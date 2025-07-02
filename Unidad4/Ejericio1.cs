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
                tbapellido.Text, tbcedula.Text, tbcorreo.Text, tbdirrecion.Text, tbedad.Text,
                tbestado.Text, tbgenero.Text, tbnacimiento.Text, tbnacionalidad.Text, tbnombre.Text,
                tbocupacion.Text, tbtelefono.Text
                );

            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox) ((TextBox)ctrl).Clear();

            }
        }

        private void Ejericio1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 12;
            for (int i = 0; i < 12; i++)
            {
                dataGridView1.Columns[i].Name = $"campo{i + 1}";
            }
        }
    }
}
