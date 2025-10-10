namespace Gestion_De_Empleados_2._0
{
    partial class DatosEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatosEmpleados));
            panelmenu = new Panel();
            button1 = new Button();
            btncargos = new Button();
            btndatos = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelmenu
            // 
            panelmenu.BackColor = Color.FromArgb(19, 21, 23);
            panelmenu.Controls.Add(button1);
            panelmenu.Controls.Add(btncargos);
            panelmenu.Controls.Add(btndatos);
            panelmenu.Controls.Add(pictureBox1);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Margin = new Padding(3, 2, 3, 2);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(219, 466);
            panelmenu.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.FromArgb(10, 12, 15);
            button1.FlatStyle = FlatStyle.Popup;
            button1.ForeColor = Color.White;
            button1.Location = new Point(31, 355);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(150, 47);
            button1.TabIndex = 3;
            button1.Text = "Consultas";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btncargos
            // 
            btncargos.Anchor = AnchorStyles.None;
            btncargos.BackColor = Color.FromArgb(10, 12, 15);
            btncargos.FlatStyle = FlatStyle.Popup;
            btncargos.ForeColor = Color.White;
            btncargos.Location = new Point(31, 240);
            btncargos.Margin = new Padding(3, 2, 3, 2);
            btncargos.Name = "btncargos";
            btncargos.Size = new Size(150, 47);
            btncargos.TabIndex = 2;
            btncargos.Text = "Cargos De Empleados";
            btncargos.UseVisualStyleBackColor = false;
            btncargos.Click += btncargos_Click;
            // 
            // btndatos
            // 
            btndatos.Anchor = AnchorStyles.None;
            btndatos.BackColor = Color.FromArgb(10, 12, 15);
            btndatos.FlatStyle = FlatStyle.Popup;
            btndatos.ForeColor = Color.White;
            btndatos.Location = new Point(31, 146);
            btndatos.Margin = new Padding(3, 2, 3, 2);
            btndatos.Name = "btndatos";
            btndatos.Size = new Size(150, 47);
            btndatos.TabIndex = 1;
            btndatos.Text = "Datos De Empleados";
            btndatos.UseVisualStyleBackColor = false;
            btndatos.Click += btndatos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(19, 21, 23);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 118);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(19, 21, 23);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(219, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 464);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(778, 464);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // DatosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(997, 466);
            Controls.Add(panel1);
            Controls.Add(panelmenu);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DatosEmpleados";
            Text = "DatosEmpleados";
            Load += DatosEmpleados_Load;
            panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelmenu;
        private Button btncargos;
        private Button btndatos;
        private PictureBox pictureBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button button1;
    }
}