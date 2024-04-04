using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Mamifero:Animal
    {
        public string pelo;

        public Mamifero(string pelo)
        {
            this.Pelo = pelo;
        }
        public Mamifero()
        {
            this.pelo = "";
        }

        public string Pelo { get => pelo; set => pelo = value; }
    }
}
