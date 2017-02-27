using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Crud3CamadasFormSqlServer
{
    class bairroDAL
    {
        String conexao_sqlserver = @"Data Source=.\SQLEXPRESS;Initial Catalog=banco_aula;user id=sa;pwd=rhtrht;";
        SqlConnection conexao = null;

        public DataTable lista_bairros()
        {
            try
            {
                conexao = new SqlConnection(conexao_sqlserver);
                SqlCommand sql = new SqlCommand("select * from bairro", conexao);
                SqlDataAdapter daBairro = new SqlDataAdapter();
                daBairro.SelectCommand = sql;
                DataTable dtBairro = new DataTable();
                daBairro.Fill(dtBairro);

                return dtBairro;
            }
            catch(Exception erro){
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public void gravaBairro(bairroModel bairro)
        {
            try
            {

                conexao = new SqlConnection(conexao_sqlserver);
                SqlCommand sql = new SqlCommand("insert into bairro values (@codigo,@nome) ", conexao);
                sql.Parameters.AddWithValue("@codigo", bairro.Codigo);
                sql.Parameters.AddWithValue("@nome", bairro.Nome);
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }

        }

        public void excluiBairro(bairroModel bairro)
        {

            try
            {

                conexao = new SqlConnection(conexao_sqlserver);
                SqlCommand sql = new SqlCommand("delete from  bairro where bai_codigo = @codigo ", conexao);
                sql.Parameters.AddWithValue("@codigo", bairro.Codigo);
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }

        }

        public void atualizaBairro(bairroModel bairro)
        {
            try
            {

                conexao = new SqlConnection(conexao_sqlserver);
                SqlCommand sql = new SqlCommand("update bairro set bai_nome = @nome where bai_codigo= @codigo ", conexao);
                sql.Parameters.AddWithValue("@codigo", bairro.Codigo);
                sql.Parameters.AddWithValue("@nome", bairro.Nome);
                conexao.Open();
                sql.ExecuteNonQuery();
            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }
        }

        public bairroModel pesquisaBairro(string pesquisa)
        {
            try
            {

                conexao = new SqlConnection(conexao_sqlserver);
                SqlCommand sql = new SqlCommand("select * from bairro where bai_nome like '" + pesquisa + "%'", conexao);
                sql.Parameters.AddWithValue("@pesquisa", pesquisa);
                conexao.Open();
                SqlDataReader datareader;

                bairroModel obj_bairro = new bairroModel();
                datareader = sql.ExecuteReader(CommandBehavior.CloseConnection);
                while (datareader.Read())
                {
                    obj_bairro.Codigo = Convert.ToInt32(datareader["bai_codigo"]);
                    obj_bairro.Nome = datareader["bai_nome"].ToString();
                }
                return obj_bairro;

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                conexao.Close();
            }

        }

    }
}
