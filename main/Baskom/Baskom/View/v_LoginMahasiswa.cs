﻿using Baskom.Controller;
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
    public partial class v_LoginMahasiswa : Form
    {
        private c_Akun c_Akun = new c_Akun();
        private m_DataAkunMahasiswa m_DataAkunMahasiswa = new m_DataAkunMahasiswa();

        public v_LoginMahasiswa()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*string nim_mahasiswa = tbx_nimlogin.Text;
            string kata_sandi = tbx_katasandilogin.Text;

            bool notNull = this.loginMahasiswa(nim_mahasiswa, kata_sandi);

            if (notNull == true)
            {
                bool validasi = c_Akun.cekLoginMahasiswa(nim_mahasiswa, kata_sandi);
                if (validasi == true)
                {*/
                    c_Akun.loginMahasiswa(m_DataAkunMahasiswa);
                    this.Hide();/*
                }

            }*/
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            v_Login v_Login = new v_Login();
            v_Login.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        public bool loginMahasiswa(string nim_mahasiswa, string kata_sandi)
        {
            if (nim_mahasiswa.Length == 0 || kata_sandi.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
