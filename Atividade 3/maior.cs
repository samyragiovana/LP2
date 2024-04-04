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
    public partial class maior : Form
    {
        public maior()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, r;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);

            if((a > b) && (a > c)){
                label5.Text = Convert.ToString(a);
            }else if ((b > a) && (b > c))
            {
                label5.Text = Convert.ToString(b);
            }
            else if ((c > b) && (c > b))
            {
                label5.Text = Convert.ToString(c);
            }
            else
            {
                label5.Text = ("Os números são iguais.");
            }
        }
    }
}
