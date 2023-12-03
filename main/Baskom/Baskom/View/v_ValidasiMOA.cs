using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Baskom.Controller;
using Baskom.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Baskom.View
{

    partial class v_ValidasiMOA : Form
    {
        private c_Dashboard c_Dashboard;
        private c_ValidasiMOA c_ValidasiMOA;
        List<int> data_id = new();
        List<string> data_status = new();
        public v_ValidasiMOA(c_Dashboard c_Dashboard, m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataPengajuanMitra m_DataPengajuanMOA, m_DataStatusValidasiMitra m_DataStatusValidasiMitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_ValidasiMOA = new c_ValidasiMOA(m_DataAkunMahasiswa, m_DataPengajuanMOA, m_DataStatusValidasiMitra);
            this.init();
        }
        public void init()
        {
            this.data_status.Clear();
            this.data_id.Clear();
            tbl_statuspengajuanmoa.Rows.Clear();
            List<object[]> data = this.c_ValidasiMOA.initDataGridView();
            for (int i = 0; i < data.Count; i++)
            {
                List<string> list_status = c_ValidasiMOA.initDgvComboBox();
                DataGridViewRow row = new DataGridViewRow();

                DataGridViewTextBoxCell nama_mhs = new DataGridViewTextBoxCell();
                nama_mhs.Value = data[i][0];

                DataGridViewTextBoxCell mitra = new DataGridViewTextBoxCell();
                mitra.Value = data[i][1];

                DataGridViewTextBoxCell deskripsi = new DataGridViewTextBoxCell();
                deskripsi.Value = data[i][2];

                DataGridViewComboBoxCell status_validasi = new DataGridViewComboBoxCell();
                if ((string)data[i][3] == "Belum Dibuat" || (string)data[i][3] == "Sudah Dibuat" || (string)data[i][3] == "Selesai")
                {
                    foreach (string status in list_status)
                    {
                        if (status == "Belum Dibuat" || status == "Sudah Dibuat" || status == "Selesai")
                        {
                            status_validasi.Items.Add(status);
                        }
                    }
                }
                else
                {
                    foreach (string status in list_status)
                    {
                        if (status == "Telah Diajukan" || status == "Telah Disetujui Mitra")
                        {
                            status_validasi.Items.Add(status);
                        }
                    }
                }
                status_validasi.Value = data[i][3];

                row.Cells.Add(nama_mhs);
                row.Cells.Add(mitra);
                row.Cells.Add(deskripsi);
                row.Cells.Add(status_validasi);

                tbl_statuspengajuanmoa.Rows.Add(row);
                if ((string)data[i][3] == "Telah Diajukan")
                {
                    status_validasi.ReadOnly = true;
                } else if ((string)data[i][3] == "Telah Disetujui Mitra")
                {
                    status_validasi.ReadOnly = false;
                }

                this.data_id.Add((int)data[i][4]);
                this.data_status.Add((string)data[i][3]);
            }
        }
        void tbl_statuspengajuanmoa_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // (No need to write anything in here)
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void daftarMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDaftarMitra();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lihatProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilTimMBKM();
        }

        private void konversiNilaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiNilai();
        }

        private void btn_simpan_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.data_id.Count; i++)
            {
                this.data_status[i] = (string)tbl_statuspengajuanmoa.Rows[i].Cells[3].Value;
            }
            string message = c_ValidasiMOA.simpanData(this.data_status, this.data_id);
            if (message.Length > 0)
            {
                MessageBox.Show(message);
            }
            this.init();
        }

        private void berandaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardTimmbkm();
        }

        private void statusPengajuanMOAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this
        }

        private void pembagianTugasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setPembagianTugas();
        }

        private void konversiSKSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setMemvalidasiKonversiSks();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void penerimaanMitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
