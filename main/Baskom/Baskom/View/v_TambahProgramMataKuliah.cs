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
    partial class v_TambahProgramMataKuliah : Form
    {
        private c_Dashboard c_Dashboard;
        private c_TambahProgramMataKuliah c_TambahProgramMataKuliah;
        private List<object> detail_program = new();
        private List<object> dropdown_matkul = new();
        public v_TambahProgramMataKuliah(c_Dashboard c_Dashboard, m_DataMataKuliah m_DataMataKuliah, m_DataProgram m_DataProgram, m_DataDetailProgram m_DataDetailProgram)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_TambahProgramMataKuliah = new c_TambahProgramMataKuliah(m_DataMataKuliah, m_DataProgram, m_DataDetailProgram);
            this.init();
        }
        public void init()
        {
            dropdown_matkul.Clear();
            cbx_matakuliah.DataSource = null;
            tbl_daftarprogram.Rows.Clear();

            List<object[]> detail_program = c_TambahProgramMataKuliah.initDetailProgram();
            List<object[]> matkul = c_TambahProgramMataKuliah.initMatkul();

            foreach (object[] item in detail_program)
            {
                tbl_daftarprogram.Rows.Add(item[0], item[1]);
            }
            foreach (object[] item in matkul)
            {
                dropdown_matkul.Add(item[2]);
            }
            cbx_matakuliah.DataSource = this.dropdown_matkul;
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardAdmin();
        }

        private void mitraToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void tambahMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilAdmin();
        }

        private void tambahMitraProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMitraProgram();
        }

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
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

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            string message = "";

            if (tbx_program.Text == "")
            {
                message = "Program Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_program.Text.ToCharArray().Any(c => Char.IsNumber(c)))
            {
                message = "Program Hanya Berisi Huruf!";
                MessageBox.Show(message);
            } else
            {
                message = c_TambahProgramMataKuliah.tambahDetailMitraBaru(tbx_program.Text, cbx_matakuliah.Text); ;
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
    }
}
