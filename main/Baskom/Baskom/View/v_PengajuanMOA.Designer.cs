﻿namespace Baskom.View
{
    partial class v_PengajuanMOA
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_PengajuanMOA));
            menuStrip1 = new MenuStrip();
            berandaToolStripMenuItem = new ToolStripMenuItem();
            penerimaanMitraToolStripMenuItem = new ToolStripMenuItem();
            daftarMitraToolStripMenuItem = new ToolStripMenuItem();
            statusPengajuanMOAToolStripMenuItem = new ToolStripMenuItem();
            pembagianTugasToolStripMenuItem = new ToolStripMenuItem();
            konversiSKSToolStripMenuItem = new ToolStripMenuItem();
            konversiNilaiToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            lihatProfilToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tbl_statuspengajuanmoa = new DataGridView();
            clm_nama = new DataGridViewTextBoxColumn();
            clm_mitra = new DataGridViewTextBoxColumn();
            clm_deskripsi = new DataGridViewTextBoxColumn();
            clm_status = new DataGridViewComboBoxColumn();
            btn_simpan = new Button();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_statuspengajuanmoa).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { berandaToolStripMenuItem, penerimaanMitraToolStripMenuItem, pembagianTugasToolStripMenuItem, konversiSKSToolStripMenuItem, konversiNilaiToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(13, 5, 0, 5);
            menuStrip1.Size = new Size(1517, 48);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // berandaToolStripMenuItem
            // 
            berandaToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            berandaToolStripMenuItem.Name = "berandaToolStripMenuItem";
            berandaToolStripMenuItem.Size = new Size(151, 38);
            berandaToolStripMenuItem.Text = "Dashboard";
            berandaToolStripMenuItem.Click += berandaToolStripMenuItem_Click;
            // 
            // penerimaanMitraToolStripMenuItem
            // 
            penerimaanMitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { daftarMitraToolStripMenuItem, statusPengajuanMOAToolStripMenuItem });
            penerimaanMitraToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            penerimaanMitraToolStripMenuItem.Name = "penerimaanMitraToolStripMenuItem";
            penerimaanMitraToolStripMenuItem.Size = new Size(222, 38);
            penerimaanMitraToolStripMenuItem.Text = "Penerimaan Mitra";
            penerimaanMitraToolStripMenuItem.Click += penerimaanMitraToolStripMenuItem_Click;
            // 
            // daftarMitraToolStripMenuItem
            // 
            daftarMitraToolStripMenuItem.Name = "daftarMitraToolStripMenuItem";
            daftarMitraToolStripMenuItem.Size = new Size(359, 44);
            daftarMitraToolStripMenuItem.Text = "Daftar Mitra";
            daftarMitraToolStripMenuItem.Click += daftarMitraToolStripMenuItem_Click;
            // 
            // statusPengajuanMOAToolStripMenuItem
            // 
            statusPengajuanMOAToolStripMenuItem.Name = "statusPengajuanMOAToolStripMenuItem";
            statusPengajuanMOAToolStripMenuItem.Size = new Size(359, 44);
            statusPengajuanMOAToolStripMenuItem.Text = "Validasi MOA";
            statusPengajuanMOAToolStripMenuItem.Click += statusPengajuanMOAToolStripMenuItem_Click;
            // 
            // pembagianTugasToolStripMenuItem
            // 
            pembagianTugasToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pembagianTugasToolStripMenuItem.Name = "pembagianTugasToolStripMenuItem";
            pembagianTugasToolStripMenuItem.Size = new Size(230, 38);
            pembagianTugasToolStripMenuItem.Text = "Pembagian Tugas";
            pembagianTugasToolStripMenuItem.Click += pembagianTugasToolStripMenuItem_Click;
            // 
            // konversiSKSToolStripMenuItem
            // 
            konversiSKSToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            konversiSKSToolStripMenuItem.Size = new Size(181, 38);
            konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            konversiSKSToolStripMenuItem.Click += konversiSKSToolStripMenuItem_Click;
            // 
            // konversiNilaiToolStripMenuItem
            // 
            konversiNilaiToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            konversiNilaiToolStripMenuItem.Size = new Size(182, 38);
            konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            konversiNilaiToolStripMenuItem.Click += konversiNilaiToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lihatProfilToolStripMenuItem, logoutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(89, 38);
            profilToolStripMenuItem.Text = "Profil";
            profilToolStripMenuItem.Click += profilToolStripMenuItem_Click;
            // 
            // lihatProfilToolStripMenuItem
            // 
            lihatProfilToolStripMenuItem.Name = "lihatProfilToolStripMenuItem";
            lihatProfilToolStripMenuItem.Size = new Size(302, 44);
            lihatProfilToolStripMenuItem.Text = "Informasi Akun";
            lihatProfilToolStripMenuItem.Click += lihatProfilToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(302, 44);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.96907F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.030928F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbl_statuspengajuanmoa, 0, 1);
            tableLayoutPanel1.Location = new Point(26, 96);
            tableLayoutPanel1.Margin = new Padding(6, 8, 6, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.84971F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.15029F));
            tableLayoutPanel1.Size = new Size(1465, 851);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(6, 0);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(286, 55);
            label1.TabIndex = 0;
            label1.Text = "Daftar Mitra";
            // 
            // tbl_statuspengajuanmoa
            // 
            tbl_statuspengajuanmoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbl_statuspengajuanmoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_statuspengajuanmoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_statuspengajuanmoa.Columns.AddRange(new DataGridViewColumn[] { clm_nama, clm_mitra, clm_deskripsi, clm_status });
            tbl_statuspengajuanmoa.Location = new Point(6, 108);
            tbl_statuspengajuanmoa.Margin = new Padding(6, 8, 6, 8);
            tbl_statuspengajuanmoa.Name = "tbl_statuspengajuanmoa";
            tbl_statuspengajuanmoa.RowHeadersWidth = 62;
            tbl_statuspengajuanmoa.Size = new Size(1437, 735);
            tbl_statuspengajuanmoa.TabIndex = 1;
            tbl_statuspengajuanmoa.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clm_nama
            // 
            clm_nama.HeaderText = "Nama";
            clm_nama.MinimumWidth = 8;
            clm_nama.Name = "clm_nama";
            clm_nama.ReadOnly = true;
            // 
            // clm_mitra
            // 
            clm_mitra.HeaderText = "Mitra";
            clm_mitra.MinimumWidth = 8;
            clm_mitra.Name = "clm_mitra";
            clm_mitra.ReadOnly = true;
            // 
            // clm_deskripsi
            // 
            clm_deskripsi.HeaderText = "Deskripsi";
            clm_deskripsi.MinimumWidth = 8;
            clm_deskripsi.Name = "clm_deskripsi";
            clm_deskripsi.ReadOnly = true;
            // 
            // clm_status
            // 
            clm_status.HeaderText = "Status Pengajuan MOA";
            clm_status.MinimumWidth = 8;
            clm_status.Name = "clm_status";
            clm_status.ReadOnly = true;
            // 
            // btn_simpan
            // 
            btn_simpan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_simpan.BackColor = SystemColors.MenuHighlight;
            btn_simpan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(1258, 952);
            btn_simpan.Margin = new Padding(6, 8, 6, 8);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(211, 56);
            btn_simpan.TabIndex = 2;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // v_PengajuanMOA
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 1107);
            Controls.Add(btn_simpan);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 8, 6, 8);
            Name = "v_PengajuanMOA";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_statuspengajuanmoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem berandaToolStripMenuItem;
        private ToolStripMenuItem penerimaanMitraToolStripMenuItem;
        private ToolStripMenuItem pembagianTugasToolStripMenuItem;
        private ToolStripMenuItem konversiSKSToolStripMenuItem;
        private ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private DataGridView tbl_statuspengajuanmoa;
        private Button btn_simpan;
        private DataGridViewTextBoxColumn clm_nama;
        private DataGridViewTextBoxColumn clm_mitra;
        private DataGridViewTextBoxColumn clm_deskripsi;
        private DataGridViewComboBoxColumn clm_status;
        private ToolStripMenuItem daftarMitraToolStripMenuItem;
        private ToolStripMenuItem statusPengajuanMOAToolStripMenuItem;
        private ToolStripMenuItem lihatProfilToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}