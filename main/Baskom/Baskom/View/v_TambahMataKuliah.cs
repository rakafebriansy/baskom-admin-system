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
    partial class v_TambahMataKuliah : Form
    {
        private c_Dashboard c_Dashboard;
        private c_TambahMataKuliah c_TambahMataKuliah;
        public v_TambahMataKuliah(c_Dashboard c_Dashboard, m_DataMataKuliah m_DataMataKuliah)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_TambahMataKuliah = new c_TambahMataKuliah(m_DataMataKuliah);
            this.init();
        }
        public void init()
        {
            tbl_daftarmatkul.Rows.Clear();
            List<object[]> data = this.c_TambahMataKuliah.initDataGridView();
            foreach (object[] item in data)
            {
                tbl_daftarmatkul.Rows.Add(item[1], item[2], item[3]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //logout
        }

        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardAdmin();
        }

        private void mitraToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void tambahMitraProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMitraProgram();
        }

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahProgramMataKuliah();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
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

        private void tbl_daftarmatkul_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_tambahmatkul_Click(object sender, EventArgs e)
        {
            string message = "";

            if (tbx_kodematakuliah.Text == "")
            {
                message = "Kode Mata Kuliah Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_kodematakuliah.Text.ToCharArray().Any(c => !Char.IsLetterOrDigit(c)))
            {
                message = "Kode Mata Kuliah Terdiri Huruf dan Angka!";
                MessageBox.Show(message);
            }
            else if (tbx_namamatakuliah.Text == "")
            {
                message = "Nama Mata Kuliah Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_namamatakuliah.Text.ToCharArray().Any(c => Char.IsNumber(c)))
            {
                message = "Nama Mata Kuliah Hanya Huruf!";
                MessageBox.Show(message);
            }
            else if (tbx_jumlahsks.Text == "")
            {
                message = "Jumlah SKS Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_jumlahsks.Text.ToCharArray().Any(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                message = "Jumlah SKS Hanya Berisi Angka!";
                MessageBox.Show(message);
            }
            else if (tbx_jumlahsks.Text.Count() > 4)
            {
                message = "Jumlah SKS Maksimal 4!";
                MessageBox.Show(message);
            }
            else
            {
                object[] matkul = new object[3];

                matkul[0] = tbx_kodematakuliah.Text;
                matkul[1] = tbx_namamatakuliah.Text;
                matkul[2] = int.Parse(tbx_jumlahsks.Text);

                message = c_TambahMataKuliah.tambahMataKuliahBaru(matkul);

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

        private void logOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
