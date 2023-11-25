using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_tcc.DB
{
    public class ConnectionDB
    {
        public static NpgsqlConnection Connection()
        {
            string stringConnection = "Host=localhost;" +
                                      "Port=5432;" +
                                      "Username=postgres;" +
                                      "Password=123456;" +
                                      "Database=db_FiltroDNS;";

            NpgsqlConnection connection = new NpgsqlConnection(stringConnection);
            connection.Open();
            return connection;
        }
        public static void CRUD(NpgsqlCommand command)
        {
            NpgsqlConnection con = Connection();
            command.Connection = con;
            command.ExecuteNonQuery();
            con.Close();
        }

        public static NpgsqlDataReader Select(NpgsqlCommand command)
        {
            NpgsqlConnection con = Connection();
            command.Connection = con;
            NpgsqlDataReader dr = command.ExecuteReader();
            return dr;
        }

        public static NpgsqlDataReader Reader(NpgsqlCommand command)
        {
            NpgsqlConnection con = Connection();
            command.Connection = con;
            NpgsqlDataReader dr = command.ExecuteReader();
            return dr;
        }




    }
}
