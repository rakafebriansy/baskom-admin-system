﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBO
{
    public partial class ProfilAdmin : Form
    {
        public ProfilAdmin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profil form4 = new Profil();
            form4.Show();
            this.Hide();
        }

        private void akunTimMBKMToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard form2 = new Dashboard();
            form2.Show();
            this.Hide();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mitra form5 = new Mitra();
            form5.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}