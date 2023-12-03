using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baskom.Model;

namespace Baskom.Controller
{

    internal class c_DetailValidasiKonversiSKS
    {
        m_DataKonversiSks m_DataKonversiSks;
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataMataKuliah m_DataMataKuliah;
        object[] identitas_mhs;
        string nim;
        public c_DetailValidasiKonversiSKS(string nim,m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataKonversiSks m_DataKonversiSks, m_DataMataKuliah m_DataMataKuliah)
        {
            this.nim = nim;
            this.identitas_mhs = m_DataAkunMahasiswa.getMahasiswaByNim(nim);
            this.m_DataKonversiSks = m_DataKonversiSks;
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataMataKuliah = m_DataMataKuliah;

        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new List<object[]>();
            List<object[]> data_konversi_sks = m_DataKonversiSks.getAllKonversiSksByIdMhs((int)identitas_mhs[0]);
            foreach (object[] konversi_sks in data_konversi_sks)
            {
                object[] items = new object[6];
                object[] matkul = m_DataMataKuliah.getMataKuliahById((int)konversi_sks[4]);
                items[0] = konversi_sks[1];
                items[1] = konversi_sks[2];
                items[2] = matkul[2];
                items[3] = matkul[3];
                items[4] = konversi_sks[3];
                items[5] = konversi_sks[0];
                result.Add(items);
            }
            return result;
        }
        public string simpanData(List<int> list_id_konversi_sks, List<int> list_status_validasi)
        {
            for (int i = 0; i < list_id_konversi_sks.Count; i++)
            {
                m_DataKonversiSks.updateKonversiSks(list_id_konversi_sks[i], list_status_validasi[i]);
            }
            return "Perubahan Berhasil Disimpan!";
        }
    }
}
