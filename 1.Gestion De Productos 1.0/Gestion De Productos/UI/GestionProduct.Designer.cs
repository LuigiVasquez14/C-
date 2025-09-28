namespace Gestion_De_Productos
{
    partial class GestionProduct
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtid = new TextBox();
            txtnombre = new TextBox();
            cmbcategoria = new ComboBox();
            txtpreciocompra = new TextBox();
            txtprecioventa = new TextBox();
            txtcantidad = new TextBox();
            picFoto = new PictureBox();
            btnagregar = new Button();
            btneliminar = new Button();
            btnactualizar = new Button();
            chkdiponible = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            btnempleados = new Button();
            dgDatos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Disponible = new DataGridViewCheckBoxColumn();
            wMHelpersBindingSource = new BindingSource(components);
            txtfiltro = new TextBox();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)wMHelpersBindingSource).BeginInit();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.BackColor = Color.FromArgb(21, 27, 35);
            txtid.ForeColor = Color.White;
            txtid.Location = new Point(24, 95);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "Id";
            txtid.Size = new Size(143, 27);
            txtid.TabIndex = 0;
            txtid.TextChanged += txtid_TextChanged;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.FromArgb(21, 27, 35);
            txtnombre.ForeColor = Color.White;
            txtnombre.Location = new Point(24, 133);
            txtnombre.Margin = new Padding(3, 4, 3, 4);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(141, 27);
            txtnombre.TabIndex = 1;
            // 
            // cmbcategoria
            // 
            cmbcategoria.BackColor = Color.FromArgb(21, 27, 35);
            cmbcategoria.ForeColor = Color.White;
            cmbcategoria.FormattingEnabled = true;
            cmbcategoria.Location = new Point(175, 172);
            cmbcategoria.Margin = new Padding(3, 4, 3, 4);
            cmbcategoria.Name = "cmbcategoria";
            cmbcategoria.Size = new Size(141, 28);
            cmbcategoria.TabIndex = 3;
            cmbcategoria.Text = "Categoria";
            cmbcategoria.SelectedIndexChanged += cmbcategoria_SelectedIndexChanged;
            // 
            // txtpreciocompra
            // 
            txtpreciocompra.BackColor = Color.FromArgb(21, 27, 35);
            txtpreciocompra.ForeColor = Color.White;
            txtpreciocompra.Location = new Point(175, 95);
            txtpreciocompra.Margin = new Padding(3, 4, 3, 4);
            txtpreciocompra.Name = "txtpreciocompra";
            txtpreciocompra.PlaceholderText = "Precio Compra";
            txtpreciocompra.Size = new Size(141, 27);
            txtpreciocompra.TabIndex = 4;
            // 
            // txtprecioventa
            // 
            txtprecioventa.BackColor = Color.FromArgb(21, 27, 35);
            txtprecioventa.ForeColor = Color.White;
            txtprecioventa.Location = new Point(175, 133);
            txtprecioventa.Margin = new Padding(3, 4, 3, 4);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.PlaceholderText = "Precio Venta";
            txtprecioventa.Size = new Size(141, 27);
            txtprecioventa.TabIndex = 5;
            txtprecioventa.TextChanged += txtventa_TextChanged;
            // 
            // txtcantidad
            // 
            txtcantidad.BackColor = Color.FromArgb(21, 27, 35);
            txtcantidad.ForeColor = Color.White;
            txtcantidad.Location = new Point(24, 173);
            txtcantidad.Margin = new Padding(3, 4, 3, 4);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.PlaceholderText = "Cantidad";
            txtcantidad.Size = new Size(141, 27);
            txtcantidad.TabIndex = 2;
            // 
            // picFoto
            // 
            picFoto.Location = new Point(869, 97);
            picFoto.Margin = new Padding(3, 4, 3, 4);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(224, 253);
            picFoto.TabIndex = 7;
            picFoto.TabStop = false;
            picFoto.Click += picFoto_Click;
            // 
            // btnagregar
            // 
            btnagregar.BackColor = Color.FromArgb(0, 188, 251);
            btnagregar.FlatStyle = FlatStyle.Popup;
            btnagregar.ForeColor = Color.Transparent;
            btnagregar.Location = new Point(24, 255);
            btnagregar.Margin = new Padding(3, 4, 3, 4);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(126, 55);
            btnagregar.TabIndex = 10;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = false;
            btnagregar.Click += button1_Click;
            // 
            // btneliminar
            // 
            btneliminar.BackColor = Color.FromArgb(255, 1, 3);
            btneliminar.FlatStyle = FlatStyle.Popup;
            btneliminar.ForeColor = Color.Transparent;
            btneliminar.Location = new Point(157, 255);
            btneliminar.Margin = new Padding(3, 4, 3, 4);
            btneliminar.Name = "btneliminar";
            btneliminar.Size = new Size(126, 55);
            btneliminar.TabIndex = 11;
            btneliminar.Text = "Eliminar";
            btneliminar.UseVisualStyleBackColor = false;
            btneliminar.Click += btneliminar_Click;
            // 
            // btnactualizar
            // 
            btnactualizar.BackColor = Color.LimeGreen;
            btnactualizar.FlatStyle = FlatStyle.Popup;
            btnactualizar.ForeColor = Color.Transparent;
            btnactualizar.Location = new Point(289, 255);
            btnactualizar.Margin = new Padding(3, 4, 3, 4);
            btnactualizar.Name = "btnactualizar";
            btnactualizar.Size = new Size(126, 55);
            btnactualizar.TabIndex = 12;
            btnactualizar.Text = "Actualizar";
            btnactualizar.UseVisualStyleBackColor = false;
            // 
            // chkdiponible
            // 
            chkdiponible.AutoSize = true;
            chkdiponible.ForeColor = Color.FromArgb(109, 108, 108);
            chkdiponible.Location = new Point(323, 97);
            chkdiponible.Margin = new Padding(3, 4, 3, 4);
            chkdiponible.Name = "chkdiponible";
            chkdiponible.Size = new Size(129, 24);
            chkdiponible.TabIndex = 13;
            chkdiponible.Text = "Disponibilidad";
            chkdiponible.UseVisualStyleBackColor = true;
            chkdiponible.CheckedChanged += chkdiponible_CheckedChanged;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnempleados
            // 
            btnempleados.BackColor = SystemColors.AppWorkspace;
            btnempleados.FlatStyle = FlatStyle.Popup;
            btnempleados.ForeColor = Color.Transparent;
            btnempleados.Location = new Point(421, 255);
            btnempleados.Margin = new Padding(3, 4, 3, 4);
            btnempleados.Name = "btnempleados";
            btnempleados.Size = new Size(126, 55);
            btnempleados.TabIndex = 14;
            btnempleados.Text = "Ver Empleados";
            btnempleados.UseVisualStyleBackColor = false;
            btnempleados.Click += btnempleados_Click;
            // 
            // dgDatos
            // 
            dgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Cantidad, PrecioCompra, PrecioVenta, Categoria, Disponible });
            dgDatos.Location = new Point(-2, 435);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 51;
            dgDatos.Size = new Size(1140, 343);
            dgDatos.TabIndex = 15;
            dgDatos.CellContentClick += dgDatos_CellContentClick_1;
            dgDatos.CellDoubleClick += dgDatos_CellContentClick_1;
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
            Nombre.DataPropertyName = "nombre";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "cantidad";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            // 
            // PrecioCompra
            // 
            PrecioCompra.DataPropertyName = "preciocompra";
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.MinimumWidth = 6;
            PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            PrecioVenta.DataPropertyName = "precioventa";
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.MinimumWidth = 6;
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Categoria
            // 
            Categoria.DataPropertyName = "categoria";
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            // 
            // Disponible
            // 
            Disponible.DataPropertyName = "diponible";
            Disponible.HeaderText = "Disponible";
            Disponible.MinimumWidth = 6;
            Disponible.Name = "Disponible";
            // 
            // wMHelpersBindingSource
            // 
            wMHelpersBindingSource.DataSource = typeof(Helpers.WMHelpers);
            // 
            // txtfiltro
            // 
            txtfiltro.Location = new Point(536, 46);
            txtfiltro.Name = "txtfiltro";
            txtfiltro.Size = new Size(149, 27);
            txtfiltro.TabIndex = 16;
            txtfiltro.TextChanged += txtfiltro_TextChanged;
            // 
            // GestionProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(67, 61, 105);
            ClientSize = new Size(1117, 612);
            Controls.Add(txtfiltro);
            Controls.Add(dgDatos);
            Controls.Add(btnempleados);
            Controls.Add(chkdiponible);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(picFoto);
            Controls.Add(txtprecioventa);
            Controls.Add(txtpreciocompra);
            Controls.Add(cmbcategoria);
            Controls.Add(txtcantidad);
            Controls.Add(txtnombre);
            Controls.Add(txtid);
            ForeColor = Color.Black;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionProduct";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            ((System.ComponentModel.ISupportInitialize)wMHelpersBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid;
        private TextBox txtnombre;
        private TextBox txtpreciocompra;
        private TextBox txtprecioventa;
        private TextBox txtcantidad;
        private PictureBox picFoto;
        private Button btnagregar;
        private Button btneliminar;
        private Button btnactualizar;
        private CheckBox chkdiponible;
        private OpenFileDialog openFileDialog1;
        private Button btnempleados;
        private DataGridView dgDatos;
        public ComboBox cmbcategoria;
        private BindingSource wMHelpersBindingSource;
        private TextBox txtfiltro;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewCheckBoxColumn Disponible;
    }
}
