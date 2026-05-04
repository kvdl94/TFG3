using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class GestionNotificaciones : UserControl
    {
        private List<Notificacion> todasLasNotificaciones = new List<Notificacion>();
        private List<Trabajador> empleados = new List<Trabajador>();
        private string filtroActual = "todas";

        public GestionNotificaciones()
        {
            InitializeComponent();
        }

        private void GestionNotificaciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private async void CargarDatos()
        {
            try
            {
                NotificacionController notifController = new NotificacionController();
                TrabajadorController trabController = new TrabajadorController();

                todasLasNotificaciones = await notifController.ObtenerTodas();
                empleados = await trabController.ObtenerTodosLosTrabajadores();

                if (todasLasNotificaciones == null) 
                  todasLasNotificaciones = new List<Notificacion>();
                if (empleados == null) 
                    empleados = new List<Trabajador>();

                ActualizarBadge();
                MostrarNotificaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ActualizarBadge()
        {
            int sinLeer = 0;
            for (int i = 0; i < todasLasNotificaciones.Count; i++)
            {
                if (!todasLasNotificaciones[i].leido) sinLeer++;
            }
            labelBadge.Text = sinLeer + " sin leer";
            labelBadge.Visible = sinLeer > 0;
        }

        private void MostrarNotificaciones()
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < todasLasNotificaciones.Count; i++)
            {
                Notificacion n = todasLasNotificaciones[i];

                if (filtroActual == "tareas" && n.tipo != "tarea") continue;
                if (filtroActual == "vacaciones" && n.tipo != "vacaciones") continue;
                if (filtroActual == "fichajes" && n.tipo != "fichaje") continue;

                
                string nombreEmpleado = "Desconocido";
                bool encontrado = false;

                for (int j = 0; j < empleados.Count && !encontrado; j++)
                {
                    if (!string.IsNullOrEmpty(n.id_remitente) && empleados[j].id == n.id_remitente)
                    {
                        nombreEmpleado = empleados[j].nombre + " " + empleados[j].apellidos;
                        encontrado = true;
                    }
                }

                
                if (!encontrado)
                {
                    for (int j = 0; j < empleados.Count && !encontrado; j++)
                    {
                        if (empleados[j].id == n.id_trabajador)
                        {
                            nombreEmpleado = empleados[j].nombre + " " + empleados[j].apellidos;
                            encontrado = true;
                        }
                    }
                }

                string fecha = n.fecha.HasValue ? n.fecha.Value.ToString("dd/MM HH:mm") : "-";
                string leida = n.leido ? "Sí" : "No";
                string punto = n.leido ? "" : "●";

                int fila = dataGridView1.Rows.Add(
                    punto,
                    n.titulo,
                    nombreEmpleado,
                    n.tipo,
                    fecha,
                    leida
                );

                dataGridView1.Rows[fila].Tag = n.id;

                if (!n.leido)
                {
                    dataGridView1.Rows[fila].DefaultCellStyle.BackColor = Color.FromArgb(255, 253, 245);
                    dataGridView1.Rows[fila].DefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);

                    dataGridView1.Rows[fila].Cells["SinLeer"].Style.ForeColor = Color.FromArgb(212, 5, 17);
                    dataGridView1.Rows[fila].Cells["SinLeer"].Style.SelectionForeColor = Color.FromArgb(212, 5, 17);
                    dataGridView1.Rows[fila].Cells["SinLeer"].Style.Font = new Font("Segoe UI", 10);
                }

                Color colorTipo = Color.FromArgb(100, 100, 100);
                if (n.tipo == "tarea") colorTipo = Color.FromArgb(24, 95, 165);
                if (n.tipo == "vacaciones") colorTipo = Color.FromArgb(21, 87, 36);
                if (n.tipo == "fichaje") colorTipo = Color.FromArgb(200, 160, 64);
                dataGridView1.Rows[fila].Cells["Tipo"].Style.ForeColor = colorTipo;

                Color colorLeida = n.leido ? Color.FromArgb(21, 87, 36) : Color.FromArgb(170, 170, 170);
                dataGridView1.Rows[fila].Cells["Leida"].Style.ForeColor = colorLeida;
            }
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            filtroActual = "todas";
            MostrarNotificaciones();
        }

        private void btnTareas_Click(object sender, EventArgs e)
        {
            filtroActual = "tareas";
            MostrarNotificaciones();
        }

        private void btnVacaciones_Click(object sender, EventArgs e)
        {
            filtroActual = "vacaciones";
            MostrarNotificaciones();
        }

        private void btnFichajes_Click(object sender, EventArgs e)
        {
            filtroActual = "fichajes";
            MostrarNotificaciones();
        }

        private async void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = (int)dataGridView1.Rows[e.RowIndex].Tag;

            NotificacionController controller = new NotificacionController();
            await controller.MarcarComoLeida(id);
            CargarDatos();
        }
    }
}