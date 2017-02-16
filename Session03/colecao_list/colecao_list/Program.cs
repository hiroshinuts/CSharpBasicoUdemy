using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colecao_list
{
    class Program
    {
        static void Main(string[] args)
        {

            List<double> notas = new List<double>();
            notas.Add(8.5);
            notas.Add(7.2);
            notas.Add(6.7);
            notas.Add(9.2);

            Console.WriteLine(notas.Average());
            Console.WriteLine(notas.Min());
            Console.WriteLine(notas.Max());
            Console.ReadKey();

            List<string> nomes = new List<string>();
            nomes.Add("Neri");
            nomes.Add("Hiro");
            nomes.Add("Babara");

            for(int i = 0; i < nomes.Count; i++)
            {
                Console.WriteLine(nomes[i]);
            }
            

            Console.WriteLine(nomes.Count);
            Console.ReadKey();

        }
    }
}
