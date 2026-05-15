using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class GestionMensajes : UserControl
    {
        private List<Trabajador> empleados = new List<Trabajador>();
        private List<Mensaje> mensajes = new List<Mensaje>();
        private string idEmpleadoSeleccionado = null;
        private string adminId = TFG3.services.SupabaseConexion.UsuarioActualId;

        public GestionMensajes()
        {
            InitializeComponent();
        }

     
        private void GestionMensajes_Load(object sender, EventArgs e)
        {
            adminId = TFG3.services.SupabaseConexion.UsuarioActualId;
            CargarEmpleados();
        }

        private async void CargarEmpleados()
        {
            try
            {
                TrabajadorController controller = new TrabajadorController();
                empleados = await controller.ObtenerTodosLosTrabajadores();
                if (empleados == null) empleados = new List<Trabajador>();

                panelListaEmpleados.Controls.Clear();
                int yPos = 0;

                foreach (Trabajador t in empleados)
                {
                    if (t.id == adminId) continue;

                 
                    string[] partesApellidos = t.apellidos.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    string primerApellido = partesApellidos.Length > 0 ? partesApellidos[0] : "";
                    string nombreCorto = t.nombre + " " + primerApellido;

                    string nombreCompleto = t.nombre + " " + t.apellidos;

                    Panel fila = new Panel
                    {
                        Size = new Size(panelListaEmpleados.ClientSize.Width - 10, 55),
                        Location = new Point(0, yPos),
                        BackColor = Color.White,
                        Cursor = Cursors.Hand
                    };

                    Panel bordeIzq = new Panel
                    {
                        Size = new Size(4, 55),
                        Location = new Point(0, 0),
                        BackColor = Color.Transparent
                    };
                    fila.Controls.Add(bordeIzq);

                    Panel avatar = new Panel
                    {
                        Size = new Size(36, 36),
                        Location = new Point(12, 10),
                        BackColor = Color.FromArgb(26, 26, 26)
                    };

                    
                    string iniciales = t.nombre[0].ToString() + (t.apellidos.Length > 0 ? t.apellidos[0].ToString() : "");
                    Label lblIniciales = new Label
                    {
                        Text = iniciales.ToUpper(),
                        ForeColor = Color.FromArgb(200, 160, 64),
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Fill
                    };
                    avatar.Controls.Add(lblIniciales);
                    fila.Controls.Add(avatar);

                    Label lblNombre = new Label
                    {
                        Text = nombreCorto, 
                        ForeColor = Color.FromArgb(51, 51, 51),
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        AutoSize = false,
                        Location = new Point(55, 18),
                        Size = new Size(panelListaEmpleados.Width - 70, 22),
                        TextAlign = ContentAlignment.MiddleLeft
                    };
                    fila.Controls.Add(lblNombre);

                    string idEmp = t.id;

                    
                    Action selectAction = () => SeleccionarEmpleado(idEmp, nombreCompleto, bordeIzq, fila);

                    fila.Click += (s, ev) => selectAction();
                    lblNombre.Click += (s, ev) => selectAction();
                    avatar.Click += (s, ev) => selectAction();
                    lblIniciales.Click += (s, ev) => selectAction();

                    panelListaEmpleados.Controls.Add(fila);
                    yPos += 56;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar empleados: " + ex.Message);
            }
        }

        private async void SeleccionarEmpleado(string idEmpleado, string nombreEmpleado, Panel bordeIzq, Panel fila)
        {
            idEmpleadoSeleccionado = idEmpleado;
            labelNombreEmpleadoSeleccionado.Text = nombreEmpleado;

            foreach (Control c in panelListaEmpleados.Controls)
            {
                if (c is Panel p)
                {
                    p.BackColor = Color.White;
                    foreach (Control child in p.Controls)
                    {
                        if (child.Width == 4) child.BackColor = Color.Transparent;
                    }
                }
            }

            fila.BackColor = Color.FromArgb(245, 245, 245);
            bordeIzq.BackColor = Color.FromArgb(200, 160, 64);

            await CargarMensajes();
        }

        private async System.Threading.Tasks.Task CargarMensajes()
        {
            if (idEmpleadoSeleccionado == null) return;

            MensajeController controller = new MensajeController();
            mensajes = await controller.ObtenerMensajes(idEmpleadoSeleccionado);
            if (mensajes == null) mensajes = new List<Mensaje>();

            panelChat.Controls.Clear();
            panelChat.BackColor = Color.White;
            int yPos = 20;

            foreach (Mensaje m in mensajes)
            {
                bool esMio = m.id_remitente == adminId;

                
                Label lblMensaje = new Label
                {
                    Text = m.mensaje,
                    ForeColor = Color.FromArgb(30, 30, 30),
                    Font = new Font("Segoe UI", 10),
                    BackColor = Color.Transparent,
                    AutoSize = true,
                    MaximumSize = new Size(300, 0), 
                    Location = new Point(12, 10)
                };

               
                Panel burbuja = new Panel
                {
                    BackColor = esMio ? Color.FromArgb(230, 243, 255) : Color.FromArgb(245, 245, 245),
                    
                    Width = Math.Max(lblMensaje.PreferredWidth + 24, 70),
                    Height = lblMensaje.PreferredHeight + 35,
                };

               
                if (!esMio)
                {
                    burbuja.Paint += (s, e) => {
                        ControlPaint.DrawBorder(e.Graphics, burbuja.ClientRectangle, Color.FromArgb(225, 225, 225), ButtonBorderStyle.Solid);
                    };
                }

               
                Label lblHora = new Label
                {
                    Text = m.fecha.HasValue ? m.fecha.Value.ToString("HH:mm") : "",
                    ForeColor = Color.Gray,
                    Font = new Font("Segoe UI", 7.5f),
                    AutoSize = true,
                    BackColor = Color.Transparent
                };

               
                burbuja.Controls.Add(lblMensaje);
                burbuja.Controls.Add(lblHora);
                lblHora.Location = new Point(burbuja.Width - lblHora.PreferredWidth - 8, burbuja.Height - 18);

                
                int xPos = esMio ? panelChat.ClientSize.Width - burbuja.Width - 25 : 20;
                burbuja.Location = new Point(xPos, yPos);

                panelChat.Controls.Add(burbuja);

                
                yPos += burbuja.Height + 15;
            }

           
            panelChat.VerticalScroll.Value = panelChat.VerticalScroll.Maximum;
            panelChat.PerformLayout();
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            if (idEmpleadoSeleccionado == null)
            {
                MessageBox.Show("Selecciona un empleado primero.");
                return;
            }

            string texto = hopeTextBoxMensaje.Text.Trim();
            if (texto == "") return;

            MensajeController controller = new MensajeController();
            await controller.EnviarMensaje(adminId, idEmpleadoSeleccionado, texto);

            hopeTextBoxMensaje.Text = "";
            await CargarMensajes();
        }

        private void panelChat_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}