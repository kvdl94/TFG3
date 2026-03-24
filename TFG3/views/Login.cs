using FontAwesome.Sharp;
using TFG3.Properties;
using TFG3.Controllers;
using TFG3.Modelo;
using TFG3.views;

namespace TFG3
{
    public partial class Login : Form
    {
        LoginController controlador;

        public Login()
        {
            InitializeComponent();
            controlador = new LoginController();
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            PictureBoxOjo.Image = IconChar.Eye.ToBitmap(Color.DimGray, 28);
            PictureBoxOjo.Cursor = Cursors.Hand;
            PictureBoxOjo.SizeMode = PictureBoxSizeMode.CenterImage;
            if (Settings.Default.Recordar == true)
            {
                hopeTextBox1.Text = Settings.Default.UsuarioRecordado;
                hopeCheckBox1.Checked = true;
            }



        }

        private async void nightButton1_Click(object sender, EventArgs e)
        {
            Trabajador trabajador = await controlador.ValidarAcceso(hopeTextBox1.Text, TextBoxPass.Text);

            if (trabajador == null)
            {
                MessageBox.Show("Credenciales incorrectas o nivel de acceso insuficiente.");
                return;
            }

            if (trabajador.rol != "admin")
            {
                MessageBox.Show("Credenciales incorrectas o nivel de acceso insuficiente.");
                return;
            }

            if (hopeCheckBox1.Checked)
            {
                Settings.Default.UsuarioRecordado = hopeTextBox1.Text;
                Settings.Default.Recordar = true;
            }
            else
            {
                Settings.Default.UsuarioRecordado = "";
                Settings.Default.Recordar = false;
            }

            Settings.Default.Save();

            PanelCentral panelCentral = new PanelCentral();
            panelCentral.Show();
            this.Hide();
        }

        private void PictureBoxOjo_Click(object sender, EventArgs e)
        {
            if (TextBoxPass.UseSystemPasswordChar == true)
            {
                TextBoxPass.UseSystemPasswordChar = false;
                PictureBoxOjo.Image = IconChar.EyeSlash.ToBitmap(Color.DimGray, 28);
            }
            else
            {
                TextBoxPass.UseSystemPasswordChar = true;
                PictureBoxOjo.Image = IconChar.Eye.ToBitmap(Color.DimGray, 28);
            }
        }
    }
}