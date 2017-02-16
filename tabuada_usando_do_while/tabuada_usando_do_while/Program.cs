using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabuada_usando_do_while
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.Write("Digite um numero..:");
            numero = int.Parse(Console.ReadLine());

            int i = 1;
            do
            {
                Console.WriteLine(numero + " x " + 1 + " = " + (numero * i));
                i++;
            } while (i < 11);



            Console.ReadLine();

        }
    }
}
