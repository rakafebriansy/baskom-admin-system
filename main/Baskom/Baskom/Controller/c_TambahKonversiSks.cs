using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_TambahKonversiSks
    {
        private m_DataKonversiSks m_DataKonversiSks;
        private m_DataMataKuliah m_DataMataKuliah;
        private m_DataMataKuliahTempuh m_DataMataKuliahTempuh;
        private m_DataPenerimaanMitra m_DataPenerimaanMitra;

        public c_TambahKonversiSks(m_DataKonversiSks m_DataKonversiSks, m_DataMataKuliah m_DataMataKuliah, m_DataMataKuliahTempuh m_DataMataKuliahTempuh, m_DataPenerimaanMitra m_DataPenerimaanMitra)
        {
            this.m_DataKonversiSks = m_DataKonversiSks;
            this.m_DataMataKuliah = m_DataMataKuliah;
            this.m_DataMataKuliahTempuh = m_DataMataKuliahTempuh;
            this.m_DataPenerimaanMitra = m_DataPenerimaanMitra;
        }

        public List<object[]> initDataGridView(int id_mahasiswa)
        {
            List<object[]> result = this.m_DataKonversiSks.getAllKonversiSksByIdMhs(id_mahasiswa);
            return result;
        }

        public List<object[]> getMatkulSKS(List<int> id_matkul)
        {
            List<object[]> result = this.m_DataMataKuliah.getAllMatkulByIdMatkul(id_matkul);
            return result;
        }

        public void hapusDataSKS(int id_mahasiswa, int id_matkul)
        {
            this.m_DataKonversiSks.deleteDataKonversiSks(id_mahasiswa, id_matkul);
        }

        public List<object[]> getAllNonMatkulTempuh(int id_mahasiswa)
        {
            List<int> list_id_matkul_tempuh = this.m_DataMataKuliahTempuh.getAllIdMatkulByIdMhs(id_mahasiswa);
            List<object[]> result = this.m_DataMataKuliah.getAllNonMatkulTempuhByIdMatkulTempuh(list_id_matkul_tempuh);
            return result;
        }

        public int getJumlahMaksSKS(int id_mahasiswa)
        {
            object[] penerimaan_mitra = m_DataPenerimaanMitra.getPenerimaanMitraByIdMhs(id_mahasiswa);
            return (int)penerimaan_mitra[3];
        }

        public void tambahKonversiSks(object[] konversiSksBaru)
        {
            m_DataKonversiSks.sendDataKonversiSks(konversiSksBaru);
        }
    }
}
