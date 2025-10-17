using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_De_Estudiantes.UI
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void childform(Form childform)
        {
            if (this.PanelContenedor.Controls.Count > 0)
                this.PanelContenedor.Controls.RemoveAt(0);
            childform.TopLevel = false;
            childform.Dock = DockStyle.Fill;
            this.PanelContenedor.Controls.Add(childform);
            this.PanelContenedor.Tag = childform;
            childform.Show();
        }

        private void MainUI_Load(object sender, EventArgs e)
        {

        }

        private void btnestudiantes_Click(object sender, EventArgs e)
        {
            EstudiantesUI panelcontenedor = new EstudiantesUI();
            childform(panelcontenedor);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnconsultas_Click(object sender, EventArgs e)
        {
            ConsultasUI panelcontenedor = new ConsultasUI();
            childform(panelcontenedor);
        }

    }
}
