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
            txtnombre = new TextBox();
            txtid = new TextBox();
            txtfunciones = new TextBox();
            dgDatos2 = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Funciones = new DataGridViewTextBoxColumn();
            btnactualizar = new Button();
            btneliminar = new Button();
            btnagregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos2).BeginInit();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtnombre.Location = new Point(318, 110);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(137, 23);
            txtnombre.TabIndex = 8;
            // 
            // txtid
            // 
            txtid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtid.Location = new Point(176, 110);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "Id";
            txtid.Size = new Size(137, 23);
            txtid.TabIndex = 7;
            // 
            // txtfunciones
            // 
            txtfunciones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtfunciones.Location = new Point(459, 110);
            txtfunciones.Margin = new Padding(3, 2, 3, 2);
            txtfunciones.Name = "txtfunciones";
            txtfunciones.PlaceholderText = "Funciones";
            txtfunciones.Size = new Size(137, 23);
            txtfunciones.TabIndex = 9;
            // 
            // dgDatos2
            // 
            dgDatos2.AllowUserToAddRows = false;
            dgDatos2.AllowUserToDeleteRows = false;
            dgDatos2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgDatos2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos2.BorderStyle = BorderStyle.None;
            dgDatos2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos2.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Funciones });
            dgDatos2.Location = new Point(3, 213);
            dgDatos2.Margin = new Padding(3, 2, 3, 2);
            dgDatos2.Name = "dgDatos2";
            dgDatos2.ReadOnly = true;
            dgDatos2.RowHeadersWidth = 51;
            dgDatos2.ScrollBars = ScrollBars.Vertical;
            dgDatos2.Size = new Size(762, 206);
            dgDatos2.TabIndex = 10;
            dgDatos2.CellContentClick += dgDatos2_CellContentClick;
            dgDatos2.CellDoubleClick += dgDatos2_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Funciones
            // 
            Funciones.DataPropertyName = "funciones";
            Funciones.HeaderText = "Funciones";
            Funciones.Name = "Funciones";
            Funciones.ReadOnly = true;
            // 
            // btnactualizar
            // 
            btnactualizar.FlatStyle = FlatStyle.Popup;
            btnactualizar.Location = new Point(459, 146);
            btnactualizar.Margin = new Padding(3, 2, 3, 2);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(157, 40);
            btnactualizar.TabIndex = 11;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // btneliminar
            // 
            btneliminar.FlatStyle = FlatStyle.Popup;
            btneliminar.Location = new Point(298, 146);
            btneliminar.Margin = new Padding(3, 2, 3, 2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(157, 40);
            btneliminar.TabIndex = 12;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnagregar
            // 
            btnagregar.FlatStyle = FlatStyle.Popup;
            btnagregar.Location = new Point(136, 146);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(157, 40);
            btnagregar.TabIndex = 13;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // FrmCargos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 61, 105);
            ClientSize = new Size(762, 428);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(dgDatos2);
            Controls.Add(txtfunciones);
            Controls.Add(txtnombre);
            Controls.Add(txtid);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmCargos";
            Text = "PanelContenedor2";
            Load += PanelContenedor2_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos2).EndInit();
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
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Funciones;
    }
}