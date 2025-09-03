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
    public partial class FrmDatosEmpleados : Form
    {
        private EmpleadosDao dao = new EmpleadosDao();

        private void fillgrid()
        {
            var x = dao.GetAll();
            BindingSource bs = new BindingSource();
            dgDatos.AutoGenerateColumns = false;
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
                cmbgenero.Text = obj.Genero;
                cmbcargo.Text = obj.Cargo;
                //dttiempo.Value = obj.FechaDeIngreso;

            }
        }

        


        private void clear()
        {
            txtid.Clear();
            txtnombre.Clear();
            //dttiempo.Value = DateTime.Now;
            cmbgenero.SelectedIndex = -1;
            cmbcargo.SelectedIndex = -1;
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
            x.Genero = cmbgenero.Text;
            x.Cargo = cmbcargo.Text;
            //x.FechaDeIngreso = dttiempo.Text;
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

        private void initialicer()
        {
            WMHelperEmpleado.Seed();
            WMHelperCargos.Seed();
            fillgrid();


        }


        public FrmDatosEmpleados()
        {
            InitializeComponent();

        }

        private void PanelContenedor_Load(object sender, EventArgs e)
        {
            initialicer();

        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            add();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (dgDatos.SelectedRows.Count > 0)
            {

                dgDatos.Rows.RemoveAt(dgDatos.SelectedRows[0].Index);


            }
        }


        private void btnactualizar_Click(object sender, EventArgs e)
        {
            update();
        }

        private void dgDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > 0)
                filldata(Convert.ToInt32(dgDatos[0, f].Value));
        }

        private void dttiempo_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
