using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunTimmbkm
    {
        private int id_timmbkm;
        private string nidn;
        private int timmbkm_id_dosen;

        public bool cekLoginTimmbkm(string nidn, string kata_sandi)
        {
            m_DataAkunDosen m_DataAkunDosen = new();
            object[] result = getTimmbkmByNidn(nidn);
            try
            {
                object[] dosen = m_DataAkunDosen.getDosenById((int)result[2]);
                if (dosen[6].ToString() == kata_sandi)
                {
                    this.id_timmbkm = (int)result[0];
                    this.nidn = nidn;
                    this.timmbkm_id_dosen = (int)result[2];
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return false;
        }
        public object[] getTimmbkmByNidn(string nidn)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Timmbkm\" WHERE nidn = '{nidn}'");
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
        public object[] getTimmbkmById(int id_timmbkm)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Timmbkm\" WHERE id_timmbkm = {id_timmbkm}");
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
        public object[] getDosenAttributes()
        {
             m_DataAkunDosen m_DataAkunDosen = new();
            return m_DataAkunDosen.getAttributes(this.timmbkm_id_dosen);
        }
        public void sendTimmbkm(string nidn, int id_dosen)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Akun_Timmbkm\" (nidn,id_dosen) VALUES ('{nidn}',{id_dosen});");
        }

        public List<object[]> getAllTimmbkm()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Timmbkm\";");
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
        public object[] getAttributes()
        {
            object[] result = new object[3];
            result[0] = this.id_timmbkm;
            result[1] = this.nidn;
            result[2] = this.timmbkm_id_dosen;
            return result;
        }
    }
}
