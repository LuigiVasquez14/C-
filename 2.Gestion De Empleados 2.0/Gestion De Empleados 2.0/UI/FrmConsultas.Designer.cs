namespace Gestion_De_Empleados_2._0.UI
{
    partial class FrmConsultas
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
            tabPage1 = new TabPage();
            button1 = new Button();
            cmbsalario = new ComboBox();
            tabControl1 = new TabControl();
            dgConsultas = new DataGridView();
            tabPage1.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgConsultas).BeginInit();
            SuspendLayout();
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(cmbsalario);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(635, 387);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Salario";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(438, 15);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(149, 35);
            button1.TabIndex = 2;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // cmbsalario
            // 
            cmbsalario.FormattingEnabled = true;
            cmbsalario.Items.AddRange(new object[] { "Mayor", "Menor" });
            cmbsalario.Location = new Point(7, 8);
            cmbsalario.Margin = new Padding(3, 4, 3, 4);
            cmbsalario.Name = "cmbsalario";
            cmbsalario.Size = new Size(138, 28);
            cmbsalario.TabIndex = 1;
            cmbsalario.SelectedIndexChanged += cmbsalario_SelectedIndexChanged;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(119, 16);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(643, 420);
            tabControl1.TabIndex = 0;
            // 
            // dgConsultas
            // 
            dgConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConsultas.Location = new Point(63, 448);
            dgConsultas.Margin = new Padding(3, 4, 3, 4);
            dgConsultas.Name = "dgConsultas";
            dgConsultas.RowHeadersWidth = 51;
            dgConsultas.Size = new Size(750, 289);
            dgConsultas.TabIndex = 1;
            // 
            // FrmConsultas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(871, 707);
            Controls.Add(dgConsultas);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmConsultas";
            Text = "FrmConsultas";
            Load += FrmConsultas_Load;
            tabPage1.ResumeLayout(false);
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private TabControl tabControl1;
        private ComboBox cmbsalario;
        private DataGridView dgConsultas;
        private Button button1;
    }
}