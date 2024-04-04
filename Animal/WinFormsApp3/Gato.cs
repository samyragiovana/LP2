using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Gato:Mamifero
    {

        public override void acao()
        {
            MessageBox.Show("caça");
        }

        public override void fala()
        {
            MessageBox.Show("miau miau");
        }

    }
}
