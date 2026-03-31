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

namespace TFG3.views
{
    public partial class PanelCentral : Form
    {

        public PanelCentral()
        {

            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            AjustarBotones();


        }


        private void AjustarBotones()
        {
            int altoDisponible = panel1.Height - pictureBox2.Height - bigLabel1.Height - iconButton6.Height;
            int altoPorBoton = altoDisponible / 5;

            iconButton1.Height = altoPorBoton;
            iconButton2.Height = altoPorBoton;
            iconButton3.Height = altoPorBoton;
            iconButton4.Height = altoPorBoton;
            iconButton5.Height = altoPorBoton;
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


        private void PanelCentral_Load(object sender, EventArgs e)
        {
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
    }
}
