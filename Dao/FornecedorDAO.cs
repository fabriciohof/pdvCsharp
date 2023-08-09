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
    public class FornecedorDAO
    {
        private MySqlConnection conn;
        public FornecedorDAO()
        {
            this.conn = new conexao().getconnection();
        }
        public void CadastrarFornecedores(Fornecedores fornecedor)
        {
            try
            {
                string sql = @"INSERT INTO tbl_fornecedores (nome,cnpj,email,telefone,cep,endereco,numero,complemento,bairro,cidade,estado)
                               values(@nome,@cnpj,@email,@telefone,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";
                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@nome", fornecedor.nome);
                executar.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                executar.Parameters.AddWithValue("@email", fornecedor.email);
                executar.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                executar.Parameters.AddWithValue("@cep", fornecedor.cep);
                executar.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                executar.Parameters.AddWithValue("@numero", fornecedor.numero);
                executar.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                executar.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                executar.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                executar.Parameters.AddWithValue("@estado", fornecedor.estado);

                conn.Open();
                executar.ExecuteNonQuery();
                MessageBox.Show("Fornecedor cadastrado");
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao cadastrar" + e);
            }
        }
        public DataTable listarFornecedores()
        {
            try
            {
                DataTable tabela = new DataTable();         //criar Data table
                string sql = "SELECT * from tbl_fornecedores";

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
        public void AlterarFornecedores(Fornecedores fornecedor)
        {
            try
            {
                string sql = @"UPDATE tbl_fornecedores set nome=@nome,cnpj=@cnpj,email=@email,telefone=@telefone,cep=@cep,endereco=@endereco,
                              numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@nome", fornecedor.nome);
                executar.Parameters.AddWithValue("@cnpj", fornecedor.cnpj);
                executar.Parameters.AddWithValue("@email", fornecedor.email);
                executar.Parameters.AddWithValue("@telefone", fornecedor.telefone);
                executar.Parameters.AddWithValue("@cep", fornecedor.cep);
                executar.Parameters.AddWithValue("@endereco", fornecedor.endereco);
                executar.Parameters.AddWithValue("@numero", fornecedor.numero);
                executar.Parameters.AddWithValue("@complemento", fornecedor.complemento);
                executar.Parameters.AddWithValue("@bairro", fornecedor.bairro);
                executar.Parameters.AddWithValue("@cidade", fornecedor.cidade);
                executar.Parameters.AddWithValue("@estado", fornecedor.estado);

                executar.Parameters.AddWithValue("@id", fornecedor.cod);

                conn.Open();
                executar.ExecuteNonQuery();
                MessageBox.Show("Fornecedor alterado");
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao alterar" + e);
            }
        }

        //excluir clientes
        public void ExcluirFornecedores(Fornecedores fornecedor)
        {
            try
            {
                string sql = @"DELETE from tbl_fornecedores where id=@id";

                MySqlCommand executar = new MySqlCommand(sql, conn);

                executar.Parameters.AddWithValue("@id", fornecedor.cod);

                conn.Open();
                executar.ExecuteNonQuery();
                MessageBox.Show("Fornecedor excluído");
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao excluir" + e);
            }
        }

        public DataTable BuscarFornecedor(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();         //criar Data table
                string sql = "SELECT * from tbl_fornecedores where nome=@nome";

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
        public DataTable ListarFornecedorPorNome(string nome)
        {
            // buscar os clientes por aproximação 
            try
            {
                DataTable tabela = new DataTable();         //criar Data table
                string sql = "SELECT * from tbl_fornecedores where nome like @nome";

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
    }
}
