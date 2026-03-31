namespace TFG3.views
{
    partial class DetalleVacacion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelSuperior = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            labelEstado = new Label();
            label1 = new Label();
            labelNombre = new Label();
            panelInferior = new Panel();
            iconButtonCerrar = new FontAwesome.Sharp.IconButton();
            iconButtonRechazar = new FontAwesome.Sharp.IconButton();
            iconButtonAprobar = new FontAwesome.Sharp.IconButton();
            panelSemaforo = new Panel();
            labelDetalleDisponibilidad = new Label();
            labelDisponibilidad = new Label();
            label2 = new Label();
            labelMotivo = new Label();
            label54 = new Label();
            panelDesde = new Panel();
            labelFechaDesde = new Label();
            labelDesde = new Label();
            panelDias = new Panel();
            labelDiasTot = new Label();
            labelDias = new Label();
            panelHasta = new Panel();
            labelFechaHasta = new Label();
            labelHasta = new Label();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelInferior.SuspendLayout();
            panelSemaforo.SuspendLayout();
            panelDesde.SuspendLayout();
            panelDias.SuspendLayout();
            panelHasta.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 26, 26);
            panelSuperior.Controls.Add(iconPictureBox1);
            panelSuperior.Controls.Add(labelEstado);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(labelNombre);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(478, 80);
            panelSuperior.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(26, 26, 26);
            iconPictureBox1.ForeColor = SystemColors.ControlText;
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.None;
            iconPictureBox1.IconColor = SystemColors.ControlText;
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 54;
            iconPictureBox1.Location = new Point(13, 9);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(63, 54);
            iconPictureBox1.TabIndex = 3;
            iconPictureBox1.TabStop = false;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Location = new Point(373, 14);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(58, 20);
            labelEstado.TabIndex = 2;
            labelEstado.Text = "estado ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(136, 136, 136);
            label1.Location = new Point(95, 43);
            label1.Name = "label1";
            label1.Size = new Size(164, 20);
            label1.TabIndex = 1;
            label1.Text = "Solicitud de vacaciones";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(84, 4);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(105, 31);
            labelNombre.TabIndex = 0;
            labelNombre.Text = "9999999";
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(iconButtonCerrar);
            panelInferior.Controls.Add(iconButtonRechazar);
            panelInferior.Controls.Add(iconButtonAprobar);
            panelInferior.Controls.Add(panelSemaforo);
            panelInferior.Controls.Add(label2);
            panelInferior.Controls.Add(labelMotivo);
            panelInferior.Controls.Add(label54);
            panelInferior.Controls.Add(panelDesde);
            panelInferior.Controls.Add(panelDias);
            panelInferior.Controls.Add(panelHasta);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 80);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(478, 429);
            panelInferior.TabIndex = 1;
            // 
            // iconButtonCerrar
            // 
            iconButtonCerrar.BackColor = Color.WhiteSmoke;
            iconButtonCerrar.ForeColor = Color.Black;
            iconButtonCerrar.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButtonCerrar.IconColor = Color.Black;
            iconButtonCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCerrar.IconSize = 30;
            iconButtonCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonCerrar.Location = new Point(336, 358);
            iconButtonCerrar.Name = "iconButtonCerrar";
            iconButtonCerrar.Size = new Size(111, 46);
            iconButtonCerrar.TabIndex = 9;
            iconButtonCerrar.Text = "Cerrar";
            iconButtonCerrar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonCerrar.UseVisualStyleBackColor = false;
            iconButtonCerrar.Click += btnCerrar_Click;
            // 
            // iconButtonRechazar
            // 
            iconButtonRechazar.BackColor = Color.FromArgb(212, 5, 17);
            iconButtonRechazar.ForeColor = Color.White;
            iconButtonRechazar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButtonRechazar.IconColor = Color.White;
            iconButtonRechazar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonRechazar.IconSize = 30;
            iconButtonRechazar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonRechazar.Location = new Point(171, 358);
            iconButtonRechazar.Name = "iconButtonRechazar";
            iconButtonRechazar.Size = new Size(111, 46);
            iconButtonRechazar.TabIndex = 8;
            iconButtonRechazar.Text = "Rechazar";
            iconButtonRechazar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonRechazar.UseVisualStyleBackColor = false;
            iconButtonRechazar.Click += btnRechazar_Click;
            // 
            // iconButtonAprobar
            // 
            iconButtonAprobar.BackColor = Color.FromArgb(29, 158, 117);
            iconButtonAprobar.ForeColor = Color.White;
            iconButtonAprobar.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconButtonAprobar.IconColor = Color.White;
            iconButtonAprobar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAprobar.IconSize = 30;
            iconButtonAprobar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonAprobar.Location = new Point(13, 358);
            iconButtonAprobar.Name = "iconButtonAprobar";
            iconButtonAprobar.Size = new Size(109, 46);
            iconButtonAprobar.TabIndex = 7;
            iconButtonAprobar.Text = "Aprobar";
            iconButtonAprobar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonAprobar.UseVisualStyleBackColor = false;
            iconButtonAprobar.Click += btnAprobar_Click;
            // 
            // panelSemaforo
            // 
            panelSemaforo.Controls.Add(labelDetalleDisponibilidad);
            panelSemaforo.Controls.Add(labelDisponibilidad);
            panelSemaforo.Location = new Point(0, 241);
            panelSemaforo.Name = "panelSemaforo";
            panelSemaforo.Size = new Size(477, 69);
            panelSemaforo.TabIndex = 6;
            // 
            // labelDetalleDisponibilidad
            // 
            labelDetalleDisponibilidad.AutoSize = true;
            labelDetalleDisponibilidad.Location = new Point(39, 39);
            labelDetalleDisponibilidad.Name = "labelDetalleDisponibilidad";
            labelDetalleDisponibilidad.Size = new Size(0, 20);
            labelDetalleDisponibilidad.TabIndex = 1;
            // 
            // labelDisponibilidad
            // 
            labelDisponibilidad.AutoSize = true;
            labelDisponibilidad.Location = new Point(39, 0);
            labelDisponibilidad.Name = "labelDisponibilidad";
            labelDisponibilidad.Size = new Size(0, 20);
            labelDisponibilidad.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(136, 136, 136);
            label2.Location = new Point(3, 208);
            label2.Name = "label2";
            label2.Size = new Size(210, 20);
            label2.TabIndex = 5;
            label2.Text = "Disponibilidad en estas fechas";
            // 
            // labelMotivo
            // 
            labelMotivo.BackColor = Color.WhiteSmoke;
            labelMotivo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMotivo.ForeColor = Color.FromArgb(51, 51, 51);
            labelMotivo.Location = new Point(3, 159);
            labelMotivo.Name = "labelMotivo";
            labelMotivo.Size = new Size(474, 34);
            labelMotivo.TabIndex = 4;
            labelMotivo.Text = "label2";
            // 
            // label54
            // 
            label54.AutoSize = true;
            label54.ForeColor = Color.FromArgb(136, 136, 136);
            label54.Location = new Point(3, 123);
            label54.Name = "label54";
            label54.Size = new Size(153, 20);
            label54.TabIndex = 3;
            label54.Text = "Motivo del empleado";
            // 
            // panelDesde
            // 
            panelDesde.Controls.Add(labelFechaDesde);
            panelDesde.Controls.Add(labelDesde);
            panelDesde.Location = new Point(3, 17);
            panelDesde.Name = "panelDesde";
            panelDesde.Size = new Size(138, 80);
            panelDesde.TabIndex = 0;
            // 
            // labelFechaDesde
            // 
            labelFechaDesde.AutoSize = true;
            labelFechaDesde.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFechaDesde.Location = new Point(37, 0);
            labelFechaDesde.Name = "labelFechaDesde";
            labelFechaDesde.Size = new Size(64, 25);
            labelFechaDesde.TabIndex = 1;
            labelFechaDesde.Text = "Desde";
            // 
            // labelDesde
            // 
            labelDesde.AutoSize = true;
            labelDesde.Location = new Point(36, 40);
            labelDesde.Name = "labelDesde";
            labelDesde.Size = new Size(51, 20);
            labelDesde.TabIndex = 0;
            labelDesde.Text = "Desde";
            // 
            // panelDias
            // 
            panelDias.Controls.Add(labelDiasTot);
            panelDias.Controls.Add(labelDias);
            panelDias.Location = new Point(336, 17);
            panelDias.Name = "panelDias";
            panelDias.Size = new Size(141, 80);
            panelDias.TabIndex = 2;
            // 
            // labelDiasTot
            // 
            labelDiasTot.AutoSize = true;
            labelDiasTot.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDiasTot.Location = new Point(45, 0);
            labelDiasTot.Name = "labelDiasTot";
            labelDiasTot.Size = new Size(48, 25);
            labelDiasTot.TabIndex = 3;
            labelDiasTot.Text = "Días";
            // 
            // labelDias
            // 
            labelDias.AutoSize = true;
            labelDias.Location = new Point(45, 40);
            labelDias.Name = "labelDias";
            labelDias.Size = new Size(38, 20);
            labelDias.TabIndex = 2;
            labelDias.Text = "Días";
            // 
            // panelHasta
            // 
            panelHasta.Controls.Add(labelFechaHasta);
            panelHasta.Controls.Add(labelHasta);
            panelHasta.Location = new Point(171, 17);
            panelHasta.Name = "panelHasta";
            panelHasta.Size = new Size(136, 80);
            panelHasta.TabIndex = 1;
            // 
            // labelFechaHasta
            // 
            labelFechaHasta.AutoSize = true;
            labelFechaHasta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFechaHasta.Location = new Point(41, 0);
            labelFechaHasta.Name = "labelFechaHasta";
            labelFechaHasta.Size = new Size(61, 25);
            labelFechaHasta.TabIndex = 2;
            labelFechaHasta.Text = "Hasta";
            // 
            // labelHasta
            // 
            labelHasta.AutoSize = true;
            labelHasta.Location = new Point(41, 40);
            labelHasta.Name = "labelHasta";
            labelHasta.Size = new Size(47, 20);
            labelHasta.TabIndex = 1;
            labelHasta.Text = "Hasta";
            // 
            // DetalleVacacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(478, 509);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleVacacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DetalleVacacion";
            Load += DetalleVacacion_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            panelSemaforo.ResumeLayout(false);
            panelSemaforo.PerformLayout();
            panelDesde.ResumeLayout(false);
            panelDesde.PerformLayout();
            panelDias.ResumeLayout(false);
            panelDias.PerformLayout();
            panelHasta.ResumeLayout(false);
            panelHasta.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label labelEstado;
        private Label label1;
        private Label labelNombre;
        private Panel panelInferior;
        private Panel panelDesde;
        private Panel panelDias;
        private Panel panelHasta;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label labelFechaDesde;
        private Label labelDesde;
        private Label labelDiasTot;
        private Label labelDias;
        private Label labelFechaHasta;
        private Label labelHasta;
        private Label label54;
        private Label label2;
        private Label labelMotivo;
        private Panel panelSemaforo;
        private Label labelDetalleDisponibilidad;
        private Label labelDisponibilidad;
        private FontAwesome.Sharp.IconButton iconButtonCerrar;
        private FontAwesome.Sharp.IconButton iconButtonRechazar;
        private FontAwesome.Sharp.IconButton iconButtonAprobar;
    }
}