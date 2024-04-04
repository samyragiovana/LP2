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
    public partial class animalmamifero : Form
    {

        Gato g = new Gato();
        Cachorro c = new Cachorro();
        public animalmamifero()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                g.Nome = textBox1.Text;
                g.Pelo = textBox2.Text;
                MessageBox.Show("Nome: " + g.Nome + "\nCor do Pelo: " + g.pelo);

            }
            else
            {
                c.Nome = textBox1.Text;
                c.Pelo = textBox2.Text;
                MessageBox.Show("Nome: " + c.Nome + "\nCor do Pelo: " + c.Pelo);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                g.acao();
            }
            else
            {
                c.acao();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                g.fala();
            }
            else
            {
                c.fala();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
