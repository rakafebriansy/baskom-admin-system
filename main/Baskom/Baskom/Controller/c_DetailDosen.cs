using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_DetailDosen
    {
        m_DataAkunDosen m_DataAkunDosen;
        m_DataAkunTimmbkm m_DataAkunTimmbkm;
        public c_DetailDosen(m_DataAkunDosen m_DataAkunDosen, m_DataAkunTimmbkm m_DataAkunTimmbkm)
        {
            this.m_DataAkunDosen = m_DataAkunDosen;
            this.m_DataAkunTimmbkm = m_DataAkunTimmbkm;
        }
        public object[] initProfile(string nip)
        {
            return m_DataAkunDosen.getDosenByNip(nip);
        }
        public bool cekTimmbkm(string nidn)
        {
            try
            {
                object[] timmbkm = m_DataAkunTimmbkm.getTimmbkmByNidn(nidn);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
