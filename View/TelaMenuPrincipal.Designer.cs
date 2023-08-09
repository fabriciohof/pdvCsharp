namespace ControleVendas.View
{
    partial class TelaMenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MCadastroClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MConsultaClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.MFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MCadastroFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MConsultaFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.MProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MCadastroProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MConsultaProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.MVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.MNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.MHistorico = new System.Windows.Forms.ToolStripMenuItem();
            this.MConfiguracoes = new System.Windows.Forms.ToolStripMenuItem();
            this.MSair = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MClientes,
            this.MFornecedores,
            this.MProdutos,
            this.MVendas,
            this.MConfiguracoes});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 26);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MClientes
            // 
            this.MClientes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCadastroClientes,
            this.MConsultaClientes});
            this.MClientes.Image = global::ControleVendas.Properties.Resources.cliente1;
            this.MClientes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MClientes.Name = "MClientes";
            this.MClientes.Size = new System.Drawing.Size(79, 22);
            this.MClientes.Text = "Clientes";
            // 
            // MCadastroClientes
            // 
            this.MCadastroClientes.Name = "MCadastroClientes";
            this.MCadastroClientes.Size = new System.Drawing.Size(180, 22);
            this.MCadastroClientes.Text = "Cadastro ";
            this.MCadastroClientes.Click += new System.EventHandler(this.MCadastroClientes_Click);
            // 
            // MConsultaClientes
            // 
            this.MConsultaClientes.Name = "MConsultaClientes";
            this.MConsultaClientes.Size = new System.Drawing.Size(180, 22);
            this.MConsultaClientes.Text = "Consulta";
            this.MConsultaClientes.Click += new System.EventHandler(this.MConsultaClientes_Click);
            // 
            // MFornecedores
            // 
            this.MFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCadastroFornecedores,
            this.MConsultaFornecedores});
            this.MFornecedores.Image = global::ControleVendas.Properties.Resources.fornecedor__1_;
            this.MFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MFornecedores.Name = "MFornecedores";
            this.MFornecedores.Size = new System.Drawing.Size(108, 22);
            this.MFornecedores.Text = "Fornecedores";
            // 
            // MCadastroFornecedores
            // 
            this.MCadastroFornecedores.Name = "MCadastroFornecedores";
            this.MCadastroFornecedores.Size = new System.Drawing.Size(180, 22);
            this.MCadastroFornecedores.Text = "Cadastro";
            this.MCadastroFornecedores.Click += new System.EventHandler(this.MCadastroFornecedores_Click);
            // 
            // MConsultaFornecedores
            // 
            this.MConsultaFornecedores.Name = "MConsultaFornecedores";
            this.MConsultaFornecedores.Size = new System.Drawing.Size(180, 22);
            this.MConsultaFornecedores.Text = "Consulta";
            this.MConsultaFornecedores.Click += new System.EventHandler(this.MConsultaFornecedores_Click);
            // 
            // MProdutos
            // 
            this.MProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MCadastroProdutos,
            this.MConsultaProdutos});
            this.MProdutos.Image = global::ControleVendas.Properties.Resources.caixa__1_;
            this.MProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MProdutos.Name = "MProdutos";
            this.MProdutos.Size = new System.Drawing.Size(85, 22);
            this.MProdutos.Text = "Produtos";
            // 
            // MCadastroProdutos
            // 
            this.MCadastroProdutos.Name = "MCadastroProdutos";
            this.MCadastroProdutos.Size = new System.Drawing.Size(180, 22);
            this.MCadastroProdutos.Text = "Cadastro";
            this.MCadastroProdutos.Click += new System.EventHandler(this.MCadastroProdutos_Click);
            // 
            // MConsultaProdutos
            // 
            this.MConsultaProdutos.Name = "MConsultaProdutos";
            this.MConsultaProdutos.Size = new System.Drawing.Size(180, 22);
            this.MConsultaProdutos.Text = "Consulta";
            this.MConsultaProdutos.Click += new System.EventHandler(this.MConsultaProdutos_Click);
            // 
            // MVendas
            // 
            this.MVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MNovaVenda,
            this.MHistorico});
            this.MVendas.Image = global::ControleVendas.Properties.Resources.venda;
            this.MVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MVendas.Name = "MVendas";
            this.MVendas.Size = new System.Drawing.Size(74, 22);
            this.MVendas.Text = "Vendas";
            // 
            // MNovaVenda
            // 
            this.MNovaVenda.Name = "MNovaVenda";
            this.MNovaVenda.Size = new System.Drawing.Size(180, 22);
            this.MNovaVenda.Text = "Nova Venda";
            this.MNovaVenda.Click += new System.EventHandler(this.MNovaVenda_Click);
            // 
            // MHistorico
            // 
            this.MHistorico.Name = "MHistorico";
            this.MHistorico.Size = new System.Drawing.Size(180, 22);
            this.MHistorico.Text = "Histórico ";
            this.MHistorico.Click += new System.EventHandler(this.MHistorico_Click);
            // 
            // MConfiguracoes
            // 
            this.MConfiguracoes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MSair});
            this.MConfiguracoes.Image = global::ControleVendas.Properties.Resources.settings__1_;
            this.MConfiguracoes.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MConfiguracoes.Name = "MConfiguracoes";
            this.MConfiguracoes.Size = new System.Drawing.Size(114, 22);
            this.MConfiguracoes.Text = "Configurações";
            // 
            // MSair
            // 
            this.MSair.Name = "MSair";
            this.MSair.Size = new System.Drawing.Size(180, 22);
            this.MSair.Text = "Sair";
            this.MSair.Click += new System.EventHandler(this.MSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.txtData,
            this.toolStripStatusLabel4,
            this.txtHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(67, 17);
            this.toolStripStatusLabel1.Text = "Data atual :";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 17);
            // 
            // txtData
            // 
            this.txtData.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtData.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel4.Text = "Hora :";
            // 
            // txtHora
            // 
            this.txtHora.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TelaMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::ControleVendas.Properties.Resources._9099__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaMenuPrincipal";
            this.Text = "Menu Principal - Controle de Vendas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TelaMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MClientes;
        private System.Windows.Forms.ToolStripMenuItem MCadastroClientes;
        private System.Windows.Forms.ToolStripMenuItem MConsultaClientes;
        private System.Windows.Forms.ToolStripMenuItem MFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MCadastroFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MConsultaFornecedores;
        private System.Windows.Forms.ToolStripMenuItem MProdutos;
        private System.Windows.Forms.ToolStripMenuItem MCadastroProdutos;
        private System.Windows.Forms.ToolStripMenuItem MConsultaProdutos;
        private System.Windows.Forms.ToolStripMenuItem MVendas;
        private System.Windows.Forms.ToolStripMenuItem MNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem MHistorico;
        private System.Windows.Forms.ToolStripMenuItem MConfiguracoes;
        private System.Windows.Forms.ToolStripMenuItem MSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel txtData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
        private System.Windows.Forms.Timer timer1;
    }
}