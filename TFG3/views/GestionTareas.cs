using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class GestionTareas : UserControl
    {
        private List<Tarea> todasLasTareas = new List<Tarea>();
        private List<Trabajador> empleados = new List<Trabajador>();
        private string filtroActual = "todas";

        public GestionTareas()
        {
            InitializeComponent();
        }

        private void GestionTareas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private async void CargarDatos()
        {
            try
            {
                TareaController tareaController = new TareaController();
                TrabajadorController trabController = new TrabajadorController();

                todasLasTareas = await tareaController.ObtenerTodas();
                empleados = await trabController.ObtenerTodosLosTrabajadores();

                if (todasLasTareas == null) todasLasTareas = new List<Tarea>();
                if (empleados == null) empleados = new List<Trabajador>();

                MostrarTareas();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MostrarTareas()
        {
            dataGridView1.Rows.Clear();

            string textoBusqueda = hopeTextBox2.Text.Trim().ToLower();

            for (int i = 0; i < todasLasTareas.Count; i++)
            {
                Tarea t = todasLasTareas[i];

                if (filtroActual == "pendientes" && t.estado != "pendiente") continue;
                if (filtroActual == "en_progreso" && t.estado != "en_progreso") continue;

                
                string nombreEmpleado = "Desconocido";
                for (int j = 0; j < empleados.Count; j++)
                {
                    if (empleados[j].id == t.id_trabajador)
                    {
                        nombreEmpleado = empleados[j].nombre + " " + empleados[j].apellidos;
                        break;
                    }
                }

                string asignadoPor = "Desconocido";
                for (int j = 0; j < empleados.Count; j++)
                {
                    if (empleados[j].id == t.asignado_por)
                    {
                        asignadoPor = empleados[j].nombre + " " + empleados[j].apellidos;
                        break;
                    }
                }

              
                if (!string.IsNullOrEmpty(textoBusqueda))
                {
                    bool coincide =
                        t.titulo.ToLower().Contains(textoBusqueda) ||
                        nombreEmpleado.ToLower().Contains(textoBusqueda) ||
                        t.prioridad.ToLower().Contains(textoBusqueda) ||
                        t.estado.ToLower().Contains(textoBusqueda) ||
                        asignadoPor.ToLower().Contains(textoBusqueda);

                    if (!coincide) continue;
                }

                string fechaLimite = t.fecha_limite.HasValue ? t.fecha_limite.Value.ToString("dd/MM/yyyy") : "-";

                int fila = dataGridView1.Rows.Add(
                    t.titulo,
                    nombreEmpleado,
                    t.prioridad,
                    t.estado,
                    fechaLimite,
                    asignadoPor
                );
                dataGridView1.Rows[fila].Tag = t.id;

                Color colorPrioridad = Color.FromArgb(51, 51, 51);
                if (t.prioridad == "alta") colorPrioridad = Color.FromArgb(114, 28, 36);
                if (t.prioridad == "media") colorPrioridad = Color.FromArgb(133, 100, 4);
                if (t.prioridad == "baja") colorPrioridad = Color.FromArgb(21, 87, 36);
                dataGridView1.Rows[fila].Cells["Prioridad"].Style.ForeColor = colorPrioridad;

                Color colorEstado = Color.FromArgb(51, 51, 51);
                if (t.estado == "pendiente") colorEstado = Color.FromArgb(133, 100, 4);
                if (t.estado == "en_progreso") colorEstado = Color.FromArgb(0, 64, 133);
                if (t.estado == "completada") colorEstado = Color.FromArgb(21, 87, 36);
                if (t.estado == "cancelada") colorEstado = Color.FromArgb(212, 5, 17);
                dataGridView1.Rows[fila].Cells["Estado"].Style.ForeColor = colorEstado;
            }
        }

        private void btnTodas_Click(object sender, EventArgs e)
        {
            filtroActual = "todas";
            MostrarTareas();
        }

        private void btnPendientes_Click(object sender, EventArgs e)
        {
            filtroActual = "pendientes";
            MostrarTareas();
        }

        private void btnEnProgreso_Click(object sender, EventArgs e)
        {
            filtroActual = "en_progreso";
            MostrarTareas();
        }

        public async Task Recargar()
        {
            TareaController tareaController = new TareaController();
            TrabajadorController trabController = new TrabajadorController();

            todasLasTareas = await tareaController.ObtenerTodas();
            empleados = await trabController.ObtenerTodosLosTrabajadores();

            if (todasLasTareas == null) todasLasTareas = new List<Tarea>();
            if (empleados == null) empleados = new List<Trabajador>();

            MostrarTareas();
        }

        private void iconButtonNueva_Click(object sender, EventArgs e)
        {
            NuevaTarea formulario = new NuevaTarea(this);
            formulario.ShowDialog();
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona una tarea para eliminar.");
                return;
            }

            int id = (int)dataGridView1.SelectedRows[0].Tag;

            DialogResult confirm = MessageBox.Show(
                "¿Seguro que quieres eliminar esta tarea?",
                "Confirmar",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes)
            {
                TareaController controller = new TareaController();
                await controller.EliminarTarea(id);
                await Recargar();
            }




        }

        private void hopeTextBox2_TextChanged(object sender, EventArgs e)
        {
            MostrarTareas();
        }
    }
}