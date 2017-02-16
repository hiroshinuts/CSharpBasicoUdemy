using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_simples_uma_dimensao
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] nomes = new string[3];

            nomes[0] = "Neri";
            nomes[1] = "Hiro";
            nomes[2] = "Babara";

            Console.WriteLine(nomes[0] +  nomes[1] + nomes[2]);
            Console.WriteLine(String.Concat(nomes)); // Concatena todos os dados da string
            Console.WriteLine("Tamanho = " + nomes.Length.ToString());
            Console.ReadLine();

        }
    }
}
