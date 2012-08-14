namespace WindowsFormsApplication3
{
    partial class AlterarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlterarCliente));
            this.tb_Data_de_nacimento = new System.Windows.Forms.MaskedTextBox();
            this.tb_Telefone = new System.Windows.Forms.MaskedTextBox();
            this.BtCancelCliente = new System.Windows.Forms.Button();
            this.BtAlteraCliente = new System.Windows.Forms.Button();
            this.Tb_Estado = new System.Windows.Forms.ComboBox();
            this.Tb_Cidade = new System.Windows.Forms.ComboBox();
            this.Estado = new System.Windows.Forms.Label();
            this.Cidade = new System.Windows.Forms.Label();
            this.CEP = new System.Windows.Forms.Label();
            this.tb_Bairro = new System.Windows.Forms.TextBox();
            this.Bairro = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.Label();
            this.tb_Logradouro = new System.Windows.Forms.TextBox();
            this.Logradouro = new System.Windows.Forms.Label();
            this.tb_Numero = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.Label();
            this.Data_de_nacimento = new System.Windows.Forms.Label();
            this.tb_Nome = new System.Windows.Forms.TextBox();
            this.Nome = new System.Windows.Forms.Label();
            this.CPF = new System.Windows.Forms.Label();
            this.tb_CPF = new System.Windows.Forms.MaskedTextBox();
            this.tb_CEP = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // tb_Data_de_nacimento
            // 
            this.tb_Data_de_nacimento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Data_de_nacimento.Location = new System.Drawing.Point(515, 50);
            this.tb_Data_de_nacimento.Mask = "00/00/0000";
            this.tb_Data_de_nacimento.Name = "tb_Data_de_nacimento";
            this.tb_Data_de_nacimento.Size = new System.Drawing.Size(88, 20);
            this.tb_Data_de_nacimento.TabIndex = 74;
            this.tb_Data_de_nacimento.ValidatingType = typeof(System.DateTime);
            // 
            // tb_Telefone
            // 
            this.tb_Telefone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Telefone.Location = new System.Drawing.Point(515, 99);
            this.tb_Telefone.Mask = "(99) 0000-0000";
            this.tb_Telefone.Name = "tb_Telefone";
            this.tb_Telefone.Size = new System.Drawing.Size(88, 20);
            this.tb_Telefone.TabIndex = 73;
            // 
            // BtCancelCliente
            // 
            this.BtCancelCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtCancelCliente.Location = new System.Drawing.Point(492, 245);
            this.BtCancelCliente.Name = "BtCancelCliente";
            this.BtCancelCliente.Size = new System.Drawing.Size(111, 39);
            this.BtCancelCliente.TabIndex = 72;
            this.BtCancelCliente.Text = "Cancelar";
            this.BtCancelCliente.UseVisualStyleBackColor = true;
            this.BtCancelCliente.Click += new System.EventHandler(this.BtCancelCliente_Click);
            // 
            // BtAlteraCliente
            // 
            this.BtAlteraCliente.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAlteraCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtAlteraCliente.Location = new System.Drawing.Point(326, 245);
            this.BtAlteraCliente.Name = "BtAlteraCliente";
            this.BtAlteraCliente.Size = new System.Drawing.Size(117, 39);
            this.BtAlteraCliente.TabIndex = 71;
            this.BtAlteraCliente.Text = "Alterar";
            this.BtAlteraCliente.UseVisualStyleBackColor = true;
            this.BtAlteraCliente.Click += new System.EventHandler(this.BtAlteraCliente_Click);
            // 
            // Tb_Estado
            // 
            this.Tb_Estado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Estado.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tb_Estado.FormattingEnabled = true;
            this.Tb_Estado.Items.AddRange(new object[] {
            "SP",
            "MG"});
            this.Tb_Estado.Location = new System.Drawing.Point(548, 144);
            this.Tb_Estado.Name = "Tb_Estado";
            this.Tb_Estado.Size = new System.Drawing.Size(55, 24);
            this.Tb_Estado.TabIndex = 70;
            // 
            // Tb_Cidade
            // 
            this.Tb_Cidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tb_Cidade.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Tb_Cidade.FormattingEnabled = true;
            this.Tb_Cidade.Items.AddRange(new object[] {
            "Americanas",
            "Catanduva",
            "Jales",
            "Mirassol",
            "São José do Rio Preto",
            "Mococa",
            "Neves Paulista",
            "Monte Aprazível",
            "Sebastianópolis do Sul",
            "Pereira Barreto",
            "Ilha Solteira",
            "Presidente Prudente",
            "Marilia",
            "Bauru",
            "São Paulo",
            "Belo Horizonte",
            "Araxá",
            "Uberaba",
            "Uberlândia",
            "Frutal",
            "Pouso Alegre",
            "Alfenas",
            "Brás Pires",
            "Camacho",
            "Coimbra",
            "Riachinho",
            "Poços de Caldas",
            "Nova Cruzeiro",
            "Medina",
            "Lagamar",
            "Campos do Jordão"});
            this.Tb_Cidade.Location = new System.Drawing.Point(323, 195);
            this.Tb_Cidade.Name = "Tb_Cidade";
            this.Tb_Cidade.Size = new System.Drawing.Size(280, 24);
            this.Tb_Cidade.TabIndex = 69;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.BackColor = System.Drawing.Color.Transparent;
            this.Estado.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.ForeColor = System.Drawing.SystemColors.Control;
            this.Estado.Location = new System.Drawing.Point(484, 152);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(58, 16);
            this.Estado.TabIndex = 68;
            this.Estado.Text = "Estado";
            // 
            // Cidade
            // 
            this.Cidade.AutoSize = true;
            this.Cidade.BackColor = System.Drawing.Color.Transparent;
            this.Cidade.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cidade.ForeColor = System.Drawing.SystemColors.Control;
            this.Cidade.Location = new System.Drawing.Point(259, 199);
            this.Cidade.Name = "Cidade";
            this.Cidade.Size = new System.Drawing.Size(58, 16);
            this.Cidade.TabIndex = 67;
            this.Cidade.Text = "Cidade";
            // 
            // CEP
            // 
            this.CEP.AutoSize = true;
            this.CEP.BackColor = System.Drawing.Color.Transparent;
            this.CEP.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEP.ForeColor = System.Drawing.SystemColors.Control;
            this.CEP.Location = new System.Drawing.Point(328, 151);
            this.CEP.Name = "CEP";
            this.CEP.Size = new System.Drawing.Size(36, 16);
            this.CEP.TabIndex = 65;
            this.CEP.Text = "CEP";
            // 
            // tb_Bairro
            // 
            this.tb_Bairro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Bairro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Bairro.Location = new System.Drawing.Point(71, 96);
            this.tb_Bairro.Name = "tb_Bairro";
            this.tb_Bairro.Size = new System.Drawing.Size(367, 23);
            this.tb_Bairro.TabIndex = 64;
            // 
            // Bairro
            // 
            this.Bairro.AutoSize = true;
            this.Bairro.BackColor = System.Drawing.Color.Transparent;
            this.Bairro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bairro.ForeColor = System.Drawing.SystemColors.Control;
            this.Bairro.Location = new System.Drawing.Point(9, 103);
            this.Bairro.Name = "Bairro";
            this.Bairro.Size = new System.Drawing.Size(52, 16);
            this.Bairro.TabIndex = 63;
            this.Bairro.Text = "Bairro";
            // 
            // Numero
            // 
            this.Numero.AutoSize = true;
            this.Numero.BackColor = System.Drawing.Color.Transparent;
            this.Numero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Numero.ForeColor = System.Drawing.SystemColors.Control;
            this.Numero.Location = new System.Drawing.Point(12, 203);
            this.Numero.Name = "Numero";
            this.Numero.Size = new System.Drawing.Size(65, 16);
            this.Numero.TabIndex = 62;
            this.Numero.Text = "Numero";
            // 
            // tb_Logradouro
            // 
            this.tb_Logradouro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Logradouro.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Logradouro.Location = new System.Drawing.Point(106, 148);
            this.tb_Logradouro.Name = "tb_Logradouro";
            this.tb_Logradouro.Size = new System.Drawing.Size(211, 23);
            this.tb_Logradouro.TabIndex = 61;
            // 
            // Logradouro
            // 
            this.Logradouro.AutoSize = true;
            this.Logradouro.BackColor = System.Drawing.Color.Transparent;
            this.Logradouro.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Logradouro.ForeColor = System.Drawing.SystemColors.Control;
            this.Logradouro.Location = new System.Drawing.Point(9, 151);
            this.Logradouro.Name = "Logradouro";
            this.Logradouro.Size = new System.Drawing.Size(91, 16);
            this.Logradouro.TabIndex = 60;
            this.Logradouro.Text = "Logradouro";
            // 
            // tb_Numero
            // 
            this.tb_Numero.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Numero.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Numero.Location = new System.Drawing.Point(106, 196);
            this.tb_Numero.Name = "tb_Numero";
            this.tb_Numero.Size = new System.Drawing.Size(137, 23);
            this.tb_Numero.TabIndex = 59;
            // 
            // Telefone
            // 
            this.Telefone.AutoSize = true;
            this.Telefone.BackColor = System.Drawing.Color.Transparent;
            this.Telefone.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.ForeColor = System.Drawing.SystemColors.Control;
            this.Telefone.Location = new System.Drawing.Point(439, 103);
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(70, 16);
            this.Telefone.TabIndex = 58;
            this.Telefone.Text = "Telefone";
            // 
            // Data_de_nacimento
            // 
            this.Data_de_nacimento.AutoSize = true;
            this.Data_de_nacimento.BackColor = System.Drawing.Color.Transparent;
            this.Data_de_nacimento.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_de_nacimento.ForeColor = System.Drawing.SystemColors.Control;
            this.Data_de_nacimento.Location = new System.Drawing.Point(364, 54);
            this.Data_de_nacimento.Name = "Data_de_nacimento";
            this.Data_de_nacimento.Size = new System.Drawing.Size(145, 16);
            this.Data_de_nacimento.TabIndex = 57;
            this.Data_de_nacimento.Text = "Data de nacimento";
            // 
            // tb_Nome
            // 
            this.tb_Nome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Nome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tb_Nome.Location = new System.Drawing.Point(71, 50);
            this.tb_Nome.Name = "tb_Nome";
            this.tb_Nome.Size = new System.Drawing.Size(293, 23);
            this.tb_Nome.TabIndex = 56;
            // 
            // Nome
            // 
            this.Nome.AutoSize = true;
            this.Nome.BackColor = System.Drawing.Color.Transparent;
            this.Nome.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.ForeColor = System.Drawing.SystemColors.Control;
            this.Nome.Location = new System.Drawing.Point(9, 54);
            this.Nome.Name = "Nome";
            this.Nome.Size = new System.Drawing.Size(50, 16);
            this.Nome.TabIndex = 55;
            this.Nome.Text = "Nome";
            // 
            // CPF
            // 
            this.CPF.AutoSize = true;
            this.CPF.BackColor = System.Drawing.Color.Transparent;
            this.CPF.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.ForeColor = System.Drawing.SystemColors.Control;
            this.CPF.Location = new System.Drawing.Point(9, 245);
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(36, 16);
            this.CPF.TabIndex = 53;
            this.CPF.Text = "CPF";
            // 
            // tb_CPF
            // 
            this.tb_CPF.Location = new System.Drawing.Point(71, 241);
            this.tb_CPF.Mask = "999-000-000-00";
            this.tb_CPF.Name = "tb_CPF";
            this.tb_CPF.Size = new System.Drawing.Size(100, 20);
            this.tb_CPF.TabIndex = 75;
            // 
            // tb_CEP
            // 
            this.tb_CEP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_CEP.Location = new System.Drawing.Point(379, 148);
            this.tb_CEP.Name = "tb_CEP";
            this.tb_CEP.Size = new System.Drawing.Size(87, 23);
            this.tb_CEP.TabIndex = 76;
            // 
            // AlterarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(609, 293);
            this.Controls.Add(this.tb_CEP);
            this.Controls.Add(this.tb_CPF);
            this.Controls.Add(this.tb_Data_de_nacimento);
            this.Controls.Add(this.tb_Telefone);
            this.Controls.Add(this.BtCancelCliente);
            this.Controls.Add(this.BtAlteraCliente);
            this.Controls.Add(this.Tb_Estado);
            this.Controls.Add(this.Tb_Cidade);
            this.Controls.Add(this.Estado);
            this.Controls.Add(this.Cidade);
            this.Controls.Add(this.CEP);
            this.Controls.Add(this.tb_Bairro);
            this.Controls.Add(this.Bairro);
            this.Controls.Add(this.Numero);
            this.Controls.Add(this.tb_Logradouro);
            this.Controls.Add(this.Logradouro);
            this.Controls.Add(this.tb_Numero);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Data_de_nacimento);
            this.Controls.Add(this.tb_Nome);
            this.Controls.Add(this.Nome);
            this.Controls.Add(this.CPF);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AlterarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alterar Cliente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AlterarCliente_FormClosing);
            this.Load += new System.EventHandler(this.AlterarCliente_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox tb_Data_de_nacimento;
        private System.Windows.Forms.MaskedTextBox tb_Telefone;
        private System.Windows.Forms.Button BtCancelCliente;
        private System.Windows.Forms.Button BtAlteraCliente;
        private System.Windows.Forms.ComboBox Tb_Estado;
        private System.Windows.Forms.ComboBox Tb_Cidade;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Label Cidade;
        private System.Windows.Forms.Label CEP;
        private System.Windows.Forms.TextBox tb_Bairro;
        private System.Windows.Forms.Label Bairro;
        private System.Windows.Forms.Label Numero;
        private System.Windows.Forms.TextBox tb_Logradouro;
        private System.Windows.Forms.Label Logradouro;
        private System.Windows.Forms.TextBox tb_Numero;
        private System.Windows.Forms.Label Telefone;
        private System.Windows.Forms.Label Data_de_nacimento;
        private System.Windows.Forms.TextBox tb_Nome;
        private System.Windows.Forms.Label Nome;
        private System.Windows.Forms.Label CPF;
        private System.Windows.Forms.MaskedTextBox tb_CPF;
        private System.Windows.Forms.MaskedTextBox tb_CEP;
    }
}