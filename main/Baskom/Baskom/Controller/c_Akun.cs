using Baskom.Model;
using Baskom.View;
using Baskom.View_Lama;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    class c_Akun
    {
        private m_DataAkunAdmin m_DataAkunAdmin;
        private m_DataAkunMahasiswa m_DataAkunMahasiswa;
        private m_DataAkunTimmbkm m_DataAkunTimmbkm;

        public c_Akun()
        {
        }
        public bool loginAdmin(string email, string kata_sandi, v_LoginAdmin form)
        {
            this.m_DataAkunAdmin = new m_DataAkunAdmin();
            bool check = this.m_DataAkunAdmin.cekLoginAdmin(email, kata_sandi);
            if (check)
            {
                c_Dashboard c_Dashboard = new(this.m_DataAkunAdmin);
                form.Close();
                c_Dashboard.setDashboardAdmin();
                return true;
            }
            else
            {
                MessageBox.Show("Data Login Tidak Valid!");
                return false;
            }
        }

        public void loginMahasiswa(string nim, string kata_sandi, v_LoginMahasiswa form)
        {
            this.m_DataAkunMahasiswa = new m_DataAkunMahasiswa();
            bool check = this.m_DataAkunMahasiswa.cekLoginMahasiswa(nim, kata_sandi);
            if (check)
            {
                c_Dashboard c_Dashboard = new(this.m_DataAkunMahasiswa);
                form.Close();
                c_Dashboard.setDashboardMahasiswa();
            }
            else
            {
                MessageBox.Show("Data Login Tidak Valid!");
            }
        }

        public void loginTimmbkm(string nidn, string kata_sandi, v_LoginTimmbkm form)
        {
            this.m_DataAkunTimmbkm = new m_DataAkunTimmbkm();
            bool check = this.m_DataAkunTimmbkm.cekLoginTimmbkm(nidn, kata_sandi);
            if (check)
            {
                c_Dashboard c_Dashboard = new(this.m_DataAkunTimmbkm);
                form.Close();
                c_Dashboard.setDashboardTimmbkm();
            }
            else
            {
                MessageBox.Show("Data Login Tidak Valid!");
            }
        }
    }
}
