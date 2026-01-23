using Formulario.Interface;
using Formulario.Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;
using System.Text;

namespace Formulario.Dal
{
    public class DalClientes : InterfaceClientes
    {
        private MySqlConnection conexao;


        public void Adicionar(ModelClientes cliente)
        {
            try
            {
                string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string sql = @"INSERT INTO tb_clientes
            (Cliente, CPF, Contato, Email, CEP, Endereco, DataNascimento, Ativo)
            VALUES
            (@Cliente, @CPF, @Contato, @Email, @CEP, @Endereco, @DataNascimento, @Ativo)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Cliente", cliente.Cliente);
                        cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                        cmd.Parameters.AddWithValue("@Contato", cliente.Contato);
                        cmd.Parameters.AddWithValue("@Email", cliente.Email);
                        cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
                        cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                        cmd.Parameters.AddWithValue("@DataNascimento", cliente.Datadenascimento);
                        cmd.Parameters.AddWithValue("@Ativo", cliente.Ativo);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar cliente:\n" + ex.Message);
            }
        }


        public void Atualizar(ModelClientes cliente)
        {
            {
                try
                {
                    string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string sql = "UPDATE tb_clientes  SET Cliente = @Cliente, CPF = @CPF, Contato = @Contato, Email = @Email, CEP = @CEP, Endereco = @Endereco, DataNascimento = @DataNascimento, Ativo = @Ativo WHERE Id = @Id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@Id", cliente.Id);
                            cmd.Parameters.AddWithValue("@Cliente", cliente.Cliente);
                            cmd.Parameters.AddWithValue("@CPF", cliente.CPF);
                            cmd.Parameters.AddWithValue("@Contato", cliente.Contato);
                            cmd.Parameters.AddWithValue("@Email", cliente.Email);
                            cmd.Parameters.AddWithValue("@CEP", cliente.CEP);
                            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco);
                            cmd.Parameters.AddWithValue("@DataNascimento", cliente.Datadenascimento);
                            cmd.Parameters.AddWithValue("@Ativo", cliente.Ativo);

                            con.Open();
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro inesperado: " + ex.Message);
                }
            }
        }

        public void Deletar(int id)
        {
            try
            {
                string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string sql = "DELETE FROM tb_clientes WHERE Id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", id);

                        con.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }
        }



        public DataTable ListarTodos(string _nome)
        {
            DataTable tabelaClientes = new DataTable();

            try
            {
                string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM tb_clientes";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(tabelaClientes);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }

            return tabelaClientes;
        }
    }
}


