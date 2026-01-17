using Formulario.Model;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Formulario.Dal
{
    public class DalServicos : Interface.InterfaceServicos
    {
        public void Adicionar(ModelServicos servicos)
        {
            try
            {
                string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string sql = @"INSERT INTO tb_servicos 
                           (servicos, preco)
                           VALUES 
                           (@servicos, @preco)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@servicos", servicos.Servico);
                        cmd.Parameters.AddWithValue("@preco", servicos.Preco);

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

        public void Atualizar(ModelServicos servicos)
        {
            {
                try
                {
                    string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string sql = "UPDATE tb_servicos  SET Servicos = @servicos, preco = @preco, WHERE Id = @Id";

                        using (MySqlCommand cmd = new MySqlCommand(sql, con))
                        {
                            cmd.Parameters.AddWithValue("@servicos", servicos.Servico);
                            cmd.Parameters.AddWithValue("@preco", servicos.Preco);


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
            {
                try
                {
                    string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string sql = "DELETE FROM tb_servicos WHERE Id = @Id";

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
        }

        public DataTable ListarTodos()
        {
            DataTable tabelaservicos = new DataTable();

            try
            {
                string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM tb_servicos";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(tabelaservicos);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }

            return tabelaservicos;
        }
    }
}
    

