using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3
{
    public class Animal
    {
        private string nome;

        public Animal()
        {
            this.nome = "";
        }

        public Animal(string nome) {
            this.nome = nome;
        }
        
        public string Nome { get => nome; set => nome = value; }
        
        public virtual void acao()
        {
            MessageBox.Show("acao do animal..");
        }

        public virtual void fala()
        {
            MessageBox.Show("fala do animal..");
        }

    }
}
