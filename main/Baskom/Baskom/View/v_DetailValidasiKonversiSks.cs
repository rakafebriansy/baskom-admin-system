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
    partial class v_DetailValidasiKonversiSks : Form
    {
        c_DetailValidasiKonversiSKS c_DetailValidasiKonversiSKS;
        List<int> list_id_konversi_sks = new List<int>();
        public v_DetailValidasiKonversiSks(string nama_mhs, string nim, string nama_mitra, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataKonversiSks m_DataKonversiSks, m_DataMataKuliah m_DataMataKuliah)
        {
            InitializeComponent();
            lbl_NamaOrang.Text = nama_mhs;
            lbl_NIM.Text = nim;
            lbl_namamitra.Text = nama_mitra;
            this.c_DetailValidasiKonversiSKS = new c_DetailValidasiKonversiSKS(nim, m_DataAkunMahasiswa, m_DataKonversiSks, m_DataMataKuliah);
            this.init();
        }
        public void init()
        {
            list_id_konversi_sks.Clear();
            dataGridView1.Rows.Clear();
            List<object[]> data = c_DetailValidasiKonversiSKS.initDataGridView();
            foreach (object[] item in data)
            {
                bool status_validasi = Convert.ToInt32(item[4]) == 1 ? true : false;
                dataGridView1.Rows.Add(item[0], item[1], item[2], item[3], status_validasi);
                this.list_id_konversi_sks.Add((int)item[5]);
            }
        }
        private void btn_simpan_Click(object sender, EventArgs e)
        {
            List<int> list_status_validasi = new List<int>();
            for (int i = 0; i < list_id_konversi_sks.Count; i++)
            {
                int status_validasi = (bool)dataGridView1.Rows[i].Cells[4].Value ? 1 : 0;
                list_status_validasi.Add(status_validasi);
            }
            string message = c_DetailValidasiKonversiSKS.simpanData(this.list_id_konversi_sks, list_status_validasi);
            if (message.Length > 0)
            {
                MessageBox.Show(message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
