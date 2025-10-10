namespace Gestion_De_Empleados_2._0
{
    partial class FrmDatosEmpleados
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
            txtid = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtsalario = new TextBox();
            cmbgenero = new ComboBox();
            cmbcargo = new ComboBox();
            dgDatos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            btnagregar = new Button();
            btneliminar = new Button();
            btnactualizar = new Button();
            txtfiltro = new TextBox();
            dttiempo = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtid.Location = new Point(11, 12);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "Id";
            txtid.Size = new Size(156, 27);
            txtid.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtnombre.Location = new Point(11, 45);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(156, 27);
            txtnombre.TabIndex = 1;
            // 
            // txtapellido
            // 
            txtapellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtapellido.Location = new Point(11, 77);
            txtapellido.Name = "txtapellido";
            txtapellido.PlaceholderText = "Apellido";
            txtapellido.Size = new Size(156, 27);
            txtapellido.TabIndex = 2;
            // 
            // txtsalario
            // 
            txtsalario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtsalario.Location = new Point(197, 11);
            txtsalario.Name = "txtsalario";
            txtsalario.PlaceholderText = "Salario";
            txtsalario.Size = new Size(156, 27);
            txtsalario.TabIndex = 3;
            // 
            // cmbgenero
            // 
            cmbgenero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbgenero.FormattingEnabled = true;
            cmbgenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otros" });
            cmbgenero.Location = new Point(197, 43);
            cmbgenero.Name = "cmbgenero";
            cmbgenero.Size = new Size(156, 28);
            cmbgenero.TabIndex = 4;
            cmbgenero.Text = "Genero";
            // 
            // cmbcargo
            // 
            cmbcargo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbcargo.FormattingEnabled = true;
            cmbcargo.Location = new Point(197, 77);
            cmbcargo.Name = "cmbcargo";
            cmbcargo.Size = new Size(156, 28);
            cmbcargo.TabIndex = 5;
            cmbcargo.Text = "Cargo";
            // 
            // dgDatos
            // 
            dgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos.BorderStyle = BorderStyle.None;
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, Genero, Salario });
            dgDatos.Location = new Point(1, 253);
            dgDatos.Name = "dgDatos";
            dgDatos.ReadOnly = true;
            dgDatos.RowHeadersWidth = 51;
            dgDatos.ScrollBars = ScrollBars.Vertical;
            dgDatos.Size = new Size(871, 346);
            dgDatos.TabIndex = 7;
            dgDatos.CellContentClick += dgDatos_CellContentClick;
            dgDatos.CellDoubleClick += dgDatos_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            Apellido.ReadOnly = true;
            // 
            // Genero
            // 
            Genero.DataPropertyName = "Genero";
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 6;
            Genero.Name = "Genero";
            Genero.ReadOnly = true;
            // 
            // Salario
            // 
            Salario.DataPropertyName = "Salario";
            Salario.HeaderText = "Salario";
            Salario.MinimumWidth = 6;
            Salario.Name = "Salario";
            Salario.ReadOnly = true;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(10, 12, 15);
            btnagregar.FlatStyle = FlatStyle.Popup;
            btnagregar.ForeColor = Color.White;
            btnagregar.Location = new Point(11, 131);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(179, 53);
            btnagregar.TabIndex = 10;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(10, 12, 15);
            btneliminar.FlatStyle = FlatStyle.Popup;
            btneliminar.ForeColor = Color.White;
            btneliminar.Location = new Point(197, 131);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(179, 53);
            btneliminar.TabIndex = 10;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.FromArgb(10, 12, 15);
            btnactualizar.FlatStyle = FlatStyle.Popup;
            btnactualizar.ForeColor = Color.White;
            btnactualizar.Location = new Point(382, 131);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(179, 53);
            btnactualizar.TabIndex = 10;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // txtfiltro
            // 
            txtfiltro.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtfiltro.Location = new Point(393, 60);
            txtfiltro.Name = "txtfiltro";
            txtfiltro.PlaceholderText = "Buscar";
            txtfiltro.Size = new Size(178, 27);
            txtfiltro.TabIndex = 12;
            txtfiltro.TextChanged += txtfiltro_TextChanged_1;
            txtfiltro.KeyDown += txtfiltro_KeyDown;
            // 
            // dttiempo
            // 
            dttiempo.Location = new Point(393, 12);
            dttiempo.Name = "dttiempo";
            dttiempo.Size = new Size(268, 27);
            dttiempo.TabIndex = 13;
            // 
            // FrmDatosEmpleados
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(871, 571);
            Controls.Add(dttiempo);
            Controls.Add(txtfiltro);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(dgDatos);
            Controls.Add(cmbcargo);
            Controls.Add(cmbgenero);
            Controls.Add(txtsalario);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtid);
            Name = "FrmDatosEmpleados";
            Text = "PanelContenedor";
            Load += PanelContenedor_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtsalario;
        private ComboBox cmbgenero;
        private ComboBox cmbcargo;
        private DataGridView dgDatos;
        private Button btnagregar;
        private Button btneliminar;
        private Button btnactualizar;
        private TextBox txtfiltro;
        private DateTimePicker dttiempo;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Salario;
    }
}