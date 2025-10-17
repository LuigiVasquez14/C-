namespace Gestión_De_Estudiantes.UI
{
    partial class MainUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainUI));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btnconsultas = new Button();
            btnestudiantes = new Button();
            PanelContenedor = new Panel();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            PanelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(19, 21, 23);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1084, 98);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Historic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(379, 9);
            label1.Name = "label1";
            label1.Size = new Size(501, 62);
            label1.TabIndex = 0;
            label1.Text = "Plataforma Estudiantil";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnconsultas);
            panel2.Controls.Add(btnestudiantes);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(173, 458);
            panel2.TabIndex = 1;
            // 
            // btnconsultas
            // 
            btnconsultas.BackColor = Color.FromArgb(12, 14, 16);
            btnconsultas.BackgroundImageLayout = ImageLayout.None;
            btnconsultas.FlatStyle = FlatStyle.Popup;
            btnconsultas.ForeColor = Color.WhiteSmoke;
            btnconsultas.Location = new Point(12, 187);
            btnconsultas.Name = "btnconsultas";
            btnconsultas.Size = new Size(149, 68);
            btnconsultas.TabIndex = 3;
            btnconsultas.Text = "Consultas";
            btnconsultas.UseVisualStyleBackColor = false;
            btnconsultas.Click += btnconsultas_Click;
            // 
            // btnestudiantes
            // 
            btnestudiantes.BackColor = Color.FromArgb(12, 14, 16);
            btnestudiantes.BackgroundImageLayout = ImageLayout.None;
            btnestudiantes.FlatStyle = FlatStyle.Popup;
            btnestudiantes.ForeColor = Color.WhiteSmoke;
            btnestudiantes.Location = new Point(12, 35);
            btnestudiantes.Name = "btnestudiantes";
            btnestudiantes.Size = new Size(149, 68);
            btnestudiantes.TabIndex = 2;
            btnestudiantes.Text = "Estudiantes";
            btnestudiantes.UseVisualStyleBackColor = false;
            btnestudiantes.Click += btnestudiantes_Click;
            // 
            // PanelContenedor
            // 
            PanelContenedor.Controls.Add(pictureBox2);
            PanelContenedor.Dock = DockStyle.Fill;
            PanelContenedor.Location = new Point(173, 98);
            PanelContenedor.Name = "PanelContenedor";
            PanelContenedor.Size = new Size(911, 458);
            PanelContenedor.TabIndex = 2;
            PanelContenedor.Paint += panel3_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(911, 458);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(1084, 556);
            Controls.Add(PanelContenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainUI";
            Text = "MainUI";
            Load += MainUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            PanelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnestudiantes;
        private Panel PanelContenedor;
        private Button btnconsultas;
        private PictureBox pictureBox2;
    }
}