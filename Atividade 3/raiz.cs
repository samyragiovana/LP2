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
    public partial class raiz : Form
    {
        public raiz()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double raiz;
            raiz = double.Parse(textBox1.Text);

            raiz = Math.Sqrt(raiz);

            label3.Text = Convert.ToString(raiz);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
