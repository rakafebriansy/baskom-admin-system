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
    partial class v_ProfilAdmin : Form
    {
        c_Dashboard c_Dashboard;
        m_DataAkunAdmin data_akun_pengguna;
        public v_ProfilAdmin(c_Dashboard c_Dashboard, m_DataAkunAdmin data_akun_pengguna)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.data_akun_pengguna = data_akun_pengguna;
            object[] data_admin = data_akun_pengguna.getAttributes();
            lbl_nama.Text = (string)data_admin[1];
            lbl_katasandi.Text = (string)data_admin[2];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c_Dashboard.setUbahKataSandiProfil();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardAdmin();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void akunDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDataDosen();
        }

        private void akunMahasiswaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDataMahasiswa();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void tambahMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMataKuliah();
        }

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahProgram();
        }

        private void tambahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMitraProgram();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMataKuliah();
        }

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahProgramMataKuliah();
        }
    }
}
