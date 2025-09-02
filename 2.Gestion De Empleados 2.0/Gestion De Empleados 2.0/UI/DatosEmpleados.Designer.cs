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
            btncargos = new Button();
            btndatos = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panelmenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panelmenu
            // 
            panelmenu.BackColor = Color.FromArgb(67, 61, 105);
            panelmenu.Controls.Add(btncargos);
            panelmenu.Controls.Add(btndatos);
            panelmenu.Controls.Add(pictureBox1);
            panelmenu.Dock = DockStyle.Left;
            panelmenu.Location = new Point(0, 0);
            panelmenu.Name = "panelmenu";
            panelmenu.Size = new Size(250, 621);
            panelmenu.TabIndex = 1;
            // 
            // btncargos
            // 
            btncargos.Anchor = AnchorStyles.None;
            btncargos.Location = new Point(35, 320);
            btncargos.Name = "btncargos";
            btncargos.Size = new Size(172, 63);
            btncargos.TabIndex = 2;
            btncargos.Text = "Cargos De Empleados";
            btncargos.UseVisualStyleBackColor = true;
            btncargos.Click += btncargos_Click;
            // 
            // btndatos
            // 
            btndatos.Anchor = AnchorStyles.None;
            btndatos.Location = new Point(35, 195);
            btndatos.Name = "btndatos";
            btndatos.Size = new Size(172, 63);
            btndatos.TabIndex = 1;
            btndatos.Text = "Datos De Empleados";
            btndatos.UseVisualStyleBackColor = true;
            btndatos.Click += btndatos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(67, 61, 105);
            panel1.Location = new Point(250, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(889, 618);
            panel1.TabIndex = 2;
            // 
            // DatosEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1139, 621);
            Controls.Add(panel1);
            Controls.Add(panelmenu);
            Name = "DatosEmpleados";
            Text = "DatosEmpleados";
            Load += DatosEmpleados_Load;
            panelmenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelmenu;
        private Button btncargos;
        private Button btndatos;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}