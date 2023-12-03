using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Baskom.Controller;
using Baskom.Model;

namespace Baskom.View
{
    partial class v_MemvalidasiKonversiNilai : Form
    {
        private c_Dashboard c_Dashboard;
        private c_MemvalidasiKonversiNilai c_MemvalidasiKonversiNilai;
        public v_MemvalidasiKonversiNilai(c_Dashboard c_Dashboard, m_DataKonversiSks m_DataKonversiSks, m_DataKonversiNilai m_DataKonversiNilai, m_DataAkunDosen m_DataAkunDosen, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataProdi m_DataProdi, m_DataPenerimaanMitra m_DataPenerimaanMitra, m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataPembagianTugas m_DataPembagianTugas, m_DataAkunTimmbkm data_akun_pengguna)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_MemvalidasiKonversiNilai = new c_MemvalidasiKonversiNilai(m_DataKonversiSks, m_DataKonversiNilai, m_DataAkunDosen, m_DataAkunMahasiswa, m_DataProdi, m_DataPenerimaanMitra, m_DataMitra, m_DataProgram, m_DataPembagianTugas, data_akun_pengguna);
            this.init();
        }
        public void init()
        {
            tbl_konversinilai1.Rows.Clear();
            List<object[]> data = this.c_MemvalidasiKonversiNilai.initDataGridView();
            foreach (object[] item in data)
            {
                tbl_konversinilai1.Rows.Add(item[0], item[1], item[2], item[3], item[4]);
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            string nama_mhs = (string)tbl_konversinilai1.Rows[index].Cells[0].Value;
            string nim = (string)tbl_konversinilai1.Rows[index].Cells[1].Value;
            string nama_mitra = (string)tbl_konversinilai1.Rows[index].Cells[3].Value;
            string prodi = (string)tbl_konversinilai1.Rows[index].Cells[2].Value;
            string program = (string)tbl_konversinilai1.Rows[index].Cells[4].Value;
            if (e.ColumnIndex == 5)
            {
                c_Dashboard.setDetailValidasiKonversiNilai(nama_mhs, nim, nama_mitra, prodi, program);
            }
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setValidasiMOA();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void daftarMitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDaftarMitra();
        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilTimMBKM();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiSks();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPembagianTugas();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

