namespace TFG3.views
{
    partial class InformeFichajes
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panelSuperior = new Panel();
            labelMes = new Label();
            labelDepartamento = new Label();
            labelNombre = new Label();
            panelResumen = new Panel();
            labelPuntualidad = new Label();
            labelSalidas = new Label();
            labelRetrasos = new Label();
            labelDias = new Label();
            labelTituloPuntualidad = new Label();
            labelTituloSalidas = new Label();
            labelTituloRetrasos = new Label();
            labelTituloDias = new Label();
            dataGridViewFichajes = new DataGridView();
            Fecha = new DataGridViewTextBoxColumn();
            HoraEntrada = new DataGridViewTextBoxColumn();
            HoraSalida = new DataGridViewTextBoxColumn();
            Retraso = new DataGridViewTextBoxColumn();
            Estado = new DataGridViewTextBoxColumn();
            panelBotones = new Panel();
            iconButtonCerrar = new FontAwesome.Sharp.IconButton();
            iconButtonImprimir = new FontAwesome.Sharp.IconButton();
            panelSuperior.SuspendLayout();
            panelResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFichajes).BeginInit();
            panelBotones.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 26, 26);
            panelSuperior.Controls.Add(labelMes);
            panelSuperior.Controls.Add(labelDepartamento);
            panelSuperior.Controls.Add(labelNombre);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(700, 80);
            panelSuperior.TabIndex = 1;
            // 
            // labelMes
            // 
            labelMes.AutoSize = true;
            labelMes.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMes.ForeColor = Color.FromArgb(102, 102, 102);
            labelMes.Location = new Point(564, 46);
            labelMes.Name = "labelMes";
            labelMes.Size = new Size(59, 25);
            labelMes.TabIndex = 5;
            labelMes.Text = "label1";
            // 
            // labelDepartamento
            // 
            labelDepartamento.AutoSize = true;
            labelDepartamento.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelDepartamento.ForeColor = Color.FromArgb(136, 136, 136);
            labelDepartamento.Location = new Point(84, 46);
            labelDepartamento.Name = "labelDepartamento";
            labelDepartamento.Size = new Size(59, 25);
            labelDepartamento.TabIndex = 2;
            labelDepartamento.Text = "label1";
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombre.ForeColor = Color.White;
            labelNombre.Location = new Point(84, 9);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(79, 31);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "label1";
            // 
            // panelResumen
            // 
            panelResumen.BackColor = Color.FromArgb(248, 248, 248);
            panelResumen.Controls.Add(labelPuntualidad);
            panelResumen.Controls.Add(labelSalidas);
            panelResumen.Controls.Add(labelRetrasos);
            panelResumen.Controls.Add(labelDias);
            panelResumen.Controls.Add(labelTituloPuntualidad);
            panelResumen.Controls.Add(labelTituloSalidas);
            panelResumen.Controls.Add(labelTituloRetrasos);
            panelResumen.Controls.Add(labelTituloDias);
            panelResumen.Dock = DockStyle.Top;
            panelResumen.Location = new Point(0, 80);
            panelResumen.Name = "panelResumen";
            panelResumen.Size = new Size(700, 70);
            panelResumen.TabIndex = 2;
            // 
            // labelPuntualidad
            // 
            labelPuntualidad.AutoSize = true;
            labelPuntualidad.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPuntualidad.ForeColor = Color.FromArgb(26, 26, 26);
            labelPuntualidad.Location = new Point(531, 26);
            labelPuntualidad.Name = "labelPuntualidad";
            labelPuntualidad.Size = new Size(61, 41);
            labelPuntualidad.TabIndex = 7;
            labelPuntualidad.Text = "0%";
            // 
            // labelSalidas
            // 
            labelSalidas.AutoSize = true;
            labelSalidas.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelSalidas.ForeColor = Color.FromArgb(200, 160, 64);
            labelSalidas.Location = new Point(345, 26);
            labelSalidas.Name = "labelSalidas";
            labelSalidas.Size = new Size(35, 41);
            labelSalidas.TabIndex = 6;
            labelSalidas.Text = "0";
            // 
            // labelRetrasos
            // 
            labelRetrasos.AutoSize = true;
            labelRetrasos.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRetrasos.ForeColor = Color.FromArgb(212, 5, 17);
            labelRetrasos.Location = new Point(189, 26);
            labelRetrasos.Name = "labelRetrasos";
            labelRetrasos.Size = new Size(35, 41);
            labelRetrasos.TabIndex = 5;
            labelRetrasos.Text = "0";
            // 
            // labelDias
            // 
            labelDias.AutoSize = true;
            labelDias.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelDias.Location = new Point(29, 26);
            labelDias.Name = "labelDias";
            labelDias.Size = new Size(35, 41);
            labelDias.TabIndex = 4;
            labelDias.Text = "0";
            // 
            // labelTituloPuntualidad
            // 
            labelTituloPuntualidad.AutoSize = true;
            labelTituloPuntualidad.ForeColor = Color.FromArgb(136, 136, 136);
            labelTituloPuntualidad.Location = new Point(506, 1);
            labelTituloPuntualidad.Name = "labelTituloPuntualidad";
            labelTituloPuntualidad.Size = new Size(88, 20);
            labelTituloPuntualidad.TabIndex = 3;
            labelTituloPuntualidad.Text = "Puntualidad";
            // 
            // labelTituloSalidas
            // 
            labelTituloSalidas.AutoSize = true;
            labelTituloSalidas.ForeColor = Color.FromArgb(136, 136, 136);
            labelTituloSalidas.Location = new Point(319, 1);
            labelTituloSalidas.Name = "labelTituloSalidas";
            labelTituloSalidas.Size = new Size(95, 20);
            labelTituloSalidas.TabIndex = 2;
            labelTituloSalidas.Text = "Salidas tarde";
            // 
            // labelTituloRetrasos
            // 
            labelTituloRetrasos.AutoSize = true;
            labelTituloRetrasos.ForeColor = Color.FromArgb(136, 136, 136);
            labelTituloRetrasos.Location = new Point(183, 1);
            labelTituloRetrasos.Name = "labelTituloRetrasos";
            labelTituloRetrasos.Size = new Size(65, 20);
            labelTituloRetrasos.TabIndex = 1;
            labelTituloRetrasos.Text = "Retrasos";
            // 
            // labelTituloDias
            // 
            labelTituloDias.AutoSize = true;
            labelTituloDias.ForeColor = Color.FromArgb(136, 136, 136);
            labelTituloDias.Location = new Point(7, 1);
            labelTituloDias.Name = "labelTituloDias";
            labelTituloDias.Size = new Size(113, 20);
            labelTituloDias.TabIndex = 0;
            labelTituloDias.Text = "Días trabajados";
            // 
            // dataGridViewFichajes
            // 
            dataGridViewFichajes.AllowUserToAddRows = false;
            dataGridViewFichajes.AllowUserToDeleteRows = false;
            dataGridViewFichajes.BackgroundColor = Color.White;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(26, 26, 26);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(200, 160, 64);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewFichajes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewFichajes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFichajes.Columns.AddRange(new DataGridViewColumn[] { Fecha, HoraEntrada, HoraSalida, Retraso, Estado });
            dataGridViewFichajes.Dock = DockStyle.Fill;
            dataGridViewFichajes.EnableHeadersVisualStyles = false;
            dataGridViewFichajes.Location = new Point(0, 150);
            dataGridViewFichajes.Name = "dataGridViewFichajes";
            dataGridViewFichajes.ReadOnly = true;
            dataGridViewFichajes.RowHeadersVisible = false;
            dataGridViewFichajes.RowHeadersWidth = 51;
            dataGridViewFichajes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewFichajes.Size = new Size(700, 450);
            dataGridViewFichajes.TabIndex = 3;
            // 
            // Fecha
            // 
            Fecha.DataPropertyName = "fecha";
            Fecha.HeaderText = "fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // HoraEntrada
            // 
            HoraEntrada.DataPropertyName = "hora_entrada";
            HoraEntrada.HeaderText = "Entrada";
            HoraEntrada.MinimumWidth = 6;
            HoraEntrada.Name = "HoraEntrada";
            HoraEntrada.ReadOnly = true;
            HoraEntrada.Width = 125;
            // 
            // HoraSalida
            // 
            HoraSalida.DataPropertyName = "hora_salida";
            HoraSalida.HeaderText = "Salida";
            HoraSalida.MinimumWidth = 6;
            HoraSalida.Name = "HoraSalida";
            HoraSalida.ReadOnly = true;
            HoraSalida.Width = 125;
            // 
            // Retraso
            // 
            Retraso.HeaderText = "Retraso";
            Retraso.MinimumWidth = 6;
            Retraso.Name = "Retraso";
            Retraso.ReadOnly = true;
            Retraso.Width = 125;
            // 
            // Estado
            // 
            Estado.HeaderText = "Estado";
            Estado.MinimumWidth = 6;
            Estado.Name = "Estado";
            Estado.ReadOnly = true;
            Estado.Width = 125;
            // 
            // panelBotones
            // 
            panelBotones.Controls.Add(iconButtonCerrar);
            panelBotones.Controls.Add(iconButtonImprimir);
            panelBotones.Dock = DockStyle.Bottom;
            panelBotones.Location = new Point(0, 550);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(700, 50);
            panelBotones.TabIndex = 4;
            // 
            // iconButtonCerrar
            // 
            iconButtonCerrar.BackColor = Color.WhiteSmoke;
            iconButtonCerrar.ForeColor = Color.FromArgb(136, 136, 136);
            iconButtonCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            iconButtonCerrar.IconColor = Color.FromArgb(136, 136, 136);
            iconButtonCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonCerrar.IconSize = 25;
            iconButtonCerrar.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonCerrar.Location = new Point(469, 9);
            iconButtonCerrar.Name = "iconButtonCerrar";
            iconButtonCerrar.Size = new Size(209, 29);
            iconButtonCerrar.TabIndex = 1;
            iconButtonCerrar.Text = "Cerrar";
            iconButtonCerrar.UseVisualStyleBackColor = false;
            iconButtonCerrar.Click += btnCerrar_Click;
            // 
            // iconButtonImprimir
            // 
            iconButtonImprimir.BackColor = Color.FromArgb(26, 26, 26);
            iconButtonImprimir.ForeColor = Color.FromArgb(200, 160, 64);
            iconButtonImprimir.IconChar = FontAwesome.Sharp.IconChar.Print;
            iconButtonImprimir.IconColor = Color.FromArgb(200, 160, 64);
            iconButtonImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonImprimir.IconSize = 25;
            iconButtonImprimir.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonImprimir.Location = new Point(226, 4);
            iconButtonImprimir.Name = "iconButtonImprimir";
            iconButtonImprimir.Size = new Size(209, 38);
            iconButtonImprimir.TabIndex = 0;
            iconButtonImprimir.Text = "Imprimir PDF";
            iconButtonImprimir.UseVisualStyleBackColor = false;
            iconButtonImprimir.Click += btnImprimir_Click;
            // 
            // InformeFichajes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 600);
            Controls.Add(panelBotones);
            Controls.Add(dataGridViewFichajes);
            Controls.Add(panelResumen);
            Controls.Add(panelSuperior);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InformeFichajes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InformeFichajes";
            Load += InformeFichajes_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panelResumen.ResumeLayout(false);
            panelResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFichajes).EndInit();
            panelBotones.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Panel panelResumen;
        private DataGridView dataGridViewFichajes;
        private Panel panelBotones;
        private Label labelDepartamento;
        private Label labelNombre;
        private Label labelMes;
        private Label labelTituloSalidas;
        private Label labelTituloRetrasos;
        private Label labelTituloDias;
        private Label labelTituloPuntualidad;
        private Label labelPuntualidad;
        private Label labelSalidas;
        private Label labelRetrasos;
        private Label labelDias;
        private DataGridViewTextBoxColumn Fecha;
        private DataGridViewTextBoxColumn HoraEntrada;
        private DataGridViewTextBoxColumn HoraSalida;
        private DataGridViewTextBoxColumn Retraso;
        private DataGridViewTextBoxColumn Estado;
        private FontAwesome.Sharp.IconButton iconButtonImprimir;
        private FontAwesome.Sharp.IconButton iconButtonCerrar;
    }
}