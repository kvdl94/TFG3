namespace TFG3.views
{
    partial class GestionMensajes
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            panelIzquierdo = new Panel();
            panelListaEmpleados = new Panel();
            panelSuperior = new Panel();
            label1 = new Label();
            panelCabecera = new Panel();
            labelNombreEmpleadoSeleccionado = new Label();
            panelChat = new Panel();
            panelInferiror = new Panel();
            iconButtonEnviar = new FontAwesome.Sharp.IconButton();
            hopeTextBoxMensaje = new ReaLTaiizor.Controls.HopeTextBox();
            panelIzquierdo.SuspendLayout();
            panelSuperior.SuspendLayout();
            panelCabecera.SuspendLayout();
            panelInferiror.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.Black;
            panelIzquierdo.Controls.Add(panelListaEmpleados);
            panelIzquierdo.Controls.Add(panelSuperior);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 0);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(206, 749);
            panelIzquierdo.TabIndex = 0;
            // 
            // panelListaEmpleados
            // 
            panelListaEmpleados.AutoScroll = true;
            panelListaEmpleados.Dock = DockStyle.Fill;
            panelListaEmpleados.Location = new Point(0, 122);
            panelListaEmpleados.Name = "panelListaEmpleados";
            panelListaEmpleados.Size = new Size(206, 627);
            panelListaEmpleados.TabIndex = 3;
            // 
            // panelSuperior
            // 
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(206, 122);
            panelSuperior.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 0;
            label1.Text = "MENSAJES";
            // 
            // panelCabecera
            // 
            panelCabecera.BackColor = Color.Black;
            panelCabecera.Controls.Add(labelNombreEmpleadoSeleccionado);
            panelCabecera.Dock = DockStyle.Top;
            panelCabecera.Location = new Point(206, 0);
            panelCabecera.Name = "panelCabecera";
            panelCabecera.Size = new Size(959, 125);
            panelCabecera.TabIndex = 1;
            // 
            // labelNombreEmpleadoSeleccionado
            // 
            labelNombreEmpleadoSeleccionado.AutoSize = true;
            labelNombreEmpleadoSeleccionado.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreEmpleadoSeleccionado.ForeColor = Color.White;
            labelNombreEmpleadoSeleccionado.Location = new Point(6, 3);
            labelNombreEmpleadoSeleccionado.Name = "labelNombreEmpleadoSeleccionado";
            labelNombreEmpleadoSeleccionado.Size = new Size(70, 28);
            labelNombreEmpleadoSeleccionado.TabIndex = 0;
            labelNombreEmpleadoSeleccionado.Text = "label2";
            // 
            // panelChat
            // 
            panelChat.AutoScroll = true;
            panelChat.BackColor = Color.White;
            panelChat.Dock = DockStyle.Fill;
            panelChat.Location = new Point(206, 125);
            panelChat.Name = "panelChat";
            panelChat.Size = new Size(959, 570);
            panelChat.TabIndex = 2;
            panelChat.Paint += panelChat_Paint;
            // 
            // panelInferiror
            // 
            panelInferiror.BackColor = Color.White;
            panelInferiror.Controls.Add(iconButtonEnviar);
            panelInferiror.Controls.Add(hopeTextBoxMensaje);
            panelInferiror.Dock = DockStyle.Bottom;
            panelInferiror.Location = new Point(206, 695);
            panelInferiror.Name = "panelInferiror";
            panelInferiror.Size = new Size(959, 54);
            panelInferiror.TabIndex = 0;
            // 
            // iconButtonEnviar
            // 
            iconButtonEnviar.BackColor = Color.FromArgb(200, 160, 64);
            iconButtonEnviar.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            iconButtonEnviar.IconColor = Color.Black;
            iconButtonEnviar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            iconButtonEnviar.IconSize = 40;
            iconButtonEnviar.Location = new Point(807, 11);
            iconButtonEnviar.Name = "iconButtonEnviar";
            iconButtonEnviar.Size = new Size(94, 43);
            iconButtonEnviar.TabIndex = 1;
            iconButtonEnviar.UseVisualStyleBackColor = false;
            iconButtonEnviar.Click += btnEnviar_Click;
            // 
            // hopeTextBoxMensaje
            // 
            hopeTextBoxMensaje.BackColor = Color.White;
            hopeTextBoxMensaje.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxMensaje.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxMensaje.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxMensaje.Font = new Font("Segoe UI", 12F);
            hopeTextBoxMensaje.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxMensaje.Hint = "Escribe un mensaje...";
            hopeTextBoxMensaje.Location = new Point(3, 6);
            hopeTextBoxMensaje.MaxLength = 32767;
            hopeTextBoxMensaje.Multiline = false;
            hopeTextBoxMensaje.Name = "hopeTextBoxMensaje";
            hopeTextBoxMensaje.PasswordChar = '\0';
            hopeTextBoxMensaje.ScrollBars = ScrollBars.None;
            hopeTextBoxMensaje.SelectedText = "";
            hopeTextBoxMensaje.SelectionLength = 0;
            hopeTextBoxMensaje.SelectionStart = 0;
            hopeTextBoxMensaje.Size = new Size(801, 43);
            hopeTextBoxMensaje.TabIndex = 0;
            hopeTextBoxMensaje.TabStop = false;
            hopeTextBoxMensaje.UseSystemPasswordChar = false;
            // 
            // GestionMensajes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelChat);
            Controls.Add(panelInferiror);
            Controls.Add(panelCabecera);
            Controls.Add(panelIzquierdo);
            Name = "GestionMensajes";
            Size = new Size(1165, 749);
            Load += GestionMensajes_Load;
            panelIzquierdo.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelCabecera.ResumeLayout(false);
            panelCabecera.PerformLayout();
            panelInferiror.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIzquierdo;
        private Label label1;
        private Panel panelCabecera;
        private Panel panelListaEmpleados;
        private Panel panelSuperior;
        private Label labelNombreEmpleadoSeleccionado;
        private Panel panelChat;
        private Panel panelInferiror;
        private FontAwesome.Sharp.IconButton iconButtonEnviar;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxMensaje;
    }
}
