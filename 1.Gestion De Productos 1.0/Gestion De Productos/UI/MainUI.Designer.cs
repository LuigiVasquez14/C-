namespace Gestion_De_Productos.UI
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btncategoria = new Button();
            btnproductos = new Button();
            panelcontenedor = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(67, 61, 105);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1330, 122);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 161);
            label1.Location = new Point(483, 30);
            label1.Name = "label1";
            label1.Size = new Size(465, 52);
            label1.TabIndex = 0;
            label1.Text = "Gestion De Productos";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(67, 61, 105);
            panel2.Controls.Add(btncategoria);
            panel2.Controls.Add(btnproductos);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 122);
            panel2.Name = "panel2";
            panel2.Size = new Size(195, 659);
            panel2.TabIndex = 1;
            // 
            // btncategoria
            // 
            btncategoria.Location = new Point(12, 207);
            btncategoria.Name = "btncategoria";
            btncategoria.Size = new Size(152, 57);
            btncategoria.TabIndex = 1;
            btncategoria.Text = "Categoria";
            btncategoria.UseVisualStyleBackColor = true;
            btncategoria.Click += button2_Click;
            // 
            // btnproductos
            // 
            btnproductos.Location = new Point(12, 79);
            btnproductos.Name = "btnproductos";
            btnproductos.Size = new Size(152, 70);
            btnproductos.TabIndex = 0;
            btnproductos.Text = "Productos";
            btnproductos.UseVisualStyleBackColor = true;
            btnproductos.Click += button1_Click;
            // 
            // panelcontenedor
            // 
            panelcontenedor.BackColor = Color.FromArgb(67, 61, 105);
            panelcontenedor.Dock = DockStyle.Fill;
            panelcontenedor.Location = new Point(195, 122);
            panelcontenedor.Name = "panelcontenedor";
            panelcontenedor.Size = new Size(1135, 659);
            panelcontenedor.TabIndex = 2;
            // 
            // MainUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1330, 781);
            Controls.Add(panelcontenedor);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainUI";
            Text = "MainUI";
            Load += MainUI_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelcontenedor;
        private Label label1;
        private Button btncategoria;
        private Button btnproductos;
    }
}