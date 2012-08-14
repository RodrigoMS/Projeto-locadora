using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Locadora_2
{
    
    public partial class Locadora_Principal : Form
    {
        
        public Locadora_Principal()
        {
           
            InitializeComponent();
        }
        private string entrega;
        private string Dias;
        private int resp;
        public string func;

        public void timer1_Tick(object sender, EventArgs e)
        {
            
            //A variavel DataHora atualiza a cada um segundo
            DateTime DataHota = DateTime.Now;
            //Mostra na Form
            lDate.Text = DataHota.ToShortDateString();
            LTime.Text = DataHota.ToLongTimeString();
            lbDataTime.Text = "Data: " + DataHota.ToShortDateString() + " Hora: " + DataHota.ToLongTimeString();
            Dias = DataHota.ToShortDateString();
            entrega = lbDataTime.Text;
        }
        public string DH()
        {
            return entrega;
        }
        public int ContaDias()
        {
            char a='0',b='0';
            char dias2;

            int x = 0;

            if ((Dias[0] == '0' || Dias[0] != '0') && (Dias[1] != '/'))
            {
                x = 1;
            }
            for (int i = 0; i <= x; ++i)
            {
                dias2 = Dias[i];

                if (i == 0) a = Dias[i];                                            
                else b = Dias[i];                                                 
            }

            if (a == '0')
            {
                Dias = Convert.ToString(b);
            }
            else
            {
                Dias = Convert.ToString(a);
                Dias += Convert.ToString(b);
            }
            return resp = Convert.ToInt16(Dias);
        }

     


        private void BotãoSair_Click(object sender, EventArgs e)
        {
            
        }

        private void BtUsuario_cvl1_Click(object sender, EventArgs e)
        {

        }
      
        private void Locadora_Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Sair do programa?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void Locadora_Principal_Load(object sender, EventArgs e)
        {
            GerenteBancoDados obj = new GerenteBancoDados();
            string sql;

            sql = "SELECT usuario FROM ATENDENTE";

            obj.conectar();

            SqlCommand comando = new SqlCommand(sql,obj.objCon);

            SqlDataReader lerAtendente = comando.ExecuteReader();

            for (int i = 0; lerAtendente.Read(); ++i)
            {
                label1.Text = lerAtendente["usuario"].ToString();
            }
            func = label1.Text;
            obj.desconectar();

            int datapc;
            int dataBanco=0;
            timer1_Tick(e,e);

            datapc = ContaDias();

            

            sql = "SELECT data FROM DataAtual";


            obj.conectar();

            SqlCommand cmd = new SqlCommand(sql,obj.objCon);

            SqlDataReader ledados = cmd.ExecuteReader();

            for (int i = 0; ledados.Read(); ++i)
            {
                dataBanco = Convert.ToInt16(ledados["data"]);
            }

            obj.desconectar();

            if (datapc != dataBanco)
            {

                sql = "UPDATE Locar_Devolver SET QtdDias = QtdDias + 1 ";
                obj.conectar();
                SqlCommand _cmd = new SqlCommand(sql, obj.objCon);
                _cmd.ExecuteNonQuery();
                obj.desconectar();


                sql = "UPDATE DataAtual SET Data = " + datapc;
                obj.conectar();
                SqlCommand cmd2 = new SqlCommand(sql, obj.objCon);
                cmd2.ExecuteNonQuery();
                obj.desconectar();
            }

        }

        private void bt_trocaUsuario_Click(object sender, EventArgs e)
        {
           Locadora_2.Locadora_Principal obj = new Locadora_Principal();

            obj.Dispose();
            Login_Locadora.Login login = new Login_Locadora.Login();
            login.ShowDialog();
            Locadora_Principal_Load(e,e);
        }

        private void Cliente_Click_1(object sender, EventArgs e)
        {
            Clientes Clientes = new Clientes();
            Clientes.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Filmes Filmes = new Filmes();
            Filmes.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            WindowsFormsApplication3.frmSenhaAdm Verifica = new WindowsFormsApplication3.frmSenhaAdm();

            WindowsFormsApplication3.FmUsuario frmusuario = new WindowsFormsApplication3.FmUsuario();

            Verifica.ShowDialog();
            if (Verifica.Senhalogado)
            {
                frmusuario.ShowDialog();
            }
          
        }

        public void button1_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Sair do programa?", "Mensagem do Sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Application.ExitThread();
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
