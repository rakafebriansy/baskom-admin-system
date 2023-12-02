namespace Baskom.View
{
    partial class v_ProfilMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_ProfilMahasiswa));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            pengajuanMitraToolStripMenuItem = new ToolStripMenuItem();
            statusMitraToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            konversiSKSToolStripMenuItem = new ToolStripMenuItem();
            konversiNilaiToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            lbl_status = new Label();
            label16 = new Label();
            lbl_email = new Label();
            label14 = new Label();
            lbl_thnmasuk = new Label();
            label12 = new Label();
            lbl_nowa = new Label();
            lbl_batch = new Label();
            lbl_prodi = new Label();
            lbl_nimmahasiswa = new Label();
            lbl_namamahasiswa = new Label();
            lnk_ubahsandi = new LinkLabel();
            label10 = new Label();
            label8 = new Label();
            label6 = new Label();
            label2 = new Label();
            label4 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Control;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, konversiSKSToolStripMenuItem, konversiNilaiToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(1334, 34);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(114, 28);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pengajuanMitraToolStripMenuItem, statusMitraToolStripMenuItem });
            mitraToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(65, 28);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click;
            // 
            // pengajuanMitraToolStripMenuItem
            // 
            pengajuanMitraToolStripMenuItem.Name = "pengajuanMitraToolStripMenuItem";
            pengajuanMitraToolStripMenuItem.Size = new Size(270, 34);
            pengajuanMitraToolStripMenuItem.Text = "Penerimaan Mitra";
            pengajuanMitraToolStripMenuItem.Click += pengajuanMitraToolStripMenuItem_Click_1;
            // 
            // statusMitraToolStripMenuItem
            // 
            statusMitraToolStripMenuItem.Name = "statusMitraToolStripMenuItem";
            statusMitraToolStripMenuItem.Size = new Size(270, 34);
            statusMitraToolStripMenuItem.Text = "Pengajuan MOA";
            statusMitraToolStripMenuItem.Click += statusMitraToolStripMenuItem_Click;
            // 
            // mataKuliahToolStripMenuItem
            // 
            mataKuliahToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(120, 28);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            mataKuliahToolStripMenuItem.Click += mataKuliahToolStripMenuItem_Click;
            // 
            // konversiSKSToolStripMenuItem
            // 
            konversiSKSToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiSKSToolStripMenuItem.Name = "konversiSKSToolStripMenuItem";
            konversiSKSToolStripMenuItem.Size = new Size(137, 28);
            konversiSKSToolStripMenuItem.Text = "Konversi SKS";
            konversiSKSToolStripMenuItem.Click += konversiSKSToolStripMenuItem_Click;
            // 
            // konversiNilaiToolStripMenuItem
            // 
            konversiNilaiToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            konversiNilaiToolStripMenuItem.Name = "konversiNilaiToolStripMenuItem";
            konversiNilaiToolStripMenuItem.Size = new Size(136, 28);
            konversiNilaiToolStripMenuItem.Text = "Konversi Nilai";
            konversiNilaiToolStripMenuItem.Click += konversiNilaiToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logOutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(67, 28);
            profilToolStripMenuItem.Text = "Profil";
            profilToolStripMenuItem.Click += profilToolStripMenuItem_Click;
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(228, 34);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(228, 34);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(20, 141);
            tableLayoutPanel1.Margin = new Padding(5, 6, 5, 6);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1291, 714);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lbl_status);
            panel1.Controls.Add(label16);
            panel1.Controls.Add(lbl_email);
            panel1.Controls.Add(label14);
            panel1.Controls.Add(lbl_thnmasuk);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(lbl_nowa);
            panel1.Controls.Add(lbl_batch);
            panel1.Controls.Add(lbl_prodi);
            panel1.Controls.Add(lbl_nimmahasiswa);
            panel1.Controls.Add(lbl_namamahasiswa);
            panel1.Controls.Add(lnk_ubahsandi);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(5, 6);
            panel1.Margin = new Padding(5, 6, 5, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 702);
            panel1.TabIndex = 0;
            // 
            // lbl_status
            // 
            lbl_status.AutoSize = true;
            lbl_status.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_status.Location = new Point(94, 392);
            lbl_status.Margin = new Padding(5, 0, 5, 0);
            lbl_status.Name = "lbl_status";
            lbl_status.Size = new Size(45, 22);
            lbl_status.TabIndex = 31;
            lbl_status.Text = "Aktif";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label16.Location = new Point(94, 353);
            label16.Margin = new Padding(5, 0, 5, 0);
            label16.Name = "label16";
            label16.Size = new Size(217, 25);
            label16.TabIndex = 30;
            label16.Text = "Status Mahasiswa :";
            // 
            // lbl_email
            // 
            lbl_email.AutoSize = true;
            lbl_email.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_email.Location = new Point(94, 625);
            lbl_email.Margin = new Padding(5, 0, 5, 0);
            lbl_email.Name = "lbl_email";
            lbl_email.Size = new Size(232, 22);
            lbl_email.TabIndex = 29;
            lbl_email.Text = "2224101010XX@gmail.com";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(94, 589);
            label14.Margin = new Padding(5, 0, 5, 0);
            label14.Name = "label14";
            label14.Size = new Size(84, 25);
            label14.TabIndex = 28;
            label14.Text = "Email :";
            // 
            // lbl_thnmasuk
            // 
            lbl_thnmasuk.AutoSize = true;
            lbl_thnmasuk.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_thnmasuk.Location = new Point(94, 311);
            lbl_thnmasuk.Margin = new Padding(5, 0, 5, 0);
            lbl_thnmasuk.Name = "lbl_thnmasuk";
            lbl_thnmasuk.Size = new Size(50, 22);
            lbl_thnmasuk.TabIndex = 27;
            lbl_thnmasuk.Text = "2022";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(94, 272);
            label12.Margin = new Padding(5, 0, 5, 0);
            label12.Name = "label12";
            label12.Size = new Size(168, 25);
            label12.TabIndex = 26;
            label12.Text = "Tahun Masuk :\r\n";
            // 
            // lbl_nowa
            // 
            lbl_nowa.AutoSize = true;
            lbl_nowa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nowa.Location = new Point(94, 469);
            lbl_nowa.Margin = new Padding(5, 0, 5, 0);
            lbl_nowa.Name = "lbl_nowa";
            lbl_nowa.Size = new Size(122, 22);
            lbl_nowa.TabIndex = 25;
            lbl_nowa.Text = "0812XXXXXX\r\n";
            // 
            // lbl_batch
            // 
            lbl_batch.AutoSize = true;
            lbl_batch.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_batch.Location = new Point(99, 552);
            lbl_batch.Margin = new Padding(5, 0, 5, 0);
            lbl_batch.Name = "lbl_batch";
            lbl_batch.Size = new Size(20, 22);
            lbl_batch.TabIndex = 24;
            lbl_batch.Text = "1";
            lbl_batch.Click += label9_Click;
            // 
            // lbl_prodi
            // 
            lbl_prodi.AutoSize = true;
            lbl_prodi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_prodi.Location = new Point(94, 222);
            lbl_prodi.Margin = new Padding(5, 0, 5, 0);
            lbl_prodi.Name = "lbl_prodi";
            lbl_prodi.Size = new Size(141, 22);
            lbl_prodi.TabIndex = 23;
            lbl_prodi.Text = "Sistem Informasi\r\n";
            // 
            // lbl_nimmahasiswa
            // 
            lbl_nimmahasiswa.AutoSize = true;
            lbl_nimmahasiswa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nimmahasiswa.Location = new Point(94, 133);
            lbl_nimmahasiswa.Margin = new Padding(5, 0, 5, 0);
            lbl_nimmahasiswa.Name = "lbl_nimmahasiswa";
            lbl_nimmahasiswa.Size = new Size(134, 22);
            lbl_nimmahasiswa.TabIndex = 22;
            lbl_nimmahasiswa.Text = "2224101010XX";
            // 
            // lbl_namamahasiswa
            // 
            lbl_namamahasiswa.AutoSize = true;
            lbl_namamahasiswa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_namamahasiswa.Location = new Point(94, 44);
            lbl_namamahasiswa.Margin = new Padding(5, 0, 5, 0);
            lbl_namamahasiswa.Name = "lbl_namamahasiswa";
            lbl_namamahasiswa.Size = new Size(154, 22);
            lbl_namamahasiswa.TabIndex = 21;
            lbl_namamahasiswa.Text = "Auryn Devi Sagita";
            // 
            // lnk_ubahsandi
            // 
            lnk_ubahsandi.AutoSize = true;
            lnk_ubahsandi.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            lnk_ubahsandi.Location = new Point(94, 666);
            lnk_ubahsandi.Margin = new Padding(5, 0, 5, 0);
            lnk_ubahsandi.Name = "lnk_ubahsandi";
            lnk_ubahsandi.Size = new Size(125, 20);
            lnk_ubahsandi.TabIndex = 20;
            lnk_ubahsandi.TabStop = true;
            lnk_ubahsandi.Text = "Ubah kata sandi";
            lnk_ubahsandi.LinkClicked += lnk_ubahsandi_LinkClicked;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(94, 431);
            label10.Margin = new Padding(5, 0, 5, 0);
            label10.Name = "label10";
            label10.Size = new Size(167, 25);
            label10.TabIndex = 9;
            label10.Text = "No Whatsapp :";
            label10.Click += label10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(94, 516);
            label8.Margin = new Padding(5, 0, 5, 0);
            label8.Name = "label8";
            label8.Size = new Size(86, 25);
            label8.TabIndex = 7;
            label8.Text = "Batch :";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(94, 181);
            label6.Margin = new Padding(5, 0, 5, 0);
            label6.Name = "label6";
            label6.Size = new Size(175, 25);
            label6.TabIndex = 5;
            label6.Text = "Program Studi :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 0);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 25);
            label2.TabIndex = 3;
            label2.Text = "Nama :";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 97);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 2;
            label4.Text = "NIM :";
            label4.Click += label4_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Left;
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(650, 133);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(585, 447);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 6);
            pictureBox1.Margin = new Padding(5, 6, 5, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(585, 434);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 64);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(202, 40);
            label1.TabIndex = 2;
            label1.Text = "Akun Anda";
            // 
            // v_ProfilMahasiswa
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 820);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 6, 5, 6);
            Name = "v_ProfilMahasiswa";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private ToolStripMenuItem konversiSKSToolStripMenuItem;
        private ToolStripMenuItem konversiNilaiToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label4;
        private Label label1;
        private Label label10;
        private Label label8;
        private Label label6;
        private Label label2;
        private Panel panel2;
        private PictureBox pictureBox1;
        private LinkLabel lnk_ubahsandi;
        private Label lbl_nimmahasiswa;
        private Label lbl_namamahasiswa;
        private Label lbl_nowa;
        private Label lbl_batch;
        private Label lbl_prodi;
        private Label label12;
        private Label lbl_thnmasuk;
        private Label lbl_email;
        private Label label14;
        private Label lbl_status;
        private Label label16;
        private ToolStripMenuItem pengajuanMitraToolStripMenuItem;
        private ToolStripMenuItem statusMitraToolStripMenuItem;
    }
}