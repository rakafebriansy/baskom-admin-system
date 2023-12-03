namespace Baskom.View
{
    partial class v_DashboardMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_DashboardMahasiswa));
            menuStrip1 = new MenuStrip();
            dashboardToolStripMenuItem = new ToolStripMenuItem();
            mitraToolStripMenuItem = new ToolStripMenuItem();
            pengajuanMitraToolStripMenuItem = new ToolStripMenuItem();
            statusMOAToolStripMenuItem = new ToolStripMenuItem();
            mataKuliahToolStripMenuItem = new ToolStripMenuItem();
            konversiSKSToolStripMenuItem = new ToolStripMenuItem();
            konversiNilaiToolStripMenuItem = new ToolStripMenuItem();
            profilToolStripMenuItem = new ToolStripMenuItem();
            informasiAkunToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            panel4 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            lbl_dashboard = new Label();
            panel1 = new Panel();
            pic_logobaskom = new PictureBox();
            panel3 = new Panel();
            menuStrip1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logobaskom).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dashboardToolStripMenuItem, mitraToolStripMenuItem, mataKuliahToolStripMenuItem, konversiSKSToolStripMenuItem, konversiNilaiToolStripMenuItem, profilToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1493, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            dashboardToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            dashboardToolStripMenuItem.Size = new Size(95, 22);
            dashboardToolStripMenuItem.Text = "Dashboard";
            dashboardToolStripMenuItem.Click += dashboardToolStripMenuItem_Click;
            // 
            // mitraToolStripMenuItem
            // 
            mitraToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pengajuanMitraToolStripMenuItem, statusMOAToolStripMenuItem });
            mitraToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mitraToolStripMenuItem.Name = "mitraToolStripMenuItem";
            mitraToolStripMenuItem.Size = new Size(55, 22);
            mitraToolStripMenuItem.Text = "Mitra";
            mitraToolStripMenuItem.Click += mitraToolStripMenuItem_Click;
            // 
            // pengajuanMitraToolStripMenuItem
            // 
            pengajuanMitraToolStripMenuItem.Name = "pengajuanMitraToolStripMenuItem";
            pengajuanMitraToolStripMenuItem.Size = new Size(206, 26);
            pengajuanMitraToolStripMenuItem.Text = "Penerimaan Mitra";
            pengajuanMitraToolStripMenuItem.Click += pengajuanMitraToolStripMenuItem_Click;
            // 
            // statusMOAToolStripMenuItem
            // 
            statusMOAToolStripMenuItem.Name = "statusMOAToolStripMenuItem";
            statusMOAToolStripMenuItem.Size = new Size(206, 26);
            statusMOAToolStripMenuItem.Text = "Pengajuan MOA";
            statusMOAToolStripMenuItem.Click += statusMOAToolStripMenuItem_Click;
            // 
            // mataKuliahToolStripMenuItem
            // 
            mataKuliahToolStripMenuItem.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            mataKuliahToolStripMenuItem.Name = "mataKuliahToolStripMenuItem";
            mataKuliahToolStripMenuItem.Size = new Size(99, 22);
            mataKuliahToolStripMenuItem.Text = "Mata Kuliah";
            mataKuliahToolStripMenuItem.Click += mataKuliahToolStripMenuItem_Click;
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
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(32, 32);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(149, 795);
            panel4.Name = "panel4";
            panel4.Size = new Size(147, 125);
            panel4.TabIndex = 18;
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
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1361, 775);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(4, 19);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(66, 133);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 18;
            pictureBox5.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45.6521721F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 54.3478279F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(0, 202);
            tableLayoutPanel1.Margin = new Padding(2, 3, 2, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1493, 452);
            tableLayoutPanel1.TabIndex = 23;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.Controls.Add(lbl_dashboard);
            panel2.Location = new Point(687, 3);
            panel2.Margin = new Padding(2, 3, 2, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 446);
            panel2.TabIndex = 2;
            // 
            // lbl_dashboard
            // 
            lbl_dashboard.AutoSize = true;
            lbl_dashboard.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_dashboard.ForeColor = Color.Black;
            lbl_dashboard.Location = new Point(3, 184);
            lbl_dashboard.Name = "lbl_dashboard";
            lbl_dashboard.Size = new Size(758, 140);
            lbl_dashboard.TabIndex = 1;
            lbl_dashboard.Text = resources.GetString("lbl_dashboard.Text");
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pic_logobaskom);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(675, 446);
            panel1.TabIndex = 3;
            // 
            // pic_logobaskom
            // 
            pic_logobaskom.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic_logobaskom.Image = (Image)resources.GetObject("pic_logobaskom.Image");
            pic_logobaskom.Location = new Point(82, 113);
            pic_logobaskom.Margin = new Padding(2, 3, 2, 3);
            pic_logobaskom.Name = "pic_logobaskom";
            pic_logobaskom.Size = new Size(591, 217);
            pic_logobaskom.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logobaskom.TabIndex = 0;
            pic_logobaskom.TabStop = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel3.Controls.Add(pictureBox6);
            panel3.Location = new Point(1472, 290);
            panel3.Name = "panel3";
            panel3.Size = new Size(52, 72);
            panel3.TabIndex = 24;
            // 
            // v_DashboardMahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1493, 898);
            Controls.Add(panel3);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(panel4);
            Controls.Add(menuStrip1);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_DashboardMahasiswa";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form3_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_logobaskom).EndInit();
            panel3.ResumeLayout(false);
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
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem profilToolStripMenuItem;
        private ToolStripMenuItem informasiAkunToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem pengajuanMitraToolStripMenuItem;
        private ToolStripMenuItem statusMOAToolStripMenuItem;
        private Panel panel4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel2;
        private Panel panel1;
        private PictureBox pic_logobaskom;
        private Label lbl_dashboard;
        private Panel panel3;
    }
}