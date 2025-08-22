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
            PrecioCompra = new DataGridViewTextBoxColumn();
            PrecioVenta = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            Disponible = new DataGridViewTextBoxColumn();
            panel1 = new Panel();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            chkdiponible = new CheckBox();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)picFoto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgDatos).BeginInit();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Location = new Point(2, 71);
            txtid.Name = "txtid";
            txtid.PlaceholderText = "Id";
            txtid.Size = new Size(124, 23);
            txtid.TabIndex = 0;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(2, 100);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(124, 23);
            txtnombre.TabIndex = 1;
            // 
            // cmbcategoria
            // 
            cmbcategoria.FormattingEnabled = true;
            cmbcategoria.Items.AddRange(new object[] { "Refrigeradores", "Neveras", "Congeladores", "Cocinas ", "Estufas", "Hornos", "Lavadoras", "Secadoras", "Lavavajilla", "Televisores", "Equipos de sonido", "Reproductores multimedia", "Consolas de videojuegos", "Secadores de pelo", "Planchas de cabello", "Afeitadoras eléctricas", "Cepillos de dientes eléctricos", "Depiladoras", "Masajeadores", "Aires acondicionados", "Ventiladores", "Calefactores", "Deshumidificadores", "Humidificadores", "Purificadores de aire" });
            cmbcategoria.Location = new Point(132, 129);
            cmbcategoria.Name = "cmbcategoria";
            cmbcategoria.Size = new Size(124, 23);
            cmbcategoria.TabIndex = 3;
            cmbcategoria.Text = "Categoria";
            // 
            // txtcompra
            // 
            txtcompra.Location = new Point(132, 71);
            txtcompra.Name = "txtcompra";
            txtcompra.PlaceholderText = "Precio Compra";
            txtcompra.Size = new Size(124, 23);
            txtcompra.TabIndex = 4;
            // 
            // txtventa
            // 
            txtventa.Location = new Point(132, 100);
            txtventa.Name = "txtventa";
            txtventa.PlaceholderText = "Precio Venta";
            txtventa.Size = new Size(124, 23);
            txtventa.TabIndex = 5;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(2, 129);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.PlaceholderText = "Cantidad";
            txtcantidad.Size = new Size(124, 23);
            txtcantidad.TabIndex = 2;
            // 
            // picFoto
            // 
            picFoto.Location = new Point(921, 71);
            picFoto.Name = "picFoto";
            picFoto.Size = new Size(192, 196);
            picFoto.TabIndex = 7;
            picFoto.TabStop = false;
            picFoto.Click += picFoto_Click;
            // 
            // dgDatos
            // 
            dgDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatos.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, PrecioCompra, PrecioVenta, Categoria, Disponible });
            dgDatos.Location = new Point(2, 297);
            dgDatos.Name = "dgDatos";
            dgDatos.Size = new Size(1111, 339);
            dgDatos.TabIndex = 8;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.Name = "Nombre";
            // 
            // PrecioCompra
            // 
            PrecioCompra.HeaderText = "Precio Compra";
            PrecioCompra.Name = "PrecioCompra";
            // 
            // PrecioVenta
            // 
            PrecioVenta.HeaderText = "Precio Venta";
            PrecioVenta.Name = "PrecioVenta";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.Name = "Categoria";
            // 
            // Disponible
            // 
            Disponible.HeaderText = "Disponible";
            Disponible.Name = "Disponible";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1117, 65);
            panel1.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 188, 251);
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(21, 191);
            button1.Name = "button1";
            button1.Size = new Size(110, 41);
            button1.TabIndex = 10;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(255, 1, 3);
            button2.ForeColor = Color.Transparent;
            button2.Location = new Point(137, 191);
            button2.Name = "button2";
            button2.Size = new Size(110, 41);
            button2.TabIndex = 11;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Lime;
            button3.ForeColor = Color.Transparent;
            button3.Location = new Point(253, 191);
            button3.Name = "button3";
            button3.Size = new Size(110, 41);
            button3.TabIndex = 12;
            button3.Text = "Actualizar";
            button3.UseVisualStyleBackColor = false;
            // 
            // chkdiponible
            // 
            chkdiponible.AutoSize = true;
            chkdiponible.Location = new Point(262, 73);
            chkdiponible.Name = "chkdiponible";
            chkdiponible.Size = new Size(102, 19);
            chkdiponible.TabIndex = 13;
            chkdiponible.Text = "Disponibilidad";
            chkdiponible.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // GestionProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1117, 648);
            Controls.Add(chkdiponible);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Controls.Add(dgDatos);
            Controls.Add(picFoto);
            Controls.Add(txtventa);
            Controls.Add(txtcompra);
            Controls.Add(cmbcategoria);
            Controls.Add(txtcantidad);
            Controls.Add(txtnombre);
            Controls.Add(txtid);
            Name = "GestionProduct";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picFoto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgDatos).EndInit();
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
        private DataGridView dgDatos;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PrecioCompra;
        private DataGridViewTextBoxColumn PrecioVenta;
        private DataGridViewTextBoxColumn Categoria;
        private DataGridViewTextBoxColumn Disponible;
        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private CheckBox chkdiponible;
        private OpenFileDialog openFileDialog1;
    }
}
