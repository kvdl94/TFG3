namespace TFG3.views
{
    partial class NuevaTarea
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panelSuperior = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            hopeTextBoxTitulo = new ReaLTaiizor.Controls.HopeTextBox();
            label4 = new Label();
            hopeTextBoxDescripcion = new ReaLTaiizor.Controls.HopeTextBox();
            label5 = new Label();
            hopeComboBoxEmpleado = new ReaLTaiizor.Controls.HopeComboBox();
            guna2ComboBoxPrioridad = new Guna.UI2.WinForms.Guna2ComboBox();
            label6 = new Label();
            label7 = new Label();
            dateTimePicker1 = new DateTimePicker();
            iconButtonCrear = new FontAwesome.Sharp.IconButton();
            iconButtonCancelar = new FontAwesome.Sharp.IconButton();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.Black;
            panelSuperior.Controls.Add(label2);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(736, 76);
            panelSuperior.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(136, 136, 136);
            label2.Location = new Point(21, 41);
            label2.Name = "label2";
            label2.Size = new Size(224, 20);
            label2.TabIndex = 1;
            label2.Text = "Asigna una tarea a un empleado";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 0);
            label1.Name = "label1";
            label1.Size = new Size(148, 28);
            label1.TabIndex = 0;
            label1.Text = "NUEVA TAREA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 99);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 1;
            label3.Text = "Título";
            // 
            // hopeTextBoxTitulo
            // 
            hopeTextBoxTitulo.BackColor = Color.White;
            hopeTextBoxTitulo.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxTitulo.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxTitulo.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxTitulo.Font = new Font("Segoe UI", 12F);
            hopeTextBoxTitulo.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxTitulo.Hint = "Título";
            hopeTextBoxTitulo.Location = new Point(21, 133);
            hopeTextBoxTitulo.MaxLength = 32767;
            hopeTextBoxTitulo.Multiline = false;
            hopeTextBoxTitulo.Name = "hopeTextBoxTitulo";
            hopeTextBoxTitulo.PasswordChar = '\0';
            hopeTextBoxTitulo.ScrollBars = ScrollBars.None;
            hopeTextBoxTitulo.SelectedText = "";
            hopeTextBoxTitulo.SelectionLength = 0;
            hopeTextBoxTitulo.SelectionStart = 0;
            hopeTextBoxTitulo.Size = new Size(110, 43);
            hopeTextBoxTitulo.TabIndex = 2;
            hopeTextBoxTitulo.TabStop = false;
            hopeTextBoxTitulo.UseSystemPasswordChar = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 194);
            label4.Name = "label4";
            label4.Size = new Size(87, 20);
            label4.TabIndex = 3;
            label4.Text = "Descripción";
            // 
            // hopeTextBoxDescripcion
            // 
            hopeTextBoxDescripcion.BackColor = Color.White;
            hopeTextBoxDescripcion.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBoxDescripcion.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxDescripcion.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxDescripcion.Font = new Font("Segoe UI", 12F);
            hopeTextBoxDescripcion.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBoxDescripcion.Hint = "Descripción...";
            hopeTextBoxDescripcion.Location = new Point(21, 238);
            hopeTextBoxDescripcion.MaxLength = 32767;
            hopeTextBoxDescripcion.Multiline = true;
            hopeTextBoxDescripcion.Name = "hopeTextBoxDescripcion";
            hopeTextBoxDescripcion.PasswordChar = '\0';
            hopeTextBoxDescripcion.ScrollBars = ScrollBars.None;
            hopeTextBoxDescripcion.SelectedText = "";
            hopeTextBoxDescripcion.SelectionLength = 0;
            hopeTextBoxDescripcion.SelectionStart = 0;
            hopeTextBoxDescripcion.Size = new Size(633, 92);
            hopeTextBoxDescripcion.TabIndex = 4;
            hopeTextBoxDescripcion.TabStop = false;
            hopeTextBoxDescripcion.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 356);
            label5.Name = "label5";
            label5.Size = new Size(77, 20);
            label5.TabIndex = 5;
            label5.Text = "Empleado";
            // 
            // hopeComboBoxEmpleado
            // 
            hopeComboBoxEmpleado.DrawMode = DrawMode.OwnerDrawFixed;
            hopeComboBoxEmpleado.FlatStyle = FlatStyle.Flat;
            hopeComboBoxEmpleado.Font = new Font("Segoe UI", 12F);
            hopeComboBoxEmpleado.FormattingEnabled = true;
            hopeComboBoxEmpleado.ItemHeight = 30;
            hopeComboBoxEmpleado.Location = new Point(21, 391);
            hopeComboBoxEmpleado.Name = "hopeComboBoxEmpleado";
            hopeComboBoxEmpleado.Size = new Size(224, 36);
            hopeComboBoxEmpleado.TabIndex = 6;
            // 
            // guna2ComboBoxPrioridad
            // 
            guna2ComboBoxPrioridad.BackColor = Color.Transparent;
            guna2ComboBoxPrioridad.CustomizableEdges = customizableEdges1;
            guna2ComboBoxPrioridad.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBoxPrioridad.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBoxPrioridad.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBoxPrioridad.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBoxPrioridad.Font = new Font("Segoe UI", 10F);
            guna2ComboBoxPrioridad.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBoxPrioridad.ItemHeight = 30;
            guna2ComboBoxPrioridad.Location = new Point(365, 391);
            guna2ComboBoxPrioridad.Name = "guna2ComboBoxPrioridad";
            guna2ComboBoxPrioridad.ShadowDecoration.CustomizableEdges = customizableEdges2;
            guna2ComboBoxPrioridad.Size = new Size(175, 36);
            guna2ComboBoxPrioridad.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 356);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 8;
            label6.Text = "Prioridad ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(21, 460);
            label7.Name = "label7";
            label7.Size = new Size(89, 20);
            label7.TabIndex = 9;
            label7.Text = "Fecha límite";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(23, 501);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(310, 27);
            dateTimePicker1.TabIndex = 10;
            dateTimePicker1.Value = new DateTime(2026, 3, 31, 16, 12, 41, 0);
            // 
            // iconButtonCrear
            // 
            iconButtonCrear.BackColor = Color.FromArgb(200, 160, 64);
            iconButtonCrear.ForeColor = Color.FromArgb(26, 26, 26);
            iconButtonCrear.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButtonCrear.IconColor = Color.Black;
            iconButtonCrear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCrear.IconSize = 30;
            iconButtonCrear.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonCrear.Location = new Point(25, 588);
            iconButtonCrear.Name = "iconButtonCrear";
            iconButtonCrear.Size = new Size(379, 44);
            iconButtonCrear.TabIndex = 11;
            iconButtonCrear.Text = "Crear tarea";
            iconButtonCrear.UseVisualStyleBackColor = false;
            iconButtonCrear.Click += btnCrear_Click;
            // 
            // iconButtonCancelar
            // 
            iconButtonCancelar.BackColor = Color.WhiteSmoke;
            iconButtonCancelar.ForeColor = Color.FromArgb(136, 136, 136);
            iconButtonCancelar.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButtonCancelar.IconColor = Color.FromArgb(136, 136, 136);
            iconButtonCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCancelar.IconSize = 30;
            iconButtonCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonCancelar.Location = new Point(502, 590);
            iconButtonCancelar.Name = "iconButtonCancelar";
            iconButtonCancelar.Size = new Size(193, 42);
            iconButtonCancelar.TabIndex = 12;
            iconButtonCancelar.Text = "Cancelar";
            iconButtonCancelar.UseVisualStyleBackColor = false;
            iconButtonCancelar.Click += btnCancelar_Click;
            // 
            // NuevaTarea
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(736, 698);
            Controls.Add(iconButtonCancelar);
            Controls.Add(iconButtonCrear);
            Controls.Add(dateTimePicker1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(guna2ComboBoxPrioridad);
            Controls.Add(hopeComboBoxEmpleado);
            Controls.Add(label5);
            Controls.Add(hopeTextBoxDescripcion);
            Controls.Add(label4);
            Controls.Add(hopeTextBoxTitulo);
            Controls.Add(label3);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "NuevaTarea";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NuevaTarea";
            Load += NuevaTarea_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelSuperior;
        private Label label1;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxTitulo;
        private Label label4;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxDescripcion;
        private Label label5;
        private ReaLTaiizor.Controls.HopeComboBox hopeComboBoxEmpleado;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBoxPrioridad;
        private Label label6;
        private Label label7;
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton iconButtonCrear;
        private FontAwesome.Sharp.IconButton iconButtonCancelar;
    }
}