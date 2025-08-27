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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            txtid = new TextBox();
            txtnombre = new TextBox();
            cmbcategoria = new ComboBox();
            txtcompra = new TextBox();
            txtventa = new TextBox();
            txtcantidad = new TextBox();
            picFoto = new PictureBox();
            dgDatos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Disponible = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            label1 = new Label();
            btnagregar = new Button();
            btneliminar = new Button();
            btnactualizar = new Button();
            chkdiponible = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            btnempleados = new Button();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.BackColor = Color.FromArgb(21, 27, 35);
            txtid.ForeColor = Color.Black;
            txtid.Location = new Point(2, 95);
            txtid.Margin = new Padding(3, 4, 3, 4);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "Id";
            txtid.Size = new Size(141, 27);
            txtid.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.BackColor = Color.FromArgb(21, 27, 35);
            txtnombre.ForeColor = Color.White;
            txtnombre.Location = new Point(0, 133);
            txtnombre.Margin = new Padding(3, 4, 3, 4);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(141, 27);
            txtnombre.TabIndex = 1;
            // 
            // cmbcategoria
            // 
            cmbcategoria.BackColor = Color.FromArgb(21, 27, 35);
            cmbcategoria.ForeColor = Color.FromArgb(109, 108, 108);
            cmbcategoria.FormattingEnabled = true;
            cmbcategoria.Items.AddRange(new object[] { "Refrigeradores", "Neveras", "Congeladores", "Cocinas ", "Estufas", "Hornos", "Lavadoras", "Secadoras", "Lavavajilla", "Televisores", "Equipos de sonido", "Reproductores multimedia", "Consolas de videojuegos", "Secadores de pelo", "Planchas de cabello", "Afeitadoras eléctricas", "Cepillos de dientes eléctricos", "Depiladoras", "Masajeadores", "Aires acondicionados", "Ventiladores", "Calefactores", "Deshumidificadores", "Humidificadores", "Purificadores de aire" });
            cmbcategoria.Location = new Point(151, 172);
            cmbcategoria.Margin = new Padding(3, 4, 3, 4);
            cmbcategoria.Name = "cmbcategoria";
            cmbcategoria.Size = new Size(141, 28);
            cmbcategoria.TabIndex = 3;
            cmbcategoria.Text = "Categoria";
            cmbcategoria.SelectedIndexChanged += cmbcategoria_SelectedIndexChanged;
            // 
            // txtcompra
            // 
            txtcompra.BackColor = Color.FromArgb(21, 27, 35);
            txtcompra.ForeColor = Color.White;
            txtcompra.Location = new Point(151, 95);
            txtcompra.Margin = new Padding(3, 4, 3, 4);
            txtcompra.Name = "txtcompra";
            txtcompra.PlaceholderText = "Precio Compra";
            txtcompra.Size = new Size(141, 27);
            txtcompra.TabIndex = 4;
            // 
            // txtventa
            // 
            txtventa.BackColor = Color.FromArgb(21, 27, 35);
            txtventa.ForeColor = Color.White;
            txtventa.Location = new Point(151, 133);
            txtventa.Margin = new Padding(3, 4, 3, 4);
            txtventa.Name = "txtventa";
            txtventa.PlaceholderText = "Precio Venta";
            txtventa.Size = new Size(141, 27);
            txtventa.TabIndex = 5;
            txtventa.TextChanged += txtventa_TextChanged;
            // 
            // txtcantidad
            // 
            txtcantidad.BackColor = Color.FromArgb(21, 27, 35);
            txtcantidad.ForeColor = Color.White;
            txtcantidad.Location = new Point(0, 173);
            txtcantidad.Margin = new Padding(3, 4, 3, 4);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.PlaceholderText = "Cantidad";
            txtcantidad.Size = new Size(141, 27);
            txtcantidad.TabIndex = 2;
            // 
            // picFoto
            // 
            picFoto.Location = new Point(1048, 95);
            picFoto.Margin = new Padding(3, 4, 3, 4);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(224, 253);
            picFoto.TabIndex = 7;
            picFoto.TabStop = false;
            picFoto.Click += picFoto_Click;
            // 
            // dgDatos
            // 
            dgDatos.AllowDrop = true;
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.SelectionBackColor = Color.White;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgDatos.BackgroundColor = Color.SlateGray;
            dgDatos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.ColumnHeadersVisible = false;
            dgDatos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Cantidad, PrecioCompra, PrecioVenta, Categoria, Disponible });
            dgDatos.GridColor = SystemColors.InactiveBorder;
            dgDatos.Location = new Point(2, 396);
            dgDatos.Margin = new Padding(3, 4, 3, 4);
            dgDatos.Name = "dgDatos";
            dgDatos.RowHeadersWidth = 51;
            dgDatos.Size = new Size(1270, 452);
            dgDatos.TabIndex = 8;
            dgDatos.CellContentClick += dgDatos_CellContentClick;
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
            PrecioVenta.DataPropertyName = "venta";
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
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 35, 40);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1277, 87);
            panel1.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Arial", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(109, 108, 108);
            label1.Location = new Point(387, 9);
            label1.Name = "label1";
            label1.Size = new Size(483, 53);
            label1.TabIndex = 0;
            label1.Text = "Gestion De Productos";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
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
            chkdiponible.Location = new Point(299, 97);
            chkdiponible.Margin = new Padding(3, 4, 3, 4);
            chkdiponible.Name = "chkdiponible";
            chkdiponible.Size = new Size(129, 24);
            chkdiponible.TabIndex = 13;
            chkdiponible.Text = "Disponibilidad";
            chkdiponible.UseVisualStyleBackColor = true;
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
            // 
            // GestionProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(25, 31, 37);
            ClientSize = new Size(1277, 864);
            Controls.Add(btnempleados);
            Controls.Add(chkdiponible);
            Controls.Add(btnactualizar);
            Controls.Add(btneliminar);
            Controls.Add(btnagregar);
            Controls.Add(panel1);
            Controls.Add(dgDatos);
            Controls.Add(picFoto);
            Controls.Add(txtventa);
            Controls.Add(txtcompra);
            Controls.Add(cmbcategoria);
            Controls.Add(txtcantidad);
            Controls.Add(txtnombre);
            Controls.Add(txtid);
            ForeColor = Color.White;
            Margin = new Padding(3, 4, 3, 4);
            Name = "GestionProduct";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid;
        private TextBox txtnombre;
        private ComboBox cmbcategoria;
        private TextBox txtcompra;
        private TextBox txtventa;
        private TextBox txtcantidad;
        private PictureBox picFoto;
        private Panel panel1;
        private Button btnagregar;
        private Button btneliminar;
        private Button btnactualizar;
        private CheckBox chkdiponible;
        private OpenFileDialog openFileDialog1;
        private Label label1;
        private Button btnempleados;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Disponible;
        public DataGridView dgDatos;
    }
}
