using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Locadora_2
{
    public partial class Clientes : Form
    {
        private string sql;
        private GerenteBancoDados obj = new GerenteBancoDados();
        
        public Clientes()
        {
            InitializeComponent();
        }

        private void BotãoSair_Click(object sender, EventArgs e)
        {

                this.Dispose();
   
        }

        private void Cadastrar_Click(object sender, EventArgs e)
        {
            if (validaentrada())
            {
                ArrayList arr = new ArrayList();
                try
                {
                    arr.Add(tb_CPF.Text);
                    arr.Add(tb_Nome.Text);
                    arr.Add(tb_Data_de_nacimento.Text);
                    arr.Add(tb_Tel.Text);
                    arr.Add(tb_Logradouro.Text);
                    arr.Add(tb_numero.Text);
                    arr.Add(tb_Bairro.Text);
                    arr.Add(tb_CEP.Text);
                    arr.Add(cb_Cidade.Text);
                    arr.Add(cb_Estado.Text);

                    if (obj.Insert(arr))
                    {
                        MessageBox.Show("Cadastrado com sucesso","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        tb_Bairro.Text = null;
                        tb_CEP.Text = null;
                        tb_CPF.Text = null;
                        tb_Data_de_nacimento.Text = null;
                        Tb_ficha.Text = null;
                        tb_Logradouro.Text = null;
                        tb_Nome.Text = null;
                        tb_Tel.Text = null;
                        tb_numero.Text = null;
                        cb_Cidade.Text = null;
                        cb_Estado.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Campo Preenchido incorretamente\n Verifique e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Campo Preenchido incorretamente\n Verifique e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo Preenchido incorretamente\n Verifique e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool validaentrada()
        {
            try
            {
                int g = int.Parse(tb_numero.Text);
            }
            catch
            {
                return false;
            }

            if (tb_CPF.Text == null || tb_Nome.Text == null || tb_Data_de_nacimento.Text == null || tb_Logradouro.Text == null ||
                tb_numero.Text == null || tb_Bairro.Text == null || tb_CEP.Text == null || cb_Cidade.Text == null || cb_Estado.Text == null)
            {
                return false;
            }
            
            return true;
        }

        private void Bt_Pesquisar_Click(object sender, EventArgs e)
        {
            
            
            if (rbNome.Checked)
            {
                    sql = "SELECT [FICHA], [CPF], [NOME], [DATA_DE_NASCIMENTO], [TELEFONE], [LOGRADOURO], [NUMERO], [BAIRRO], [CEP] FROM CLIENTE WHERE NOME LIKE @VALOR ORDER BY [NOME]";
                    dataGridView2.DataSource = obj.Pesquisar(sql, "%" + tbVPerquisa.Text + "%");   
            }
            else
            {
                sql = "SELECT [FICHA], [CPF], [NOME], [DATA_DE_NASCIMENTO], [TELEFONE], [LOGRADOURO], [NUMERO], [BAIRRO], [CEP] FROM CLIENTE WHERE FICHA = @VALOR ORDER BY [NOME]";
                dataGridView2.DataSource = obj.Pesquisar(sql, tbVPerquisa.Text);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente excluir este cliente?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool valido = false;
                int cod_Cliente = 0;
                try
                {
                    cod_Cliente = int.Parse(tbCodAltEx.Text);
                    valido = true;
                }
                catch (Exception)
                {
                    valido = false;
                }
                if (valido)
                {
                    if (obj.Delete(cod_Cliente))
                    {
                        MessageBox.Show("Apagado");
                        dataGridView1.DataSource = obj.Listar();
                    }
                    else
                    {
                        MessageBox.Show("Não apagado");
                    }

                }
                else
                {
                    MessageBox.Show("Campos Preenchido incorretamente\n Verifique e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            WindowsFormsApplication3.AlterarCliente objAlt = new WindowsFormsApplication3.AlterarCliente();
            try
            {
                int x = int.Parse(tbCodAltEx.Text);
                if (objAlt.pegar(tbCodAltEx.Text))
                {
                    objAlt.ShowDialog();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Campos Preenchido incorretamente\n Verifique e tente novamente", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

     
           


        }


        private void Clientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj.Listar();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            dataGridView2.DataSource = obj.Listar();
        }

        private void Bt_pesqCliente_Click(object sender, EventArgs e)
        {
            sql = "SELECT [FICHA], [CPF], [NOME], [DATA_DE_NASCIMENTO], [TELEFONE], [LOGRADOURO], [NUMERO], [BAIRRO], [CEP] FROM CLIENTE WHERE NOME LIKE @VALOR ORDER BY NOME";
            dataGridView1.DataSource = obj.Pesquisar(sql, "%" + EsseAqui.Text + "%"); 
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.LocarFilme frmLocar = new WindowsFormsApplication3.LocarFilme();

            if (frmLocar.pegar(Tb_ficha.Text))
            {
                frmLocar.Show();
            }
        }

        private void bt_devolver_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.DevolverFilme frmDevolver = new WindowsFormsApplication3.DevolverFilme();
            if (frmDevolver.pegar(Tb_ficha.Text))
            {
                frmDevolver.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            WindowsFormsApplication3.FilmesLocados frmLocados = new WindowsFormsApplication3.FilmesLocados();

            frmLocados.Show();

        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            EsseAqui.Focus();
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

        private void BtCancelCliente_Click(object sender, EventArgs e)
        {
            tb_Bairro.Text = null;
            tb_CEP.Text = null;
            tb_CPF.Text = null;
            tb_Data_de_nacimento.Text = null;
            Tb_ficha.Text = null;
            tb_Logradouro.Text = null;
            tb_Nome.Text = null;
            tb_Tel.Text = null;
            tb_numero.Text = null;
            cb_Cidade.Text = null;
            cb_Estado.Text = null;
        }

        private void Clientes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (
                        tb_Bairro.Text != string.Empty ||
                        Tb_ficha.Text != string.Empty ||
                        tb_Logradouro.Text != string.Empty ||
                        tb_Nome.Text != string.Empty ||
                        tb_numero.Text != string.Empty ||
                        cb_Cidade.Text != string.Empty ||
                        cb_Estado.Text != string.Empty
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
