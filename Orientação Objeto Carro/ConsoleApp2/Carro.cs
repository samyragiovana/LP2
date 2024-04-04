using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Carro
    {
        //Atributos
        private String placa;
        private String corLataria;
        private String corParachoque;
        private int aro;
        private String tipoVidro;
        private String marca;
        private String nome;
        private int marcha = 0;
        private int velocidade = 0;


        //Propriedades
        public string Placa { get => placa; set => placa = value; }
        public string CorLataria { get => corLataria; set => corLataria = value; }
        public string Parachoque1 { get => corParachoque; set => corParachoque = value; }
        public int Aro { get => aro; set => aro = value; }
        public string TipoVidro { get => tipoVidro; set => tipoVidro = value; }
        public string Marca { get => marca; set => marca = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Marcha { get => marcha; set => marcha = value; }
        public int Velocidade { get => velocidade; set => velocidade = value; }

        //Métodos
        public void imprimir()
        {
            Console.WriteLine("\n--------------------------------------");
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Cor da Lataria: " + corLataria);
            Console.WriteLine("Cor do Parachoque: " + corParachoque);
            Console.WriteLine("Aro: " + aro);
            Console.WriteLine("Tipo do Vidro: " + tipoVidro);
            Console.WriteLine("Marca: " + marca);
            Console.WriteLine("Modelo: " + nome);

            if(marcha == 0)
                Console.WriteLine("Marcha: Ré");
            else if (marcha == -1)
                Console.WriteLine("Marcha: Neutro");
            else
                Console.WriteLine("Marcha: " + marcha);

            Console.WriteLine("Velocidade: " + velocidade);
            Console.WriteLine("--------------------------------------");
        }

        public void ler()
        {
            Console.WriteLine("Lendo Dados:");
            Console.WriteLine("-----------------\n");


            Console.WriteLine("\nDigite as placa:");
            placa = Console.ReadLine();

            Console.WriteLine("\nDigite a cor da lataria:");
            corLataria = Console.ReadLine();

            Console.WriteLine("\nDigite a cor do parachoque:");
            corParachoque = Console.ReadLine();

            Console.WriteLine("\nDigite o aro:");
            aro = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nDigite o tipo do vidro:");
            tipoVidro = Console.ReadLine();

            Console.WriteLine("\nDigite a marca:");
            marca = Console.ReadLine();

            Console.WriteLine("\nDigite o modelo:");
            nome = Console.ReadLine();
        }

        public void ligar()
        {
            Console.WriteLine("\nLigando o veiculo...");
            Console.WriteLine("Vrum! Vrum!");
            Console.WriteLine("Veiculo ligado\n");


            for (int i = 0; i < 500; i++)
                Console.Beep();
        }

        public void trocarMarcha()
        {
            if(marcha == 5)
                marcha = 0;
            else
                marcha = marcha + 1;
        }

        public void acelerar()
        {
            velocidade = velocidade + 10*marcha;
        }

    }
}
