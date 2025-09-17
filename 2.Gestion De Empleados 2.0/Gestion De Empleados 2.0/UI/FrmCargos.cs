using Gestion_De_Empleados_2._0.Dao;
using Gestion_De_Empleados_2._0.Helpers.HelEmpleado;
using Gestion_De_Empleados_2._0.Helpers.HelpCargos;
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
    public partial class FrmCargos : Form
    {
        private CargoDao dao = new CargoDao();

        private void fillgrid()
        {
            BindingSource bs = new BindingSource();
            dgDatos2.AutoGenerateColumns = false;
            var x = dao.GetAll();
            bs.DataSource = x;
            dgDatos2.DataSource = bs;
            dgDatos2.Refresh();
        }

        private void filldata(int id)
        {
            var obj = dao.GetById(id);
            if (obj != null)
            {
                clear();
                txtid.Text = obj.Id.ToString();
                txtnombre.Text = obj.Nombre.ToUpper();
                txtfunciones.Text = obj.Funciones.ToString();


            }
        }


        private void clear()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtfunciones.Clear();
        }

        private Cargo capture()
        {
            Cargo x = new Cargo();
            x.Id = Convert.ToInt32(txtid.Text);
            x.Nombre = txtnombre.Text.ToUpper();
            x.Funciones = txtfunciones.Text.ToUpper();
            return x;
        }

        private void add()
        {
            try
            {
                var dia = MessageBox.Show("¿Desea agregar un nuevo empleado?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dia == DialogResult.Yes)
                {
                    dao.add(capture());
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
                    dao.update(capture());
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Para que no marque error al dar clic en el encabezado
            {
                // Seleccionar la fila completa
                dgDatos2.Rows[e.RowIndex].Selected = true;
            }
        }

        private void initialicer()
        {
            WMHelperEmpleado.Seed();
            WMHelperCargos.Seed();
            fillgrid();


        }

        public FrmCargos()
        {
            InitializeComponent();
        }

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PanelContenedor2_Load(object sender, EventArgs e)
        {
            initialicer();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgDatos2.SelectedRows.Count > 0)
            {
                
                dgDatos2.Rows.RemoveAt(dgDatos2.SelectedRows[0].Index);

                
            }
        }


        private void btnactualizar_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dgDatos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > 0)
                filldata(Convert.ToInt32(dgDatos2[0, f].Value));
        }
    }
}
