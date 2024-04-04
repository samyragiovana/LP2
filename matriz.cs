using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] v = new int[10];
            for(int i=0; i<v.Length; i++)
            {
                v[i] = i;
            } for(int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }
            Console.WriteLine();
            int[,] m = new int[10,10];
            for(int i=0; i<10; i++)
            {
                for(int j=0; j< 10; j++)
                {
                    m[i,j] = i * 10 +j;
                }
            }
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(m[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();


        }
    } 
}
