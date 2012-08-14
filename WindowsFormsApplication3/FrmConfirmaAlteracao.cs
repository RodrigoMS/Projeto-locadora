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

    public partial class FrmConfirmaAlteracao : Form
    {

        public bool ConfirmaAltera = false;
        Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();
        public FrmConfirmaAlteracao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string Satual = tb_SenhaAtual.Text;

            string sql = "SELECT id_user FROM usuario WHERE senha = "+Satual+" AND id_user = 1";

            try
            {
                obj.conectar();
                SqlCommand cmd = new SqlCommand(sql, obj.objCon);

                SqlDataReader objLeitura = cmd.ExecuteReader();

                while (objLeitura.Read())
                {
                    Satual = objLeitura["id_user"].ToString();
                    if (Satual == "1")
                    {
                        ConfirmaAltera = true;
                        this.Dispose();
                    }
                }

                obj.desconectar();



                if (!(ConfirmaAltera))
                {
                    MessageBox.Show("Senha Incorreta Tente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_SenhaAtual.Text = string.Empty;
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Senha Incorreta Tente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_SenhaAtual.Text = string.Empty;
            }
        }
    }
}
