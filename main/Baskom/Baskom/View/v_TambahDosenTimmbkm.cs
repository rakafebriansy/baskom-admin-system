using Baskom.Controller;
using Baskom.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Baskom.View
{
    partial class v_TambahDosenTimmbkm : Form
    {
        c_TambahDosenTimmbkm c_TambahDosenTimmbkm;
        v_DataDosen v_DataDosen;
        public v_TambahDosenTimmbkm(m_DataAkunTimmbkm m_DataAkunTimmbkm, m_DataAkunDosen m_DataAkunDosen, v_DataDosen v_DataDosen)
        {
            InitializeComponent();
            this.c_TambahDosenTimmbkm = new c_TambahDosenTimmbkm(m_DataAkunTimmbkm, m_DataAkunDosen);
            this.v_DataDosen = v_DataDosen;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void daftardosen_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label5_Click_1(object sender, EventArgs e)
        {
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_tambahtambahdosen_Click(object sender, EventArgs e)
        {
            string message = "";

            object b = cbx_jabatandosen.SelectedItem;
            object jabatanDipilih = cbx_jabatandosen.GetItemText(b);

            if (tbx_namatambahdosen.Text == "")
            {
                message = "Nama Dosen Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_namatambahdosen.Text.ToCharArray().Any(c => Char.IsNumber(c)))
            {
                message = "Nama Dosen Hanya Huruf!";
                MessageBox.Show(message);
            }
            else if (tbx_niptambahdosen.Text == "")
            {
                message = "NIP Dosen Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_niptambahdosen.Text.ToCharArray().Any(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                message = "NIP Hanya Berisi Angka!";
                MessageBox.Show(message);
            }
            else if (tbx_niptambahdosen.Text.Count() != 9 && tbx_niptambahdosen.Text.Count() != 18)
            {
                message = "NIP Hanya Berjumlah 9 digit (lama) dan 18 digit (baru)!";
                MessageBox.Show(message);
            }
            else if (tbx_nidntambahdosen.Text == "")
            {
                message = "NIDN Dosen Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_nidntambahdosen.Text.ToCharArray().Any(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                message = "NIDN Hanya Berisi Angka!";
                MessageBox.Show(message);
            }
            else if (tbx_nidntambahdosen.Text.Count() != 10)
            {
                message = "NIDN Hanya Berjumlah 10 digit!";
                MessageBox.Show(message);
            }
            else if (jabatanDipilih.ToString() == "")
            {
                message = "Pilih Jabatan Yang Tersedia!";
                MessageBox.Show(message);
            }
            else if (tbx_nowatambahdosen.Text == "")
            {
                message = "No Wa Dosen Tidak Boleh Kosong!";
                MessageBox.Show(message);
            }
            else if (tbx_nowatambahdosen.Text.ToCharArray().Any(c => Char.IsLetter(c) || Char.IsWhiteSpace(c)))
            {
                message = "No Wa Hanya Berisi Angka!";
                MessageBox.Show(message);
            }
            else if (tbx_nowatambahdosen.Text.Count() < 11 || tbx_nowatambahdosen.Text.Count() > 13)
            {
                message = "No Wa Harus Sesuai! (11-13 digit)";
                MessageBox.Show(message);
            }
            else if (tbx_emailtambahdosen.Text == "")
            {
                message = "Email Tidak Boleh Kosong";
                MessageBox.Show(message);
            }
            else if (tbx_katasanditambahdosen.Text == "")
            {
                message = "Kata Sandi Tidak Boleh Kosong";
                MessageBox.Show(message);
            }
            else if (tbx_katasanditambahdosen.Text.Count() < 8)
            {
                message = "Kata Sandi Minimal 8 Karakter";
                MessageBox.Show(message);
            }
            else
            {
                bool result;
                try
                {
                    System.Net.Mail.MailAddress email = new System.Net.Mail.MailAddress(tbx_emailtambahdosen.Text);
                    result = true;
                }
                catch (Exception)
                {
                    result = false;
                    MessageBox.Show("Format Emailmu Tidak Valid!");
                }

                if (result)
                {
                    object[] dosen = new object[9];

                    dosen[0] = tbx_niptambahdosen.Text;
                    dosen[1] = tbx_nidntambahdosen.Text;
                    dosen[2] = tbx_namatambahdosen.Text;
                    dosen[3] = tbx_nowatambahdosen.Text;
                    dosen[4] = tbx_emailtambahdosen.Text;
                    dosen[5] = tbx_katasanditambahdosen.Text;
                    dosen[6] = cbx_jabatandosen.Text;

                    message = this.c_TambahDosenTimmbkm.tambahDosenBaru(dosen);

                    if (message == "Data Dosen Berhasil Ditambahkan!" && jabatanDipilih.ToString() == "Tim MBKM")
                    {
                        message = this.c_TambahDosenTimmbkm.tambahTimmbkmBaru(dosen);

                        if (message != "Data TimMbkm Berhasil Ditambahkan!")
                        {
                            MessageBox.Show(message);
                        }
                        else
                        {
                            MessageBox.Show(message);
                            this.Close();
                            v_DataDosen.init();
                        }
                    } else if (message != "Data Dosen Berhasil Ditambahkan!")
                    {
                        MessageBox.Show(message);
                    } else
                    {
                        MessageBox.Show(message);
                        this.Close();
                        v_DataDosen.init();
                    }
                }
            }
        }
    }
}
