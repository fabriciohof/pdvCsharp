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
    public partial class TelaFornecedores : Form
    {
        public TelaFornecedores()
        {
            InitializeComponent();
        }

        private void buBuscarCep_Click(object sender, EventArgs e)
        {
            //consultar cep pela api do viacep
            try
            {
                string cep = txtCep.Text;
                string xml = "https://viacep.com.br/ws/" + cep + "/xml/";

                DataSet dados = new DataSet(); //receber os dados da consulta
                dados.ReadXml(xml);

                //colocar entre aspas o que está no xml da API
                txtEndereco.Text = dados.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = dados.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = dados.Tables[0].Rows[0]["localidade"].ToString();
                txtComplemento.Text = dados.Tables[0].Rows[0]["complemento"].ToString();
                cbEstado.Text = dados.Tables[0].Rows[0]["uf"].ToString();

            }
            catch (Exception)
            {
                MessageBox.Show("Endereço não encontrado");

            }
        
    }

        private void buNovo_Click(object sender, EventArgs e)
        {
            new Metodos().limparCampos(this);   //limpar essa tela
        }

        private void buSalvar_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedor = new Fornecedores();
            FornecedorDAO fornecedorDao = new FornecedorDAO();

            fornecedor.nome = txtNome.Text;
            fornecedor.cnpj = txtCnpj.Text;
            fornecedor.email = txtEmail.Text;
            fornecedor.telefone = txtTelefone.Text;
            fornecedor.cep = txtCep.Text;
            fornecedor.endereco = txtEndereco.Text;
            fornecedor.numero = int.Parse(txtNumero.Text);
            fornecedor.complemento = txtComplemento.Text;
            fornecedor.bairro = txtBairro.Text;
            fornecedor.cidade = txtCidade.Text;
            fornecedor.estado = cbEstado.Text;


            fornecedorDao.CadastrarFornecedores(fornecedor);  //jogar no banco de dados
            tblFornecedores.DataSource = fornecedorDao.listarFornecedores();
            new Metodos().limparCampos(this);
        }

        private void TelaFornecedores_Load(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorDAO = new FornecedorDAO();
            tblFornecedores.DataSource = fornecedorDAO.listarFornecedores();
        }

        private void buAlterar_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedor = new Fornecedores();
            FornecedorDAO fornecedorDao = new FornecedorDAO();

            fornecedor.nome = txtNome.Text;
            fornecedor.cnpj = txtCnpj.Text;
            fornecedor.email = txtEmail.Text;
            fornecedor.telefone = txtTelefone.Text;
            fornecedor.cep = txtCep.Text;
            fornecedor.endereco = txtEndereco.Text;
            fornecedor.numero = int.Parse(txtNumero.Text);
            fornecedor.complemento = txtComplemento.Text;
            fornecedor.bairro = txtBairro.Text;
            fornecedor.cidade = txtCidade.Text;
            fornecedor.estado = cbEstado.Text;

            fornecedor.cod = int.Parse(txtCod.Text);

            fornecedorDao.AlterarFornecedores(fornecedor);  //jogar no banco de dados
            tblFornecedores.DataSource = fornecedorDao.listarFornecedores();
            new Metodos().limparCampos(this);
        }

        private void buExcluir_Click(object sender, EventArgs e)
        {
            Fornecedores fornecedor = new Fornecedores();
            FornecedorDAO fornecedorDAO = new FornecedorDAO();

            fornecedor.cod = int.Parse(txtCod.Text);

            fornecedorDAO.ExcluirFornecedores(fornecedor);
            tblFornecedores.DataSource = fornecedorDAO.listarFornecedores();
            new Metodos().limparCampos(this);
        }

        private void tblFornecedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegando dados da linha do fornecedor selecionado

            txtCod.Text = tblFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tblFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = tblFornecedores.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = tblFornecedores.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = tblFornecedores.CurrentRow.Cells[4].Value.ToString();
            txtCep.Text = tblFornecedores.CurrentRow.Cells[5].Value.ToString();
            txtEndereco.Text = tblFornecedores.CurrentRow.Cells[6].Value.ToString();
            txtNumero.Text = tblFornecedores.CurrentRow.Cells[7].Value.ToString();
            txtComplemento.Text = tblFornecedores.CurrentRow.Cells[8].Value.ToString();
            txtBairro.Text = tblFornecedores.CurrentRow.Cells[9].Value.ToString();
            txtCidade.Text = tblFornecedores.CurrentRow.Cells[10].Value.ToString();
            cbEstado.Text = tblFornecedores.CurrentRow.Cells[11].Value.ToString();


            tabFornecedores.SelectedTab = tabDados; // mudar aba após clicar na linha selecionada
        }

        private void buPesquisar_Click(object sender, EventArgs e)
        {
            FornecedorDAO fornecedorDao = new FornecedorDAO();

            string nome = txtNomeConsulta.Text;
            tblFornecedores.DataSource = fornecedorDao.BuscarFornecedor(nome);

            // não deixar a tabela vazia se não achar o nome
            if (tblFornecedores.Rows.Count == 0)
            {
                tblFornecedores.DataSource = fornecedorDao.listarFornecedores();
            }
        }

        private void txtNomeConsulta_TextChanged(object sender, EventArgs e)
        {
            // buscar os clientes por aproximação 

            FornecedorDAO fornecedorDao = new FornecedorDAO();

            string nome = "%" + txtNomeConsulta.Text + "%";
            tblFornecedores.DataSource = fornecedorDao.ListarFornecedorPorNome(nome);
        }
    }
}
