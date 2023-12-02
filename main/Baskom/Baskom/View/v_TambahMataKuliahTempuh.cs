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
    partial class v_TambahMataKuliahTempuh : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunMahasiswa data_akun_pengguna;
        private c_TambahMataKuliahTempuh c_TambahMataKuliahTempuh;
        object[] data_mahasiswa;
        List<object[]> list_konversi_sks;
        List<object[]> list_data_sks;
        public v_TambahMataKuliahTempuh(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataMataKuliah m_DataMataKuliah, m_DataMataKuliahTempuh m_DataMataKuliahTempuh, m_DataKonversiSks m_DataKonversiSks)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_TambahMataKuliahTempuh = new c_TambahMataKuliahTempuh(m_DataMataKuliah, m_DataMataKuliahTempuh, m_DataKonversiSks);
            this.data_akun_pengguna = data_akun_pengguna;
            data_mahasiswa = data_akun_pengguna.getAttributes();
            this.init();
            this.getDataSKS();
            this.isiComboBox();
        }
        public void init()
        {
            List<object[]> list_matkul = this.c_TambahMataKuliahTempuh.initDataGridView((int)data_mahasiswa[0]);
            tbl_matkul.Rows.Clear();
            foreach (object[] item in list_matkul)
            {
                tbl_matkul.Rows.Add(item[1], item[2], item[3]);
            }
        }

        public void getDataSKS()
        {
            this.list_konversi_sks = this.c_TambahMataKuliahTempuh.getListKonversiSks((int)data_mahasiswa[0]);

            List<int> list_idmatkul = new List<int>();

            foreach (object[] item_konversi in list_konversi_sks)
            {
                list_idmatkul.Add((int)item_konversi[4]);
            }

            this.list_data_sks = this.c_TambahMataKuliahTempuh.getMatkulSKS(list_idmatkul);
        }

        public void isiComboBox()
        {
            cbx_matkulygtlhditmph.Items.Clear();
            cbx_matkulygtlhditmph.ResetText();

            List<object[]> list_non_matkul_tempuh = c_TambahMataKuliahTempuh.getAllNonMatkulTempuh((int)data_mahasiswa[0]);
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
                cbx_matkulygtlhditmph.Items.Add(item2[2]);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahKonversiSks();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardMahasiswa();
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

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void btn_tambah_Click(object sender, EventArgs e)
        {
            object[] matkulTempuhBaru = new object[2];

            object b = cbx_matkulygtlhditmph.SelectedItem;
            object matkulDipilih = cbx_matkulygtlhditmph.GetItemText(b);

            if (matkulDipilih.ToString() == "")
            {
                string message = "Pilih Mata Kuliah Yang Tersedia!";
                MessageBox.Show(message);
            }
            else
            {
                List<object[]> list_non_matkul_tempuh = c_TambahMataKuliahTempuh.getAllNonMatkulTempuh((int)data_mahasiswa[0]);
                foreach (object[] item in list_non_matkul_tempuh)
                {
                    if (item[2].ToString() == matkulDipilih.ToString())
                    {
                        matkulTempuhBaru[0] = (int)item[0];
                        matkulTempuhBaru[1] = (int)data_mahasiswa[0];
                    }
                }

                c_TambahMataKuliahTempuh.tambahMataKuliahTempuh(matkulTempuhBaru);

                this.init();
                this.isiComboBox();
            }
        }
    }
}
