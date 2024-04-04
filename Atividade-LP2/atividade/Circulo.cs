using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Circulo : Figura
    {
        double Raio;

        public double Raio1 { get => Raio; set => Raio = value; }

        public override double CalcularArea() {
        return Math.Round(Math.Pow(this.Raio1, 2) * Math.PI,2);
        }
    }
}