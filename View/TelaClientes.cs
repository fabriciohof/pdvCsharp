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
    public partial class TelaClientes : Form
    {
        public TelaClientes()
        {
            InitializeComponent();
        }

        private void buSalvar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            ClienteDAO clienteDao = new ClienteDAO();

            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.email = txtEmail.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.cep = txtCep.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.numero = int.Parse(txtNumero.Text);
            cliente.complemento = txtComplemento.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cidade = txtCidade.Text;
            cliente.estado = cbEstado.Text;


            clienteDao.CadastrarClientes(cliente);  //jogar no banco de dados
            tblClientes.DataSource = clienteDao.listarClientes();
            new Metodos().limparCampos(this);
        }

        private void TelaClientes_Load(object sender, EventArgs e)
        {
            ClienteDAO clienteDAO = new ClienteDAO();
            tblClientes.DataSource = clienteDAO.listarClientes();

        }

        private void tblClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pegando dados da linha do cliente selecionado

            txtCod.Text = tblClientes.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tblClientes.CurrentRow.Cells[1].Value.ToString();
            txtCpf.Text = tblClientes.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = tblClientes.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = tblClientes.CurrentRow.Cells[4].Value.ToString();
            txtCep.Text = tblClientes.CurrentRow.Cells[5].Value.ToString();
            txtEndereco.Text = tblClientes.CurrentRow.Cells[6].Value.ToString();
            txtNumero.Text = tblClientes.CurrentRow.Cells[7].Value.ToString();
            txtComplemento.Text = tblClientes.CurrentRow.Cells[8].Value.ToString();
            txtBairro.Text = tblClientes.CurrentRow.Cells[9].Value.ToString();
            txtCidade.Text = tblClientes.CurrentRow.Cells[10].Value.ToString();
            cbEstado.Text = tblClientes.CurrentRow.Cells[11].Value.ToString();


            tabClientes.SelectedTab = tabDados; // mudar aba após clicar na linha selecionada
        }

        private void buExcluir_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            ClienteDAO clienteDAO = new ClienteDAO();

            cliente.cod = int.Parse(txtCod.Text);

            clienteDAO.ExcluirClientes(cliente);
            tblClientes.DataSource = clienteDAO.listarClientes();
            new Metodos().limparCampos(this);
        }

        private void buAlterar_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            ClienteDAO clienteDao = new ClienteDAO();

            cliente.nome = txtNome.Text;
            cliente.cpf = txtCpf.Text;
            cliente.email = txtEmail.Text;
            cliente.telefone = txtTelefone.Text;
            cliente.cep = txtCep.Text;
            cliente.endereco = txtEndereco.Text;
            cliente.numero = int.Parse(txtNumero.Text);
            cliente.complemento = txtComplemento.Text;
            cliente.bairro = txtBairro.Text;
            cliente.cidade = txtCidade.Text;
            cliente.estado = cbEstado.Text;

            cliente.cod = int.Parse(txtCod.Text);

            clienteDao.AlterarClientes(cliente);  //jogar no banco de dados
            tblClientes.DataSource = clienteDao.listarClientes();
            new Metodos().limparCampos(this);
        }

        private void buPesquisar_Click(object sender, EventArgs e)
        {
            ClienteDAO clienteDao = new ClienteDAO();

            string nome = txtNomeConsulta.Text;
            tblClientes.DataSource = clienteDao.BuscarCliente(nome);

            // não deixar a tabela vazia se não achar o nome
            if (tblClientes.Rows.Count == 0)
            {
                tblClientes.DataSource = clienteDao.listarClientes();
            }
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
            catch (Exception )
            {
                MessageBox.Show("Endereço não encontrado");

            }
        }

        private void buNovo_Click(object sender, EventArgs e)
        {
            new Metodos().limparCampos(this);   //limpar essa tela
        }

        private void txtNomeConsulta_TextChanged(object sender, EventArgs e)
        {
            // buscar os clientes por aproximação 

            ClienteDAO clienteDao = new ClienteDAO();

            string nome = "%" + txtNomeConsulta.Text + "%";
            tblClientes.DataSource = clienteDao.ListarClientePorNome(nome);
        }
    }

}
