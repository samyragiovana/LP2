using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividade
{
    public class Retangulo : Figura
    {
        double base1;
        double altura;

        public double Base1 { get => base1; set => base1 = value; }
        public double Altura { get => altura; set => altura = value; }

        public override double CalcularArea()
        {
            return base1 * altura;
        }
    }
}
