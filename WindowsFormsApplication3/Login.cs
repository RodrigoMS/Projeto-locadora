using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_Locadora
{
    public partial class Login : Form
    {
        private string strSql = string.Empty;
        public  bool logado = false;
        public string user;

        Locadora_2.Locadora_Principal FRM = new Locadora_2.Locadora_Principal();
 
        public Login()
        {
            
            InitializeComponent();
           
        }

        public void logar()
            {
            Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();
            
            string  pwd;

            try
            {
                
                user = tb_Usuario.Text;
                pwd = tb_senha.Text;

                strSql = "SELECT COUNT(id_user) FROM usuario WHERE USUARIO = @USUARIO AND SENHA = @SENHA";

                obj.conectar();

                SqlCommand cmd = new SqlCommand(strSql, obj.objCon);

                cmd.Parameters.Add("@USUARIO",SqlDbType.VarChar).Value = user;
                cmd.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = pwd;
               
                int v = (int)cmd.ExecuteScalar();
                obj.desconectar();
                if (v > 0)
                {
                    string sql = "UPDATE ATENDENTE SET usuario ='" + user.ToUpper() + "'   WHERE id_Atendente = 1";

                    obj.conectar();

                    SqlCommand cmd2 = new SqlCommand(sql, obj.objCon);

                    cmd2.ExecuteNonQuery();

                    obj.desconectar();
                 
                    logado = true;     
                    this.Dispose();
                  
                }
                else
                {
                    MessageBox.Show("ERRO AO LOGAR VERIFIQUE A SENHA");
                    logado = false;
                }

                

            }
            catch (SqlException)
            {

                Console.WriteLine("ERRO  AO  CONECTAR AO BANCO !!!");
            }
            
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            logar();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            Locadora_2.Locadora_Principal Fim = new Locadora_2.Locadora_Principal();
            Fim.button1_Click(e,e);
        }

        private void tb_senha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                logar();
            }
        }
    }
}
