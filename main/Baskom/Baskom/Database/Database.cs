﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

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
        public static void sendData(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query,conn);
            cmd.ExecuteNonQuery();
        }
        public static NpgsqlDataReader getData(string query)
        {
            NpgsqlCommand cmd = new NpgsqlCommand(query,conn);
            NpgsqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }
    }
}