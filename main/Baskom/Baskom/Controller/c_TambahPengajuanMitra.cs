using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_TambahPengajuanMitra
    {
        private m_DataPengajuanMitra m_DataPengajuanMitra;
        public c_TambahPengajuanMitra(m_DataPengajuanMitra m_DataPengajuanMitra)
        {
            this.m_DataPengajuanMitra = m_DataPengajuanMitra;
        }


        public List<object[]> getAllDataPengajuan()
        {
            List<object[]> result = this.m_DataPengajuanMitra.getAllPengajuanMitra();
            return result;
        }

        public void tambahPengajuanMitra(object[] pengajuan_mitra_baru)
        {
            List<object[]> pengajuan_mitra = m_DataPengajuanMitra.getAllPengajuanMitra();
            foreach (object[] item in pengajuan_mitra)
            {
                if (((string)item[1]).ToLower() == ((string)pengajuan_mitra_baru[0]).ToLower())
                {
                    string message = "Mitra Sudah Terdaftar!";
                    MessageBox.Show(message);
                }
            }
            m_DataPengajuanMitra.sendPengajuan(pengajuan_mitra_baru);
        }
    }
}
