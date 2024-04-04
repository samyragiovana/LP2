using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace atividade
{
    public partial class Circulo1 : Form
    {
        public Circulo1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            label4.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Circulo C = new Circulo();
            C.Raio1 = Double.Parse(textBox1.Text);
            // MessageBox.Show("RETORNANDO CIRCULO: " + C.CalcularArea());
            label4.Text = Convert.ToString(C.CalcularArea());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
