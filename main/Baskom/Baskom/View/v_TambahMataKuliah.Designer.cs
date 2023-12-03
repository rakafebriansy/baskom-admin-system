namespace Baskom.View
{
    partial class v_TambahMataKuliah
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_TambahMataKuliah));
            lyt_mitra = new TableLayoutPanel();
            panel1 = new Panel();
            btn_tambah = new Button();
            cbx_matakuliah = new ComboBox();
            lbl_matakuliah = new Label();
            cbx_program = new ComboBox();
            lbl_program = new Label();
            cbx_namamitra = new ComboBox();
            lbl_namamitra = new Label();
            panel2 = new Panel();
            tbl_daftarprogrammitra = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            lbl_daftarprogrammitra = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel3 = new Panel();
            btn_tambahmatkul = new Button();
            tbx_jumlahsks = new TextBox();
            lbl_jumlahsks = new Label();
            tbx_namamatakuliah = new TextBox();
            tbx_kodematakuliah = new TextBox();
            lbl_namamatakuliah = new Label();
            lbl_kodematakuliah = new Label();
            panel4 = new Panel();
            tbl_daftarmatkul = new DataGridView();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            lbl_daftarmatkul = new Label();
            menuStrip2 = new MenuStrip();
            dashboardToolStripMenuItem1 = new ToolStripMenuItem();
            manajemenAkunToolStripMenuItem = new ToolStripMenuItem();
            akunToolStripMenuItem = new ToolStripMenuItem();
            akunMahasiswaToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            tambahMitraProgramToolStripMenuItem = new ToolStripMenuItem();
            tambahProgramMataKuliahToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lyt_mitra.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarprogrammitra).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarmatkul).BeginInit();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lyt_mitra
            // 
            lyt_mitra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lyt_mitra.ColumnCount = 2;
            lyt_mitra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt_mitra.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt_mitra.Controls.Add(panel1, 0, 0);
            lyt_mitra.Location = new Point(0, 0);
            lyt_mitra.Name = "lyt_mitra";
            lyt_mitra.RowCount = 1;
            lyt_mitra.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            lyt_mitra.Size = new Size(200, 100);
            lyt_mitra.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(btn_tambah);
            panel1.Controls.Add(cbx_matakuliah);
            panel1.Controls.Add(lbl_matakuliah);
            panel1.Controls.Add(cbx_program);
            panel1.Controls.Add(lbl_program);
            panel1.Controls.Add(cbx_namamitra);
            panel1.Controls.Add(lbl_namamitra);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(94, 94);
            panel1.TabIndex = 0;
            // 
            // btn_tambah
            // 
            btn_tambah.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_tambah.BackColor = SystemColors.MenuHighlight;
            btn_tambah.BackgroundImageLayout = ImageLayout.None;
            btn_tambah.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambah.ForeColor = Color.White;
            btn_tambah.Location = new Point(5, 404);
            btn_tambah.Name = "btn_tambah";
            btn_tambah.Size = new Size(105, 38);
            btn_tambah.TabIndex = 6;
            btn_tambah.Text = "Tambah";
            btn_tambah.UseVisualStyleBackColor = false;
            // 
            // cbx_matakuliah
            // 
            cbx_matakuliah.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbx_matakuliah.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_matakuliah.FormattingEnabled = true;
            cbx_matakuliah.Location = new Point(3, 250);
            cbx_matakuliah.Name = "cbx_matakuliah";
            cbx_matakuliah.Size = new Size(273, 26);
            cbx_matakuliah.TabIndex = 5;
            // 
            // lbl_matakuliah
            // 
            lbl_matakuliah.AutoSize = true;
            lbl_matakuliah.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_matakuliah.Location = new Point(5, 214);
            lbl_matakuliah.Name = "lbl_matakuliah";
            lbl_matakuliah.Size = new Size(108, 20);
            lbl_matakuliah.TabIndex = 4;
            lbl_matakuliah.Text = "Mata Kuliah";
            // 
            // cbx_program
            // 
            cbx_program.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            cbx_program.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_program.FormattingEnabled = true;
            cbx_program.Location = new Point(3, 143);
            cbx_program.Name = "cbx_program";
            cbx_program.Size = new Size(270, 26);
            cbx_program.TabIndex = 3;
            // 
            // lbl_program
            // 
            lbl_program.AutoSize = true;
            lbl_program.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_program.Location = new Point(3, 107);
            lbl_program.Name = "lbl_program";
            lbl_program.Size = new Size(80, 20);
            lbl_program.TabIndex = 2;
            lbl_program.Text = "Program";
            // 
            // cbx_namamitra
            // 
            cbx_namamitra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cbx_namamitra.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cbx_namamitra.FormattingEnabled = true;
            cbx_namamitra.Location = new Point(3, 44);
            cbx_namamitra.Name = "cbx_namamitra";
            cbx_namamitra.Size = new Size(270, 26);
            cbx_namamitra.TabIndex = 1;
            // 
            // lbl_namamitra
            // 
            lbl_namamitra.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_namamitra.AutoSize = true;
            lbl_namamitra.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_namamitra.Location = new Point(5, 5);
            lbl_namamitra.Name = "lbl_namamitra";
            lbl_namamitra.Size = new Size(106, 20);
            lbl_namamitra.TabIndex = 0;
            lbl_namamitra.Text = "Nama Mitra";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tbl_daftarprogrammitra);
            panel2.Controls.Add(lbl_daftarprogrammitra);
            panel2.Location = new Point(103, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(94, 453);
            panel2.TabIndex = 1;
            // 
            // tbl_daftarprogrammitra
            // 
            tbl_daftarprogrammitra.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbl_daftarprogrammitra.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_daftarprogrammitra.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_daftarprogrammitra.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            tbl_daftarprogrammitra.Location = new Point(4, 45);
            tbl_daftarprogrammitra.Name = "tbl_daftarprogrammitra";
            tbl_daftarprogrammitra.RowHeadersWidth = 62;
            tbl_daftarprogrammitra.RowTemplate.Height = 25;
            tbl_daftarprogrammitra.Size = new Size(270, 756);
            tbl_daftarprogrammitra.TabIndex = 1;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama Mitra";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Program";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Mata Kuliah";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // lbl_daftarprogrammitra
            // 
            lbl_daftarprogrammitra.AutoSize = true;
            lbl_daftarprogrammitra.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_daftarprogrammitra.Location = new Point(3, 3);
            lbl_daftarprogrammitra.Name = "lbl_daftarprogrammitra";
            lbl_daftarprogrammitra.Size = new Size(188, 20);
            lbl_daftarprogrammitra.TabIndex = 0;
            lbl_daftarprogrammitra.Text = "Daftar Program Mitra";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel4, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 79);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(856, 540);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.Controls.Add(btn_tambahmatkul);
            panel3.Controls.Add(tbx_jumlahsks);
            panel3.Controls.Add(lbl_jumlahsks);
            panel3.Controls.Add(tbx_namamatakuliah);
            panel3.Controls.Add(tbx_kodematakuliah);
            panel3.Controls.Add(lbl_namamatakuliah);
            panel3.Controls.Add(lbl_kodematakuliah);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(422, 425);
            panel3.TabIndex = 0;
            panel3.Paint += panel3_Paint;
            // 
            // btn_tambahmatkul
            // 
            btn_tambahmatkul.BackColor = SystemColors.MenuHighlight;
            btn_tambahmatkul.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambahmatkul.ForeColor = Color.White;
            btn_tambahmatkul.Location = new Point(0, 306);
            btn_tambahmatkul.Name = "btn_tambahmatkul";
            btn_tambahmatkul.Size = new Size(112, 34);
            btn_tambahmatkul.TabIndex = 16;
            btn_tambahmatkul.Text = "Tambah";
            btn_tambahmatkul.UseVisualStyleBackColor = false;
            btn_tambahmatkul.Click += btn_tambahmatkul_Click;
            // 
            // tbx_jumlahsks
            // 
            tbx_jumlahsks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_jumlahsks.Location = new Point(5, 231);
            tbx_jumlahsks.Name = "tbx_jumlahsks";
            tbx_jumlahsks.Size = new Size(414, 24);
            tbx_jumlahsks.TabIndex = 15;
            // 
            // lbl_jumlahsks
            // 
            lbl_jumlahsks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_jumlahsks.AutoSize = true;
            lbl_jumlahsks.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_jumlahsks.Location = new Point(5, 192);
            lbl_jumlahsks.Name = "lbl_jumlahsks";
            lbl_jumlahsks.Size = new Size(111, 20);
            lbl_jumlahsks.TabIndex = 14;
            lbl_jumlahsks.Text = "Jumlah SKS";
            // 
            // tbx_namamatakuliah
            // 
            tbx_namamatakuliah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_namamatakuliah.Location = new Point(5, 136);
            tbx_namamatakuliah.Name = "tbx_namamatakuliah";
            tbx_namamatakuliah.Size = new Size(414, 24);
            tbx_namamatakuliah.TabIndex = 13;
            // 
            // tbx_kodematakuliah
            // 
            tbx_kodematakuliah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbx_kodematakuliah.Location = new Point(5, 45);
            tbx_kodematakuliah.Name = "tbx_kodematakuliah";
            tbx_kodematakuliah.Size = new Size(414, 24);
            tbx_kodematakuliah.TabIndex = 12;
            // 
            // lbl_namamatakuliah
            // 
            lbl_namamatakuliah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_namamatakuliah.AutoSize = true;
            lbl_namamatakuliah.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_namamatakuliah.Location = new Point(5, 97);
            lbl_namamatakuliah.Name = "lbl_namamatakuliah";
            lbl_namamatakuliah.Size = new Size(162, 20);
            lbl_namamatakuliah.TabIndex = 9;
            lbl_namamatakuliah.Text = "Nama Mata Kuliah";
            // 
            // lbl_kodematakuliah
            // 
            lbl_kodematakuliah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_kodematakuliah.AutoSize = true;
            lbl_kodematakuliah.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_kodematakuliah.Location = new Point(5, 5);
            lbl_kodematakuliah.Name = "lbl_kodematakuliah";
            lbl_kodematakuliah.Size = new Size(156, 20);
            lbl_kodematakuliah.TabIndex = 7;
            lbl_kodematakuliah.Text = "Kode Mata Kuliah";
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel4.Controls.Add(tbl_daftarmatkul);
            panel4.Controls.Add(lbl_daftarmatkul);
            panel4.Location = new Point(431, 3);
            panel4.Name = "panel4";
            panel4.Size = new Size(422, 534);
            panel4.TabIndex = 1;
            // 
            // tbl_daftarmatkul
            // 
            tbl_daftarmatkul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbl_daftarmatkul.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_daftarmatkul.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_daftarmatkul.Columns.AddRange(new DataGridViewColumn[] { Column4, Column5, Column6 });
            tbl_daftarmatkul.Location = new Point(3, 44);
            tbl_daftarmatkul.Name = "tbl_daftarmatkul";
            tbl_daftarmatkul.RowHeadersWidth = 62;
            tbl_daftarmatkul.RowTemplate.Height = 33;
            tbl_daftarmatkul.Size = new Size(416, 487);
            tbl_daftarmatkul.TabIndex = 1;
            tbl_daftarmatkul.CellContentClick += tbl_daftarmatkul_CellContentClick;
            // 
            // Column4
            // 
            Column4.HeaderText = "Kode Mata Kuliah";
            Column4.MinimumWidth = 8;
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Nama Mata Kuliah";
            Column5.MinimumWidth = 8;
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Jumlah SKS";
            Column6.MinimumWidth = 8;
            Column6.Name = "Column6";
            // 
            // lbl_daftarmatkul
            // 
            lbl_daftarmatkul.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_daftarmatkul.AutoSize = true;
            lbl_daftarmatkul.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_daftarmatkul.Location = new Point(3, 5);
            lbl_daftarmatkul.Name = "lbl_daftarmatkul";
            lbl_daftarmatkul.Size = new Size(167, 20);
            lbl_daftarmatkul.TabIndex = 0;
            lbl_daftarmatkul.Text = "Daftar Mata Kuliah";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(24, 24);
            menuStrip2.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem1, manajemenAkunToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, profilToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(880, 26);
            menuStrip2.TabIndex = 9;
            menuStrip2.Text = "menuStrip2";
            // 
            // dashboardToolStripMenuItem1
            // 
            dashboardToolStripMenuItem1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            dashboardToolStripMenuItem1.Size = new Size(95, 22);
            dashboardToolStripMenuItem1.Text = "Dashboard";
            dashboardToolStripMenuItem1.Click += dashboardToolStripMenuItem1_Click;
            // 
            // manajemenAkunToolStripMenuItem
            // 
            manajemenAkunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { akunToolStripMenuItem, akunMahasiswaToolStripMenuItem });
            manajemenAkunToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            manajemenAkunToolStripMenuItem.Name = "manajemenAkunToolStripMenuItem";
            manajemenAkunToolStripMenuItem.Size = new Size(136, 22);
            manajemenAkunToolStripMenuItem.Text = "Manajemen Akun";
            // 
            // akunToolStripMenuItem
            // 
            akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            akunToolStripMenuItem.Size = new Size(202, 26);
            akunToolStripMenuItem.Text = "Akun Dosen";
            akunToolStripMenuItem.Click += akunToolStripMenuItem_Click;
            // 
            // akunMahasiswaToolStripMenuItem
            // 
            akunMahasiswaToolStripMenuItem.Name = "akunMahasiswaToolStripMenuItem";
            akunMahasiswaToolStripMenuItem.Size = new Size(202, 26);
            akunMahasiswaToolStripMenuItem.Text = "Akun Mahasiswa";
            akunMahasiswaToolStripMenuItem.Click += akunMahasiswaToolStripMenuItem_Click;
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tambahMitraProgramToolStripMenuItem, tambahProgramMataKuliahToolStripMenuItem });
            mitraToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(55, 22);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click_1;
            // 
            // tambahMitraProgramToolStripMenuItem
            // 
            tambahMitraProgramToolStripMenuItem.Name = "tambahMitraProgramToolStripMenuItem";
            tambahMitraProgramToolStripMenuItem.Size = new Size(287, 26);
            tambahMitraProgramToolStripMenuItem.Text = "Tambah Mitra Program";
            tambahMitraProgramToolStripMenuItem.Click += tambahMitraProgramToolStripMenuItem_Click;
            // 
            // tambahProgramMataKuliahToolStripMenuItem
            // 
            tambahProgramMataKuliahToolStripMenuItem.Name = "tambahProgramMataKuliahToolStripMenuItem";
            tambahProgramMataKuliahToolStripMenuItem.Size = new Size(287, 26);
            tambahProgramMataKuliahToolStripMenuItem.Text = "Tambah Program Mata Kuliah";
            tambahProgramMataKuliahToolStripMenuItem.Click += tambahProgramMataKuliahToolStripMenuItem_Click;
            // 
            // mataKuliahToolStripMenuItem
            // 
            mataKuliahToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(99, 22);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            mataKuliahToolStripMenuItem.Click += mataKuliahToolStripMenuItem_Click;
            // 
            // profilToolStripMenuItem
            // 
            profilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logOutToolStripMenuItem });
            profilToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            profilToolStripMenuItem.Size = new Size(56, 22);
            profilToolStripMenuItem.Text = "Profil";
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(188, 26);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click_1;
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripSeparator1 });
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(188, 26);
            logOutToolStripMenuItem.Text = "Log Out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click_1;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(71, 6);
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-21, 579);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(188, 529);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 31;
            pictureBox5.TabStop = false;
            // 
            // v_TambahMataKuliah
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 755);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(menuStrip2);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_TambahMataKuliah";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            lyt_mitra.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarprogrammitra).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftarmatkul).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel lyt_mitra;
        private Panel panel1;
        private Button btn_tambah;
        private ComboBox cbx_matakuliah;
        private Label lbl_matakuliah;
        private ComboBox cbx_program;
        private Label lbl_program;
        private ComboBox cbx_namamitra;
        private Label lbl_namamitra;
        private Panel panel2;
        private DataGridView tbl_daftarprogrammitra;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private Label lbl_daftarprogrammitra;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel3;
        private Panel panel4;
        private Label lbl_namamatakuliah;
        private Label lbl_kodematakuliah;
        private Label lbl_daftarmatkul;
        private DataGridView tbl_daftarmatkul;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem dashboardToolStripMenuItem1;
        private ToolStripMenuItem manajemenAkunToolStripMenuItem;
        private ToolStripMenuItem akunToolStripMenuItem;
        private ToolStripMenuItem akunMahasiswaToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private TextBox tbx_kodematakuliah;
        private TextBox tbx_namamatakuliah;
        private ToolStripMenuItem tambahMitraProgramToolStripMenuItem;
        private ToolStripMenuItem tambahProgramMataKuliahToolStripMenuItem;
        private TextBox tbx_jumlahsks;
        private Label lbl_jumlahsks;
        private Button btn_tambahmatkul;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ToolStripSeparator toolStripSeparator1;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}