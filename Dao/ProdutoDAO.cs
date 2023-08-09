using ControleVendas.Conexaobd;
using ControleVendas.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleVendas.Dao
{
    public class ProdutoDAO
    {
        private MySqlConnection conn;
        public ProdutoDAO() 
        {
            this.conn = new conexao().getconnection();
        }

        public void CadastrarProdutos(Produtos produto)
        {
            try
            {
                string sql = @"INSERT INTO tbl_produtos (descricao,preco,qtd_estoque,for_id)
                               VALUES (@descricao,@preco,@qtd_estoque,@for_id)";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@descricao", produto.descricao);
                executar.Parameters.AddWithValue("@preco", produto.preco);
                executar.Parameters.AddWithValue("@qtd_estoque", produto.estoque);
                executar.Parameters.AddWithValue("@for_id", produto.for_id);

                conn.Open();
                executar.ExecuteNonQuery();

                MessageBox.Show("Produto cadastrado");
                conn.Close();


            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
            }

        }
        public DataTable listarProdutos()
        {
            try
            {
                DataTable tabela = new DataTable();         //criar Data table
                string sql = @"SELECT tbl_produtos.id as 'Cód',tbl_produtos.descricao as 'Descrição',
	                        tbl_produtos.preco as 'Preço',tbl_produtos.qtd_estoque as 'Estoque',
                            tbl_fornecedores.nome as 'Fornecedor' from tbl_produtos 
                            join tbl_fornecedores on (tbl_produtos.for_id = tbl_fornecedores.id);";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                conn.Open();
                executar.ExecuteNonQuery();         //executar comando

                MySqlDataAdapter da = new MySqlDataAdapter(executar);  //preencher dados
                da.Fill(tabela);
                conn.Close();

                return tabela;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar" + e);
                return null;

            }
        }

        public void AlterarProdutos(Produtos produto)
        {
            try
            {
                string sql = @"UPDATE tbl_produtos SET descricao=@descricao,preco=@preco,
                             qtd_estoque=@qtd_estoque,for_id=@for_id WHERE id = @id";
                               

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@descricao", produto.descricao);
                executar.Parameters.AddWithValue("@preco", produto.preco);
                executar.Parameters.AddWithValue("@qtd_estoque", produto.estoque);
                executar.Parameters.AddWithValue("@for_id", produto.for_id);

                executar.Parameters.AddWithValue("@id", produto.id);

                conn.Open();
                executar.ExecuteNonQuery();

                MessageBox.Show("Produto alterado");
                conn.Close();


            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
            }

        }
        public void ExcluirProdutos(Produtos produto)
        {
            try
            {
                string sql = @"DELETE FROM tbl_produtos WHERE id =@id";


                MySqlCommand executar = new MySqlCommand(sql, conn);

                executar.Parameters.AddWithValue("@id", produto.id);

                conn.Open();
                executar.ExecuteNonQuery();

                MessageBox.Show("Produto excluído");
                conn.Close();


            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
            }

        }

        public DataTable BuscarProdutos(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();         //criar Data table
                string sql = @"SELECT tbl_produtos.id as 'Cód',tbl_produtos.descricao as 'Descrição',
	                        tbl_produtos.preco as 'Preço',tbl_produtos.qtd_estoque as 'Estoque',
                            tbl_fornecedores.nome as 'Fornecedor' from tbl_produtos 
                            join tbl_fornecedores on (tbl_produtos.for_id = tbl_fornecedores.id) 
                            WHERE tbl_produtos.descricao like @nome;";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@nome", nome);
                conn.Open();
                executar.ExecuteNonQuery();         //executar comando

                MySqlDataAdapter da = new MySqlDataAdapter(executar);  //preencher dados
                da.Fill(tabela);
                conn.Close();

                return tabela;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar" + e);
                return null;

            }
        }
        public DataTable ListarProdutoPorNome(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();         //criar Data table
                string sql = @"SELECT tbl_produtos.id as 'Cód',tbl_produtos.descricao as 'Descrição',
	                        tbl_produtos.preco as 'Preço',tbl_produtos.qtd_estoque as 'Estoque',
                            tbl_fornecedores.nome as 'Fornecedor' from tbl_produtos 
                            join tbl_fornecedores on (tbl_produtos.for_id = tbl_fornecedores.id) 
                            WHERE tbl_produtos.descricao = @nome;";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@nome", nome);
                conn.Open();
                executar.ExecuteNonQuery();         //executar comando

                MySqlDataAdapter da = new MySqlDataAdapter(executar);  //preencher dados
                da.Fill(tabela);
                conn.Close();

                return tabela;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar" + e);
                return null;

            }
        }

        public Produtos retornarProdutoPorCod(int id)
        {
            try
            {
                Produtos produtos = new Produtos();
                string sql = "SELECT * FROM tbl_produtos WHERE id = @id";

                MySqlCommand executar = new MySqlCommand(sql,conn);
                executar.Parameters.AddWithValue("@id",id);

                conn.Open();
                MySqlDataReader reader = executar.ExecuteReader();

                if (reader.Read()) 
                {
                    
                    produtos.id = reader.GetInt32("id");
                    produtos.descricao = reader.GetString("descricao");
                    produtos.preco = reader.GetDecimal("preco");

                    conn.Close();
                    return produtos;
                }
                else
                {
                    MessageBox.Show("Nenhum produto encontrado com esse cód");
                    conn.Close() ;
                    return null;
                }

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
                return null;
            }
        }

        public void AtualizaEstoque(int produtoId,int qtdEstoque)
        {
            try
            {
                string sql = "UPDATE tbl_produtos SET qtd_estoque=@qtd_estoque WHERE id = @id";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@qtd_estoque", qtdEstoque);
                executar.Parameters.AddWithValue("@id",produtoId);

                conn.Open();
                executar.ExecuteNonQuery();

                conn.Close();



            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
                conn.Close();
            }
        }
        public int RetornarEstoqueAtual(int produtoId)
        {
            try
            {
                string sql = "SELECT qtd_estoque from tbl_produtos WHERE id =@id";
                int qtdEstoque = 0;
                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@id", produtoId);

                conn.Open();
                MySqlDataReader reader = executar.ExecuteReader();
                if(reader.Read()) 
                {
                    qtdEstoque = reader.GetInt32("qtd_estoque");
                    conn.Close();

                }
                return qtdEstoque;

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
                conn.Close();
                return 0;
            }
        }
            
    }
}
