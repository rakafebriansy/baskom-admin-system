using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_DetailMahasiswa
    {
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataProdi m_DataProdi;
        public c_DetailMahasiswa(m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataProdi m_DataProdi)
        {
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataProdi = m_DataProdi;
        }
        public object[] initProfile(string nim)
        {
            object[] mhs = m_DataAkunMahasiswa.getMahasiswaByNim(nim);
            object[] new_mhs = new object[mhs.Length];
            new_mhs[0] = mhs[0];
            new_mhs[1] = mhs[1];
            new_mhs[2] = mhs[2];
            new_mhs[3] = mhs[3];
            new_mhs[4] = mhs[4];
            new_mhs[5] = mhs[5];
            new_mhs[6] = mhs[6];
            new_mhs[7] = mhs[7];
            new_mhs[8] = mhs[8];
            new_mhs[9] = (string)m_DataProdi.getNamaProdiById(3);
            return new_mhs;
        }
    }
}
