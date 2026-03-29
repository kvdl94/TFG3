namespace TFG3.views
{
    partial class GestionPlantilla
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dataGridView1 = new DataGridView();
            NUMERO_EMPLEADO = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellidos = new DataGridViewTextBoxColumn();
            DNI = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Teléfono = new DataGridViewTextBoxColumn();
            Rol = new DataGridViewTextBoxColumn();
            Departamento = new DataGridViewTextBoxColumn();
            Activo = new DataGridViewTextBoxColumn();
            Vacaciones = new DataGridViewTextBoxColumn();
            Antigüedad = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(200, 160, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { NUMERO_EMPLEADO, Nombre, Apellidos, DNI, Email, Teléfono, Rol, Departamento, Activo, Vacaciones, Antigüedad });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(200, 160, 64);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.Gainsboro;
            dataGridView1.Location = new Point(-75, 61);
            dataGridView1.Margin = new Padding(0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Size = new Size(1383, 717);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // NUMERO_EMPLEADO
            // 
            NUMERO_EMPLEADO.HeaderText = "Nº Empleado";
            NUMERO_EMPLEADO.MinimumWidth = 6;
            NUMERO_EMPLEADO.Name = "NUMERO_EMPLEADO";
            NUMERO_EMPLEADO.ReadOnly = true;
            NUMERO_EMPLEADO.Width = 110;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            Nombre.Width = 125;
            // 
            // Apellidos
            // 
            Apellidos.DataPropertyName = "apellidos";
            Apellidos.HeaderText = "Apellidos";
            Apellidos.MinimumWidth = 6;
            Apellidos.Name = "Apellidos";
            Apellidos.ReadOnly = true;
            Apellidos.Width = 125;
            // 
            // DNI
            // 
            DNI.DataPropertyName = "dni";
            DNI.HeaderText = "DNI";
            DNI.MinimumWidth = 6;
            DNI.Name = "DNI";
            DNI.ReadOnly = true;
            DNI.Width = 125;
            // 
            // Email
            // 
            Email.DataPropertyName = "email";
            Email.HeaderText = "Email";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.ReadOnly = true;
            Email.Width = 125;
            // 
            // Teléfono
            // 
            Teléfono.DataPropertyName = "telefono";
            Teléfono.HeaderText = "Teléfono";
            Teléfono.MinimumWidth = 6;
            Teléfono.Name = "Teléfono";
            Teléfono.ReadOnly = true;
            Teléfono.Width = 125;
            // 
            // Rol
            // 
            Rol.DataPropertyName = "rol";
            Rol.HeaderText = "Rol";
            Rol.MinimumWidth = 6;
            Rol.Name = "Rol";
            Rol.ReadOnly = true;
            Rol.Width = 125;
            // 
            // Departamento
            // 
            Departamento.HeaderText = "Departamento";
            Departamento.MinimumWidth = 6;
            Departamento.Name = "Departamento";
            Departamento.ReadOnly = true;
            Departamento.Width = 140;
            // 
            // Activo
            // 
            Activo.HeaderText = "Activo";
            Activo.MinimumWidth = 6;
            Activo.Name = "Activo";
            Activo.ReadOnly = true;
            Activo.Width = 125;
            // 
            // Vacaciones
            // 
            Vacaciones.DataPropertyName = "dias_vacaciones";
            Vacaciones.HeaderText = "Días Vacaciones";
            Vacaciones.MinimumWidth = 6;
            Vacaciones.Name = "Vacaciones";
            Vacaciones.ReadOnly = true;
            Vacaciones.Width = 125;
            // 
            // Antigüedad
            // 
            Antigüedad.HeaderText = "Antigüedad";
            Antigüedad.MinimumWidth = 6;
            Antigüedad.Name = "Antigüedad";
            Antigüedad.ReadOnly = true;
            Antigüedad.Width = 125;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(iconButton2);
            panel1.Controls.Add(iconPictureBox1);
            panel1.Controls.Add(iconButton1);
            panel1.Controls.Add(hopeTextBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1401, 58);
            panel1.TabIndex = 1;
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
            iconButton2.Location = new Point(1183, 3);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(215, 43);
            iconButton2.TabIndex = 14;
            iconButton2.Text = "Eliminar";
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(42, 42, 42);
            iconPictureBox1.ForeColor = Color.FromArgb(200, 160, 64);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            iconPictureBox1.IconColor = Color.FromArgb(200, 160, 64);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(261, 3);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 2;
            iconPictureBox1.TabStop = false;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.FromArgb(200, 160, 64);
            iconButton1.ForeColor = Color.FromArgb(26, 26, 26);
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            iconButton1.IconColor = Color.Black;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(962, 3);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(215, 43);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "+ Nuevo";
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.FromArgb(42, 42, 42);
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(200, 160, 64);
            hopeTextBox1.BorderColorB = Color.FromArgb(200, 160, 64);
            hopeTextBox1.Font = new Font("Segoe UI", 12F);
            hopeTextBox1.ForeColor = Color.White;
            hopeTextBox1.Hint = "Buscar empleado...";
            hopeTextBox1.Location = new Point(0, 0);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(244, 43);
            hopeTextBox1.TabIndex = 0;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            hopeTextBox1.TextChanged += hopeTextBox1_TextChanged;
            // 
            // GestionPlantilla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(panel1);
            Name = "GestionPlantilla";
            Size = new Size(1401, 801);
            Load += GestionPlantilla_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn NUMERO_EMPLEADO;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellidos;
        private DataGridViewTextBoxColumn DNI;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Teléfono;
        private DataGridViewTextBoxColumn Rol;
        private DataGridViewTextBoxColumn Departamento;
        private DataGridViewTextBoxColumn Activo;
        private DataGridViewTextBoxColumn Vacaciones;
        private DataGridViewTextBoxColumn Antigüedad;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton2;
    }
}
