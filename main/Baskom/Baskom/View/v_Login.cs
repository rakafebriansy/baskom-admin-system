﻿using Baskom.Controller;
using Baskom.View_Lama;
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
    public partial class v_Login : Form
    {
        public v_Login()
        {
            InitializeComponent();
        }

        private c_Login c_Login = new c_Login();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c_Login.setLoginMahasiswa();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            c_Login.setLoginTimmbkm();   
            this.Hide();
        }

        private void btn_loginadmin_Click(object sender, EventArgs e)
        {
            c_Login.setLoginAdmin();
            this.Hide();
        }
    }
}