using Gestion_De_Empleados_2._0.Dao;
using Gestion_De_Empleados_2._0.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Empleados_2._0
{
    public partial class PanelContenedor : Form
    {
        private EmpleadosDao dao = new EmpleadosDao();

        private void fillgrid()
        {
            BindingSource bs = new BindingSource();
            dgDatos.AutoGenerateColumns = false;
            var x = dao.GetAll();
            bs.DataSource = x;
            dgDatos.DataSource = bs;
            dgDatos.Refresh();
        }

        private void filldata(int id)
        {
            var obj = dao.GetById(id);
            if (obj != null)
            {
                clear();
                txtid.Text = obj.Id.ToString();
                txtnombre.Text = obj.Nombre.ToUpper();
                txtapellido.Text = obj.Apellido.ToUpper();
                txtsalario.Text = obj.Salario.ToString();
                cmbgenero.SelectedItem = obj.Genero;
                cmbcargo.SelectedItem = obj.Cargo;
                //dttiempo.Value = obj.FechaDeIngreso;

            }
        }


        private void clear()
        {
            txtid.Clear();
            txtnombre.Clear();
            //dttiempo.Value = DateTime.Now;
            cmbgenero.SelectedIndex = 0;
            cmbcargo.SelectedIndex = 0;
            txtsalario.Clear();
            //picFoto.Image = null;
        }

        private Empleados capture()
        {
            Empleados x = new Empleados();
            x.Id = Convert.ToInt32(txtid.Text);
            x.Nombre = txtnombre.Text.ToUpper();
            x.Apellido = txtapellido.Text.ToUpper();
            x.Salario = Convert.ToDecimal(txtsalario.Text);
            x.Genero = cmbgenero.SelectedItem.ToString();
            x.Cargo = cmbcargo.SelectedItem.ToString();
            //x.FechaDeIngreso = dttiempo.Value;
            return x;
        }

        private void add()
        {
            try
            {
                var dia = MessageBox.Show("¿Desea agregar un nuevo empleado?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.Add(capture());
                    clear();
                    fillgrid();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void update()
        {
            try
            {
                var dia = MessageBox.Show("¿Desea actualizar el empleado?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.Update(capture());
                    clear();
                    fillgrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void delete()
        {
            try
            {
                var dia = MessageBox.Show("¿Desea eliminar el empleado?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.Delete(Convert.ToInt32(txtid.Text));
                    clear();
                    fillgrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public PanelContenedor()
        {
            InitializeComponent();
        }

        private void PanelContenedor_Load(object sender, EventArgs e)
        {

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            delete();
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
