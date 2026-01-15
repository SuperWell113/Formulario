using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using Mysqlx.Connection;

namespace Formulario.Conexao
{
    public class Conexao
    {
        public class ConnectionFactory
        {
            private static string connectionString = "Server=127.0.0.1;Database=db_barbearia;User Id=root;Password=;";

            public static MySqlConnection GetConnection()
            {
                return new MySqlConnection(connectionString);
            }
        }
    }
}
