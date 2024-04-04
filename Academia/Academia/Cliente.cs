using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academia
{
    class Cliente
    {
       public string Plano { get; set; }
       public string Nome { get; set; }
       public string Telefone { get; set; }
       public string Endereco { get; set; }
        
    public Cliente(string plano,string nome,string telefone,string endereco)
        {
            Plano = plano;
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
        }
    }
}
