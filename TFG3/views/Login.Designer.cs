namespace TFG3
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            panel1 = new ReaLTaiizor.Controls.Panel();
            panel3 = new ReaLTaiizor.Controls.Panel();
            label1 = new Label();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            panel2 = new ReaLTaiizor.Controls.Panel();
            PictureBoxOjo = new PictureBox();
            hopeCheckBox1 = new ReaLTaiizor.Controls.HopeCheckBox();
            TextBoxPass = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            nightButton1 = new ReaLTaiizor.Controls.NightButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxOjo).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 26);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(hopePictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(583, 1045);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.FromArgb(200, 160, 64);
            panel3.Controls.Add(label1);
            panel3.EdgeColor = Color.FromArgb(32, 41, 50);
            panel3.Location = new Point(98, 792);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(315, 51);
            panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel3.TabIndex = 2;
            panel3.Text = "panel3";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.FromArgb(26, 26, 26);
            label1.Font = new Font("Segoe UI Symbol", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(200, 160, 64);
            label1.Location = new Point(8, 5);
            label1.Name = "label1";
            label1.Size = new Size(299, 41);
            label1.TabIndex = 1;
            label1.Text = "SISTEMA DE GESTIÓN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = (Image)resources.GetObject("hopePictureBox1.Image");
            hopePictureBox1.InitialImage = (Image)resources.GetObject("hopePictureBox1.InitialImage");
            hopePictureBox1.Location = new Point(54, 228);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(436, 422);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 0;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(PictureBoxOjo);
            panel2.Controls.Add(hopeCheckBox1);
            panel2.Controls.Add(TextBoxPass);
            panel2.Controls.Add(hopeTextBox1);
            panel2.Controls.Add(nightButton1);
            panel2.Controls.Add(bigLabel1);
            panel2.EdgeColor = Color.FromArgb(32, 41, 50);
            panel2.Location = new Point(583, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(5);
            panel2.Size = new Size(969, 1045);
            panel2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel2.TabIndex = 1;
            panel2.Text = "panel2";
            // 
            // PictureBoxOjo
            // 
            PictureBoxOjo.Anchor = AnchorStyles.None;
            PictureBoxOjo.Location = new Point(772, 493);
            PictureBoxOjo.Name = "PictureBoxOjo";
            PictureBoxOjo.Size = new Size(60, 43);
            PictureBoxOjo.TabIndex = 8;
            PictureBoxOjo.TabStop = false;
            PictureBoxOjo.Click += PictureBoxOjo_Click;
            // 
            // hopeCheckBox1
            // 
            hopeCheckBox1.Anchor = AnchorStyles.None;
            hopeCheckBox1.AutoSize = true;
            hopeCheckBox1.CheckedColor = Color.Black;
            hopeCheckBox1.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeCheckBox1.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeCheckBox1.Enable = true;
            hopeCheckBox1.EnabledCheckedColor = Color.Black;
            hopeCheckBox1.EnabledStringColor = Color.FromArgb(153, 153, 153);
            hopeCheckBox1.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeCheckBox1.Font = new Font("Segoe UI", 12F);
            hopeCheckBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeCheckBox1.Location = new Point(459, 630);
            hopeCheckBox1.Name = "hopeCheckBox1";
            hopeCheckBox1.Size = new Size(115, 20);
            hopeCheckBox1.TabIndex = 6;
            hopeCheckBox1.Text = "Recordar";
            hopeCheckBox1.UseVisualStyleBackColor = true;
            // 
            // TextBoxPass
            // 
            TextBoxPass.Anchor = AnchorStyles.None;
            TextBoxPass.BackColor = Color.White;
            TextBoxPass.BaseColor = Color.FromArgb(44, 55, 66);
            TextBoxPass.BorderColorA = Color.FromArgb(64, 158, 255);
            TextBoxPass.BorderColorB = Color.FromArgb(220, 223, 230);
            TextBoxPass.Font = new Font("Segoe UI", 12F);
            TextBoxPass.ForeColor = Color.FromArgb(48, 49, 51);
            TextBoxPass.Hint = "Contraseña";
            TextBoxPass.Location = new Point(261, 493);
            TextBoxPass.MaxLength = 32767;
            TextBoxPass.Multiline = false;
            TextBoxPass.Name = "TextBoxPass";
            TextBoxPass.PasswordChar = '\0';
            TextBoxPass.ScrollBars = ScrollBars.None;
            TextBoxPass.SelectedText = "";
            TextBoxPass.SelectionLength = 0;
            TextBoxPass.SelectionStart = 0;
            TextBoxPass.Size = new Size(505, 43);
            TextBoxPass.TabIndex = 5;
            TextBoxPass.TabStop = false;
            TextBoxPass.UseSystemPasswordChar = true;
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.Anchor = AnchorStyles.None;
            hopeTextBox1.BackColor = Color.White;
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Segoe UI", 12F);
            hopeTextBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox1.Hint = "Número de empleado";
            hopeTextBox1.Location = new Point(261, 327);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(505, 43);
            hopeTextBox1.TabIndex = 4;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // nightButton1
            // 
            nightButton1.Anchor = AnchorStyles.None;
            nightButton1.BackColor = Color.FromArgb(212, 5, 17);
            nightButton1.DialogResult = DialogResult.None;
            nightButton1.Font = new Font("Segoe UI", 10F);
            nightButton1.ForeColor = Color.White;
            nightButton1.HoverBackColor = Color.FromArgb(50, 242, 93, 89);
            nightButton1.HoverForeColor = Color.FromArgb(26, 26, 26);
            nightButton1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
            nightButton1.Location = new Point(381, 769);
            nightButton1.MinimumSize = new Size(144, 47);
            nightButton1.Name = "nightButton1";
            nightButton1.NormalBackColor = Color.FromArgb(212, 5, 17);
            nightButton1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            nightButton1.PressedBackColor = Color.FromArgb(100, 242, 93, 89);
            nightButton1.PressedForeColor = Color.FromArgb(26, 26, 26);
            nightButton1.Radius = 20;
            nightButton1.Size = new Size(292, 74);
            nightButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            nightButton1.TabIndex = 3;
            nightButton1.Text = "Entrar";
            nightButton1.Click += nightButton1_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.Anchor = AnchorStyles.None;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F);
            bigLabel1.ForeColor = Color.FromArgb(80, 80, 80);
            bigLabel1.Location = new Point(163, 146);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(650, 72);
            bigLabel1.TabIndex = 0;
            bigLabel1.Text = "BIENVENIDO";
            bigLabel1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1548, 1045);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBoxOjo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.Panel panel2;
        private Label label1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.Panel panel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.NightButton nightButton1;
        private ReaLTaiizor.Controls.HopeTextBox TextBoxPass;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.HopeCheckBox hopeCheckBox1;
        private PictureBox PictureBoxOjo;
    }
}
