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
    public partial class FmUsuario : Form
    {
        private Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();
      
        private string cmdsql;
        public FmUsuario()
        {
            InitializeComponent();
        }

        private void FmUsuario_Load(object sender, EventArgs e)
        {
            obj.conectar();
            SqlCommand cmd = new SqlCommand("SELECT usuario FROM usuario WHERE id_user = 1", obj.objCon);

            SqlDataReader objLeitura = cmd.ExecuteReader();

            while (objLeitura.Read())
            {
                LbnomeAdm.Text = objLeitura["usuario"].ToString().ToUpper();

            }

            obj.desconectar();
            string[] vetor = new string[9];
            char [] matriz = new char[9];
            matriz[0] = 'a';
            matriz[1] = 'v';
            matriz[2] = 'r';
            matriz[3] = 'd';
            matriz[4] = 't';
            matriz[5] = 'c';
            matriz[6] = 'm';
            matriz[7] = 'f';
            matriz[8] = 'o';

            obj.conectar();
            int cont = 0;
        laco:
            string sql = "SELECT COUNT(*) FROM FILME WHERE GENERO = '"+matriz[cont]+"' ";
            SqlCommand cmd2 = new SqlCommand(sql, obj.objCon);

             int x = (int)cmd2.ExecuteScalar();
             vetor[cont] = x.ToString();

             ++cont; if(cont == 9) goto endlaco;
                goto laco;
            endlaco:
           
    
             sql = "SELECT COUNT(*) FROM FILME";
            SqlCommand cmd3 = new SqlCommand(sql, obj.objCon);

             x = (int)cmd3.ExecuteScalar();
             lb_total.Text = x.ToString();
             
             sql = "SELECT COUNT(*) FROM CLIENTE";
             SqlCommand cmd4 = new SqlCommand(sql, obj.objCon);

             x = (int)cmd4.ExecuteScalar();
             lb_qtddeclientes.Text = x.ToString();
             sql = "SELECT COUNT(*) FROM usuario";
             SqlCommand cmd5 = new SqlCommand(sql, obj.objCon);

             x = (int)cmd5.ExecuteScalar();
             lb_qtdfuncionários.Text = (x - 1).ToString();
             sql = "SELECT COUNT(*) FROM Locar_Devolver";
             SqlCommand cmd6 = new SqlCommand(sql, obj.objCon);

             x = (int)cmd6.ExecuteScalar();
             lb_locados.Text = x.ToString();

             sql = "SELECT COUNT(*) FROM Locar_Devolver WHERE QtdDias > 3";
             SqlCommand cmd7 = new SqlCommand(sql, obj.objCon);

             x = (int)cmd7.ExecuteScalar();
             lb_atrazados.Text = x.ToString();

             obj.desconectar();


               
            lb_acao.Text = vetor[0];
            lb_aventura.Text  = vetor[1];
            lbRomance.Text = vetor[2];
            lb_drama.Text = vetor[3];
            lb_terror.Text = vetor[4];
            lb_comedia.Text   = vetor[5];
            lb_documentario.Text= vetor[6];
            lb_ficcao.Text = vetor[7];
            lb_outros.Text = vetor[8];

            timer1_Tick(e, e);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime HoraData = DateTime.Now;

            tbDateTime.Text = "Data: " + HoraData.ToShortDateString() + " Hora: " + HoraData.ToLongTimeString();

        }

        private void tbDateTime_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LimpaTextBox();
        }

        private void bt_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                string nomeUser, senhaUser, strSql;

                
                nomeUser = tbLoginCad.Text;
                senhaUser = tb_SenhaCad.Text;



                if (tb_SenhaCad.Text == tb_confirmaSenha.Text && nomeUser != "")
                {
                    strSql = "INSERT INTO usuario VALUES('" + nomeUser + "','" + senhaUser + "')";
                    obj.conectar();
                    SqlCommand cmd = new SqlCommand(strSql,obj.objCon);
                    

                    cmd.ExecuteNonQuery();

                    obj.desconectar();

                    MessageBox.Show("Novo Login :  "+nomeUser+"\n\nCADASTRADO COM SUCESSO"," Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    LimpaTextBox();
                }
                else
                {
                    MessageBox.Show("DADOS INVÁLIDO TENTE NOVAMENTE", "ERRO");
                    LimpaTextBox();
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("ERRO AO CONECTAR AO BANCO ", "ERRO");
            }
        }

        public void LimpaTextBox()
        {
            tbLoginCad.Text = null;
            tb_confirmaSenha.Text = string.Empty;
            tb_SenhaCad.Text = string.Empty;
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {
            tabControl1_Enter(e, e);
        }

        private void bt_excluirUser_Click(object sender, EventArgs e)
        {

            int cod;

            try
            {
                try
                {

                    cod = int.Parse(tb_excluirUser.Text);
                    if (cod != 1)
                    {
                        cmdsql = "DELETE FROM usuario WHERE id_user = " + cod;
                        obj.conectar();
                        SqlCommand cmd = new SqlCommand(cmdsql, obj.objCon);
                       
                        cmd.ExecuteNonQuery();
                        obj.desconectar();
                        MessageBox.Show("USUÁRIO EXCLUIDO COM SUCESSO", "Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        tb_excluirUser.Text = null;
                        label2.Text = null;
                        tabControl1_Enter(e, e);
                    }
                    else
                    {
                        MessageBox.Show("CÓDIGO DE IDENTIFICAÇÃO INVÁLIDA", "ERRO",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        tabControl1_Enter(e, e);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("CÓDIGO DE IDENTIFICAÇÃO INVÁLIDA", "ERRO");
                }

            }
            catch (SqlException)
            {

                MessageBox.Show("ERRO AO CONECTAR AO BANCO", "ERRO");
            }

        }

        private void tabControl1_Enter(object sender, EventArgs e)
        {
            dg_Excluir.DataSource = ListUsuario();
        }
        public DataTable ListUsuario()
        {
            cmdsql = "SELECT [id_user] AS CÓDIGO,[usuario] AS USUÁRIO,[senha] AS SENHA FROM usuario WHERE id_user > 1";
            SqlConnection conn = new SqlConnection();


            try
            {
                obj.conectar();
                SqlCommand cmd = new SqlCommand(cmdsql, obj.objCon);

                SqlDataAdapter sdt = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                sdt.Fill(dt);

                return dt;

            }
            catch (SqlException ee)
            {
                return null;
                throw ee;
            }
            finally
            {
                obj.desconectar();

            }
        }
        #region Botões Retornar
        private void Retornar_Click(object sender, EventArgs e)
        {
            this.Close();
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
        #endregion
        private void Salvar_Click(object sender, EventArgs e)
        {
            FrmConfirmaAlteracao CONFIRMA = new FrmConfirmaAlteracao();
            string
                   Snova = tb_novaSenha.Text,
                   Cnova = tb_confirmaSenha.Text,
                   Adm = tb_novoNome.Text;
                   

            if ((Snova != cmdsql) && (Adm != ""))
            {
                CONFIRMA.ShowDialog();
                if (CONFIRMA.ConfirmaAltera)
                {
                    cmdsql = "UPDATE usuario SET usuario = '" + Adm + "', senha = '" + Snova + "' WHERE id_user = 1";
                    obj.conectar();

                    SqlCommand cmd = new SqlCommand(cmdsql,obj.objCon);

                    cmd.ExecuteNonQuery();

                    obj.desconectar();
                    MessageBox.Show("Usuário Alterado com sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Verifique os Campos\nE tente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

       

    }
}
