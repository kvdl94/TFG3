using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using iText.Html2pdf;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class InformeFichajes : Form
    {
        private Trabajador trabajador;
        private Departamento departamento;
        private List<Fichaje> fichajes = new List<Fichaje>();

        public InformeFichajes(Trabajador trabajador, Departamento departamento)
        {
            InitializeComponent();
            this.trabajador = trabajador;
            this.departamento = departamento;
        }

        private void InformeFichajes_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private async void CargarDatos()
        {
            // Datos del empleado en panel superior
            labelNombre.Text = trabajador.nombre + " " + trabajador.apellidos;
            labelDepartamento.Text = departamento.nombre_dep + " · " + trabajador.rol;
            labelMes.Text = DateTime.Now.ToString("MMMM yyyy").ToUpper();

            // Iniciales en pictureBox
            string iniciales = trabajador.nombre[0].ToString() + trabajador.apellidos[0].ToString();
            // Las iniciales las ponemos con un label encima del pictureBox

            // Cargar fichajes del último mes
            FichajeController controller = new FichajeController();
            fichajes = await controller.ObtenerFichajesPorEmpleado(trabajador.id);
            MessageBox.Show("ID trabajador: " + trabajador.id);


            // Filtrar solo el mes actual
            List<Fichaje> fichajesMes = new List<Fichaje>();
            for (int i = 0; i < fichajes.Count; i++)
            {
                if (fichajes[i].fecha.HasValue)
                {
                    if (fichajes[i].fecha.Value.Month == DateTime.Now.Month &&
                        fichajes[i].fecha.Value.Year == DateTime.Now.Year)
                    {
                        fichajesMes.Add(fichajes[i]);
                    }
                }
            }

            // Calcular estadísticas
            int diasTrabajados = fichajesMes.Count;
            int retrasos = 0;
            int salidasTarde = 0;

            TimeSpan horaEntradaEst = TimeSpan.Parse(departamento.hora_entrada_est);
            TimeSpan horaSalidaEst = TimeSpan.Parse(departamento.hora_salida_est);

            dataGridViewFichajes.Rows.Clear();

            for (int i = 0; i < fichajesMes.Count; i++)
            {
                Fichaje f = fichajesMes[i];
                string retraso = "-";
                string estado = "Puntual";
                Color colorEstado = Color.FromArgb(29, 158, 117);

                if (f.hora_entrada.HasValue && f.hora_entrada.Value > horaEntradaEst)
                {
                    TimeSpan diff = f.hora_entrada.Value - horaEntradaEst;
                    int horas = (int)diff.TotalHours;
                    int minutos = diff.Minutes;

                    if (horas > 0)
                    {
                        retraso = "+" + horas + "h " + minutos + "min";
                    }
                    else
                    {
                        retraso = "+" + minutos + " min";
                    }

                    estado = "Tarde";
                    colorEstado = Color.FromArgb(212, 5, 17);
                    retrasos++;
                }

                if (f.hora_salida.HasValue && f.hora_salida.Value > horaSalidaEst)
                {
                    salidasTarde++;
                }

                dataGridViewFichajes.Rows.Add(
                    f.fecha.Value.ToString("dd/MM/yyyy"),
                    f.hora_entrada.HasValue ? f.hora_entrada.Value.ToString(@"hh\:mm") : "-",
                    f.hora_salida.HasValue ? f.hora_salida.Value.ToString(@"hh\:mm") : "-",
                    retraso,
                    estado
                );

                dataGridViewFichajes.Rows[i].Cells["Estado"].Style.ForeColor = colorEstado;
            }

            // Actualizar estadísticas
            labelDias.Text = diasTrabajados.ToString();
            labelRetrasos.Text = retrasos.ToString();
            labelSalidas.Text = salidasTarde.ToString();

            if (diasTrabajados > 0)
            {
                int puntualidad = ((diasTrabajados - retrasos) * 100) / diasTrabajados;
                labelPuntualidad.Text = puntualidad + "%";
            }
            else
            {
                labelPuntualidad.Text = "0%";
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButtonImprimir_Click(object sender, EventArgs e)
        {
            string filas = "";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string estado = dataGridView1.Rows[i].Cells[4].Value?.ToString();
                string clase = estado == "Tarde" ? "tarde" : "puntual";
                filas += $"<tr><td>{dataGridView1.Rows[i].Cells[0].Value}</td><td>{dataGridView1.Rows[i].Cells[1].Value}</td><td>{dataGridView1.Rows[i].Cells[2].Value}</td><td class='{clase}'>{dataGridView1.Rows[i].Cells[3].Value}</td><td class='{clase}'>{estado}</td></tr>";
            }

            string html = $@"
    <html><head><style>
        body {{ font-family: Arial; margin: 40px; }}
        .cabecera {{ background: #1a1a1a; color: white; padding: 20px; margin-bottom: 0; }}
        .titulo {{ color: #c8a040; font-size: 20px; font-weight: bold; }}
        .subtitulo {{ color: #888; font-size: 12px; margin-top: 5px; }}
        .stats {{ display: flex; gap: 40px; padding: 15px 20px; background: #f8f8f8; margin-bottom: 20px; }}
        .stat p {{ margin: 0; }}
        .stat-titulo {{ color: #888; font-size: 10px; }}
        .stat-valor {{ font-size: 22px; font-weight: bold; color: #1a1a1a; }}
        .rojo {{ color: #D40511; }}
        .dorado {{ color: #c8a040; }}
        table {{ width: 100%; border-collapse: collapse; }}
        th {{ background: #1a1a1a; color: #c8a040; padding: 8px; text-align: left; font-size: 11px; }}
        td {{ padding: 8px; border-bottom: 1px solid #eee; font-size: 11px; }}
        tr:nth-child(even) {{ background: #f9f9f9; }}
        .tarde {{ color: #D40511; }}
        .puntual {{ color: #1D9E75; }}
    </style></head><body>
        <div class='cabecera'>
            <div class='titulo'>INFORME DE FICHAJES</div>
            <div class='subtitulo'>{trabajador.nombre} {trabajador.apellidos} · {departamento.nombre_dep} · {DateTime.Now.ToString("MMMM yyyy").ToUpper()}</div>
        </div>
        <div class='stats'>
            <div class='stat'><p class='stat-titulo'>DÍAS TRABAJADOS</p><p class='stat-valor'>{labelDias.Text}</p></div>
            <div class='stat'><p class='stat-titulo'>RETRASOS</p><p class='stat-valor rojo'>{labelRetrasos.Text}</p></div>
            <div class='stat'><p class='stat-titulo'>SALIDAS TARDE</p><p class='stat-valor dorado'>{labelSalidas.Text}</p></div>
            <div class='stat'><p class='stat-titulo'>PUNTUALIDAD</p><p class='stat-valor'>{labelPuntualidad.Text}</p></div>
        </div>
        <table>
            <tr><th>Fecha</th><th>Entrada</th><th>Salida</th><th>Retraso</th><th>Estado</th></tr>
            {filas}
        </table>
    </body></html>";

            SaveFileDialog dialogo = new SaveFileDialog();
            dialogo.Filter = "PDF|*.pdf";
            dialogo.FileName = "Informe_" + trabajador.nombre + "_" + DateTime.Now.ToString("MMyyyy");

            if (dialogo.ShowDialog() == DialogResult.OK)
            {
                using (FileStream stream = new FileStream(dialogo.FileName, FileMode.Create))
                {
                    HtmlConverter.ConvertToPdf(html, stream);
                }
                MessageBox.Show("PDF guardado correctamente.");
            }
        }
    }
}