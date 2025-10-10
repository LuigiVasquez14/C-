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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Empleados_2._0
{
    public partial class FrmCargos : Form
    {
        private CargoDao dao = new CargoDao();

        private void fillgrid()
        {
            try
            {
                dgDatos2.DataSource = null;
                dgDatos2.DataSource= dao.GetAll();
                dgDatos2.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void filldata(int id)
        {
            try
            {
                var obj = dao.GetById(id);
                if (obj != null)
                {

                    txtid.Text = obj.Id.ToString();
                    txtnombre.Text = obj.Nombre.ToUpper();
                    txtfunciones.Text = obj.Funciones.ToUpper();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
        }


        private void clear()
        {
            txtid.Clear();
            txtnombre.Clear();
            txtfunciones.Clear();
        }
       private bool ValidateData()
        {
            return true;
           

        }

        private void UpdateData()
        {
            try
            {
                if (ValidateData())
                {
                    var x = capture();
                    var dia = MessageBox.Show("¿Desea actualizar el cargo?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dia == DialogResult.Yes)
                    {
                        dao.update(x);
                        clear();
                        fillgrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteData()
        {
            try
            {
                if (ValidateData())
                {
                    var dia = MessageBox.Show("¿Desea eliminar el cargo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dia == DialogResult.Yes)
                    {
                        dao.Delete(Convert.ToInt32(txtid.Text));
                        clear();
                        fillgrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddData()
        {
                       try
            {
                if (ValidateData())

                {
                    var x = capture();
                    var dia = MessageBox.Show("¿Desea agregar un nuevo cargo?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dia == DialogResult.Yes)
                    {
                        dao.add(x);
                        clear();
                        fillgrid();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                var dia = MessageBox.Show("¿Desea agregar un nuevo cargo?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                var dia = MessageBox.Show("¿Desea actualizar el cargo?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                var dia = MessageBox.Show("¿Desea eliminar el cargo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        private void residence_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void initialicer()
        {
            
            fillgrid();
        }
            

        public FrmCargos()
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

       

        private void PanelContenedor2_Load(object sender, EventArgs e)
        {
            initialicer();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DeleteData();
        }


        private void btnactualizar_Click(object sender, EventArgs e)
        {
            UpdateData();
        }

        private void dgDatos2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int f = e.RowIndex;
            if (f > 0)
                filldata(Convert.ToInt32(dgDatos2[0, f].Value));
        }
    }
}
