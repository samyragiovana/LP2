using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Retangulo : Figura
    {
        double b, h;

        public Retangulo(double b, double h)
        {
            this.b = b;
            this.h = h;

        }

        public double B { get => b; set => b = value; }
        public double H { get => h; set => h = value; }

        public override double calculaArea()
        {
            return b*h;
        }
    }

    
}
