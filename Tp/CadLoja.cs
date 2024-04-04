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
    public partial class CadLoja : Form
    {
        public CadLoja()
        {
            InitializeComponent();
        }

        private void cadLojaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cadLojaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.tpDataSet);

        }

        private void CadLoja_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'tpDataSet.CadLoja'. Você pode movê-la ou removê-la conforme necessário.
            this.cadLojaTableAdapter.Fill(this.tpDataSet.CadLoja);

        }
    }
}
