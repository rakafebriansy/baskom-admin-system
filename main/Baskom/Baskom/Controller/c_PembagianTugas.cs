using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_PembagianTugas
    {
        m_DataPembagianTugas m_DataPembagianTugas;
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataProgram m_DataProgram;
        m_DataMitra m_DataMitra;
        m_DataAkunDosen m_DataAkunDosen;
        m_DataPenerimaanMitra m_DataPenerimaanMitra;
        m_DataProdi m_DataProdi;
        m_DataAkunTimmbkm m_DataAkunTimmbkm;
        object[] data_akun_pengguna;
        public c_PembagianTugas(m_DataPembagianTugas m_DataPembagianTugas, m_DataPenerimaanMitra m_DataPenerimaanMitra, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataAkunDosen m_DataAkunDosen, m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataProdi m_DataProdi, m_DataAkunTimmbkm data_akun_pengguna)
        {
            this.m_DataPembagianTugas = m_DataPembagianTugas;
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataProgram = m_DataProgram;
            this.m_DataMitra = m_DataMitra;
            this.m_DataAkunDosen = m_DataAkunDosen;
            this.m_DataPenerimaanMitra = m_DataPenerimaanMitra;
            this.m_DataProdi = m_DataProdi;
            this.m_DataAkunTimmbkm = data_akun_pengguna;
            this.data_akun_pengguna = data_akun_pengguna.getAttributes();
        }
        public List<object[]> initDataGridView()
        {

            List<object[]> result = new List<object[]>();
            List<object[]> data_pembagian_tugas = m_DataPembagianTugas.getAllPembagianTugas();
            foreach (object[] pembagian_tugas in data_pembagian_tugas)
            {
                //if ((int)pembagian_tugas[2] == (int)this.data_akun_pengguna[0])
                //{
                    object[] items = new object[6];
                    object[] mahasiswa = m_DataAkunMahasiswa.getMahasiswaById((int)pembagian_tugas[1]);
                    object[] penerimaan_mitra = m_DataPenerimaanMitra.getPenerimaanMitraByIdMhs((int)pembagian_tugas[1]);
                    object[] timmbkm = m_DataAkunTimmbkm.getTimmbkmById((int)pembagian_tugas[2]);
                    items[0] = (string)mahasiswa[2];
                    items[1] = (string)mahasiswa[1];
                    items[2] = m_DataProdi.getNamaProdiById((int)mahasiswa[9]);
                    items[3] = (string)m_DataMitra.getMitraById((int)penerimaan_mitra[6])[1];
                    items[4] = (string)m_DataProgram.getProgramById((int)penerimaan_mitra[9])[1];
                    items[5] = (string)m_DataAkunDosen.getDosenById((int)timmbkm[2])[3];
                    result.Add(items);
                //}
            }
            return result;
        }
    }
}
