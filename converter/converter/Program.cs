using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace converter
{
    class Program
    {
        static void Main(string[] args)
        {

            string nomeh, idadeh, salarioh, nomem, idadem, salariom ;

            Console.WriteLine("Digite o Nome dele : ");
            nomeh = Console.ReadLine();
                       
            Console.WriteLine("Quanto o " + nomeh + " ganha?" );
            salarioh = Console.ReadLine();

            Console.WriteLine("idade do " + nomeh);
            idadeh = Console.ReadLine();

            Console.WriteLine("Digite o Nome dela : ");
            nomem = Console.ReadLine();

            Console.WriteLine("Quanto o " + nomem + " ganha?");
            salariom = Console.ReadLine();

            Console.WriteLine("idade do " + nomem);
            idadem = Console.ReadLine();

            //double somasalario = double.Parse(salarioh) +  double.Parse(salariom);
            //int somaIdade = int.Parse(idadeh) + int.Parse(idadem);
            //OU PODE CONVERTER DA MANEIRA ABAIXO

            double somasalario = Convert.ToDouble(salarioh) + Convert.ToDouble(salariom);
            int somaIdade = Convert.ToInt16(idadeh) + Convert.ToInt16(idadem);

            Console.WriteLine("A soma dos salarios é " + somasalario  );
            Console.WriteLine("A soma das idades é " + somaIdade);


            Console.ReadKey();

        }
    }
}
