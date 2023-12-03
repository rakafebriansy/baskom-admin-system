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
    partial class v_DetailMahasiswa : Form
    {
        c_DetailMahasiswa c_DetailMahasiswa;
        public v_DetailMahasiswa(m_DataAkunMahasiswa m_DataAkunMahasiswa, m_DataProdi m_DataProdi, string nim)
        {
            InitializeComponent();
            this.c_DetailMahasiswa = new c_DetailMahasiswa(m_DataAkunMahasiswa, m_DataProdi);
            this.init(nim);
        }

        public void init(string nim)
        {
            object[] data = this.c_DetailMahasiswa.initProfile(nim);
            lbl_detailnamamhs.Text = (string)data[2];
            lbl_detailnimmhs.Text = (string)data[1];
            lbl_detailprodimhs.Text = (string)data[9];
            lbl_detailthmasukmhs.Text = data[3].ToString();
            lbl_detailstatusmhs.Text = Convert.ToInt32(data[4]) == 1 ? "Aktif" : "Tidak Aktif";
            lbl_detailnowamhs.Text = (string)data[5];
            lbl_detailbatchmhs.Text = data[6].ToString();
            lbl_detailemailmhs.Text = (string)data[7];
        }
        private void lbl_detailthmasukdosen_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lbl_detailnamamhs_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void lbl_detailnimmhs_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void lbl_detailprodimhs_Click(object sender, EventArgs e)
        {
        }

        private void label9_Click(object sender, EventArgs e)
        {
        }

        private void label11_Click(object sender, EventArgs e)
        {
        }

        private void lbl_detailstatusmhs_Click(object sender, EventArgs e)
        {
        }

        private void lbl_detailbatchmhs_Click(object sender, EventArgs e)
        {

        }

        private void lbl_detailnowamhs_Click(object sender, EventArgs e)
        {

        }
    }
}
