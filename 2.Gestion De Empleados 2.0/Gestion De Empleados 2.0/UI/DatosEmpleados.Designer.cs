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
            btnFiltros = new Button();
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
            panelmenu.Controls.Add(btnFiltros);
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
            // btnFiltros
            // 
            btnFiltros.Anchor = AnchorStyles.None;
            btnFiltros.FlatStyle = FlatStyle.Popup;
            btnFiltros.Location = new Point(31, 408);
            btnFiltros.Margin = new Padding(3, 2, 3, 2);
            btnFiltros.Name = "btnFiltros";
            btnFiltros.Size = new Size(150, 47);
            btnFiltros.TabIndex = 3;
            btnFiltros.Text = "Filtros De Empleados";
            btnFiltros.UseVisualStyleBackColor = true;
            btnFiltros.Click += btnFiltros_Click;
            // 
            // btncargos
            // 
            btncargos.Anchor = AnchorStyles.None;
            btncargos.FlatStyle = FlatStyle.Popup;
            btncargos.Location = new Point(31, 240);
            btncargos.Margin = new Padding(3, 2, 3, 2);
            btncargos.Name = "btncargos";
            btncargos.Size = new Size(150, 47);
            btncargos.TabIndex = 2;
            btncargos.Text = "Cargos De Empleados";
            btncargos.UseVisualStyleBackColor = true;
            btncargos.Click += btncargos_Click;
            // 
            // btndatos
            // 
            btndatos.Anchor = AnchorStyles.None;
            btndatos.FlatStyle = FlatStyle.Popup;
            btndatos.Location = new Point(31, 146);
            btndatos.Margin = new Padding(3, 2, 3, 2);
            btndatos.Name = "btndatos";
            btndatos.Size = new Size(150, 47);
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
            panel1.BackColor = Color.FromArgb(67, 61, 105);
            panel1.Location = new Point(219, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(778, 464);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
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
            ResumeLayout(false);
        }

        #endregion
        private Panel panelmenu;
        private Button btncargos;
        private Button btndatos;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button btnFiltros;
    }
}