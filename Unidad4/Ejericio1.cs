using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4
{
    public partial class Ejericio1 : Form
    {
        public Ejericio1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(
                tbnombre.Text, tbapellido.Text, tbedad.Text, tbgenero.Text, tbdirrecion.Text, tbtelefono.Text, tbcorreo.Text,
                tbnacionalidad.Text, tbestado.Text, tbocupacion.Text, tbcedula.Text, tbnacimiento.Text

                );

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox) ((TextBox)ctrl).Clear();

            }
        }

        private void Ejericio1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 12;
            dataGridView1.Columns[0].Name = "Nombres";
            dataGridView1.Columns[1].Name = "Apellidos";
            dataGridView1.Columns[2].Name = "Edad";
            dataGridView1.Columns[3].Name = "Género";
            dataGridView1.Columns[4].Name = "Dirección";
            dataGridView1.Columns[5].Name = "Teléfono";
            dataGridView1.Columns[6].Name = "Correo";
            dataGridView1.Columns[7].Name = "Nacionalidad";
            dataGridView1.Columns[8].Name = "Estado Civil";
            dataGridView1.Columns[9].Name = "Ocupación";
            dataGridView1.Columns[10].Name = "Cédula";
            dataGridView1.Columns[11].Name = "Fecha de Nacimiento";
        }

        private void tbnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
