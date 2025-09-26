namespace Concesionario.UI
{
    partial class MarcaUI
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
            txtPaisOrigen = new TextBox();
            txtNombre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            dgDatosMarcas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            PaìsDeOrigen = new DataGridViewTextBoxColumn();
            FechaCreacion = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgDatosMarcas).BeginInit();
            SuspendLayout();
            // 
            // txtid
            // 
            txtid.Location = new Point(37, 13);
            txtid.Name = "txtid";
            txtid.Size = new Size(157, 23);
            txtid.TabIndex = 0;
            txtid.Text = "ID";
            // 
            // txtPaisOrigen
            // 
            txtPaisOrigen.Location = new Point(37, 94);
            txtPaisOrigen.Name = "txtPaisOrigen";
            txtPaisOrigen.Size = new Size(157, 23);
            txtPaisOrigen.TabIndex = 1;
            txtPaisOrigen.Text = "Paìs de origen";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(37, 51);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(157, 23);
            txtNombre.TabIndex = 2;
            txtNombre.Text = "Nombre";
            // 
            // button1
            // 
            button1.Location = new Point(12, 176);
            button1.Name = "button1";
            button1.Size = new Size(85, 34);
            button1.TabIndex = 3;
            button1.Text = "Nuevo";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(103, 176);
            button2.Name = "button2";
            button2.Size = new Size(96, 34);
            button2.TabIndex = 4;
            button2.Text = "Agregar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(205, 176);
            button3.Name = "button3";
            button3.Size = new Size(96, 34);
            button3.TabIndex = 5;
            button3.Text = "Eliminar";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(307, 176);
            button4.Name = "button4";
            button4.Size = new Size(96, 34);
            button4.TabIndex = 6;
            button4.Text = "Actualizar";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgDatosMarcas
            // 
            dgDatosMarcas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgDatosMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDatosMarcas.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, PaìsDeOrigen, FechaCreacion });
            dgDatosMarcas.Location = new Point(425, 13);
            dgDatosMarcas.Name = "dgDatosMarcas";
            dgDatosMarcas.Size = new Size(444, 401);
            dgDatosMarcas.TabIndex = 7;
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
            // PaìsDeOrigen
            // 
            PaìsDeOrigen.HeaderText = "Paìs de Origen";
            PaìsDeOrigen.Name = "PaìsDeOrigen";
            // 
            // FechaCreacion
            // 
            FechaCreacion.HeaderText = "Fecha Creacion";
            FechaCreacion.Name = "FechaCreacion";
            // 
            // MarcaUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(36, 25, 67);
            ClientSize = new Size(871, 380);
            Controls.Add(dgDatosMarcas);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtNombre);
            Controls.Add(txtPaisOrigen);
            Controls.Add(txtid);
            Name = "MarcaUI";
            Text = "MarcaUI";
            Load += MarcaUI_Load;
            ((System.ComponentModel.ISupportInitialize)dgDatosMarcas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtid;
        private TextBox txtPaisOrigen;
        private TextBox txtNombre;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView dgDatosMarcas;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn PaìsDeOrigen;
        private DataGridViewTextBoxColumn FechaCreacion;
    }
}