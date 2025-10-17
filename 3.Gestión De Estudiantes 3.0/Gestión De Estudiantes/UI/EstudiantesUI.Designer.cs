namespace Gestión_De_Estudiantes.UI
{
    partial class EstudiantesUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EstudiantesUI));
            txtid = new TextBox();
            txtcorreo = new TextBox();
            txtestatura = new TextBox();
            txtpeso = new TextBox();
            txtsangre = new TextBox();
            txtapellido = new TextBox();
            txtnombre = new TextBox();
            txtcurso = new TextBox();
            btnnuevo = new Button();
            btnagregar = new Button();
            btneliminar = new Button();
            dgDatos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            TipoSangre = new DataGridViewTextBoxColumn();
            Peso = new DataGridViewTextBoxColumn();
            Estatura = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Curso = new DataGridViewTextBoxColumn();
            pictureBox1 = new PictureBox();
            txtbuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Location = new Point(12, 12);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "Id";
            txtid.Size = new Size(144, 27);
            txtid.TabIndex = 0;
            // 
            // txtcorreo
            // 
            txtcorreo.Location = new Point(162, 78);
            txtcorreo.Name = "txtcorreo";
            txtcorreo.PlaceholderText = "Correo";
            txtcorreo.Size = new Size(144, 27);
            txtcorreo.TabIndex = 1;
            // 
            // txtestatura
            // 
            txtestatura.Location = new Point(162, 45);
            txtestatura.Name = "txtestatura";
            txtestatura.PlaceholderText = "Estatura";
            txtestatura.Size = new Size(144, 27);
            txtestatura.TabIndex = 2;
            // 
            // txtpeso
            // 
            txtpeso.Location = new Point(162, 12);
            txtpeso.Name = "txtpeso";
            txtpeso.PlaceholderText = "Peso";
            txtpeso.Size = new Size(144, 27);
            txtpeso.TabIndex = 3;
            // 
            // txtsangre
            // 
            txtsangre.Location = new Point(12, 111);
            txtsangre.Name = "txtsangre";
            txtsangre.PlaceholderText = "Tipo de Sangre";
            txtsangre.Size = new Size(144, 27);
            txtsangre.TabIndex = 4;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(12, 78);
            txtapellido.Name = "txtapellido";
            txtapellido.PlaceholderText = "Apellido";
            txtapellido.Size = new Size(144, 27);
            txtapellido.TabIndex = 5;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(12, 45);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(144, 27);
            txtnombre.TabIndex = 6;
            // 
            // txtcurso
            // 
            txtcurso.Location = new Point(162, 111);
            txtcurso.Name = "txtcurso";
            txtcurso.PlaceholderText = "Curso";
            txtcurso.Size = new Size(144, 27);
            txtcurso.TabIndex = 7;
            // 
            // btnnuevo
            // 
            btnnuevo.BackColor = Color.FromArgb(103, 172, 229);
            btnnuevo.FlatStyle = FlatStyle.Flat;
            btnnuevo.Location = new Point(12, 161);
            btnnuevo.Name = "btnnuevo";
            btnnuevo.Size = new Size(105, 43);
            btnnuevo.TabIndex = 8;
            btnnuevo.Text = "Agregar";
            btnnuevo.UseVisualStyleBackColor = false;
            btnnuevo.Click += btnnuevo_Click;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.Yellow;
            btnagregar.FlatStyle = FlatStyle.Flat;
            btnagregar.Location = new Point(234, 161);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(105, 43);
            btnagregar.TabIndex = 9;
            btnagregar.Text = "Actualizar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += btnagregar_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(255, 19, 21);
            btneliminar.FlatStyle = FlatStyle.Flat;
            btneliminar.Location = new Point(123, 161);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(105, 43);
            btneliminar.TabIndex = 10;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // dgDatos
            // 
            dgDatos.AllowUserToAddRows = false;
            dgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, TipoSangre, Peso, Estatura, Correo, Curso });
            dgDatos.Location = new Point(0, 210);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 51;
            dgDatos.Size = new Size(893, 201);
            dgDatos.TabIndex = 11;
            dgDatos.CellContentDoubleClick += dgDatos_CellContentDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "Nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.DataPropertyName = "Apellido";
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            // 
            // TipoSangre
            // 
            TipoSangre.DataPropertyName = "TipoSangre";
            TipoSangre.HeaderText = "Tipo de Sangre";
            TipoSangre.MinimumWidth = 6;
            TipoSangre.Name = "TipoSangre";
            // 
            // Peso
            // 
            Peso.DataPropertyName = "Peso";
            Peso.HeaderText = "Peso";
            Peso.MinimumWidth = 6;
            Peso.Name = "Peso";
            // 
            // Estatura
            // 
            Estatura.DataPropertyName = "Estatura";
            Estatura.HeaderText = "Estatura";
            Estatura.MinimumWidth = 6;
            Estatura.Name = "Estatura";
            // 
            // Correo
            // 
            Correo.DataPropertyName = "Correo";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 6;
            Correo.Name = "Correo";
            // 
            // Curso
            // 
            Curso.DataPropertyName = "Curso";
            Curso.HeaderText = "Curso";
            Curso.MinimumWidth = 6;
            Curso.Name = "Curso";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(626, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(267, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // txtbuscar
            // 
            txtbuscar.Location = new Point(419, 12);
            txtbuscar.Name = "txtbuscar";
            txtbuscar.PlaceholderText = "Buscar";
            txtbuscar.Size = new Size(144, 27);
            txtbuscar.TabIndex = 13;
            txtbuscar.TextChanged += txtbuscar_TextChanged;
            // 
            // EstudiantesUI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(19, 21, 23);
            ClientSize = new Size(893, 411);
            Controls.Add(txtbuscar);
            Controls.Add(pictureBox1);
            Controls.Add(dgDatos);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(btnnuevo);
            Controls.Add(txtcurso);
            Controls.Add(txtnombre);
            Controls.Add(txtapellido);
            Controls.Add(txtsangre);
            Controls.Add(txtpeso);
            Controls.Add(txtestatura);
            Controls.Add(txtcorreo);
            Controls.Add(txtid);
            Name = "EstudiantesUI";
            Text = "EstudiantesUI";
            Load += EstudiantesUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid;
        private TextBox txtcorreo;
        private TextBox txtestatura;
        private TextBox txtpeso;
        private TextBox txtsangre;
        private TextBox txtapellido;
        private TextBox txtnombre;
        private TextBox txtcurso;
        private Button btnnuevo;
        private Button btnagregar;
        private Button btneliminar;
        private DataGridView dgDatos;
        private PictureBox pictureBox1;
        private TextBox txtbuscar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn TipoSangre;
        private DataGridViewTextBoxColumn Peso;
        private DataGridViewTextBoxColumn Estatura;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Curso;
    }
}