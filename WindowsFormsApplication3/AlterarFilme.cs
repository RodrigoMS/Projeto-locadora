using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public partial class AlterarFilme : Form
    {
        private Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();

        private string cmdSql = string.Empty;

        public int x;

        public AlterarFilme()
        {
            InitializeComponent();
        }

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

        public void BtAlterar_Click(object sender, EventArgs e)
        {

            try
            {
                int tb7 = int.Parse(tb_7altera.Text);
                int tb6 = int.Parse(tb_6altera.Text);
               
                ArrayList arr = new ArrayList();

                arr.Add(tb_1altera.Text);
                arr.Add(tb_2altera.Text);
                arr.Add(tb_3altera.Text);
                arr.Add(tb_4altera.Text);
                arr.Add(comboBox1.Text);
                arr.Add(tb6);
                arr.Add(tb7);
                arr.Add(x);

                if (obj.UpdateFilme(arr))
                {
                    MessageBox.Show("Filme Alterado Com sucesso", " Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    
                }
                else
                {
                    MessageBox.Show("Campos Preenchidos\n Incorretamente\nTente Novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Campos Preenchidos\n Incorretamente\nTente Novamente", "Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void limpaTextbox()
        {
            tb_1altera.Text = string.Empty;
            tb_2altera.Text = string.Empty;
            tb_3altera.Text = string.Empty;
            tb_4altera.Text = string.Empty;
            comboBox1.Text = string.Empty;
            tb_6altera.Text = string.Empty;
            tb_7altera.Text = string.Empty;
        }

        private void AlterarFilme_Load(object sender, EventArgs e)
        {
            AlteraFilme();
        }

        public bool AlteraFilme()
        {
     
            cmdSql = "SELECT * FROM Filme WHERE id_filme = " + x;

            
            try
            {
                obj.conectar();

                SqlCommand cmd = new SqlCommand(cmdSql, obj.objCon);

                SqlDataReader ledados = cmd.ExecuteReader();

                for (int i = 0; ledados.Read(); ++i)
                {
                    tb_1altera.Text = ledados["titulo"].ToString();
                    tb_2altera.Text = ledados["subtitulo"].ToString();
                    tb_3altera.Text = ledados["anoprod"].ToString();
                    tb_4altera.Text = ledados["produtora"].ToString();
                    comboBox1.Text = ledados["genero"].ToString();
                    tb_6altera.Text = ledados["duracao"].ToString();
                    tb_7altera.Text = ledados["quantidade"].ToString();
               
                }


                obj.desconectar();

                return true;

            }
            catch
            (SqlException xx)
            {
                return false;
                throw xx;
            }

        }

 

        private void btCancelarAltera_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AlterarFilme_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
                       tb_1altera.Text != string.Empty ||
                       tb_2altera.Text != string.Empty ||
                       tb_3altera.Text != string.Empty ||
                       tb_4altera.Text != string.Empty ||
                       comboBox1.Text != string.Empty ||
                       tb_6altera.Text != string.Empty ||
                       tb_7altera.Text != string.Empty
                    )
            {
                if (MessageBox.Show("A alguns Campos Preenchidos\n Deseja Realmente Fechar o Formulario?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                
            }
            else
            {
                Dispose();
            }
        }

       
    }
}
