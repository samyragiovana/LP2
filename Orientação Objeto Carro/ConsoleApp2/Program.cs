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

            Carro fusca = new Carro();

            //fusca.ler();

            fusca.trocarMarcha();
            fusca.trocarMarcha();
            fusca.trocarMarcha();
            fusca.trocarMarcha();
            fusca.trocarMarcha();

            fusca.acelerar();
            fusca.acelerar();

            fusca.imprimir();

            fusca.ligar();

            Console.ReadKey();
        }
    }
}
