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
    partial class v_DetailValidasiKonversiNilai : Form
    {
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataKonversiNilai m_DataKonversiNilai;
        m_DataMataKuliah m_DataMataKuliah;
        c_DetailValidasiKonversiNilai c_DetailValidasiKonversiNilai;
        List<int> list_id_konversi_nilai = new List<int>();
        public v_DetailValidasiKonversiNilai(string nama_mhs, string nim, string nama_mitra, string prodi, string program, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataKonversiNilai m_DataKonversiNilai, m_DataKonversiSks m_DataKonversiSks, m_DataMataKuliah m_DataMataKuliah)
        {
            InitializeComponent();
            lbl_nama.Text = nama_mhs;
            lbl_nim.Text = nim;
            lbl_mitra.Text = nama_mitra;
            lbl_prodi.Text = prodi;
            lbl_posisi.Text = program;
            this.m_DataAkunMahasiswa = m_DataAkunMahasiswa;
            this.m_DataKonversiNilai = m_DataKonversiNilai;
            this.m_DataMataKuliah = m_DataMataKuliah;
            this.c_DetailValidasiKonversiNilai = new c_DetailValidasiKonversiNilai(nim, m_DataAkunMahasiswa, m_DataKonversiNilai, m_DataKonversiSks, m_DataMataKuliah);
            this.init();
        }
        public void init()
        {
            list_id_konversi_nilai.Clear();
            tbl_detailkonversinilai.Rows.Clear();
            List<object[]> data = c_DetailValidasiKonversiNilai.initDataGridView();
            foreach (object[] item in data)
            {
                bool status_validasi = Convert.ToInt32(item[4]) == 1 ? true : false;
                tbl_detailkonversinilai.Rows.Add(item[0], item[1], item[2], item[3], status_validasi);
                list_id_konversi_nilai.Add((int)item[5]);
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<int> list_status_validasi = new List<int>();
            for(int i=0;i<list_id_konversi_nilai.Count;i++)
            {
                int status_validasi = (bool)tbl_detailkonversinilai.Rows[i].Cells[4].Value? 1:0;
                list_status_validasi.Add(status_validasi);
            }
            string message = c_DetailValidasiKonversiNilai.simpanData(list_id_konversi_nilai, list_status_validasi);
            if(message.Length > 0 )
            {
                MessageBox.Show(message);
            }
        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbl_detailkonversinilai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
