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
    public partial class DevolverFilme : Form
    {
        public DevolverFilme()
        {
            InitializeComponent();
        }
        Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();
        private int x;

        public bool pegar(string n)
        {
            try
            {
                x = int.Parse(n);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campos preenchidos\n incorretamente\ntente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void DevolverFilme_Load(object sender, EventArgs e)
        {
            

            string SQL;

            SQL = "SELECT [FICHA], [NOME], [CPF], [TELEFONE] FROM CLIENTE WHERE [FICHA] = " + x;


            obj.conectar();

            SqlCommand cmd = new SqlCommand(SQL, obj.objCon);


            SqlDataReader ledados = cmd.ExecuteReader();


            for (int i = 0; ledados.Read(); ++i)
            {
                lb_ficha.Text += (ledados["FICHA"]).ToString();
                lb_nome.Text = (ledados["NOME"]).ToString();
                lb_cpf.Text += (ledados["CPF"]).ToString();
                lb_tel.Text += (ledados["TELEFONE"]).ToString();
            }
            obj.desconectar();
            dgPesqLocadosD.DataSource = obj.ListaLocados(x.ToString());

        }

        private void bt_Devolver_Click(object sender, EventArgs e)
        {
            Locadora_2.Locadora_Principal DH = new Locadora_2.Locadora_Principal();
            string datahora;

            try
            {
                int g = int.Parse(tb_codfilmeD.Text);
               
                datahora = DH.DH();
                DH.timer1_Tick(datahora, e);
                datahora = DH.DH();
                if (obj.DevolverLocados(tb_codfilmeD.Text, x, datahora))
                {
                    MessageBox.Show("Filme devolvido com sucesso", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgPesqLocadosD.DataSource = obj.ListaLocados(x.ToString());
                    tb_codfilmeD.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Erro ao devolver verifique os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao devolver verifique os campos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
