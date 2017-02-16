using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_laco_repeticao_while
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.Write("Digite um numero..:");
            numero = int.Parse(Console.ReadLine());

            int i = 1;
            while(i < 11)
            {
                Console.WriteLine(numero + " x " + 1 + " = " +(numero * i));
                i++;
            }



            Console.ReadLine();
        }
    }
}
