using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    internal class m_DataPengajuanMitra
    {
        public List<object[]> getAllPengajuanMitra()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Pengajuan_Mitra\";");
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
        public object[] getPengajuanMitraById(int id_pengajuan)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Pengajuan_Mitra\" WHERE id_pengajuan = {id_pengajuan}");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
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
        public void sendPengajuan(object[] pengajuan_mitra)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Pengajuan_Mitra\" (nama_mitra, deskripsi_mitra, id_status_validasi, id_mahasiswa) VALUES ('{pengajuan_mitra[0]}', '{pengajuan_mitra[1]}', {pengajuan_mitra[2]}, {pengajuan_mitra[3]});");
        }
        public void updateStatusValidasi(int id_status_validasi, int id_pengajuan)
        {
            Database.Database.sendData($"UPDATE \"Data_Pengajuan_Mitra\" SET id_status_validasi = {id_status_validasi} WHERE id_pengajuan = {id_pengajuan}");
        }
    }
}
