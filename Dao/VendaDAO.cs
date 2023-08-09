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
    public class VendaDAO
    {
        private MySqlConnection conn;

        public VendaDAO()
        {
            this.conn = new conexao().getconnection();
        }
        public void CadastrarVendas(Vendas venda)
        {
            try
            {
                string sql = @"INSERT INTO tbl_vendas (cliente_id,data_venda,total_venda,observacoes)
                               VALUES(@cliente_id,@data_venda,@total_venda,@observacoes)";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@cliente_id", venda.cliente_id);
                executar.Parameters.AddWithValue("@data_venda", venda.data_venda);
                executar.Parameters.AddWithValue("@total_venda", venda.total_venda);
                executar.Parameters.AddWithValue("@observacoes", venda.observacoes);


                conn.Open();
                executar.ExecuteNonQuery();

               // MessageBox.Show("Venda Efetuada");
                conn.Close();

            }
            catch (Exception e)
            {

                MessageBox.Show("Erro" + e);
            }

        }
        public int RetornarIdVenda()
        {
            try
            {
                int Vendaid = 0;
                string sql = "SELECT MAX(id) id FROM tbl_vendas";
                MySqlCommand executar = new MySqlCommand(sql, conn);

                conn.Open();
                MySqlDataReader reader = executar.ExecuteReader();
                if(reader.Read()) 
                {
                    Vendaid = reader.GetInt32("id");
                              
                }
                conn.Close();
                return Vendaid;

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);
                conn.Close();
                return 0;

            }
        }

        public DataTable RetornarVendasPorPeriodo(DateTime dataInicio,DateTime dataFim)
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @"SELECT tbl_vendas.id as 'Cód' ,
                                      tbl_vendas.data_venda as 'Data da Venda',
                                      tbl_clientes.nome as 'Cliente',
                                      tbl_vendas.total_venda as 'Total',
                                      tbl_vendas.observacoes as 'Obs'
                               FROM tbl_vendas JOIN tbl_clientes ON (tbl_vendas.cliente_id = tbl_clientes.id)
                               WHERE tbl_vendas.data_venda between @datainicio and @datafim";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@datainicio", dataInicio);
                executar.Parameters.AddWithValue("@datafim", dataFim);

                conn.Open() ;
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
        public DataTable listarVendas()
        {
            try
            {
                DataTable tabela = new DataTable();
                string sql = @"SELECT tbl_vendas.id as 'Cód' ,
                                      tbl_vendas.data_venda as 'Data da Venda',
                                      tbl_clientes.nome as 'Cliente',
                                      tbl_vendas.total_venda as 'Total',
                                      tbl_vendas.observacoes as 'Obs'
                               FROM tbl_vendas JOIN tbl_clientes ON (tbl_vendas.cliente_id = tbl_clientes.id)";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                conn.Open();
                executar.ExecuteNonQuery();

                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(executar);
                dataAdapter.Fill(tabela);

                conn.Close();
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
