using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_TambahProgramMataKuliah
    {
        m_DataMataKuliah m_DataMataKuliah;
        m_DataProgram m_DataProgram;
        m_DataDetailProgram m_DataDetailProgram;
        public c_TambahProgramMataKuliah(m_DataMataKuliah m_DataMataKuliah, m_DataProgram m_DataProgram, m_DataDetailProgram m_DataDetailProgram)
        {
            this.m_DataMataKuliah = m_DataMataKuliah;
            this.m_DataProgram = m_DataProgram;
            this.m_DataDetailProgram = m_DataDetailProgram;
        }
        public List<object[]> initMatkul()
        {
            List<object[]> matkul = this.m_DataMataKuliah.getAllMataKuliah();
            return matkul;
        }
        public List<object[]> initProgram()
        {
            List<object[]> program = this.m_DataProgram.getAllProgram();
            return program;
        }
        public List<object[]> initDetailProgram()
        {
            List<object[]> detail_matkul = this.m_DataDetailProgram.getAllDetailProgram();
            foreach (object[] item in detail_matkul)
            {
                object[] program = this.m_DataProgram.getProgramById((int)item[1]);
                object[] matkul = this.m_DataMataKuliah.getMataKuliahById((int)item[0]);
                item[0] = program[1];
                item[1] = matkul[2];
            }
            return detail_matkul;
        }
        public string tambahDetailMitraBaru(string nama_program, string nama_matkul)
        {
            string message = "";
            bool isAvailable = false;
            List<object[]> detail_matkul = this.m_DataDetailProgram.getAllDetailProgram();
            List<object[]> program = this.m_DataProgram.getAllProgram();
            object[] matkul = this.m_DataMataKuliah.getMataKuliahByNama(nama_matkul);
            foreach (object[] item in detail_matkul)
            {
                if (item[0].ToString() == nama_program && item[1].ToString() == matkul[0].ToString())
                {
                    return "Detail Program Telah Tersedia!";
                }
            }
            foreach (object[] item in program)
            {
                if (item[1].ToString() == nama_program)
                {
                    isAvailable= true;
                    break;
                }
            }
            if (!isAvailable)
            {
                this.m_DataProgram.sendProgram(nama_program);
            }
            int id_program = (int)m_DataProgram.getProgramByNama(nama_program)[0];
            this.m_DataDetailProgram.sendDetailProgram((int)id_program, (int)matkul[0]);
            return message;
        }
    }
}
