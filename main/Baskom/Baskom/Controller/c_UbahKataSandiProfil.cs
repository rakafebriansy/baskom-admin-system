﻿using Baskom.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baskom.Controller
{
    internal class c_UbahKataSandiProfil
    {
        m_DataAkunMahasiswa m_DataAkunMahasiswa;
        m_DataAkunTimmbkm m_DataAkunTimmbkm;
        m_DataAkunAdmin m_DataAkunAdmin;
        public c_UbahKataSandiProfil(m_DataAkunMahasiswa data_akun_pengguna)
        {
            this.m_DataAkunMahasiswa = data_akun_pengguna;
        }
        public c_UbahKataSandiProfil(m_DataAkunTimmbkm data_akun_pengguna)
        {
            this.m_DataAkunTimmbkm = data_akun_pengguna;
        }
        public c_UbahKataSandiProfil(m_DataAkunAdmin data_akun_pengguna)
        {
            this.m_DataAkunAdmin = data_akun_pengguna;
        }
        public string ubahKataSandiProfil(int id_akun, string kata_sandi_baru)
        {
            m_DataAkunMahasiswa.updateKataSandi(id_akun, kata_sandi_baru);
            return "Kata Sandi Telah Diubah!";
        }
    }
}
