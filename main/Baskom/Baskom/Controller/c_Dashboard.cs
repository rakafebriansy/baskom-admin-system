﻿using Baskom.Model;
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
        private m_DataAkunDosen m_DataAkunDosen = new();
        private m_DataAkunMahasiswa m_DataAkunMahasiswa = new();
        private m_DataAkunTimmbkm m_DataAkunTimmbkm = new();
        private v_DashboardMahasiswa v_DashboardMahasiswa;
        private v_DashboardAdmin v_DashboardAdmin;
        private v_DashboardTimmbkm v_DashboardTimmbkm;
        private v_DataDosen v_DataDosen;
        private v_DataMahasiswa v_DataMahasiswa;
        private v_DaftarMitra v_DaftarMitra;
        private v_MemvalidasiKonversiSks v_MemvalidasiKonversiSks;
        private v_MemvalidasiKonversiNilai v_MemvalidasiKonversiNilai;
        private v_PembagianTugas v_PembagianTugas;
        private v_PengajuanMOA v_PengajuanMOA;
        private v_ProfilMahasiswa v_ProfilMahasiswa;
        private v_ProfilTimMBKM v_ProfilTimMBKM;
        private v_ProfilAdmin v_ProfilAdmin;
        private v_StatusMOA v_StatusMOA;
        private v_TambahKonversiNilai v_TambahKonversiNilai;
        private v_TambahKonversiSks v_TambahKonversiSks;
        private v_TambahMataKuliahTempuh v_TambahMataKuliahTempuh;
        private v_PengajuanMitra v_PengajuanMitra;
        private v_TambahPengajuanMitra v_TambahPengajuanMitra;
        private v_TambahDosen v_TambahDosen;
        private v_TambahMahasiswa v_TambahMahasiswa;
        private v_FormUbahKataSandi v_FormUbahKataSandi;
        private v_DataMitra v_DataMitra;
        private v_TambahProgram v_TambahProgram;
        private v_TambahMataKuliah v_TambahMataKuliah;


        public c_Dashboard(object data_akun_pengguna)
        {
            this.data_akun_pengguna = data_akun_pengguna;
            this.v_FormUbahKataSandi = new v_FormUbahKataSandi();
            if (data_akun_pengguna.GetType() == typeof(m_DataAkunMahasiswa))
            {
                v_DashboardMahasiswa v_DashboardMahasiswa = new(this);
                v_PengajuanMitra v_PengajuanMitra = new(this);
                v_StatusMOA v_StatusMOA = new(this);
                v_TambahMataKuliahTempuh v_TambahMataKuliahTempuh = new(this);
                v_TambahKonversiSks v_TambahKonversiSks = new(this);
                v_TambahKonversiNilai v_TambahKonversiNilai = new(this);
                v_ProfilMahasiswa v_ProfilMahasiswa = new(this, (m_DataAkunMahasiswa)data_akun_pengguna);
                this.v_DashboardMahasiswa = v_DashboardMahasiswa;
                this.v_PengajuanMitra = v_PengajuanMitra;
                this.v_StatusMOA = v_StatusMOA;
                this.v_TambahMataKuliahTempuh = v_TambahMataKuliahTempuh;
                this.v_TambahKonversiSks = v_TambahKonversiSks;
                this.v_TambahKonversiNilai = v_TambahKonversiNilai;
                this.v_ProfilMahasiswa = v_ProfilMahasiswa;
            }
            else if (data_akun_pengguna.GetType() == typeof(m_DataAkunTimmbkm))
            {
                v_DashboardTimmbkm v_DashboardTimmbkm = new(this);
                v_DaftarMitra v_DaftarMitra = new(this);
                v_PengajuanMOA v_PengajuanMOA = new(this);
                v_PembagianTugas v_PembagianTugas = new(this);
                v_MemvalidasiKonversiSks v_MemvalidasiKonversiSks = new(this);
                v_MemvalidasiKonversiNilai v_MemvalidasiKonversiNilai = new(this);
                v_ProfilTimMBKM v_ProfilTimMBKM = new(this,(m_DataAkunTimmbkm)data_akun_pengguna);
                this.v_DashboardTimmbkm = v_DashboardTimmbkm;
                this.v_DaftarMitra = v_DaftarMitra;
                this.v_PengajuanMOA = v_PengajuanMOA;
                this.v_PembagianTugas = v_PembagianTugas;
                this.v_MemvalidasiKonversiSks = v_MemvalidasiKonversiSks;
                this.v_MemvalidasiKonversiNilai = v_MemvalidasiKonversiNilai;
                this.v_ProfilTimMBKM = v_ProfilTimMBKM;
            }
            else if (data_akun_pengguna.GetType() == typeof(m_DataAkunAdmin))
            {
                v_DashboardAdmin v_DashboardAdmin = new(this);
                v_ProfilAdmin v_ProfilAdmin = new(this,(m_DataAkunAdmin)data_akun_pengguna);
                v_DataMahasiswa v_DataMahasiswa = new(this, this.m_DataAkunMahasiswa);
                v_DataDosen v_DataDosen = new(this, this.m_DataAkunDosen);
                v_DataMitra v_DataMitra = new(this);
                v_TambahProgram v_TambahProgram = new(this);
                v_TambahMataKuliah v_TambahMataKuliah = new(this);
                v_TambahDosen v_TambahDosen = new();
                v_TambahMahasiswa v_TambahMahasiswa = new();
                this.v_DashboardAdmin = v_DashboardAdmin;
                this.v_ProfilAdmin = v_ProfilAdmin;
                this.v_DataMahasiswa = v_DataMahasiswa;
                this.v_DataDosen = v_DataDosen;
                this.v_DataMitra = v_DataMitra;
                this.v_TambahProgram = v_TambahProgram;
                this.v_TambahMataKuliah = v_TambahMataKuliah;
                this.v_TambahDosen = v_TambahDosen;
                this.v_TambahMahasiswa = v_TambahMahasiswa;
            }
        }
        public void logout() { }
        public void setProfil(object data_akun_pengguna) { }
        public void setDashboardMahasiswa()
        {
            this.v_DashboardMahasiswa.Show();
        }
        public void setDashboardAdmin()
        {
            this.v_DashboardAdmin.Show();
        }
        public void setDashboardTimmbkm()
        {
            this.v_DashboardTimmbkm.Show();
        }
        public void setStatusMOA()
        {
            this.v_StatusMOA.Show();
        }
        public void setTambahMataKuliahTempuh()
        {
            this.v_TambahMataKuliahTempuh.Show();
        }
        public void setTambahKonversiSks()
        {
            this.v_TambahKonversiSks.Show();
        }
        public void setTambahKonversiNilai()
        {
            this.v_TambahKonversiNilai.Show();
        }
        public void setProfilMahasiswa()
        {
            this.v_ProfilMahasiswa.Show();
        }
        public void setDaftarMitra()
        {
            this.v_DaftarMitra.Show();
        }
        public void setPengajuanMOA()
        {
            this.v_PengajuanMOA.Show();
        }
        public void setPembagianTugas()
        {
            this.v_PembagianTugas.Show();
        }
        public void setMemvalidasiKonversiSks()
        {
            this.v_MemvalidasiKonversiSks.Show();
        }
        public void setMemvalidasiKonversiNilai()
        {
            this.v_MemvalidasiKonversiNilai.Show();
        }
        public void setProfilTimMBKM()
        {
            this.v_ProfilTimMBKM.Show();
        }
        public void setDataDosen()
        {
            this.v_DataDosen.Show();
        }
        public void setDataMahasiswa()
        {
            this.v_DataMahasiswa.Show();
        }
        public void setPengajuanMitra()
        {
            this.v_PengajuanMitra.Show();
        }
        public void setProfilAdmin()
        {
            this.v_ProfilAdmin.Show();
        }
        public void setFormUbahKataSandi()
        {
            this.v_FormUbahKataSandi.ShowDialog();
        }
        public void setTambahDosen()
        {
            this.v_TambahDosen.ShowDialog();
        }
        public void setTambahMahasiswa()
        {
            this.v_TambahMahasiswa.ShowDialog();
        }
        public void setDataMitra()
        {
            this.v_DataMitra.Show();
        }
        public void setTambahProgram()
        {
            this.v_TambahProgram.Show();
        }
        public void setTambahMataKuliah()
        {
            this.v_TambahMataKuliah.Show();
        }
    }
}