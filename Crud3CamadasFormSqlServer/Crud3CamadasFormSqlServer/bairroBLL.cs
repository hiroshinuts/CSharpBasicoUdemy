using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Crud3CamadasFormSqlServer
{
    class bairroBLL
    {
        bairroDAL bairrodal = null;

        public DataTable lista_bairros_dal()
        {
            DataTable datatable = new DataTable();

            try
            {
                bairrodal = new bairroDAL();
                datatable = bairrodal.lista_bairros();
            }
            catch (Exception erro)
            {
                throw erro;
            }

            return datatable;

        }

        public void gravaBairroDal(bairroModel bairro)
        {
            try
            {
                bairrodal = new bairroDAL();
                bairrodal.gravaBairro(bairro);
            }
            catch (Exception erro)
            {
                throw erro;
            }

            
        }

        public void excluiBairroDal(bairroModel bairro)
        {
            try
            {
                bairrodal = new bairroDAL();
                bairrodal.excluiBairro(bairro);
            }
            catch (Exception erro)
            {
                throw erro;
            }


        }

        public void atualizaBairroDal(bairroModel bairro)
        {
            try
            {
                bairrodal = new bairroDAL();
                bairrodal.atualizaBairro(bairro);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }


        public bairroModel pesquisaBairroDal(string pesquisa)
        {
            try
            {
                bairrodal = new bairroDAL();
                return bairrodal.pesquisaBairro(pesquisa);
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
   

    }
}
