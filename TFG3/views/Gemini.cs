using System;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class Gemini : UserControl
    {
        public Gemini()
        {
            InitializeComponent();

        }

        private async Task<string> ObtenerContextoSupabase()
        {
            try
            {
                var trabajadores = await new TrabajadorController().ObtenerTodosLosTrabajadores();
                var departamentos = await new DepartamentoController().ObtenerTodos();
                var fichajes = await new FichajeController().ObtenerTodos();
                var vacaciones = await new VacacionesController().ObtenerTodas();

                var sb = new StringBuilder();
                sb.AppendLine("Eres el asistente de DHL para la gestión de recursos humanos.");
                sb.AppendLine("Responde de forma breve y concisa en español.");
                sb.AppendLine();

                sb.AppendLine("DEPARTAMENTOS:");
                foreach (var d in departamentos)
                    sb.AppendLine($"- ID:{d.id} | {d.nombre_dep} | Entrada: {d.hora_entrada_est} | Salida: {d.hora_salida_est}");

                sb.AppendLine();
                sb.AppendLine("TRABAJADORES:");
                foreach (var t in trabajadores)
                    sb.AppendLine($"- {t.nombre} {t.apellidos} | DNI: {t.dni} | Email: {t.email} | Rol: {t.rol} | Depto ID: {t.id_departamento} | Activo: {t.activo} | Vacaciones disponibles: {t.dias_vacaciones}");

                sb.AppendLine();
                sb.AppendLine("FICHAJES:");
                foreach (var f in fichajes)
                {
                    
                    var emp = trabajadores.FirstOrDefault(t => t.id == f.id_trabajador);
                    string nombreCompleto = emp != null ? $"{emp.nombre} {emp.apellidos}" : "Desconocido";

                    sb.AppendLine($"- Empleado: {nombreCompleto} | Fecha: {f.fecha:dd/MM/yyyy} | Entrada Real: {f.hora_entrada} | ID Depto: {emp?.id_departamento}");
                }

                sb.AppendLine();
                sb.AppendLine("VACACIONES:");
                foreach (var v in vacaciones)
                    sb.AppendLine($"- Trabajador ID: {v.id_trabajador} | Del {v.fecha_inicio} al {v.fecha_fin} | Estado: {v.estado_solicitud}");

                return sb.ToString();
            }
            catch (Exception ex)
            {
                return "Eres el asistente de DHL para la gestión de recursos humanos. Responde en español.";
            }
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string pregunta = hopeTextBoxPregunta.Text.Trim();
            if (pregunta == "") return;

            iconButton1.Enabled = false;
            richTextBox1.SelectionColor = System.Drawing.Color.FromArgb(200, 160, 64);
            richTextBox1.AppendText("Tú: " + pregunta + "\n");
            richTextBox1.SelectionColor = System.Drawing.Color.FromArgb(51, 51, 51);
            richTextBox1.AppendText("Grok: Pensando...\n\n");

            string contexto = await ObtenerContextoSupabase();

            string respuesta = await new GeminiController().PreguntarAsync(contexto, pregunta);

            int pos = richTextBox1.Text.LastIndexOf("Pensando...");
            if (pos >= 0)
            {
                richTextBox1.Select(pos, "Pensando...".Length);
                richTextBox1.SelectedText = respuesta;
            }

            hopeTextBoxPregunta.Text = "";
            iconButton1.Enabled = true;
            richTextBox1.ScrollToCaret();
        }
    }
}