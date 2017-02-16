using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_simples_numerico_soma_media
{
    class Program
    {
        static void Main(string[] args)
        {

            double[] notas = new double[5];
            notas[0] = 6;
            notas[1] = 8;
            notas[2] = 7;
            notas[3] = 9;
            notas[4] = 6;
            //Pode fazer assim : double[] notas = {6,8,7,9,6};


            double soma = notas[0] + notas[1] + notas[2] + notas[3] + notas[4];
            double media = soma / 5;
            Console.WriteLine("A soma é " + soma);
            Console.WriteLine("A media é " + media);

            double soma2 = notas.Sum();
            double media2 = notas.Average();

            Console.WriteLine("A soma é " + soma2);
            Console.WriteLine("A media é " + media2);

            Console.ReadKey();

        }
    }
}
