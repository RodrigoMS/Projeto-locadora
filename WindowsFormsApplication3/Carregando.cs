using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Carregando : Form
    {
        public bool Pbar = false;


        public Carregando()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 20;

            }
            else
            {
                //timer1.Enabled = false;
                timer1.Stop();

                Pbar= true;
                
                this.Dispose();

            }
            

        }

        private void Carregando_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void Carregando_Load(object sender, EventArgs e)
        {

        }


    }
}
