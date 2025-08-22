using Gestion_De_Productos.DAO;
using Gestion_De_Productos.Model;

namespace Gestion_De_Productos
{
    public partial class GestionProduct : Form
    {
        private ProductosDAO dao = new ProductosDAO();
        private int cantidadregistrada = 0;


        private void CerrarFormulario()
        {
            DialogResult x = MessageBox.Show("Desea Salir?","Productos" ,MessageBoxButtons.YesNo,MessageBoxIcon.Question);

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
            dgDatos.AutoGenerateColumns = false;
            dgDatos.DataSource = bs;
            dgDatos.Refresh();
            var x = dao.GetAll();
            cantidadregistrada = x.Count;


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
    }
}
