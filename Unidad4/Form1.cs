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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ejercicio1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Proyecto1 = new Ejericio1();

            Proyecto1.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ejercicio2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Proyecto2 = new Ejercicio2();

            Proyecto2.Show();
        }

        private void ejercicio3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form Proyecto3 = new Ejercicio3();

            Proyecto3.Show();
        }
    }
}
