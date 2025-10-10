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
        private void CargarCargos()
        {
            CargoDao cargoDao = new CargoDao();
            var listacargos = cargoDao.GetAll();

            cmbcargo.DataSource = listacargos;
            cmbcargo.DisplayMember = "Nombre";
            
        }
        

        private void fillgrid()
        {
            var x = dao.GetAll();
            BindingSource bs = new BindingSource();
            dgDatos.AutoGenerateColumns = true;
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
                dttiempo.Value = obj.FechaDeIngreso;

            }
        }

        private void clear()
        {
            txtid.Clear();
            txtnombre.Clear();
            dttiempo.Value = DateTime.Now;
            cmbgenero.SelectedIndex = -1;
            cmbcargo.SelectedIndex = -1;
            txtsalario.Clear();
            
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
            x.FechaDeIngreso = dttiempo.Value;

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

        private void initialicer()
        {
            WMHelperEmpleado.Seed();
            CargarCargos();
            cmbcargo.SelectedIndex = -1;
            fillgrid();


        }
        private void residence_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }



        public FrmDatosEmpleados()
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
        DataTable Table;

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
          
            {
                if (dgDatos.SelectedRows.Count > 0)
                {

                    dgDatos.Rows.RemoveAt(dgDatos.SelectedRows[0].Index);


                }

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

        private void txtfiltro_TextChanged_1(object sender, EventArgs e)
        {

           var filtro = txtfiltro.Text;

    // Obtén todos los empleados y filtra la lista en memoria usando LINQ
    var lista = dao.GetAll().Where(x => 
        x.Nombre.Contains(filtro) || 
        x.Apellido.Contains(filtro) || 
        x.Cargo.Contains(filtro) || 
        x.Genero.Contains(filtro)
    ).ToList();

    // Crea un nuevo BindingSource con la lista filtrada
    BindingSource bs = new BindingSource();
    bs.DataSource = lista;

    // Asigna la nueva fuente de datos al DataGridView
    dgDatos.DataSource = bs;
    dgDatos.Refresh();
        }

        private void txtfiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var filtro = txtfiltro.Text;
                var lista = dao.GetAll().Where(x => x.Nombre.Contains(filtro) || x.Apellido.Contains(filtro) || x.Cargo.Contains(filtro) || x.Genero.Contains(filtro)).ToList();
                BindingSource bs = new BindingSource();
                bs.DataSource = lista;
                dgDatos.DataSource = bs;
                dgDatos.Refresh();
            }
        }
    }
}
