﻿using System;
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
    public partial class v_CariMataKuliah : Form
    {
        public v_CariMataKuliah()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            v_TambahKonversiSks v_TambahKonversiSks = new v_TambahKonversiSks();
            v_TambahKonversiSks.Show();
            this.Hide();
        }
    }
}
