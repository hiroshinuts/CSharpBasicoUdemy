using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_simples
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um numero..:");
            numero = int.Parse(Console.ReadLine());

            Console.WriteLine(numero + " x 1 = " + numero * 1);
            Console.WriteLine(numero + " x 2 = " + numero * 2);
            Console.WriteLine(numero + " x 3 = " + numero * 3);
            Console.WriteLine(numero + " x 4 = " + numero * 4);
            Console.WriteLine(numero + " x 5 = " + numero * 5);
            Console.WriteLine(numero + " x 6 = " + numero * 6);
            Console.WriteLine(numero + " x 7 = " + numero * 7);
            Console.WriteLine(numero + " x 8 = " + numero * 8);
            Console.WriteLine(numero + " x 9 = " + numero * 9);
            Console.WriteLine(numero + " x 10 = " + numero * 10);

            Console.ReadLine();

        }
    }
}
