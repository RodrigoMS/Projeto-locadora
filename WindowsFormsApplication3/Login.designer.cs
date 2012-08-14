namespace Login_Locadora
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lb_usuario = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.tb_Usuario = new System.Windows.Forms.TextBox();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_usuario
            // 
            this.lb_usuario.AutoSize = true;
            this.lb_usuario.BackColor = System.Drawing.Color.Transparent;
            this.lb_usuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_usuario.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_usuario.Location = new System.Drawing.Point(214, 59);
            this.lb_usuario.Name = "lb_usuario";
            this.lb_usuario.Size = new System.Drawing.Size(92, 23);
            this.lb_usuario.TabIndex = 0;
            this.lb_usuario.Text = "Usuário";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.BackColor = System.Drawing.Color.Transparent;
            this.lb_senha.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_senha.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_senha.Location = new System.Drawing.Point(214, 149);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(78, 23);
            this.lb_senha.TabIndex = 1;
            this.lb_senha.Text = "Senha";
            // 
            // tb_Usuario
            // 
            this.tb_Usuario.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Usuario.Location = new System.Drawing.Point(218, 85);
            this.tb_Usuario.Name = "tb_Usuario";
            this.tb_Usuario.Size = new System.Drawing.Size(228, 31);
            this.tb_Usuario.TabIndex = 2;
            // 
            // tb_senha
            // 
            this.tb_senha.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tb_senha.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_senha.Location = new System.Drawing.Point(218, 175);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = '*';
            this.tb_senha.Size = new System.Drawing.Size(228, 33);
            this.tb_senha.TabIndex = 3;
            this.tb_senha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_senha_KeyDown);
            // 
            // bt_login
            // 
            this.bt_login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_login.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_login.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.bt_login.Location = new System.Drawing.Point(169, 255);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(137, 38);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "Efetuar Login";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_cancelar
            // 
            this.bt_cancelar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_cancelar.Location = new System.Drawing.Point(330, 255);
            this.bt_cancelar.Name = "bt_cancelar";
            this.bt_cancelar.Size = new System.Drawing.Size(116, 38);
            this.bt_cancelar.TabIndex = 5;
            this.bt_cancelar.Text = "Sair";
            this.bt_cancelar.UseVisualStyleBackColor = true;
            this.bt_cancelar.Click += new System.EventHandler(this.bt_cancelar_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(466, 309);
            this.Controls.Add(this.bt_cancelar);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_Usuario);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessar o Sistema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_usuario;
        private System.Windows.Forms.Label lb_senha;
        private System.Windows.Forms.TextBox tb_Usuario;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_cancelar;
    }
}

