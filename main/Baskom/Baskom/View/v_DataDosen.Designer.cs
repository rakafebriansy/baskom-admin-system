namespace Baskom.View
{
    partial class v_DataDosen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DataDosen));
            panel1 = new Panel();
            msp_navadmindosen = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            managemenAkunToolStripMenuItem = new ToolStripMenuItem();
            akunDosenToolStripMenuItem = new ToolStripMenuItem();
            akunToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            tambahMitraProgramToolStripMenuItem = new ToolStripMenuItem();
            tambahProgramMataKuliahToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            profileToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            tbl_daftardosenadmin = new DataGridView();
            panel3 = new Panel();
            btn_tambahdaftardosenadmin = new Button();
            label1 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            pictureBox1 = new PictureBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewButtonColumn();
            panel1.SuspendLayout();
            msp_navadmindosen.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_daftardosenadmin).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(msp_navadmindosen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1158, 33);
            panel1.TabIndex = 0;
            // 
            // msp_navadmindosen
            // 
            msp_navadmindosen.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            msp_navadmindosen.ImageScalingSize = new Size(20, 20);
            msp_navadmindosen.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, managemenAkunToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, profileToolStripMenuItem });
            msp_navadmindosen.Location = new Point(0, 0);
            msp_navadmindosen.Name = "msp_navadmindosen";
            msp_navadmindosen.Padding = new Padding(0);
            msp_navadmindosen.Size = new Size(1158, 24);
            msp_navadmindosen.TabIndex = 0;
            msp_navadmindosen.Text = "menuStrip1";
            msp_navadmindosen.ItemClicked += menuStrip1_ItemClicked_1;
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(95, 24);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // managemenAkunToolStripMenuItem
            // 
            managemenAkunToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { akunDosenToolStripMenuItem, akunToolStripMenuItem });
            managemenAkunToolStripMenuItem.Name = "managemenAkunToolStripMenuItem";
            managemenAkunToolStripMenuItem.Size = new Size(141, 24);
            managemenAkunToolStripMenuItem.Text = "Managemen Akun";
            // 
            // akunDosenToolStripMenuItem
            // 
            akunDosenToolStripMenuItem.Name = "akunDosenToolStripMenuItem";
            akunDosenToolStripMenuItem.Size = new Size(202, 26);
            akunDosenToolStripMenuItem.Text = "Akun Dosen";
            akunDosenToolStripMenuItem.Click += akunDosenToolStripMenuItem_Click;
            // 
            // akunToolStripMenuItem
            // 
            akunToolStripMenuItem.Name = "akunToolStripMenuItem";
            akunToolStripMenuItem.Size = new Size(202, 26);
            akunToolStripMenuItem.Text = "Akun Mahasiswa";
            akunToolStripMenuItem.Click += akunToolStripMenuItem_Click;
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { tambahMitraProgramToolStripMenuItem, tambahProgramMataKuliahToolStripMenuItem });
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(55, 24);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click;
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
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(99, 24);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            mataKuliahToolStripMenuItem.Click += mataKuliahToolStripMenuItem_Click;
            // 
            // profileToolStripMenuItem
            // 
            profileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { informasiAkunToolStripMenuItem, logoutToolStripMenuItem });
            profileToolStripMenuItem.Name = "profileToolStripMenuItem";
            profileToolStripMenuItem.Size = new Size(64, 24);
            profileToolStripMenuItem.Text = "Profile";
            profileToolStripMenuItem.Click += profileToolStripMenuItem_Click;
            // 
            // informasiAkunToolStripMenuItem
            // 
            informasiAkunToolStripMenuItem.Name = "informasiAkunToolStripMenuItem";
            informasiAkunToolStripMenuItem.Size = new Size(188, 26);
            informasiAkunToolStripMenuItem.Text = "Informasi Akun";
            informasiAkunToolStripMenuItem.Click += informasiAkunToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(188, 26);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(tbl_daftardosenadmin);
            panel2.Location = new Point(24, 193);
            panel2.Name = "panel2";
            panel2.Size = new Size(1110, 292);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // tbl_daftardosenadmin
            // 
            tbl_daftardosenadmin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbl_daftardosenadmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_daftardosenadmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_daftardosenadmin.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            tbl_daftardosenadmin.Location = new Point(3, 3);
            tbl_daftardosenadmin.Name = "tbl_daftardosenadmin";
            tbl_daftardosenadmin.RowHeadersWidth = 51;
            tbl_daftardosenadmin.RowTemplate.Height = 29;
            tbl_daftardosenadmin.Size = new Size(1104, 285);
            tbl_daftardosenadmin.TabIndex = 0;
            tbl_daftardosenadmin.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            panel3.Controls.Add(btn_tambahdaftardosenadmin);
            panel3.Location = new Point(970, 512);
            panel3.Name = "panel3";
            panel3.Size = new Size(163, 35);
            panel3.TabIndex = 3;
            // 
            // btn_tambahdaftardosenadmin
            // 
            btn_tambahdaftardosenadmin.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_tambahdaftardosenadmin.BackColor = SystemColors.Highlight;
            btn_tambahdaftardosenadmin.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambahdaftardosenadmin.ForeColor = SystemColors.ControlLightLight;
            btn_tambahdaftardosenadmin.Location = new Point(0, 0);
            btn_tambahdaftardosenadmin.Name = "btn_tambahdaftardosenadmin";
            btn_tambahdaftardosenadmin.Size = new Size(160, 35);
            btn_tambahdaftardosenadmin.TabIndex = 0;
            btn_tambahdaftardosenadmin.Text = "Tambah";
            btn_tambahdaftardosenadmin.UseVisualStyleBackColor = false;
            btn_tambahdaftardosenadmin.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 2);
            label1.Name = "label1";
            label1.Size = new Size(164, 29);
            label1.TabIndex = 0;
            label1.Text = "Daftar Dosen";
            label1.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Location = new Point(24, 111);
            panel4.Name = "panel4";
            panel4.Size = new Size(233, 44);
            panel4.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-9, 499);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel5.Controls.Add(pictureBox1);
            panel5.Location = new Point(1040, 22);
            panel5.Name = "panel5";
            panel5.Size = new Size(147, 125);
            panel5.TabIndex = 19;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 138);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // Column1
            // 
            Column1.HeaderText = "Nama";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Resizable = DataGridViewTriState.True;
            // 
            // Column2
            // 
            Column2.HeaderText = "NIP";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Detail Dosen";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Resizable = DataGridViewTriState.True;
            Column3.SortMode = DataGridViewColumnSortMode.Automatic;
            Column3.Text = "Lihat";
            Column3.UseColumnTextForButtonValue = true;
            // 
            // v_DataDosen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1158, 605);
            Controls.Add(panel5);
            Controls.Add(pictureBox4);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "v_DataDosen";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            msp_navadmindosen.ResumeLayout(false);
            msp_navadmindosen.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_daftardosenadmin).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private MenuStrip msp_navadmindosen;
        private ToolStripMenuItem dashboardToolStripMenuItem;
        private ToolStripMenuItem managemenAkunToolStripMenuItem;
        private ToolStripMenuItem akunDosenToolStripMenuItem;
        private ToolStripMenuItem akunToolStripMenuItem;
        private ToolStripMenuItem mitraToolStripMenuItem;
        private Panel panel2;
        private Panel panel3;
        private DataGridView tbl_daftardosenadmin;
        private Button btn_tambahdaftardosenadmin;
        private Label label1;
        private Panel panel4;
        private ToolStripMenuItem profileToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem mataKuliahToolStripMenuItem;
        private ToolStripMenuItem tambahMitraProgramToolStripMenuItem;
        private ToolStripMenuItem tambahProgramMataKuliahToolStripMenuItem;
        private PictureBox pictureBox4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewButtonColumn Column3;
    }
}