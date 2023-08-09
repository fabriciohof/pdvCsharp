namespace ControleVendas.View
{
    partial class TelaFornecedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabFornecedores = new System.Windows.Forms.TabControl();
            this.tabDados = new System.Windows.Forms.TabPage();
            this.buBuscarCep = new System.Windows.Forms.Button();
            this.cbEstado = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComplemento = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCep = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCnpj = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabConsulta = new System.Windows.Forms.TabPage();
            this.tblFornecedores = new System.Windows.Forms.DataGridView();
            this.buPesquisar = new System.Windows.Forms.Button();
            this.txtNomeConsulta = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.buAlterar = new System.Windows.Forms.Button();
            this.buExcluir = new System.Windows.Forms.Button();
            this.buSalvar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabFornecedores.SuspendLayout();
            this.tabDados.SuspendLayout();
            this.tabConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFornecedores)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de Fornecedores";
            // 
            // tabFornecedores
            // 
            this.tabFornecedores.Controls.Add(this.tabDados);
            this.tabFornecedores.Controls.Add(this.tabConsulta);
            this.tabFornecedores.Location = new System.Drawing.Point(0, 92);
            this.tabFornecedores.Name = "tabFornecedores";
            this.tabFornecedores.SelectedIndex = 0;
            this.tabFornecedores.Size = new System.Drawing.Size(800, 334);
            this.tabFornecedores.TabIndex = 2;
            // 
            // tabDados
            // 
            this.tabDados.Controls.Add(this.buBuscarCep);
            this.tabDados.Controls.Add(this.cbEstado);
            this.tabDados.Controls.Add(this.label12);
            this.tabDados.Controls.Add(this.txtCidade);
            this.tabDados.Controls.Add(this.label13);
            this.tabDados.Controls.Add(this.txtBairro);
            this.tabDados.Controls.Add(this.label10);
            this.tabDados.Controls.Add(this.txtComplemento);
            this.tabDados.Controls.Add(this.label11);
            this.tabDados.Controls.Add(this.txtNumero);
            this.tabDados.Controls.Add(this.label8);
            this.tabDados.Controls.Add(this.txtEndereco);
            this.tabDados.Controls.Add(this.label9);
            this.tabDados.Controls.Add(this.txtCep);
            this.tabDados.Controls.Add(this.label7);
            this.tabDados.Controls.Add(this.txtEmail);
            this.tabDados.Controls.Add(this.label4);
            this.tabDados.Controls.Add(this.txtTelefone);
            this.tabDados.Controls.Add(this.label6);
            this.tabDados.Controls.Add(this.txtCnpj);
            this.tabDados.Controls.Add(this.label5);
            this.tabDados.Controls.Add(this.txtNome);
            this.tabDados.Controls.Add(this.label3);
            this.tabDados.Controls.Add(this.txtCod);
            this.tabDados.Controls.Add(this.label2);
            this.tabDados.Location = new System.Drawing.Point(4, 22);
            this.tabDados.Name = "tabDados";
            this.tabDados.Padding = new System.Windows.Forms.Padding(3);
            this.tabDados.Size = new System.Drawing.Size(792, 308);
            this.tabDados.TabIndex = 0;
            this.tabDados.Text = "Dados";
            this.tabDados.UseVisualStyleBackColor = true;
            // 
            // buBuscarCep
            // 
            this.buBuscarCep.Location = new System.Drawing.Point(458, 60);
            this.buBuscarCep.Name = "buBuscarCep";
            this.buBuscarCep.Size = new System.Drawing.Size(75, 23);
            this.buBuscarCep.TabIndex = 6;
            this.buBuscarCep.Text = "Buscar";
            this.buBuscarCep.UseVisualStyleBackColor = true;
            this.buBuscarCep.Click += new System.EventHandler(this.buBuscarCep_Click);
            // 
            // cbEstado
            // 
            this.cbEstado.FormattingEnabled = true;
            this.cbEstado.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AP",
            "AM",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MT",
            "MS",
            "MG",
            "PA",
            "PB",
            "PR",
            "PE",
            "PI",
            "RJ",
            "RN",
            "RS",
            "RO",
            "RR",
            "SC",
            "SP",
            "SE",
            "TO"});
            this.cbEstado.Location = new System.Drawing.Point(605, 188);
            this.cbEstado.Name = "cbEstado";
            this.cbEstado.Size = new System.Drawing.Size(39, 21);
            this.cbEstado.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(538, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Estado :";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(605, 149);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(100, 20);
            this.txtCidade.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(538, 149);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Cidade :";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(389, 195);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(91, 20);
            this.txtBairro.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(306, 195);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Bairro :";
            // 
            // txtComplemento
            // 
            this.txtComplemento.Location = new System.Drawing.Point(389, 146);
            this.txtComplemento.Name = "txtComplemento";
            this.txtComplemento.Size = new System.Drawing.Size(91, 20);
            this.txtComplemento.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(306, 149);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Complemento :";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(557, 108);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(26, 20);
            this.txtNumero.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Número :";
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(373, 106);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(107, 20);
            this.txtEndereco.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "Endereço :";
            // 
            // txtCep
            // 
            this.txtCep.Location = new System.Drawing.Point(373, 62);
            this.txtCep.Mask = "00000-999";
            this.txtCep.Name = "txtCep";
            this.txtCep.Size = new System.Drawing.Size(65, 20);
            this.txtCep.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(306, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "CEP :";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(115, 231);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(111, 20);
            this.txtEmail.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Email :";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(115, 190);
            this.txtTelefone.Mask = "(99) 0 0000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(111, 20);
            this.txtTelefone.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Telefone :";
            // 
            // txtCnpj
            // 
            this.txtCnpj.Location = new System.Drawing.Point(115, 149);
            this.txtCnpj.Mask = "##,###,###/####-##";
            this.txtCnpj.Name = "txtCnpj";
            this.txtCnpj.Size = new System.Drawing.Size(111, 20);
            this.txtCnpj.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "CNPJ :";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(115, 108);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(111, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nome :";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(115, 62);
            this.txtCod.Name = "txtCod";
            this.txtCod.ReadOnly = true;
            this.txtCod.Size = new System.Drawing.Size(28, 20);
            this.txtCod.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Cód :";
            // 
            // tabConsulta
            // 
            this.tabConsulta.Controls.Add(this.tblFornecedores);
            this.tabConsulta.Controls.Add(this.buPesquisar);
            this.tabConsulta.Controls.Add(this.txtNomeConsulta);
            this.tabConsulta.Controls.Add(this.label14);
            this.tabConsulta.Location = new System.Drawing.Point(4, 22);
            this.tabConsulta.Name = "tabConsulta";
            this.tabConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tabConsulta.Size = new System.Drawing.Size(792, 308);
            this.tabConsulta.TabIndex = 1;
            this.tabConsulta.Text = "Consulta";
            this.tabConsulta.UseVisualStyleBackColor = true;
            // 
            // tblFornecedores
            // 
            this.tblFornecedores.AllowUserToAddRows = false;
            this.tblFornecedores.AllowUserToDeleteRows = false;
            this.tblFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblFornecedores.Location = new System.Drawing.Point(19, 46);
            this.tblFornecedores.Name = "tblFornecedores";
            this.tblFornecedores.ReadOnly = true;
            this.tblFornecedores.Size = new System.Drawing.Size(753, 227);
            this.tblFornecedores.TabIndex = 7;
            this.tblFornecedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblFornecedores_CellClick);
            // 
            // buPesquisar
            // 
            this.buPesquisar.Location = new System.Drawing.Point(425, 6);
            this.buPesquisar.Name = "buPesquisar";
            this.buPesquisar.Size = new System.Drawing.Size(75, 23);
            this.buPesquisar.TabIndex = 6;
            this.buPesquisar.Text = "Buscar";
            this.buPesquisar.UseVisualStyleBackColor = true;
            this.buPesquisar.Click += new System.EventHandler(this.buPesquisar_Click);
            // 
            // txtNomeConsulta
            // 
            this.txtNomeConsulta.Location = new System.Drawing.Point(265, 6);
            this.txtNomeConsulta.Name = "txtNomeConsulta";
            this.txtNomeConsulta.Size = new System.Drawing.Size(117, 20);
            this.txtNomeConsulta.TabIndex = 5;
            this.txtNomeConsulta.TextChanged += new System.EventHandler(this.txtNomeConsulta_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(218, 9);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Nome :";
            // 
            // buAlterar
            // 
            this.buAlterar.Location = new System.Drawing.Point(355, 447);
            this.buAlterar.Name = "buAlterar";
            this.buAlterar.Size = new System.Drawing.Size(75, 23);
            this.buAlterar.TabIndex = 9;
            this.buAlterar.Text = "Alterar";
            this.buAlterar.UseVisualStyleBackColor = true;
            this.buAlterar.Click += new System.EventHandler(this.buAlterar_Click);
            // 
            // buExcluir
            // 
            this.buExcluir.Location = new System.Drawing.Point(513, 447);
            this.buExcluir.Name = "buExcluir";
            this.buExcluir.Size = new System.Drawing.Size(75, 23);
            this.buExcluir.TabIndex = 8;
            this.buExcluir.Text = "Excluir";
            this.buExcluir.UseVisualStyleBackColor = true;
            this.buExcluir.Click += new System.EventHandler(this.buExcluir_Click);
            // 
            // buSalvar
            // 
            this.buSalvar.Location = new System.Drawing.Point(195, 447);
            this.buSalvar.Name = "buSalvar";
            this.buSalvar.Size = new System.Drawing.Size(75, 23);
            this.buSalvar.TabIndex = 7;
            this.buSalvar.Text = "Salvar";
            this.buSalvar.UseVisualStyleBackColor = true;
            this.buSalvar.Click += new System.EventHandler(this.buSalvar_Click);
            // 
            // TelaFornecedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 491);
            this.Controls.Add(this.buAlterar);
            this.Controls.Add(this.buExcluir);
            this.Controls.Add(this.buSalvar);
            this.Controls.Add(this.tabFornecedores);
            this.Controls.Add(this.panel1);
            this.Name = "TelaFornecedores";
            this.Text = "TelaFornecedores";
            this.Load += new System.EventHandler(this.TelaFornecedores_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabFornecedores.ResumeLayout(false);
            this.tabDados.ResumeLayout(false);
            this.tabDados.PerformLayout();
            this.tabConsulta.ResumeLayout(false);
            this.tabConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblFornecedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buBuscarCep;
        private System.Windows.Forms.ComboBox cbEstado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComplemento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox txtCep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox txtCnpj;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView tblFornecedores;
        private System.Windows.Forms.Button buPesquisar;
        private System.Windows.Forms.TextBox txtNomeConsulta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button buAlterar;
        private System.Windows.Forms.Button buExcluir;
        private System.Windows.Forms.Button buSalvar;
        public System.Windows.Forms.TabControl tabFornecedores;
        public System.Windows.Forms.TabPage tabDados;
        public System.Windows.Forms.TabPage tabConsulta;
    }
}