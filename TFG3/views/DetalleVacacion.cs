using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class DetalleVacacion : Form
    {
        private Vacaciones vacacion;
        private string nombreEmpleado;
        private GestionVacaciones gestionVacaciones;
        private List<Vacaciones> todasLasVacaciones;
        private List<Trabajador> empleados;

        public DetalleVacacion(Vacaciones vacacion, string nombreEmpleado, GestionVacaciones gestion)
        {
            InitializeComponent();
            this.vacacion = vacacion;
            this.nombreEmpleado = nombreEmpleado;
            this.gestionVacaciones = gestion;
        }

        private void DetalleVacacion_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private async void CargarDatos()
        {
            VacacionesController vacController = new VacacionesController();
            TrabajadorController trabController = new TrabajadorController();
            todasLasVacaciones = await vacController.ObtenerTodas();
            empleados = await trabController.ObtenerTodosLosTrabajadores();

            // Panel superior
            labelNombre.Text = nombreEmpleado;
            

            // Estado
            if (vacacion.estado_solicitud == "pendiente")
            {
                labelEstado.Text = "PENDIENTE";
                labelEstado.ForeColor = Color.FromArgb(133, 100, 4);
                labelEstado.BackColor = Color.FromArgb(255, 243, 205);
            }
            else if (vacacion.estado_solicitud == "aprobada")
            {
                labelEstado.Text = "APROBADA";
                labelEstado.ForeColor = Color.FromArgb(21, 87, 36);
                labelEstado.BackColor = Color.FromArgb(212, 237, 218);
                iconButtonAprobar.Visible = false;
                iconButtonRechazar.Visible = true;
            }
            else
            {
                labelEstado.Text = "RECHAZADA";
                labelEstado.ForeColor = Color.White;
                labelEstado.BackColor = Color.FromArgb(212, 5, 17);
                iconButtonAprobar.Visible = true;
                iconButtonRechazar.Visible = false;

            }

            // Fechas
            labelDesde.Text = vacacion.fecha_inicio.HasValue ? vacacion.fecha_inicio.Value.ToString("dd/MM/yyyy") : "-";
            labelHasta.Text = vacacion.fecha_fin.HasValue ? vacacion.fecha_fin.Value.ToString("dd/MM/yyyy") : "-";

            int dias = 0;
            if (vacacion.fecha_inicio.HasValue && vacacion.fecha_fin.HasValue)
            {
                dias = (int)(vacacion.fecha_fin.Value - vacacion.fecha_inicio.Value).TotalDays + 1;
            }
            labelDias.Text = dias + " días";

            // Motivo
            labelMotivo.Text = vacacion.motivo ?? "Sin motivo";

            // Disponibilidad
            int empleadosDeVacaciones = 0;
            int totalEmpleados = empleados.Count;

            for (int i = 0; i < todasLasVacaciones.Count; i++)
            {
                Vacaciones v = todasLasVacaciones[i];
                if (v.id == vacacion.id) continue;
                if (v.estado_solicitud != "aprobada") continue;
                if (!v.fecha_inicio.HasValue || !v.fecha_fin.HasValue) continue;
                if (!vacacion.fecha_inicio.HasValue || !vacacion.fecha_fin.HasValue) continue;

                bool solapan = v.fecha_inicio.Value <= vacacion.fecha_fin.Value &&
                               v.fecha_fin.Value >= vacacion.fecha_inicio.Value;

                if (solapan) empleadosDeVacaciones++;
            }

            double porcentaje = totalEmpleados > 0 ? (double)empleadosDeVacaciones / totalEmpleados * 100 : 0;

            if (porcentaje < 20)
            {
             
                labelDisponibilidad.Text = "Alta disponibilidad";
                labelDisponibilidad.ForeColor = Color.FromArgb(21, 87, 36);
                labelDetalleDisponibilidad.Text = empleadosDeVacaciones + " de " + totalEmpleados + " empleados de vacaciones esas fechas";
                labelDetalleDisponibilidad.ForeColor = Color.FromArgb(21, 87, 36);
            }
            else if (porcentaje < 50)
            {
                
                labelDisponibilidad.Text = "Media disponibilidad";
                labelDisponibilidad.ForeColor = Color.FromArgb(133, 100, 4);
                labelDetalleDisponibilidad.Text = empleadosDeVacaciones + " de " + totalEmpleados + " empleados de vacaciones esas fechas";
                labelDetalleDisponibilidad.ForeColor = Color.FromArgb(133, 100, 4);
            }
            else
            {
              
                labelDisponibilidad.Text = "Baja disponibilidad";
                labelDisponibilidad.ForeColor = Color.FromArgb(114, 28, 36);
                labelDetalleDisponibilidad.Text = empleadosDeVacaciones + " de " + totalEmpleados + " empleados de vacaciones esas fechas";
                labelDetalleDisponibilidad.ForeColor = Color.FromArgb(114, 28, 36);
            }

          
        }

        private async void btnAprobar_Click(object sender, EventArgs e)
        {
            VacacionesController controller = new VacacionesController();
            await controller.AprobarVacacion(vacacion.id);
            await gestionVacaciones.Recargar();
            this.Close();
        }

        private async void btnRechazar_Click(object sender, EventArgs e)
        {
            string motivo = Microsoft.VisualBasic.Interaction.InputBox(
                "¿Motivo del rechazo?",
                "Rechazar vacaciones",
                ""
            );

            if (motivo == "") return;

            VacacionesController controller = new VacacionesController();
            await controller.RechazarVacacion(vacacion.id, motivo);
            await gestionVacaciones.Recargar();
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


      





    }
}