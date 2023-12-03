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
    partial class v_MemvalidasiKonversiSks : Form
    {
        private c_Dashboard c_Dashboard;
        private c_MemvalidasiKonversiSks c_MemvalidasiKonversiSks;
        public v_MemvalidasiKonversiSks(c_Dashboard c_Dashboard, m_DataKonversiSks m_DataKonversiSks, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataProdi m_DataProdi, m_DataPenerimaanMitra m_DataPenerimaanMitra, m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataPembagianTugas m_DataPembagianTugas, m_DataAkunTimmbkm data_akun_pengguna)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_MemvalidasiKonversiSks = new c_MemvalidasiKonversiSks(m_DataKonversiSks, m_DataAkunMahasiswa, m_DataProdi, m_DataPenerimaanMitra, m_DataMitra, m_DataProgram, m_DataPembagianTugas, data_akun_pengguna);
            this.init();
        }
        public void init()
        {
            dataGridView1.Rows.Clear();
            List<object[]> data = this.c_MemvalidasiKonversiSks.initDataGridView();
            foreach (object[] item in data)
            {
                dataGridView1.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPembagianTugas();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void konversiNIlaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiNilai();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilTimMBKM();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string nama_mhs = (string)dataGridView1.Rows[index].Cells[0].Value;
            string nim = (string)dataGridView1.Rows[index].Cells[1].Value;
            string nama_mitra = (string)dataGridView1.Rows[index].Cells[3].Value;
            if (e.ColumnIndex == 5)
            {
                c_Dashboard.setDetailValidasiKonversiSks(nama_mhs, nim, nama_mitra);
            }
        }

        private void pengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setValidasiMOA();
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDaftarMitra();
        }
    }
}
