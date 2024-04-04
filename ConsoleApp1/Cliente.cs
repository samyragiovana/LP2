using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Cliente:Pessoa
    {
        public Cliente(): base() {
            Console.WriteLine("Construindo objeto Cliente");
        }
        public Cliente(string nome) : base(nome) {
            Console.WriteLine("Construindo objeto Cliente" + nome);
        }

    }
}
