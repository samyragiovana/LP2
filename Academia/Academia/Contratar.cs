using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class Contratar : Form
    {
       /* private readonly Contratar _parent;*/
        
        public Contratar(Contratar parent)
        {
            InitializeComponent();
            //_parent = parent ;
        }

        public void bntFinalizar(object sender, EventArgs e)
        {
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
            Ctt c = new Ctt();
            c.ShowDialog();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.academiaDataSet);

        }

        private void Contratar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'academiaDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.academiaDataSet.Cliente);

        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
