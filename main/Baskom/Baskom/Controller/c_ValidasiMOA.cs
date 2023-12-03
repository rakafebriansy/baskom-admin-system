using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Baskom.Controller
{
    internal class c_ValidasiMOA
    {
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataPengajuanMitra m_DataPengajuanMitra;
        m_DataStatusValidasiMitra m_DataStatusValidasiMitra;
        m_DataMitra m_DataMitra;
        public c_ValidasiMOA(m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataPengajuanMitra m_DataPengajuanMitra, m_DataStatusValidasiMitra m_DataStatusValidasiMitra, m_DataMitra m_DataMitra)
        {
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataPengajuanMitra = m_DataPengajuanMitra;
            this.m_DataStatusValidasiMitra = m_DataStatusValidasiMitra;
            this.m_DataMitra = m_DataMitra;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new List<object[]>();
            List<object[]> data_pengajuan_mitra = m_DataPengajuanMitra.getAllPengajuanMitra();
            foreach (object[] pengajuan in data_pengajuan_mitra)
            {
                object[] items = new object[5];
                object[] mahasiswa = m_DataAkunMahasiswa.getMahasiswaById((int)pengajuan[4]);
                string status_validasi_mitra = m_DataStatusValidasiMitra.getStatusValidasiMitraById((int)pengajuan[3]);
                items[0] = mahasiswa[2];
                items[1] = pengajuan[1];
                items[2] = pengajuan[2];
                items[3] = status_validasi_mitra;
                items[4] = (int)pengajuan[0];
                result.Add(items);
            }
            return result;
        }
        public List<string> initDgvComboBox()
        {
            return m_DataStatusValidasiMitra.getAllStatusValidasiMitra();
        }
        public string simpanData(List<string> data_status, List<int> data_id)
        {
            for (int i = 0; i < data_id.Count; i++)
            {
                int id_validasi = m_DataStatusValidasiMitra.getIdValidasiMitraByStatus(data_status[i]);
                m_DataPengajuanMitra.updateStatusValidasi(id_validasi, data_id[i]);
            }
            return "Perubahan Berhasil Disimpan!";
        }
        public void addMitra(object[] hasil)
        {
            m_DataMitra.addMitra(hasil);
        }
    }
}
