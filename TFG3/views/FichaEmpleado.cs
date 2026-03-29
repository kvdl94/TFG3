using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class FichaEmpleado : Form
    {
        private bool esNuevo = false;
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

        public FichaEmpleado(GestionPlantilla gestion)
        {
            InitializeComponent();
            this.gestionPlantilla = gestion;
            this.esNuevo = true;
            this.Load += (s, e) => { this.ActiveControl = null; };
            labelNombre.Text = "Nuevo empleado";
            labelRol.Text = "Sin asignar";
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

            bool encontradoRol = false;
            int i = 0;

            while (i < ComboBoxRol.Items.Count && encontradoRol == false)
            {
                if (ComboBoxRol.Items[i].ToString().Trim() == trabajador.rol.Trim())
                {
                    ComboBoxRol.SelectedIndex = i;
                    encontradoRol = true;
                }
                i++;
            }

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

        private async void iconButton1_Click(object sender, EventArgs e)
        {
            trabajador.dni = textBoxDNI.Text;

            trabajador.telefono = textBoxTelefono.Text;
            trabajador.rol = ComboBoxRol.SelectedItem.ToString();
            trabajador.dias_vacaciones = int.Parse(textBoxVacaciones.Text);

            TrabajadorController controller = new TrabajadorController();
            await controller.ActualizarTrabajador(trabajador);
            await gestionPlantilla.Recargar();
            this.Close();
        }

        private void iconButtonInforme_Click(object sender, EventArgs e)
        {
            Departamento dep = null;
            bool encontrado = false;
            int i = 0;
            while (i < departamentos.Count && encontrado == false)
            {
                if (departamentos[i].id == trabajador.id_departamento)
                {
                    dep = departamentos[i];
                    encontrado = true;
                }
                i++;
            }

            if (dep == null)
            {
                MessageBox.Show("El empleado no tiene departamento asignado.");
                return;
            }

            InformeFichajes informe = new InformeFichajes(trabajador, dep);
            informe.ShowDialog();
        }
    }
}