using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace operadores
{
    class Program
    {
        static void Main(string[] args)
        {
           
            string nome = "Neri";
            double salario = 850.50;
            double salario_informaticon = 950.50;
            double soma = salario + salario_informaticon;

            Console.WriteLine("Nome = " + nome + "ganha R$ " + soma);


            double num1, num2;
            num1 = 10;
            num2 = 5;

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
