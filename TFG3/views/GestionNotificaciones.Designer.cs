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
            panelSuperior = new Panel();
            labelBadge = new Label();
            label1 = new Label();
            panelLista = new Panel();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 26, 26);
            panelSuperior.Controls.Add(labelBadge);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(714, 68);
            panelSuperior.TabIndex = 0;
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
            panelLista.Dock = DockStyle.Fill;
            panelLista.Location = new Point(0, 68);
            panelLista.Name = "panelLista";
            panelLista.Size = new Size(714, 552);
            panelLista.TabIndex = 1;
            // 
            // GestionNotificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panelLista);
            Controls.Add(panelSuperior);
            Name = "GestionNotificaciones";
            Size = new Size(714, 620);
            Load += GestionNotificaciones_Load;
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelSuperior;
        private Label labelBadge;
        private Label label1;
        private Panel panelLista;
    }
}
