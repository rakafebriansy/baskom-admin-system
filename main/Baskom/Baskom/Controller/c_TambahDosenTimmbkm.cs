using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_TambahDosenTimmbkm
    {
        private m_DataAkunTimmbkm m_DataAkunTimmbkm;
        private m_DataAkunDosen m_DataAkunDosen;
        public c_TambahDosenTimmbkm(m_DataAkunTimmbkm m_DataAkunTimmbkm, m_DataAkunDosen m_DataAkunDosen)
        {
            this.m_DataAkunTimmbkm = m_DataAkunTimmbkm;
            this.m_DataAkunDosen = m_DataAkunDosen;
        }
        public string tambahDosenBaru(object[] dosen)
        {
            List<object[]> data_dosen = this.m_DataAkunDosen.getAllDosen();
            string message = "";
            foreach (object[] item in data_dosen)
            {
                if (item[1].ToString() == dosen[0].ToString())
                {
                    message = "NIP Telah Digunakan!";
                    return message;
                }
                else if (item[2].ToString() == dosen[1].ToString())
                {
                    message = "NIDN Telah Digunakan!";
                    return message;
                }               
                else if (item[4].ToString() == dosen[3].ToString())
                {
                    message = "Nomor WhatsApp Telah Digunakan!";
                    return message;
                }
                else if (item[5].ToString() == dosen[4].ToString())
                {
                    message = "Email Telah Digunakan!";
                    return message;
                }
            }
            this.m_DataAkunDosen.sendDosen(dosen);
            message = "Data Dosen Berhasil Ditambahkan!";
            return message;
        }
        public string tambahTimmbkmBaru(object[] dosen)
        {
            object[] timmbkm = this.m_DataAkunTimmbkm.getTimmbkmByNidn((string)dosen[1]);
            object[] dosenbaru = this.m_DataAkunDosen.getDosenByNidn((string)dosen[1]);
            List<object[]> dosenLama = this.m_DataAkunDosen.getAllDosen();
            string message = "";

            bool available = true;
            foreach (var item in timmbkm)
            {
                if (item == null)
                {
                    available = false;
                }
            }

            if (available)
            {
                message = "NIDN Telah Terdaftar di TimMbkm!";
                return message;
            }
            else
            {
                foreach (object[] item in dosenLama)
                {
                    if ((string)dosen[0] == (string)item[1] && (string)dosen[1] == (string)item[2])
                    {
                        break;
                    }
                    else if ((string)dosen[0] == (string)item[1])
                    {
                        message = "NIP Telah Digunakan";
                        return message;
                    }
                    else if ((string)dosen[1] == (string)item[2])
                    {
                        message = "NIDN Telah Digunakan";
                        return message;
                    }
                }

                this.m_DataAkunTimmbkm.sendTimmbkm((string)dosen[1], (int)dosenbaru[0]);
                message = "Data TimMbkm Berhasil Ditambahkan!";
                return message;
            }
        }
    }
}
