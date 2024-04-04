using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atleta
{
    public class Triatleta:Atleta, ICiclista,ICorredor,INadador
    {

        public override void Habilidades()
        {
            //base.Habilidades();
            //MessageBox.Show("Correr,pedalar e nadar");
            new Corredor().Habilidades();
            new Nadador().Habilidades();
            new Ciclista().Habilidades();


        }

        public override void acao()
        {
            MessageBox.Show("O atleta está correndo, pedalando e nadando.");

        }

    }
}
