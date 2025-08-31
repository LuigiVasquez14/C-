using Gestion_De_Productos.DAO;
using Gestion_De_Productos.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Gestion_De_Productos
{
    public partial class FormCategoria : Form
    {


        private CategoriaDao dao = new CategoriaDao();
        private int cantidadregistrada = 0;

        //private void closeform()


        //private void searchimage()

        //private void deleteimage()

        private void fillgrid()
        {
            BindingSource bs = new BindingSource();
            dgDatos2.AutoGenerateColumns = false;
            var x = dao.tenertodo();
            bs.DataSource = x;
            dgDatos2.DataSource = bs;
            dgDatos2.Refresh();
        }

        private void clear()
        {
            txtidcate.Clear();
            txtnombrecate.Clear();
        }

        private void filldata(int identificacion)
        {
            var obj = dao.Conseguirporidentificacion(identificacion);
            if (obj != null)
            {
                clear();
                txtidcate.Text = obj.identificacion.ToString();
                txtnombrecate.Text = obj.Nombre.ToString();
            }
        }

        private Categorias capturar()
        {
            Categorias x = new Categorias();
            x.identificacion = Convert.ToInt32(txtidcate.Text);
            x.Nombre = txtnombrecate.Text;
            return x;
        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtidcate.Text != "")
                {
                    int id = Convert.ToInt32(txtidcate.Text);
                    filldata(id);
                }
                else
                {
                    MessageBox.Show("Ingrese una identificacion", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void agregar()
        {
            try
            {
                var dia = MessageBox.Show("Desea Agregar?", "Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.agregarcate(capturar());
                    clear();
                    fillgrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            // Verifica si hay al menos una fila seleccionada
            if (dgDatos2.SelectedRows.Count > 0)
            {
                // Confirma eliminación (opcional)
                DialogResult result = MessageBox.Show("¿Está seguro de que desea eliminar esta fila?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Elimina la fila seleccionada del DataGridView
                    dgDatos2.Rows.RemoveAt(dgDatos2.SelectedRows[0].Index);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una fila para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        




        public FormCategoria()
        {
            InitializeComponent();
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {

        }
      

        private void btnagregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        

        private void btneliminar_Click_1(object sender, EventArgs e)
        {
            btnEliminar_Click(sender, e);
        }

        private void txtnombrecate_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
