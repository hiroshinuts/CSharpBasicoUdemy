using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores_relacionais
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("digite o valor de A");
            a = Convert.ToInt16(Console.ReadLine());

            Console.Write("digite o valor de B");
            b = Convert.ToInt16(Console.ReadLine());

            if (a > b)
            {
                Console.Write("O  " + a + "é o maior");
            }
            else
            {
                Console.WriteLine("O " + b + "é maior");
            }

            if (a != b)
            {
                Console.WriteLine("A é diferente de B");
            }
            else
            {
                Console.WriteLine("A é igual a B");
            }

            Console.ReadKey();

        }


    }
}


