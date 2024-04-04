using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Pessoa
    {
        public Pessoa() {
            Console.WriteLine("Construindo objeto em branco");
        }
        public Pessoa(String nome) { 
        Console.WriteLine("Construindo objeto Pessoa: " + nome);

        }
        public virtual void viajar()
        {
            Console.WriteLine("Pessoas viajando!");
        }
    }
}
