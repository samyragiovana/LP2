using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class Pessoa
    {
        private String nome,id,cpf;
        private int idade;

        public string Nome { get => nome; set => nome = value; }
        public string Id { get => id; set => id = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public int Idade { get => idade; set => idade = value; }
    }
}
