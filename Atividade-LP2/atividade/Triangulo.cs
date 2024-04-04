using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Triangulo : Figura
    {
        double h;
        double b;

        public double Altura { get => h; set => h = value; }
        public double Base1 { get => b; set => b = value; }

        public override double CalcularArea()
        {
            return (b * h) / 2;
        }
    }
}
