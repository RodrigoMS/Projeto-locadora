using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
//Adicionar Bibliotécas
using System.Data;
using System.Data.SqlClient;


namespace Locadora_2
{
    class GerenteBancoDados
    {

        private const string Conectividade = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Diego_Germano\Desktop\ProjetoLocadora\BancoLocadora - Cópia\BancoLocadora.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        private string SQL = "";
        public SqlConnection objCon = null;

       
        // METODOS CONECTAR E DESCONECTAR AO BANCO
        
        public bool conectar()
        {
            objCon = new SqlConnection(Conectividade);
            try
            {
                objCon.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool desconectar()
        {
            if (objCon.State != ConnectionState.Closed)
            {
                objCon.Close();
                //retira o objeto da menória
                objCon.Dispose();
                return true;
            }
            else
            {
                objCon.Dispose();
                return false;
            }
        }

        // METODOS CLIENTES

        public bool Insert(ArrayList p_arrInsert)
        {
            SQL = "INSERT INTO CLIENTE([CPF],[NOME],[DATA_DE_NASCIMENTO],[TELEFONE],[LOGRADOURO],[NUMERO],[BAIRRO],[CEP],[CIDADE],[ESTADO])" +
                  "VALUES(@CPF,@NOME,@DATA_DE_NACIMENTO,@TELEFONE,@LOGRADOURO,@NUMERO,@BAIRRO,@CEP,@CIDADE,@ESTADO);";
            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    //VAI FASER A INCERÇÃO NO BANDO DE DADOS - DE FORMA QUE CADA ATRIBUTO SQL SE TORNA UMA VARIÁVEL STRING 
                    objcmd = new SqlCommand(SQL, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@CPF", p_arrInsert[0]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME", p_arrInsert[1]));
                    objcmd.Parameters.Add(new SqlParameter("@DATA_DE_NACIMENTO", p_arrInsert[2]));
                    objcmd.Parameters.Add(new SqlParameter("@TELEFONE", p_arrInsert[3]));
                    objcmd.Parameters.Add(new SqlParameter("@LOGRADOURO", p_arrInsert[4]));
                    objcmd.Parameters.Add(new SqlParameter("@NUMERO", p_arrInsert[5]));
                    objcmd.Parameters.Add(new SqlParameter("@BAIRRO", p_arrInsert[6]));
                    objcmd.Parameters.Add(new SqlParameter("@CEP", p_arrInsert[7]));
                    objcmd.Parameters.Add(new SqlParameter("@CIDADE", p_arrInsert[8]));
                    objcmd.Parameters.Add(new SqlParameter("@ESTADO", p_arrInsert[9]));

                    //Executa e não consulta
                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlerr)
                {
                    return false;
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public bool Update(ArrayList p_arrUpdate)
        {
            SQL = "UPDATE CLIENTE SET CPF = @CPF, NOME = @NOME, DATA_DE_NASCIMENTO = @DATA_DE_NASCIMENTO,"+
   " TELEFONE = @TELEFONE, LOGRADOURO = @LOGRADOURO, NUMERO = @NUMERO, BAIRRO = @BAIRRO, CEP = @CEP, CIDADE = @CIDADE, ESTADO = @ESTADO WHERE FICHA = @FICHA";
            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    //VAI FASER A INCERÇÃO NO BANDO DE DADOS - DE FORMA QUE CADA ATRIBUTO SQL SE TORNA UMA VARIÁVEL STRING 
                    objcmd = new SqlCommand(SQL, objCon);
                    
                    objcmd.Parameters.Add(new SqlParameter("@CPF", p_arrUpdate[0]));
                    objcmd.Parameters.Add(new SqlParameter("@NOME", p_arrUpdate[1]));
                    objcmd.Parameters.Add(new SqlParameter("@DATA_DE_NASCIMENTO", p_arrUpdate[2]));
                    objcmd.Parameters.Add(new SqlParameter("@TELEFONE", p_arrUpdate[3]));
                    objcmd.Parameters.Add(new SqlParameter("@LOGRADOURO", p_arrUpdate[4]));
                    objcmd.Parameters.Add(new SqlParameter("@NUMERO", p_arrUpdate[5]));
                    objcmd.Parameters.Add(new SqlParameter("@BAIRRO", p_arrUpdate[6]));
                    objcmd.Parameters.Add(new SqlParameter("@CEP", p_arrUpdate[7]));
                    objcmd.Parameters.Add(new SqlParameter("@CIDADE", p_arrUpdate[8]));
                    objcmd.Parameters.Add(new SqlParameter("@ESTADO", p_arrUpdate[9]));
                    objcmd.Parameters.Add(new SqlParameter("@FICHA", p_arrUpdate[10]));

                    

                    //Executa e não consulta
                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int FichaCliente )
        {
            SQL = "DELETE FROM CLIENTE WHERE FICHA = @FICHA";
            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(SQL, objCon);
                    objcmd.Parameters.AddWithValue("@FICHA",FichaCliente);

                    objcmd.ExecuteNonQuery();

                    return true;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return false;
            }
        }
   
        public DataTable Listar()
        {
            SQL = "SELECT [FICHA], [CPF], [NOME], [DATA_DE_NASCIMENTO], [TELEFONE], [LOGRADOURO], [NUMERO], [BAIRRO], [CEP], [CIDADE], [ESTADO] FROM CLIENTE ORDER BY [NOME]";
            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(SQL, objCon);
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
        }

        public DataTable Pesquisar(string sql,string param)
        {
            this.SQL = sql;
            SqlCommand objcmd = null;

            if (this.conectar())
            {
                try
                {
                    objcmd = new SqlCommand(SQL, objCon);
                    objcmd.Parameters.Add(new SqlParameter("@VALOR",param));
                    SqlDataAdapter adp = new SqlDataAdapter(objcmd);
                    DataTable dt = new DataTable();
                    adp.Fill(dt);
                    return dt;
                }
                catch (SqlException sqlerr)
                {
                    return null;
                    throw sqlerr;
                }
                finally
                {
                    this.desconectar();
                }
            }
            else
            {
                return null;
            }
        }

      // METODOS FILMES

        public DataTable ListGridFilme()
        {
            SQL = "SELECT [id_filme] AS CÓDIGO,[titulo] AS TÍTULO,[subtitulo] AS SUBTÍTULO," +
            "[anoprod] AS ANO_PRODUZIDO, [produtora] AS PRODUTORA,[genero] AS GENERO,[duracao]" +
            "AS DURAÇÃO,[quantidade] AS QUANTIDADE FROM Filme ORDER BY TITULO";



            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand(SQL, objCon);

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
                this.desconectar();
            }

        }

