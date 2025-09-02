namespace Gestion_De_Empleados_2._0
{
    partial class PanelContenedor2
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
            textBox1 = new TextBox();
            dgDatos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Apellido = new DataGridViewTextBoxColumn();
            FechaDeIngreso = new DataGridViewTextBoxColumn();
            Genero = new DataGridViewTextBoxColumn();
            Salario = new DataGridViewTextBoxColumn();
            Foto = new DataGridViewTextBoxColumn();
            btnactualizar = new Button();
            btneliminar = new Button();
            btnagregar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // txtnombre
            // 
            txtnombre.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtnombre.Location = new Point(363, 146);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(156, 27);
            txtnombre.TabIndex = 8;
            // 
            // txtid
            // 
            txtid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtid.Location = new Point(201, 146);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "Id";
            txtid.Size = new Size(156, 27);
            txtid.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Location = new Point(525, 146);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Funciones";
            textBox1.Size = new Size(156, 27);
            textBox1.TabIndex = 9;
            // 
            // dgDatos
            // 
            dgDatos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos.BorderStyle = BorderStyle.None;
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Apellido, FechaDeIngreso, Genero, Salario, Foto });
            dgDatos.Location = new Point(3, 284);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 51;
            dgDatos.ScrollBars = ScrollBars.Vertical;
            dgDatos.Size = new Size(871, 275);
            dgDatos.TabIndex = 10;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Apellido
            // 
            Apellido.HeaderText = "Apellido";
            Apellido.MinimumWidth = 6;
            Apellido.Name = "Apellido";
            // 
            // FechaDeIngreso
            // 
            FechaDeIngreso.HeaderText = "Fecha De Ingreso";
            FechaDeIngreso.MinimumWidth = 6;
            FechaDeIngreso.Name = "FechaDeIngreso";
            // 
            // Genero
            // 
            Genero.HeaderText = "Genero";
            Genero.MinimumWidth = 6;
            Genero.Name = "Genero";
            // 
            // Salario
            // 
            Salario.HeaderText = "Salario";
            Salario.MinimumWidth = 6;
            Salario.Name = "Salario";
            // 
            // Foto
            // 
            Foto.HeaderText = "Foto";
            Foto.MinimumWidth = 6;
            Foto.Name = "Foto";
            // 
            // btnactualizar
            // 
            btnactualizar.Location = new Point(525, 195);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(179, 53);
            btnactualizar.TabIndex = 11;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            btneliminar.Location = new Point(340, 195);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(179, 53);
            btneliminar.TabIndex = 12;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(155, 195);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(179, 53);
            btnagregar.TabIndex = 13;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // PanelContenedor2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 61, 105);
            ClientSize = new Size(871, 571);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(dgDatos);
            Controls.Add(textBox1);
            Controls.Add(txtnombre);
            Controls.Add(txtid);
            Name = "PanelContenedor2";
            Text = "PanelContenedor2";
            Load += PanelContenedor2_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtnombre;
        private TextBox txtid;
        private TextBox textBox1;
        private DataGridView dgDatos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Apellido;
        private DataGridViewTextBoxColumn FechaDeIngreso;
        private DataGridViewTextBoxColumn Genero;
        private DataGridViewTextBoxColumn Salario;
        private DataGridViewTextBoxColumn Foto;
        private Button btnactualizar;
        private Button btneliminar;
        private Button btnagregar;
    }
}