namespace TFG3.views
{
    partial class GestionNotificaciones
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
            panelSuperior = new Panel();
            btnFichajes = new FontAwesome.Sharp.IconButton();
            BtnVacaciones = new FontAwesome.Sharp.IconButton();
            BtnTareas = new FontAwesome.Sharp.IconButton();
            BtnTodas = new FontAwesome.Sharp.IconButton();
            labelBadge = new Label();
            label1 = new Label();
            panelLista = new Panel();
            dataGridView1 = new DataGridView();
            SinLeer = new DataGridViewTextBoxColumn();
            Titulo = new DataGridViewTextBoxColumn();
            Empleado = new DataGridViewTextBoxColumn();
            Tipo = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            Leida = new DataGridViewTextBoxColumn();
            panelSuperior.SuspendLayout();
            panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 26, 26);
            panelSuperior.Controls.Add(btnFichajes);
            panelSuperior.Controls.Add(BtnVacaciones);
            panelSuperior.Controls.Add(BtnTareas);
            panelSuperior.Controls.Add(BtnTodas);
            panelSuperior.Controls.Add(labelBadge);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1132, 68);
            panelSuperior.TabIndex = 0;
            // 
            // btnFichajes
            // 
            btnFichajes.BackColor = Color.FromArgb(200, 160, 64);
            btnFichajes.ForeColor = Color.FromArgb(26, 26, 26);
            btnFichajes.IconChar = FontAwesome.Sharp.IconChar.None;
            btnFichajes.IconColor = Color.Black;
            btnFichajes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnFichajes.Location = new Point(977, 12);
            btnFichajes.Name = "btnFichajes";
            btnFichajes.Size = new Size(129, 41);
            btnFichajes.TabIndex = 5;
            btnFichajes.Text = "Fichajes";
            btnFichajes.UseVisualStyleBackColor = false;
            btnFichajes.Click += btnFichajes_Click;
            // 
            // BtnVacaciones
            // 
            BtnVacaciones.BackColor = Color.FromArgb(200, 160, 64);
            BtnVacaciones.ForeColor = Color.FromArgb(26, 26, 26);
            BtnVacaciones.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnVacaciones.IconColor = Color.Black;
            BtnVacaciones.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnVacaciones.Location = new Point(830, 12);
            BtnVacaciones.Name = "BtnVacaciones";
            BtnVacaciones.Size = new Size(129, 41);
            BtnVacaciones.TabIndex = 4;
            BtnVacaciones.Text = "Vacaciones";
            BtnVacaciones.UseVisualStyleBackColor = false;
            BtnVacaciones.Click += btnVacaciones_Click;
            // 
            // BtnTareas
            // 
            BtnTareas.BackColor = Color.FromArgb(200, 160, 64);
            BtnTareas.ForeColor = Color.FromArgb(26, 26, 26);
            BtnTareas.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnTareas.IconColor = Color.Black;
            BtnTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnTareas.Location = new Point(683, 12);
            BtnTareas.Name = "BtnTareas";
            BtnTareas.Size = new Size(129, 41);
            BtnTareas.TabIndex = 3;
            BtnTareas.Text = "Tareas";
            BtnTareas.UseVisualStyleBackColor = false;
            BtnTareas.Click += btnTareas_Click;
            // 
            // BtnTodas
            // 
            BtnTodas.BackColor = Color.FromArgb(200, 160, 64);
            BtnTodas.ForeColor = Color.FromArgb(26, 26, 26);
            BtnTodas.IconChar = FontAwesome.Sharp.IconChar.None;
            BtnTodas.IconColor = Color.Black;
            BtnTodas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnTodas.Location = new Point(536, 12);
            BtnTodas.Name = "BtnTodas";
            BtnTodas.Size = new Size(129, 41);
            BtnTodas.TabIndex = 2;
            BtnTodas.Text = "Todas";
            BtnTodas.UseVisualStyleBackColor = false;
            BtnTodas.Click += btnTodas_Click;
            // 
            // labelBadge
            // 
            labelBadge.AutoSize = true;
            labelBadge.BackColor = Color.FromArgb(212, 5, 17);
            labelBadge.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelBadge.ForeColor = Color.White;
            labelBadge.Location = new Point(218, 0);
            labelBadge.Name = "labelBadge";
            labelBadge.Size = new Size(89, 28);
            labelBadge.TabIndex = 1;
            labelBadge.Text = "0 sin leer";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(173, 28);
            label1.TabIndex = 0;
            label1.Text = "NOTIFICACIONES";
            // 
            // panelLista
            // 
            panelLista.AutoScroll = true;
            panelLista.Controls.Add(dataGridView1);
            panelLista.Dock = DockStyle.Fill;
            panelLista.Location = new Point(0, 68);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(1132, 552);
            panelLista.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(200, 160, 64);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { SinLeer, Titulo, Empleado, Tipo, Fecha, Leida });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(200, 160, 64);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1132, 552);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // SinLeer
            // 
            SinLeer.HeaderText = "";
            SinLeer.MinimumWidth = 6;
            SinLeer.Name = "SinLeer";
            SinLeer.ReadOnly = true;
            SinLeer.Width = 125;
            // 
            // Titulo
            // 
            Titulo.HeaderText = "Titulo";
            Titulo.MinimumWidth = 6;
            Titulo.Name = "Titulo";
            Titulo.ReadOnly = true;
            Titulo.Width = 250;
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.MinimumWidth = 6;
            Empleado.Name = "Empleado";
            Empleado.ReadOnly = true;
            Empleado.Width = 125;
            // 
            // Tipo
            // 
            Tipo.HeaderText = "Tipo";
            Tipo.MinimumWidth = 6;
            Tipo.Name = "Tipo";
            Tipo.ReadOnly = true;
            Tipo.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // Leida
            // 
            Leida.HeaderText = "Leida";
            Leida.MinimumWidth = 6;
            Leida.Name = "Leida";
            Leida.ReadOnly = true;
            Leida.Width = 125;
            // 
            // GestionNotificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelLista);
            Controls.Add(panelSuperior);
            Name = "GestionNotificaciones";
            Size = new Size(1132, 620);
            Load += GestionNotificaciones_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelLista.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label labelBadge;
        private Label label1;
        private Panel panelLista;
        private FontAwesome.Sharp.IconButton btnFichajes;
        private FontAwesome.Sharp.IconButton BtnVacaciones;
        private FontAwesome.Sharp.IconButton BtnTareas;
        private FontAwesome.Sharp.IconButton BtnTodas;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn SinLeer;
        private DataGridViewTextBoxColumn Titulo;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn Tipo;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn Leida;
    }
}
