namespace TFG3.views
{
    partial class GestionTareas
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panelSuperior = new Panel();
            iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            iconButtonNueva = new FontAwesome.Sharp.IconButton();
            iconButtonEnProgreso = new FontAwesome.Sharp.IconButton();
            iconButtonPendientes = new FontAwesome.Sharp.IconButton();
            iconButtonTodas = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelInferior = new Panel();
            dataGridView1 = new DataGridView();
            Titulo = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            Prioridad = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            FechLimite = new DataGridViewTextBoxColumn();
            AsinadoPor = new DataGridViewTextBoxColumn();
            panelSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).BeginInit();
            panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 26, 26);
            panelSuperior.Controls.Add(iconPictureBox1);
            panelSuperior.Controls.Add(hopeTextBox2);
            panelSuperior.Controls.Add(iconButtonEliminar);
            panelSuperior.Controls.Add(iconButtonNueva);
            panelSuperior.Controls.Add(iconButtonEnProgreso);
            panelSuperior.Controls.Add(iconButtonPendientes);
            panelSuperior.Controls.Add(iconButtonTodas);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1193, 113);
            panelSuperior.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            iconPictureBox1.BackColor = Color.FromArgb(42, 42, 42);
            iconPictureBox1.ForeColor = Color.FromArgb(200, 160, 64);
            iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            iconPictureBox1.IconColor = Color.FromArgb(200, 160, 64);
            iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconPictureBox1.IconSize = 40;
            iconPictureBox1.Location = new Point(278, 52);
            iconPictureBox1.Name = "iconPictureBox1";
            iconPictureBox1.Size = new Size(40, 40);
            iconPictureBox1.TabIndex = 8;
            iconPictureBox1.TabStop = false;
            // 
            // hopeTextBox2
            // 
            hopeTextBox2.BackColor = Color.FromArgb(42, 42, 42);
            hopeTextBox2.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox2.BorderColorA = Color.FromArgb(200, 160, 64);
            hopeTextBox2.BorderColorB = Color.FromArgb(200, 160, 64);
            hopeTextBox2.Font = new Font("Segoe UI", 12F);
            hopeTextBox2.ForeColor = Color.White;
            hopeTextBox2.Hint = "Buscador ...";
            hopeTextBox2.Location = new Point(16, 49);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '\0';
            hopeTextBox2.ScrollBars = ScrollBars.None;
            hopeTextBox2.SelectedText = "";
            hopeTextBox2.SelectionLength = 0;
            hopeTextBox2.SelectionStart = 0;
            hopeTextBox2.Size = new Size(244, 43);
            hopeTextBox2.TabIndex = 7;
            hopeTextBox2.TabStop = false;
            hopeTextBox2.UseSystemPasswordChar = false;
            hopeTextBox2.TextChanged += hopeTextBox2_TextChanged;
            // 
            // iconButtonEliminar
            // 
            iconButtonEliminar.BackColor = Color.Red;
            iconButtonEliminar.ForeColor = Color.White;
            iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            iconButtonEliminar.IconColor = Color.White;
            iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEliminar.IconSize = 30;
            iconButtonEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonEliminar.Location = new Point(1038, 7);
            iconButtonEliminar.Name = "iconButtonEliminar";
            iconButtonEliminar.Size = new Size(103, 48);
            iconButtonEliminar.TabIndex = 5;
            iconButtonEliminar.Text = "Eliminar";
            iconButtonEliminar.TextAlign = ContentAlignment.MiddleRight;
            iconButtonEliminar.UseVisualStyleBackColor = false;
            iconButtonEliminar.Click += iconButtonEliminar_Click;
            // 
            // iconButtonNueva
            // 
            iconButtonNueva.BackColor = Color.FromArgb(0, 192, 0);
            iconButtonNueva.ForeColor = Color.Black;
            iconButtonNueva.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            iconButtonNueva.IconColor = Color.Black;
            iconButtonNueva.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonNueva.IconSize = 30;
            iconButtonNueva.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonNueva.Location = new Point(929, 7);
            iconButtonNueva.Name = "iconButtonNueva";
            iconButtonNueva.Size = new Size(103, 48);
            iconButtonNueva.TabIndex = 4;
            iconButtonNueva.Text = "Nueva";
            iconButtonNueva.TextAlign = ContentAlignment.MiddleRight;
            iconButtonNueva.UseVisualStyleBackColor = false;
            iconButtonNueva.Click += iconButtonNueva_Click;
            // 
            // iconButtonEnProgreso
            // 
            iconButtonEnProgreso.BackColor = Color.FromArgb(42, 42, 42);
            iconButtonEnProgreso.ForeColor = Color.White;
            iconButtonEnProgreso.IconChar = FontAwesome.Sharp.IconChar.Spinner;
            iconButtonEnProgreso.IconColor = Color.White;
            iconButtonEnProgreso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEnProgreso.IconSize = 30;
            iconButtonEnProgreso.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonEnProgreso.Location = new Point(785, 7);
            iconButtonEnProgreso.Name = "iconButtonEnProgreso";
            iconButtonEnProgreso.Size = new Size(129, 48);
            iconButtonEnProgreso.TabIndex = 3;
            iconButtonEnProgreso.Text = "En progreso";
            iconButtonEnProgreso.TextAlign = ContentAlignment.MiddleRight;
            iconButtonEnProgreso.UseVisualStyleBackColor = false;
            iconButtonEnProgreso.Click += btnEnProgreso_Click;
            // 
            // iconButtonPendientes
            // 
            iconButtonPendientes.BackColor = Color.FromArgb(42, 42, 42);
            iconButtonPendientes.ForeColor = Color.White;
            iconButtonPendientes.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconButtonPendientes.IconColor = Color.White;
            iconButtonPendientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonPendientes.IconSize = 30;
            iconButtonPendientes.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonPendientes.Location = new Point(651, 7);
            iconButtonPendientes.Name = "iconButtonPendientes";
            iconButtonPendientes.Size = new Size(117, 48);
            iconButtonPendientes.TabIndex = 2;
            iconButtonPendientes.Text = "Pendientes";
            iconButtonPendientes.TextAlign = ContentAlignment.MiddleRight;
            iconButtonPendientes.UseVisualStyleBackColor = false;
            iconButtonPendientes.Click += btnPendientes_Click;
            // 
            // iconButtonTodas
            // 
            iconButtonTodas.BackColor = Color.FromArgb(200, 160, 64);
            iconButtonTodas.ForeColor = Color.FromArgb(26, 26, 26);
            iconButtonTodas.IconChar = FontAwesome.Sharp.IconChar.ListAlt;
            iconButtonTodas.IconColor = Color.Black;
            iconButtonTodas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonTodas.IconSize = 30;
            iconButtonTodas.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonTodas.Location = new Point(527, 9);
            iconButtonTodas.Name = "iconButtonTodas";
            iconButtonTodas.Size = new Size(107, 46);
            iconButtonTodas.TabIndex = 1;
            iconButtonTodas.Text = "Todas";
            iconButtonTodas.TextAlign = ContentAlignment.MiddleRight;
            iconButtonTodas.UseVisualStyleBackColor = false;
            iconButtonTodas.Click += btnTodas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(248, 28);
            label1.TabIndex = 0;
            label1.Text = "ASIGNACIÓN DE TAREAS";
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(dataGridView1);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 113);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1193, 493);
            panelInferior.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLight;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(200, 160, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Titulo, Empleado, Prioridad, Estado, FechLimite, AsinadoPor });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.GridColor = Color.White;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1193, 493);
            dataGridView1.TabIndex = 0;
            // 
            // Titulo
            // 
            Titulo.DataPropertyName = "titulo";
            Titulo.HeaderText = "Tarea";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.SortMode = DataGridViewColumnSortMode.NotSortable;
            Titulo.Width = 450;
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.MinimumWidth = 6;
            Empleado.Name = "Empleado";
            Empleado.ReadOnly = true;
            Empleado.SortMode = DataGridViewColumnSortMode.NotSortable;
            Empleado.Width = 450;
            // 
            // Prioridad
            // 
            Prioridad.DataPropertyName = "prioridad";
            Prioridad.HeaderText = "Prioridad";
            Prioridad.MinimumWidth = 6;
            Prioridad.Name = "Prioridad";
            Prioridad.ReadOnly = true;
            Prioridad.SortMode = DataGridViewColumnSortMode.NotSortable;
            Prioridad.Width = 125;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "estado";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            Estado.Width = 125;
            // 
            // FechLimite
            // 
            FechLimite.HeaderText = "Vence";
            FechLimite.MinimumWidth = 6;
            FechLimite.Name = "FechLimite";
            FechLimite.ReadOnly = true;
            FechLimite.SortMode = DataGridViewColumnSortMode.NotSortable;
            FechLimite.Width = 125;
            // 
            // AsinadoPor
            // 
            AsinadoPor.HeaderText = "Asignado por";
            AsinadoPor.MinimumWidth = 6;
            AsinadoPor.Name = "AsinadoPor";
            AsinadoPor.ReadOnly = true;
            AsinadoPor.Width = 250;
            // 
            // GestionTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelInferior);
            Controls.Add(panelSuperior);
            Name = "GestionTareas";
            Size = new Size(1193, 606);
            Load += GestionTareas_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconPictureBox1).EndInit();
            panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private FontAwesome.Sharp.IconButton iconButtonPendientes;
        private FontAwesome.Sharp.IconButton iconButtonTodas;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButtonNueva;
        private FontAwesome.Sharp.IconButton iconButtonEnProgreso;
        private Panel panelInferior;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn Prioridad;
        private DataGridViewTextBoxColumn Estado;
        private DataGridViewTextBoxColumn FechLimite;
        private DataGridViewTextBoxColumn AsinadoPor;
    }
}
