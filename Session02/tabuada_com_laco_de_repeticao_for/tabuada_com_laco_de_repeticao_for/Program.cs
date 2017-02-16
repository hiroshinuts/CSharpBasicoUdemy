using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_com_laco_de_repeticao_for
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um numero..:");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i < 11; i++)
            {
                Console.WriteLine(numero + " x " + i +  " = " + numero * i);
            }
            Console.ReadLine();
        }
    }
}
