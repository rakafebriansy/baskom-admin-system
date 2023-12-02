using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataPembagianTugas
    {
        public List<object[]> getAllPembagianTugas()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Pembagian_Tugas\";");
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
        public object[] getPembagianTugasByIdMhs(int id_mahasiswa)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Pembagian_Tugas\" WHERE id_mahasiswa = {id_mahasiswa}");
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
        public void sendPembagianTugas(int id_mahasiswa, int id_timmbkm)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Pembagian_Tugas\" (id_mahasiswa, id_timmbkm) VALUES ({id_mahasiswa}, {id_timmbkm});");
        }
    }
}
