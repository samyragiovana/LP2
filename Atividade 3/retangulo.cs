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
    public partial class retangulo : Form
    {
        public retangulo()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double b, h, r;
            b = double.Parse(textBox1.Text);
            h = double.Parse(textBox2.Text);
            r = b * h;

            label5.Text = Convert.ToString(r);

        }
    }
}
