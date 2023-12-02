using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Baskom.Model;

namespace Baskom.Controller
{
    internal class c_TambahMahasiswa
    {
        private m_DataAkunMahasiswa m_DataAkunMahasiswa;
        private m_DataProdi m_DataProdi;
        private m_DataAkunTimmbkm m_DataAkunTimmbkm;
        private m_DataAkunDosen m_DataAkunDosen;
        private m_DataPembagianTugas m_DataPembagianTugas;
        public c_TambahMahasiswa(m_DataAkunMahasiswa m_DataAkunMahasiswa,m_DataProdi m_DataProdi, m_DataAkunTimmbkm m_DataAkunTimmbkm, m_DataAkunDosen m_DataAkunDosen, m_DataPembagianTugas m_DataPembagianTugas)
        {
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataProdi = m_DataProdi;
            this.m_DataAkunTimmbkm = m_DataAkunTimmbkm;
            this.m_DataAkunDosen = m_DataAkunDosen;
            this.m_DataPembagianTugas = m_DataPembagianTugas;
        }

        public List<string> initProdi()
        {
            return m_DataProdi.getAllNamaProdi();
        }
        public List<string> initNamaTimmbkm()
        {
            List<string> list_nama_timmbkm = new List<string>();
            List<object[]> timmbkm = m_DataAkunTimmbkm.getAllTimmbkm();
            foreach (object[] t in timmbkm)
            {
                object[] nama_dosen = m_DataAkunDosen.getDosenById((int)t[2]);
                list_nama_timmbkm.Add((string)nama_dosen[3]);
            }
            return list_nama_timmbkm;
        }
        public string tambahMahasiswaBaru(object[] mhs)
        {
            object[] mahasiswa = mhs;
            List<object[]> data_mahasiswa = this.m_DataAkunMahasiswa.getAllMahasiswa();
            string message = "";
            foreach (object[] item in data_mahasiswa)
            {
                if (item[1].ToString() == mahasiswa[0].ToString())
                {
                    message = "NIM Telah Digunakan!";
                    return message;
                }
                else if (item[5].ToString() == mahasiswa[4].ToString())
                {
                    message = "Nomor WhatsApp Telah Digunakan!";
                    return message;
                }
                else if (item[7].ToString() == mahasiswa[6].ToString())
                {
                    message = "Email Telah Digunakan!";
                    return message;
                }
            }
            int id_prodi = m_DataProdi.getIdProdiByNama((string)mahasiswa[8]);
            mahasiswa[8] = id_prodi;
            this.m_DataAkunMahasiswa.sendMahasiswa(mahasiswa);

            object[] dosen = m_DataAkunDosen.getDosenByNama((string)mahasiswa[9]);
            object[] timmbkm = m_DataAkunTimmbkm.getTimmbkmByNidn((string)dosen[2]);
            mahasiswa = this.m_DataAkunMahasiswa.getMahasiswaByNim((string)mahasiswa[0]);
            this.m_DataPembagianTugas.sendPembagianTugas((int)mahasiswa[0], (int)timmbkm[0]);
            return message;
        }
    }
}
