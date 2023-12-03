namespace Baskom.View
{
    partial class v_DaftarMitra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DaftarMitra));
            menuStrip1 = new MenuStrip();
            berandaToolStripMenuItem = new ToolStripMenuItem();
            penerimaanMitraToolStripMenuItem = new ToolStripMenuItem();
            daftarMitraToolStripMenuItem = new ToolStripMenuItem();
            mitraBaruToolStripMenuItem = new ToolStripMenuItem();
            pembagianTugasToolStripMenuItem = new ToolStripMenuItem();
            konversiSKSToolStripMenuItem = new ToolStripMenuItem();
            konversiNilaiToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            tbl_daftarmitra = new DataGridView();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            clm_mitra = new DataGridViewTextBoxColumn();
            clm_deskmitra = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarmitra).BeginInit();
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
            menuStrip1.Size = new Size(1122, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
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
            penerimaanMitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { daftarMitraToolStripMenuItem, mitraBaruToolStripMenuItem });
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
            // mitraBaruToolStripMenuItem
            // 
            mitraBaruToolStripMenuItem.Name = "mitraBaruToolStripMenuItem";
            mitraBaruToolStripMenuItem.Size = new Size(178, 26);
            mitraBaruToolStripMenuItem.Text = "Validasi MOA";
            mitraBaruToolStripMenuItem.Click += mitraBaruToolStripMenuItem_Click;
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
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logOutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(56, 22);
            profilToolStripMenuItem.Text = "Profil";
            profilToolStripMenuItem.Click += profilToolStripMenuItem_Click;
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(188, 26);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(188, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 98.96907F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.030928F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(tbl_daftarmitra, 0, 1);
            tableLayoutPanel1.Location = new Point(16, 58);
            tableLayoutPanel1.Margin = new Padding(4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 90.25F));
            tableLayoutPanel1.Size = new Size(1092, 616);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(180, 36);
            label1.TabIndex = 0;
            label1.Text = "Daftar Mitra";
            // 
            // tbl_daftarmitra
            // 
            tbl_daftarmitra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbl_daftarmitra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_daftarmitra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_daftarmitra.Columns.AddRange(new DataGridViewColumn[] { clm_mitra, clm_deskmitra });
            tbl_daftarmitra.Location = new Point(4, 64);
            tbl_daftarmitra.Margin = new Padding(4);
            tbl_daftarmitra.Name = "tbl_daftarmitra";
            tbl_daftarmitra.RowHeadersWidth = 82;
            tbl_daftarmitra.Size = new Size(1072, 546);
            tbl_daftarmitra.TabIndex = 1;
            tbl_daftarmitra.CellContentClick += tbl_daftarmitra_CellContentClick;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-15, 715);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(490, 838);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1012, 694);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 133);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            // 
            // clm_mitra
            // 
            clm_mitra.HeaderText = "Nama Mitra";
            clm_mitra.MinimumWidth = 10;
            clm_mitra.Name = "clm_mitra";
            clm_mitra.ReadOnly = true;
            // 
            // clm_deskmitra
            // 
            clm_deskmitra.HeaderText = "Deskripsi";
            clm_deskmitra.MinimumWidth = 10;
            clm_deskmitra.Name = "clm_deskmitra";
            clm_deskmitra.ReadOnly = true;
            // 
            // v_DaftarMitra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1122, 871);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4);
            Name = "v_DaftarMitra";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarmitra).EndInit();
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
        private DataGridView tbl_daftarmitra;
        private ToolStripMenuItem daftarMitraToolStripMenuItem;
        private ToolStripMenuItem mitraBaruToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private DataGridViewTextBoxColumn clm_mitra;
        private DataGridViewTextBoxColumn clm_deskmitra;
    }
}