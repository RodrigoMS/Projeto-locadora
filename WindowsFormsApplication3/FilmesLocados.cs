using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApplication3
{
    public partial class FilmesLocados : Form
    {
        public FilmesLocados()
        {
            InitializeComponent();
        }
        Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();

        private void FilmesLocados_Load(object sender, EventArgs e)
        {
            string valor = null;
            

            dg_locados.DataSource = obj.ListaLocados(valor);
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            dgAtrazo.DataSource = obj.ListaAtrazos();
        }

        private void Bt_pesqCliente_Click(object sender, EventArgs e)
        {
            string sql;
            sql = "SELECT [id_filme] AS CÓDIGO,[NomeFilme] AS TÍTULO,[id_cliente] AS FICHA,[NomeCliente] AS CLIENTE,[telefone] AS TELEFONE, [DataHora] AS DATA_E_HORA FROM Locar_Devolver WHERE nomefilme LIKE @VALOR ORDER BY NomeCliente"; 
            dg_locados.DataSource = obj.Pesquisar(sql, "%" + tb_locados.Text + "%");

            
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            VerificaData();
        }
        private bool erro;
        public string ArrumaData()
        {
            
            string datacerta = tb_historico.Text;
            string total;
            char[] resto = new char[5];

            string data = tb_historico.Text;

            char a = '0', b = '0', c = '0', d = '0', e = '0';

            char neutro;
            try
            {
                for (int i = 0; i <= 9; ++i)
                {
                    neutro = data[i];

                    if (i == 0) a = neutro;
                    else if (i == 1) b = neutro;
                    else if (i == 2) c = neutro;
                    else if (i == 3) d = neutro;
                    else if (i == 4) e = neutro;
                    if (i > 4) resto[i - 5] = neutro;

                }



                if (d == '0' && a != '0')
                {
                    total = Convert.ToString(a);
                    total += Convert.ToString(b);
                    total += Convert.ToString(c);
                    total += Convert.ToString(e);
                    total += Convert.ToString(resto[0]);
                    total += Convert.ToString(resto[1]);
                    total += Convert.ToString(resto[2]);
                    total += Convert.ToString(resto[3]);
                    total += Convert.ToString(resto[4]);
                    datacerta = total;

                }
                else if (a == '0' && d == '0')
                {

                    total = Convert.ToString(b);
                    total += Convert.ToString(c);
                    total += Convert.ToString(e);
                    total += Convert.ToString(resto[0]);
                    total += Convert.ToString(resto[1]);
                    total += Convert.ToString(resto[2]);
                    total += Convert.ToString(resto[3]);
                    total += Convert.ToString(resto[4]);
                    datacerta = total;

                }
                else if (a == '0' && d != '0')
                {
                    total = Convert.ToString(b);
                    total += Convert.ToString(c);
                    total += Convert.ToString(d);
                    total += Convert.ToString(e);
                    total += Convert.ToString(resto[0]);
                    total += Convert.ToString(resto[1]);
                    total += Convert.ToString(resto[2]);
                    total += Convert.ToString(resto[3]);
                    total += Convert.ToString(resto[4]);
                    datacerta = total;
                }
                erro = true;
                return datacerta;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro Verifique O campo e tente Novamente", " erro ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                erro=false;
                return null;
            }
        }

        public void VerificaData()
        {
            ArrumaData();
            string SQL;
            if(erro)
            {
                SQL = "SELECT [id_filme] AS CÓDIGO,[NomeFilme] AS TÍTULO,[Retirada] AS RETIRADA, [Atendente_R] AS ATENDENTE_R, [DEVOLUCAO] AS DEVOLUÇÃO, [Atendente_D] AS ATENDENTE_D, [id_cliente] AS FICHA FROM HISTORICO WHERE (DEVOLUCAO LIKE @Pesq OR DEVOLUCAO LIKE @Pesq2) or (RETIRADA LIKE @Pesq OR RETIRADA LIKE @Pesq2)";
                dg_historicoRelatorio.DataSource = obj.ListaHistoricoDevolidos(SQL, "%" + ArrumaData() + "%", "%" + tb_historico.Text + "%");

                SQL = "SELECT [id_filme] AS CÓDIGO,[NomeFilme] AS TÍTULO,[DataHora] AS RETIRADA,[id_cliente] AS FICHA,[Atendente_L] AS ATENDENTE_R FROM Locar_Devolver WHERE DataHora LIKE @Pesq OR DataHora LIKE @Pesq2";
                dg_filmesRetirados.DataSource = obj.ListaHistoricoDevolidos(SQL, "%" + ArrumaData() + "%", "%" + tb_historico.Text + "%");
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();
            int j = 0;
            obj.conectar();

            string sql2 = "SELECT COUNT(*) FROM HISTORICO WHERE (DEVOLUCAO LIKE '%" + ArrumaData() + "%') OR (RETIRADA LIKE '%" + tb_historico.Text + "%')";
            SqlCommand cmd2 = new SqlCommand(sql2, obj.objCon);

            j = (int)cmd2.ExecuteScalar();

            obj.desconectar();


            obj.conectar();
            string sql = "SELECT ID_FILME, NOMEFILME,RETIRADA,ATENDENTE_R,DEVOLUCAO,ATENDENTE_D,ID_CLIENTE  FROM HISTORICO WHERE (DEVOLUCAO LIKE '%" + ArrumaData() + "%') OR (RETIRADA LIKE '%" + tb_historico.Text + "%')";

            SqlCommand cmd = new SqlCommand(sql, obj.objCon);


            SqlDataReader LEDADOS = cmd.ExecuteReader();


            string[] dados = new string[j];

            for (int i = 0; LEDADOS.Read(); ++i)
            {
                dados[i] = LEDADOS["id_filme"].ToString();
                if (dados[i].Length < 5)
                {
                    int f = dados[i].Length;
                    while (f <= 5)
                    {
                        if (f == 4) dados[i] += "|";
                        else
                        dados[i] += " ";
                        
                        ++f;
                    }
                }

                dados[i] += LEDADOS["Nomefilme"].ToString();
                if(dados[i].Length < 30)
                {
                    int f = dados[i].Length;
                    while(f <= 30)
                    {
                        if (f == 30) dados[i] += "|";
                        else
                         dados[i] += " ";
                        ++f;
                    }
                }
                dados[i] += LEDADOS["retirada"].ToString();
                if (dados[i].Length <= 62)
                {
                    int f = dados[i].Length;
                    while (f <= 62)
                    {
                        if (f == 62) dados[i] += "|";
                        else
                        dados[i] += " ";
                        
                        ++f;
                    }
                }
                dados[i] += LEDADOS["Atendente_R"].ToString();
                if (dados[i].Length <= 72)
                {
                    int f = dados[i].Length;
                    while (f <= 72)
                    {
                        if (f == 72) dados[i] += "|";
                        else
                            dados[i] += " ";

                        ++f;
                    }
                }
                dados[i] += LEDADOS["devolucao"].ToString();
                if (dados[i].Length <= 104)
                {
                    int f = dados[i].Length;
                    while (f <= 104)
                    {
                        if (f == 104) dados[i] += "|";
                        else
                            dados[i] += " ";

                        ++f;
                    }
                }
                dados[i] += LEDADOS["Atendente_D"].ToString();
                if (dados[i].Length <= 113)
                {
                    int f = dados[i].Length;
                    while (f <= 113)
                    {
                        if (f == 113) dados[i] += "|";
                        else
                            dados[i] += " ";
                        ++f;
                    }
                }
                dados[i] += LEDADOS["id_cliente"].ToString();
                if (dados[i].Length <= 119)
                {
                    int f = dados[i].Length;
                    while (f <=119)
                    {
                        if (f == 119) dados[i] += "|";
                        else
                        dados[i] += " ";
                        
                        ++f;
                    }
                }

            }

            obj.desconectar();

            

            string cabecalho = "________________________________________________________________________________________________________________________";
            string cabecalho2 = "    |                         |                               |         |                               |        |     |";
            string cabecalho3 = "COD |         TITULO          |          HORA RETIRADA        |  ATE_R  |          HORA DEVOUÇÃO        | ATE_D  |FICHA|";
            string cabecalho4 = "____|_________________________|_______________________________|_________|_______________________________|________|_____|";

            StreamWriter relatorio = new StreamWriter(@"C:\Users\Diego_Germano\Desktop\" + dataModificada() + ".txt");
            relatorio.WriteLine("Reletório do dia " + tb_historico.Text);
            relatorio.WriteLine(cabecalho);
            relatorio.WriteLine(cabecalho2);
            relatorio.WriteLine(cabecalho3);
            relatorio.WriteLine(cabecalho4);
            for (int i = 0; i < j; ++i)
            {
                relatorio.WriteLine(dados[i]);
            }
            relatorio.WriteLine(cabecalho4);
            relatorio.Close();
            MessageBox.Show("Arquivo Gerado Com sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public string dataModificada()
        {
            string datacerta = tb_historico.Text;
            string total;
            char[] resto = new char[5];

            string data = tb_historico.Text;

            char a = '0', b = '0', c = '0', d = '0', e = '0';

            char neutro;

            for (int i = 0; i <= 9; ++i)
            {
                neutro = data[i];

                if (i == 0) a = neutro;
                else if (i == 1) b = neutro;
                else if (i == 2) c = neutro;
                else if (i == 3) d = neutro;
                else if (i == 4) e = neutro;
                if (i > 4) resto[i - 5] = neutro;

            }


            if (d == '0' && a != '0')
            {
                total = Convert.ToString(a);
                total += Convert.ToString(b);
                total += "_";
                total += Convert.ToString(e);
                total += "_";
                total += Convert.ToString(resto[1]);
                total += Convert.ToString(resto[2]);
                total += Convert.ToString(resto[3]);
                total += Convert.ToString(resto[4]);
                datacerta = total;

            }
            else if (a == '0' && d == '0')
            {

                total = Convert.ToString(b);
                total += "_";
                total += Convert.ToString(e);
                total += "_";
                total += Convert.ToString(resto[1]);
                total += Convert.ToString(resto[2]);
                total += Convert.ToString(resto[3]);
                total += Convert.ToString(resto[4]);
                datacerta = total;

            }
            else if (a == '0' && d != '0')
            {
                total = Convert.ToString(b);
                total += "_";
                total += Convert.ToString(d);
                total += Convert.ToString(e);
                total += "_";
                total += Convert.ToString(resto[1]);
                total += Convert.ToString(resto[2]);
                total += Convert.ToString(resto[3]);
                total += Convert.ToString(resto[4]);
                datacerta = total;
            }
            return datacerta;
        }
    }
}
 