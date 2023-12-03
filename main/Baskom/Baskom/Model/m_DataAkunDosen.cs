using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunDosen
    {
        public object[] getDosenById(int id_dosen)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Dosen\" WHERE id_dosen = {id_dosen}");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
                result[4] = reader[4];
                result[5] = reader[5];
                result[6] = reader[6];
            }
            reader.Close();
            return result;
        }
        public object[] getDosenByNidn(string nidn)
        {
            object[] result = new object[7];
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Dosen\" WHERE nidn = '{nidn}'");
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
                result[4] = reader[4];
                result[5] = reader[5];
                result[6] = reader[6];
            }
            reader.Close();
            return result;
        }
        public object[] getDosenByNama(string nama_dosen)
        {
            object[] result = new object[7];
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Dosen\" WHERE nama_dosen = '{nama_dosen}'");
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
                result[4] = reader[4];
                result[5] = reader[5];
                result[6] = reader[6];
            }
            reader.Close();
            return result;
        }
        public List<object[]> getAllDosen()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Dosen\";");
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
                field_values[6] = reader[6];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }      
        public object[] getAttributes(int id_dosen)
        {
            object[] result = new object[7];
            object[] dosen = getDosenById(id_dosen);
            result[0] = (int)dosen[0];
            result[1] = dosen[1];
            result[2] = dosen[2];
            result[3] = dosen[3];
            result[4] = dosen[4];
            result[5] = dosen[5];
            result[6] = dosen[6];
            return result;
        }
        public void sendDosen(object[] dosen)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Akun_Dosen\" (nip, nidn, nama_dosen, no_wa, email, kata_sandi) VALUES ('{dosen[0]}','{dosen[1]}','{dosen[2]}','{dosen[3]}','{dosen[4]}','{dosen[5]}');");
        }
        public void updateKataSandi(int id_dosen, string kata_sandi_baru)
        {
            Database.Database.sendData($"UPDATE \"Data_Akun_Dosen\" SET kata_sandi = '{kata_sandi_baru}' WHERE id_dosen = {id_dosen}");
        }
    }
}
