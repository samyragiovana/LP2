using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace atividade
{
    public partial class Retangulo1 : Form
    {
        public Retangulo1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Retangulo Rt = new Retangulo();
            Rt.Altura = Double.Parse(textBox1.Text);
            Rt.Base1 = Double.Parse(textBox2.Text);
            // MessageBox.Show("RETORNANDO RETANGULO: " + Rt.CalcularArea());
            label5.Text = Convert.ToString(Rt.CalcularArea());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            label5.Text = " ";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Retangulo1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
