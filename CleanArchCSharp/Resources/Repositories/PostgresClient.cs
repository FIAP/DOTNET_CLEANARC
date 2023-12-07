using FiapCAVendas.Entities;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiapCAVendas.Resources.Repositories
{
    internal class PostgresClient
    {
        public string ConnString { get; }
     
        public PostgresClient()
        {
            string host = "localhost";
            string port = "5432";
            string dbname = "fiapvendas";
            string user = "fiap";
            string password = "fiap";

            ConnString = $"Host={host};Port={port};Username={user};Password={password};Database={dbname}";
        }

        public VendedorEntity? ObterVendedorPorIdentificacao(string identificacao)
        {
            using var conn = new NpgsqlConnection(ConnString);
            conn.Open();
            using var cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT * FROM vendedor WHERE identificacao = @identificacao";
            cmd.Parameters.AddWithValue("identificacao", identificacao);
            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                var vendedor = new VendedorEntity(reader.GetString(1), reader.GetString(2));
                return vendedor;
            }
            else
            {
                return null;
            }
        }

    }
}
