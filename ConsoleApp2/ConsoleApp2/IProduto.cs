using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal interface IProduto
    {
       bool EPerecivel { get; }

        Fornecedor RecuperaFornecedor();
        void RegistrarVenda(Cliente Cliente);
    }
}
