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
    partial class v_UbahKataSandiProfil : Form
    {
        private c_UbahKataSandiProfil c_UbahKataSandiProfil;
        private int panjang_sandi;
        private int index_kata_sandi;
        private object[] atribut_data_akun;
        private object data_akun_pengguna;
        public v_UbahKataSandiProfil(m_DataAkunMahasiswa data_akun_pengguna)
        {
            InitializeComponent();
            this.c_UbahKataSandiProfil = new c_UbahKataSandiProfil(data_akun_pengguna);
            this.atribut_data_akun = data_akun_pengguna.getAttributes();
            this.index_kata_sandi = 8;
            this.panjang_sandi = ((string)atribut_data_akun[this.index_kata_sandi]).Length;
            this.sembunyikanKataSandi();
            this.data_akun_pengguna = data_akun_pengguna;

        }
        public v_UbahKataSandiProfil(m_DataAkunTimmbkm data_akun_pengguna, m_DataAkunDosen m_DataAkunDosen)
        {
            InitializeComponent();
            this.c_UbahKataSandiProfil = new c_UbahKataSandiProfil(data_akun_pengguna, m_DataAkunDosen);
            this.atribut_data_akun = data_akun_pengguna.getDosenAttributes();
            this.index_kata_sandi = 6;
            this.panjang_sandi = ((string)atribut_data_akun[this.index_kata_sandi]).Length;
            this.sembunyikanKataSandi();
            this.data_akun_pengguna = data_akun_pengguna;
        }
        public v_UbahKataSandiProfil(m_DataAkunAdmin data_akun_pengguna)
        {
            InitializeComponent();
            this.c_UbahKataSandiProfil = new c_UbahKataSandiProfil(data_akun_pengguna);
            this.atribut_data_akun = data_akun_pengguna.getAttributes();
            this.index_kata_sandi = 3;
            this.panjang_sandi = ((string)atribut_data_akun[this.index_kata_sandi]).Length;
            this.sembunyikanKataSandi();
            this.data_akun_pengguna = data_akun_pengguna;
        }

        private void sembunyikanKataSandi()
        {
            lbl_katasandilama.Text = String.Concat(Enumerable.Repeat('*', this.panjang_sandi));
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string message = "";
            string kata_sandi_baru = tbx_katasandibaru.Text;
            string konfirmasi = tbx_konfirmasikatasandibaru.Text;
            if (this.data_akun_pengguna.GetType() == typeof(m_DataAkunMahasiswa))
            {
                if (kata_sandi_baru.Length > 0 & konfirmasi.Length > 0)
                {
                    if (kata_sandi_baru == konfirmasi)
                    {
                        message = c_UbahKataSandiProfil.ubahKataSandiProfilMhs(Convert.ToInt32(atribut_data_akun[0]), kata_sandi_baru);
                        this.atribut_data_akun[8] = kata_sandi_baru;
                        this.panjang_sandi = kata_sandi_baru.Length;
                        this.sembunyikanKataSandi();
                        tbx_katasandibaru.Text = "";
                        tbx_konfirmasikatasandibaru.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Konfirmasi Kata Sandi Berbeda!");
                }
            }
            else if (this.data_akun_pengguna.GetType() == typeof(m_DataAkunTimmbkm))
            {
                if (kata_sandi_baru.Length > 0 & konfirmasi.Length > 0)
                {
                    if (kata_sandi_baru == konfirmasi)
                    {
                        message = c_UbahKataSandiProfil.ubahKataSandiProfilDosen(Convert.ToInt32(atribut_data_akun[2]), kata_sandi_baru);
                        this.panjang_sandi = kata_sandi_baru.Length;
                        this.sembunyikanKataSandi();
                        tbx_katasandibaru.Text = "";
                        tbx_konfirmasikatasandibaru.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Konfirmasi Kata Sandi Berbeda!");
                    }
                }
            }
            else if (this.data_akun_pengguna.GetType() == typeof(m_DataAkunAdmin))
            {
                if (kata_sandi_baru.Length > 0 & konfirmasi.Length > 0)
                {
                    if (kata_sandi_baru == konfirmasi)
                    {
                        message = c_UbahKataSandiProfil.ubahKataSandiProfilAdmin(Convert.ToInt32(atribut_data_akun[0]), kata_sandi_baru);
                        this.atribut_data_akun[3] = kata_sandi_baru;
                        this.panjang_sandi = kata_sandi_baru.Length;
                        this.sembunyikanKataSandi();
                        tbx_katasandibaru.Text = "";
                        tbx_konfirmasikatasandibaru.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Konfirmasi Kata Sandi Berbeda!");
                    }
                }
            }
            if (message.Length > 0)
            {
                MessageBox.Show(message);
                this.Close();
            }
            else
            {
                MessageBox.Show("Masukkan Kata Sandi Baru!");
            }


        }

        private void btn_lihat_Click(object sender, EventArgs e)
        {
            string kata_sandi = lbl_katasandilama.Text;
            if (kata_sandi[0] == '*')
            {
                lbl_katasandilama.Text = (string)atribut_data_akun[this.index_kata_sandi];
            }
            else
            {
                this.sembunyikanKataSandi();
            }
        }
    }
}
