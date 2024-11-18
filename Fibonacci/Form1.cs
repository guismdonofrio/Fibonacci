using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbAlgoritimos.Items.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lsbAlgoritimos.Items.Clear();

            int a = 0, b = 1;

            for (int i = 1; i <= 30; i++)
            {
                int soma = a + b;
                a = b;
                b = soma;

                lsbAlgoritimos.Items.Add(a);
            }
        }
    }
}
