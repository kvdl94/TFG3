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
           
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
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
