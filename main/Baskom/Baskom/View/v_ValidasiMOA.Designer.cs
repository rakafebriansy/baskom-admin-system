namespace Baskom.View
{
    partial class v_ValidasiMOA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_ValidasiMOA));
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
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_statuspengajuanmoa).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { berandaToolStripMenuItem, penerimaanMitraToolStripMenuItem, pembagianTugasToolStripMenuItem, konversiSKSToolStripMenuItem, konversiNilaiToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(934, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // berandaToolStripMenuItem
            // 
            berandaToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            berandaToolStripMenuItem.Name = "berandaToolStripMenuItem";
            berandaToolStripMenuItem.Size = new Size(95, 22);
            berandaToolStripMenuItem.Text = "Dashboard";
            berandaToolStripMenuItem.Click += berandaToolStripMenuItem_Click;
            // 
            // penerimaanMitraToolStripMenuItem
            // 
            penerimaanMitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { daftarMitraToolStripMenuItem, statusPengajuanMOAToolStripMenuItem });
            penerimaanMitraToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            penerimaanMitraToolStripMenuItem.Name = "penerimaanMitraToolStripMenuItem";
            penerimaanMitraToolStripMenuItem.Size = new Size(138, 22);
            penerimaanMitraToolStripMenuItem.Text = "Penerimaan Mitra";
            penerimaanMitraToolStripMenuItem.Click += penerimaanMitraToolStripMenuItem_Click;
            // 
            // daftarMitraToolStripMenuItem
            // 
            daftarMitraToolStripMenuItem.Name = "daftarMitraToolStripMenuItem";
            daftarMitraToolStripMenuItem.Size = new Size(178, 26);
            daftarMitraToolStripMenuItem.Text = "Daftar Mitra";
            daftarMitraToolStripMenuItem.Click += daftarMitraToolStripMenuItem_Click;
            // 
            // statusPengajuanMOAToolStripMenuItem
            // 
            statusPengajuanMOAToolStripMenuItem.Name = "statusPengajuanMOAToolStripMenuItem";
            statusPengajuanMOAToolStripMenuItem.Size = new Size(178, 26);
            statusPengajuanMOAToolStripMenuItem.Text = "Validasi MOA";
            statusPengajuanMOAToolStripMenuItem.Click += statusPengajuanMOAToolStripMenuItem_Click;
            // 
            // pembagianTugasToolStripMenuItem
            // 
            pembagianTugasToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            pembagianTugasToolStripMenuItem.Name = "pembagianTugasToolStripMenuItem";
            pembagianTugasToolStripMenuItem.Size = new Size(141, 22);
            pembagianTugasToolStripMenuItem.Text = "Pembagian Tugas";
            pembagianTugasToolStripMenuItem.Click += pembagianTugasToolStripMenuItem_Click;
            // 
            // konversiSKSToolStripMenuItem
            // 
            konversiSKSToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            konversiSKSToolStripMenuItem.Size = new Size(114, 22);
            konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            konversiSKSToolStripMenuItem.Click += konversiSKSToolStripMenuItem_Click;
            // 
            // konversiNilaiToolStripMenuItem
            // 
            konversiNilaiToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            konversiNilaiToolStripMenuItem.Size = new Size(112, 22);
            konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            konversiNilaiToolStripMenuItem.Click += konversiNilaiToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { lihatProfilToolStripMenuItem, logoutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(56, 22);
            profilToolStripMenuItem.Text = "Profil";
            profilToolStripMenuItem.Click += profilToolStripMenuItem_Click;
            // 
            // lihatProfilToolStripMenuItem
            // 
            lihatProfilToolStripMenuItem.Name = "lihatProfilToolStripMenuItem";
            lihatProfilToolStripMenuItem.Size = new Size(188, 26);
            lihatProfilToolStripMenuItem.Text = "Informasi Akun";
            lihatProfilToolStripMenuItem.Click += lihatProfilToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(188, 26);
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
            tableLayoutPanel1.Location = new Point(16, 60);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.84971F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.15029F));
            tableLayoutPanel1.Size = new Size(902, 532);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(341, 36);
            label1.TabIndex = 0;
            label1.Text = "Daftar Pengajuan Mitra";
            // 
            // tbl_statuspengajuanmoa
            // 
            tbl_statuspengajuanmoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbl_statuspengajuanmoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_statuspengajuanmoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_statuspengajuanmoa.Columns.AddRange(new DataGridViewColumn[] { clm_nama, clm_mitra, clm_deskripsi, clm_status });
            tbl_statuspengajuanmoa.Location = new Point(4, 68);
            tbl_statuspengajuanmoa.Margin = new Padding(4, 5, 4, 5);
            tbl_statuspengajuanmoa.Name = "tbl_statuspengajuanmoa";
            tbl_statuspengajuanmoa.RowHeadersWidth = 62;
            tbl_statuspengajuanmoa.Size = new Size(884, 459);
            tbl_statuspengajuanmoa.TabIndex = 1;
            tbl_statuspengajuanmoa.CellContentClick += dataGridView1_CellContentClick;
            // 
            // clm_nama
            // 
            clm_nama.HeaderText = "Nama Mahasiswa";
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
            clm_status.HeaderText = "Status";
            clm_status.MinimumWidth = 8;
            clm_status.Name = "clm_status";
            clm_status.Resizable = DataGridViewTriState.True;
            // 
            // btn_simpan
            // 
            btn_simpan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_simpan.BackColor = SystemColors.MenuHighlight;
            btn_simpan.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(774, 595);
            btn_simpan.Margin = new Padding(4, 5, 4, 5);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(130, 35);
            btn_simpan.TabIndex = 2;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-14, 553);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 10;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(397, 713);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 11;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(815, 603);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 133);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // v_ValidasiMOA
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 740);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btn_simpan);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "v_ValidasiMOA";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_statuspengajuanmoa).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private ToolStripMenuItem daftarMitraToolStripMenuItem;
        private ToolStripMenuItem statusPengajuanMOAToolStripMenuItem;
        private ToolStripMenuItem lihatProfilToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private DataGridViewTextBoxColumn clm_nama;
        private DataGridViewTextBoxColumn clm_mitra;
        private DataGridViewTextBoxColumn clm_deskripsi;
        private DataGridViewComboBoxColumn clm_status;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
    }
}