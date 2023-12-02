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
    partial class v_TambahKonversiSks : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunMahasiswa data_akun_pengguna;
        private c_TambahKonversiSks c_TambahKonversiSks;
        List<object[]> list_konversi_sks;
        List<object[]> list_data_sks;

        private object[] data_mahasiswa;
        int jumlah_sks;
        public v_TambahKonversiSks(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataKonversiSks m_DataKonversiSks, m_DataMataKuliah m_DataMataKuliah, m_DataMataKuliahTempuh m_DataMataKuliahTempuh, m_DataPenerimaanMitra m_DataPenerimaanMitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_TambahKonversiSks = new c_TambahKonversiSks(m_DataKonversiSks, m_DataMataKuliah, m_DataMataKuliahTempuh, m_DataPenerimaanMitra);
            this.data_akun_pengguna = data_akun_pengguna;
            data_mahasiswa = data_akun_pengguna.getAttributes();

            this.setDataAkun();
            this.init();
            this.isiComboBox();
        }
        private void setDataAkun()
        {
            lbl_namakonversisks.Text = (string)data_mahasiswa[2];
            lbl_nimkonversisks.Text = (string)data_mahasiswa[1];

            string inisial = (string)data_mahasiswa[2];

            string[] pisahkan = { " " };
            Int32 count = 2;

            String[] strlist = inisial.Split(pisahkan, count,
               StringSplitOptions.RemoveEmptyEntries);

            string inisialfiks = "";

            foreach (String s in strlist)
            {
                inisialfiks += s[0];
            }

            lbl_AD.Text = inisialfiks;
        }

        public void init()
        {
            tbl_matkulkonversisks.Rows.Clear();

            this.list_konversi_sks = this.c_TambahKonversiSks.initDataGridView((int)data_mahasiswa[0]);

            List<int> list_idmatkul = new List<int>();

            foreach (object[] item_konversi in list_konversi_sks)
            {
                list_idmatkul.Add((int)item_konversi[4]);
            }

            this.list_data_sks = this.c_TambahKonversiSks.getMatkulSKS(list_idmatkul);

            int i = 0;
            foreach (object[] item in list_data_sks)
            {
                if (list_konversi_sks[i][3].ToString() == "0")
                {
                    tbl_matkulkonversisks.Rows.Add(item[1], item[2], item[3], "Belum Disetujui");
                }
                else
                {
                    tbl_matkulkonversisks.Rows.Add(item[1], item[2], item[3], "Sudah Disetujui");
                }
                i++;
            }
        }

        public void isiComboBox()
        {
            cbx_matkulygdikonversi.Items.Clear();
            cbx_matkulygdikonversi.ResetText();

            List<object[]> list_non_matkul_tempuh = c_TambahKonversiSks.getAllNonMatkulTempuh((int)data_mahasiswa[0]);
            List<object[]> list_non_matkul_tempuh2 = list_non_matkul_tempuh;

            foreach (object[] item in list_data_sks)
            {
                for (int i = 0; i < list_non_matkul_tempuh.Count(); i++)
                {
                    if (item[1].ToString() == list_non_matkul_tempuh[i][1].ToString())
                    {
                        list_non_matkul_tempuh2.RemoveAt(i);
                    }
                }
            }

            foreach (object[] item2 in list_non_matkul_tempuh2)
            {
                cbx_matkulygdikonversi.Items.Add(item2[2]);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (tbl_matkulkonversisks.Rows[e.RowIndex].Cells[3].Value.ToString() == "Sudah Disetujui")
                {
                    MessageBox.Show("Tidak Dapat Menghapus Karena Sudah Disetujui!");
                }
                else
                {
                    int id_mahasiswa = (int)data_mahasiswa[0];
                    int id_matkul = (int)list_konversi_sks[e.RowIndex][4];

                    c_TambahKonversiSks.hapusDataSKS(id_mahasiswa, id_matkul);
                    this.init();
                    this.isiComboBox();
                }
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            c_Dashboard.setLihatMataKuliahProgram();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMataKuliahTempuh();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardMahasiswa();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void KonversiSKS_Load(object sender, EventArgs e)
        {

        }

        private void tbx_kompetensikonversisks_TextChanged(object sender, EventArgs e)
        {

        }

        private void lyt_konversisks_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pengajuanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPenerimaanMitra();
        }

        private void statusMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPengajuanMOA();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahKonversiNilai();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilMahasiswa();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void lbl_namakonversisks_Click(object sender, EventArgs e)
        {

        }

        private void btn_simpankonversisks_Click(object sender, EventArgs e)
        {
            int sisa_sks = this.hitungSisaSKS();

            object[] konversiSksBaru = new object[5];

            object b = cbx_matkulygdikonversi.SelectedItem;
            object matkulDipilih = cbx_matkulygdikonversi.GetItemText(b);

            if (tbx_kompetensikonversisks.Text == "")
            {
                string message = "Isi Kolom Kompetensi!";
                MessageBox.Show(message);
            } 
            else if (tbx_keterangankonversisks.Text == "")
            {
                string message = "Isi Kolom Keterangan!";
                MessageBox.Show(message);
            }
            else if (matkulDipilih.ToString() == "")
            {
                string message = "Pilih Mata Kuliah Yang Tersedia!";
                MessageBox.Show(message);
            }
            else
            {
                List<object[]> list_non_matkul_tempuh = c_TambahKonversiSks.getAllNonMatkulTempuh((int)data_mahasiswa[0]);
                foreach (object[] item in list_non_matkul_tempuh)
                {
                    if (item[2].ToString() == matkulDipilih.ToString())
                    {
                        if (sisa_sks - int.Parse(item[3].ToString()) >= 0)
                        {
                            konversiSksBaru[0] = tbx_kompetensikonversisks.Text;
                            konversiSksBaru[1] = tbx_keterangankonversisks.Text;
                            konversiSksBaru[2] = 0;
                            konversiSksBaru[3] = (int)item[0];
                            konversiSksBaru[4] = (int)data_mahasiswa[0];

                            c_TambahKonversiSks.tambahKonversiSks(konversiSksBaru);

                            this.init();
                            this.isiComboBox();
                        } else
                        {
                            MessageBox.Show($"Sisa SKS = {sisa_sks}, tidak dapat mengambil {item[2]} dengan SKS = {item[3]}");
                        }
                    }
                }
            }
        }

        private int hitungSisaSKS()
        {
            jumlah_sks = c_TambahKonversiSks.getJumlahMaksSKS((int)data_mahasiswa[0]);

            foreach (object[] item in list_data_sks)
            {
                jumlah_sks -= int.Parse(item[3].ToString());
            }

            return jumlah_sks;
        }
    }
}
