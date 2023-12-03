using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataMitra
    {
        public List<object[]> getAllMitra()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Mitra\";");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                field_values[2] = reader[2];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public object[] getMitraById(int id_mitra)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Mitra\" WHERE id_mitra = {id_mitra};");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
            }
            reader.Close();
            return result;
        }
        public object[] getMitraByNama(string nama_mitra)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Mitra\" WHERE nama_mitra = '{nama_mitra}';");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
            }
            reader.Close();
            return result;
        }
    }
}
