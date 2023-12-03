namespace Baskom.View
{
    partial class v_MemvalidasiKonversiNilai
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_MemvalidasiKonversiNilai));
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_DftrMahasiswa = new Label();
            tbl_konversinilai1 = new DataGridView();
            newToolStripMenuItem = new ToolStripMenuItem();
            openToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            printToolStripMenuItem = new ToolStripMenuItem();
            printPreviewToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            undoToolStripMenuItem = new ToolStripMenuItem();
            redoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            cutToolStripMenuItem = new ToolStripMenuItem();
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            selectAllToolStripMenuItem = new ToolStripMenuItem();
            customizeToolStripMenuItem = new ToolStripMenuItem();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            contentsToolStripMenuItem = new ToolStripMenuItem();
            indexToolStripMenuItem = new ToolStripMenuItem();
            searchToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            penerimaanMitraToolStripMenuItem = new ToolStripMenuItem();
            daftarMitraToolStripMenuItem = new ToolStripMenuItem();
            statusPengajuanMOAToolStripMenuItem = new ToolStripMenuItem();
            pembagianTugasToolStripMenuItem = new ToolStripMenuItem();
            konversiSKSToolStripMenuItem = new ToolStripMenuItem();
            konversiNilaiToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            lihatProfilToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            clm_NamaMhs = new DataGridViewTextBoxColumn();
            clm_nim = new DataGridViewTextBoxColumn();
            clm_prodi = new DataGridViewTextBoxColumn();
            clm_mitra = new DataGridViewTextBoxColumn();
            clm_posisi = new DataGridViewTextBoxColumn();
            btn_detail = new DataGridViewButtonColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_konversinilai1).BeginInit();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.95288F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.04712F));
            tableLayoutPanel1.Controls.Add(lbl_DftrMahasiswa, 0, 0);
            tableLayoutPanel1.Controls.Add(tbl_konversinilai1, 0, 1);
            tableLayoutPanel1.Location = new Point(32, 72);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.219178F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.78082F));
            tableLayoutPanel1.Size = new Size(1018, 622);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // lbl_DftrMahasiswa
            // 
            lbl_DftrMahasiswa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_DftrMahasiswa.AutoSize = true;
            lbl_DftrMahasiswa.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_DftrMahasiswa.Location = new Point(4, 0);
            lbl_DftrMahasiswa.Margin = new Padding(4, 0, 4, 0);
            lbl_DftrMahasiswa.Name = "lbl_DftrMahasiswa";
            lbl_DftrMahasiswa.Size = new Size(999, 36);
            lbl_DftrMahasiswa.TabIndex = 0;
            lbl_DftrMahasiswa.Text = "Daftar Mahasiswa";
            lbl_DftrMahasiswa.Click += label1_Click;
            // 
            // tbl_konversinilai1
            // 
            tbl_konversinilai1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbl_konversinilai1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_konversinilai1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbl_konversinilai1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_konversinilai1.Columns.AddRange(new DataGridViewColumn[] { clm_NamaMhs, clm_nim, clm_prodi, clm_mitra, clm_posisi, btn_detail });
            tbl_konversinilai1.Location = new Point(4, 56);
            tbl_konversinilai1.Margin = new Padding(4, 5, 4, 5);
            tbl_konversinilai1.Name = "tbl_konversinilai1";
            tbl_konversinilai1.RowHeadersWidth = 62;
            tbl_konversinilai1.Size = new Size(999, 555);
            tbl_konversinilai1.TabIndex = 1;
            tbl_konversinilai1.CellContentClick += dataGridView1_CellContentClick_1;
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(32, 19);
            newToolStripMenuItem.Text = "&New";
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Image = (Image)resources.GetObject("openToolStripMenuItem.Image");
            openToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openToolStripMenuItem.Size = new Size(32, 19);
            openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            toolStripSeparator.Name = "toolStripSeparator";
            toolStripSeparator.Size = new Size(6, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Image = (Image)resources.GetObject("saveToolStripMenuItem.Image");
            saveToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveToolStripMenuItem.Size = new Size(32, 19);
            saveToolStripMenuItem.Text = "&Save";
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(32, 19);
            saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 6);
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.Image = (Image)resources.GetObject("printToolStripMenuItem.Image");
            printToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.P;
            printToolStripMenuItem.Size = new Size(32, 19);
            printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            printPreviewToolStripMenuItem.Image = (Image)resources.GetObject("printPreviewToolStripMenuItem.Image");
            printPreviewToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            printPreviewToolStripMenuItem.Size = new Size(32, 19);
            printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(32, 19);
            exitToolStripMenuItem.Text = "E&xit";
            // 
            // undoToolStripMenuItem
            // 
            undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            undoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Z;
            undoToolStripMenuItem.Size = new Size(32, 19);
            undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            redoToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.Y;
            redoToolStripMenuItem.Size = new Size(32, 19);
            redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 6);
            // 
            // cutToolStripMenuItem
            // 
            cutToolStripMenuItem.Image = (Image)resources.GetObject("cutToolStripMenuItem.Image");
            cutToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            cutToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.X;
            cutToolStripMenuItem.Size = new Size(32, 19);
            cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Image = (Image)resources.GetObject("copyToolStripMenuItem.Image");
            copyToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.C;
            copyToolStripMenuItem.Size = new Size(32, 19);
            copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Image = (Image)resources.GetObject("pasteToolStripMenuItem.Image");
            pasteToolStripMenuItem.ImageTransparentColor = Color.Magenta;
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.V;
            pasteToolStripMenuItem.Size = new Size(32, 19);
            pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            selectAllToolStripMenuItem.Size = new Size(32, 19);
            selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // customizeToolStripMenuItem
            // 
            customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            customizeToolStripMenuItem.Size = new Size(32, 19);
            customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(32, 19);
            optionsToolStripMenuItem.Text = "&Options";
            // 
            // contentsToolStripMenuItem
            // 
            contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            contentsToolStripMenuItem.Size = new Size(32, 19);
            contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            indexToolStripMenuItem.Size = new Size(32, 19);
            indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            searchToolStripMenuItem.Size = new Size(32, 19);
            searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(6, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(32, 19);
            aboutToolStripMenuItem.Text = "&About...";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, penerimaanMitraToolStripMenuItem, pembagianTugasToolStripMenuItem, konversiSKSToolStripMenuItem, konversiNilaiToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1066, 28);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(92, 22);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // penerimaanMitraToolStripMenuItem
            // 
            penerimaanMitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { daftarMitraToolStripMenuItem, statusPengajuanMOAToolStripMenuItem });
            penerimaanMitraToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            penerimaanMitraToolStripMenuItem.Name = "penerimaanMitraToolStripMenuItem";
            penerimaanMitraToolStripMenuItem.Size = new Size(138, 22);
            penerimaanMitraToolStripMenuItem.Text = "Penerimaan Mitra";
            // 
            // daftarMitraToolStripMenuItem
            // 
            daftarMitraToolStripMenuItem.Name = "daftarMitraToolStripMenuItem";
            daftarMitraToolStripMenuItem.Size = new Size(178, 26);
            daftarMitraToolStripMenuItem.Text = "Daftar Mitra";
            daftarMitraToolStripMenuItem.Click += daftarMitraToolStripMenuItem_Click_1;
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
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(956, 764);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(122, 114);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 22;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-13, 680);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 24;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(315, 702);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 25;
            pictureBox5.TabStop = false;
            // 
            // clm_NamaMhs
            // 
            clm_NamaMhs.HeaderText = "Nama";
            clm_NamaMhs.MinimumWidth = 8;
            clm_NamaMhs.Name = "clm_NamaMhs";
            clm_NamaMhs.ReadOnly = true;
            // 
            // clm_nim
            // 
            clm_nim.HeaderText = "NIM";
            clm_nim.MinimumWidth = 8;
            clm_nim.Name = "clm_nim";
            clm_nim.ReadOnly = true;
            // 
            // clm_prodi
            // 
            clm_prodi.HeaderText = "Program Studi";
            clm_prodi.MinimumWidth = 8;
            clm_prodi.Name = "clm_prodi";
            clm_prodi.ReadOnly = true;
            // 
            // clm_mitra
            // 
            clm_mitra.HeaderText = "Nama Mitra";
            clm_mitra.MinimumWidth = 8;
            clm_mitra.Name = "clm_mitra";
            clm_mitra.ReadOnly = true;
            // 
            // clm_posisi
            // 
            clm_posisi.HeaderText = "Program";
            clm_posisi.MinimumWidth = 8;
            clm_posisi.Name = "clm_posisi";
            clm_posisi.ReadOnly = true;
            // 
            // btn_detail
            // 
            btn_detail.HeaderText = "Detail";
            btn_detail.MinimumWidth = 8;
            btn_detail.Name = "btn_detail";
            btn_detail.Text = "Lihat";
            btn_detail.UseColumnTextForButtonValue = true;
            // 
            // v_MemvalidasiKonversiNilai
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 804);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "v_MemvalidasiKonversiNilai";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_konversinilai1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_DftrMahasiswa;
        private DataGridView tbl_konversinilai1;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem printToolStripMenuItem;
        private ToolStripMenuItem printPreviewToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem cutToolStripMenuItem;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem selectAllToolStripMenuItem;
        private ToolStripMenuItem customizeToolStripMenuItem;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem contentsToolStripMenuItem;
        private ToolStripMenuItem indexToolStripMenuItem;
        private ToolStripMenuItem searchToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem penerimaanMitraToolStripMenuItem;
        private ToolStripMenuItem daftarMitraToolStripMenuItem;
        private ToolStripMenuItem statusPengajuanMOAToolStripMenuItem;
        private ToolStripMenuItem pembagianTugasToolStripMenuItem;
        private ToolStripMenuItem konversiSKSToolStripMenuItem;
        private ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem lihatProfilToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private DataGridViewTextBoxColumn clm_NamaMhs;
        private DataGridViewTextBoxColumn clm_nim;
        private DataGridViewTextBoxColumn clm_prodi;
        private DataGridViewTextBoxColumn clm_mitra;
        private DataGridViewTextBoxColumn clm_posisi;
        private DataGridViewButtonColumn btn_detail;
    }
}

