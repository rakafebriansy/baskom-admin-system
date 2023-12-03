using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace Baskom.Database
{
    static class Database
    {
        static NpgsqlConnection conn = new NpgsqlConnection("Host=localhost;Username=postgres;Password=123;Database=baskom");
        public static void openDb()
        {
            conn.Open();
        }
        public static void closeDb()
        {
            conn.Close();
        }
        public static int sendData(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query,conn);
            int rows_affected = cmd.ExecuteNonQuery();
            return rows_affected;
        }
        public static NpgsqlDataReader getData(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query,conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
        public static void sendBindData(List<int> data, string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlParameter p = new NpgsqlParameter("data", NpgsqlDbType.Array | NpgsqlDbType.Integer);
            p.Value = data;
            cmd.Parameters.Add(p);
            cmd.ExecuteNonQuery();
        }        
        public static NpgsqlDataReader getBindData(List<int> data, string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlParameter p = new NpgsqlParameter("data", NpgsqlDbType.Array | NpgsqlDbType.Integer);
            p.Value = data;
            cmd.Parameters.Add(p);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}
