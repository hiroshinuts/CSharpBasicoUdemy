using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_finally
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.Write("Digite um numero..:");
            numero = int.Parse(Console.ReadLine());

            try
            {

                for (int i = 1; i < 11; i++)
                {
                    Console.WriteLine(numero + " x " + i + " = " + (numero * i));
                }

            }
            catch (Exception erro_ocorreu)
            {
                Console.WriteLine("Voce deve digitar um numero, erro = " + erro_ocorreu.Message);
            }
            finally
            {
                Console.WriteLine("Aperte Qualquer Tecla");
                Console.ReadLine();
            }



        }
    }
}
