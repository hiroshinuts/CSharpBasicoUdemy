using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_bidimensional
{
    class Program
    {
        static void Main(string[] args)
        {

            double[,] aluno_nota = new double[3, 3];

            aluno_nota[0, 0] = 8;
            aluno_nota[0, 1] = 6;
            aluno_nota[0, 2] = 4;

            aluno_nota[1, 0] = 4;
            aluno_nota[1, 1] = 7;
            aluno_nota[1, 2] = 8;

            aluno_nota[2, 0] = 3;
            aluno_nota[2, 1] = 8;
            aluno_nota[2, 2] = 1;

            for(int aluno = 0; aluno < 3; aluno++)
            {
                for(int nota= 0; nota < 3; nota++)
                {
                    Console.WriteLine("Arrays Matriz aluno_nota[" + aluno + " , " + nota + "] = " + aluno_nota[aluno, nota]);
                }
            }
            Console.ReadKey();
        }
    }
}
