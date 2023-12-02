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
    partial class v_TambahKonversiNilai : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunMahasiswa data_akun_pengguna;
        private c_TambahKonversiNilai c_TambahKonversiNilai;
        List<int> list_id_matkul_dinilai = new();
        private object[] data_mahasiswa;
        public v_TambahKonversiNilai(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataKonversiSks m_DataKonversiSks, m_DataKonversiNilai m_DataKonversiNilai, m_DataMataKuliah m_DataMataKuliah)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_Dashboard = c_Dashboard;
            this.c_TambahKonversiNilai = new c_TambahKonversiNilai(m_DataKonversiSks, m_DataKonversiNilai, m_DataMataKuliah);
            this.data_akun_pengguna = data_akun_pengguna;
            data_mahasiswa = data_akun_pengguna.getAttributes();

            this.init();
            this.isiComboBox();
        }
        public void init()
        {
            dataGridView1.Rows.Clear();
            List<object[]> data = c_TambahKonversiNilai.initDataGridView((int)this.data_mahasiswa[0]);
            foreach (object[] items in data)
            {
                dataGridView1.Rows.Add(items[0], items[1]);
                this.list_id_matkul_dinilai.Add((int)items[2]);
            }
        }

        public void isiComboBox()
        {
            cbx_matkulajukan.Items.Clear();
            cbx_matkulajukan.ResetText();

            List<object[]> list_matkul_belum_dinilai = c_TambahKonversiNilai.getMatkulByIdMhs((int)this.data_mahasiswa[0]);
            foreach (int id in this.list_id_matkul_dinilai)
            {
                for (int i = 0; i < list_matkul_belum_dinilai.Count(); i++)
                {
                    if ((int)list_matkul_belum_dinilai[i][0] != id)
                    {
                        cbx_matkulajukan.Items.Add(list_matkul_belum_dinilai[i][2]);
                    }
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void statusMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPenerimaanMitra();
        }

        private void btn_simpannilai_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilMahasiswa();
        }

        private void btn_inputmatkul_Click(object sender, EventArgs e)
        {
            object[] konversiNilaiBaru = new object[4];

            object b = cbx_matkulajukan.SelectedItem;
            object matkulDipilih = cbx_matkulajukan.GetItemText(b);

            if (tbx_nilai.Text == "")
            {
                string message = "Kolom Nilai Harus Diisi!";
                MessageBox.Show(message);
            }
            else if (int.Parse(tbx_nilai.Text) > 100)
            {
                string message = "Nilai Maksimal 100!";
                MessageBox.Show(message);
            }
            else if (tbx_bukti.Text == "")
            {
                string message = "Kolom Bukti Harus Dinilai!";
                MessageBox.Show(message);
            }
            else if (matkulDipilih.ToString() == "")
            {
                string message = "Pilih Mata Kuliah Yang Tersedia!";
                MessageBox.Show(message);
            }
            else
            {
                konversiNilaiBaru[0] = int.Parse(tbx_nilai.Text);
                konversiNilaiBaru[1] = tbx_bukti.Text;
                konversiNilaiBaru[2] = 0;

                List<object[]> list_data_sks = c_TambahKonversiNilai.getDataSksByIdMhs((int)data_mahasiswa[0]);
                List<object[]> list_matkul_dinilai = c_TambahKonversiNilai.getKonversiNilaiMhs(this.list_id_matkul_dinilai);
                foreach (object[] item in list_matkul_dinilai)
                {
                    if (item[2].ToString() == matkulDipilih.ToString())
                    {
                        foreach (object[] item_sks in list_data_sks)
                        {
                            if (item[0].ToString() == item_sks[4].ToString())
                            {
                                konversiNilaiBaru[3] = (int)item_sks[0];

                                c_TambahKonversiNilai.tambahKonversiNilai(konversiNilaiBaru);
                            }
                        }
                    }
                }

                tbx_nilai.Clear();
                tbx_bukti.Clear();
                this.init();
                this.isiComboBox();
            }
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardMahasiswa();
        }

        private void statusMitraToolStripMenuItem1_Click(object sender, EventArgs e)
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

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }
    }
}
