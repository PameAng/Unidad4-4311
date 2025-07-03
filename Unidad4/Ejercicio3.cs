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

namespace Unidad4
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            if (int.TryParse(txtIngresar.Text, out int limite) && limite >= 0)
            {
                StringBuilder sb = new StringBuilder();
                int a = 0, b = 1;

                while (a < limite)
                {
                    sb.Append(a + " ");
                    int temp = a;
                    a = b;
                    b = temp + b;
                }
                txtResultado.Text = sb.ToString();

            }
            else
            { 
                MessageBox.Show("Ingrese un número mayor o igual a cero");
            }
        }
    }
}
