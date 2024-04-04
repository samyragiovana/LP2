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
    public partial class areaCirculo : Form
    {
        public areaCirculo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raio, pi = 3.14, area;
            raio = double.Parse(textBox1.Text);
            area = pi * Math.Pow(raio, 2);

            label3.Text = Convert.ToString(area);
        }

        private void areaCirculo_Load(object sender, EventArgs e)
        {

        }
    }
}
