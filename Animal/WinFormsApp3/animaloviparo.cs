using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class animaloviparo : Form
    {
        Galinha g1 = new Galinha();
        public animaloviparo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            g1.Nome = textBox1.Text;
            g1.CorDaPena = textBox2.Text;
            MessageBox.Show("Nome: " + g1.Nome + "\nCor da Pena: " + g1.CorDaPena);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            g1.acao();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            g1.fala();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
