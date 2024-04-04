using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Computador : IProduto
    {
        public bool eperecivel = false;

        public bool EPerecivel {
            get { return eperecivel; 
        }}


        public Fornecedor RecuperaFornecedor()
        {
            return new Fornecedor("João");
        }

        public void RegistrarVenda(Cliente Cliente)
        {
            Console.WriteLine("Venda registrada do cliente " +  Cliente.nome);
        }
    }
}
