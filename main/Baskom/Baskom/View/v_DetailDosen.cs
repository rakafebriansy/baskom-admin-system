using Baskom.Model;
using Baskom.Controller;
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
    partial class v_DetailDosen : Form
    {
        c_DetailDosen c_DetailDosen;
        public v_DetailDosen(m_DataAkunDosen m_DataAkunDosen, m_DataAkunTimmbkm m_DataAkunTimmbkm, string nip)
        {
            InitializeComponent();
            this.c_DetailDosen = new c_DetailDosen(m_DataAkunDosen, m_DataAkunTimmbkm);
            this.init(nip);
        }
        public void init(string nip)
        {
            object[] data = c_DetailDosen.initProfile(nip);
            lbl_detailnamadosen.Text = (string)data[3];
            lbl_detailnipdosen.Text = (string)data[1];
            lbl_detailnidndosen.Text = (string)data[2];
            lbl_detailjabatandosen.Text = c_DetailDosen.cekTimmbkm((string)data[2])? "Tim MBKM": "Dosen";
            lbl_detailemaildosen.Text = (string)data[5];
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void v_DetailDosen_Load(object sender, EventArgs e)
        {

        }

        private void btn_kembalidetaildoesn_Click(object sender, EventArgs e)
        {

        }

        private void lbl_detailemaildosen_Click(object sender, EventArgs e)
        {

        }
    }
}
