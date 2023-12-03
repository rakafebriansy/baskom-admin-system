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
using static System.Windows.Forms.DataFormats;

namespace Baskom.View
{
    partial class v_TambahMitraProgram : Form
    {
        private c_Dashboard c_Dashboard;
        private c_TambahMitraProgam c_TambahMitraProgam;
        List<object> dropdown_mitra = new();
        List<object> dropdown_program = new();
        public v_TambahMitraProgram(c_Dashboard c_Dashboard, m_DataMitra m_DataMitra, m_DataProgram m_DataProgram, m_DataDetailMitra m_DataDetailMitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_TambahMitraProgam = new c_TambahMitraProgam(m_DataMitra, m_DataProgram, m_DataDetailMitra);
            this.init();
        }
        public void init()
        {
            dropdown_mitra.Clear();
            dropdown_program.Clear();
            cbx_namamitra.DataSource = null;
            cbx_program.DataSource = null;
            tbl_daftarprogrammitra.Rows.Clear();

            List<object[]> detail_mitra = c_TambahMitraProgam.initDetailMitra();
            List<object[]> mitra = c_TambahMitraProgam.initMitra();
            List<object[]> program = c_TambahMitraProgam.initProgram();

            foreach (object[] item in detail_mitra)
            {
                tbl_daftarprogrammitra.Rows.Add(item[1], item[0]);
            }
            foreach (object[] item in mitra)
            {
                dropdown_mitra.Add(item[1]);
            }
            foreach (object[] item in program)
            {
                dropdown_program.Add(item[1]);
            }

            cbx_namamitra.DataSource = dropdown_mitra;
            cbx_program.DataSource = dropdown_program;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lbl_matakuliah_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardAdmin();
        }

        private void tambahMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilAdmin();
        }

        private void tambahProgramMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahProgramMataKuliah();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMataKuliah();
        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDataDosen();
        }

        private void akunMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDataMahasiswa();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string message = "";

            object program = cbx_program.SelectedItem;
            object programDipilih = cbx_program.GetItemText(program);

            if (programDipilih.ToString() == "")
            {
                message = "Pilih Program Yang Tersedia!";
                MessageBox.Show(message);
            } else
            {
                message = c_TambahMitraProgam.tambahDetailMitraBaru(cbx_program.Text, cbx_namamitra.Text); ;
                if (message.Length > 0)
                {
                    MessageBox.Show(message);
                }
                else
                {
                    this.init();
                }
            }
        }

        private void cbx_namamitra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
