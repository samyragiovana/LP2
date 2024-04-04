using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria
{
    public partial class ListaEPesquisa : Form
    {
        public ListaEPesquisa()
        {
            InitializeComponent();
        }

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.livroDataSet);

        }

        private void ListaEPesquisa_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'livroDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.livroDataSet.Livros);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.livrosTableAdapter.FillByTitulo(this.livroDataSet.Livros,textBox1.Text + "%");
        }
    }
}
