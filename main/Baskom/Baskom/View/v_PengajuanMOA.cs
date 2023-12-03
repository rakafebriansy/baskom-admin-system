using Baskom.Controller;
using Baskom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Baskom.View
{
    partial class v_PengajuanMOA : Form
    {
        private c_Dashboard c_Dashboard;
        private m_DataAkunMahasiswa data_akun_pengguna;
        private c_PengajuanMOA c_PengajuanMOA;
        object[] pengajuan_mitra_baru = new object[5];
        bool available;
        public v_PengajuanMOA(c_Dashboard c_Dashboard, m_DataAkunMahasiswa data_akun_pengguna, m_DataPengajuanMitra m_DataPengajuanMitra, m_DataStatusValidasiMitra m_DataStatusValidasiMitra)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_Dashboard = c_Dashboard;
            this.c_PengajuanMOA = new c_PengajuanMOA(m_DataPengajuanMitra, m_DataStatusValidasiMitra);
            this.data_akun_pengguna = data_akun_pengguna;
            this.available = false;
            List<string> data_status = m_DataStatusValidasiMitra.getAllStatusValidasiMitra();
            foreach (string item in data_status)
            {
                if (item == "Telah Diajukan" || item == "Telah Disetujui Mitra")
                {
                    cbx_statusmitra.Items.Add(item);
                }
            }


            this.setMOA();
        }
        public void setMOA()
        {
            object[] data_mahasiswa = this.data_akun_pengguna.getAttributes();
            List<object[]> data_pengajuan = c_PengajuanMOA.getAllPengajuanMitra();

            foreach (object[] item in data_pengajuan)
            {
                if ((int)item[4] == (int)data_mahasiswa[0])
                {
                    this.available = true;
                    this.pengajuan_mitra_baru = item;
                    break;
                }
            }

            if (this.available)
            {
                tbx_namamitra.Enabled = false;
                tbx_deksripsimitra.Enabled = false;
                tbx_namamitra.Text = (string)pengajuan_mitra_baru[1];
                tbx_deksripsimitra.Text = (string)pengajuan_mitra_baru[2];
                this.setStatus((int)pengajuan_mitra_baru[3]);
            }
            else
            {
                tbx_namamitra.Enabled = true;
                tbx_deksripsimitra.Enabled = true;
                cbx_statusmitra.Enabled = false;
            }
        }
        public void setStatus(int id_status)
        {

            string status = c_PengajuanMOA.getStatusValidasiMitraById(id_status);
            if (status == "Belum Dibuat")
            {
                cbx_statusmitra.Enabled = false;
                cbx_statusmitra.Text = status;

            }
            else if (status == "Sudah Dibuat")
            {
                cbx_statusmitra.Enabled = true;
                cbx_statusmitra.Text = status;
            }
            else if (status == "Telah Diajukan")
            {
                cbx_statusmitra.Enabled = true;
                cbx_statusmitra.Text = status;
            }
            else if (status == "Telah Disetujui Mitra")
            {
                cbx_statusmitra.Enabled = false;
                cbx_statusmitra.Text = status;
            }
            else if (status == "Selesai")
            {
                cbx_statusmitra.Enabled = false;
                cbx_statusmitra.Text = status;
            }
        }

        private void btn_simpanstatus_Click(object sender, EventArgs e)
        {
            string message = "";
            object status = cbx_statusmitra.SelectedItem;
            object status_dipilih = cbx_statusmitra.GetItemText(status);

            if (tbx_namamitra.Text == "")
            {
                message = "Nama Mitra Tidak Boleh Kosong!";
                MessageBox.Show(message);
            } else if (tbx_deksripsimitra.Text == "")
            {
                message = "Deskripsi Mitra Tidak Boleh Kosong!";
                MessageBox.Show(message);
            } else
            {
                if (((string)status_dipilih).Length > 0)
                {
                    message = c_PengajuanMOA.updateStatusValidasi((string)status_dipilih, (int)pengajuan_mitra_baru[0]);
                }
                else
                {
                    object[] pengajuan_mitra_baru = new object[4];
                    pengajuan_mitra_baru[0] = tbx_namamitra.Text;
                    pengajuan_mitra_baru[1] = tbx_deksripsimitra.Text;
                    pengajuan_mitra_baru[2] = "Belum Dibuat";
                    pengajuan_mitra_baru[3] = data_akun_pengguna.getAttributes()[0];
                    message = c_PengajuanMOA.tambahPengajuanMitra(pengajuan_mitra_baru);
                }
                if (message.Length > 0)
                {
                    MessageBox.Show(message);
                } else
                {
                    setMOA();
                    message = "Mitra Berhasil Ditambahkan!";
                    MessageBox.Show(message);
                }

                this.Close();
            }
        }
        private void statusmitra_Load(object sender, EventArgs e)
        {

        }
    }
}
