using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataMataKuliah
    {
        public List<object[]> getAllMataKuliah()
        {
            List<object[]> result = new List<object[]>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Mata_Kuliah\";");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                field_values[2] = reader[2];
                field_values[3] = reader[3];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public List<object[]> getAllMatkulByIdMatkul(List<int> list_id_matkul_tempuh)
        {
            List<object[]> result = new List<object[]>();

            foreach (object id_matkul in list_id_matkul_tempuh)
            {
                NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Mata_Kuliah\" WHERE id_matkul = {(int)id_matkul};");
                int field_count = reader.FieldCount;
                while (reader.Read())
                {
                    object[] field_values = new object[field_count];
                    field_values[0] = reader[0];
                    field_values[1] = reader[1];
                    field_values[2] = reader[2];
                    field_values[3] = reader[3];
                    result.Add(field_values);
                }
                reader.Close();
            }
            return result;
        }        
        public List<object[]> getAllNonMatkulTempuhByIdMatkulTempuh(List<object[]> list_id_matkul_tempuh)
        {
            List<object[]> result = new List<object[]>();

            foreach (object[] item in list_id_matkul_tempuh)
            {
                NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Mata_Kuliah\" WHERE id_matkul = {(int)item[0]};");
                int field_count = reader.FieldCount;
                while (reader.Read())
                {
                    object[] field_values = new object[field_count];
                    field_values[0] = reader[0];
                    field_values[1] = reader[1];
                    field_values[2] = reader[2];
                    field_values[3] = reader[3];
                    result.Add(field_values);
                }
                reader.Close();
            }
            return result;
        }
        public List<object[]> getAllNonMatkulTempuhByIdMatkulTempuh(List<int> list_id_matkul_tempuh)
        {
            List<object[]> result = new List<object[]>();

            NpgsqlDataReader reader = Database.Database.getBindData(list_id_matkul_tempuh,$"SELECT * FROM \"Data_Mata_Kuliah\" WHERE NOT (id_matkul = ANY(ARRAY[:data]));");
            int field_count = reader.FieldCount;
            while (reader.Read())
            {
                object[] field_values = new object[field_count];
                field_values[0] = reader[0];
                field_values[1] = reader[1];
                field_values[2] = reader[2];
                field_values[3] = reader[3];
                result.Add(field_values);
            }
            reader.Close();
            return result;
        }
        public void sendMataKuliah(object[] matkul)
        {
            string query = $"INSERT INTO \"Data_Mata_Kuliah\" (kode_matkul, nama_matkul, sks) VALUES ('{matkul[0]}','{matkul[1]}',{matkul[2]});";
            Database.Database.sendData(query);
        }
        public object[] getMataKuliahById(int id_matkul)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Mata_Kuliah\" WHERE id_matkul = {id_matkul};");
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

        public object[] getMataKuliahByNama(string nama_matkul)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Mata_Kuliah\" WHERE nama_matkul = '{nama_matkul}';");
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

        public object[] getMataKuliahByKode(string kode_matkul)
        {
            NpgsqlDataReader reader = Database.Database.getData($"SELECT * FROM \"Data_Mata_Kuliah\" WHERE kode_matkul = '{kode_matkul}';");
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
    }
}
