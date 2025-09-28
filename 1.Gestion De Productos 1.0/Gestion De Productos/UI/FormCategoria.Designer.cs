namespace Gestion_De_Productos
{
    partial class FormCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCategoria));
            txtidcate = new TextBox();
            txtnombrecate = new TextBox();
            dgDatos2 = new DataGridView();
            idcate = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            btnagregar = new Button();
            btneliminar = new Button();
            btnactualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos2).BeginInit();
            SuspendLayout();
            // 
            // txtidcate
            // 
            resources.ApplyResources(txtidcate, "txtidcate");
            txtidcate.Name = "txtidcate";
            // 
            // txtnombrecate
            // 
            resources.ApplyResources(txtnombrecate, "txtnombrecate");
            txtnombrecate.Name = "txtnombrecate";
            txtnombrecate.TextChanged += txtnombrecate_TextChanged;
            // 
            // dgDatos2
            // 
            dgDatos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos2.Columns.AddRange(new DataGridViewColumn[] { idcate, Nombre });
            dgDatos2.EditMode = DataGridViewEditMode.EditOnF2;
            resources.ApplyResources(dgDatos2, "dgDatos2");
            dgDatos2.Name = "dgDatos2";
            // 
            // idcate
            // 
            idcate.DataPropertyName = "identificacion";
            resources.ApplyResources(idcate, "idcate");
            idcate.Name = "idcate";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            resources.ApplyResources(Nombre, "Nombre");
            Nombre.Name = "Nombre";
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(0, 188, 251);
            resources.ApplyResources(btnagregar, "btnagregar");
            btnagregar.Name = "btnagregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(255, 1, 3);
            resources.ApplyResources(btneliminar, "btneliminar");
            btneliminar.Name = "btneliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click_1;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.LimeGreen;
            resources.ApplyResources(btnactualizar, "btnactualizar");
            btnactualizar.Name = "btnactualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            // 
            // FormCategoria
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 61, 105);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(dgDatos2);
            Controls.Add(txtnombrecate);
            Controls.Add(txtidcate);
            Name = "FormCategoria";
            Load += FormCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtidcate;
        private DataGridView dgDatos2;
        private Button btnagregar;
        private Button btneliminar;
        private Button btnactualizar;
        private DataGridViewTextBoxColumn idcate;
        private DataGridViewTextBoxColumn Nombre;
        public TextBox txtnombrecate;
    }
}