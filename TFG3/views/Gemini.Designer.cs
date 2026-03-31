namespace TFG3.views
{
    partial class Gemini
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
            panelIA = new Panel();
            panelInferior = new Panel();
            richTextBox1 = new RichTextBox();
            hopeTextBoxPregunta = new ReaLTaiizor.Controls.HopeTextBox();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            panelSuperior = new Panel();
            label1 = new Label();
            label11 = new Label();
            panelIA.SuspendLayout();
            panelInferior.SuspendLayout();
            panelSuperior.SuspendLayout();
            SuspendLayout();
            // 
            // panelIA
            // 
            panelIA.BackColor = Color.White;
            panelIA.Controls.Add(panelInferior);
            panelIA.Controls.Add(panelSuperior);
            panelIA.Dock = DockStyle.Fill;
            panelIA.Location = new Point(0, 0);
            panelIA.Name = "panelIA";
            panelIA.Size = new Size(718, 538);
            panelIA.TabIndex = 2;
            // 
            // panelInferior
            // 
            panelInferior.Controls.Add(richTextBox1);
            panelInferior.Controls.Add(hopeTextBoxPregunta);
            panelInferior.Controls.Add(iconButton1);
            panelInferior.Dock = DockStyle.Fill;
            panelInferior.Location = new Point(0, 71);
            panelInferior.Name = "panelInferior";
            panelInferior.Size = new Size(718, 467);
            panelInferior.TabIndex = 5;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(3, 0);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(712, 408);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // hopeTextBoxPregunta
            // 
            hopeTextBoxPregunta.BackColor = Color.FromArgb(200, 160, 64);
            hopeTextBoxPregunta.BaseColor = Color.FromArgb(200, 160, 64);
            hopeTextBoxPregunta.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBoxPregunta.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBoxPregunta.Font = new Font("Segoe UI", 12F);
            hopeTextBoxPregunta.ForeColor = Color.Black;
            hopeTextBoxPregunta.Hint = "Escriba una pregunta...";
            hopeTextBoxPregunta.Location = new Point(0, 414);
            hopeTextBoxPregunta.MaxLength = 32767;
            hopeTextBoxPregunta.Multiline = false;
            hopeTextBoxPregunta.Name = "hopeTextBoxPregunta";
            hopeTextBoxPregunta.PasswordChar = '\0';
            hopeTextBoxPregunta.ScrollBars = ScrollBars.None;
            hopeTextBoxPregunta.SelectedText = "";
            hopeTextBoxPregunta.SelectionLength = 0;
            hopeTextBoxPregunta.SelectionStart = 0;
            hopeTextBoxPregunta.Size = new Size(272, 43);
            hopeTextBoxPregunta.TabIndex = 0;
            hopeTextBoxPregunta.TabStop = false;
            hopeTextBoxPregunta.UseSystemPasswordChar = false;
            // 
            // iconButton1
            // 
            iconButton1.ForeColor = Color.Black;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            iconButton1.IconColor = Color.FromArgb(200, 160, 64);
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 30;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(602, 428);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(113, 29);
            iconButton1.TabIndex = 1;
            iconButton1.Text = "Enviar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.UseVisualStyleBackColor = true;
            iconButton1.Click += btnEnviar_Click;
            // 
            // panelSuperior
            // 
            panelSuperior.BackColor = Color.FromArgb(26, 26, 26);
            panelSuperior.Controls.Add(label1);
            panelSuperior.Controls.Add(label11);
            panelSuperior.Dock = DockStyle.Top;
            panelSuperior.Location = new Point(0, 0);
            panelSuperior.Name = "panelSuperior";
            panelSuperior.Size = new Size(718, 71);
            panelSuperior.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(136, 136, 136);
            label1.Location = new Point(3, 40);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 4;
            label1.Text = "Powered by Grok";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.FromArgb(200, 160, 64);
            label11.Location = new Point(3, 0);
            label11.Name = "label11";
            label11.Size = new Size(166, 31);
            label11.TabIndex = 3;
            label11.Text = "Asistente DHL";
            // 
            // Gemini
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelIA);
            Name = "Gemini";
            Size = new Size(718, 538);
            panelIA.ResumeLayout(false);
            panelInferior.ResumeLayout(false);
            panelSuperior.ResumeLayout(false);
            panelSuperior.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelIA;
        private Label label11;
        private FontAwesome.Sharp.IconButton iconButton1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBoxPregunta;
        private Panel panelSuperior;
        private Label label1;
        private Panel panelInferior;
        private RichTextBox richTextBox1;
    }
}
