using Baskom.Controller;
using Baskom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    partial class v_LihatMataKuliahProgram : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunMahasiswa data_akun_pengguna;
        private c_LihatMataKuliahProgram c_LihatMataKuliahProgram;

        private object[] data_mahasiswa;
        private object[] data_penerimaan;

        List<object[]> data_detail_program;
        List<object[]> data_matkul;

        public v_LihatMataKuliahProgram(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataPenerimaanMitra m_DataPenerimaanMitra, m_DataDetailProgram m_DataDetailProgram, m_DataMataKuliah m_DataMataKuliah)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_LihatMataKuliahProgram = new c_LihatMataKuliahProgram(m_DataPenerimaanMitra, m_DataDetailProgram, m_DataMataKuliah);
            this.data_akun_pengguna = data_akun_pengguna;
            data_mahasiswa = data_akun_pengguna.getAttributes();

            this.init();
        }

        public void init()
        {
            tbl_matkulkonversisks.Rows.Clear();

            data_penerimaan = c_LihatMataKuliahProgram.getDataPenerimaanByIdMhs((int)data_mahasiswa[0]);
            data_detail_program = c_LihatMataKuliahProgram.getDataProgramByIdProgram((int)data_penerimaan[9]);

            List<int> list_id_matkul = new List<int>();

            foreach (object[] item in data_detail_program)
            {
                list_id_matkul.Add((int)item[0]);
            }


            data_matkul = c_LihatMataKuliahProgram.getDataMatkulByListIdMatkul(list_id_matkul);

            foreach (object[] item1 in data_matkul)
            {
                tbl_matkulkonversisks.Rows.Add(item1[1], item1[2], item1[3]);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahKonversiSks();
        }
    }
}
