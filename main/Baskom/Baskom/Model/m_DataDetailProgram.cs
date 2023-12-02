using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataDetailProgram
    {
        public List<object[]> getAllDetailProgram()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Detail_Program\";");
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
        public List<object[]> getDetailProgramByIdProgram(int id_program)
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Detail_Program\" WHERE id_program = {id_program};");
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
        public void sendDetailProgram(int id_program, int id_matkul)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Detail_Program\" (id_program, id_matkul) VALUES ({id_program},{id_matkul});");
        }
    }
}
