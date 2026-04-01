using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ReaLTaiizor.Controls;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class PanelCentral : Form
    {

        public PanelCentral()
        {
            InitializeComponent();
            // Quitamos AjustarBotones() para que mande el diseño del editor
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }



        private void AjustarBotones()
        {
            // Asegúrate de que el panel tenga el tamaño real antes de calcular
            panel1.PerformLayout();

            // Restamos el logo y el título. 
            // No restes iconButton6 aquí si vas a incluirlo en la división por 8 (o el número total de botones)
            int altoDisponible = panel1.Height - pictureBox2.Height - bigLabel1.Height - 40; // 40 de margen extra

            // Tienes 8 elementos (Inicio, Empleados, Gemini, Vacaciones, Tareas, Notif, Mensajes, Salir)
            int altoPorBoton = altoDisponible / 8;

            // Aplicar a todos por igual
            iconButton1.Height = altoPorBoton;
            iconButton2.Height = altoPorBoton;
            iconButtonGemini.Height = altoPorBoton; // ¡Faltaba este en tu lista!
            iconButton3.Height = altoPorBoton;
            iconButton4.Height = altoPorBoton;
            iconButton5.Height = altoPorBoton;
            iconButton7.Height = altoPorBoton;
            iconButton6.Height = altoPorBoton; // El de salir también
        }


        private void iconButton6_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {


            panelContenedor.Controls.Clear();
            GestionPlantilla vista = new GestionPlantilla();
            vista.Size = panelContenedor.Size;
            vista.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(vista);
            vista.BringToFront();





        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(dashboard);
            dashboard.BringToFront();
        }


        private async void PanelCentral_Load(object sender, EventArgs e)
        {
            await ActualizarBadgeNotificaciones();
            panelContenedor.Controls.Clear();
            Dashboard dashboard = new Dashboard();
            dashboard.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(dashboard);
            dashboard.BringToFront();
        }

        private void iconButtonGemini_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            Gemini gemini = new Gemini();
            gemini.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(gemini);
            gemini.BringToFront();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            GestionVacaciones vista = new GestionVacaciones();
            vista.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(vista);
            vista.BringToFront();
        }


        public async Task ActualizarBadgeNotificaciones()
        {
            NotificacionController notifController = new NotificacionController();
            List<Notificacion> notificaciones = await notifController.ObtenerTodas();

            int sinLeer = 0;
            for (int i = 0; i < notificaciones.Count; i++)
            {
                if (notificaciones[i].leido == false) sinLeer++;
            }

            if (sinLeer > 0)
            {
                iconButton5.Text = "Notificaciones (" + sinLeer + ")";
                iconButton5.ForeColor = Color.FromArgb(212, 5, 17);
            }
            else
            {
                iconButton5.Text = "Notificaciones";
                iconButton5.ForeColor = Color.FromArgb(170, 170, 170);
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            GestionTareas vista = new GestionTareas();
            vista.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(vista);
            vista.BringToFront();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            GestionNotificaciones vista = new GestionNotificaciones();
            vista.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(vista);
            vista.BringToFront();
        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            panelContenedor.Controls.Clear();
            GestionMensajes vista = new GestionMensajes();
            vista.Dock = DockStyle.Fill;
            panelContenedor.Controls.Add(vista);
            vista.BringToFront();
        }
    }
}
