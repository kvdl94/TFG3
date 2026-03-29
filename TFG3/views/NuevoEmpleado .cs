using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class NuevoEmpleado : Form
    {
        private int pasoActual = 1;
        private GestionPlantilla gestionPlantilla;
        private List<Departamento> departamentos = new List<Departamento>();

        public NuevoEmpleado(GestionPlantilla gestion)
        {
            InitializeComponent();
            this.gestionPlantilla = gestion;
        }

        private async void NuevoEmpleado_Load(object sender, EventArgs e)
        {
            this.ActiveControl = null;
            await CargarDepartamentos();
        }

        private async Task CargarDepartamentos()
        {
            try
            {
                DepartamentoController depController = new DepartamentoController();
                departamentos = await depController.ObtenerTodos();
                

                hopeComboBoxDepartamento.Items.Clear();
                for (int i = 0; i < departamentos.Count; i++)
                {
                    hopeComboBoxDepartamento.Items.Add(departamentos[i].nombre_dep);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ActualizarBarras()
        {
            panelPaso1.Visible = false;
            panelPaso2.Visible = false;
            panelPaso3.Visible = false;

            if (pasoActual == 1)
            {
                panelPaso1.Visible = true;
                panelBarra1.BackColor = ColorTranslator.FromHtml("#c8a040");
                panelBarra2.BackColor = ColorTranslator.FromHtml("#333333");
                panelBarra3.BackColor = ColorTranslator.FromHtml("#333333");
                labelPaso.Text = "PASO 1 DE 3 — DATOS PERSONALES";
            }

            if (pasoActual == 2)
            {
                panelPaso2.Visible = true;
                panelBarra1.BackColor = ColorTranslator.FromHtml("#c8a040");
                panelBarra2.BackColor = ColorTranslator.FromHtml("#c8a040");
                panelBarra3.BackColor = ColorTranslator.FromHtml("#333333");
                labelPaso.Text = "PASO 2 DE 3 — ACCESO Y ROL";
            }

            if (pasoActual == 3)
            {
                panelPaso3.Visible = true;
                panelBarra1.BackColor = ColorTranslator.FromHtml("#c8a040");
                panelBarra2.BackColor = ColorTranslator.FromHtml("#c8a040");
                panelBarra3.BackColor = ColorTranslator.FromHtml("#c8a040");
                labelPaso.Text = "PASO 3 DE 3 — CONTRASEÑA";
            }
        }

        private  async void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (pasoActual == 1)
            {
                if (hopeTextBoxNombre.Text == "" || hopeTextBoxApellido.Text == "" || hopeTextBoxDni.Text == "")
                {
                    MessageBox.Show("Rellena todos los campos obligatorios.");
                    return;
                }

                if (ValidarDNI(hopeTextBoxDni.Text) == false)
                {
                    MessageBox.Show("El DNI no es válido.");
                    return;
                }



                await CargarDepartamentos();
                await CalcularNumeroEmpleado();
            }

            if (pasoActual == 2)
            {
                if (hopeTextBoxNEmpleado.Text == "" || hopeComboBoxRol.SelectedItem == null || hopeComboBoxDepartamento.SelectedItem == null)
                {
                    MessageBox.Show("Rellena todos los campos obligatorios.");
                    return;
                }
            }

            pasoActual++;
            ActualizarBarras();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            pasoActual--;
            ActualizarBarras();
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {

            if (hopeTextBoxContraseña1.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres.");
                return;
            }



            if (hopeTextBoxContraseña1.Text == "")
            {
                MessageBox.Show("Introduce una contraseña.");
                return;
            }

            if (hopeTextBoxContraseña1.Text != hopeTextBoxContraseña2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            Trabajador nuevo = new Trabajador();
            nuevo.nombre = hopeTextBoxNombre.Text;
            nuevo.apellidos = hopeTextBoxApellido.Text;
            nuevo.dni = hopeTextBoxDni.Text;
            nuevo.telefono = hopeTextBoxTelefono.Text;
            nuevo.rol = hopeComboBoxRol.SelectedItem.ToString().Trim().ToLower();
            nuevo.dias_vacaciones = 22;
            nuevo.activo = true;
            nuevo.created_at = DateTime.Now;

            int indice = hopeComboBoxDepartamento.SelectedIndex;
            nuevo.id_departamento = departamentos[indice].id;

            TrabajadorController controller = new TrabajadorController();
            string error = await controller.CrearTrabajador(hopeTextBoxNEmpleado.Text, hopeTextBoxContraseña1.Text, nuevo);

            if (error != null)
            {
                MessageBox.Show("Error: " + error);
                return;
            }

            MessageBox.Show("Empleado creado correctamente.");
            await gestionPlantilla.Recargar();
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            pasoActual--;
            ActualizarBarras();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            pasoActual--;
            ActualizarBarras();
        }

        private async Task CalcularNumeroEmpleado()
        {
            TrabajadorController controller = new TrabajadorController();
            List<Trabajador> todos = await controller.ObtenerTodosLosTrabajadores();

            int maximo = 0;
            for (int i = 0; i < todos.Count; i++)
            {
                string emailSinDominio = todos[i].email.Replace("@dhl.com", "");
                int numero = 0;
                bool esNumero = int.TryParse(emailSinDominio, out numero);
                if (esNumero == true && numero > maximo)
                {
                    maximo = numero;
                }
            }

            hopeTextBoxNEmpleado.Text = (maximo + 1).ToString();
        }



        private void iconButtonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private bool ValidarDNI(string dni)
        {
          
            if (string.IsNullOrEmpty(dni) || dni.Length != 9)
            {
                return false;
            }

           
            string numeros = dni.Substring(0, 8);
            char letra = dni[8]; 

            
            if (!int.TryParse(numeros, out _))
            {
                return false;
            }

           
            if (!char.IsLetter(letra))
            {
                return false;
            }

            return true;
        }






    }
}