using Formulario.Interface;
using Formulario.Model;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Formulario.Dal
{
    public class DalAgendamento : InterfaceAgendamento
    {
        private MySqlConnection conexao;
        public void Adicionar(MoldelAgendamento agendamento)
        {
            try
            {
                string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string sql = @"INSERT INTO tb_agendamento 
                           (Id_cliente, Dia_Horario)
                           VALUES 
                           (@Id_cliente, @Dia_Horario)";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Id_cliente", agendamento.Id_cliente);
                        cmd.Parameters.AddWithValue("@Dia_Horario", agendamento.Dia_Horario);

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

        public void Atualizar(MoldelAgendamento agendamento)
        {
            try
            {
                string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string sql = @"UPDATE tb_agendamento
                           SET Id_cliente = @Id_cliente,
                               Dia_Horario = @Dia_Horario
                           WHERE Id = @Id";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Id", agendamento.Id);
                        cmd.Parameters.AddWithValue("@Id_cliente", agendamento.Id_cliente);
                        cmd.Parameters.AddWithValue("@Dia_Horario", agendamento.Dia_Horario);

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


        public void Deletar(int id)
        {
            {
                try
                {
                    string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                    using (MySqlConnection con = new MySqlConnection(connectionString))
                    {
                        string sql = "DELETE FROM tb_agendamento WHERE Id = @Id";

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
            DataTable tabelaAgendamento = new DataTable();

            try
            {
                string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    string sql = "SELECT * FROM tb_agendamento";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                        {
                            da.Fill(tabelaAgendamento);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro inesperado: " + ex.Message);
            }

            return tabelaAgendamento;
        }
    }
}

