using Gestion_De_Productos.DAO;
using Gestion_De_Productos.Model;
using System.DirectoryServices;

namespace Gestion_De_Productos
{
    public partial class GestionProduct : Form
    {
        private ProductosDAO dao = new ProductosDAO();
        private int cantidadregistrada = 0;


        private void CerrarFormulario()
        {
            DialogResult x = MessageBox.Show("Desea Salir?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (x == DialogResult.Yes)
                this.Close();
        }

        private void buscarimagen()
        {

        }

        private void eliminarimagen()
        {

        }

        private void fillgrid()
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dao.GetAll(); // Asignar los datos al BindingSource
            dgDatos.AutoGenerateColumns = false;
            dgDatos.DataSource = bs;
            dgDatos.Refresh();
            cantidadregistrada = dao.GetAll().Count;
        }

        private void filldata(int id)
        {
            var obj = dao.GetById(id);
            if (obj != null)
            {
                txtid.Text = obj.Id.ToString();
                txtnombre.Text = obj.nombre;
                txtcantidad.Text = obj.cantidad.ToString();
                txtcompra.Text = obj.preciocompra.ToString();
                txtventa.Text = obj.precioventa.ToString();
                cmbcategoria.SelectedItem = obj.categoria;
                chkdiponible.Checked = obj.disponible;
                // picFoto.ImageLocation = obj.Foto;
            }
        }

        private void limpiar()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtcantidad.Clear();
            txtcompra.Clear();
            txtventa.Clear();
            cmbcategoria.SelectedIndex = -1;
            //chkdiponible.Checked = false;
            //picFoto.ImageLocation = "";
            //Deleteimagage();
        }

        private GestionProductos capturar()
        {
            GestionProductos x = new GestionProductos();
            x.Id = Convert.ToInt32(txtid.Text);
            x.nombre = txtnombre.Text.ToUpper();
            x.cantidad = txtcantidad.Text.ToUpper();
            x.preciocompra = txtcompra.Text.ToUpper();
            x.precioventa = txtventa.Text.ToUpper();
            x.categoria = Convert.ToString(cmbcategoria.SelectedItem).ToUpper();
            x.disponible = Convert.ToString(chkdiponible.Checked).ToUpper() == "TRUE" ? true : false;
            //x.Foto = picFoto.ImageLocation;
            return x;
        }
        private void agregar()
        {
            try
            {
                var dia = MessageBox.Show("Desea Agregar?", "Productos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.agregar(capturar());
                    limpiar();
                    fillgrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public GestionProduct()
        {
            InitializeComponent();
        }

        private void picFoto_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void cmbcategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtventa_TextChanged(object sender, EventArgs e)
        {

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
