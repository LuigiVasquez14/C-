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
    public partial class DatosEmpleados : Form
    {
        public DatosEmpleados()
        {
            InitializeComponent();
        }

        private void openchildform(object childform)
        {
            if (this.panel1.Controls.Count > 0)
                this.panel1.Controls.RemoveAt(0);
            Form fh = childform as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(fh);
            this.panel1.Tag = fh;
            fh.Show();
        }






        private void DatosEmpleados_Load(object sender, EventArgs e)
        {

        }

        private void btndatos_Click(object sender, EventArgs e)
        {
            FrmDatosEmpleados panelContenedor = new FrmDatosEmpleados();
            openchildform(panelContenedor);

        }

        private void btncargos_Click(object sender, EventArgs e)
        {
            FrmCargos panelContenedor2 = new FrmCargos();
            openchildform(panelContenedor2);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFiltros_Click(object sender, EventArgs e)
        {
            FrmFiltros panelFiltros = new FrmFiltros();
            openchildform(panelFiltros);
        }
    }
}
