using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Vendedor:Pessoa
    {
        public override void viajar()
        {
            base.viajar();
            Console.WriteLine("Realizando vendas!");
        }
    }
}
