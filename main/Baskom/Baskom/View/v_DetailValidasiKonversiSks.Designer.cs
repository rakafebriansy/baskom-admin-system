﻿namespace Baskom.View
{
    partial class v_DetailValidasiKonversiSks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DetailValidasiKonversiSks));
            tableLayoutPanel1 = new TableLayoutPanel();
            lbl_nama = new Label();
            lbl_NIM = new Label();
            lbl_Mitra = new Label();
            lbl_nimmahasiswa = new Label();
            lbl_namamitra = new Label();
            lbl_NamaOrang = new Label();
            panel1 = new Panel();
            dataGridView1 = new DataGridView();
            Kompetensi = new DataGridViewTextBoxColumn();
            TargetPengembangan = new DataGridViewTextBoxColumn();
            DetailPembelajaran = new DataGridViewTextBoxColumn();
            SKS = new DataGridViewTextBoxColumn();
            disetujui = new DataGridViewCheckBoxColumn();
            btn_simpan = new Button();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.56051F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 83.43949F));
            tableLayoutPanel1.Controls.Add(lbl_nama, 0, 0);
            tableLayoutPanel1.Controls.Add(lbl_NIM, 0, 1);
            tableLayoutPanel1.Controls.Add(lbl_Mitra, 0, 2);
            tableLayoutPanel1.Controls.Add(lbl_nimmahasiswa, 1, 1);
            tableLayoutPanel1.Controls.Add(lbl_namamitra, 1, 2);
            tableLayoutPanel1.Controls.Add(lbl_NamaOrang, 1, 0);
            tableLayoutPanel1.Location = new Point(40, 46);
            tableLayoutPanel1.Margin = new Padding(4, 5, 4, 5);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 49.12281F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50.87719F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(1069, 174);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lbl_nama
            // 
            lbl_nama.AutoSize = true;
            lbl_nama.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nama.Location = new Point(4, 0);
            lbl_nama.Margin = new Padding(4, 0, 4, 0);
            lbl_nama.Name = "lbl_nama";
            lbl_nama.Size = new Size(98, 31);
            lbl_nama.TabIndex = 0;
            lbl_nama.Text = "Nama ";
            // 
            // lbl_NIM
            // 
            lbl_NIM.AutoSize = true;
            lbl_NIM.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NIM.Location = new Point(4, 60);
            lbl_NIM.Margin = new Padding(4, 0, 4, 0);
            lbl_NIM.Name = "lbl_NIM";
            lbl_NIM.Size = new Size(67, 31);
            lbl_NIM.TabIndex = 1;
            lbl_NIM.Text = "NIM";
            // 
            // lbl_Mitra
            // 
            lbl_Mitra.AutoSize = true;
            lbl_Mitra.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Mitra.Location = new Point(4, 123);
            lbl_Mitra.Margin = new Padding(4, 0, 4, 0);
            lbl_Mitra.Name = "lbl_Mitra";
            lbl_Mitra.Size = new Size(79, 31);
            lbl_Mitra.TabIndex = 2;
            lbl_Mitra.Text = "Mitra";
            // 
            // lbl_nimmahasiswa
            // 
            lbl_nimmahasiswa.AutoSize = true;
            lbl_nimmahasiswa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_nimmahasiswa.Location = new Point(181, 60);
            lbl_nimmahasiswa.Margin = new Padding(4, 0, 4, 0);
            lbl_nimmahasiswa.Name = "lbl_nimmahasiswa";
            lbl_nimmahasiswa.Size = new Size(169, 29);
            lbl_nimmahasiswa.TabIndex = 4;
            lbl_nimmahasiswa.Text = "222410101086";
            // 
            // lbl_namamitra
            // 
            lbl_namamitra.AutoSize = true;
            lbl_namamitra.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_namamitra.Location = new Point(181, 123);
            lbl_namamitra.Margin = new Padding(4, 0, 4, 0);
            lbl_namamitra.Name = "lbl_namamitra";
            lbl_namamitra.Size = new Size(152, 29);
            lbl_namamitra.TabIndex = 5;
            lbl_namamitra.Text = "PT. Benakno";
            // 
            // lbl_NamaOrang
            // 
            lbl_NamaOrang.AutoSize = true;
            lbl_NamaOrang.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_NamaOrang.Location = new Point(181, 0);
            lbl_NamaOrang.Margin = new Padding(4, 0, 4, 0);
            lbl_NamaOrang.Name = "lbl_NamaOrang";
            lbl_NamaOrang.Size = new Size(201, 29);
            lbl_NamaOrang.TabIndex = 3;
            lbl_NamaOrang.Text = "Auryn Devi Sagita";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(3, 307);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1149, 319);
            panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Kompetensi, TargetPengembangan, DetailPembelajaran, SKS, disetujui });
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Margin = new Padding(4, 5, 4, 5);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 28;
            dataGridView1.Size = new Size(1145, 314);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Kompetensi
            // 
            Kompetensi.HeaderText = "Kompetensi";
            Kompetensi.MinimumWidth = 8;
            Kompetensi.Name = "Kompetensi";
            // 
            // TargetPengembangan
            // 
            TargetPengembangan.HeaderText = "Deskripsi Kompetensi";
            TargetPengembangan.MinimumWidth = 8;
            TargetPengembangan.Name = "TargetPengembangan";
            // 
            // DetailPembelajaran
            // 
            DetailPembelajaran.HeaderText = "Mata Kuliah";
            DetailPembelajaran.MinimumWidth = 8;
            DetailPembelajaran.Name = "DetailPembelajaran";
            // 
            // SKS
            // 
            SKS.HeaderText = "SKS";
            SKS.MinimumWidth = 8;
            SKS.Name = "SKS";
            SKS.ReadOnly = true;
            // 
            // disetujui
            // 
            disetujui.HeaderText = "Disetujui";
            disetujui.MinimumWidth = 8;
            disetujui.Name = "disetujui";
            // 
            // btn_simpan
            // 
            btn_simpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_simpan.BackColor = SystemColors.MenuHighlight;
            btn_simpan.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(996, 635);
            btn_simpan.Margin = new Padding(4, 5, 4, 5);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(143, 65);
            btn_simpan.TabIndex = 2;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += btn_simpan_Click;
            // 
            // v_DetailValidasiKonversiSks
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 719);
            Controls.Add(btn_simpan);
            Controls.Add(panel1);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "v_DetailValidasiKonversiSks";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lbl_nama;
        private Label lbl_NIM;
        private Label lbl_Mitra;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Button btn_simpan;
        private Label lbl_NamaOrang;
        private Label lbl_nimmahasiswa;
        private Label lbl_namamitra;
        private DataGridViewTextBoxColumn Kompetensi;
        private DataGridViewTextBoxColumn TargetPengembangan;
        private DataGridViewTextBoxColumn DetailPembelajaran;
        private DataGridViewTextBoxColumn SKS;
        private DataGridViewCheckBoxColumn disetujui;
    }
}