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
            //Figura f = new Figura();
            Figura f1 = new Circulo(3);
            Figura f2 = new Triangulo(3,5);
            Figura f3 = new Retangulo(3,5);

            Console.WriteLine("A area do circulo é: " + f1.calculaArea());
            Console.WriteLine("A area do triangulo é: " + f2.calculaArea());
            Console.WriteLine("A area do retangulo é: " + f3.calculaArea());
            
            Console.ReadKey();
        }
    }
}
