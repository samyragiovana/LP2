using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Cachorro:Animal
    {
        public string Pelo { get; internal set; }

        public override void acao()
        {
            MessageBox.Show("protege o dono");
        }

        public override void fala()
        {
            MessageBox.Show("au au au");
        }

    }
}
