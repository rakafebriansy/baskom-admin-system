using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataKonversiNilai
    {
        public List<object[]> getAllKonversiNilai()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Konversi_Nilai\";");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                field_values[2] = reader[2];
                field_values[3] = reader[3];
                field_values[4] = reader[4];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public object[] getKonversiNilaiByIdKonversiSks(int id_konversi_sks)
        {
            object[] result = new object[5];
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Konversi_Nilai\" WHERE id_konversi_sks = {id_konversi_sks};");
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
                result[4] = reader[4];
            }
            reader.Close();
            return result;
        }
        public List<object[]> getAllKonversiNilaiById(List<int> list_id_konversi_nilai)
        {
            List<object[]> result = new List<object[]>();

            foreach (int id_nilai in list_id_konversi_nilai)
            {
                NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Konversi_Nilai\" WHERE id_konversi_nilai = {id_nilai};");
                int field_count = reader.FieldCount;
                while (reader.Read())
                {
                    object[] field_values = new object[field_count];
                    field_values[0] = reader[0];
                    field_values[1] = reader[1];
                    field_values[2] = reader[2];
                    field_values[3] = reader[3];
                    field_values[4] = reader[4];
                    result.Add(field_values);
                }
                reader.Close();
            }
            return result;
        }      
        public List<object[]> getAllKonversiNilaiByIdSks(List<int> list_id_konversi_sks)
        {
            List<object[]> result = new List<object[]>();

            foreach (int id_sks in list_id_konversi_sks)
            {
                NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Konversi_Nilai\" WHERE id_konversi_sks = {id_sks};");
                int field_count = reader.FieldCount;
                while (reader.Read())
                {
                    object[] field_values = new object[field_count];
                    field_values[0] = reader[0];
                    field_values[1] = reader[1];
                    field_values[2] = reader[2];
                    field_values[3] = reader[3];
                    field_values[4] = reader[4];
                    result.Add(field_values);
                }
                reader.Close();
            }
            return result;
        }
        public void updateKonversiNilai(int id_konversi_nilai, int status_validasi)
        {
            Database.Database.sendData($"UPDATE \"Data_Konversi_Nilai\" SET status_validasi = {Convert.ToInt16(status_validasi)} WHERE id_konversi_nilai = {id_konversi_nilai}");
        }
        public void sendDataKonversiNilai(object[] dataKonversiNilai)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Konversi_Nilai\" (nilai,file_laporan_akhir,status_validasi,id_konversi_sks) VALUES ({dataKonversiNilai[0]},'{dataKonversiNilai[1]}',{dataKonversiNilai[2]},{dataKonversiNilai[3]});");
        }
    }
}
