using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_TambahMataKuliahTempuh
    {
        m_DataMataKuliah m_DataMataKuliah;
        m_DataMataKuliahTempuh m_DataMataKuliahTempuh;
        m_DataKonversiSks m_DataKonversiSks;

        public c_TambahMataKuliahTempuh(m_DataMataKuliah m_DataMataKuliah, m_DataMataKuliahTempuh m_DataMataKuliahTempuh, m_DataKonversiSks m_DataKonversiSks)
        {
            this.m_DataMataKuliah = m_DataMataKuliah;
            this.m_DataMataKuliahTempuh = m_DataMataKuliahTempuh;
            this.m_DataKonversiSks = m_DataKonversiSks;
        }

        public List<object[]> initDataGridView(int id_mahasiswa)
        {
            List<int> list_id_matkul_tempuh = this.m_DataMataKuliahTempuh.getAllIdMatkulByIdMhs(id_mahasiswa);
            List<object[]> result = this.m_DataMataKuliah.getAllMatkulByIdMatkul(list_id_matkul_tempuh);
            return result;
        }

        public List<object[]> getListKonversiSks(int id_mahasiswa)
        {
            List<object[]> result = this.m_DataKonversiSks.getAllKonversiSksByIdMhs(id_mahasiswa);
            return result;
        }

        public List<object[]> getMatkulSKS(List<int> id_matkul)
        {
            List<object[]> result = this.m_DataMataKuliah.getAllMatkulByIdMatkul(id_matkul);
            return result;
        }

        public List<object[]> getAllNonMatkulTempuh(int id_mahasiswa)
        {
            List<int> list_id_matkul_tempuh = this.m_DataMataKuliahTempuh.getAllIdMatkulByIdMhs(id_mahasiswa);
            List<object[]> result = this.m_DataMataKuliah.getAllNonMatkulTempuhByIdMatkulTempuh(list_id_matkul_tempuh);
            return result;
        }

        public void tambahMataKuliahTempuh(object[] matkul)
        {
            m_DataMataKuliahTempuh.sendMatkulByIdMahasiswa((int)matkul[0], (int)matkul[1]);
        }
    }
}
