using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_LihatMataKuliahProgram
    {
        m_DataPenerimaanMitra m_DataPenerimaanMitra;
        m_DataDetailProgram m_DataDetailProgram;
        m_DataMataKuliah m_DataMataKuliah;

        public c_LihatMataKuliahProgram(m_DataPenerimaanMitra m_DataPenerimaanMitra, m_DataDetailProgram m_DataDetailProgram, m_DataMataKuliah m_DataMataKuliah)
        {
            this.m_DataPenerimaanMitra = m_DataPenerimaanMitra;
            this.m_DataDetailProgram = m_DataDetailProgram;
            this.m_DataMataKuliah = m_DataMataKuliah;
        }

        public object[] getDataPenerimaanByIdMhs(int id_mahasiswa)
        {
            object[] result = this.m_DataPenerimaanMitra.getPenerimaanMitraByIdMhs(id_mahasiswa);
            return result;
        }

        public List<object[]> getDataProgramByIdProgram(int id_program)
        {
            List<object[]> result = this.m_DataDetailProgram.getDetailProgramByIdProgram(id_program);
            return result;
        }

        public List<object[]> getDataMatkulByListIdMatkul(List<int> list_id_matkul)
        {
            List<object[]> result = this.m_DataMataKuliah.getAllMatkulByIdMatkul(list_id_matkul);
            return result;
        }
    }
}
