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
    public partial class AlterarCliente : Form
    {
        Locadora_2.GerenteBancoDados obj = new Locadora_2.GerenteBancoDados();
        public int x;

        public AlterarCliente()
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
                return false;
            }
        }

        private void BtAlteraCliente_Click(object sender, EventArgs e)
        {
            bool verifica = false;
            if (tb_Bairro.Text != string.Empty && tb_Nome.Text != string.Empty &&
                tb_CEP.Text != string.Empty && Tb_Cidade.Text != string.Empty)
                verifica = true;
            try
            {

                string cidade,estado,Data;
                string cpf = tb_CPF.Text;

                Data = tb_Data_de_nacimento.Text;
                cidade = Tb_Cidade.Text;

                estado = Tb_Estado.Text;
           

                ArrayList arr = new ArrayList();


                arr.Add(cpf);
                arr.Add(tb_Nome.Text);
                arr.Add(Data);
                arr.Add(tb_Telefone.Text);
                arr.Add(tb_Logradouro.Text);
                arr.Add(tb_Numero.Text);
                arr.Add(tb_Bairro.Text);
                arr.Add(tb_CEP.Text);
                arr.Add(cidade);
                arr.Add(estado);
                arr.Add(x);
                

                if (verifica && obj.Update(arr))
                {
                    MessageBox.Show("Cliente alterado com sucesso", " Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Campos preenchidos\n Incorretamente\nTente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
               // limpaTextbox();
                MessageBox.Show("Campos preenchidos\n incorretamente\nTente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AlterarCliente_Load_1(object sender, EventArgs e)
        {

            if (!(Preencher()))
            {
                MessageBox.Show("Erro ao preencher campos","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
  
        }

        public bool Preencher()
        {
           

            string SQL;

            SQL = "SELECT * FROM CLIENTE WHERE FICHA = " + x;

            try
            {
                obj.conectar();

                SqlCommand cmd = new SqlCommand(SQL,obj.objCon);

                SqlDataReader ledados = cmd.ExecuteReader();
                
                
                for (int i = 0; ledados.Read(); ++i)
                {
                    tb_CPF.Text = ledados["CPF"].ToString();
                    tb_Nome.Text =ledados["NOME"].ToString();
                    tb_Data_de_nacimento.Text = ledados["DATA_DE_NASCIMENTO"].ToString();
                    tb_Telefone.Text=ledados["TELEFONE"].ToString();
                    tb_Logradouro.Text=ledados["LOGRADOURO"].ToString();
                    tb_Numero.Text=ledados["NUMERO"].ToString();
                    tb_Bairro.Text=ledados["BAIRRO"].ToString();
                    tb_CEP.Text=ledados["CEP"].ToString();
                    Tb_Cidade.Text=ledados["CIDADE"].ToString();
                    Tb_Estado.Text=ledados["ESTADO"].ToString();
                    
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

        private void BtCancelCliente_Click(object sender, EventArgs e)
        {
            tb_Bairro.Text = string.Empty;
            tb_CEP.Text = string.Empty;
            tb_Data_de_nacimento.Text = string.Empty;
            tb_Telefone.Text = string.Empty;
            tb_CEP.Text = string.Empty;
            tb_CPF.Text = string.Empty;
            Tb_Cidade.Text = string.Empty;
            tb_Data_de_nacimento.Text = string.Empty;
            Tb_Estado.Text = string.Empty;
            tb_Logradouro.Text = string.Empty;
            tb_Nome.Text = string.Empty;
            tb_Numero.Text = string.Empty;
            tb_Telefone.Text = string.Empty;
        }

        private void AlterarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {

            if (
                    tb_Bairro.Text != string.Empty ||
                    tb_CEP.Text != string.Empty ||
                    Tb_Cidade.Text != string.Empty ||
                    tb_Data_de_nacimento.Text != string.Empty ||
                    Tb_Estado.Text != string.Empty ||
                    tb_Logradouro.Text != string.Empty ||
                    tb_Nome.Text != string.Empty ||
                    tb_Numero.Text != string.Empty ||
                    tb_Telefone.Text != string.Empty
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

