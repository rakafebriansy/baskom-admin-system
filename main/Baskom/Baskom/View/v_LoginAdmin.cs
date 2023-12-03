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
            bool berhasil = c_Akun.loginAdmin(nidn, kata_sandi, this);
            if (berhasil == true)
            {
                this.Close();
            } else
            {
                tbx_email.Clear();
                tbx_katasandi.Clear();
            }
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
            if (tbx_katasandi.PasswordChar == (char)0)
            {
                tbx_katasandi.PasswordChar = '*';
            }
            else
            {
                tbx_katasandi.PasswordChar = (char)0;
            }
        }

        private void tbx_katasandi_TextChanged(object sender, EventArgs e)
        {
            tbx_katasandi.ForeColor = Color.Black;
            tbx_katasandi.PasswordChar = '*';
        }
    }
}