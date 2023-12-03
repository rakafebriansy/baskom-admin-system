using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.Controller
{
    internal class c_TambahKonversiNilai
    {
        m_DataKonversiSks m_DataKonversiSks;
        m_DataKonversiNilai m_DataKonversiNilai;
        m_DataMataKuliah m_DataMataKuliah;

        public c_TambahKonversiNilai(m_DataKonversiSks m_DataKonversiSks, m_DataKonversiNilai m_DataKonversiNilai, m_DataMataKuliah dataMataKuliah)
        {
            this.m_DataKonversiSks = m_DataKonversiSks;
            this.m_DataKonversiNilai = m_DataKonversiNilai;
            this.m_DataMataKuliah = dataMataKuliah;
        }
        public List<object[]> initDataGridView(int id_mahasiswa)
        {
            List<object[]> result = new();
            List<object[]> list_data_sks = m_DataKonversiSks.getAllKonversiSksByIdMhs((int)id_mahasiswa);

            List<int> list_id_konversi_sks = new ();
            List<int> list_id_matkul = new ();
            foreach (object[] item_sks in list_data_sks)
            {
                if (Convert.ToInt32(item_sks[3]) == 1)
                {
                    list_id_konversi_sks.Add((int)item_sks[0]);
                    list_id_matkul.Add((int)item_sks[4]);
                }
            }
            List<object[]> list_konversi_nilai = this.m_DataKonversiNilai.getAllKonversiNilaiByIdSks(list_id_konversi_sks);
            List<object[]> list_data_matkul = this.m_DataMataKuliah.getAllMatkulByIdMatkul(list_id_matkul);

            for (int i = 0; i < list_konversi_nilai.Count(); i++)
            {
                for (int j = 0; j < list_id_konversi_sks.Count(); j++)
                {
                    if ((int)list_konversi_nilai[i][4] == list_id_konversi_sks[j])
                    {
                        object[] items = new object[3];
                        items[0] = list_data_matkul[j][2];
                        items[1] = list_konversi_nilai[i][1];
                        items[2] = list_konversi_nilai[i][0];
                        result.Add(items);
                    }
                }
            }
            return result;
        }
        public List<object[]> getDataSksByIdMhs(int id_mahasiswa)
        {
            return this.m_DataKonversiSks.getAllKonversiSksByIdMhs(id_mahasiswa);
        }

        public List<object[]> getMatkulByIdMhs(int id_mahasiswa)
        {
            List<object[]> result = new();
            List<object[]> list_data_sks = this.getDataSksByIdMhs(id_mahasiswa);
            foreach (object[] item_sks in list_data_sks)
            {
                if (Convert.ToInt32(item_sks[3]) == 1)
                {
                    object[] matkul = this.m_DataMataKuliah.getMataKuliahById((int)item_sks[4]);
                    result.Add(matkul);

                }
            }
            return result;
        }

        public List<object[]> getDataNilaiByIdSks(List<int> id_sks)
        {
            List<object[]> result = this.m_DataKonversiNilai.getAllKonversiNilaiByIdSks(id_sks);
            return result;
        }

        public List<object[]> getMataKuliah(List<int> id_matkul)
        {
            List<object[]> result = this.m_DataMataKuliah.getAllMatkulByIdMatkul(id_matkul);
            return result;
        }

        public List<object[]> getKonversiNilaiMhs(List<int> id_konversi_nilai)
        {
            return this.m_DataKonversiNilai.getAllKonversiNilaiById(id_konversi_nilai);
        }

        public void tambahKonversiNilai(object[] konversiNilaiBaru)
        {
            m_DataKonversiNilai.sendDataKonversiNilai(konversiNilaiBaru);
        }
    }
}
