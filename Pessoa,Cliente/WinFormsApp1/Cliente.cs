using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Cliente:Pessoa
    {
        String[] v = { "Arroz", "Sal", "Açucar" };
        public void comprar(int idProduto)
        {
            MessageBox.Show("Comprando: " + v[idProduto]);
        }
    }
}
