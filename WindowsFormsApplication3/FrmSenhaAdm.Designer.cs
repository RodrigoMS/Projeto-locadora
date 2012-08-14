namespace WindowsFormsApplication3
{
    partial class frmSenhaAdm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSenhaAdm));
            this.bt_senhaAdm = new System.Windows.Forms.Button();
            this.bt_CancelSenhaAdm = new System.Windows.Forms.Button();
            this.tb_senhaAdm = new System.Windows.Forms.TextBox();
            this.lb_senha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_senhaAdm
            // 
            this.bt_senhaAdm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_senhaAdm.Location = new System.Drawing.Point(145, 92);
            this.bt_senhaAdm.Name = "bt_senhaAdm";
            this.bt_senhaAdm.Size = new System.Drawing.Size(100, 39);
            this.bt_senhaAdm.TabIndex = 2;
            this.bt_senhaAdm.Text = "&Ok";
            this.bt_senhaAdm.UseVisualStyleBackColor = true;
            this.bt_senhaAdm.Click += new System.EventHandler(this.bt_senhaAdm_Click);
            // 
            // bt_CancelSenhaAdm
            // 
            this.bt_CancelSenhaAdm.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_CancelSenhaAdm.Location = new System.Drawing.Point(274, 92);
            this.bt_CancelSenhaAdm.Name = "bt_CancelSenhaAdm";
            this.bt_CancelSenhaAdm.Size = new System.Drawing.Size(99, 39);
            this.bt_CancelSenhaAdm.TabIndex = 3;
            this.bt_CancelSenhaAdm.Text = "&Cancelar";
            this.bt_CancelSenhaAdm.UseVisualStyleBackColor = true;
            this.bt_CancelSenhaAdm.Click += new System.EventHandler(this.bt_CancelSenhaAdm_Click);
            // 
            // tb_senhaAdm
            // 
            this.tb_senhaAdm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_senhaAdm.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senhaAdm.Location = new System.Drawing.Point(145, 16);
            this.tb_senhaAdm.Name = "tb_senhaAdm";
            this.tb_senhaAdm.PasswordChar = '*';
            this.tb_senhaAdm.Size = new System.Drawing.Size(228, 33);
            this.tb_senhaAdm.TabIndex = 1;
            this.tb_senhaAdm.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_senhaAdm_KeyDown);
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.BackColor = System.Drawing.Color.Transparent;
            this.lb_senha.Font = new System.Drawing.Font("Verdana", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_senha.Location = new System.Drawing.Point(12, 19);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(90, 26);
            this.lb_senha.TabIndex = 4;
            this.lb_senha.Text = "Senha";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 6;
            // 
            // frmSenhaAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(385, 143);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_senhaAdm);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.bt_CancelSenhaAdm);
            this.Controls.Add(this.bt_senhaAdm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSenhaAdm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Somente Administrador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_senhaAdm;
        private System.Windows.Forms.Button bt_CancelSenhaAdm;
        private System.Windows.Forms.TextBox tb_senhaAdm;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.Label label1;
    }
}