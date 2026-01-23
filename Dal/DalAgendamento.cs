using Formulario.Interface;
using Formulario.Model;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace Formulario.Dal
{
    public class DalAgendamento : InterfaceAgendamento
    {
        private string connectionString =
            "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";


        private DateTime NormalizarHorario(DateTime data)
        {
            return new DateTime(
                data.Year,
                data.Month,
                data.Day,
                data.Hour,
                data.Minute,
                0
            );
        }


        private bool HorarioJaExiste(DateTime data)
        {
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string sql = @"SELECT COUNT(*) 
                               FROM tb_agendamento 
                               WHERE Dia_Horario = @Dia_Horario";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Dia_Horario", data);
                    con.Open();
                    int total = Convert.ToInt32(cmd.ExecuteScalar());
                    return total > 0;
                }
            }
        }

        public void Adicionar(MoldelAgendamento agendamento)
        {
            DateTime horarioNormalizado = NormalizarHorario(agendamento.Dia_Horario);

            if (HorarioJaExiste(horarioNormalizado))
                throw new Exception("Esse horário já está ocupado.");

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string sql = @"INSERT INTO tb_agendamento 
                               (Id_cliente, Dia_Horario)
                               VALUES 
                               (@Id_cliente, @Dia_Horario)";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    cmd.Parameters.AddWithValue("@Id_cliente", agendamento.Id_cliente);
                    cmd.Parameters.AddWithValue("@Dia_Horario", horarioNormalizado);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void Atualizar(MoldelAgendamento agendamento)
        {
            DateTime horarioNormalizado = NormalizarHorario(agendamento.Dia_Horario);

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
                    cmd.Parameters.AddWithValue("@Dia_Horario", horarioNormalizado);

                    con.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public void Deletar(int id)
        {
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


        public DataTable ListarTodos()
        {
            DataTable tabela = new DataTable();

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string sql = "SELECT * FROM tb_agendamento";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(tabela);
                }
            }

            return tabela;
        }
    


public DataTable ListarAgendamentoComServicos()
        {
            DataTable tabela = new DataTable();

            string connectionString =
                "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                string sql = @"
            SELECT 
                a.Id AS IdAgendamento,
                a.Id_cliente,
                a.Dia_Horario,
                s.Servico,
                s.Preco
            FROM tb_agendamento a
            INNER JOIN tb_servicos s ON s.Id = a.Id_cliente
            ORDER BY a.Dia_Horario
        ";

                using (MySqlCommand cmd = new MySqlCommand(sql, con))
                {
                    using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                    {
                        da.Fill(tabela);
                    }
                }
            }

            return tabela;
        }
    }
}

