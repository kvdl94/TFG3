using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class NuevaTarea : Form
    {
        private List<Trabajador> empleados = new List<Trabajador>();
        private GestionTareas gestionTareas;

        public NuevaTarea(GestionTareas gestion)
        {
            InitializeComponent();
            this.gestionTareas = gestion;
        }

        private async void NuevaTarea_Load(object sender, EventArgs e)
        {
            await CargarEmpleados();

            
            guna2ComboBoxPrioridad.Items.Clear();
            guna2ComboBoxPrioridad.Items.Add("baja");
            guna2ComboBoxPrioridad.Items.Add("media");
            guna2ComboBoxPrioridad.Items.Add("alta");
            dateTimePicker1.MinDate = DateTime.Today;
        }

        private async Task CargarEmpleados()
        {
            TrabajadorController controller = new TrabajadorController();
            empleados = await controller.ObtenerTodosLosTrabajadores();

            hopeComboBoxEmpleado.Items.Clear();
            for (int i = 0; i < empleados.Count; i++)
            {
                hopeComboBoxEmpleado.Items.Add(empleados[i].nombre + " " + empleados[i].apellidos);
            }
        }

        private async void btnCrear_Click(object sender, EventArgs e)
        {
            if (hopeTextBoxTitulo.Text.Trim() == "")
            {
                MessageBox.Show("El título es obligatorio.");
                return;
            }
            if (hopeComboBoxEmpleado.SelectedIndex < 0)
            {
                MessageBox.Show("Selecciona un empleado.");
                return;
            }
            if (guna2ComboBoxPrioridad.SelectedItem == null)
            {
                MessageBox.Show("Selecciona una prioridad.");
                return;
            }
            if (dateTimePicker1.Value.Date < DateTime.Today)
            {
                MessageBox.Show("La fecha límite no puede ser anterior a hoy.");
                return;
            }

            Tarea nueva = new Tarea();
            nueva.titulo = hopeTextBoxTitulo.Text.Trim();
            nueva.descripcion = hopeTextBoxDescripcion.Text.Trim();
            nueva.id_trabajador = empleados[hopeComboBoxEmpleado.SelectedIndex].id;
            nueva.prioridad = guna2ComboBoxPrioridad.SelectedItem.ToString();
            nueva.estado = "pendiente";
            nueva.fecha_limite = dateTimePicker1.Value;
            nueva.asignado_por = TFG3.services.SupabaseConexion.UsuarioActualId;

            TareaController controller = new TareaController();
            await controller.CrearTarea(nueva);
            await gestionTareas.Recargar();
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}