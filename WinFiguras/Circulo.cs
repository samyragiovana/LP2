using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Circulo:Figura
    {
        public Circulo() { }
        double raio;
        double pi = 3.14;

        public double Raio { get => raio; set => raio = value; }

        public Circulo(double raio)
        {
            this.raio = raio;
        }

        public override double calculaArea()
        {
            return pi * (Math.Pow(raio, 2));
        }

    }
}
