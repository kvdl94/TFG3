using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class Dashboard : UserControl
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            labelTitulo.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy").ToUpper();
            CargarDatos();
        }

        private async void CargarDatos()
        {
            try
            {
                TrabajadorController trabajadorController = new TrabajadorController();
                DepartamentoController depController = new DepartamentoController();
                VacacionesController vacController = new VacacionesController();
                FichajeController fichajeController = new FichajeController();
                TareaController tareaController = new TareaController();

                List<Trabajador> empleados = await trabajadorController.ObtenerTodosLosTrabajadores() ?? new List<Trabajador>();
                List<Departamento> departamentos = await depController.ObtenerTodos() ?? new List<Departamento>();
                List<Vacaciones> vacaciones = await vacController.ObtenerTodas() ?? new List<Vacaciones>();
                List<Fichaje> fichajes = await fichajeController.ObtenerTodos() ?? new List<Fichaje>();
                List<Tarea> tareas = await tareaController.ObtenerTodas() ?? new List<Tarea>();

                DateTime hoy = DateTime.Today;

                label7.Text = empleados.Count.ToString();

                int vacPendientes = 0;
                foreach (var v in vacaciones)
                {
                    if (v.estado_solicitud == "pendiente") vacPendientes++;
                }
                label8.Text = vacPendientes.ToString();

                int tareasPendientes = 0, enProgreso = 0, completadas = 0, canceladas = 0;
                foreach (var t in tareas)
                {
                    if (t.estado == "pendiente") tareasPendientes++;
                    else if (t.estado == "en_progreso") enProgreso++;
                    else if (t.estado == "completada") completadas++;
                    else if (t.estado == "cancelada") canceladas++;
                }
                label9.Text = tareasPendientes.ToString();

                int fichajesHoy = 0;
                foreach (var f in fichajes)
                {
                    if (f.fecha.HasValue && f.fecha.Value.Date == hoy) fichajesHoy++;
                }
                label10.Text = fichajesHoy.ToString();

                panelBarras.Controls.Clear();
                int maxEmpleados = 1;
                foreach (var d in departamentos)
                {
                    int count = empleados.FindAll(emp => emp.id_departamento == d.id).Count;
                    if (count > maxEmpleados) maxEmpleados = count;
                }

                Color[] colores = {
                    Color.FromArgb(200, 160, 64),
                    Color.FromArgb(212, 5, 17),
                    Color.FromArgb(26, 26, 26),
                    Color.FromArgb(29, 158, 117)
                };

                int yPos = 25;
                int colorIndex = 0;

                foreach (var d in departamentos)
                {
                    int count = empleados.FindAll(emp => emp.id_departamento == d.id).Count;
                    if (count == 0) continue;

                    Label labelDep = new Label
                    {
                        Text = d.nombre_dep,
                        ForeColor = Color.FromArgb(136, 136, 136),
                        Font = new Font("Segoe UI", 9),
                        Location = new Point(5, yPos),
                        Size = new Size(120, 18)
                    };
                    panelBarras.Controls.Add(labelDep);

                    Panel barra = new Panel();
                    int anchoMax = panelBarras.Width - 160;
                    barra.Size = new Size((count * anchoMax) / maxEmpleados, 14);
                    barra.Location = new Point(130, yPos + 2);
                    barra.BackColor = colores[colorIndex % colores.Length];
                    panelBarras.Controls.Add(barra);

                    Label labelCount = new Label
                    {
                        Text = count.ToString(),
                        ForeColor = Color.FromArgb(51, 51, 51),
                        Font = new Font("Segoe UI", 9),
                        Location = new Point(barra.Right + 5, yPos),
                        AutoSize = true
                    };
                    panelBarras.Controls.Add(labelCount);

                    yPos += 35;
                    colorIndex++;
                }

                yPos += 60;

                Label labelTituloTareas = new Label
                {
                    Text = "Tareas por estado",
                    ForeColor = Color.Black,
                    Font = new Font("Segoe UI", 12, FontStyle.Bold),
                    Location = new Point(5, yPos),
                    AutoSize = true
                };
                panelBarras.Controls.Add(labelTituloTareas);

                yPos += 45;

                int maxTareas = Math.Max(Math.Max(tareasPendientes, enProgreso), Math.Max(completadas, canceladas));
                if (maxTareas == 0) maxTareas = 1;

                string[] estadosTareas = { "Pendiente", "En progreso", "Completada", "Cancelada" };
                int[] valoresTareas = { tareasPendientes, enProgreso, completadas, canceladas };
                Color[] coloresTareas = {
                    Color.FromArgb(200, 160, 64),
                    Color.FromArgb(24, 95, 165),
                    Color.FromArgb(29, 158, 117),
                    Color.FromArgb(212, 5, 17)
                };

                for (int i = 0; i < estadosTareas.Length; i++)
                {
                    Label labelEstado = new Label
                    {
                        Text = estadosTareas[i],
                        ForeColor = Color.FromArgb(136, 136, 136),
                        Font = new Font("Segoe UI", 9),
                        Location = new Point(5, yPos),
                        Size = new Size(120, 18) // Aumentado para que no se corte "Completada"
                    };
                    panelBarras.Controls.Add(labelEstado);

                    Panel barraT = new Panel();
                    int anchoMax2 = panelBarras.Width - 170; // Ajustado para dar espacio al label más largo
                    int anchoBarra = (valoresTareas[i] * anchoMax2) / maxTareas;
                    if (anchoBarra < 1) anchoBarra = 1;

                    barraT.Size = new Size(anchoBarra, 14);
                    barraT.Location = new Point(130, yPos + 2); // Movido a la derecha para alinear con departamentos
                    barraT.BackColor = coloresTareas[i];
                    panelBarras.Controls.Add(barraT);

                    Label labelCount2 = new Label
                    {
                        Text = valoresTareas[i].ToString(),
                        ForeColor = Color.FromArgb(51, 51, 51),
                        Font = new Font("Segoe UI", 9),
                        Location = new Point(barraT.Right + 5, yPos),
                        AutoSize = true
                    };
                    panelBarras.Controls.Add(labelCount2);

                    yPos += 35;
                }

                panelFichajes2.Controls.Clear();
                int yFichaje = 10;
                foreach (var f in fichajes)
                {
                    if (!f.fecha.HasValue || f.fecha.Value.Date != hoy) continue;

                    string nombreEmpleado = "Desconocido";
                    string iniciales = "??";

                    var emp = empleados.Find(e => e.id == f.id_trabajador);
                    if (emp != null)
                    {
                        nombreEmpleado = emp.nombre + " " + emp.apellidos;
                        iniciales = emp.nombre[0].ToString() + emp.apellidos[0].ToString();
                    }

                    Panel fila = new Panel
                    {
                        Size = new Size(panelFichajes2.ClientSize.Width - 15, 45),
                        Location = new Point(5, yFichaje),
                        BackColor = Color.FromArgb(249, 249, 249)
                    };

                    Panel avatar = new Panel
                    {
                        Size = new Size(32, 32),
                        Location = new Point(8, 6),
                        BackColor = Color.FromArgb(26, 26, 26)
                    };

                    Label lblIniciales = new Label
                    {
                        Text = iniciales.ToUpper(),
                        ForeColor = Color.FromArgb(200, 160, 64),
                        Font = new Font("Segoe UI", 8, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };
                    avatar.Controls.Add(lblIniciales);
                    fila.Controls.Add(avatar);

                    Label lblNombre = new Label
                    {
                        Text = nombreEmpleado,
                        ForeColor = Color.FromArgb(51, 51, 51),
                        Font = new Font("Segoe UI", 9),
                        Location = new Point(48, 5),
                        AutoSize = true
                    };
                    fila.Controls.Add(lblNombre);

                    string horaEntrada = f.hora_entrada.HasValue ? f.hora_entrada.Value.ToString(@"hh\:mm") : "-";
                    Label lblHora = new Label
                    {
                        Text = "Entrada " + horaEntrada,
                        ForeColor = Color.FromArgb(136, 136, 136),
                        Font = new Font("Segoe UI", 8),
                        Location = new Point(48, 22),
                        AutoSize = true
                    };
                    fila.Controls.Add(lblHora);

                    Panel bordeIzq = new Panel
                    {
                        Size = new Size(3, 45),
                        Location = new Point(0, 0),
                        BackColor = Color.FromArgb(29, 158, 117)
                    };
                    fila.Controls.Add(bordeIzq);

                    panelFichajes2.Controls.Add(fila);
                    yFichaje += 55;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}