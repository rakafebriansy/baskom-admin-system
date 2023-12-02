using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_DetailValidasiKonversiNilai
    {
        m_DataKonversiNilai m_DataKonversiNilai;
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataMataKuliah m_DataMataKuliah;
        m_DataKonversiSks m_DataKonversiSks;
        string nim;
        public c_DetailValidasiKonversiNilai(string nim, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataKonversiNilai m_DataKonversiNilai, m_DataKonversiSks m_DataKonversiSks, m_DataMataKuliah m_DataMataKuliah)
        {
            this. nim = nim;
            this.m_DataKonversiNilai = m_DataKonversiNilai;
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataKonversiSks = m_DataKonversiSks;
            this.m_DataMataKuliah = m_DataMataKuliah;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new List<object[]>();
            object[] mahasiswa = m_DataAkunMahasiswa.getMahasiswaByNim(this.nim);
            List<object[]> data_konversi_sks = m_DataKonversiSks.getAllKonversiSksByIdMhs((int)mahasiswa[0]);
            foreach (object[] konversi_sks in data_konversi_sks)
            {
                object[] konversi_nilai = m_DataKonversiNilai.getKonversiNilaiByIdKonversiSks((int)konversi_sks[0]);
                object[] items = new object[6];
                items[0] = (string)konversi_sks[1];
                items[1] = konversi_sks[2];
                items[2] = konversi_nilai[1];
                items[3] = konversi_nilai[2];
                items[4] = konversi_nilai[3];
                items[5] = konversi_nilai[0];
                result.Add(items);
            }
            return result;
        }
        public string simpanData(List<int> list_id_konversi_nilai, List<int> list_status_validasi)
        {
            for (int i = 0; i < list_id_konversi_nilai.Count;i++)
            {
                m_DataKonversiNilai.updateKonversiNilai(list_id_konversi_nilai[i], list_status_validasi[i]);
            }
            return "Perubahan Berhasil Disimpan!";
        }
    }
}
