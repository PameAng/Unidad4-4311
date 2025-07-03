using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unidad4
{
    public partial class Ejercicio2 : Form
    {
        Dictionary<string, decimal> tasasCambio = new Dictionary<string, decimal>
        {

            {"USD", 1.00m},
            {"EUR", 0.85m},
            {"DOP", 59.00m},
            {"MXN", 17.00m},
            {"JPY", 157.00m}

        };

        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {
            foreach (var moneda in tasasCambio.Keys)
            {
                cbDe.Items.Add(moneda);
                cbA.Items.Add(moneda);
            }
            cbDe.SelectedIndex = 0;
            cbA.SelectedIndex = 1;
        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = decimal.Parse(textBox1.Text);
                string de = cbDe.SelectedItem.ToString();
                string a = cbA.SelectedItem.ToString();

                decimal enUSD = monto / tasasCambio[de];
                decimal convertido = enUSD * tasasCambio[a];

                label1.Text = $"{convertido:F2}{a}";
            }
            catch
            {
                MessageBox.Show("Por favor ingresa un monto.");

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}