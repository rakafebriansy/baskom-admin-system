using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataKonversiSks
    {
        public List<object[]> getAllKonversiSks()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Konversi_SKS\";");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                field_values[2] = reader[2];
                field_values[3] = reader[3];
                field_values[4] = reader[4];
                field_values[5] = reader[5];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public List<object[]> getAllKonversiSksByIdMhs(int id_mahasiswa)
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Konversi_SKS\" WHERE id_mahasiswa = {id_mahasiswa};");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                field_values[2] = reader[2];
                field_values[3] = reader[3];
                field_values[4] = reader[4];
                field_values[5] = reader[5];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public List<object[]> getAllKonversiSksByIdSks(List<int> list_id_sks)
        {
            List<object[]> result = new List<object[]>();

            foreach (int id_sks in list_id_sks)
            {
                NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Konversi_SKS\" WHERE id_konversi_sks = {id_sks};");
                int field_count = reader.FieldCount;
                while (reader.Read())
                {
                    object[] field_values = new object[field_count];
                    field_values[0] = reader[0];
                    field_values[1] = reader[1];
                    field_values[2] = reader[2];
                    field_values[3] = reader[3];
                    field_values[4] = reader[4];
                    field_values[5] = reader[5];
                    result.Add(field_values);
                }
                reader.Close();
            }
            return result;
        }
        public void updateKonversiSks(int id_konversi_sks, int status_validasi)
        {
            Database.Database.sendData($"UPDATE \"Data_Konversi_SKS\" SET status_validasi = {Convert.ToInt16(status_validasi)} WHERE id_konversi_sks = {id_konversi_sks}");
        }
        public void deleteDataKonversiSks(int id_mahasiswa, int id_matkul)
        {
            string query = $"DELETE FROM \"Data_Konversi_SKS\" WHERE id_matkul = {id_matkul} and id_mahasiswa = {id_mahasiswa};";
            Database.Database.sendData(query);
        }

        public void sendDataKonversiSks(object[] dataKonversiSks)
        {
            string query = $"INSERT INTO \"Data_Konversi_SKS\" (kompetensi, deskripsi_kompetensi, status_validasi, id_matkul, id_mahasiswa) VALUES ('{dataKonversiSks[0]}','{dataKonversiSks[1]}', {dataKonversiSks[2]}, {dataKonversiSks[3]}, {dataKonversiSks[4]});";
            Database.Database.sendData(query);
        }
    }
}
