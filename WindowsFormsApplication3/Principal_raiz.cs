using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication3
{
    public class Principal_raiz
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Principal_raiz obj = new Principal_raiz();
            obj.Inicializacao();
        }

        public void Inicializacao()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Login_Locadora.Login login = new Login_Locadora.Login();

            Carregando Carregar = new Carregando();

            Carregar.ShowDialog();

            if (Carregar.Pbar)
            {
                Carregar.Dispose();
                login.ShowDialog();
                if (login.logado)
                {
                    login.Dispose();
                    Application.Run(new Locadora_2.Locadora_Principal());
                }

            }
        }
       

       

        

        
    }
}
