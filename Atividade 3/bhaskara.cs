using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade_3
{
    public partial class bhaskara : Form
    {
        public bhaskara()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, delta;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            delta = ((b * b) - 4 * a * c);

            if (delta > 0)
            {
                Double x1 = ((-(b) + Math.Sqrt(delta)) / 2 * a);
                Double x2 = ((-(b) - Math.Sqrt(delta)) / 2 * a);
                label5.Text = x1.ToString();
                label7.Text = x2.ToString();
            }
            else if (delta == 0)
            {
                Double x1 = ((-(b) + Math.Sqrt(delta)) / 2 * a);
                label5.Text = x1.ToString();
                label6.Text = null;
            }
            else
            {
                label5.Text = ("Não existe raiz");
                label6.Text = null;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
