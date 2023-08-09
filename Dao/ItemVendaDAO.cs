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
    public class ItemVendaDAO
    {
        private MySqlConnection conn;
        public ItemVendaDAO()
        {
            this.conn = new conexao().getconnection();
        }

        public void CadastrarItem(ItensVendas itemvenda)
        {
            try
            {
                string sql = @"INSERT INTO tbl_itensvendas(venda_id,produto_id,qtd,subtotal)
                               VALUES(@venda_id,@produto_id,@qtd,@subtotal)";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@venda_id", itemvenda.venda_id);
                executar.Parameters.AddWithValue("@produto_id", itemvenda.produto_id);
                executar.Parameters.AddWithValue("@qtd", itemvenda.qtd);
                executar.Parameters.AddWithValue("@subtotal", itemvenda.subtotal);

                conn.Open();
                executar.ExecuteNonQuery();

                // MessageBox.Show("Item Cadastrado");
                conn.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
            }
        }

        public DataTable listarItensPorVenda(int venda_id)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @"SELECT tbl_itensvendas.id as 'Cód' ,
                                      tbl_produtos.descricao as 'Descrição',
                                      tbl_itensvendas.qtd as 'Quantidade',
                                      tbl_produtos.preco as 'Preço',
                                      tbl_itensvendas.subtotal as 'SubTotal'
                               FROM tbl_itensvendas JOIN tbl_produtos ON (tbl_itensvendas.produto_id = tbl_produtos.id)
                               WHERE venda_id = @venda_id";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@venda_id", venda_id);

                conn.Open();
                executar.ExecuteNonQuery();

                MySqlDataAdapter da = new MySqlDataAdapter(executar);
                da.Fill(tabela);

                return tabela;
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
                return null;
            }
        }
    }
}
