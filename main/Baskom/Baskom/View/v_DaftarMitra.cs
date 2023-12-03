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
    partial class v_DaftarMitra : Form
    {
        private c_Dashboard c_Dashboard;
        private c_DaftarMitra c_DaftarMitra;

        public v_DaftarMitra(c_Dashboard c_Dashboard, m_DataMitra m_DataMitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_DaftarMitra = new c_DaftarMitra(m_DataMitra);
            this.init();
        }
        public void init()
        {
            tbl_daftarmitra.Rows.Clear();
            List<object[]> data = this.c_DaftarMitra.initDataGridView();
            foreach (object[] item in data)
            {
                tbl_daftarmitra.Rows.Add(item[0], item[1]);
            }
        }
        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiNilai();
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mitraBaruToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setValidasiMOA();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilTimMBKM();
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPembagianTugas();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiSks();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbl_daftarmitra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
