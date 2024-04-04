using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    internal class Oviparo:Animal
    {
        string corDaPena;

        public Oviparo(string corDaPena)
        {
            this.CorDaPena = corDaPena;
        }

        public Oviparo()
        {
            this.corDaPena = "";
        }

        public string CorDaPena { get => corDaPena; set => corDaPena = value; }
    }
}
