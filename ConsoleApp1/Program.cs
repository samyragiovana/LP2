using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pessoa p = new Pessoa();
            Pessoa p1 = new Diretor();
            Pessoa p2 = new Vendedor();
            Pessoa p3 = new Funcionario();
            /*Pessoa p2 = new Pessoa("Samyra");
            Console.ReadKey();

            Cliente cliente = new Cliente();    
            Cliente c2 = new Cliente("Ana");
            Console.ReadKey();*/
            p1.viajar();
            p2.viajar();
            p3.viajar();
            Console.ReadKey();

        }
    }
}
