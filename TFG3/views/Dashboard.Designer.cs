namespace TFG3.views
{
    partial class Dashboard
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
            panelSuperior = new Panel();
            labelFechaActual = new Label();
            labelFecha = new Label();
            panel1 = new Panel();
            panelFichajes = new Panel();
            label10 = new Label();
            panel5 = new Panel();
            label6 = new Label();
            panelTareas = new Panel();
            label9 = new Label();
            panel4 = new Panel();
            label5 = new Label();
            panelVacaciones = new Panel();
            label8 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panelEmpleados = new Panel();
            label7 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            panelIzquierdo = new Panel();
            panelBarras = new Panel();
            labelEmpleadosPorDepartamento = new Label();
            panelDrecho = new Panel();
            panelFichajes2 = new Panel();
            labelFichajesDeHoy = new Label();
            panelSuperior.SuspendLayout();
            panel1.SuspendLayout();
            panelFichajes.SuspendLayout();
            panelTareas.SuspendLayout();
            panelVacaciones.SuspendLayout();
            panelEmpleados.SuspendLayout();
            panelIzquierdo.SuspendLayout();
            panelBarras.SuspendLayout();
            panelDrecho.SuspendLayout();
            panelFichajes2.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 26, 26);
            panelSuperior.Controls.Add(labelFechaActual);
            panelSuperior.Controls.Add(labelFecha);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(1295, 80);
            panelSuperior.TabIndex = 0;
            // 
            // labelFechaActual
            // 
            labelFechaActual.AutoSize = true;
            labelFechaActual.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFechaActual.ForeColor = Color.FromArgb(136, 136, 136);
            labelFechaActual.Location = new Point(3, 57);
            labelFechaActual.Name = "labelFechaActual";
            labelFechaActual.Size = new Size(55, 23);
            labelFechaActual.TabIndex = 1;
            labelFechaActual.Text = "label1";
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFecha.ForeColor = Color.White;
            labelFecha.Location = new Point(3, 0);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(306, 41);
            labelFecha.TabIndex = 0;
            labelFecha.Text = "PANEL DE CONTROL";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panelFichajes);
            panel1.Controls.Add(panelTareas);
            panel1.Controls.Add(panelVacaciones);
            panel1.Controls.Add(panelEmpleados);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 80);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1295, 120);
            panel1.TabIndex = 1;
            // 
            // panelFichajes
            // 
            panelFichajes.BackColor = Color.FromArgb(26, 26, 26);
            panelFichajes.BorderStyle = BorderStyle.FixedSingle;
            panelFichajes.Controls.Add(label10);
            panelFichajes.Controls.Add(panel5);
            panelFichajes.Controls.Add(label6);
            panelFichajes.Location = new Point(1095, 30);
            panelFichajes.Name = "panelFichajes";
            panelFichajes.Size = new Size(200, 90);
            panelFichajes.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(0, 192, 0);
            label10.Location = new Point(78, 34);
            label10.Name = "label10";
            label10.Size = new Size(43, 50);
            label10.TabIndex = 6;
            label10.Text = "0";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(0, 192, 0);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(14, 88);
            panel5.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.FromArgb(136, 136, 136);
            label6.Location = new Point(20, 0);
            label6.Name = "label6";
            label6.Size = new Size(89, 20);
            label6.TabIndex = 0;
            label6.Text = "Fichajes hoy";
            // 
            // panelTareas
            // 
            panelTareas.BackColor = Color.FromArgb(26, 26, 26);
            panelTareas.BorderStyle = BorderStyle.FixedSingle;
            panelTareas.Controls.Add(label9);
            panelTareas.Controls.Add(panel4);
            panelTareas.Controls.Add(label5);
            panelTareas.Location = new Point(708, 32);
            panelTareas.Name = "panelTareas";
            panelTareas.Size = new Size(200, 90);
            panelTareas.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(200, 160, 64);
            label9.Location = new Point(76, 35);
            label9.Name = "label9";
            label9.Size = new Size(43, 50);
            label9.TabIndex = 6;
            label9.Text = "0";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(200, 160, 64);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(14, 88);
            panel4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(136, 136, 136);
            label5.Location = new Point(20, -1);
            label5.Name = "label5";
            label5.Size = new Size(127, 20);
            label5.TabIndex = 0;
            label5.Text = "Tareas pendientes";
            // 
            // panelVacaciones
            // 
            panelVacaciones.BackColor = Color.FromArgb(26, 26, 26);
            panelVacaciones.BorderStyle = BorderStyle.FixedSingle;
            panelVacaciones.Controls.Add(label8);
            panelVacaciones.Controls.Add(panel3);
            panelVacaciones.Controls.Add(label2);
            panelVacaciones.Location = new Point(332, 31);
            panelVacaciones.Name = "panelVacaciones";
            panelVacaciones.Size = new Size(200, 90);
            panelVacaciones.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(78, 35);
            label8.Name = "label8";
            label8.Size = new Size(43, 50);
            label8.TabIndex = 6;
            label8.Text = "0";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Red;
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(14, 88);
            panel3.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(136, 136, 136);
            label2.Location = new Point(20, 1);
            label2.Name = "label2";
            label2.Size = new Size(110, 20);
            label2.TabIndex = 1;
            label2.Text = "Vac. Pendientes";
            // 
            // panelEmpleados
            // 
            panelEmpleados.BackColor = Color.FromArgb(26, 26, 26);
            panelEmpleados.BorderStyle = BorderStyle.FixedSingle;
            panelEmpleados.Controls.Add(label7);
            panelEmpleados.Controls.Add(panel2);
            panelEmpleados.Controls.Add(label1);
            panelEmpleados.Location = new Point(3, 27);
            panelEmpleados.Name = "panelEmpleados";
            panelEmpleados.Size = new Size(200, 90);
            panelEmpleados.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.FromArgb(200, 160, 64);
            label7.Location = new Point(70, 38);
            label7.Name = "label7";
            label7.Size = new Size(43, 50);
            label7.TabIndex = 5;
            label7.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(200, 160, 64);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(14, 88);
            panel2.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(136, 136, 136);
            label1.Location = new Point(20, 2);
            label1.Name = "label1";
            label1.Size = new Size(120, 20);
            label1.TabIndex = 0;
            label1.Text = "Total empleados";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(136, 136, 136);
            label3.Location = new Point(-1, 0);
            label3.Name = "label3";
            label3.Size = new Size(127, 20);
            label3.TabIndex = 1;
            label3.Text = "Tareas pendientes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(136, 136, 136);
            label4.Location = new Point(-1, 0);
            label4.Name = "label4";
            label4.Size = new Size(89, 20);
            label4.TabIndex = 1;
            label4.Text = "Fichajes hoy";
            // 
            // panelIzquierdo
            // 
            panelIzquierdo.BackColor = Color.White;
            panelIzquierdo.Controls.Add(panelBarras);
            panelIzquierdo.Dock = DockStyle.Left;
            panelIzquierdo.Location = new Point(0, 200);
            panelIzquierdo.Name = "panelIzquierdo";
            panelIzquierdo.Size = new Size(629, 601);
            panelIzquierdo.TabIndex = 2;
            // 
            // panelBarras
            // 
            panelBarras.Controls.Add(labelEmpleadosPorDepartamento);
            panelBarras.Location = new Point(4, 34);
            panelBarras.Name = "panelBarras";
            panelBarras.Size = new Size(622, 564);
            panelBarras.TabIndex = 1;
            // 
            // labelEmpleadosPorDepartamento
            // 
            labelEmpleadosPorDepartamento.AutoSize = true;
            labelEmpleadosPorDepartamento.Dock = DockStyle.Top;
            labelEmpleadosPorDepartamento.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEmpleadosPorDepartamento.ForeColor = Color.FromArgb(26, 26, 26);
            labelEmpleadosPorDepartamento.Location = new Point(0, 0);
            labelEmpleadosPorDepartamento.Name = "labelEmpleadosPorDepartamento";
            labelEmpleadosPorDepartamento.Size = new Size(296, 28);
            labelEmpleadosPorDepartamento.TabIndex = 0;
            labelEmpleadosPorDepartamento.Text = "Empleados por Departamento";
            // 
            // panelDrecho
            // 
            panelDrecho.BackColor = Color.White;
            panelDrecho.Controls.Add(panelFichajes2);
            panelDrecho.Dock = DockStyle.Right;
            panelDrecho.Location = new Point(624, 200);
            panelDrecho.Name = "panelDrecho";
            panelDrecho.Size = new Size(671, 601);
            panelDrecho.TabIndex = 3;
            // 
            // panelFichajes2
            // 
            panelFichajes2.Controls.Add(labelFichajesDeHoy);
            panelFichajes2.Location = new Point(0, 34);
            panelFichajes2.Name = "panelFichajes2";
            panelFichajes2.Size = new Size(568, 564);
            panelFichajes2.TabIndex = 1;
            // 
            // labelFichajesDeHoy
            // 
            labelFichajesDeHoy.AutoSize = true;
            labelFichajesDeHoy.Dock = DockStyle.Top;
            labelFichajesDeHoy.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFichajesDeHoy.ForeColor = Color.FromArgb(26, 26, 26);
            labelFichajesDeHoy.Location = new Point(0, 0);
            labelFichajesDeHoy.Name = "labelFichajesDeHoy";
            labelFichajesDeHoy.Size = new Size(157, 28);
            labelFichajesDeHoy.TabIndex = 0;
            labelFichajesDeHoy.Text = "Fichajes de hoy";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelDrecho);
            Controls.Add(panelIzquierdo);
            Controls.Add(panel1);
            Controls.Add(panelSuperior);
            Name = "Dashboard";
            Size = new Size(1295, 801);
            Load += Dashboard_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            panel1.ResumeLayout(false);
            panelFichajes.ResumeLayout(false);
            panelFichajes.PerformLayout();
            panelTareas.ResumeLayout(false);
            panelTareas.PerformLayout();
            panelVacaciones.ResumeLayout(false);
            panelVacaciones.PerformLayout();
            panelEmpleados.ResumeLayout(false);
            panelEmpleados.PerformLayout();
            panelIzquierdo.ResumeLayout(false);
            panelBarras.ResumeLayout(false);
            panelBarras.PerformLayout();
            panelDrecho.ResumeLayout(false);
            panelFichajes2.ResumeLayout(false);
            panelFichajes2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label labelFecha;
        private Label labelFechaActual;
        private Panel panel1;
        private Panel panelEmpleados;
        private Panel panel4;
        private Panel panel3;
        private Panel panelVacaciones;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panelFichajes;
        private Label label6;
        private Panel panelTareas;
        private Label label5;
        private Panel panel2;
        private Panel panel5;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Panel panelIzquierdo;
        private Panel panelDrecho;
        private Label labelEmpleadosPorDepartamento;
        private Label labelFichajesDeHoy;
        private Panel panelBarras;
        private Panel panelFichajes2;
    }
}
