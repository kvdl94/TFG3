using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TFG3.Controllers;
using TFG3.Modelo;

namespace TFG3.views
{
    public partial class GestionNotificaciones : UserControl
    {
        private List<Notificacion> notificaciones = new List<Notificacion>();
        private List<Trabajador> empleados = new List<Trabajador>();

        public GestionNotificaciones()
        {
            InitializeComponent();
        }

        private void GestionNotificaciones_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private async void CargarDatos()
        {
            try
            {
                NotificacionController notifController = new NotificacionController();
                TrabajadorController trabController = new TrabajadorController();

                notificaciones = await notifController.ObtenerTodas();
                empleados = await trabController.ObtenerTodosLosTrabajadores();

                if (notificaciones == null) notificaciones = new List<Notificacion>();
                if (empleados == null) empleados = new List<Trabajador>();

                int sinLeer = 0;
                for (int i = 0; i < notificaciones.Count; i++)
                {
                    if (notificaciones[i].leido == false) sinLeer++;
                }
                labelBadge.Text = sinLeer + " sin leer";
                labelBadge.Visible = sinLeer > 0;

                MostrarNotificaciones();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void MostrarNotificaciones()
        {
            panelLista.Controls.Clear();
            int yPos = 5;

            for (int i = 0; i < notificaciones.Count; i++)
            {
                Notificacion n = notificaciones[i];

                string nombreEmpleado = "Desconocido";
                string iniciales = "??";
                for (int j = 0; j < empleados.Count; j++)
                {
                    if (empleados[j].id == n.id_trabajador)
                    {
                        nombreEmpleado = empleados[j].nombre + " " + empleados[j].apellidos;
                        iniciales = empleados[j].nombre[0].ToString() + empleados[j].apellidos[0].ToString();
                        break;
                    }
                }

                Panel fila = new Panel();
                fila.Size = new Size(panelLista.ClientSize.Width - 15, 60);
                fila.Location = new Point(5, yPos);
                fila.BackColor = n.leido ? Color.White : Color.FromArgb(255, 253, 245);
                fila.Cursor = Cursors.Hand;

                // Borde izquierdo por tipo
                Panel bordeIzq = new Panel();
                bordeIzq.Size = new Size(4, 60);
                bordeIzq.Location = new Point(0, 0);
                bordeIzq.BackColor = ObtenerColorTipo(n.tipo);
                fila.Controls.Add(bordeIzq);

                // Avatar
                Panel avatar = new Panel();
                avatar.Size = new Size(36, 36);
                avatar.Location = new Point(14, 12);
                avatar.BackColor = ObtenerColorFondoTipo(n.tipo);

                Label lblIniciales = new Label();
                lblIniciales.Text = iniciales.ToUpper();
                lblIniciales.ForeColor = ObtenerColorTipo(n.tipo);
                lblIniciales.Font = new Font("Segoe UI", 8, FontStyle.Bold);
                lblIniciales.TextAlign = ContentAlignment.MiddleCenter;
                lblIniciales.Dock = DockStyle.Fill;
                avatar.Controls.Add(lblIniciales);
                fila.Controls.Add(avatar);

                // Título
                Label lblTitulo = new Label();
                lblTitulo.Text = n.titulo;
                lblTitulo.ForeColor = Color.FromArgb(51, 51, 51);
                lblTitulo.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblTitulo.Location = new Point(58, 10);
                lblTitulo.AutoSize = true;
                fila.Controls.Add(lblTitulo);

                // Mensaje
                Label lblMensaje = new Label();
                lblMensaje.Text = n.mensaje;
                lblMensaje.ForeColor = Color.FromArgb(136, 136, 136);
                lblMensaje.Font = new Font("Segoe UI", 8);
                lblMensaje.Location = new Point(58, 28);
                lblMensaje.Size = new Size(panelLista.Width - 150, 16);
                fila.Controls.Add(lblMensaje);

                // Fecha
                Label lblFecha = new Label();
                lblFecha.Text = n.fecha.HasValue ? n.fecha.Value.ToString("dd/MM HH:mm") : "-";
                lblFecha.ForeColor = Color.FromArgb(136, 136, 136);
                lblFecha.Font = new Font("Segoe UI", 8);
                lblFecha.Location = new Point(58, 44);
                lblFecha.AutoSize = true;
                fila.Controls.Add(lblFecha);

                // Punto sin leer
                if (!n.leido)
                {
                    Panel punto = new Panel();
                    punto.Size = new Size(8, 8);
                    punto.Location = new Point(fila.Width - 20, 26);
                    punto.BackColor = Color.FromArgb(212, 5, 17);
                    fila.Controls.Add(punto);
                }

                // Click para marcar como leída
                int notifId = n.id;
                fila.Click += async (s, e) =>
                {
                    NotificacionController controller = new NotificacionController();
                    await controller.MarcarComoLeida(notifId);
                    CargarDatos();
                };

                panelLista.Controls.Add(fila);
                yPos += 65;
            }
        }

        private Color ObtenerColorTipo(string tipo)
        {
            if (tipo == "vacaciones") return Color.FromArgb(212, 5, 17);
            if (tipo == "tarea") return Color.FromArgb(24, 95, 165);
            if (tipo == "fichaje") return Color.FromArgb(200, 160, 64);
            if (tipo == "alerta") return Color.FromArgb(212, 5, 17);
            return Color.FromArgb(136, 136, 136);
        }

        private Color ObtenerColorFondoTipo(string tipo)
        {
            if (tipo == "vacaciones") return Color.FromArgb(248, 215, 218);
            if (tipo == "tarea") return Color.FromArgb(204, 229, 255);
            if (tipo == "fichaje") return Color.FromArgb(255, 243, 205);
            if (tipo == "alerta") return Color.FromArgb(248, 215, 218);
            return Color.FromArgb(240, 240, 240);
        }

       
    }
}