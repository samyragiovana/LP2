using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Computador computador = new Computador();
            Fornecedor fornecedor = computador.RecuperaFornecedor();
            Console.WriteLine("Fornecedor " +  fornecedor.nome);
            Cliente cliente = new Cliente("Juca");
            computador.RegistrarVenda(cliente);
            Console.ReadKey();
                }
    }
}
