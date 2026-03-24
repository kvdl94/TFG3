using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class FichaEmpleado : Form
    {
        private Trabajador trabajador;
        private List<Departamento> departamentos = new List<Departamento>();
        private GestionPlantilla gestionPlantilla;
        public FichaEmpleado(Trabajador trabajador, GestionPlantilla gestion)
        {
            InitializeComponent();
            this.gestionPlantilla = gestion;
            this.trabajador = trabajador;
            this.Load += (s, e) => { this.ActiveControl = null; };
            CargarDatos();
        }

        private async void CargarDatos()
        {
            DepartamentoController depController = new DepartamentoController();
            departamentos = await depController.ObtenerTodos();

            labelNombre.Text = trabajador.nombre + " " + trabajador.apellidos;
            labelRol.Text = trabajador.rol.ToUpper() + " · Nº " + trabajador.email.Replace("@dhl.com", "");

            textBoxDNI.Text = trabajador.dni;
            textBoxEmail.Text = trabajador.email;
            textBoxTelefono.Text = trabajador.telefono;
            textBoxVacaciones.Text = trabajador.dias_vacaciones.ToString();
            textBoxAntigüedad.Text = (DateTime.Now.Year - trabajador.created_at.Value.Year) + " años";

            if (trabajador.foto_url != null && trabajador.foto_url != "")
            {
                pictureBox1.Load(trabajador.foto_url);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }

            if (trabajador.id_departamento != null)
            {
                bool encontrado = false;
                int j = 0;
                while (j < departamentos.Count && encontrado == false)
                {
                    if (departamentos[j].id == trabajador.id_departamento)
                    {
                        textBoxDepartamento.Text = departamentos[j].nombre_dep;
                        encontrado = true;
                    }
                    j++;
                }
            }
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
                "¿Estás seguro de que quieres eliminar a " + trabajador.nombre + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (resultado == DialogResult.Yes)
            {
                TrabajadorController controller = new TrabajadorController();
                await controller.EliminarTrabajador(trabajador.id);
                await gestionPlantilla.Recargar();
                this.Close();
            }
        }

    }
}