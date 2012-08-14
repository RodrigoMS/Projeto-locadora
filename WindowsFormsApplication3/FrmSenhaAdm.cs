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
    public partial class frmSenhaAdm : Form
    {

        private string strSql = string.Empty;
        
        public bool Senhalogado = false;

        public frmSenhaAdm()
        {
            InitializeComponent();
        }

        public void bt_senhaAdm_Click(object sender, EventArgs e)
        {
            Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();
            string senha;
            WindowsFormsApplication3.FmUsuario FmrUsuario = new WindowsFormsApplication3.FmUsuario();
            
            
            senha = tb_senhaAdm.Text;
            try
            {
                strSql = "SELECT id_user FROM usuario WHERE SENHA = @SENHA";



                obj.conectar();
                SqlCommand cmd = new SqlCommand(strSql, obj.objCon);

                cmd.Parameters.Add("@SENHA", SqlDbType.VarChar).Value = senha;

             

                SqlDataReader objLeitura = cmd.ExecuteReader();

                while (objLeitura.Read())
                {
                    label1.Visible = false;
                    label1.Text += objLeitura["id_user"];
                    if (label1.Text == "1")
                    {
                        Senhalogado = true;
                        this.Dispose();
                    }
                }

                obj.desconectar();
        
            }
            catch(SqlException)
            {
                MessageBox.Show(" ERRO AO CONECTAR AO BANCO DE DADO", "ERRO");
            }

            if (Senhalogado == false)
            {
                label1.Text = string.Empty;
                tb_senhaAdm.Text = string.Empty;
                MessageBox.Show("VERIFIQUE A SENHA", "ERRO");
                Senhalogado = false;
                
            }

        }

        public void bt_CancelSenhaAdm_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void tb_senhaAdm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bt_senhaAdm_Click(e,e);
            }
        }
    }
}
