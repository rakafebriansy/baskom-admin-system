using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_DaftarMitra
    {
        m_DataMitra m_DataMitra;
        public c_DaftarMitra(m_DataMitra m_DataMitra)
        {
            this.m_DataMitra = m_DataMitra;
        }
        public List<object[]> initDataGridView()
        {
            List<object[]> result = new List<object[]>();
            List<object[]> data_mitra = m_DataMitra.getAllMitra();
            foreach (object[] mitra in data_mitra)
            {
                object[] item = new object[3];
                item[0] = mitra[1];
                item[1] = mitra[2];
                result.Add(item);
            }
            return result;
        }
    }
}
