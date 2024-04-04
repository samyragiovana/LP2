using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Circulo:Figura
    {
        double raio;
        double pi = 3.14;

        public Circulo(double raio){
            this.raio = raio;
        }

        public double Raio { get => raio; set => raio = value; }

        public override double calculaArea()
        {
            return pi * (Math.Pow(raio,2));
        }
    }
}
