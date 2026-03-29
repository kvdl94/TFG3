using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class GestionPlantilla : UserControl
    {
        private List<Trabajador> empleados = new List<Trabajador>();
        private List<Departamento> departamentos = new List<Departamento>();
        private bool esNuevo = false;
        public GestionPlantilla()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private async void GestionPlantilla_Load(object sender, EventArgs e)
        {
            TrabajadorController controller = new TrabajadorController();
            DepartamentoController depController = new DepartamentoController();

            empleados = await controller.ObtenerTodosLosTrabajadores();
            departamentos = await depController.ObtenerTodos();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = empleados;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Trabajador t = empleados[i];

                string email = t.email;
                string numeroEmpleado = email.Replace("@dhl.com", "");
                dataGridView1.Rows[i].Cells["NUMERO_EMPLEADO"].Value = numeroEmpleado;

                if (t.created_at != null)
                {
                    int años = DateTime.Now.Year - t.created_at.Value.Year;
                    dataGridView1.Rows[i].Cells["Antigüedad"].Value = años + " años";
                }

                if (t.id_departamento != null)
                {
                    bool encontrado = false;
                    int j = 0;
                    while (j < departamentos.Count && encontrado == false)
                    {
                        if (departamentos[j].id == t.id_departamento)
                        {
                            dataGridView1.Rows[i].Cells["Departamento"].Value = departamentos[j].nombre_dep;
                            encontrado = true;
                        }
                        j++;
                    }
                }

                if (t.activo == true)
                {
                    dataGridView1.Rows[i].Cells["Activo"].Value = "✓";
                }
                else
                {
                    dataGridView1.Rows[i].Cells["Activo"].Value = "✗";
                }


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Trabajador trabajador = empleados[e.RowIndex];
                FichaEmpleado ficha = new FichaEmpleado(trabajador, this);
                ficha.ShowDialog();
            }
        }

        public async Task Recargar()
        {
            TrabajadorController controller = new TrabajadorController();
            DepartamentoController depController = new DepartamentoController();

            empleados = await controller.ObtenerTodosLosTrabajadores();
            departamentos = await depController.ObtenerTodos();

            dataGridView1.DataSource = null;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = empleados;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                Trabajador t = empleados[i];

                string email = t.email;
                string numeroEmpleado = email.Replace("@dhl.com", "");
                dataGridView1.Rows[i].Cells["NUMERO_EMPLEADO"].Value = numeroEmpleado;

                if (t.created_at != null)
                {
                    int años = DateTime.Now.Year - t.created_at.Value.Year;
                    dataGridView1.Rows[i].Cells["Antigüedad"].Value = años + " años";
                }

                if (t.id_departamento != null)
                {
                    bool encontrado = false;
                    int j = 0;
                    while (j < departamentos.Count && encontrado == false)
                    {
                        if (departamentos[j].id == t.id_departamento)
                        {
                            dataGridView1.Rows[i].Cells["Departamento"].Value = departamentos[j].nombre_dep;
                            encontrado = true;
                        }
                        j++;
                    }
                }

                if (t.activo == true)
                {
                    dataGridView1.Rows[i].Cells["Activo"].Value = "✓";
                }
                else
                {
                    dataGridView1.Rows[i].Cells["Activo"].Value = "✗";
                }




            }

            dataGridView1.ClearSelection();
        }

        private async void iconButton2_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecciona un empleado primero.");
                return;
            }

            Trabajador trabajador = empleados[dataGridView1.SelectedRows[0].Index];

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
                await Recargar();

            }



        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            NuevoEmpleado formulario = new NuevoEmpleado(this);
            formulario.ShowDialog();
        }

        private void hopeTextBox1_TextChanged(object sender, EventArgs e)
        {
            string busqueda = hopeTextBox1.Text.ToLower();
            dataGridView1.CurrentCell = null;
            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].IsNewRow)
                {
                    continue;
                }

                bool visible = false;

                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    if (dataGridView1.Rows[i].Cells[j].Value != null)
                    {
                        if (dataGridView1.Rows[i].Cells[j].Value.ToString().ToLower().Contains(busqueda))
                        {
                            visible = true;
                        }
                    }
                }

                dataGridView1.Rows[i].Visible = visible;
            }
        }
    }
}