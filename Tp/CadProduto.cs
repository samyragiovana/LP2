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
    public partial class CadProduto : Form
    {
        public CadProduto()
        {
            InitializeComponent();
        }

        private void cadProdutoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadProdutoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tpDataSet);

        }

        private void CadProduto_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tpDataSet.CadProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.cadProdutoTableAdapter.Fill(this.tpDataSet.CadProduto);

        }
    }
}
