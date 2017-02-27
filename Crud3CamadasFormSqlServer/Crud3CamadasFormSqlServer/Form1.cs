using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crud3CamadasFormSqlServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            povoa_grade();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pesquisa = tb_pesquisa.Text;
            bairroModel obj_bairro = new bairroModel();
           
            try
            {
                bairroBLL bairrobll = new bairroBLL();
                obj_bairro = bairrobll.pesquisaBairroDal(pesquisa);
                tb_codigo.Text = obj_bairro.Codigo.ToString();
                tb_descricao.Text = obj_bairro.Nome.ToString();
                MessageBox.Show("Procurando...");
                povoa_grade();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na pesquisa de bairros " + erro);
            }
        }

        public void povoa_grade()
        {
            try
            {
                bairroBLL bairrobll = new bairroBLL();
                grade_bairros.DataSource = bairrobll.lista_bairros_dal();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na listagem de bairros " + erro);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bairroModel obj_bairro = new bairroModel();
            obj_bairro.Codigo = Convert.ToInt32(tb_codigo.Text);
            obj_bairro.Nome = tb_descricao.Text;

            try
            {
                bairroBLL bairrobll = new bairroBLL();
                bairrobll.gravaBairroDal(obj_bairro);
                MessageBox.Show("Bairro adicionado com sucesso!");
                povoa_grade();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na gravacao de bairros " + erro);
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bairroModel obj_bairro = new bairroModel();
            obj_bairro.Codigo = Convert.ToInt32(tb_codigo.Text);
            
            try
            {
                bairroBLL bairrobll = new bairroBLL();
                bairrobll.excluiBairroDal(obj_bairro);
                MessageBox.Show("Bairro excluido com sucesso!");
                povoa_grade();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na exclusao de bairros " + erro);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            bairroModel obj_bairro = new bairroModel();
            obj_bairro.Codigo = Convert.ToInt32(tb_codigo.Text);
            obj_bairro.Nome = tb_descricao.Text;

            try
            {
                bairroBLL bairrobll = new bairroBLL();
                bairrobll.atualizaBairroDal(obj_bairro);
                MessageBox.Show("Bairro atualizado com sucesso!");
                povoa_grade();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na gravacao de bairros " + erro);
            }
            
        }

    }
}
