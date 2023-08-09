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
    public partial class TelaVendas : Form
    {
        Clientes cliente = new Clientes();
        ClienteDAO clienteDAO = new ClienteDAO();

        Produtos produto = new Produtos();
        ProdutoDAO produtoDAO = new ProdutoDAO();

        DataTable carrinho = new DataTable(); // carrinho de compras - tblProdutos

        int qtd;
        decimal preco;
        decimal subtotal;
        decimal total;

        public TelaVendas()
        {
            InitializeComponent();

            carrinho.Columns.Add("Cód", typeof(int));
            carrinho.Columns.Add("Produto", typeof(string));
            carrinho.Columns.Add("Qtd", typeof(int));
            carrinho.Columns.Add("Preço", typeof(decimal));
            carrinho.Columns.Add("SubTotal", typeof(decimal));

            tblProdutos.DataSource = carrinho;   // data grid view é o carrinho
        }


        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)                 //tecla enter = 13
            {
                cliente = clienteDAO.retornarClientePorCPF(txtCpf.Text);
                if(cliente != null)
                {
                    txtCodigo.Text = cliente.cod.ToString();
                    txtNome.Text = cliente.nome;    // txt do nome para preencher

                }
                else
                {
                    txtCpf.Clear();
                    txtCpf.Focus();
                }
               

            }
        }

        private void txtCod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                produto = produtoDAO.retornarProdutoPorCod(int.Parse(txtCod.Text));

                if(produto != null)
                {
                    txtDescricao.Text = produto.descricao;
                    txtPreco.Text = produto.preco.ToString();
                }
                else
                {
                    txtCod.Clear();
                    txtCod.Focus();

                }
                


            }
        }

        private void TelaVendas_Load(object sender, EventArgs e)
        {
            txtData.Text = DateTime.Now.ToShortDateString();

        }

        private void buAdicionar_Click(object sender, EventArgs e)
        {
            try
            {
                qtd = int.Parse(txtEstoque.Text);
                preco = decimal.Parse(txtPreco.Text);
                subtotal = qtd * preco;

                total += subtotal;

                //adicionando produtos no carrinho
                carrinho.Rows.Add(int.Parse(txtCod.Text), txtDescricao.Text, qtd, preco, subtotal);
                txtTotal.Text = total.ToString();

                txtCod.Clear();
                txtDescricao.Clear();
                txtPreco.Clear();
                txtEstoque.Clear();

                txtCod.Focus();  //depois que limpar os campos voltar o foco para o cod

            }
            catch (Exception ex)
            {

                MessageBox.Show("Digite o cód do produto");
            }

            
        }

        private void buRemover_Click(object sender, EventArgs e)
        {
            decimal produtosubTotal = decimal.Parse(tblProdutos.CurrentRow.Cells[4].Value.ToString());
            int indice = tblProdutos.CurrentRow.Index;

            DataRow linha = carrinho.Rows[indice];   //definindo a linha para fazer a exclusão

            carrinho.Rows.Remove(linha);
            carrinho.AcceptChanges();     // para fazer as alterações

            total -= produtosubTotal;
            txtTotal.Text = total.ToString();

            MessageBox.Show("Item removido do carrinho");
        }

        private void buPagamento_Click(object sender, EventArgs e)
        {
            //passando valores para tela de pagamento para salvar no banco
            DateTime data = DateTime.Parse(txtData.Text);
            TeladePagamento tela = new TeladePagamento(cliente,carrinho,data);

            //passar o total para tela de pagamento
            tela.txtTotal.Text = total.ToString();

            tela.ShowDialog(); // mostrar tela e impedir que feche ate finalizar a venda

        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void tblProdutos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void buCancelar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda cancelada");
            Dispose();
        }
    }
}
