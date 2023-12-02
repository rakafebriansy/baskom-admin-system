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
    class c_Dashboard
    {
        private object? data_akun_pengguna;
        private v_Login v_Login;
        private m_DataAkunDosen m_DataAkunDosen = new();
        private m_DataAkunMahasiswa m_DataAkunMahasiswa = new();
        private m_DataAkunTimmbkm m_DataAkunTimmbkm = new();
        private m_DataProdi m_DataProdi = new();
        private m_DataMataKuliah m_DataMataKuliah = new();
        private m_DataMitra m_DataMitra = new();
        private m_DataProgram m_DataProgram = new();
        private m_DataDetailMitra m_DataDetailMitra = new();
        private m_DataDetailProgram m_DataDetailProgram = new();
        private m_DataBkp m_DataBkp = new();
        private m_DataPengajuanMitra m_DataPengajuanMitra = new();
        private m_DataPembagianTugas m_DataPembagianTugas = new();
        private m_DataPenerimaanMitra m_DataPenerimaanMitra = new();
        private m_DataKonversiSks m_DataKonversiSks = new();
        private m_DataKonversiNilai m_DataKonversiNilai = new();
        private m_DataMataKuliahTempuh m_DataMataKuliahTempuh = new();
        private m_DataStatusValidasiMitra m_DataStatusValidasiMitra = new();

        public c_Dashboard(m_DataAkunMahasiswa data_akun_pengguna)
        {
            this.data_akun_pengguna = data_akun_pengguna;
        }
        public c_Dashboard(m_DataAkunTimmbkm data_akun_pengguna)
        {
            this.data_akun_pengguna = data_akun_pengguna;
        }
        public c_Dashboard(m_DataAkunAdmin data_akun_pengguna)
        {
            this.data_akun_pengguna = data_akun_pengguna;
        }
        public void logout() { }
        public void setProfil(object data_akun_pengguna) { }
        public void setDashboardMahasiswa()
        {
            v_DashboardMahasiswa v_DashboardMahasiswa = new(this);
            v_DashboardMahasiswa.Show();
        }
        public void setDashboardAdmin()
        {
            v_DashboardAdmin v_DashboardAdmin = new(this);
            v_DashboardAdmin.Show();
        }
        public void setDashboardTimmbkm()
        {
            v_DashboardTimmbkm v_DashboardTimmbkm = new(this);
            v_DashboardTimmbkm.Show();
        }
        public void setPengajuanMOA()
        {
            v_DashboardMahasiswa v_DashboardMahasiswa = new(this);
            v_PengajuanMOA v_PengajuanMOA = new(this,(m_DataAkunMahasiswa)this.data_akun_pengguna,this.m_DataPengajuanMitra,this.m_DataStatusValidasiMitra);
            v_DashboardMahasiswa.Show();
            v_PengajuanMOA.Show();
        }
        public void setTambahMataKuliahTempuh()
        {
            v_TambahMataKuliahTempuh v_TambahMataKuliahTempuh = new(this, (m_DataAkunMahasiswa)this.data_akun_pengguna, this.m_DataMataKuliah, this.m_DataMataKuliahTempuh, this.m_DataKonversiSks);
            v_TambahMataKuliahTempuh.Show();
        }
        public void setTambahKonversiSks()
        {
            v_TambahKonversiSks v_TambahKonversiSks = new(this, (m_DataAkunMahasiswa)this.data_akun_pengguna, this.m_DataKonversiSks , this.m_DataMataKuliah , this.m_DataMataKuliahTempuh, this.m_DataPenerimaanMitra);
            v_TambahKonversiSks.Show();
        }
        public void setTambahKonversiNilai()
        {
            v_TambahKonversiNilai v_TambahKonversiNilai = new(this, (m_DataAkunMahasiswa)this.data_akun_pengguna,  m_DataKonversiSks, m_DataKonversiNilai, m_DataMataKuliah);
            v_TambahKonversiNilai.Show();
        } 
        public void setProfilMahasiswa()
        {
            v_ProfilMahasiswa v_ProfilMahasiswa = new(this,(m_DataAkunMahasiswa) data_akun_pengguna);
            v_ProfilMahasiswa.Show();
        }
        public void setDaftarMitra()
        {
            v_DaftarMitra v_DaftarMitra = new(this, this.m_DataMitra, this.m_DataBkp);
            v_DaftarMitra.init();
            v_DaftarMitra.Show();
        }
        public void setValidasiMOA()
        {
            v_ValidasiMOA v_ValidasiMOA = new(this, m_DataAkunMahasiswa, this.m_DataPengajuanMitra, this.m_DataStatusValidasiMitra);
            v_ValidasiMOA.Show();
        }
        public void setPembagianTugas()
        {
            v_PembagianTugas v_PembagianTugas = new(this, this.m_DataPembagianTugas, this.m_DataPenerimaanMitra, this.m_DataAkunMahasiswa, this.m_DataAkunDosen, this.m_DataMitra, this.m_DataProgram, this.m_DataProdi, this.data_akun_pengguna);
            v_PembagianTugas.Show();
        }
        public void setMemvalidasiKonversiSks()
        {
            v_MemvalidasiKonversiSks v_MemvalidasiKonversiSks = new(this, this.m_DataKonversiSks, this.m_DataAkunMahasiswa, this.m_DataProdi, this.m_DataPenerimaanMitra, this.m_DataMitra, this.m_DataProgram, this.m_DataPembagianTugas, (m_DataAkunTimmbkm)this.data_akun_pengguna);
            v_MemvalidasiKonversiSks.Show();
        }
        public void setMemvalidasiKonversiNilai()
        {
            v_MemvalidasiKonversiNilai v_MemvalidasiKonversiNilai = new(this, this.m_DataKonversiNilai, this.m_DataAkunDosen, this.m_DataAkunMahasiswa, this.m_DataProdi, this.m_DataPenerimaanMitra, this.m_DataMitra, this.m_DataProgram, this.m_DataPembagianTugas, (m_DataAkunTimmbkm)this.data_akun_pengguna);
            v_MemvalidasiKonversiNilai.Show();
        }
        public void setProfilTimMBKM()
        {
            v_ProfilTimMBKM v_ProfilTimMBKM = new(this, (m_DataAkunTimmbkm)data_akun_pengguna);
            v_ProfilTimMBKM.Show();
        }
        public void setDataDosen()
        {
            v_DataDosen v_DataDosen = new(this, this.m_DataAkunDosen);
            v_DataDosen.init();
            v_DataDosen.Show();
        }
        public void setDataMahasiswa()
        {
            v_DataMahasiswa v_DataMahasiswa = new(this, this.m_DataAkunMahasiswa, this.m_DataPembagianTugas, this.m_DataAkunTimmbkm, this.m_DataAkunDosen);
            v_DataMahasiswa.init();
            v_DataMahasiswa.Show();
        }
        public void setPenerimaanMitra()
        {
            v_PenerimaanMitra v_PenerimaanMitra = new(this,(m_DataAkunMahasiswa)this.data_akun_pengguna, this.m_DataBkp, this.m_DataAkunDosen, this.m_DataMitra, this.m_DataPenerimaanMitra,this.m_DataProgram);
            v_PenerimaanMitra.Show();
        }
        public void setProfilAdmin()
        {
            v_ProfilAdmin v_ProfilAdmin = new(this, (m_DataAkunAdmin)data_akun_pengguna);
            v_ProfilAdmin.Show();
        }
        public void setUbahKataSandiProfil()
        {
            v_UbahKataSandiProfil v_UbahKataSandiProfil;
            if (this.data_akun_pengguna.GetType() == typeof(m_DataAkunMahasiswa))
            {
                v_UbahKataSandiProfil = new v_UbahKataSandiProfil((m_DataAkunMahasiswa)this.data_akun_pengguna);
            }            
            else if (this.data_akun_pengguna.GetType() == typeof(m_DataAkunTimmbkm))
            {
                v_UbahKataSandiProfil = new v_UbahKataSandiProfil((m_DataAkunTimmbkm)this.data_akun_pengguna, this.m_DataAkunDosen);
            }            
            else
            {
                v_UbahKataSandiProfil = new v_UbahKataSandiProfil((m_DataAkunAdmin)this.data_akun_pengguna);
            }
            v_UbahKataSandiProfil.Show();
        }
        public void setTambahDosenTimmbkm()
        {
            v_TambahDosenTimmbkm v_TambahDosenTimmbkm = new(this.m_DataAkunTimmbkm, this.m_DataAkunDosen);
            v_TambahDosenTimmbkm.Show();
        }
        public void setTambahMahasiswa(v_DataMahasiswa v_DataMahasiswa)
        {
            v_TambahMahasiswa v_TambahMahasiswa = new(v_DataMahasiswa, this.m_DataAkunMahasiswa, this.m_DataProdi, this.m_DataAkunTimmbkm,this.m_DataAkunDosen, this.m_DataPembagianTugas);
            v_TambahMahasiswa.Show();
        }
        public void setTambahProgram()
        {
            v_TambahProgramMataKuliah v_TambahProgramMataKuliah = new(this, this.m_DataMataKuliah, this.m_DataProgram, this.m_DataDetailProgram);
            v_TambahProgramMataKuliah.Show();
        }
        public void setTambahMataKuliah()
        {
            v_TambahMataKuliah v_TambahMataKuliah = new(this, this.m_DataMataKuliah);
            v_TambahMataKuliah.init();
            v_TambahMataKuliah.Show();
        }
        public void setTambahMitraProgram()
        {
            v_TambahMitraProgram v_TambahMitraProgram = new(this, this.m_DataMitra, this.m_DataProgram, this.m_DataDetailMitra);
            v_TambahMitraProgram.init();
            v_TambahMitraProgram.Show();
        }
        public void setTambahProgramMataKuliah()
        {
            v_TambahProgramMataKuliah v_TambahProgramMataKuliah = new(this, this.m_DataMataKuliah, this.m_DataProgram, this.m_DataDetailProgram);
            v_TambahProgramMataKuliah.init();
            v_TambahProgramMataKuliah.Show();
        }
        public void setDetailValidasiKonversiSks(string nama_mhs, string nim, string nama_mitra)
        {
            v_DetailValidasiKonversiSks v_DetailValidasiKonversiSks = new(nama_mhs, nim, nama_mitra,this.m_DataAkunMahasiswa,this.m_DataKonversiSks,this.m_DataMataKuliah);
            v_DetailValidasiKonversiSks.Show();
        }        

        public void setDetailValidasiKonversiNilai(string nama_mhs, string nim, string nama_mitra, string prodi,string program)
        {
            v_DetailValidasiKonversiNilai v_DetailValidasiKonversiNilai = new(nama_mhs, nim, nama_mitra,prodi,program,this.m_DataAkunMahasiswa,this.m_DataKonversiNilai, this.m_DataKonversiSks, this.m_DataMataKuliah);
            v_DetailValidasiKonversiNilai.Show();
        }
        public void setLihatMataKuliahProgram()
        {
            v_LihatMataKuliahProgram v_LihatMataKuliahProgram = new(this, (m_DataAkunMahasiswa)this.data_akun_pengguna, this.m_DataPenerimaanMitra, this.m_DataDetailProgram, this.m_DataMataKuliah);
            v_LihatMataKuliahProgram.Show();
        }
    }
}
