using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_MemvalidasiKonversiNilai
    {
        m_DataAkunDosen m_DataAkunDosen;
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataKonversiNilai m_DataKonversiNilai;
        m_DataKonversiSks m_DataKonversiSks;
        m_DataProdi m_DataProdi;
        m_DataPenerimaanMitra m_DataPenerimaanMitra;
        m_DataMitra m_DataMitra;
        m_DataProgram m_DataProgram;
        m_DataPembagianTugas m_DataPembagianTugas;
        object[] data_akun_pengguna;
        public c_MemvalidasiKonversiNilai(m_DataKonversiSks m_DataKonversiSks, m_DataKonversiNilai m_DataKonversiNilai, m_DataAkunDosen m_DataAkunDosen, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataProdi m_DataProdi, m_DataPenerimaanMitra m_DataPenerimaanMitra, m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataPembagianTugas m_DataPembagianTugas, m_DataAkunTimmbkm data_akun_pengguna)
        {
            this.m_DataKonversiSks = m_DataKonversiSks;
            this.m_DataKonversiNilai = m_DataKonversiNilai;
            this.m_DataAkunDosen = m_DataAkunDosen;
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataProdi = m_DataProdi;
            this.m_DataPenerimaanMitra = m_DataPenerimaanMitra;
            this.m_DataMitra = m_DataMitra;
            this.m_DataProgram = m_DataProgram;
            this.m_DataPembagianTugas = m_DataPembagianTugas;
            this.data_akun_pengguna = data_akun_pengguna.getAttributes();

        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new List<object[]>();

            List<object[]> pembagian_tugas = m_DataPembagianTugas.getAllPembagianTugas();
            List<int> list_id_mhs = new List<int>();
            foreach (object[] pembagian in pembagian_tugas)
            {
                if ((int)pembagian[2] == (int)data_akun_pengguna[0])
                {
                    list_id_mhs.Add((int)pembagian[1]);
                }
            }

            List<object[]> data_konversi_sks = m_DataKonversiSks.getAllKonversiSksByListMhs(list_id_mhs);
            List<object[]> data_konversi_nilai = m_DataKonversiNilai.getAllKonversiNilai();

            List<object[]> data_konversi_nilai_pic = new List<object[]>();
            List<object[]> data_konversi_sks_pic = new List<object[]>();
            for (int i = 0; i < data_konversi_nilai.Count; i++)
            {
                for (int j = 0; j < data_konversi_sks.Count; j++)
                {
                    if ((int)data_konversi_nilai[i][4] == (int)data_konversi_sks[j][0])
                    {
                        data_konversi_nilai_pic.Add(data_konversi_nilai[i]);
                        data_konversi_sks_pic.Add(data_konversi_sks[j]);
                    }
                }
            }

            for (int i = 0; i < data_konversi_nilai_pic.Count; i++)
            {
                object[] mahasiswa = m_DataAkunMahasiswa.getMahasiswaById((int)data_konversi_sks_pic[i][5]);
                object[] petugas = m_DataPembagianTugas.getPembagianTugasByIdMhs((int)data_konversi_sks_pic[i][5]);

                object[] items = new object[5];
                object[] penerimaan_mitra = m_DataPenerimaanMitra.getPenerimaanMitraByIdMhs((int)mahasiswa[0]);
                object[] mitra = m_DataMitra.getMitraById((int)penerimaan_mitra[6]);
                object[] program = m_DataProgram.getProgramById((int)penerimaan_mitra[9]);
                string nama_prodi = m_DataProdi.getNamaProdiById((int)mahasiswa[9]);
                items[0] = mahasiswa[2];
                items[1] = mahasiswa[1];
                items[2] = nama_prodi;
                items[3] = mitra[1];
                items[4] = program[1];
                result.Add(items);
            }

            List<object[]> result2 = result;

            for (int i = 0; i < result.Count(); i++)
            {
                for (int j = 0; j < result.Count(); j++)
                {
                    if (result[i][1].ToString() == result[j][1].ToString())
                    {
                        result2.RemoveAt(j);
                    }
                }
            }
            return result2;
        }
    }
}
