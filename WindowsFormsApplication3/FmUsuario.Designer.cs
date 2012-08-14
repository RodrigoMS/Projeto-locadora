namespace WindowsFormsApplication3
{
    partial class FmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmUsuario));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tbDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Retornar = new System.Windows.Forms.ToolStripButton();
            this.button2 = new System.Windows.Forms.Button();
            this.bt_Cadastrar = new System.Windows.Forms.Button();
            this.tb_confirmaSenha = new System.Windows.Forms.TextBox();
            this.tb_SenhaCad = new System.Windows.Forms.TextBox();
            this.tbLoginCad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbSenha = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Retorna = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dg_Excluir = new System.Windows.Forms.DataGridView();
            this.bt_excluirUser = new System.Windows.Forms.Button();
            this.tb_excluirUser = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.Salvar = new System.Windows.Forms.Button();
            this.tb_confirma = new System.Windows.Forms.TextBox();
            this.tb_novaSenha = new System.Windows.Forms.TextBox();
            this.tb_novoNome = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LbnomeAdm = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.toolStrip3 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.lb_atrazados = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lb_locados = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_qtddeclientes = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_outros = new System.Windows.Forms.Label();
            this.lb_ficcao = new System.Windows.Forms.Label();
            this.lb_documentario = new System.Windows.Forms.Label();
            this.lb_comedia = new System.Windows.Forms.Label();
            this.lb_terror = new System.Windows.Forms.Label();
            this.lb_drama = new System.Windows.Forms.Label();
            this.lbRomance = new System.Windows.Forms.Label();
            this.lb_aventura = new System.Windows.Forms.Label();
            this.lb_acao = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lb_qtdfuncionários = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.Retorna.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Excluir)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.toolStrip3.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 440);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbDateTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 440);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(634, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tbDateTime
            // 
            this.tbDateTime.Name = "tbDateTime";
            this.tbDateTime.Size = new System.Drawing.Size(118, 17);
            this.tbDateTime.Text = "toolStripStatusLabel1";
            this.tbDateTime.Click += new System.EventHandler(this.tbDateTime_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 440);
            this.panel1.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Verdana", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(631, 437);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.Enter += new System.EventHandler(this.tabControl1_Enter);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.bt_Cadastrar);
            this.tabPage1.Controls.Add(this.tb_confirmaSenha);
            this.tabPage1.Controls.Add(this.tb_SenhaCad);
            this.tabPage1.Controls.Add(this.tbLoginCad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbSenha);
            this.tabPage1.Controls.Add(this.lbLogin);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(623, 411);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cadastrar Funcionário";
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Retornar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 369);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(617, 39);
            this.toolStrip1.TabIndex = 12;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Retornar
            // 
            this.Retornar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Retornar.ForeColor = System.Drawing.SystemColors.Control;
            this.Retornar.Image = ((System.Drawing.Image)(resources.GetObject("Retornar.Image")));
            this.Retornar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Retornar.Name = "Retornar";
            this.Retornar.Size = new System.Drawing.Size(112, 36);
            this.Retornar.Text = "Retornar";
            this.Retornar.Click += new System.EventHandler(this.Retornar_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(370, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 44);
            this.button2.TabIndex = 11;
            this.button2.Text = "&Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Cadastrar
            // 
            this.bt_Cadastrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.bt_Cadastrar.Location = new System.Drawing.Point(142, 266);
            this.bt_Cadastrar.Name = "bt_Cadastrar";
            this.bt_Cadastrar.Size = new System.Drawing.Size(93, 44);
            this.bt_Cadastrar.TabIndex = 10;
            this.bt_Cadastrar.Text = "&Cadastrar";
            this.bt_Cadastrar.UseVisualStyleBackColor = true;
            this.bt_Cadastrar.Click += new System.EventHandler(this.bt_Cadastrar_Click);
            // 
            // tb_confirmaSenha
            // 
            this.tb_confirmaSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_confirmaSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirmaSenha.Location = new System.Drawing.Point(307, 194);
            this.tb_confirmaSenha.Name = "tb_confirmaSenha";
            this.tb_confirmaSenha.PasswordChar = '*';
            this.tb_confirmaSenha.Size = new System.Drawing.Size(156, 27);
            this.tb_confirmaSenha.TabIndex = 9;
            // 
            // tb_SenhaCad
            // 
            this.tb_SenhaCad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SenhaCad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_SenhaCad.Location = new System.Drawing.Point(307, 150);
            this.tb_SenhaCad.Name = "tb_SenhaCad";
            this.tb_SenhaCad.PasswordChar = '*';
            this.tb_SenhaCad.Size = new System.Drawing.Size(156, 27);
            this.tb_SenhaCad.TabIndex = 8;
            // 
            // tbLoginCad
            // 
            this.tbLoginCad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbLoginCad.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbLoginCad.Location = new System.Drawing.Point(307, 104);
            this.tbLoginCad.Name = "tbLoginCad";
            this.tbLoginCad.Size = new System.Drawing.Size(156, 27);
            this.tbLoginCad.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(139, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Confirmar Senha:";
            // 
            // lbSenha
            // 
            this.lbSenha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbSenha.AutoSize = true;
            this.lbSenha.BackColor = System.Drawing.Color.Transparent;
            this.lbSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSenha.ForeColor = System.Drawing.SystemColors.Control;
            this.lbSenha.Location = new System.Drawing.Point(139, 153);
            this.lbSenha.Name = "lbSenha";
            this.lbSenha.Size = new System.Drawing.Size(69, 18);
            this.lbSenha.TabIndex = 5;
            this.lbSenha.Text = "Senha:";
            // 
            // lbLogin
            // 
            this.lbLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lbLogin.AutoSize = true;
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.lbLogin.Location = new System.Drawing.Point(139, 107);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(61, 18);
            this.lbLogin.TabIndex = 4;
            this.lbLogin.Text = "Login:";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage3.BackgroundImage")));
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.Retorna);
            this.tabPage3.Controls.Add(this.dg_Excluir);
            this.tabPage3.Controls.Add(this.bt_excluirUser);
            this.tabPage3.Controls.Add(this.tb_excluirUser);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(623, 411);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Excluir Funcionário";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // Retorna
            // 
            this.Retorna.BackColor = System.Drawing.Color.Transparent;
            this.Retorna.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Retorna.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Retorna.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.Retorna.Location = new System.Drawing.Point(3, 369);
            this.Retorna.Name = "Retorna";
            this.Retorna.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Retorna.Size = new System.Drawing.Size(617, 39);
            this.Retorna.TabIndex = 13;
            this.Retorna.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(112, 36);
            this.toolStripButton1.Text = "Retornar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // dg_Excluir
            // 
            this.dg_Excluir.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dg_Excluir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Excluir.GridColor = System.Drawing.SystemColors.ControlText;
            this.dg_Excluir.Location = new System.Drawing.Point(134, 82);
            this.dg_Excluir.Name = "dg_Excluir";
            this.dg_Excluir.Size = new System.Drawing.Size(363, 167);
            this.dg_Excluir.TabIndex = 7;
            // 
            // bt_excluirUser
            // 
            this.bt_excluirUser.Location = new System.Drawing.Point(426, 334);
            this.bt_excluirUser.Name = "bt_excluirUser";
            this.bt_excluirUser.Size = new System.Drawing.Size(95, 24);
            this.bt_excluirUser.TabIndex = 6;
            this.bt_excluirUser.Text = "&Excluir";
            this.bt_excluirUser.UseVisualStyleBackColor = true;
            this.bt_excluirUser.Click += new System.EventHandler(this.bt_excluirUser_Click);
            // 
            // tb_excluirUser
            // 
            this.tb_excluirUser.Location = new System.Drawing.Point(259, 334);
            this.tb_excluirUser.Name = "tb_excluirUser";
            this.tb_excluirUser.Size = new System.Drawing.Size(161, 20);
            this.tb_excluirUser.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(28, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(225, 18);
            this.label4.TabIndex = 4;
            this.label4.Text = "Código de Identificação: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 18);
            this.label2.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.fundo_azul_2_;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.Salvar);
            this.tabPage2.Controls.Add(this.tb_confirma);
            this.tabPage2.Controls.Add(this.tb_novaSenha);
            this.tabPage2.Controls.Add(this.tb_novoNome);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.LbnomeAdm);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.toolStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(623, 411);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Alterar Administrador";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(370, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 28);
            this.button3.TabIndex = 24;
            this.button3.Text = "&Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Salvar
            // 
            this.Salvar.Location = new System.Drawing.Point(492, 313);
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(111, 28);
            this.Salvar.TabIndex = 23;
            this.Salvar.Text = "&Salvar";
            this.Salvar.UseVisualStyleBackColor = true;
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // tb_confirma
            // 
            this.tb_confirma.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirma.Location = new System.Drawing.Point(220, 219);
            this.tb_confirma.Name = "tb_confirma";
            this.tb_confirma.PasswordChar = '*';
            this.tb_confirma.Size = new System.Drawing.Size(100, 27);
            this.tb_confirma.TabIndex = 22;
            // 
            // tb_novaSenha
            // 
            this.tb_novaSenha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_novaSenha.Location = new System.Drawing.Point(220, 175);
            this.tb_novaSenha.Name = "tb_novaSenha";
            this.tb_novaSenha.PasswordChar = '*';
            this.tb_novaSenha.Size = new System.Drawing.Size(100, 27);
            this.tb_novaSenha.TabIndex = 21;
            // 
            // tb_novoNome
            // 
            this.tb_novoNome.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_novoNome.Location = new System.Drawing.Point(220, 131);
            this.tb_novoNome.Name = "tb_novoNome";
            this.tb_novoNome.Size = new System.Drawing.Size(100, 27);
            this.tb_novoNome.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(62, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(148, 18);
            this.label9.TabIndex = 19;
            this.label9.Text = "Confirma Senha";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Control;
            this.label8.Location = new System.Drawing.Point(62, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 18);
            this.label8.TabIndex = 18;
            this.label8.Text = "Nova Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(62, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 18);
            this.label7.TabIndex = 17;
            this.label7.Text = "Novo Adm";
            // 
            // LbnomeAdm
            // 
            this.LbnomeAdm.AutoSize = true;
            this.LbnomeAdm.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbnomeAdm.ForeColor = System.Drawing.SystemColors.Control;
            this.LbnomeAdm.Location = new System.Drawing.Point(400, 41);
            this.LbnomeAdm.Name = "LbnomeAdm";
            this.LbnomeAdm.Size = new System.Drawing.Size(107, 32);
            this.LbnomeAdm.TabIndex = 16;
            this.LbnomeAdm.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(122, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 32);
            this.label5.TabIndex = 15;
            this.label5.Text = "Administrador";
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2});
            this.toolStrip2.Location = new System.Drawing.Point(3, 369);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(617, 39);
            this.toolStrip2.TabIndex = 14;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton2.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(112, 36);
            this.toolStripButton2.Text = "Retornar";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackgroundImage = global::WindowsFormsApplication3.Properties.Resources.fundo_azul_2_2;
            this.tabPage4.Controls.Add(this.toolStrip3);
            this.tabPage4.Controls.Add(this.lb_atrazados);
            this.tabPage4.Controls.Add(this.label20);
            this.tabPage4.Controls.Add(this.lb_locados);
            this.tabPage4.Controls.Add(this.label18);
            this.tabPage4.Controls.Add(this.label11);
            this.tabPage4.Controls.Add(this.lb_qtddeclientes);
            this.tabPage4.Controls.Add(this.lb_total);
            this.tabPage4.Controls.Add(this.lb_outros);
            this.tabPage4.Controls.Add(this.lb_ficcao);
            this.tabPage4.Controls.Add(this.lb_documentario);
            this.tabPage4.Controls.Add(this.lb_comedia);
            this.tabPage4.Controls.Add(this.lb_terror);
            this.tabPage4.Controls.Add(this.lb_drama);
            this.tabPage4.Controls.Add(this.lbRomance);
            this.tabPage4.Controls.Add(this.lb_aventura);
            this.tabPage4.Controls.Add(this.lb_acao);
            this.tabPage4.Controls.Add(this.label17);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label26);
            this.tabPage4.Controls.Add(this.label16);
            this.tabPage4.Controls.Add(this.label15);
            this.tabPage4.Controls.Add(this.label14);
            this.tabPage4.Controls.Add(this.label13);
            this.tabPage4.Controls.Add(this.label12);
            this.tabPage4.Controls.Add(this.lb_qtdfuncionários);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(623, 411);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Outras Informações";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // toolStrip3
            // 
            this.toolStrip3.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip3.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3});
            this.toolStrip3.Location = new System.Drawing.Point(3, 369);
            this.toolStrip3.Name = "toolStrip3";
            this.toolStrip3.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip3.Size = new System.Drawing.Size(617, 39);
            this.toolStrip3.TabIndex = 61;
            this.toolStrip3.Text = "toolStrip3";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton3.ForeColor = System.Drawing.SystemColors.Control;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(112, 36);
            this.toolStripButton3.Text = "Retornar";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // lb_atrazados
            // 
            this.lb_atrazados.AutoSize = true;
            this.lb_atrazados.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_atrazados.Location = new System.Drawing.Point(154, 332);
            this.lb_atrazados.Name = "lb_atrazados";
            this.lb_atrazados.Size = new System.Drawing.Size(0, 13);
            this.lb_atrazados.TabIndex = 60;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.Control;
            this.label20.Location = new System.Drawing.Point(4, 332);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(136, 13);
            this.label20.TabIndex = 59;
            this.label20.Text = "Atrazados........... ->";
            // 
            // lb_locados
            // 
            this.lb_locados.AutoSize = true;
            this.lb_locados.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_locados.Location = new System.Drawing.Point(153, 302);
            this.lb_locados.Name = "lb_locados";
            this.lb_locados.Size = new System.Drawing.Size(0, 13);
            this.lb_locados.TabIndex = 58;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.Control;
            this.label18.Location = new System.Drawing.Point(5, 302);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(135, 13);
            this.label18.TabIndex = 57;
            this.label18.Text = "Locados ............. ->";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.Control;
            this.label11.Location = new System.Drawing.Point(365, 275);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(252, 18);
            this.label11.TabIndex = 56;
            this.label11.Text = "Quantidade de Funcionarios";
            // 
            // lb_qtddeclientes
            // 
            this.lb_qtddeclientes.AutoSize = true;
            this.lb_qtddeclientes.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_qtddeclientes.Location = new System.Drawing.Point(492, 103);
            this.lb_qtddeclientes.Name = "lb_qtddeclientes";
            this.lb_qtddeclientes.Size = new System.Drawing.Size(0, 13);
            this.lb_qtddeclientes.TabIndex = 55;
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_total.Location = new System.Drawing.Point(154, 275);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(0, 13);
            this.lb_total.TabIndex = 54;
            // 
            // lb_outros
            // 
            this.lb_outros.AutoSize = true;
            this.lb_outros.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_outros.Location = new System.Drawing.Point(153, 249);
            this.lb_outros.Name = "lb_outros";
            this.lb_outros.Size = new System.Drawing.Size(0, 13);
            this.lb_outros.TabIndex = 53;
            // 
            // lb_ficcao
            // 
            this.lb_ficcao.AutoSize = true;
            this.lb_ficcao.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_ficcao.Location = new System.Drawing.Point(153, 222);
            this.lb_ficcao.Name = "lb_ficcao";
            this.lb_ficcao.Size = new System.Drawing.Size(0, 13);
            this.lb_ficcao.TabIndex = 52;
            // 
            // lb_documentario
            // 
            this.lb_documentario.AutoSize = true;
            this.lb_documentario.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_documentario.Location = new System.Drawing.Point(152, 198);
            this.lb_documentario.Name = "lb_documentario";
            this.lb_documentario.Size = new System.Drawing.Size(0, 13);
            this.lb_documentario.TabIndex = 51;
            // 
            // lb_comedia
            // 
            this.lb_comedia.AutoSize = true;
            this.lb_comedia.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_comedia.Location = new System.Drawing.Point(153, 175);
            this.lb_comedia.Name = "lb_comedia";
            this.lb_comedia.Size = new System.Drawing.Size(0, 13);
            this.lb_comedia.TabIndex = 50;
            // 
            // lb_terror
            // 
            this.lb_terror.AutoSize = true;
            this.lb_terror.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_terror.Location = new System.Drawing.Point(153, 147);
            this.lb_terror.Name = "lb_terror";
            this.lb_terror.Size = new System.Drawing.Size(0, 13);
            this.lb_terror.TabIndex = 49;
            // 
            // lb_drama
            // 
            this.lb_drama.AutoSize = true;
            this.lb_drama.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_drama.Location = new System.Drawing.Point(153, 123);
            this.lb_drama.Name = "lb_drama";
            this.lb_drama.Size = new System.Drawing.Size(0, 13);
            this.lb_drama.TabIndex = 48;
            // 
            // lbRomance
            // 
            this.lbRomance.AutoSize = true;
            this.lbRomance.ForeColor = System.Drawing.SystemColors.Control;
            this.lbRomance.Location = new System.Drawing.Point(153, 95);
            this.lbRomance.Name = "lbRomance";
            this.lbRomance.Size = new System.Drawing.Size(0, 13);
            this.lbRomance.TabIndex = 47;
            // 
            // lb_aventura
            // 
            this.lb_aventura.AutoSize = true;
            this.lb_aventura.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_aventura.Location = new System.Drawing.Point(152, 65);
            this.lb_aventura.Name = "lb_aventura";
            this.lb_aventura.Size = new System.Drawing.Size(0, 13);
            this.lb_aventura.TabIndex = 46;
            // 
            // lb_acao
            // 
            this.lb_acao.AutoSize = true;
            this.lb_acao.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_acao.Location = new System.Drawing.Point(152, 40);
            this.lb_acao.Name = "lb_acao";
            this.lb_acao.Size = new System.Drawing.Size(0, 13);
            this.lb_acao.TabIndex = 45;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.Control;
            this.label17.Location = new System.Drawing.Point(8, 275);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(131, 13);
            this.label17.TabIndex = 44;
            this.label17.Text = "Total ................. ->";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.ForeColor = System.Drawing.SystemColors.Control;
            this.label29.Location = new System.Drawing.Point(7, 249);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(130, 13);
            this.label29.TabIndex = 43;
            this.label29.Text = "Outro................. ->";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.ForeColor = System.Drawing.SystemColors.Control;
            this.label28.Location = new System.Drawing.Point(6, 222);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(132, 13);
            this.label28.TabIndex = 42;
            this.label28.Text = "Ficção ............... ->";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.ForeColor = System.Drawing.SystemColors.Control;
            this.label27.Location = new System.Drawing.Point(3, 198);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(133, 13);
            this.label27.TabIndex = 41;
            this.label27.Text = "Documentário.... ->";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ForeColor = System.Drawing.SystemColors.Control;
            this.label26.Location = new System.Drawing.Point(3, 175);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(134, 13);
            this.label26.TabIndex = 40;
            this.label26.Text = "Comédia............. ->";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.Control;
            this.label16.Location = new System.Drawing.Point(6, 147);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(128, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "Terror............... ->";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.Control;
            this.label15.Location = new System.Drawing.Point(6, 123);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(129, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Drama............... ->";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 13);
            this.label14.TabIndex = 5;
            this.label14.Text = "Romance........... ->";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.Control;
            this.label13.Location = new System.Drawing.Point(6, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(130, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Aventura........... ->";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(6, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Ação.................. ->";
            // 
            // lb_qtdfuncionários
            // 
            this.lb_qtdfuncionários.AutoSize = true;
            this.lb_qtdfuncionários.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_qtdfuncionários.Location = new System.Drawing.Point(488, 309);
            this.lb_qtdfuncionários.Name = "lb_qtdfuncionários";
            this.lb_qtdfuncionários.Size = new System.Drawing.Size(0, 13);
            this.lb_qtdfuncionários.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(383, 76);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(211, 18);
            this.label10.TabIndex = 1;
            this.label10.Text = "Quantidade de Clientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(50, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Quantidade de filmes";
            // 
            // FmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 462);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "FmUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar Alterar ou Excluir Usuario";
            this.Load += new System.EventHandler(this.FmUsuario_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.Retorna.ResumeLayout(false);
            this.Retorna.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Excluir)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.toolStrip3.ResumeLayout(false);
            this.toolStrip3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel tbDateTime;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_Cadastrar;
        private System.Windows.Forms.TextBox tb_confirmaSenha;
        private System.Windows.Forms.TextBox tb_SenhaCad;
        private System.Windows.Forms.TextBox tbLoginCad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbSenha;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_excluirUser;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_excluirUser;
        private System.Windows.Forms.DataGridView dg_Excluir;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Retornar;
        private System.Windows.Forms.ToolStrip Retorna;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Salvar;
        private System.Windows.Forms.TextBox tb_confirma;
        private System.Windows.Forms.TextBox tb_novaSenha;
        private System.Windows.Forms.TextBox tb_novoNome;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LbnomeAdm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lb_qtdfuncionários;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_outros;
        private System.Windows.Forms.Label lb_ficcao;
        private System.Windows.Forms.Label lb_documentario;
        private System.Windows.Forms.Label lb_comedia;
        private System.Windows.Forms.Label lb_terror;
        private System.Windows.Forms.Label lb_drama;
        private System.Windows.Forms.Label lbRomance;
        private System.Windows.Forms.Label lb_aventura;
        private System.Windows.Forms.Label lb_acao;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lb_qtddeclientes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_atrazados;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lb_locados;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ToolStrip toolStrip3;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}