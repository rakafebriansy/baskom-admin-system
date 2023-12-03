using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baskom.Model;

namespace Baskom.Controller
{
    internal class c_MemvalidasiKonversiSks
    {
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataKonversiSks m_DataKonversiSks;
        m_DataProdi m_DataProdi;
        m_DataPenerimaanMitra m_DataPenerimaanMitra;
        m_DataMitra m_DataMitra;
        m_DataProgram m_DataProgram;
        m_DataPembagianTugas m_DataPembagianTugas;
        object[] data_akun_pengguna;
        public c_MemvalidasiKonversiSks(m_DataKonversiSks m_DataKonversiSks, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataProdi m_DataProdi, m_DataPenerimaanMitra m_DataPenerimaanMitra, m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataPembagianTugas m_DataPembagianTugas, m_DataAkunTimmbkm data_akun_pengguna)
        {
            this.m_DataKonversiSks = m_DataKonversiSks;
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
            List<object[]> data_konversi_sks = m_DataKonversiSks.getAllKonversiSks();
            foreach (object[] konversi_sks in data_konversi_sks)
            {
                object[] mahasiswa = m_DataAkunMahasiswa.getMahasiswaById((int)konversi_sks[5]);
                object[] pembagian_tugas = m_DataPembagianTugas.getPembagianTugasByIdMhs((int)mahasiswa[0]);
                if ((int)pembagian_tugas[2] == (int)this.data_akun_pengguna[0])
                {
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
