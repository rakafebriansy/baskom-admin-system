using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_PengajuanMOA
    {
        private m_DataPengajuanMitra m_DataPengajuanMitra;
        private m_DataStatusValidasiMitra m_DataStatusValidasiMitra;

        public c_PengajuanMOA(m_DataPengajuanMitra m_DataPengajuanMitra, m_DataStatusValidasiMitra m_DataStatusValidasiMitra)
        {
            this.m_DataPengajuanMitra = m_DataPengajuanMitra;
            this.m_DataStatusValidasiMitra = m_DataStatusValidasiMitra;
        }


        public List<object[]> getAllPengajuanMitra()
        {
            List<object[]> result = this.m_DataPengajuanMitra.getAllPengajuanMitra();
            return result;
        }

        public string getStatusValidasiMitraById(int id_status)
        {
            string result = m_DataStatusValidasiMitra.getStatusValidasiMitraById(id_status);
            return result;
        }        
        public List<string> getAllStatusValidasiMitra()
        {
            List<string> result = m_DataStatusValidasiMitra.getAllStatusValidasiMitra();
            return result;
        }

        public string tambahPengajuanMitra(object[] pengajuan_mitra_baru)
        {
            string message = "";
            List<object[]> pengajuan_mitra = m_DataPengajuanMitra.getAllPengajuanMitra();
            foreach (object[] item in pengajuan_mitra)
            {
                if (((string)item[1]).ToLower() == ((string)pengajuan_mitra_baru[0]).ToLower())
                {
                    message = "Mitra Sudah Terdaftar!";
                    return message;
                }
            }
            pengajuan_mitra_baru[2] = m_DataStatusValidasiMitra.getIdValidasiMitraByStatus((string)pengajuan_mitra_baru[2]);
            m_DataPengajuanMitra.sendPengajuan(pengajuan_mitra_baru);
            return message;
        }

        public string updateStatusValidasi(string status, int id_pengajuan)
        {
            int id_status = m_DataStatusValidasiMitra.getIdValidasiMitraByStatus((string)status);
            m_DataPengajuanMitra.updateStatusValidasi(id_status, id_pengajuan);
            return "Perubahan Telah Disimpan!";
        }

    }
}
