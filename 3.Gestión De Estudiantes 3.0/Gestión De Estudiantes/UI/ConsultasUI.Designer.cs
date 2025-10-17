namespace Gestión_De_Estudiantes.UI
{
    partial class ConsultasUI
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnbuscarsangre = new Button();
            cmbsangre = new ComboBox();
            tabPage2 = new TabPage();
            button2 = new Button();
            cmbpeso = new ComboBox();
            tabPage3 = new TabPage();
            button3 = new Button();
            cmbestatu = new ComboBox();
            dgConsultas = new DataGridView();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgConsultas).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(64, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(778, 77);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnbuscarsangre);
            tabPage1.Controls.Add(cmbsangre);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(770, 44);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sangre";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // btnbuscarsangre
            // 
            btnbuscarsangre.Location = new Point(569, 6);
            btnbuscarsangre.Name = "btnbuscarsangre";
            btnbuscarsangre.Size = new Size(157, 28);
            btnbuscarsangre.TabIndex = 1;
            btnbuscarsangre.Text = "Buscar";
            btnbuscarsangre.UseVisualStyleBackColor = true;
            btnbuscarsangre.Click += txtbuscarsangre_Click;
            // 
            // cmbsangre
            // 
            cmbsangre.FormattingEnabled = true;
            cmbsangre.Items.AddRange(new object[] { "A-", "A+", "AB-", "AB+", "B-", "B+", "O-", "O+" });
            cmbsangre.Location = new Point(6, 6);
            cmbsangre.Name = "cmbsangre";
            cmbsangre.Size = new Size(151, 28);
            cmbsangre.TabIndex = 0;
            cmbsangre.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(cmbpeso);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(770, 96);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Peso";
            tabPage2.UseVisualStyleBackColor = true;
            tabPage2.Click += tabPage2_Click;
            // 
            // button2
            // 
            button2.Location = new Point(569, 6);
            button2.Name = "button2";
            button2.Size = new Size(157, 28);
            button2.TabIndex = 2;
            button2.Text = "Buscar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cmbpeso
            // 
            cmbpeso.FormattingEnabled = true;
            cmbpeso.Items.AddRange(new object[] { "Mas Pesado", "Menos Pesado" });
            cmbpeso.Location = new Point(6, 6);
            cmbpeso.Name = "cmbpeso";
            cmbpeso.Size = new Size(151, 28);
            cmbpeso.TabIndex = 1;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Controls.Add(cmbestatu);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(770, 96);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Estatura";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(569, 6);
            button3.Name = "button3";
            button3.Size = new Size(157, 28);
            button3.TabIndex = 2;
            button3.Text = "Buscar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // cmbestatu
            // 
            cmbestatu.FormattingEnabled = true;
            cmbestatu.Items.AddRange(new object[] { "Mas Alto", "Menos Alto" });
            cmbestatu.Location = new Point(6, 6);
            cmbestatu.Name = "cmbestatu";
            cmbestatu.Size = new Size(151, 28);
            cmbestatu.TabIndex = 1;
            // 
            // dgConsultas
            // 
            dgConsultas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgConsultas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgConsultas.Location = new Point(68, 95);
            dgConsultas.Name = "dgConsultas";
            dgConsultas.RowHeadersWidth = 51;
            dgConsultas.Size = new Size(778, 775);
            dgConsultas.TabIndex = 1;
            dgConsultas.CellContentClick += dgSangre_CellContentClick;
            // 
            // ConsultasUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(893, 411);
            Controls.Add(dgConsultas);
            Controls.Add(tabControl1);
            Name = "ConsultasUI";
            Text = "ConsultasUI";
            Load += ConsultasUI_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgConsultas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private ComboBox cmbsangre;
        private ComboBox cmbpeso;
        private ComboBox cmbestatu;
        private Button btnbuscarsangre;
        private Button button2;
        private Button button3;
        private DataGridView dgConsultas;
    }
}