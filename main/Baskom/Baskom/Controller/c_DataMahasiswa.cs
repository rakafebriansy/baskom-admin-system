using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_DataMahasiswa
    {
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataPembagianTugas m_DataPembagianTugas;
        m_DataAkunTimmbkm m_DataAkunTimmbkm;
        m_DataAkunDosen m_DataAkunDosen;
        public c_DataMahasiswa(m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataPembagianTugas m_DataPembagianTugas, m_DataAkunTimmbkm m_DataAkunTimmbkm, m_DataAkunDosen m_DataAkunDosen)
        {
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataPembagianTugas = m_DataPembagianTugas;
            this.m_DataAkunTimmbkm = m_DataAkunTimmbkm;
            this.m_DataAkunDosen = m_DataAkunDosen;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new();
            List<object[]> data_mahasiswa = this.m_DataAkunMahasiswa.getAllMahasiswa();
            foreach (object[] mahasiswa in data_mahasiswa)
            {
                object[] items = new object[3];  
                object[] pembagian_tugas = this.m_DataPembagianTugas.getPembagianTugasByIdMhs((int)mahasiswa[0]);
                object[] timmbkm = this.m_DataAkunTimmbkm.getTimmbkmById((int)pembagian_tugas[2]);
                object[] dosen = this.m_DataAkunDosen.getDosenById((int)timmbkm[2]);
                items[0] = mahasiswa[2];
                items[1] = mahasiswa[1];
                items[2] = dosen[3];
                result.Add(items);
            }
            return result;
        }
    }
}
