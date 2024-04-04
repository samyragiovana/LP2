using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Galinha : Oviparo
    {
        public override void acao()
        {
            MessageBox.Show("Bota ovo");
        }

        public override void fala()
        {
            MessageBox.Show("có có có");
        }

    }
}
