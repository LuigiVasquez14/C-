using Concesionario.DAO;
using Concesionario.Model;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concesionario.UI
{
    public partial class MarcaUI : Form
    {
        private MarcaDAO dao = new MarcaDAO();
      

        private void ClearData()
        {
            txtid.Text = "";
            txtNombre.Clear();
            txtPaisOrigen.Clear();
        }

        private void Fillgrid(int id)
        {
            try
            {
                dgDatosMarcas.DataSource = null;
                dgDatosMarcas.DataSource = dao.GetAll(0);
                dgDatosMarcas.Refresh();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);

            }
       
        }

        private void FillData(int id)
        {
            try
            {
                var x = dao.GetById(id);
                    if (x != null)
                {
                    txtid.Text = id.ToString();
                    txtNombre.Text = x.Nombre.ToUpper();
                    txtPaisOrigen.Text = x.PaisOrigen.ToUpper();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private bool ValidateData()
        {
            if (txtid.Text.Trim() == "")
                throw new Exception("Falta el ID");

            if (txtNombre.Text.Trim() == "")
                throw new Exception("Falta el Nombre");

            if (txtPaisOrigen.Text.Trim() == "")
                throw new Exception("Falta el Pais de origen");

            return true;
        }
        private Marca CaptureData()
        {
            Marca ob = new Marca();
            ob.Id = Convert.ToInt32(txtid.Text);
            ob.Nombre = txtNombre.Text.ToUpper();
            ob.PaisOrigen = txtPaisOrigen.Text.ToUpper();
            ob.FechaCreacion = DateTime.Today;
            return ob;
        }

        private void AddData()
        {
            try
            {
                if (ValidateData())
                {
                    var x = CaptureData();
                    if (MessageBox.Show("Desea Agregar?", "Confirmar", MessageBoxButtons.OKCancel) == DialogResult.OK)

                    {
                        dao.Add(x);
                        Fillgrid();
                        ClearData();
                    }
                }
            }
            catch (Exception ex )
            {
                MessageBox.Show(ex.Message);
            }
        }

        public MarcaUI()
        {
            InitializeComponent();
        }

        private void MarcaUI_Load(object sender, EventArgs e)
        {

        }
    }
}
