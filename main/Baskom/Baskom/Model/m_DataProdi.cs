using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    internal class m_DataProdi
    {
        private int id_prodi;
        private string nama_prodi;
        public List<object[]> getAllProdi()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Prodi\";");
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
        public List<string> getAllNamaProdi()
        {
            List<string> result = new List<string>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT nama_prodi FROM \"Data_Prodi\";");
            while (reader.Read())
            {
                result.Add((string)reader[0]);
            }
            reader.Close();
            return result;
        }
        public string getNamaProdiById(int id_prodi)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Prodi\" WHERE id_prodi = '{id_prodi}'");
            while (reader.Read())
            {
                this.nama_prodi = (string)reader[1];
            }
            reader.Close();
            return this.nama_prodi;
        }
        public int getIdProdiByNama(string nama_prodi)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Prodi\" WHERE nama_prodi = '{nama_prodi}'");
            while (reader.Read())
            {
                this.id_prodi = (int)reader[0];
            }
            reader.Close();
            return this.id_prodi;
        }

    }
}
