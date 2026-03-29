namespace TFG3.views
{
    partial class NuevoEmpleado
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
            panelBarra3 = new Panel();
            panelBarra1 = new Panel();
            panelContenedorBarras = new Panel();
            panelBarra2 = new Panel();
            labelPaso = new Label();
            label1 = new Label();
            panelPaso3 = new Panel();
            label9 = new Label();
            hopeTextBoxContraseña2 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBoxContraseña1 = new ReaLTaiizor.Controls.HopeTextBox();
            iconButton4 = new FontAwesome.Sharp.IconButton();
            iconButton3 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            label7 = new Label();
            panelPaso2 = new Panel();
            hopeTextBoxDiaVacaciones = new ReaLTaiizor.Controls.HopeTextBox();
            hopeComboBoxDepartamento = new ReaLTaiizor.Controls.HopeComboBox();
            hopeComboBoxRol = new ReaLTaiizor.Controls.HopeComboBox();
            hopeTextBoxNEmpleado = new ReaLTaiizor.Controls.HopeTextBox();
            labelDiaVacaciones = new Label();
            labelDepartamento = new Label();
            Rol = new Label();
            label2 = new Label();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label6 = new Label();
            panelPaso1 = new Panel();
            iconButtonSiguiente = new FontAwesome.Sharp.IconButton();
            iconButtonCancelar = new FontAwesome.Sharp.IconButton();
            hopeTextBoxTelefono = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBoxDni = new ReaLTaiizor.Controls.HopeTextBox();
            label4 = new Label();
            hopeTextBoxApellido = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBoxNombre = new ReaLTaiizor.Controls.HopeTextBox();
            label5 = new Label();
            label3 = new Label();
            panelSuperior.SuspendLayout();
            panelContenedorBarras.SuspendLayout();
            panelPaso3.SuspendLayout();
            panelPaso2.SuspendLayout();
            panelPaso1.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 26, 26);
            panelSuperior.Controls.Add(panelBarra3);
            panelSuperior.Controls.Add(panelBarra1);
            panelSuperior.Controls.Add(panelContenedorBarras);
            panelSuperior.Controls.Add(labelPaso);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(500, 80);
            panelSuperior.TabIndex = 0;
            // 
            // panelBarra3
            // 
            panelBarra3.BackColor = Color.FromArgb(200, 160, 64);
            panelBarra3.Location = new Point(369, 34);
            panelBarra3.Name = "panelBarra3";
            panelBarra3.Size = new Size(119, 20);
            panelBarra3.TabIndex = 2;
            // 
            // panelBarra1
            // 
            panelBarra1.BackColor = Color.FromArgb(200, 160, 64);
            panelBarra1.Location = new Point(15, 34);
            panelBarra1.Name = "panelBarra1";
            panelBarra1.Size = new Size(119, 20);
            panelBarra1.TabIndex = 0;
            // 
            // panelContenedorBarras
            // 
            panelContenedorBarras.Controls.Add(panelBarra2);
            panelContenedorBarras.Location = new Point(12, 34);
            panelContenedorBarras.Name = "panelContenedorBarras";
            panelContenedorBarras.Size = new Size(488, 20);
            panelContenedorBarras.TabIndex = 2;
            // 
            // panelBarra2
            // 
            panelBarra2.BackColor = Color.FromArgb(200, 160, 64);
            panelBarra2.Location = new Point(182, 0);
            panelBarra2.Name = "panelBarra2";
            panelBarra2.Size = new Size(119, 20);
            panelBarra2.TabIndex = 1;
            // 
            // labelPaso
            // 
            labelPaso.AutoSize = true;
            labelPaso.ForeColor = Color.FromArgb(136, 136, 136);
            labelPaso.Location = new Point(3, 57);
            labelPaso.Name = "labelPaso";
            labelPaso.Size = new Size(253, 20);
            labelPaso.TabIndex = 1;
            labelPaso.Text = "PASO 1 DE 3 — DATOS PERSONALES";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(196, 31);
            label1.TabIndex = 0;
            label1.Text = "Nuevo Empleado";
            // 
            // panelPaso3
            // 
            panelPaso3.Controls.Add(label9);
            panelPaso3.Controls.Add(hopeTextBoxContraseña2);
            panelPaso3.Controls.Add(hopeTextBoxContraseña1);
            panelPaso3.Controls.Add(iconButton4);
            panelPaso3.Controls.Add(iconButton3);
            panelPaso3.Controls.Add(label8);
            panelPaso3.Controls.Add(label7);
            panelPaso3.Dock = DockStyle.Fill;
            panelPaso3.Location = new Point(0, 80);
            panelPaso3.Name = "panelPaso3";
            panelPaso3.Size = new Size(500, 370);
            panelPaso3.TabIndex = 20;
            panelPaso3.Visible = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 7.8F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(136, 136, 136);
            label9.Location = new Point(127, 115);
            label9.Name = "label9";
            label9.Size = new Size(131, 17);
            label9.TabIndex = 16;
            label9.Text = "* Mínimo 6 caracteres";
            // 
            // hopeTextBoxContraseña2
            // 
            hopeTextBoxContraseña2.BackColor = Color.White;
            hopeTextBoxContraseña2.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxContraseña2.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxContraseña2.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxContraseña2.Font = new Font("Segoe UI", 12F);
            hopeTextBoxContraseña2.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxContraseña2.Hint = "Repite la contraseña...";
            hopeTextBoxContraseña2.Location = new Point(127, 226);
            hopeTextBoxContraseña2.MaxLength = 32767;
            hopeTextBoxContraseña2.Multiline = false;
            hopeTextBoxContraseña2.Name = "hopeTextBoxContraseña2";
            hopeTextBoxContraseña2.PasswordChar = '\0';
            hopeTextBoxContraseña2.ScrollBars = ScrollBars.None;
            hopeTextBoxContraseña2.SelectedText = "";
            hopeTextBoxContraseña2.SelectionLength = 0;
            hopeTextBoxContraseña2.SelectionStart = 0;
            hopeTextBoxContraseña2.Size = new Size(240, 43);
            hopeTextBoxContraseña2.TabIndex = 15;
            hopeTextBoxContraseña2.TabStop = false;
            hopeTextBoxContraseña2.UseSystemPasswordChar = true;
            // 
            // hopeTextBoxContraseña1
            // 
            hopeTextBoxContraseña1.BackColor = Color.White;
            hopeTextBoxContraseña1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxContraseña1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxContraseña1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxContraseña1.Font = new Font("Segoe UI", 12F);
            hopeTextBoxContraseña1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxContraseña1.Hint = "Contraseña...";
            hopeTextBoxContraseña1.Location = new Point(127, 69);
            hopeTextBoxContraseña1.MaxLength = 32767;
            hopeTextBoxContraseña1.Multiline = false;
            hopeTextBoxContraseña1.Name = "hopeTextBoxContraseña1";
            hopeTextBoxContraseña1.PasswordChar = '\0';
            hopeTextBoxContraseña1.ScrollBars = ScrollBars.None;
            hopeTextBoxContraseña1.SelectedText = "";
            hopeTextBoxContraseña1.SelectionLength = 0;
            hopeTextBoxContraseña1.SelectionStart = 0;
            hopeTextBoxContraseña1.Size = new Size(240, 43);
            hopeTextBoxContraseña1.TabIndex = 14;
            hopeTextBoxContraseña1.TabStop = false;
            hopeTextBoxContraseña1.UseSystemPasswordChar = true;
            // 
            // iconButton4
            // 
            iconButton4.BackColor = Color.FromArgb(200, 160, 64);
            iconButton4.ForeColor = Color.FromArgb(26, 26, 26);
            iconButton4.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconButton4.IconColor = Color.FromArgb(26, 26, 26);
            iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton4.IconSize = 30;
            iconButton4.ImageAlign = ContentAlignment.MiddleRight;
            iconButton4.Location = new Point(252, 294);
            iconButton4.Name = "iconButton4";
            iconButton4.Size = new Size(181, 29);
            iconButton4.TabIndex = 13;
            iconButton4.Text = "Crear empleado";
            iconButton4.TextAlign = ContentAlignment.MiddleLeft;
            iconButton4.UseVisualStyleBackColor = false;
            iconButton4.Click += btnCrear_Click;
            // 
            // iconButton3
            // 
            iconButton3.BackColor = Color.WhiteSmoke;
            iconButton3.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            iconButton3.IconColor = Color.FromArgb(136, 136, 136);
            iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton3.IconSize = 35;
            iconButton3.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton3.Location = new Point(21, 294);
            iconButton3.Name = "iconButton3";
            iconButton3.Size = new Size(181, 29);
            iconButton3.TabIndex = 12;
            iconButton3.Text = "Atras";
            iconButton3.UseVisualStyleBackColor = false;
            iconButton3.Click += iconButton3_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(127, 186);
            label8.Name = "label8";
            label8.Size = new Size(151, 20);
            label8.TabIndex = 1;
            label8.Text = "Confirmar contraseña";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(127, 19);
            label7.Name = "label7";
            label7.Size = new Size(159, 20);
            label7.TabIndex = 0;
            label7.Text = "Contraseña Provisional";
            // 
            // panelPaso2
            // 
            panelPaso2.Controls.Add(hopeTextBoxDiaVacaciones);
            panelPaso2.Controls.Add(hopeComboBoxDepartamento);
            panelPaso2.Controls.Add(hopeComboBoxRol);
            panelPaso2.Controls.Add(hopeTextBoxNEmpleado);
            panelPaso2.Controls.Add(labelDiaVacaciones);
            panelPaso2.Controls.Add(labelDepartamento);
            panelPaso2.Controls.Add(Rol);
            panelPaso2.Controls.Add(label2);
            panelPaso2.Controls.Add(iconButton2);
            panelPaso2.Controls.Add(iconButton1);
            panelPaso2.Dock = DockStyle.Fill;
            panelPaso2.Location = new Point(0, 80);
            panelPaso2.Name = "panelPaso2";
            panelPaso2.Size = new Size(500, 370);
            panelPaso2.TabIndex = 10;
            panelPaso2.Visible = false;
            // 
            // hopeTextBoxDiaVacaciones
            // 
            hopeTextBoxDiaVacaciones.BackColor = Color.White;
            hopeTextBoxDiaVacaciones.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxDiaVacaciones.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxDiaVacaciones.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxDiaVacaciones.Font = new Font("Segoe UI", 12F);
            hopeTextBoxDiaVacaciones.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxDiaVacaciones.Hint = "22";
            hopeTextBoxDiaVacaciones.Location = new Point(313, 175);
            hopeTextBoxDiaVacaciones.MaxLength = 32767;
            hopeTextBoxDiaVacaciones.Multiline = false;
            hopeTextBoxDiaVacaciones.Name = "hopeTextBoxDiaVacaciones";
            hopeTextBoxDiaVacaciones.PasswordChar = '\0';
            hopeTextBoxDiaVacaciones.ScrollBars = ScrollBars.None;
            hopeTextBoxDiaVacaciones.SelectedText = "";
            hopeTextBoxDiaVacaciones.SelectionLength = 0;
            hopeTextBoxDiaVacaciones.SelectionStart = 0;
            hopeTextBoxDiaVacaciones.Size = new Size(94, 43);
            hopeTextBoxDiaVacaciones.TabIndex = 19;
            hopeTextBoxDiaVacaciones.TabStop = false;
            hopeTextBoxDiaVacaciones.UseSystemPasswordChar = false;
            // 
            // hopeComboBoxDepartamento
            // 
            hopeComboBoxDepartamento.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBoxDepartamento.FlatStyle = FlatStyle.Flat;
            hopeComboBoxDepartamento.Font = new Font("Segoe UI", 12F);
            hopeComboBoxDepartamento.FormattingEnabled = true;
            hopeComboBoxDepartamento.ItemHeight = 30;
            hopeComboBoxDepartamento.Location = new Point(23, 182);
            hopeComboBoxDepartamento.Name = "hopeComboBoxDepartamento";
            hopeComboBoxDepartamento.Size = new Size(218, 36);
            hopeComboBoxDepartamento.TabIndex = 18;
            // 
            // hopeComboBoxRol
            // 
            hopeComboBoxRol.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBoxRol.FlatStyle = FlatStyle.Flat;
            hopeComboBoxRol.Font = new Font("Segoe UI", 12F);
            hopeComboBoxRol.FormattingEnabled = true;
            hopeComboBoxRol.ItemHeight = 30;
            hopeComboBoxRol.Items.AddRange(new object[] { "Empleado", "Admin" });
            hopeComboBoxRol.Location = new Point(307, 83);
            hopeComboBoxRol.Name = "hopeComboBoxRol";
            hopeComboBoxRol.Size = new Size(151, 36);
            hopeComboBoxRol.TabIndex = 17;
            // 
            // hopeTextBoxNEmpleado
            // 
            hopeTextBoxNEmpleado.BackColor = Color.White;
            hopeTextBoxNEmpleado.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxNEmpleado.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxNEmpleado.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxNEmpleado.Enabled = false;
            hopeTextBoxNEmpleado.Font = new Font("Segoe UI", 12F);
            hopeTextBoxNEmpleado.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxNEmpleado.Hint = "";
            hopeTextBoxNEmpleado.Location = new Point(23, 85);
            hopeTextBoxNEmpleado.MaxLength = 32767;
            hopeTextBoxNEmpleado.Multiline = false;
            hopeTextBoxNEmpleado.Name = "hopeTextBoxNEmpleado";
            hopeTextBoxNEmpleado.PasswordChar = '\0';
            hopeTextBoxNEmpleado.ScrollBars = ScrollBars.None;
            hopeTextBoxNEmpleado.SelectedText = "";
            hopeTextBoxNEmpleado.SelectionLength = 0;
            hopeTextBoxNEmpleado.SelectionStart = 0;
            hopeTextBoxNEmpleado.Size = new Size(94, 43);
            hopeTextBoxNEmpleado.TabIndex = 16;
            hopeTextBoxNEmpleado.TabStop = false;
            hopeTextBoxNEmpleado.UseSystemPasswordChar = false;
            // 
            // labelDiaVacaciones
            // 
            labelDiaVacaciones.AutoSize = true;
            labelDiaVacaciones.Location = new Point(313, 147);
            labelDiaVacaciones.Name = "labelDiaVacaciones";
            labelDiaVacaciones.Size = new Size(135, 20);
            labelDiaVacaciones.TabIndex = 15;
            labelDiaVacaciones.Text = "Días de vacaciones";
            labelDiaVacaciones.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelDepartamento
            // 
            labelDepartamento.AutoSize = true;
            labelDepartamento.Location = new Point(15, 147);
            labelDepartamento.Name = "labelDepartamento";
            labelDepartamento.Size = new Size(106, 20);
            labelDepartamento.TabIndex = 14;
            labelDepartamento.Text = "Departamento";
            // 
            // Rol
            // 
            Rol.AutoSize = true;
            Rol.Location = new Point(313, 35);
            Rol.Name = "Rol";
            Rol.Size = new Size(31, 20);
            Rol.TabIndex = 13;
            Rol.Text = "Rol";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 35);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 12;
            label2.Text = "Nº Empleado";
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.WhiteSmoke;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButton2.IconColor = Color.FromArgb(136, 136, 136);
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 35;
            iconButton2.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton2.Location = new Point(3, 320);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(181, 29);
            iconButton2.TabIndex = 11;
            iconButton2.Text = "Cancelar";
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(200, 160, 64);
            iconButton1.ForeColor = Color.FromArgb(26, 26, 26);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            iconButton1.IconColor = Color.FromArgb(26, 26, 26);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleRight;
            iconButton1.Location = new Point(307, 320);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(181, 29);
            iconButton1.TabIndex = 10;
            iconButton1.Text = "Siguiente";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += btnSiguiente_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(271, 170);
            label6.Name = "label6";
            label6.Size = new Size(67, 20);
            label6.TabIndex = 3;
            label6.Text = "Teléfono";
            // 
            // panelPaso1
            // 
            panelPaso1.Controls.Add(iconButtonSiguiente);
            panelPaso1.Controls.Add(iconButtonCancelar);
            panelPaso1.Controls.Add(hopeTextBoxTelefono);
            panelPaso1.Controls.Add(label6);
            panelPaso1.Controls.Add(hopeTextBoxDni);
            panelPaso1.Controls.Add(label4);
            panelPaso1.Controls.Add(hopeTextBoxApellido);
            panelPaso1.Controls.Add(hopeTextBoxNombre);
            panelPaso1.Controls.Add(label5);
            panelPaso1.Controls.Add(label3);
            panelPaso1.Dock = DockStyle.Fill;
            panelPaso1.Location = new Point(0, 80);
            panelPaso1.Name = "panelPaso1";
            panelPaso1.Size = new Size(500, 370);
            panelPaso1.TabIndex = 1;
            // 
            // iconButtonSiguiente
            // 
            iconButtonSiguiente.BackColor = Color.FromArgb(200, 160, 64);
            iconButtonSiguiente.ForeColor = Color.FromArgb(26, 26, 26);
            iconButtonSiguiente.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            iconButtonSiguiente.IconColor = Color.FromArgb(26, 26, 26);
            iconButtonSiguiente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSiguiente.IconSize = 30;
            iconButtonSiguiente.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonSiguiente.Location = new Point(288, 310);
            iconButtonSiguiente.Name = "iconButtonSiguiente";
            iconButtonSiguiente.Size = new Size(184, 29);
            iconButtonSiguiente.TabIndex = 9;
            iconButtonSiguiente.Text = "Siguiente";
            iconButtonSiguiente.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonSiguiente.UseVisualStyleBackColor = false;
            iconButtonSiguiente.Click += btnSiguiente_Click;
            // 
            // iconButtonCancelar
            // 
            iconButtonCancelar.BackColor = Color.WhiteSmoke;
            iconButtonCancelar.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButtonCancelar.IconColor = Color.FromArgb(136, 136, 136);
            iconButtonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCancelar.IconSize = 35;
            iconButtonCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonCancelar.Location = new Point(36, 310);
            iconButtonCancelar.Name = "iconButtonCancelar";
            iconButtonCancelar.Size = new Size(181, 29);
            iconButtonCancelar.TabIndex = 8;
            iconButtonCancelar.Text = "Cancelar";
            iconButtonCancelar.UseVisualStyleBackColor = false;
            iconButtonCancelar.Click += iconButtonCancelar_Click;
            // 
            // hopeTextBoxTelefono
            // 
            hopeTextBoxTelefono.BackColor = Color.White;
            hopeTextBoxTelefono.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxTelefono.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxTelefono.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxTelefono.Font = new Font("Segoe UI", 12F);
            hopeTextBoxTelefono.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxTelefono.Hint = "600000000";
            hopeTextBoxTelefono.Location = new Point(271, 216);
            hopeTextBoxTelefono.MaxLength = 32767;
            hopeTextBoxTelefono.Multiline = false;
            hopeTextBoxTelefono.Name = "hopeTextBoxTelefono";
            hopeTextBoxTelefono.PasswordChar = '\0';
            hopeTextBoxTelefono.ScrollBars = ScrollBars.None;
            hopeTextBoxTelefono.SelectedText = "";
            hopeTextBoxTelefono.SelectionLength = 0;
            hopeTextBoxTelefono.SelectionStart = 0;
            hopeTextBoxTelefono.Size = new Size(226, 43);
            hopeTextBoxTelefono.TabIndex = 7;
            hopeTextBoxTelefono.TabStop = false;
            hopeTextBoxTelefono.UseSystemPasswordChar = false;
            // 
            // hopeTextBoxDni
            // 
            hopeTextBoxDni.BackColor = Color.White;
            hopeTextBoxDni.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxDni.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxDni.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxDni.Font = new Font("Segoe UI", 12F);
            hopeTextBoxDni.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxDni.Hint = " 12345678A";
            hopeTextBoxDni.Location = new Point(15, 216);
            hopeTextBoxDni.MaxLength = 32767;
            hopeTextBoxDni.Multiline = false;
            hopeTextBoxDni.Name = "hopeTextBoxDni";
            hopeTextBoxDni.PasswordChar = '\0';
            hopeTextBoxDni.ScrollBars = ScrollBars.None;
            hopeTextBoxDni.SelectedText = "";
            hopeTextBoxDni.SelectionLength = 0;
            hopeTextBoxDni.SelectionStart = 0;
            hopeTextBoxDni.Size = new Size(226, 43);
            hopeTextBoxDni.TabIndex = 6;
            hopeTextBoxDni.TabStop = false;
            hopeTextBoxDni.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 44);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 1;
            label4.Text = "Apellidos";
            // 
            // hopeTextBoxApellido
            // 
            hopeTextBoxApellido.BackColor = Color.White;
            hopeTextBoxApellido.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxApellido.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxApellido.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxApellido.Font = new Font("Segoe UI", 12F);
            hopeTextBoxApellido.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxApellido.Hint = "Introduce el apellido";
            hopeTextBoxApellido.Location = new Point(271, 80);
            hopeTextBoxApellido.MaxLength = 32767;
            hopeTextBoxApellido.Multiline = false;
            hopeTextBoxApellido.Name = "hopeTextBoxApellido";
            hopeTextBoxApellido.PasswordChar = '\0';
            hopeTextBoxApellido.ScrollBars = ScrollBars.None;
            hopeTextBoxApellido.SelectedText = "";
            hopeTextBoxApellido.SelectionLength = 0;
            hopeTextBoxApellido.SelectionStart = 0;
            hopeTextBoxApellido.Size = new Size(226, 43);
            hopeTextBoxApellido.TabIndex = 5;
            hopeTextBoxApellido.TabStop = false;
            hopeTextBoxApellido.UseSystemPasswordChar = false;
            // 
            // hopeTextBoxNombre
            // 
            hopeTextBoxNombre.BackColor = Color.White;
            hopeTextBoxNombre.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxNombre.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxNombre.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxNombre.Font = new Font("Segoe UI", 12F);
            hopeTextBoxNombre.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxNombre.Hint = "Introduce el nombre";
            hopeTextBoxNombre.Location = new Point(15, 80);
            hopeTextBoxNombre.MaxLength = 32767;
            hopeTextBoxNombre.Multiline = false;
            hopeTextBoxNombre.Name = "hopeTextBoxNombre";
            hopeTextBoxNombre.PasswordChar = '\0';
            hopeTextBoxNombre.ScrollBars = ScrollBars.None;
            hopeTextBoxNombre.SelectedText = "";
            hopeTextBoxNombre.SelectionLength = 0;
            hopeTextBoxNombre.SelectionStart = 0;
            hopeTextBoxNombre.Size = new Size(226, 43);
            hopeTextBoxNombre.TabIndex = 4;
            hopeTextBoxNombre.TabStop = false;
            hopeTextBoxNombre.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(15, 170);
            label5.Name = "label5";
            label5.Size = new Size(35, 20);
            label5.TabIndex = 2;
            label5.Text = "DNI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 44);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 0;
            label3.Text = "Nombre";
            // 
            // NuevoEmpleado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(500, 450);
            Controls.Add(panelPaso3);
            Controls.Add(panelPaso2);
            Controls.Add(panelPaso1);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevoEmpleado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevoEmpleado";
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelContenedorBarras.ResumeLayout(false);
            panelPaso3.ResumeLayout(false);
            panelPaso3.PerformLayout();
            panelPaso2.ResumeLayout(false);
            panelPaso2.PerformLayout();
            panelPaso1.ResumeLayout(false);
            panelPaso1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelPaso1;
        private Panel panelContenedorBarras;
        private Panel panelBarra1;
        private Label labelPaso;
        private Label label1;
        private Panel panelBarra3;
        private Panel panelBarra2;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxNombre;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButtonSiguiente;
        private FontAwesome.Sharp.IconButton iconButtonCancelar;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxTelefono;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxDni;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxApellido;
        private Panel panelPaso2;
        private Label Rol;
        private Label label2;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label labelDiaVacaciones;
        private Label labelDepartamento;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxDiaVacaciones;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBoxDepartamento;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBoxRol;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxNEmpleado;
        private Panel panelPaso3;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxContraseña2;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxContraseña1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton3;
        private Label label8;
        private Label label7;
        private Label label9;
    }
}