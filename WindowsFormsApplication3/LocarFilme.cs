using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class LocarFilme : Form
    {
        public LocarFilme()
        {
            InitializeComponent();
        }
        private Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();
        private int x;
        private string atendente;

        public bool pegar(string n)
        {
            try
            {
                x = int.Parse(n);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campos Preenchidos\n Incorretamente\nTente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }


        private void LocarFilme_Load(object sender, EventArgs e)
        {
            Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();

            string SQL;

            SQL = "SELECT [FICHA], [NOME], [CPF], [TELEFONE] FROM CLIENTE WHERE [FICHA] = "+x;


            obj.conectar();

            SqlCommand cmd = new SqlCommand(SQL, obj.objCon);


            SqlDataReader ledados = cmd.ExecuteReader();


            for (int i = 0; ledados.Read(); ++i)
            {
                lb_ficha.Text = (ledados["FICHA"]).ToString();
                lb_nome.Text = (ledados["NOME"]).ToString();
                lb_cpf.Text = (ledados["CPF"]).ToString();
                label6.Text = (ledados["TELEFONE"]).ToString();
                lb_fichaH.Text = (ledados["FICHA"]).ToString();
                lb_NomeH.Text = (ledados["NOME"]).ToString();
                lb_cpfH.Text = (ledados["CPF"]).ToString();
                lb_telH.Text = (ledados["TELEFONE"]).ToString();
            }
            obj.desconectar();
            dgPesqLocados.DataSource = obj.ListGridFilme();

            dg_historico.DataSource = obj.ListaHistórico(x.ToString());

        }

        private void bt_pesqLocados_Click(object sender, EventArgs e)
        {
            string SQL;
            if (rbNomeL.Checked)
            {
                SQL = "SELECT [id_filme] AS CÓDIGO,[titulo] AS TÍTULO,[subtitulo] AS SUBTÍTULO," +
             "[anoprod] AS ANO_PRODUZIDO, [produtora] AS PRODUTORA,[genero] AS GENERO,[duracao]" +
             "AS DURAÇÃO,[quantidade] AS QUANTIDADE FROM Filme WHERE titulo LIKE @VALOR ORDER BY TITULO";
                dgPesqLocados.DataSource = obj.Pesquisar(SQL, "%" + tb_pesqL.Text + "%");
            }
            else
            {
                SQL = "SELECT [id_filme] AS CÓDIGO,[titulo] AS TÍTULO,[subtitulo] AS SUBTÍTULO," +
               "[anoprod] AS ANO_PRODUZIDO, [produtora] AS PRODUTORA,[genero] AS GENERO,[duracao]" +
                "AS DURAÇÃO,[quantidade] AS QUANTIDADE FROM Filme WHERE id_filme = @VALOR ORDER BY TITULO";
                dgPesqLocados.DataSource = obj.Pesquisar(SQL, tb_pesqL.Text);
            }
        }

        private void bt_locar_Click(object sender, EventArgs e)
        {
            string sql;
            string qtd = null, NomeFilme = null;
            string NomeCliente = null, tel = null, datahora;

            sql = "SELECT quantidade,titulo FROM FILME WHERE id_filme = " + tb_codfilme.Text;
            obj.conectar();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, obj.objCon);

                SqlDataReader ledados = cmd.ExecuteReader();

                for (int i = 0; ledados.Read(); ++i)
                {
                    qtd = (ledados["QUANTIDADE"]).ToString();
                    NomeFilme = (ledados["titulo"]).ToString();

                }
                obj.desconectar();

                sql = "SELECT Nome,Telefone FROM CLIENTE WHERE  FICHA = " + x;
                obj.conectar();
              

                SqlCommand cmd2 = new SqlCommand(sql, obj.objCon);

                SqlDataReader ledados2 = cmd2.ExecuteReader();

                for (int i = 0; ledados2.Read(); ++i)
                {
                    NomeCliente = (ledados2["Nome"]).ToString();
                    tel = (ledados2["Telefone"]).ToString();

                }

                obj.desconectar();

                Funcionario();

                Locadora_2.Locadora_Principal DH = new Locadora_2.Locadora_Principal();

                datahora = DH.DH();
                DH.timer1_Tick(datahora, e);
                datahora = DH.DH();
                if (Convert.ToInt16(qtd) > 0)
                {
                    if (obj.InsertLocados(tb_codfilme.Text, x.ToString(), NomeFilme, NomeCliente, tel, datahora,atendente))
                    {
                        MessageBox.Show("Filme Locado Com Sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LocarFilme_Load(e,e);
                    }
                    else
                    {
                        MessageBox.Show("Erro Ao Locar Verifique os Campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Erro ao Locar Esse Filme\nNão esta disponivél", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Erro Ao Locar Verifique os Campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public string Funcionario()
        {
            string sql;
            sql = "SELECT usuario FROM ATENDENTE";

            obj.conectar();

            SqlCommand comando = new SqlCommand(sql,obj.objCon);

            SqlDataReader lerAtendente = comando.ExecuteReader();

            for (int i = 0; lerAtendente.Read(); ++i)
            {
                atendente = lerAtendente["usuario"].ToString();
            }
            obj.desconectar();
            return atendente;
        }

        private void Retornar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
