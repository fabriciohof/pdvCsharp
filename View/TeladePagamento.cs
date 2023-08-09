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
    public partial class TeladePagamento : Form
    {
        //construtor

        Clientes cliente = new Clientes();
        DataTable carrinho = new DataTable();
        DateTime data;

        public TeladePagamento(Clientes cliente,DataTable carrinho,DateTime data)
        {
            this.cliente = cliente;
            this.carrinho = carrinho;
            this.data = data;

            InitializeComponent();
        }

        private void TeladePagamento_Load(object sender, EventArgs e)
        {
            txtDinheiro.Text = "0,00";
            
            txtTroco.Text = "0,00";
        }

        private void buFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal dinheiro,troco,totalpago,total;
                int qtdEstoque, qtdComprada, qtdAtualizada; 
               


                dinheiro = decimal.Parse(txtDinheiro.Text);
                
                total = decimal.Parse(txtTotal.Text);

                totalpago = dinheiro;    // calculando total pago
                if(totalpago < total)
                {
                    MessageBox.Show("Total pago menor que o valor da venda");
                }
                else
                {
                    Vendas venda = new Vendas();
                    VendaDAO vendaDAO = new VendaDAO();

                    troco = totalpago - total; // calculando troco

                    venda.cliente_id = cliente.cod; //pegar id do cliente
                    venda.data_venda = data;        //pegar data atual
                    venda.total_venda = total;      //atribuindo o total da venda a variavel total
                    venda.observacoes = txtObservacoes.Text;
                    txtTroco.Text = troco.ToString();

                    vendaDAO.CadastrarVendas(venda);

                    foreach (DataRow linha in carrinho.Rows) // percorrer os itens do carrinho
                    {
                        //cadastrando os itens da venda
                        ItensVendas itens = new ItensVendas();
                        ItemVendaDAO itensDAO = new ItemVendaDAO();
                        ProdutoDAO produtoDAO = new ProdutoDAO();

                        itens.venda_id = vendaDAO.RetornarIdVenda();
                        itens.produto_id = int.Parse(linha["Cód"].ToString());
                        itens.qtd = int.Parse(linha["Qtd"].ToString());
                        itens.subtotal = decimal.Parse(linha["SubTotal"].ToString());

                        qtdEstoque = produtoDAO.RetornarEstoqueAtual(itens.produto_id);  //Baixa no estoque
                        qtdComprada = itens.qtd;
                        qtdAtualizada = qtdEstoque - qtdComprada;  //estoque atualizado

                        produtoDAO.AtualizaEstoque(itens.produto_id, qtdAtualizada);

                        itensDAO.CadastrarItem(itens);
                        

                    }
                    MessageBox.Show("Venda finalizada");
                    this.Dispose();

                    new TelaVendas().ShowDialog();

                   

                    
                }

                

            }
            catch (Exception ex)
            {

               
            }
            
        }
    }
}
