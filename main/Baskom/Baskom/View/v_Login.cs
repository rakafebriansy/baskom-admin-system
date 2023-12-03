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
    public partial class v_Login : Form
    {
        private c_Login c_Login;
        public v_Login()
        {
            InitializeComponent();
            this.c_Login = new c_Login(this);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c_Login.setLoginMahasiswa(this);
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
            c_Login.setLoginTimmbkm(this);
        }

        private void btn_loginadmin_Click(object sender, EventArgs e)
        {
            c_Login.setLoginAdmin(this);
        }
    }
}
