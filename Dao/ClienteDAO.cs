using ControleVendas.Model;
using ControleVendas.Conexaobd;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ControleVendas.Dao
{
    public class ClienteDAO
    {
        private MySqlConnection conn; 
        public ClienteDAO()
        {
            this.conn = new conexao().getconnection();
        }


        //cadastrar clientes
        public void CadastrarClientes(Clientes cliente)
        {
            try
            {
                string sql = @"INSERT INTO tbl_clientes (nome,cpf,email,telefone,cep,endereco,numero,complemento,bairro,cidade,estado)
                               values(@nome,@cpf,@email,@telefone,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";
                MySqlCommand executar = new MySqlCommand(sql,conn);
                executar.Parameters.AddWithValue("@nome", cliente.nome);
                executar.Parameters.AddWithValue("@cpf", cliente.cpf);
                executar.Parameters.AddWithValue("@email", cliente.email);
                executar.Parameters.AddWithValue("@telefone", cliente.telefone);
                executar.Parameters.AddWithValue("@cep", cliente.cep);
                executar.Parameters.AddWithValue("@endereco", cliente.endereco);
                executar.Parameters.AddWithValue("@numero", cliente.numero);
                executar.Parameters.AddWithValue("@complemento", cliente.complemento);
                executar.Parameters.AddWithValue("@bairro", cliente.bairro);
                executar.Parameters.AddWithValue("@cidade", cliente.cidade);
                executar.Parameters.AddWithValue("@estado", cliente.estado);

                conn.Open();
                executar.ExecuteNonQuery();
                MessageBox.Show("Cliente cadastrado");
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao cadastrar"+e);
            }
        }
        public DataTable listarClientes()
        {
            try
            {
                DataTable tabela = new DataTable();         //criar Data table
                string sql = "SELECT * from tbl_clientes";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                conn.Open() ;
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

        //alterar clientes

        public void AlterarClientes(Clientes cliente)
        {
            try
            {
                string sql = @"UPDATE tbl_clientes set nome=@nome,cpf=@cpf,email=@email,telefone=@telefone,cep=@cep,endereco=@endereco,
                              numero=@numero,complemento=@complemento,bairro=@bairro,cidade=@cidade,estado=@estado where id=@id";
                               
                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@nome", cliente.nome);
                executar.Parameters.AddWithValue("@cpf", cliente.cpf);
                executar.Parameters.AddWithValue("@email", cliente.email);
                executar.Parameters.AddWithValue("@telefone", cliente.telefone);
                executar.Parameters.AddWithValue("@cep", cliente.cep);
                executar.Parameters.AddWithValue("@endereco", cliente.endereco);
                executar.Parameters.AddWithValue("@numero", cliente.numero);
                executar.Parameters.AddWithValue("@complemento", cliente.complemento);
                executar.Parameters.AddWithValue("@bairro", cliente.bairro);
                executar.Parameters.AddWithValue("@cidade", cliente.cidade);
                executar.Parameters.AddWithValue("@estado", cliente.estado);

                executar.Parameters.AddWithValue("@id", cliente.cod);

                conn.Open();
                executar.ExecuteNonQuery();
                MessageBox.Show("Cliente alterado");
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao alterar" + e);
            }
        }

        //excluir clientes
        public void ExcluirClientes(Clientes cliente)
        {
            try
            {
                string sql = @"DELETE from tbl_clientes where id=@id";

                MySqlCommand executar = new MySqlCommand(sql, conn);

                executar.Parameters.AddWithValue("@id", cliente.cod);

                conn.Open();
                executar.ExecuteNonQuery();
                MessageBox.Show("Cliente excluído");
                conn.Close();
            }
            catch (Exception e)
            {

                MessageBox.Show("Erro ao excluir" + e);
            }
        }

        public DataTable BuscarCliente(string nome)
        {
            try
            {
                DataTable tabela = new DataTable();         //criar Data table
                string sql = "SELECT * from tbl_clientes where nome=@nome";

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
        public DataTable ListarClientePorNome(string nome)
        {
            // buscar os clientes por aproximação 
            try
            {
                DataTable tabela = new DataTable();         //criar Data table
                string sql = "SELECT * from tbl_clientes where nome like @nome";

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

        public Clientes retornarClientePorCPF(string cpf)
        {
            try
            {
                Clientes cliente = new Clientes();
                string sql = "SELECT * FROM tbl_clientes WHERE cpf = @cpf";

                MySqlCommand executar = new MySqlCommand(sql, conn);
                executar.Parameters.AddWithValue("@cpf", cpf);

                conn.Open();
                MySqlDataReader reader = executar.ExecuteReader();      // ler os dados do cpf

                if(reader.Read()) 
                { 
                    cliente.cod = reader.GetInt32("id");     //pegar coluna id no data reader
                    cliente.nome = reader.GetString("nome");

                    return cliente;        //retorna o objeto cliente
                }

                else
                {
                    MessageBox.Show("Esse cliente não foi encontrado");

                    return null;
                }

               

            }
            catch (Exception e)
            {
                MessageBox.Show("Erro" + e);

                return null;
            }
        }

    }
}
