using Gestión_De_Estudiantes.Dao;
using Gestión_De_Estudiantes.Helpers;
using Gestión_De_Estudiantes.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_De_Estudiantes.UI
{
    public partial class EstudiantesUI : Form
    {
        private EstudiantesDAO dao = new EstudiantesDAO();

        private void FillGrid()
        {
            BindingSource bs = new BindingSource();
            dgDatos.AutoGenerateColumns = false;
            var x = dao.GetAll();
            bs.DataSource = x;
            dgDatos.DataSource = bs;
            dgDatos.Refresh();
        }

        private void llenardatos(int id)
        {
            var obj = dao.getById(id);
            if (obj != null)
            {
                Clear();
                txtid.Text = obj.Id.ToString();
                txtnombre.Text = obj.Nombre.ToUpper();
                txtapellido.Text = obj.Apellido.ToString();
                txtsangre.Text = obj.TipoSangre.ToUpper();
                txtpeso.Text = obj.Peso.ToString();
                txtestatura.Text = obj.Estatura.ToString();
                txtcorreo.Text = obj.Correo.ToLower();
                txtcurso.Text = obj.Curso.ToString();
            }
        }
        private void Clear()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtapellido.Clear();
            txtsangre.Clear();
            txtpeso.Clear();
            txtestatura.Clear();
            txtcorreo.Clear();
        }

        private Estudiantes capture()
        {
            Estudiantes x = new Estudiantes();
            x.Id = Convert.ToInt32(txtid.Text);
            x.Nombre = txtnombre.Text.ToUpper();
            x.Apellido = txtapellido.Text.ToUpper();
            x.TipoSangre = txtsangre.Text.ToUpper();
            x.Peso = Convert.ToDecimal(txtpeso.Text);
            x.Estatura = Convert.ToDecimal(txtestatura.Text);
            x.Correo = txtcorreo.Text.ToLower();
            x.Curso = Convert.ToDecimal(txtcurso.Text);
            return x;
        }
        private void Add()
        {
            try
            {
                var dia = MessageBox.Show("¿Estás seguro de que deseas agregar este estudiante?", "Confirmar Adición", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    var x = capture();
                    dao.Add(x);
                    FillGrid();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Update()
        {
            try
            {
                var dia = MessageBox.Show("¿Estás seguro de que deseas actualizar este estudiante?", "Confirmar Actualización", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.Update(capture());
                    FillGrid();
                    Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void initialicer()
        {
            FillGrid();
        }

        public EstudiantesUI()
        {
            InitializeComponent();


            this.FormBorderStyle = FormBorderStyle.None;

            // O usar una border style que no tenga controles
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.ControlBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            this.Text = ""; // Opcional: quitar el texto de la barra de título
        }

        private void EstudiantesUI_Load(object sender, EventArgs e)
        {
            initialicer();
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            Add();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {

            {

                {
                    if (dgDatos.SelectedRows.Count > 0)
                    {

                        dgDatos.Rows.RemoveAt(dgDatos.SelectedRows[0].Index);


                    }

                }
            }
        }

        private void dgDatos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            if (fila > -1)
                llenardatos(Convert.ToInt32(dgDatos[0, fila].Value));

        }

        private void txtbuscar_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dao.GetAll().Where(
                x => x.Nombre.ToUpper().Contains(txtbuscar.Text.ToUpper()) ||
                x.Apellido.ToUpper().Contains(txtbuscar.Text.ToUpper()) ||
                x.Correo.ToLower().Contains(txtbuscar.Text.ToLower())
                ).ToList();
            dgDatos.DataSource = bs;
            dgDatos.Refresh();

        }
    }
    }


