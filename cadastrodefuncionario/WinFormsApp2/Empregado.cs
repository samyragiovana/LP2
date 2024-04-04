using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp2
{
    internal class Empregado
    {
        private string nome;
        private int idade;

        public Empregado() {
            this.nome = "";
            this.idade = 0;
        }

        public Empregado(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
