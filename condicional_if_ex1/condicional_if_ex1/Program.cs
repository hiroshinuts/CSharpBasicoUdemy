using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicional_if_ex1
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Problema : Crie 2 variavveis (A e B ) e leia 1 valor para cada um deles. Disponibilize eles de forma crescente */

            int a, b;

            Console.Write("digite o valor de A");
            a = Convert.ToInt16(Console.ReadLine());

            Console.Write("digite o valor de B");
            b = Convert.ToInt16(Console.ReadLine());

            if(a > b)
            {
                Console.Write("Em ordem crescente " + b + " - " + a);
            }
            else
            {
                Console.WriteLine("Em ordem crescente " + a + " - " + b);
            }

            Console.ReadKey();

        }
    }
}
