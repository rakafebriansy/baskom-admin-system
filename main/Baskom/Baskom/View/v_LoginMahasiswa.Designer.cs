namespace Baskom.View
{
    partial class v_LoginMahasiswa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_LoginMahasiswa));
            pnl_loginkanan = new Panel();
            btn_katasandi = new Button();
            lnk_loginsbgyglain = new LinkLabel();
            btn_login = new Button();
            tbx_katasandilogin = new TextBox();
            lbl_katasandilogin = new Label();
            tbx_nimlogin = new TextBox();
            lbl_nimlogin = new Label();
            lbl_loginmahasiswa = new Label();
            lyt_loginmahasiswa = new TableLayoutPanel();
            panel1 = new Panel();
            pic_logo = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pnl_loginkanan.SuspendLayout();
            lyt_loginmahasiswa.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic_logo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnl_loginkanan
            // 
            pnl_loginkanan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            pnl_loginkanan.Controls.Add(btn_katasandi);
            pnl_loginkanan.Controls.Add(lnk_loginsbgyglain);
            pnl_loginkanan.Controls.Add(btn_login);
            pnl_loginkanan.Controls.Add(tbx_katasandilogin);
            pnl_loginkanan.Controls.Add(lbl_katasandilogin);
            pnl_loginkanan.Controls.Add(tbx_nimlogin);
            pnl_loginkanan.Controls.Add(lbl_nimlogin);
            pnl_loginkanan.Controls.Add(lbl_loginmahasiswa);
            pnl_loginkanan.Location = new Point(578, 4);
            pnl_loginkanan.Margin = new Padding(3, 4, 3, 4);
            pnl_loginkanan.Name = "pnl_loginkanan";
            pnl_loginkanan.Size = new Size(615, 699);
            pnl_loginkanan.TabIndex = 1;
            pnl_loginkanan.Paint += panel2_Paint;
            // 
            // btn_katasandi
            // 
            btn_katasandi.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_katasandi.Location = new Point(430, 332);
            btn_katasandi.Name = "btn_katasandi";
            btn_katasandi.Size = new Size(77, 28);
            btn_katasandi.TabIndex = 10;
            btn_katasandi.Text = "Lihat";
            btn_katasandi.UseVisualStyleBackColor = true;
            btn_katasandi.Click += btn_katasandi_Click;
            // 
            // lnk_loginsbgyglain
            // 
            lnk_loginsbgyglain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lnk_loginsbgyglain.AutoSize = true;
            lnk_loginsbgyglain.Font = new Font("Microsoft Sans Serif", 7F, FontStyle.Regular, GraphicsUnit.Point);
            lnk_loginsbgyglain.Location = new Point(225, 487);
            lnk_loginsbgyglain.Name = "lnk_loginsbgyglain";
            lnk_loginsbgyglain.Size = new Size(137, 15);
            lnk_loginsbgyglain.TabIndex = 9;
            lnk_loginsbgyglain.TabStop = true;
            lnk_loginsbgyglain.Text = "Login sebagai yang lain";
            lnk_loginsbgyglain.LinkClicked += linkLabel2_LinkClicked;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.MenuHighlight;
            btn_login.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(83, 440);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(424, 44);
            btn_login.TabIndex = 6;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += button1_Click;
            // 
            // tbx_katasandilogin
            // 
            tbx_katasandilogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_katasandilogin.Location = new Point(83, 332);
            tbx_katasandilogin.Name = "tbx_katasandilogin";
            tbx_katasandilogin.Size = new Size(341, 24);
            tbx_katasandilogin.TabIndex = 4;
            tbx_katasandilogin.TextChanged += tbx_katasandilogin_TextChanged;
            // 
            // lbl_katasandilogin
            // 
            lbl_katasandilogin.AutoSize = true;
            lbl_katasandilogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandilogin.Location = new Point(76, 291);
            lbl_katasandilogin.Name = "lbl_katasandilogin";
            lbl_katasandilogin.Size = new Size(100, 20);
            lbl_katasandilogin.TabIndex = 3;
            lbl_katasandilogin.Text = "Kata Sandi";
            // 
            // tbx_nimlogin
            // 
            tbx_nimlogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_nimlogin.Location = new Point(83, 226);
            tbx_nimlogin.Name = "tbx_nimlogin";
            tbx_nimlogin.Size = new Size(424, 24);
            tbx_nimlogin.TabIndex = 2;
            // 
            // lbl_nimlogin
            // 
            lbl_nimlogin.AutoSize = true;
            lbl_nimlogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nimlogin.Location = new Point(76, 185);
            lbl_nimlogin.Name = "lbl_nimlogin";
            lbl_nimlogin.Size = new Size(42, 20);
            lbl_nimlogin.TabIndex = 1;
            lbl_nimlogin.Text = "NIM";
            // 
            // lbl_loginmahasiswa
            // 
            lbl_loginmahasiswa.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbl_loginmahasiswa.AutoSize = true;
            lbl_loginmahasiswa.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_loginmahasiswa.Location = new Point(177, 106);
            lbl_loginmahasiswa.Name = "lbl_loginmahasiswa";
            lbl_loginmahasiswa.Size = new Size(262, 36);
            lbl_loginmahasiswa.TabIndex = 0;
            lbl_loginmahasiswa.Text = "Login Mahasiswa";
            lbl_loginmahasiswa.Click += label1_Click;
            // 
            // lyt_loginmahasiswa
            // 
            lyt_loginmahasiswa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lyt_loginmahasiswa.ColumnCount = 2;
            lyt_loginmahasiswa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.70642F));
            lyt_loginmahasiswa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.29358F));
            lyt_loginmahasiswa.Controls.Add(panel1, 0, 0);
            lyt_loginmahasiswa.Controls.Add(pnl_loginkanan, 1, 0);
            lyt_loginmahasiswa.Location = new Point(12, 133);
            lyt_loginmahasiswa.Name = "lyt_loginmahasiswa";
            lyt_loginmahasiswa.RowCount = 1;
            lyt_loginmahasiswa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            lyt_loginmahasiswa.Size = new Size(1199, 707);
            lyt_loginmahasiswa.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pic_logo);
            panel1.Controls.Add(pictureBox6);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 701);
            panel1.TabIndex = 11;
            // 
            // pic_logo
            // 
            pic_logo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic_logo.Image = (Image)resources.GetObject("pic_logo.Image");
            pic_logo.Location = new Point(96, 186);
            pic_logo.Margin = new Padding(3, 6, 3, 6);
            pic_logo.Name = "pic_logo";
            pic_logo.Size = new Size(467, 272);
            pic_logo.SizeMode = PictureBoxSizeMode.Zoom;
            pic_logo.TabIndex = 16;
            pic_logo.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(155, 56);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 15;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 138);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(17, -4);
            panel2.Name = "panel2";
            panel2.Size = new Size(147, 125);
            panel2.TabIndex = 16;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-11, 853);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 16;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1104, 791);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 133);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 18;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(593, 949);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 17;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1065, -15);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // v_LoginMahasiswa
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 972);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox5);
            Controls.Add(panel2);
            Controls.Add(lyt_loginmahasiswa);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_LoginMahasiswa";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            pnl_loginkanan.ResumeLayout(false);
            pnl_loginkanan.PerformLayout();
            lyt_loginmahasiswa.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic_logo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnl_loginkanan;
        private Label lbl_loginmahasiswa;
        private TextBox tbx_katasandilogin;
        private Label lbl_katasandilogin;
        private TextBox tbx_nimlogin;
        private Label lbl_nimlogin;
        private Button btn_login;
        private LinkLabel lnk_loginsbgyglain;
        private Button btn_katasandi;
        private TableLayoutPanel lyt_loginmahasiswa;
        private Panel panel1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pic_logo;
    }
}