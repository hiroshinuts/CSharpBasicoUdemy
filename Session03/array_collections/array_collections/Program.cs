using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace array_collections
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList dados_cliente = new ArrayList();
            dados_cliente.Add("Neri");
            dados_cliente.Add("Faggot");
            dados_cliente.Add(24);
            dados_cliente.Add(1.500);

            for(int i = 0; i < dados_cliente.Count; i++)
            {
                Console.WriteLine(dados_cliente[i]);
            }

            Console.ReadKey();

        }
    }
}
