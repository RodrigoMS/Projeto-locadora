namespace WindowsFormsApplication3
{
    partial class LocarFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocarFilme));
            this.dgPesqLocados = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_codfilme = new System.Windows.Forms.TextBox();
            this.bt_locar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bt_pesqLocados = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbCodigoL = new System.Windows.Forms.RadioButton();
            this.rbNomeL = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_pesqL = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_ficha = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Retornar = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Ret = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.dg_historico = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_telH = new System.Windows.Forms.Label();
            this.lb_cpfH = new System.Windows.Forms.Label();
            this.lb_NomeH = new System.Windows.Forms.Label();
            this.lb_fichaH = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesqLocados)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.Ret.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_historico)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgPesqLocados
            // 
            this.dgPesqLocados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesqLocados.Location = new System.Drawing.Point(4, 203);
            this.dgPesqLocados.Name = "dgPesqLocados";
            this.dgPesqLocados.Size = new System.Drawing.Size(641, 152);
            this.dgPesqLocados.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(291, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Código do Filme";
            // 
            // tb_codfilme
            // 
            this.tb_codfilme.Location = new System.Drawing.Point(294, 388);
            this.tb_codfilme.Name = "tb_codfilme";
            this.tb_codfilme.Size = new System.Drawing.Size(156, 20);
            this.tb_codfilme.TabIndex = 45;
            // 
            // bt_locar
            // 
            this.bt_locar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_locar.Location = new System.Drawing.Point(505, 382);
            this.bt_locar.Name = "bt_locar";
            this.bt_locar.Size = new System.Drawing.Size(97, 31);
            this.bt_locar.TabIndex = 43;
            this.bt_locar.Text = "Locar";
            this.bt_locar.UseVisualStyleBackColor = true;
            this.bt_locar.Click += new System.EventHandler(this.bt_locar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bt_pesqLocados);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_pesqL);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(5, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(624, 98);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Locar Filme";
            // 
            // bt_pesqLocados
            // 
            this.bt_pesqLocados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_pesqLocados.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_pesqLocados.Location = new System.Drawing.Point(348, 33);
            this.bt_pesqLocados.Name = "bt_pesqLocados";
            this.bt_pesqLocados.Size = new System.Drawing.Size(97, 31);
            this.bt_pesqLocados.TabIndex = 41;
            this.bt_pesqLocados.Text = "Pesquisa";
            this.bt_pesqLocados.UseVisualStyleBackColor = true;
            this.bt_pesqLocados.Click += new System.EventHandler(this.bt_pesqLocados_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbCodigoL);
            this.groupBox3.Controls.Add(this.rbNomeL);
            this.groupBox3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(468, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 68);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo De Pesquisa";
            // 
            // rbCodigoL
            // 
            this.rbCodigoL.AutoSize = true;
            this.rbCodigoL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCodigoL.Location = new System.Drawing.Point(16, 22);
            this.rbCodigoL.Name = "rbCodigoL";
            this.rbCodigoL.Size = new System.Drawing.Size(104, 20);
            this.rbCodigoL.TabIndex = 34;
            this.rbCodigoL.Text = "Por Código";
            this.rbCodigoL.UseVisualStyleBackColor = true;
            // 
            // rbNomeL
            // 
            this.rbNomeL.AutoSize = true;
            this.rbNomeL.Checked = true;
            this.rbNomeL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNomeL.Location = new System.Drawing.Point(16, 42);
            this.rbNomeL.Name = "rbNomeL";
            this.rbNomeL.Size = new System.Drawing.Size(94, 20);
            this.rbNomeL.TabIndex = 32;
            this.rbNomeL.TabStop = true;
            this.rbNomeL.Text = "Por Titulo";
            this.rbNomeL.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Filme solicitado";
            // 
            // tb_pesqL
            // 
            this.tb_pesqL.Location = new System.Drawing.Point(9, 39);
            this.tb_pesqL.Name = "tb_pesqL";
            this.tb_pesqL.Size = new System.Drawing.Size(327, 20);
            this.tb_pesqL.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lb_cpf);
            this.groupBox1.Controls.Add(this.lb_nome);
            this.groupBox1.Controls.Add(this.lb_ficha);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 90);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Telefone Para Contato: ";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(499, 26);
            this.lb_cpf.Name = "lb_cpf";
            this.lb_cpf.Size = new System.Drawing.Size(47, 17);
            this.lb_cpf.TabIndex = 2;
            this.lb_cpf.Text = "CPF: ";
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_nome.Location = new System.Drawing.Point(139, 26);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(52, 17);
            this.lb_nome.TabIndex = 1;
            this.lb_nome.Text = "label2";
            // 
            // lb_ficha
            // 
            this.lb_ficha.AutoSize = true;
            this.lb_ficha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_ficha.Location = new System.Drawing.Point(71, 26);
            this.lb_ficha.Name = "lb_ficha";
            this.lb_ficha.Size = new System.Drawing.Size(57, 17);
            this.lb_ficha.TabIndex = 0;
            this.lb_ficha.Text = "Ficha: ";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(655, 456);
            this.tabControl1.TabIndex = 47;
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage1.BackgroundImage")));
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgPesqLocados);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.bt_locar);
            this.tabPage1.Controls.Add(this.tb_codfilme);
            this.tabPage1.Controls.Add(this.toolStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(647, 430);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Locar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Retornar});
            this.toolStrip1.Location = new System.Drawing.Point(3, 388);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(641, 39);
            this.toolStrip1.TabIndex = 47;
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
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabPage2.BackgroundImage")));
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.Ret);
            this.tabPage2.Controls.Add(this.dg_historico);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(647, 430);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Historico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Ret
            // 
            this.Ret.BackColor = System.Drawing.Color.Transparent;
            this.Ret.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Ret.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.Ret.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.Ret.Location = new System.Drawing.Point(3, 388);
            this.Ret.Name = "Ret";
            this.Ret.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Ret.Size = new System.Drawing.Size(641, 39);
            this.Ret.TabIndex = 48;
            this.Ret.Text = "toolStrip2";
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
            // dg_historico
            // 
            this.dg_historico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_historico.GridColor = System.Drawing.SystemColors.ControlText;
            this.dg_historico.Location = new System.Drawing.Point(15, 112);
            this.dg_historico.Name = "dg_historico";
            this.dg_historico.Size = new System.Drawing.Size(626, 271);
            this.dg_historico.TabIndex = 43;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_telH);
            this.groupBox4.Controls.Add(this.lb_cpfH);
            this.groupBox4.Controls.Add(this.lb_NomeH);
            this.groupBox4.Controls.Add(this.lb_fichaH);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Location = new System.Drawing.Point(15, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(626, 100);
            this.groupBox4.TabIndex = 42;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Cliente";
            // 
            // lb_telH
            // 
            this.lb_telH.AutoSize = true;
            this.lb_telH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_telH.Location = new System.Drawing.Point(19, 65);
            this.lb_telH.Name = "lb_telH";
            this.lb_telH.Size = new System.Drawing.Size(181, 17);
            this.lb_telH.TabIndex = 3;
            this.lb_telH.Text = "Telefone para Contato: ";
            // 
            // lb_cpfH
            // 
            this.lb_cpfH.AutoSize = true;
            this.lb_cpfH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpfH.Location = new System.Drawing.Point(450, 26);
            this.lb_cpfH.Name = "lb_cpfH";
            this.lb_cpfH.Size = new System.Drawing.Size(47, 17);
            this.lb_cpfH.TabIndex = 2;
            this.lb_cpfH.Text = "CPF: ";
            // 
            // lb_NomeH
            // 
            this.lb_NomeH.AutoSize = true;
            this.lb_NomeH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_NomeH.Location = new System.Drawing.Point(139, 26);
            this.lb_NomeH.Name = "lb_NomeH";
            this.lb_NomeH.Size = new System.Drawing.Size(52, 17);
            this.lb_NomeH.TabIndex = 1;
            this.lb_NomeH.Text = "label2";
            // 
            // lb_fichaH
            // 
            this.lb_fichaH.AutoSize = true;
            this.lb_fichaH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fichaH.Location = new System.Drawing.Point(19, 26);
            this.lb_fichaH.Name = "lb_fichaH";
            this.lb_fichaH.Size = new System.Drawing.Size(57, 17);
            this.lb_fichaH.TabIndex = 0;
            this.lb_fichaH.Text = "Ficha: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ficha: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(439, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "CPF: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Telefone Para Contato: ";
            // 
            // LocarFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 453);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LocarFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locar Filme";
            this.Load += new System.EventHandler(this.LocarFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPesqLocados)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.Ret.ResumeLayout(false);
            this.Ret.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_historico)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPesqLocados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_codfilme;
        private System.Windows.Forms.Button bt_locar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bt_pesqLocados;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbCodigoL;
        private System.Windows.Forms.RadioButton rbNomeL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_pesqL;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_ficha;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_cpfH;
        private System.Windows.Forms.Label lb_NomeH;
        private System.Windows.Forms.Label lb_fichaH;
        private System.Windows.Forms.Label lb_telH;
        private System.Windows.Forms.DataGridView dg_historico;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton Retornar;
        private System.Windows.Forms.ToolStrip Ret;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;

    }
}