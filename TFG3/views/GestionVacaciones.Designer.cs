namespace TFG3.views
{
    partial class GestionVacaciones
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
            panel1 = new Panel();
            iconButtonRechazadas = new FontAwesome.Sharp.IconButton();
            iconButtonAprobadas = new FontAwesome.Sharp.IconButton();
            iconButtonPendientes = new FontAwesome.Sharp.IconButton();
            iconButtonTodas = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            panelInferior = new Panel();
            dataGridView1 = new DataGridView();
            Empleado = new DataGridViewTextBoxColumn();
            FechaInicio = new DataGridViewTextBoxColumn();
            FechaFin = new DataGridViewTextBoxColumn();
            Dias = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panelInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(iconButtonRechazadas);
            panel1.Controls.Add(iconButtonAprobadas);
            panel1.Controls.Add(iconButtonPendientes);
            panel1.Controls.Add(iconButtonTodas);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1242, 55);
            panel1.TabIndex = 0;
            // 
            // iconButtonRechazadas
            // 
            iconButtonRechazadas.BackColor = Color.FromArgb(42, 42, 42);
            iconButtonRechazadas.ForeColor = Color.Red;
            iconButtonRechazadas.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            iconButtonRechazadas.IconColor = Color.Red;
            iconButtonRechazadas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonRechazadas.IconSize = 30;
            iconButtonRechazadas.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonRechazadas.Location = new Point(858, 8);
            iconButtonRechazadas.Name = "iconButtonRechazadas";
            iconButtonRechazadas.Size = new Size(127, 34);
            iconButtonRechazadas.TabIndex = 4;
            iconButtonRechazadas.Text = "Rechazadas";
            iconButtonRechazadas.TextAlign = ContentAlignment.MiddleRight;
            iconButtonRechazadas.UseVisualStyleBackColor = false;
            iconButtonRechazadas.Click += iconButtonRechazadas_Click;
            // 
            // iconButtonAprobadas
            // 
            iconButtonAprobadas.BackColor = Color.FromArgb(42, 42, 42);
            iconButtonAprobadas.ForeColor = Color.FromArgb(0, 192, 0);
            iconButtonAprobadas.IconChar = FontAwesome.Sharp.IconChar.Check;
            iconButtonAprobadas.IconColor = Color.FromArgb(0, 192, 0);
            iconButtonAprobadas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAprobadas.IconSize = 30;
            iconButtonAprobadas.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonAprobadas.Location = new Point(725, 8);
            iconButtonAprobadas.Name = "iconButtonAprobadas";
            iconButtonAprobadas.Size = new Size(114, 34);
            iconButtonAprobadas.TabIndex = 3;
            iconButtonAprobadas.Text = "Aprobadas";
            iconButtonAprobadas.TextAlign = ContentAlignment.MiddleRight;
            iconButtonAprobadas.UseVisualStyleBackColor = false;
            iconButtonAprobadas.Click += btnAprobadas_Click;
            // 
            // iconButtonPendientes
            // 
            iconButtonPendientes.BackColor = Color.FromArgb(42, 42, 42);
            iconButtonPendientes.ForeColor = Color.FromArgb(136, 136, 136);
            iconButtonPendientes.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconButtonPendientes.IconColor = Color.FromArgb(136, 136, 136);
            iconButtonPendientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonPendientes.IconSize = 25;
            iconButtonPendientes.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonPendientes.Location = new Point(580, 7);
            iconButtonPendientes.Name = "iconButtonPendientes";
            iconButtonPendientes.Size = new Size(121, 35);
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
            iconButtonTodas.Location = new Point(451, 5);
            iconButtonTodas.Name = "iconButtonTodas";
            iconButtonTodas.Size = new Size(112, 35);
            iconButtonTodas.TabIndex = 1;
            iconButtonTodas.Text = "Todas";
            iconButtonTodas.TextAlign = ContentAlignment.MiddleRight;
            iconButtonTodas.UseVisualStyleBackColor = false;
            iconButtonTodas.Click += btnTodas_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 3);
            label1.Name = "label1";
            label1.Size = new Size(338, 31);
            label1.TabIndex = 0;
            label1.Text = "SOLICITUDES DE VACACIONES";
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(dataGridView1);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 55);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(1242, 578);
            panelInferior.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(200, 160, 64);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Empleado, FechaInicio, FechaFin, Dias, Estado });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.White;
            dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1242, 578);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // Empleado
            // 
            Empleado.HeaderText = "Empleado";
            Empleado.MinimumWidth = 6;
            Empleado.Name = "Empleado";
            Empleado.ReadOnly = true;
            Empleado.SortMode = DataGridViewColumnSortMode.NotSortable;
            Empleado.Width = 250;
            // 
            // FechaInicio
            // 
            FechaInicio.DataPropertyName = "fecha_inicio";
            FechaInicio.HeaderText = "Desde";
            FechaInicio.MinimumWidth = 6;
            FechaInicio.Name = "FechaInicio";
            FechaInicio.ReadOnly = true;
            FechaInicio.SortMode = DataGridViewColumnSortMode.NotSortable;
            FechaInicio.Width = 125;
            // 
            // FechaFin
            // 
            FechaFin.DataPropertyName = "fecha_fin";
            FechaFin.HeaderText = "Hasta";
            FechaFin.MinimumWidth = 6;
            FechaFin.Name = "FechaFin";
            FechaFin.ReadOnly = true;
            FechaFin.SortMode = DataGridViewColumnSortMode.NotSortable;
            FechaFin.Width = 125;
            // 
            // Dias
            // 
            Dias.HeaderText = "Dias";
            Dias.MinimumWidth = 6;
            Dias.Name = "Dias";
            Dias.ReadOnly = true;
            Dias.SortMode = DataGridViewColumnSortMode.NotSortable;
            Dias.Width = 125;
            // 
            // Estado
            // 
            Estado.DataPropertyName = "estado_solicitud";
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.SortMode = DataGridViewColumnSortMode.NotSortable;
            Estado.Width = 125;
            // 
            // GestionVacaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelInferior);
            Controls.Add(panel1);
            Name = "GestionVacaciones";
            Size = new Size(1242, 633);
            Load += GestionVacaciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInferior.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private FontAwesome.Sharp.IconButton iconButtonAprobadas;
        private FontAwesome.Sharp.IconButton iconButtonPendientes;
        private FontAwesome.Sharp.IconButton iconButtonTodas;
        private Label label1;
        private Panel panelInferior;
        private DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton iconButtonRechazadas;
        private DataGridViewTextBoxColumn Empleado;
        private DataGridViewTextBoxColumn FechaInicio;
        private DataGridViewTextBoxColumn FechaFin;
        private DataGridViewTextBoxColumn Dias;
        private DataGridViewTextBoxColumn Estado;
    }
}
