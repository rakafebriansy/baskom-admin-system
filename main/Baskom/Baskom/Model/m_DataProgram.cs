using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataProgram
    {
        public List<object[]> getAllProgram()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Program\";");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public List<string> getAllNamaProgram()
        {
            List<string> result = new List<string>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT nama_program FROM \"Data_Program\";");
            while (reader.Read())
            {;
                result.Add((string)reader[0]);
            }
            reader.Close();
            return result;
        }
        public object[] getProgramById(int id_program)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Program\" WHERE id_program = {id_program};");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
            }
            reader.Close();
            return result;
        }
        public object[] getProgramByNama(string nama_program)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Program\" WHERE nama_program = '{nama_program}';");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
            }
            reader.Close();
            return result;
        }
        public void sendProgram(string nama_program)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Program\" (nama_program) VALUES ('{nama_program}');");
        }
    }
}
