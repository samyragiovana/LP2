using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           CadLoja cadLoja = new CadLoja();
           cadLoja.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CadProduto cadProduto = new CadProduto();
            cadProduto.ShowDialog();
        }
    }
}
