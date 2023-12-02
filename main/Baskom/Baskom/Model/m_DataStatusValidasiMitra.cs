using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    internal class m_DataStatusValidasiMitra
    {
        public List<string> getAllStatusValidasiMitra()
        {
            List<string> result = new List<string>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT status_validasi FROM \"Data_Status_Validasi_Mitra\";");
            while (reader.Read())
            {
                result.Add((string)reader[0]);
            }
            reader.Close();
            return result;
        }
        public string getStatusValidasiMitraById(int id_status_validasi)
        {
            string result = "";
            NpgsqlDataReader reader = Database.Database.getData($"SELECT status_validasi FROM \"Data_Status_Validasi_Mitra\" WHERE id_status_validasi = {id_status_validasi};");
            while (reader.Read())
            {
                result = (string)reader[0];
            }
            reader.Close();
            return result;
        }
        public int getIdValidasiMitraByStatus(string status_validasi)
        {
            int result = 0;
            NpgsqlDataReader reader = Database.Database.getData($"SELECT id_status_validasi FROM \"Data_Status_Validasi_Mitra\" WHERE status_validasi = '{status_validasi}';");
            while (reader.Read())
            {
                result = (int)reader[0];
            }
            reader.Close();
            return result;
        }
    }
}
