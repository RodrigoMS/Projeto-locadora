namespace WindowsFormsApplication3
{
    partial class DevolverFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DevolverFilme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_tel = new System.Windows.Forms.Label();
            this.lb_cpf = new System.Windows.Forms.Label();
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_ficha = new System.Windows.Forms.Label();
            this.dgPesqLocadosD = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_codfilmeD = new System.Windows.Forms.TextBox();
            this.bt_Devolver = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesqLocadosD)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lb_tel);
            this.groupBox1.Controls.Add(this.lb_cpf);
            this.groupBox1.Controls.Add(this.lb_nome);
            this.groupBox1.Controls.Add(this.lb_ficha);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(7, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(626, 90);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // lb_tel
            // 
            this.lb_tel.AutoSize = true;
            this.lb_tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tel.Location = new System.Drawing.Point(19, 70);
            this.lb_tel.Name = "lb_tel";
            this.lb_tel.Size = new System.Drawing.Size(177, 17);
            this.lb_tel.TabIndex = 3;
            this.lb_tel.Text = "Telefone Para Contato:";
            // 
            // lb_cpf
            // 
            this.lb_cpf.AutoSize = true;
            this.lb_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cpf.Location = new System.Drawing.Point(450, 26);
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
            this.lb_ficha.Location = new System.Drawing.Point(19, 26);
            this.lb_ficha.Name = "lb_ficha";
            this.lb_ficha.Size = new System.Drawing.Size(57, 17);
            this.lb_ficha.TabIndex = 0;
            this.lb_ficha.Text = "Ficha: ";
            // 
            // dgPesqLocadosD
            // 
            this.dgPesqLocadosD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPesqLocadosD.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgPesqLocadosD.Location = new System.Drawing.Point(7, 195);
            this.dgPesqLocadosD.Name = "dgPesqLocadosD";
            this.dgPesqLocadosD.Size = new System.Drawing.Size(641, 189);
            this.dgPesqLocadosD.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(4, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 48;
            this.label2.Text = "Código do Filme";
            // 
            // tb_codfilmeD
            // 
            this.tb_codfilmeD.Location = new System.Drawing.Point(7, 148);
            this.tb_codfilmeD.Name = "tb_codfilmeD";
            this.tb_codfilmeD.Size = new System.Drawing.Size(156, 20);
            this.tb_codfilmeD.TabIndex = 49;
            // 
            // bt_Devolver
            // 
            this.bt_Devolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Devolver.Location = new System.Drawing.Point(208, 142);
            this.bt_Devolver.Name = "bt_Devolver";
            this.bt_Devolver.Size = new System.Drawing.Size(97, 31);
            this.bt_Devolver.TabIndex = 47;
            this.bt_Devolver.Text = "&Devolver";
            this.bt_Devolver.UseVisualStyleBackColor = true;
            this.bt_Devolver.Click += new System.EventHandler(this.bt_Devolver_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 405);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(645, 39);
            this.toolStrip1.TabIndex = 52;
            this.toolStrip1.Text = "toolStrip1";
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
            // DevolverFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(645, 444);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgPesqLocadosD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_codfilmeD);
            this.Controls.Add(this.bt_Devolver);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "DevolverFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Devolver filme";
            this.Load += new System.EventHandler(this.DevolverFilme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPesqLocadosD)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lb_cpf;
        private System.Windows.Forms.Label lb_nome;
        private System.Windows.Forms.Label lb_ficha;
        private System.Windows.Forms.DataGridView dgPesqLocadosD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_codfilmeD;
        private System.Windows.Forms.Button bt_Devolver;
        private System.Windows.Forms.Label lb_tel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}