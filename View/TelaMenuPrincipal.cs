using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ControleVendas.View
{
    public partial class TelaMenuPrincipal : Form
    {
        public TelaMenuPrincipal()
        {
            InitializeComponent();
        }

        private void TelaMenuPrincipal_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pegar a hora atual

            txtHora.Text = DateTime.Now.ToLongTimeString();
        }

        private void MCadastroClientes_Click(object sender, EventArgs e)
        {
            TelaClientes telaClientes = new TelaClientes();
            telaClientes.ShowDialog();
        }

        private void MConsultaClientes_Click(object sender, EventArgs e)
        {
            TelaClientes telaClientes = new TelaClientes();
            telaClientes.tabClientes.SelectedTab = telaClientes.tabConsulta;
            telaClientes.ShowDialog();
        }

        private void MCadastroFornecedores_Click(object sender, EventArgs e)
        {
            TelaFornecedores telaFornecedores = new TelaFornecedores();
            telaFornecedores.ShowDialog();

        }

        private void MConsultaFornecedores_Click(object sender, EventArgs e)
        {
            TelaFornecedores telaFornecedores = new TelaFornecedores();
            telaFornecedores.tabFornecedores.SelectedTab = telaFornecedores.tabConsulta;
            telaFornecedores.ShowDialog();
        }

        private void MCadastroProdutos_Click(object sender, EventArgs e)
        {
            TelaProdutos telaProdutos = new TelaProdutos();
            telaProdutos.ShowDialog();
        }

        private void MConsultaProdutos_Click(object sender, EventArgs e)
        {
            TelaProdutos telaProdutos = new TelaProdutos();
            telaProdutos.tabProdutos.SelectedTab = telaProdutos.tabConsulta;
            telaProdutos.ShowDialog();
        }

        private void MNovaVenda_Click(object sender, EventArgs e)
        {
            TelaVendas  telaVendas = new TelaVendas();
            telaVendas.ShowDialog();
        }

        private void MHistorico_Click(object sender, EventArgs e)
        {
            TelaHistoricoVendas telaHistoricoVendas = new TelaHistoricoVendas();
            telaHistoricoVendas.ShowDialog();
        }

        private void MSair_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Você realmente deseja sair?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes) 
            {
                Dispose();
            }
            
            
        }
    }
}
