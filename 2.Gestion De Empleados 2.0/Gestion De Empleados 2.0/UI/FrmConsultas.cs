using Gestion_De_Empleados_2._0.Helpers.HelEmpleado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Empleados_2._0.UI
{
    public partial class FrmConsultas : Form
    {
        public FrmConsultas()
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
        private void FrmConsultas_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orden = cmbsalario.SelectedItem?.ToString() ?? "";

            if (orden.ToLower() == "igual")
            {
                if (double.TryParse(cmbsalario.Text, out double salario))
                {
                    dgConsultas.DataSource = null;
                    dgConsultas.DataSource = WMHelperEmpleado.OrdenarPorSalario(orden, salario);
                }
                else
                {
                    MessageBox.Show("Por favor ingresa un número válido.");
                }
            }
            else
            {
                dgConsultas.DataSource = null;
                dgConsultas.DataSource = WMHelperEmpleado.OrdenarPorSalario(orden);
            }
        }

        private void cmbsalario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
