using ControleVendas.Dao;
using ControleVendas.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.View
{
    public partial class TelaProdutos : Form
    {
        public TelaProdutos()
        {
            InitializeComponent();
        }

        private void TelaProdutos_Load(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();
            cbFornecedor.DataSource = fornecedorDao.listarFornecedores();
            // preencher os fornecedores no combo box

            cbFornecedor.DisplayMember = "nome";   // coluna que irá aparecer
            cbFornecedor.ValueMember = "id";       // valor

            ProdutoDAO produtoDAO = new ProdutoDAO();   

            tblProdutos.DataSource = produtoDAO.listarProdutos();

        }

        private void buSalvar_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            ProdutoDAO produtoDao = new ProdutoDAO();

            produto.descricao = txtDescricao.Text;
            produto.preco = decimal.Parse(txtPreco.Text);
            produto.estoque = int.Parse(txtEstoque.Text);
            produto.for_id = int.Parse(cbFornecedor.SelectedValue.ToString());

            

            produtoDao.CadastrarProdutos(produto);
            tblProdutos.DataSource = produtoDao.listarProdutos();
            new Metodos().limparCampos(this);



        }

        private void buNovo_Click(object sender, EventArgs e)
        {
            new Metodos().limparCampos(this);
        }

        private void tblProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCod.Text = tblProdutos.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = tblProdutos.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tblProdutos.CurrentRow.Cells[2].Value.ToString();
            txtEstoque.Text = tblProdutos.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = tblProdutos.CurrentRow.Cells[4].Value.ToString();

            tabProdutos.SelectedTab = tabDados;      //mudar de aba automatico  
        }

        private void buAlterar_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            ProdutoDAO produtoDao = new ProdutoDAO();

            produto.descricao = txtDescricao.Text;
            produto.preco = decimal.Parse(txtPreco.Text);
            produto.estoque = int.Parse(txtEstoque.Text);
            produto.for_id = int.Parse(cbFornecedor.SelectedValue.ToString());

            produto.id = int.Parse(txtCod.Text);

            
            produtoDao.AlterarProdutos(produto);
            tblProdutos.DataSource = produtoDao.listarProdutos();
            new Metodos().limparCampos(this);

        }

        private void buExcluir_Click(object sender, EventArgs e)
        {
            Produtos produto = new Produtos();
            ProdutoDAO produtoDao = new ProdutoDAO();

            produto.id = int.Parse(txtCod.Text);

            produtoDao.ExcluirProdutos(produto);
            tblProdutos.DataSource = produtoDao.listarProdutos();
            new Metodos().limparCampos(this);
        }

        private void txtNomeConsulta_TextChanged(object sender, EventArgs e)
        {
            ProdutoDAO produtoDao = new ProdutoDAO();
            string nome = "%" + txtNomeConsulta.Text + "%";
            
            tblProdutos.DataSource = produtoDao.BuscarProdutos(nome);

        }

        private void buPesquisar_Click(object sender, EventArgs e)
        {
            ProdutoDAO produtoDao = new ProdutoDAO();
            string nome = txtNomeConsulta.Text;

            tblProdutos.DataSource = produtoDao.ListarProdutoPorNome(nome);
            tblProdutos.DataSource = produtoDao.listarProdutos();
        }
    }
}
