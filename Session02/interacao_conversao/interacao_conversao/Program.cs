using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interacao_conversao
{
    class Program
    {
        static void Main(string[] args)
        {

            string nome;

            Console.WriteLine("Digite o Nome : ");
            nome = Console.ReadLine();

            Console.WriteLine("O nome digitado foi " + nome);


            double num1, num2;

            Console.WriteLine("Digite o Primeiro numero ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o Segundo numero ");
            num2 = double.Parse(Console.ReadLine());

            double somatorio = num1 + num2;
            double subtracao = num1 - num2;
            double divisao = num1 / num2;
            double multiplicacao = num1 * num2;
            double media = somatorio / 2;

            Console.WriteLine("Soma " + somatorio);
            Console.WriteLine("Subtracao " + subtracao);
            Console.WriteLine("Divisao " + divisao);
            Console.WriteLine("Multiplicacao " + multiplicacao);
            Console.WriteLine("Media " + media);

            Console.ReadKey();

           

        }
    }
}
