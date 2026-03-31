using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GenerativeAI;
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
            labelFecha.Text = DateTime.Now.ToString("dddd, dd 'de' MMMM 'de' yyyy").ToUpper();
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

                List<Trabajador> empleados = await trabajadorController.ObtenerTodosLosTrabajadores();
                List<Departamento> departamentos = await depController.ObtenerTodos();
                List<Vacaciones> vacaciones = await vacController.ObtenerTodas();
                List<Fichaje> fichajes = await fichajeController.ObtenerTodos();

                if (empleados == null) empleados = new List<Trabajador>();
                if (departamentos == null) departamentos = new List<Departamento>();
                if (vacaciones == null) vacaciones = new List<Vacaciones>();
                if (fichajes == null) fichajes = new List<Fichaje>();

                DateTime hoy = DateTime.Today;

                // Tarjetas
                label7.Text = empleados.Count.ToString();

                int vacPendientes = 0;
                for (int i = 0; i < vacaciones.Count; i++)
                {
                    if (vacaciones[i].estado_solicitud == "pendiente")
                    {
                        vacPendientes++;
                    }
                }
                label8.Text = vacPendientes.ToString();
                label9.Text = "0";

                int fichajesHoy = 0;
                for (int i = 0; i < fichajes.Count; i++)
                {
                    if (fichajes[i].fecha.HasValue && fichajes[i].fecha.Value.Date == hoy)
                    {
                        fichajesHoy++;
                    }
                }
                label10.Text = fichajesHoy.ToString();

                // Barras de departamentos
                panelBarras.Controls.Clear();
                int maxEmpleados = 1;
                for (int i = 0; i < departamentos.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < empleados.Count; j++)
                    {
                        if (empleados[j].id_departamento == departamentos[i].id)
                        {
                            count++;
                        }
                    }
                    if (count > maxEmpleados) maxEmpleados = count;
                }

                Color[] colores = new Color[]
                {
                    Color.FromArgb(200, 160, 64),
                    Color.FromArgb(212, 5, 17),
                    Color.FromArgb(26, 26, 26),
                    Color.FromArgb(29, 158, 117)
                };

                int yPos = 10;
                int colorIndex = 0;
                for (int i = 0; i < departamentos.Count; i++)
                {
                    int count = 0;
                    for (int j = 0; j < empleados.Count; j++)
                    {
                        if (empleados[j].id_departamento == departamentos[i].id)
                        {
                            count++;
                        }
                    }
                    if (count == 0) continue;

                    Label labelDep = new Label();
                    labelDep.Text = departamentos[i].nombre_dep;
                    labelDep.ForeColor = Color.FromArgb(136, 136, 136);
                    labelDep.Font = new Font("Segoe UI", 9);
                    labelDep.Location = new Point(5, yPos);
                    labelDep.Size = new Size(120, 18);
                    panelBarras.Controls.Add(labelDep);

                    Panel barra = new Panel();
                    int anchoMax = panelBarras.Width - 160;
                    barra.Size = new Size((count * anchoMax) / maxEmpleados, 14);
                    barra.Location = new Point(130, yPos + 2);
                    barra.BackColor = colores[colorIndex % colores.Length];
                    panelBarras.Controls.Add(barra);

                    Label labelCount = new Label();
                    labelCount.Text = count.ToString();
                    labelCount.ForeColor = Color.FromArgb(51, 51, 51);
                    labelCount.Font = new Font("Segoe UI", 9);
                    labelCount.Location = new Point(barra.Right + 5, yPos);
                    labelCount.AutoSize = true;
                    panelBarras.Controls.Add(labelCount);

                    yPos += 30;
                    colorIndex++;
                }

                // Fichajes de hoy
                panelFichajes2.Controls.Clear();
                int yFichaje = 5;
                for (int i = 0; i < fichajes.Count; i++)
                {
                    if (!fichajes[i].fecha.HasValue || fichajes[i].fecha.Value.Date != hoy) continue;

                    string nombreEmpleado = "Desconocido";
                    string iniciales = "??";
                    bool tardeLlegada = false;

                    for (int j = 0; j < empleados.Count; j++)
                    {
                        if (empleados[j].id == fichajes[i].id_trabajador)
                        {
                            nombreEmpleado = empleados[j].nombre + " " + empleados[j].apellidos;
                            iniciales = empleados[j].nombre[0].ToString() + empleados[j].apellidos[0].ToString();
                            break;
                        }
                    }

                    Panel fila = new Panel();
                    fila.Size = new Size(panelFichajes2.ClientSize.Width - 15, 45);
                    fila.Location = new Point(5, yFichaje);
                    fila.BackColor = Color.FromArgb(249, 249, 249);

                    Panel avatar = new Panel();
                    avatar.Size = new Size(32, 32);
                    avatar.Location = new Point(8, 6);
                    avatar.BackColor = Color.FromArgb(26, 26, 26);

                    Label lblIniciales = new Label();
                    lblIniciales.Text = iniciales.ToUpper();
                    lblIniciales.ForeColor = Color.FromArgb(200, 160, 64);
                    lblIniciales.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                    lblIniciales.TextAlign = ContentAlignment.MiddleCenter;
                    lblIniciales.Dock = DockStyle.Fill;
                    avatar.Controls.Add(lblIniciales);
                    fila.Controls.Add(avatar);

                    Label lblNombre = new Label();
                    lblNombre.Text = nombreEmpleado;
                    lblNombre.ForeColor = Color.FromArgb(51, 51, 51);
                    lblNombre.Font = new Font("Segoe UI", 9);
                    lblNombre.Location = new Point(48, 5);
                    lblNombre.AutoSize = true;
                    fila.Controls.Add(lblNombre);

                    string horaEntrada = fichajes[i].hora_entrada.HasValue ? fichajes[i].hora_entrada.Value.ToString(@"hh\:mm") : "-";
                    Label lblHora = new Label();
                    lblHora.Text = "Entrada " + horaEntrada;
                    lblHora.ForeColor = Color.FromArgb(136, 136, 136);
                    lblHora.Font = new Font("Segoe UI", 8);
                    lblHora.Location = new Point(48, 22);
                    lblHora.AutoSize = true;
                    fila.Controls.Add(lblHora);

                    Panel bordeIzq = new Panel();
                    bordeIzq.Size = new Size(3, 45);
                    bordeIzq.Location = new Point(0, 0);
                    bordeIzq.BackColor = tardeLlegada ? Color.FromArgb(212, 5, 17) : Color.FromArgb(29, 158, 117);
                    fila.Controls.Add(bordeIzq);

                    panelFichajes2.Controls.Add(fila);
                    yFichaje += 52;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }
}