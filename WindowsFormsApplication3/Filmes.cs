using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace Locadora_2
{
    public partial class Filmes : Form
    {
        private GerenteBancoDados obj = new GerenteBancoDados();
        private bool EntradaNumeros=true;
        

        public Filmes()
        {
            InitializeComponent();
        }

        private void BotãoSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        { 

            string nome = tb_titulo.Text;
            string subnoome = tb_subtitulo.Text;
            string genero = comboBox1.Text;
            string ano = tb_anoprod.Text;
            string produtora = tb_produtora.Text;
            int duracao=0;
            int qtd=0;
            try
            {
                 duracao = int.Parse(tb_duracao.Text);
                 qtd = int.Parse(tb_Quantidade.Text);
            }
            catch(Exception)
            {
                EntradaNumeros = false;
                MessageBox.Show("Campos Preenchidos\n Incorretamente\nTente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                
            }

            string strSql;
          

            if (this.ValidaEntrada())
            {
                try
                {
                    strSql = "INSERT INTO filme VALUES('" + nome + "','" + subnoome + "','" + ano +
                             "','" + produtora + "','" + genero + "','" + duracao + "','"+qtd +"')";

                    obj.conectar();

                        SqlCommand cmd = new SqlCommand(strSql,obj.objCon);

                        cmd.ExecuteNonQuery();

                    obj.desconectar();

                    MessageBox.Show("Filme Cadastrado Com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.limpaTextbox();
                }
                catch (SqlException)
                {
                    MessageBox.Show("ERRO AO CONECTAR AO BANCO", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }     
        }

        private void limpaTextbox()
        {
            tb_titulo.Text = string.Empty;
            tb_subtitulo.Text = string.Empty;
            comboBox1.Text = string.Empty;
            tb_anoprod.Text = string.Empty;
            tb_produtora.Text = string.Empty;
            tb_duracao.Text = string.Empty;
            tb_Quantidade.Text = string.Empty;
        }

        private bool ValidaEntrada()
        {
            if (
                tb_titulo.Text != " " &&
                comboBox1.Text != " " &&
                tb_anoprod.Text != " " &&
                tb_produtora.Text != " "&&
                EntradaNumeros
               )
                return true;
                return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.limpaTextbox();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {      
            dgFilmes.DataSource = obj.ListGridFilme();       
        }

        private void Bt_Pesquisar_Click(object sender, EventArgs e)
        {    
            string sql;
         
            if(rb_nome.Checked)
            {
                sql = "SELECT [id_filme] AS CÓDIGO,[titulo] AS TÍTULO,[subtitulo] AS SUBTÍTULO," +
            "[anoprod] AS ANO_PRODUZIDO, [produtora] AS PRODUTORA,[genero] AS GENERO,[duracao]" +
            "AS DURAÇÃO,[quantidade] AS QUANTIDADE FROM Filme WHERE titulo LIKE @Pesq";

                dgFilmes.DataSource = obj.PesquisaFilme(sql, "%"+tb_VerPesquisa.Text+"%");
            }
            else
            {

                sql = "SELECT [id_filme] AS CÓDIGO,[titulo] AS TÍTULO,[subtitulo] AS SUBTÍTULO," +
           "[anoprod] AS ANO_PRODUZIDO, [produtora] AS PRODUTORA,[genero] AS GENERO,[duracao]" +
           "AS DURAÇÃO,[quantidade] AS QUANTIDADE FROM Filme WHERE genero LIKE @Pesq";

                dgFilmes.DataSource = obj.PesquisaFilme(sql, "%" + tb_VerPesquisa.Text + "%");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este filme?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int cod = 0;
                try
                {
                    cod = int.Parse(tbCodAltEx.Text);
                    if (obj.ExcluirFilme(cod))
                    {
                        MessageBox.Show("Filme Excluido Com Sucesso", " Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tabPage4_Enter(e, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Houve um erro\nVerifique os campos\nE tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public string CodAltera;
     
        public void button3_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.AlterarFilme aterar = new WindowsFormsApplication3.AlterarFilme();
       
            if (aterar.pegar(tbCodAltEx.Text))
            {
                aterar.ShowDialog();
            }
        }
  

        private void Retornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Filmes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
                 tb_titulo.Text != string.Empty ||
                 tb_subtitulo.Text != string.Empty ||
                 comboBox1.Text != string.Empty ||
                 tb_anoprod.Text != string.Empty ||
                 tb_produtora.Text != string.Empty ||
                 tb_duracao.Text != string.Empty ||
                 tb_Quantidade.Text != string.Empty
              )
            {
                if (MessageBox.Show("A alguns Campos Preenchido\n Deseja Realmente Fechar o Formulario?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }

            }
            else
            {
                this.Dispose();
            }
        }
    }
}
