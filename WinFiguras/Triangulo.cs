using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Triangulo : Figura
    {
        public Triangulo() { }
        double b, h;

        public double B { get => b; set => b = value; }
        public double H { get => h; set => h = value; }

        public Triangulo(double b, double h)
        {
            this.b = b;
            this.h = h;
        }

        public override double calculaArea()
        {
            return (b * h) / 2;
        }
    }
}
