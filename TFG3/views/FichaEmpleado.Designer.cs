namespace TFG3.views
{
    partial class FichaEmpleado
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
            ComboBoxRol = new ReaLTaiizor.Controls.HopeComboBox();
            labelRol = new Label();
            labelNombre = new Label();
            pictureBox1 = new PictureBox();
            panelInferior = new Panel();
            iconButtonInforme = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            textBoxAntigüedad = new TextBox();
            textBoxTelefono = new TextBox();
            textBoxVacaciones = new TextBox();
            textBoxEmail = new TextBox();
            textBoxDepartamento = new TextBox();
            textBoxDNI = new TextBox();
            labelAntiguedad = new Label();
            labelVacaciones = new Label();
            labelDepartamento = new Label();
            labelTelefono = new Label();
            labelEmail = new Label();
            labelDNI = new Label();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelInferior.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 26, 26);
            panelSuperior.Controls.Add(ComboBoxRol);
            panelSuperior.Controls.Add(labelRol);
            panelSuperior.Controls.Add(labelNombre);
            panelSuperior.Controls.Add(pictureBox1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(571, 125);
            panelSuperior.TabIndex = 0;
            // 
            // ComboBoxRol
            // 
            ComboBoxRol.BackColor = Color.FromArgb(42, 42, 42);
            ComboBoxRol.DrawMode = DrawMode.OwnerDrawFixed;
            ComboBoxRol.FlatStyle = FlatStyle.Flat;
            ComboBoxRol.Font = new Font("Segoe UI", 12F);
            ComboBoxRol.ForeColor = Color.FromArgb(200, 160, 64);
            ComboBoxRol.FormattingEnabled = true;
            ComboBoxRol.ItemHeight = 30;
            ComboBoxRol.Items.AddRange(new object[] { "empleado ", "admin" });
            ComboBoxRol.Location = new Point(409, 86);
            ComboBoxRol.Name = "ComboBoxRol";
            ComboBoxRol.Size = new Size(159, 36);
            ComboBoxRol.TabIndex = 3;
            // 
            // labelRol
            // 
            labelRol.AutoSize = true;
            labelRol.ForeColor = Color.FromArgb(200, 160, 64);
            labelRol.Location = new Point(160, 72);
            labelRol.Name = "labelRol";
            labelRol.Size = new Size(50, 20);
            labelRol.TabIndex = 2;
            labelRol.Text = "label1";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.BackColor = Color.Black;
            labelNombre.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = SystemColors.ButtonHighlight;
            labelNombre.Location = new Point(160, 17);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(104, 41);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(42, 42, 42);
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(102, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(iconButtonInforme);
            panelInferior.Controls.Add(iconButton3);
            panelInferior.Controls.Add(iconButton2);
            panelInferior.Controls.Add(iconButton1);
            panelInferior.Controls.Add(textBoxAntigüedad);
            panelInferior.Controls.Add(textBoxTelefono);
            panelInferior.Controls.Add(textBoxVacaciones);
            panelInferior.Controls.Add(textBoxEmail);
            panelInferior.Controls.Add(textBoxDepartamento);
            panelInferior.Controls.Add(textBoxDNI);
            panelInferior.Controls.Add(labelAntiguedad);
            panelInferior.Controls.Add(labelVacaciones);
            panelInferior.Controls.Add(labelDepartamento);
            panelInferior.Controls.Add(labelTelefono);
            panelInferior.Controls.Add(labelEmail);
            panelInferior.Controls.Add(labelDNI);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 125);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(571, 373);
            panelInferior.TabIndex = 1;
            // 
            // iconButtonInforme
            // 
            iconButtonInforme.BackColor = Color.FromArgb(26, 26, 26);
            iconButtonInforme.ForeColor = Color.FromArgb(200, 160, 64);
            iconButtonInforme.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            iconButtonInforme.IconColor = Color.FromArgb(200, 160, 64);
            iconButtonInforme.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonInforme.IconSize = 30;
            iconButtonInforme.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonInforme.Location = new Point(435, 300);
            iconButtonInforme.Name = "iconButtonInforme";
            iconButtonInforme.Size = new Size(113, 47);
            iconButtonInforme.TabIndex = 15;
            iconButtonInforme.Text = "Informe";
            iconButtonInforme.TextAlign = ContentAlignment.MiddleRight;
            iconButtonInforme.UseVisualStyleBackColor = false;
            iconButtonInforme.Click += iconButtonInforme_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.WhiteSmoke;
            iconButton3.ForeColor = Color.Black;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButton3.IconColor = Color.Black;
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 25;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(282, 300);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(113, 42);
            iconButton3.TabIndex = 14;
            iconButton3.Text = "Cancelar";
            iconButton3.TextAlign = ContentAlignment.MiddleRight;
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.FromArgb(212, 5, 17);
            iconButton2.ForeColor = Color.White;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButton2.IconColor = Color.White;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 25;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(147, 300);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(117, 42);
            iconButton2.TabIndex = 13;
            iconButton2.Text = "Eliminar";
            iconButton2.TextAlign = ContentAlignment.MiddleRight;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(26, 26, 26);
            iconButton1.ForeColor = Color.FromArgb(200, 160, 64);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Save;
            iconButton1.IconColor = Color.FromArgb(200, 160, 64);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(12, 300);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(125, 42);
            iconButton1.TabIndex = 12;
            iconButton1.Text = "Guardar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // textBoxAntigüedad
            // 
            textBoxAntigüedad.Location = new Point(324, 225);
            textBoxAntigüedad.Name = "textBoxAntigüedad";
            textBoxAntigüedad.Size = new Size(125, 27);
            textBoxAntigüedad.TabIndex = 11;
            // 
            // textBoxTelefono
            // 
            textBoxTelefono.Location = new Point(26, 225);
            textBoxTelefono.Name = "textBoxTelefono";
            textBoxTelefono.Size = new Size(125, 27);
            textBoxTelefono.TabIndex = 10;
            // 
            // textBoxVacaciones
            // 
            textBoxVacaciones.Location = new Point(324, 146);
            textBoxVacaciones.Name = "textBoxVacaciones";
            textBoxVacaciones.Size = new Size(125, 27);
            textBoxVacaciones.TabIndex = 9;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(28, 146);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(125, 27);
            textBoxEmail.TabIndex = 8;
            // 
            // textBoxDepartamento
            // 
            textBoxDepartamento.Location = new Point(324, 64);
            textBoxDepartamento.Name = "textBoxDepartamento";
            textBoxDepartamento.Size = new Size(147, 27);
            textBoxDepartamento.TabIndex = 7;
            // 
            // textBoxDNI
            // 
            textBoxDNI.Location = new Point(28, 64);
            textBoxDNI.Name = "textBoxDNI";
            textBoxDNI.Size = new Size(125, 27);
            textBoxDNI.TabIndex = 6;
            // 
            // labelAntiguedad
            // 
            labelAntiguedad.AutoSize = true;
            labelAntiguedad.Location = new Point(324, 185);
            labelAntiguedad.Name = "labelAntiguedad";
            labelAntiguedad.Size = new Size(87, 20);
            labelAntiguedad.TabIndex = 5;
            labelAntiguedad.Text = "Antigüedad";
            // 
            // labelVacaciones
            // 
            labelVacaciones.AutoSize = true;
            labelVacaciones.Location = new Point(324, 110);
            labelVacaciones.Name = "labelVacaciones";
            labelVacaciones.Size = new Size(82, 20);
            labelVacaciones.TabIndex = 4;
            labelVacaciones.Text = "Vacaciones";
            // 
            // labelDepartamento
            // 
            labelDepartamento.AutoSize = true;
            labelDepartamento.Location = new Point(324, 31);
            labelDepartamento.Name = "labelDepartamento";
            labelDepartamento.Size = new Size(106, 20);
            labelDepartamento.TabIndex = 3;
            labelDepartamento.Text = "Departamento";
            // 
            // labelTelefono
            // 
            labelTelefono.AutoSize = true;
            labelTelefono.Location = new Point(26, 185);
            labelTelefono.Name = "labelTelefono";
            labelTelefono.Size = new Size(67, 20);
            labelTelefono.TabIndex = 2;
            labelTelefono.Text = "Teléfono";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(26, 110);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(46, 20);
            labelEmail.TabIndex = 1;
            labelEmail.Text = "Email";
            // 
            // labelDNI
            // 
            labelDNI.AutoSize = true;
            labelDNI.Location = new Point(26, 31);
            labelDNI.Name = "labelDNI";
            labelDNI.Size = new Size(35, 20);
            labelDNI.TabIndex = 0;
            labelDNI.Text = "DNI";
            // 
            // FichaEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(571, 498);
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FichaEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FichaEmpleado";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelInferior.ResumeLayout(false);
            panelInferior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelInferior;
        private PictureBox pictureBox1;
        private Label labelRol;
        private Label labelNombre;
        private Label labelAntiguedad;
        private Label labelVacaciones;
        private Label labelDepartamento;
        private Label labelTelefono;
        private Label labelEmail;
        private Label labelDNI;
        private FontAwesome.Sharp.IconButton iconButton1;
        private TextBox textBoxAntigüedad;
        private TextBox textBoxTelefono;
        private TextBox textBoxVacaciones;
        private TextBox textBoxEmail;
        private TextBox textBoxDepartamento;
        private TextBox textBoxDNI;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconButton2;
        private ReaLTaiizor.Controls.HopeComboBox ComboBoxRol;
        private FontAwesome.Sharp.IconButton iconButtonInforme;
    }
}