using Gestión_De_Estudiantes.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestión_De_Estudiantes.UI
{
    public partial class ConsultasUI : Form
    {
        public ConsultasUI()
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

        private void ConsultasUI_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtbuscarsangre_Click(object sender, EventArgs e)
        {
            string tipoSeleccionado = cmbsangre.SelectedItem?.ToString() ?? "";

            // Lista de tipos de sangre válidos
            string[] tiposSangreValidos = { "A-", "A+", "AB-", "AB+", "B-", "B+", "O-", "O+" };

            if (tiposSangreValidos.Contains(tipoSeleccionado))
            {
                var listaFiltrada = LVHelper.OrdenarPorSangre()
                                    .Where(x => x.TipoSangre == tipoSeleccionado)
                                    .ToList();
                dgConsultas.DataSource = listaFiltrada;

                // Opcional: Mostrar mensaje si no hay resultados
                if (!listaFiltrada.Any())
                {
                    MessageBox.Show($"No se encontraron registros para el tipo de sangre {tipoSeleccionado}.",
                                    "Sin resultados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un tipo de sangre válido.",
                                "Selección inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void dgSangre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {



        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ordenSeleccionado = cmbpeso.SelectedItem?.ToString() ?? "";

            // Lista de órdenes válidos
            string[] ordenesValidos = { "Mas Pesado", "Menos Pesado" };

            if (ordenesValidos.Contains(ordenSeleccionado))
            {
                var listaOrdenada = LVHelper.OrdenarPorPeso();

                if (ordenSeleccionado == "Menos Pesado")
                {
                    listaOrdenada = listaOrdenada.OrderBy(x => x.Peso).ToList();
                }
                else if (ordenSeleccionado == "Mas Pesado")
                {
                    listaOrdenada = listaOrdenada.OrderByDescending(x => x.Peso).ToList();
                }

                dgConsultas.DataSource = listaOrdenada;

                // Opcional: Mostrar mensaje si no hay resultados
                if (!listaOrdenada.Any())
                {
                    MessageBox.Show($"No se encontraron registros para el orden {ordenSeleccionado}.",
                                    "Sin resultados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un orden válido.",
                                "Selección inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ordenSeleccionado = cmbestatu.SelectedItem?.ToString() ?? "";

            // Lista de órdenes válidos
            string[] ordenesValidos = { "Mas Alto", "Menos Alto" };

            if (ordenesValidos.Contains(ordenSeleccionado))
            {
                var listaOrdenada = LVHelper.OrdenarPorPeso();

                if (ordenSeleccionado == "Mas Bajo")
                {
                    listaOrdenada = listaOrdenada.OrderBy(x => x.Estatura).ToList();
                }
                else if (ordenSeleccionado == "Mas Alto")
                {
                    listaOrdenada = listaOrdenada.OrderByDescending(x => x.Estatura).ToList();
                }

                dgConsultas.DataSource = listaOrdenada;

                // Opcional: Mostrar mensaje si no hay resultados
                if (!listaOrdenada.Any())
                {
                    MessageBox.Show($"No se encontraron registros para el orden {ordenSeleccionado}.",
                                    "Sin resultados",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un orden válido.",
                                "Selección inválida",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }
        }
    }
}
