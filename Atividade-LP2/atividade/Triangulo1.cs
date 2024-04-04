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
    public partial class Triangulo1 : Form
    {
        public Triangulo1()
        {
            InitializeComponent();
        }

        private void Triangulo1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            label4.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Triangulo Tr = new Triangulo();
            Tr.Altura = Double.Parse(textBox1.Text);
            Tr.Base1 = Double.Parse(textBox2.Text);
            // MessageBox.Show("RETORNANDO TRIANGULO: " + Tr.CalcularArea());
            label4.Text = Convert.ToString(Tr.CalcularArea());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
