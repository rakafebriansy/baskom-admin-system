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
    partial class v_PembagianTugas : Form
    {
        private c_Dashboard c_Dashboard;
        private c_PembagianTugas c_PembagianTugas;
        public v_PembagianTugas(c_Dashboard c_Dashboard, m_DataPembagianTugas m_DataPembagianTugas, m_DataPenerimaanMitra m_DataPenerimaanMitra, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataAkunDosen m_DataAkunDosen, m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataProdi m_DataProdi, object data_akun_pengguna)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_PembagianTugas = new c_PembagianTugas(m_DataPembagianTugas, m_DataPenerimaanMitra, m_DataAkunMahasiswa, m_DataAkunDosen, m_DataMitra, m_DataProgram, m_DataProdi, (m_DataAkunTimmbkm)data_akun_pengguna);
            this.init();
        }
        public void init()
        {
            dataGridView1.Rows.Clear();
            try
            {

                List<object[]> data = this.c_PembagianTugas.initDataGridView();
                foreach (object[] item in data)
                {
                    dataGridView1.Rows.Add(item[0], item[1], item[2], item[3], item[4], item[5]);
                }
            }
            catch { }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
            //this
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiSks();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiNilai();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
