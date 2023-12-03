namespace Baskom.View
{
    partial class v_DetailValidasiKonversiNilai
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DetailValidasiKonversiNilai));
            menuStrip1 = new MenuStrip();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lbl_nama = new Label();
            lbl_nim = new Label();
            lbl_prodi = new Label();
            lbl_mitra = new Label();
            lbl_posisi = new Label();
            label2 = new Label();
            panel1 = new Panel();
            tbl_detailkonversinilai = new DataGridView();
            clm_Kompetensi = new DataGridViewTextBoxColumn();
            clm_nilai_capaian = new DataGridViewTextBoxColumn();
            clm_deskripsi_nilai = new DataGridViewTextBoxColumn();
            clm_buktilaporan = new DataGridViewLinkColumn();
            clm_validasi = new DataGridViewCheckBoxColumn();
            btn_simpan = new Button();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_detailkonversinilai).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(8, 3, 0, 3);
            menuStrip1.Size = new Size(706, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(28, 28);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.91496F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 81.08504F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(label5, 0, 4);
            tableLayoutPanel1.Controls.Add(lbl_nama, 1, 0);
            tableLayoutPanel1.Controls.Add(lbl_nim, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl_prodi, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl_mitra, 1, 3);
            tableLayoutPanel1.Controls.Add(lbl_posisi, 1, 4);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Location = new Point(19, 65);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 25F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 54F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Size = new Size(682, 153);
            tableLayoutPanel1.TabIndex = 2;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(52, 18);
            label1.TabIndex = 0;
            label1.Text = "Nama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(4, 48);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(116, 18);
            label3.TabIndex = 2;
            label3.Text = "Program Studi";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(4, 73);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 18);
            label4.TabIndex = 3;
            label4.Text = "Nama Mitra";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(4, 98);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(73, 18);
            label5.TabIndex = 4;
            label5.Text = "Program";
            label5.Click += label5_Click;
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nama.Location = new Point(133, 0);
            lbl_nama.Margin = new Padding(4, 0, 4, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(88, 18);
            lbl_nama.TabIndex = 5;
            lbl_nama.Text = "Auryn Devi";
            lbl_nama.Click += label6_Click;
            // 
            // lbl_nim
            // 
            lbl_nim.AutoSize = true;
            lbl_nim.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nim.Location = new Point(133, 24);
            lbl_nim.Margin = new Padding(4, 0, 4, 0);
            lbl_nim.Name = "lbl_nim";
            lbl_nim.Size = new Size(114, 18);
            lbl_nim.TabIndex = 6;
            lbl_nim.Text = "2224101010xx";
            lbl_nim.Click += lbl_nim_Click;
            // 
            // lbl_prodi
            // 
            lbl_prodi.AutoSize = true;
            lbl_prodi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_prodi.Location = new Point(133, 48);
            lbl_prodi.Margin = new Padding(4, 0, 4, 0);
            lbl_prodi.Name = "lbl_prodi";
            lbl_prodi.Size = new Size(135, 18);
            lbl_prodi.TabIndex = 7;
            lbl_prodi.Text = "Sistem Informasi";
            lbl_prodi.Click += lbl_prodi_Click;
            // 
            // lbl_mitra
            // 
            lbl_mitra.AutoSize = true;
            lbl_mitra.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_mitra.Location = new Point(133, 73);
            lbl_mitra.Margin = new Padding(4, 0, 4, 0);
            lbl_mitra.Name = "lbl_mitra";
            lbl_mitra.Size = new Size(158, 18);
            lbl_mitra.TabIndex = 8;
            lbl_mitra.Text = "Pt. Benakno Official";
            lbl_mitra.Click += lbl_mitra_Click;
            // 
            // lbl_posisi
            // 
            lbl_posisi.AutoSize = true;
            lbl_posisi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_posisi.Location = new Point(133, 98);
            lbl_posisi.Margin = new Padding(4, 0, 4, 0);
            lbl_posisi.Name = "lbl_posisi";
            lbl_posisi.Size = new Size(33, 18);
            lbl_posisi.TabIndex = 9;
            lbl_posisi.Text = "PM";
            lbl_posisi.Click += lbl_posisi_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(4, 24);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(38, 18);
            label2.TabIndex = 1;
            label2.Text = "NIM";
            label2.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(tbl_detailkonversinilai);
            panel1.Location = new Point(19, 217);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(682, 242);
            panel1.TabIndex = 3;
            panel1.Paint += panel1_Paint;
            // 
            // tbl_detailkonversinilai
            // 
            tbl_detailkonversinilai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbl_detailkonversinilai.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_detailkonversinilai.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            tbl_detailkonversinilai.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_detailkonversinilai.Columns.AddRange(new DataGridViewColumn[] { clm_Kompetensi, clm_nilai_capaian, clm_deskripsi_nilai, clm_buktilaporan, clm_validasi });
            tbl_detailkonversinilai.Location = new Point(3, 5);
            tbl_detailkonversinilai.Margin = new Padding(4, 5, 4, 5);
            tbl_detailkonversinilai.Name = "tbl_detailkonversinilai";
            tbl_detailkonversinilai.RowHeadersWidth = 62;
            tbl_detailkonversinilai.Size = new Size(677, 254);
            tbl_detailkonversinilai.TabIndex = 0;
            tbl_detailkonversinilai.CellContentClick += tbl_detailkonversinilai_CellContentClick;
            // 
            // clm_Kompetensi
            // 
            clm_Kompetensi.FillWeight = 79.27198F;
            clm_Kompetensi.HeaderText = "Kompetensi";
            clm_Kompetensi.MinimumWidth = 8;
            clm_Kompetensi.Name = "clm_Kompetensi";
            clm_Kompetensi.ReadOnly = true;
            // 
            // clm_nilai_capaian
            // 
            clm_nilai_capaian.FillWeight = 45.81083F;
            clm_nilai_capaian.HeaderText = "Deskripsi Kompetensi";
            clm_nilai_capaian.MinimumWidth = 8;
            clm_nilai_capaian.Name = "clm_nilai_capaian";
            clm_nilai_capaian.ReadOnly = true;
            // 
            // clm_deskripsi_nilai
            // 
            clm_deskripsi_nilai.FillWeight = 45.81083F;
            clm_deskripsi_nilai.HeaderText = "Nilai Capaian";
            clm_deskripsi_nilai.MinimumWidth = 8;
            clm_deskripsi_nilai.Name = "clm_deskripsi_nilai";
            clm_deskripsi_nilai.ReadOnly = true;
            // 
            // clm_buktilaporan
            // 
            clm_buktilaporan.FillWeight = 45.81083F;
            clm_buktilaporan.HeaderText = "Bukti Link Laporan";
            clm_buktilaporan.MinimumWidth = 8;
            clm_buktilaporan.Name = "clm_buktilaporan";
            clm_buktilaporan.Resizable = DataGridViewTriState.True;
            // 
            // clm_validasi
            // 
            clm_validasi.FillWeight = 43.57201F;
            clm_validasi.HeaderText = "Validasi";
            clm_validasi.MinimumWidth = 8;
            clm_validasi.Name = "clm_validasi";
            // 
            // btn_simpan
            // 
            btn_simpan.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_simpan.BackColor = SystemColors.MenuHighlight;
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(617, 465);
            btn_simpan.Margin = new Padding(4, 5, 4, 5);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(81, 29);
            btn_simpan.TabIndex = 4;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += button1_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-4, 354);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(544, 285);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 133);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 21;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(366, 469);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 20;
            pictureBox5.TabStop = false;
            // 
            // v_DetailValidasiKonversiNilai
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 495);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(btn_simpan);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "v_DetailValidasiKonversiNilai";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form2_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_detailkonversinilai).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private DataGridView tbl_detailkonversinilai;
        private Button btn_simpan;
        private Label lbl_prodi;
        private Label lbl_nama;
        private Label lbl_nim;
        private Label lbl_mitra;
        private Label lbl_posisi;
        private DataGridViewTextBoxColumn clm_Kompetensi;
        private DataGridViewTextBoxColumn clm_nilai_capaian;
        private DataGridViewTextBoxColumn clm_deskripsi_nilai;
        private DataGridViewLinkColumn clm_buktilaporan;
        private DataGridViewCheckBoxColumn clm_validasi;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
    }
}