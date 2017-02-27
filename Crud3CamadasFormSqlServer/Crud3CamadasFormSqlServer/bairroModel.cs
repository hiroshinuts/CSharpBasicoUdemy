using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crud3CamadasFormSqlServer
{
    class bairroModel
    {
        int codigo;
        String nome;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }


    }
}
