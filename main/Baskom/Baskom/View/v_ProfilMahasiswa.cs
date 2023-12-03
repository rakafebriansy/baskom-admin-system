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
    partial class v_ProfilMahasiswa : Form
    {
        private c_Dashboard c_Dashboard;
        private object[] atribut_data_akun;
        public v_ProfilMahasiswa(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.atribut_data_akun = data_akun_pengguna.getAttributes();
            lbl_namamahasiswa.Text = (string)atribut_data_akun[2];
            lbl_nimmahasiswa.Text = (string)atribut_data_akun[1];
            lbl_prodi.Text = (string)atribut_data_akun[9];
            lbl_thnmasuk.Text = atribut_data_akun[3].ToString();
            lbl_status.Text = (bool)atribut_data_akun[4] ? "Aktif" : "Tidak Aktif";
            lbl_nowa.Text = (string)atribut_data_akun[5];
            lbl_batch.Text = atribut_data_akun[6].ToString();
            lbl_email.Text = (string)atribut_data_akun[7];
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahKonversiNilai();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lnk_ubahsandi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            c_Dashboard.setUbahKataSandiProfil();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pengajuanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardMahasiswa();
        }

        private void pengajuanMitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPenerimaanMitra();
        }

        private void statusMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPengajuanMOA();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMataKuliahTempuh();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahKonversiSks();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
