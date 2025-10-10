namespace Gestion_De_Empleados_2._0
{
    partial class FrmCargos
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
            components = new System.ComponentModel.Container();
            txtnombre = new TextBox();
            txtid = new TextBox();
            txtfunciones = new TextBox();
            dgDatos2 = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            funcionesDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cargoBindingSource = new BindingSource(components);
            btnactualizar = new Button();
            btneliminar = new Button();
            btnagregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cargoBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtnombre.Location = new Point(363, 147);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(156, 27);
            txtnombre.TabIndex = 8;
            // 
            // txtid
            // 
            txtid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtid.Location = new Point(201, 147);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "Id";
            txtid.Size = new Size(156, 27);
            txtid.TabIndex = 7;
            // 
            // txtfunciones
            // 
            txtfunciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtfunciones.Location = new Point(525, 147);
            txtfunciones.Name = "txtfunciones";
            txtfunciones.PlaceholderText = "Funciones";
            txtfunciones.Size = new Size(156, 27);
            txtfunciones.TabIndex = 9;
            // 
            // dgDatos2
            // 
            dgDatos2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgDatos2.AutoGenerateColumns = false;
            dgDatos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos2.BorderStyle = BorderStyle.None;
            dgDatos2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos2.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nombreDataGridViewTextBoxColumn, funcionesDataGridViewTextBoxColumn });
            dgDatos2.DataSource = cargoBindingSource;
            dgDatos2.Location = new Point(3, 284);
            dgDatos2.Name = "dgDatos2";
            dgDatos2.RowHeadersWidth = 51;
            dgDatos2.ScrollBars = ScrollBars.Vertical;
            dgDatos2.Size = new Size(871, 275);
            dgDatos2.TabIndex = 10;
            dgDatos2.CellContentClick += dgDatos2_CellContentClick;
            dgDatos2.CellDoubleClick += dgDatos2_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.MinimumWidth = 6;
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            nombreDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // funcionesDataGridViewTextBoxColumn
            // 
            funcionesDataGridViewTextBoxColumn.DataPropertyName = "Funciones";
            funcionesDataGridViewTextBoxColumn.HeaderText = "Funciones";
            funcionesDataGridViewTextBoxColumn.MinimumWidth = 6;
            funcionesDataGridViewTextBoxColumn.Name = "funcionesDataGridViewTextBoxColumn";
            // 
            // cargoBindingSource
            // 
            cargoBindingSource.DataSource = typeof(Model.Cargo);
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.FromArgb(10, 12, 15);
            btnactualizar.FlatStyle = FlatStyle.Popup;
            btnactualizar.ForeColor = Color.White;
            btnactualizar.Location = new Point(525, 195);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(179, 53);
            btnactualizar.TabIndex = 11;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(10, 12, 15);
            btneliminar.FlatStyle = FlatStyle.Popup;
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(341, 195);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(179, 53);
            btneliminar.TabIndex = 12;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(10, 12, 15);
            btnagregar.FlatStyle = FlatStyle.Popup;
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(155, 195);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(179, 53);
            btnagregar.TabIndex = 13;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // FrmCargos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(871, 571);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(dgDatos2);
            Controls.Add(txtfunciones);
            Controls.Add(txtnombre);
            Controls.Add(txtid);
            Name = "FrmCargos";
            Text = "PanelContenedor2";
            Load += PanelContenedor2_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos2).EndInit();
            ((System.ComponentModel.ISupportInitialize)cargoBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombre;
        private TextBox txtid;
        private TextBox txtfunciones;
        private DataGridView dgDatos2;
        private Button btnactualizar;
        private Button btneliminar;
        private Button btnagregar;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn funcionesDataGridViewTextBoxColumn;
        private BindingSource cargoBindingSource;
    }
}