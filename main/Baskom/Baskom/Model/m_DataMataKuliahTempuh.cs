using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Model
{
    class m_DataMataKuliahTempuh
    {
        public List<int> getAllIdMatkulByIdMhs(int id_mahasiswa)
        {
            List<int> result = new List<int>();
            NpgsqlDataReader reader = Database.Database.getData($"SELECT id_matkul FROM \"Data_Mata_Kuliah_Tempuh\" WHERE id_mahasiswa = {id_mahasiswa};");
            while (reader.Read())
            {
                result.Add((int)reader[0]);
            }
            reader.Close();
            return result;
        }

        public void sendMatkulByIdMahasiswa(int matkultempuh_id_matkul, int matkultempuh_id_mahasiswa)
        {
            string query = $"INSERT INTO \"Data_Mata_Kuliah_Tempuh\" (id_matkul, id_mahasiswa) VALUES ('{matkultempuh_id_matkul}',{matkultempuh_id_mahasiswa});";
            Database.Database.sendData(query);
        }

        public void hapusMataKuliah(int id_mahasiswa, int id_matkul)
        {
            string query = $"DELETE FROM \"Data_Mata_Kuliah_Tempuh\" WHERE id_matkul = {id_matkul} and id_mahasiswa = {id_mahasiswa};";
            Database.Database.sendData(query);
        }
    }
}
