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
            }

            dataGridView1.ClearSelection();
        }
    }
}