using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataAkunMahasiswa
    {
        private int id_mahasiswa;
        private string nim;
        private string nama_mahasiswa;
        private int tahun_masuk;
        private bool status_mahasiswa;
        private string no_wa;
        private int batch_mbkm;
        private string email;
        private string kata_sandi;
        private int id_prodi;

        public bool cekLoginMahasiswa(string nim, string kata_sandi)
        {
            object[] result = getMahasiswaByNim(nim);
            if ((string)result[1] == nim)
            {
                if ((string)result[8] == kata_sandi)
                {
                    this.id_mahasiswa = (int)result[0];
                    this.nim = (string)result[1];
                    this.nama_mahasiswa = (string)result[2];
                    this.tahun_masuk = (int)result[3];
                    this.status_mahasiswa = Convert.ToInt32(result[4]) == 1? true:false;
                    this.no_wa = (string)result[5];
                    this.batch_mbkm = (int)result[6];
                    this.email = (string)result[7];
                    this.kata_sandi = (string)result[8];
                    this.id_prodi = (int)result[9];
                    return true;
                }
                return false;
            }
            return false;
        }
        public object[] getMahasiswaByNim(string nim)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Mahasiswa\" WHERE nim = '{nim}'");
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
                result[7] = reader[7];
                result[8] = reader[8];
                result[9] = reader[9];
            }
            reader.Close();
            return result;
        }        
        public object[] getMahasiswaById(int id_mahasiswa)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Mahasiswa\" WHERE id_mahasiswa = {id_mahasiswa}");
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
                result[7] = reader[7];
                result[8] = reader[8];
                result[9] = reader[9];
            }
            reader.Close();
            return result;
        }
        public List<object[]> getAllMahasiswa()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Akun_Mahasiswa\";");
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
                field_values[7] = reader[7];
                field_values[8] = reader[8];
                field_values[9] = reader[9];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public object[] getAttributes()
        {
            m_DataProdi m_DataProdi = new();
            string nama_prodi = m_DataProdi.getNamaProdiById(id_prodi);
            object[] result = new object[10];
            result[0] = (int)this.id_mahasiswa;
            result[1] = this.nim;
            result[2] = this.nama_mahasiswa;
            result[3] = this.tahun_masuk;
            result[4] = this.status_mahasiswa;
            result[5] = this.no_wa;
            result[6] = this.batch_mbkm;
            result[7] = this.email;
            result[8] = this.kata_sandi;
            result[9] = nama_prodi;
            return result;
        }
        public void sendMahasiswa(object[] mahasiswa)
        {
            Database.Database.sendData($"INSERT INTO \"Data_Akun_Mahasiswa\" (nim,nama_mahasiswa,tahun_masuk,status_mahasiswa,no_wa,batch_mbkm,email,kata_sandi,id_prodi) VALUES ('{mahasiswa[0]}','{mahasiswa[1]}',{mahasiswa[2]},{mahasiswa[3]},'{mahasiswa[4]}',{mahasiswa[5]},'{mahasiswa[6]}','{mahasiswa[7]}',{mahasiswa[8]});");
        }
        public void updateKataSandi(int id_mahasiswa,string kata_sandi_baru)
        {
            Database.Database.sendData($"UPDATE \"Data_Akun_Mahasiswa\" SET kata_sandi = '{kata_sandi_baru}' WHERE id_mahasiswa = {id_mahasiswa}");
            this.kata_sandi = kata_sandi_baru;
        }
    }
}
