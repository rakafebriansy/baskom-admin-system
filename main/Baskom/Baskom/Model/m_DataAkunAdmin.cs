using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunAdmin
    {
        private int id_admin;
        private string email;
        private string nama_admin;
        private string kata_sandi;

        public bool cekLoginAdmin(string email, string kata_sandi)
        {
            object[] data_admin = getAdminByEmail(email);
            if ((string)data_admin[3] == kata_sandi)
            {
                this.id_admin = (int)data_admin[0];
                this.email = email;
                this.kata_sandi = kata_sandi;
                this.nama_admin = (string)data_admin[1];
                return true;
            }
            return false;
        }
        public object[] getAdminByEmail(string email)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Admin\" WHERE email = '{email}'");
            int field_count = reader.FieldCount;
            object[] result = new object[field_count];
            while (reader.Read())
            {
                result[0] = reader[0];
                result[1] = reader[1];
                result[2] = reader[2];
                result[3] = reader[3];
            }
            reader.Close();
            return result;
        }

        public object[] getAttributes()
        {
            object[] result = new object[4];
            result[0] = this.id_admin;
            result[1] = this.nama_admin;
            result[2] = this.email;
            result[3] = this.kata_sandi;
            return result;
        }
        public void updateKataSandi(int id_admin, string kata_sandi_baru)
        {
            Database.Database.sendData($"UPDATE \"Data_Akun_Admin\" SET kata_sandi = '{kata_sandi_baru}' WHERE id_admin = {id_admin}");
            this.kata_sandi = kata_sandi_baru;
        }
    }
}
