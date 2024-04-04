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
    public partial class km : Form
    {
        public km()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, contakm, custo;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            contakm = b - a;
            custo = 0.85 * (contakm);
            if (custo < 0)
            {
                custo = custo * -1;
            }
            label4.Text = Convert.ToString(custo);
        }
    }
}
