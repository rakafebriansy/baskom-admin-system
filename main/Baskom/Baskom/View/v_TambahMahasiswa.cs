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
    partial class v_TambahMahasiswa : Form
    {
        c_TambahMahasiswa c_TambahMahasiswa;
        v_DataMahasiswa v_DataMahasiswa;
        public v_TambahMahasiswa(v_DataMahasiswa v_DataMahasiswa, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataProdi m_DataProdi, m_DataAkunTimmbkm m_DataAkunTimmbkm, m_DataAkunDosen m_DataAkunDosen, m_DataPembagianTugas m_DataPembagianTugas)
        {
            InitializeComponent();
            this.c_TambahMahasiswa = new c_TambahMahasiswa(m_DataAkunMahasiswa, m_DataProdi, m_DataAkunTimmbkm, m_DataAkunDosen, m_DataPembagianTugas);
            this.v_DataMahasiswa = v_DataMahasiswa;
            this.init();
        }
        public void init()
        {
            List<string> prodi = c_TambahMahasiswa.initProdi();
            List<string> timmbkm = c_TambahMahasiswa.initNamaTimmbkm();
            cmbprogramstudimhs.DataSource = prodi;
            cbx_dosenpic.DataSource = timmbkm;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void btn_tambahtambahmhs_Click(object sender, EventArgs e)
        {
            string message = "";

            object prodi = cmbprogramstudimhs.SelectedItem;
            object pic = cbx_dosenpic.SelectedItem;
            object status = cmbstatusmahasiswamhs.SelectedItem;

            object prodiDipilih = cmbprogramstudimhs.GetItemText(prodi);
            object picDipilih = cbx_dosenpic.GetItemText(pic);
            object statusDipilih = cbx_dosenpic.GetItemText(status);

            if (tbx_namamahasiswatambahmhs.Text == "")
            {
                message = "Nama Mahasiswa Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_namamahasiswatambahmhs.Text.ToCharArray().Any(c => Char.IsNumber(c)))
            {
                message = "Nama Mahasiswa Hanya Huruf!";
                MessageBox.Show(message);
            }
            else if (tbx_nimhasiswatambahmhs.Text == "")
            {
                message = "NIM Mahasiswa Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_nimhasiswatambahmhs.Text.ToCharArray().Any(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                message = "NIM Hanya Berisi Angka!";
                MessageBox.Show(message);
            }
            else if (tbx_nimhasiswatambahmhs.Text.Count() != 12)
            {
                message = "NIM Hanya Berjumlah 12 digit";
                MessageBox.Show(message);
            }
            else if (prodiDipilih.ToString() == "")
            {
                message = "Pilih Program Studi Yang Tersedia!";
                MessageBox.Show(message);
            }
            else if (tbx_tahunmasukmahasiswatambahmhs.Text == "")
            {
                message = "Tahun Masuk Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_tahunmasukmahasiswatambahmhs.Text.ToCharArray().Any(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                message = "Tahun Hanya Berisi Angka!";
                MessageBox.Show(message);
            }
            else if (tbx_tahunmasukmahasiswatambahmhs.Text.Count() != 4)
            {
                message = "Tahun Hanya Berjumlah 4 digit! (ex : 2022)";
                MessageBox.Show(message);
            }
            else if (statusDipilih.ToString() == "")
            {
                message = "Pilih Status Yang Tersedia!";
                MessageBox.Show(message);
            }
            else if (tbx_nowamahasiswatambahmhs.Text == "")
            {
                message = "No Wa Mahasiswa Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_nowamahasiswatambahmhs.Text.ToCharArray().Any(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                message = "No Wa Hanya Berisi Angka!";
                MessageBox.Show(message);
            }
            else if (tbx_nowamahasiswatambahmhs.Text.Count() < 11 || tbx_nowamahasiswatambahmhs.Text.Count() > 13)
            {
                message = "No Wa Harus Sesuai! (11-13 digit)";
                MessageBox.Show(message);
            }
            else if (tbx_bacthmahasiswatambahmhs.Text.ToCharArray().Any(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                message = "Batch MBKM Hanya Berisi Angka!";
                MessageBox.Show(message);
            }
            else if (tbx_emailmahasiswatambahmhs.Text == "")
            {
                message = "Email Tidak Boleh Kosong";
                MessageBox.Show(message);
            }
            else if (tbx_katasandimahasiswatambahmhs.Text == "")
            {
                message = "Kata Sandi Tidak Boleh Kosong";
                MessageBox.Show(message);
            }
            else if (tbx_katasandimahasiswatambahmhs.Text.Count() < 8)
            {
                message = "Kata Sandi Minimal 8 Karakter";
                MessageBox.Show(message);
            }
            else if (picDipilih.ToString() == "")
            {
                message = "Pilih PIC Yang Tersedia!";
                MessageBox.Show(message);
            }
            else
            {
                bool result;
                try
                {
                    System.Net.Mail.MailAddress email = new System.Net.Mail.MailAddress(tbx_emailmahasiswatambahmhs.Text);
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                    MessageBox.Show("Format Emailmu Tidak Valid!");
                }

                if (result)
                {
                    object[] mahasiswa = new object[10];

                    mahasiswa[0] = tbx_nimhasiswatambahmhs.Text;
                    mahasiswa[1] = tbx_namamahasiswatambahmhs.Text;
                    mahasiswa[2] = int.Parse(tbx_tahunmasukmahasiswatambahmhs.Text);
                    mahasiswa[3] = cmbstatusmahasiswamhs.Text == "Aktif" ? 1 : 0;
                    mahasiswa[4] = tbx_nowamahasiswatambahmhs.Text;
                    mahasiswa[5] = int.Parse(tbx_bacthmahasiswatambahmhs.Text);
                    mahasiswa[6] = tbx_emailmahasiswatambahmhs.Text;
                    mahasiswa[7] = tbx_katasandimahasiswatambahmhs.Text;
                    mahasiswa[8] = cmbprogramstudimhs.Text;
                    mahasiswa[9] = cbx_dosenpic.Text;

                    message = c_TambahMahasiswa.tambahMahasiswaBaru(mahasiswa);

                    if (message != "Data Mahasiswa Berhasil Ditambahkan!")
                    {
                        MessageBox.Show(message);
                    }
                    else
                    {
                        MessageBox.Show(message);
                        this.Close();
                        v_DataMahasiswa.init();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbx_katasandimahasiswatambahmhs_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
