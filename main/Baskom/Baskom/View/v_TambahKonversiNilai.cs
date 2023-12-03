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
        List<object[]> list_data_sks;
        List<object[]> list_data_matkul;
        List<object[]> list_data_matkul_dinilai = new List<object[]>();

        private object[] data_mahasiswa;

        public v_TambahKonversiNilai(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataKonversiSks m_DataKonversiSks, m_DataKonversiNilai m_DataKonversiNilai, m_DataMataKuliah m_DataMataKuliah)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_TambahKonversiNilai = new c_TambahKonversiNilai(m_DataKonversiSks, m_DataKonversiNilai, m_DataMataKuliah);
            this.data_akun_pengguna = data_akun_pengguna;
            data_mahasiswa = data_akun_pengguna.getAttributes();

            this.init();
            this.isiComboBox();
        }

        private void cekDataPenerimaan()
        {
            List<object[]> dataSKS = c_TambahKonversiNilai.getDataSksByIdMhs((int)data_mahasiswa[0]);
            bool available = false;

            foreach (var item in dataSKS)
            {
                if (item != null)
                {
                    available = true;
                }
                else
                {
                    break;
                }
            }

            if (!available)
            {
                cbx_matkulajukan.Enabled = false;
                tbx_nilai.Enabled = false;
                tbx_bukti.Enabled = false;
                btn_inputmatkul.Enabled = false;
            }
            else
            {
                cbx_matkulajukan.Enabled = true;
                tbx_nilai.Enabled = true;
                tbx_bukti.Enabled = true;
                btn_inputmatkul.Enabled = true;
            }
        }

        public void init()
        {
            dataGridView1.Rows.Clear();

            List<object[]> list_konversi_nilai = new List<object[]>();
            this.list_data_sks = c_TambahKonversiNilai.getDataSksByIdMhs((int)data_mahasiswa[0]);

            List<int> list_id_konversi_sks = new List<int>();
            List<int> list_id_matkul = new List<int>();

            foreach (object[] item_sks in list_data_sks)
            {
                if (item_sks[3].ToString() == "1")
                {
                    list_id_konversi_sks.Add((int)item_sks[0]);
                    list_id_matkul.Add((int)item_sks[4]);
                }
            }

            list_konversi_nilai = c_TambahKonversiNilai.getDataNilaiByIdSks(list_id_konversi_sks);
            list_data_matkul = c_TambahKonversiNilai.getMataKuliah(list_id_matkul);

            for (int i = 0; i < list_konversi_nilai.Count(); i++)
            {
                for (int j = 0; j < list_id_konversi_sks.Count(); j++)
                {
                    if ((int)list_konversi_nilai[i][4] == list_id_konversi_sks[j])
                    {
                        this.list_data_matkul_dinilai.Add(list_data_matkul[j]);
                        dataGridView1.Rows.Add(list_data_matkul[j][2], list_konversi_nilai[i][1]);
                    }
                }
            }
        }

        public void isiComboBox()
        {
            cbx_matkulajukan.Items.Clear();
            cbx_matkulajukan.ResetText();

            List<object[]> list_matkul_blm_konversi_nilai = list_data_matkul;
            foreach (object[] item_done in list_data_matkul_dinilai)
            {
                for (int i = 0; i < list_data_matkul.Count(); i++)
                {
                    if (item_done[0] == list_data_matkul[i][0])
                    {
                        list_matkul_blm_konversi_nilai.RemoveAt(i);
                    }
                }
            }

            foreach (object[] item2 in list_matkul_blm_konversi_nilai)
            {
                cbx_matkulajukan.Items.Add(item2[2]);
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
            else if (tbx_nilai.Text.ToCharArray().Any(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                string message = "Nilai Hanya Berisi Angka!";
                MessageBox.Show(message);
            }
            else if (int.Parse(tbx_nilai.Text) > 100)
            {
                string message = "Nilai Maksimal 100!";
                MessageBox.Show(message);
            }
            else if (tbx_bukti.Text == "")
            {
                string message = "Kolom Bukti Harus Diisi!";
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

                foreach (object[] item in list_data_matkul)
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
