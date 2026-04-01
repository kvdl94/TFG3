using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class GestionVacaciones : UserControl
    {
        private List<Vacaciones> todasLasVacaciones = new List<Vacaciones>();
        private List<Trabajador> empleados = new List<Trabajador>();
        private string filtroActual = "todas";

        public GestionVacaciones()
        {
            InitializeComponent();
        }

        private void GestionVacaciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private async void CargarDatos()
        {
            try
            {
                VacacionesController vacController = new VacacionesController();
                TrabajadorController trabController = new TrabajadorController();

                todasLasVacaciones = await vacController.ObtenerTodas();
                empleados = await trabController.ObtenerTodosLosTrabajadores();

                if (todasLasVacaciones == null) todasLasVacaciones = new List<Vacaciones>();
                if (empleados == null) empleados = new List<Trabajador>();

                MostrarVacaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MostrarVacaciones()
        {
            dataGridView1.Rows.Clear();

            for (int i = 0; i < todasLasVacaciones.Count; i++)
            {
                Vacaciones v = todasLasVacaciones[i];

                if (filtroActual == "pendientes" && v.estado_solicitud != "pendiente") continue;
                if (filtroActual == "aprobadas" && v.estado_solicitud != "aprobada") continue;
                if (filtroActual == "rechazadas" && v.estado_solicitud != "rechazada") continue;


                string nombreEmpleado = "Desconocido";
                for (int j = 0; j < empleados.Count; j++)
                {
                    if (empleados[j].id == v.id_trabajador)
                    {
                        nombreEmpleado = empleados[j].nombre + " " + empleados[j].apellidos;
                        break;
                    }
                }

                string fechaInicio = v.fecha_inicio.HasValue ? v.fecha_inicio.Value.ToString("dd/MM/yyyy") : "-";
                string fechaFin = v.fecha_fin.HasValue ? v.fecha_fin.Value.ToString("dd/MM/yyyy") : "-";

                int dias = 0;
                if (v.fecha_inicio.HasValue && v.fecha_fin.HasValue)
                {
                    dias = (int)(v.fecha_fin.Value - v.fecha_inicio.Value).TotalDays + 1;
                }

                dataGridView1.Rows.Add(nombreEmpleado, fechaInicio, fechaFin, dias + " días", v.estado_solicitud);

                // Color del estado
                Color colorEstado = Color.FromArgb(51, 51, 51);
                if (v.estado_solicitud == "pendiente") colorEstado = Color.FromArgb(133, 100, 4);
                if (v.estado_solicitud == "aprobada") colorEstado = Color.FromArgb(21, 87, 36);
                if (v.estado_solicitud == "rechazada") colorEstado = Color.FromArgb(212, 5, 17);

                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["Estado"].Style.ForeColor = colorEstado;
            }
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            filtroActual = "todas";
            MostrarVacaciones();
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            filtroActual = "pendientes";
            MostrarVacaciones();
        }

        private void btnAprobadas_Click(object sender, EventArgs e)
        {
            filtroActual = "aprobadas";
            MostrarVacaciones();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Vacaciones vac = todasLasVacaciones[e.RowIndex];
            string nombreEmpleado = "Desconocido";

            for (int j = 0; j < empleados.Count; j++)
            {
                if (empleados[j].id == vac.id_trabajador)
                {
                    nombreEmpleado = empleados[j].nombre + " " + empleados[j].apellidos;
                    break;
                }
            }

            DetalleVacacion detalle = new DetalleVacacion(vac, nombreEmpleado, this);
            detalle.ShowDialog();
        }

        public async Task Recargar()
        {
            VacacionesController vacController = new VacacionesController();
            TrabajadorController trabController = new TrabajadorController();

            todasLasVacaciones = await vacController.ObtenerTodas();
            empleados = await trabController.ObtenerTodosLosTrabajadores();


            if (todasLasVacaciones == null) todasLasVacaciones = new List<Vacaciones>();
            if (empleados == null) empleados = new List<Trabajador>();

            Form panelCentral = Application.OpenForms["PanelCentral"];

            if (panelCentral != null)
            {
                await ((PanelCentral)panelCentral).ActualizarBadgeNotificaciones();
            }




            MostrarVacaciones();
        }

        private void iconButtonRechazadas_Click(object sender, EventArgs e)
        {
            filtroActual = "rechazadas";
            MostrarVacaciones();
        }
    }
}