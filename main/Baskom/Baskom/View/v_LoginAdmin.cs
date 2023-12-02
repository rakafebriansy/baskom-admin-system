using Baskom.Controller;
using Baskom.Model;

namespace Baskom.View
{
    partial class v_LoginAdmin : Form
    {
        private c_Akun c_Akun;
        private m_DataAkunAdmin m_DataAkunAdmin = new();
        private v_Login v_Login;
        private string kata_sandi;

        public v_LoginAdmin(c_Akun c_Akun, v_Login v_Login)
        {
            InitializeComponent();
            this.c_Akun = c_Akun;
            this.v_Login = v_Login;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_katasandi_Click(object sender, EventArgs e)
        {

        }

        private void lbl_email_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string nidn = tbx_email.Text;
            string kata_sandi = tbx_katasandi.Text;
            c_Akun.loginAdmin(nidn, kata_sandi, this);
            this.Close();
        }

        private void lnk_loginsebagaiyanglain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            v_Login.Show();
            this.Close();
        }

        public bool loginAdmin(string email_admin, string kata_sandi)
        {
            if (email_admin.Length == 0 || kata_sandi.Length == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btn_lihat_Click(object sender, EventArgs e)
        {
            if (tbx_katasandi.Text[0] == '*')
            {
                tbx_katasandi.Text = this.kata_sandi;
            }
            else
            {
                this.kata_sandi = tbx_katasandi.Text;
                tbx_katasandi.Text = String.Concat(Enumerable.Repeat('*', this.tbx_katasandi.Text.Length));
            }
        }
    }
}