        public DataTable PesquisaFilme(string sql, string Pesq)
        {
            this.SQL = sql;



            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand(SQL, objCon);

                cmd.Parameters.Add(new SqlParameter("@Pesq", Pesq));

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
                desconectar();
            }

        }

        public bool ExcluirFilme(int cod)
        {
            SQL = "DELETE FROM filme WHERE id_filme =" + cod;
            
            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand(SQL, objCon);

                cmd.ExecuteNonQuery();

                desconectar();
                return true;
            }
            catch (SqlException ee)
            {
                return false;
                throw ee;
            }
        }

        public bool UpdateFilme(ArrayList _Update)
        {

            SQL = "UPDATE  Filme SET titulo = @titulo, subtitulo = @subtitulo, anoprod = @anoprod, produtora = @produtora, genero = @genero, duracao = @duracao, quantidade = @quantidade WHERE id_filme = @id_filme";

           
            try
            {

                conectar();
                SqlCommand cmd = new SqlCommand(SQL, objCon);

                cmd.Parameters.Add(new SqlParameter("@titulo", _Update[0]));
                cmd.Parameters.Add(new SqlParameter("@subtitulo", _Update[1]));
                cmd.Parameters.Add(new SqlParameter("@anoprod", _Update[2]));
                cmd.Parameters.Add(new SqlParameter("@produtora", _Update[3]));
                cmd.Parameters.Add(new SqlParameter("@genero", _Update[4]));
                cmd.Parameters.Add(new SqlParameter("@duracao", _Update[5]));
                cmd.Parameters.Add(new SqlParameter("@quantidade", _Update[6]));
                cmd.Parameters.Add(new SqlParameter("@id_filme", _Update[7]));


                cmd.ExecuteNonQuery();

                desconectar();
                return true;

            }
            catch (SqlException x)
            {
                return false;
                throw x;
            }


        }

        // METODOS LOCAR

        public bool InsertLocados(string filme, string cliente, string Nfilme, string Ncliente, string tel, string datHora,string atendente)
        {
 
            try
            {
                SQL = "INSERT INTO Locar_Devolver (id_filme,NomeFilme,id_cliente,NomeCliente,Telefone,DataHora,QtdDias,Atendente_L)VALUES ('" + filme + "','" + Nfilme + "','" + cliente + "','" + Ncliente + "','" + tel + "','" + datHora + "',"+0+",'"+atendente+"')";
                conectar();
                SqlCommand cmd = new SqlCommand(SQL, objCon);
                cmd.ExecuteNonQuery();
                desconectar();


                SQL = "UPDATE Filme SET QUANTIDADE = QUANTIDADE - 1 WHERE id_filme = " + filme;
                conectar();
                SqlCommand _cmd = new SqlCommand(SQL, objCon);
                _cmd.ExecuteNonQuery();
                desconectar();


                return true;
            }
            catch (SqlException xx)
            {
                return false;
                throw xx;
            }
            finally
            {

            }


        }

        public bool DevolverLocados(string cod, int cliente,string datDevolve)
        {
            string NomeF = null, DatHor= null,atendente_L=null,atendente_D;
            try
            {
                try
                {

                    int v = int.Parse(cod);
                }
                catch (Exception)
                {
                    return false;
                }

                SQL = "SELECT NomeFilme, DataHora,Atendente_L FROM Locar_Devolver WHERE id_filme = " + cod + "AND id_cliente = " + cliente;


                conectar();
                SqlCommand cmd0 = new SqlCommand(SQL, objCon);

                SqlDataReader ledados = cmd0.ExecuteReader();

                for (int i = 0; ledados.Read(); ++i)
                {
                    NomeF = (ledados["NomeFilme"]).ToString();
                    DatHor = (ledados["DataHora"]).ToString();
                    atendente_L = (ledados["Atendente_L"]).ToString();
                }
                desconectar();

                if (NomeF == null || DatHor == null || atendente_L == null)
                {
                    return false;
                }
               
                    WindowsFormsApplication3.LocarFilme pegar = new WindowsFormsApplication3.LocarFilme();

                    atendente_D = pegar.Funcionario();

                    SQL = "INSERT INTO HISTORICO(id_filme,Nomefilme,Retirada,Atendente_R, Devolucao, Atendente_D, id_cliente) VALUES ('" + cod + "','" + NomeF + "','" + DatHor + "','" + atendente_L + "','" + datDevolve + "','" + atendente_D + "'," + cliente + ")";

                    conectar();

                    SqlCommand cmdHistorico = new SqlCommand(SQL, objCon);

                    cmdHistorico.ExecuteNonQuery();

                    desconectar();


                    SQL = "DELETE FROM Locar_Devolver WHERE id_filme = " + cod + "AND id_cliente = " + cliente;
                    conectar();
                    SqlCommand cmd = new SqlCommand(SQL, objCon);

                    cmd.ExecuteNonQuery();

                    desconectar();

                    SQL = "UPDATE Filme SET QUANTIDADE = QUANTIDADE + 1 WHERE id_filme = " + cod;

                    conectar();

                    SqlCommand cmd2 = new SqlCommand(SQL, objCon);

                    cmd2.ExecuteNonQuery();

                    desconectar();
                    return true;
                
            }

            catch (SqlException ee)
            {
                return false;
                throw ee;
            }
        }

        public DataTable ListaLocados(string x)
        {
            if (x != null)
            {
                SQL = "SELECT [id_filme] AS CÓDIGO,[NomeFilme] AS TÍTULO, [DataHora] AS DATA_E_HORA,[Atendente_L] AS ATENDENTE_R FROM Locar_Devolver WHERE id_cliente = " + x+" ORDER BY NomeFilme";
            }
            else
            {
                SQL = "SELECT [id_filme] AS CÓDIGO,[NomeFilme] AS TÍTULO,[id_cliente] AS FICHA,[NomeCliente] AS CLIENTE,[telefone] AS TELEFONE, [DataHora] AS DATA_E_HORA,[QtdDias] AS QTD_DIAS, [Atendente_L] AS ATENDENTE_R FROM Locar_Devolver ORDER BY NomeCliente";
            }
                         
            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand(SQL, objCon);

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
                this.desconectar();
            }

        }

        public DataTable ListaAtrazos()
        {
           
            SQL = "SELECT [id_filme] AS CÓDIGO,[NomeFilme] AS TÍTULO,[id_cliente] AS FICHA,[NomeCliente] AS CLIENTE,[telefone] AS TELEFONE, [DataHora] AS DATA_E_HORA, [QtdDias] AS QTD_DIAS,[Atendente_L] AS ATENDENTE_R FROM Locar_Devolver WHERE QtdDias >= 2 ORDER BY NomeCliente";   
            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand(SQL, objCon);

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
                this.desconectar();
            }
        }
        
        public DataTable ListaHistórico(string ficha)
        {

            SQL = "SELECT [id_filme] AS CÓDIGO,[NomeFilme] AS TÍTULO,[Retirada] AS RETIRADA,[Atendente_R] AS ATENDENTE_R, [DEVOLUCAO] AS DEVOLUÇÃO,[Atendente_D] AS ATENDENTE_D FROM HISTORICO WHERE id_cliente = " + ficha+" ORDER BY Nomefilme";
    
               
            

            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand(SQL, objCon);

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
                this.desconectar();
            }
        
        }

        public DataTable ListaHistoricoDevolidos(string SQL, string Pesq,string ppesquisa2)
        {


            try
            {
                conectar();

                SqlCommand cmd = new SqlCommand(SQL, objCon);

                cmd.Parameters.Add(new SqlParameter("@Pesq", Pesq));

                cmd.Parameters.Add(new SqlParameter("@Pesq2", ppesquisa2));

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
                desconectar();
            }
            
        }

    }
}
