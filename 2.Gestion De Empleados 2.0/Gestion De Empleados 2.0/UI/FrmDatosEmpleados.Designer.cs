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
            dttiempo = new DateTimePicker();
            dgDatos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            FechaDeIngreso = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewTextBoxColumn();
            btnagregar = new Button();
            btneliminar = new Button();
            btnactualizar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtid.Location = new Point(10, 9);
            txtid.Margin = new Padding(3, 2, 3, 2);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "Id";
            txtid.Size = new Size(137, 23);
            txtid.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtnombre.Location = new Point(10, 34);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(137, 23);
            txtnombre.TabIndex = 1;
            // 
            // txtapellido
            // 
            txtapellido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtapellido.Location = new Point(10, 58);
            txtapellido.Margin = new Padding(3, 2, 3, 2);
            txtapellido.Name = "txtapellido";
            txtapellido.PlaceholderText = "Apellido";
            txtapellido.Size = new Size(137, 23);
            txtapellido.TabIndex = 2;
            // 
            // txtsalario
            // 
            txtsalario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtsalario.Location = new Point(152, 9);
            txtsalario.Margin = new Padding(3, 2, 3, 2);
            txtsalario.Name = "txtsalario";
            txtsalario.PlaceholderText = "Salario";
            txtsalario.Size = new Size(137, 23);
            txtsalario.TabIndex = 3;
            // 
            // cmbgenero
            // 
            cmbgenero.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbgenero.FormattingEnabled = true;
            cmbgenero.Items.AddRange(new object[] { "Masculino", "Femenino", "Otros" });
            cmbgenero.Location = new Point(152, 33);
            cmbgenero.Margin = new Padding(3, 2, 3, 2);
            cmbgenero.Name = "cmbgenero";
            cmbgenero.Size = new Size(137, 23);
            cmbgenero.TabIndex = 4;
            cmbgenero.Text = "Genero";
            // 
            // cmbcargo
            // 
            cmbcargo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cmbcargo.FormattingEnabled = true;
            cmbcargo.Items.AddRange(new object[] { "Médico", "Ingeniero", "Profesor", "Abogado", "Arquitecto", "Diseñador gráfico", "Contador", "Programador", "Electricista", "Mecánico", "Chef", "Fotógrafo", "Enfermero", "Albañil", "Vendedor" });
            cmbcargo.Location = new Point(152, 58);
            cmbcargo.Margin = new Padding(3, 2, 3, 2);
            cmbcargo.Name = "cmbcargo";
            cmbcargo.Size = new Size(137, 23);
            cmbcargo.TabIndex = 5;
            cmbcargo.Text = "Cargo";
            // 
            // dttiempo
            // 
            dttiempo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dttiempo.Location = new Point(294, 8);
            dttiempo.Margin = new Padding(3, 2, 3, 2);
            dttiempo.Name = "dttiempo";
            dttiempo.Size = new Size(256, 23);
            dttiempo.TabIndex = 6;
            dttiempo.ValueChanged += dttiempo_ValueChanged;
            // 
            // dgDatos
            // 
            dgDatos.AllowUserToAddRows = false;
            dgDatos.AllowUserToDeleteRows = false;
            dgDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos.BorderStyle = BorderStyle.None;
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, FechaDeIngreso, Genero, Salario, Foto });
            dgDatos.Location = new Point(1, 190);
            dgDatos.Margin = new Padding(3, 2, 3, 2);
            dgDatos.Name = "dgDatos";
            dgDatos.ReadOnly = true;
            dgDatos.RowHeadersWidth = 51;
            dgDatos.ScrollBars = ScrollBars.Vertical;
            dgDatos.Size = new Size(762, 229);
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
            // FechaDeIngreso
            // 
            FechaDeIngreso.HeaderText = "Fecha De Ingreso";
            FechaDeIngreso.MinimumWidth = 6;
            FechaDeIngreso.Name = "FechaDeIngreso";
            FechaDeIngreso.ReadOnly = true;
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
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.MinimumWidth = 6;
            Foto.Name = "Foto";
            Foto.ReadOnly = true;
            // 
            // btnagregar
            // 
            btnagregar.FlatStyle = FlatStyle.Popup;
            btnagregar.Location = new Point(10, 98);
            btnagregar.Margin = new Padding(3, 2, 3, 2);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(157, 40);
            btnagregar.TabIndex = 10;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneliminar
            // 
            btneliminar.FlatStyle = FlatStyle.Popup;
            btneliminar.Location = new Point(172, 98);
            btneliminar.Margin = new Padding(3, 2, 3, 2);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(157, 40);
            btneliminar.TabIndex = 10;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.FlatStyle = FlatStyle.Popup;
            btnactualizar.Location = new Point(334, 98);
            btnactualizar.Margin = new Padding(3, 2, 3, 2);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(157, 40);
            btnactualizar.TabIndex = 10;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            btnactualizar.Click += btnactualizar_Click;
            // 
            // FrmDatosEmpleados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 61, 105);
            ClientSize = new Size(762, 428);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(dgDatos);
            Controls.Add(dttiempo);
            Controls.Add(cmbcargo);
            Controls.Add(cmbgenero);
            Controls.Add(txtsalario);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtid);
            Margin = new Padding(3, 2, 3, 2);
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
        private DateTimePicker dttiempo;
        private DataGridView dgDatos;
        private Button btnagregar;
        private Button btneliminar;
        private Button btnactualizar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn FechaDeIngreso;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn Foto;
    }
}