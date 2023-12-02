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
            pic = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            pnl_loginkanan.SuspendLayout();
            lyt_loginmahasiswa.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pic
            // 
            pic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pic.Image = Properties.Resources.baskom_logo_fit;
            pic.Location = new Point(3, 203);
            pic.Margin = new Padding(3, 4, 3, 4);
            pic.Name = "pic";
            pic.Size = new Size(555, 302);
            pic.SizeMode = PictureBoxSizeMode.Zoom;
            pic.TabIndex = 0;
            pic.TabStop = false;
            pic.Click += pic_Click;
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
            pnl_loginkanan.Location = new Point(570, 4);
            pnl_loginkanan.Margin = new Padding(3, 4, 3, 4);
            pnl_loginkanan.Name = "pnl_loginkanan";
            pnl_loginkanan.Size = new Size(626, 699);
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
            lnk_loginsbgyglain.Location = new Point(231, 487);
            lnk_loginsbgyglain.Name = "lnk_loginsbgyglain";
            lnk_loginsbgyglain.Size = new Size(158, 17);
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
            tbx_katasandilogin.Size = new Size(341, 28);
            tbx_katasandilogin.TabIndex = 4;
            // 
            // lbl_katasandilogin
            // 
            lbl_katasandilogin.AutoSize = true;
            lbl_katasandilogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandilogin.Location = new Point(76, 291);
            lbl_katasandilogin.Name = "lbl_katasandilogin";
            lbl_katasandilogin.Size = new Size(119, 25);
            lbl_katasandilogin.TabIndex = 3;
            lbl_katasandilogin.Text = "Kata Sandi";
            // 
            // tbx_nimlogin
            // 
            tbx_nimlogin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_nimlogin.Location = new Point(83, 226);
            tbx_nimlogin.Name = "tbx_nimlogin";
            tbx_nimlogin.Size = new Size(424, 28);
            tbx_nimlogin.TabIndex = 2;
            // 
            // lbl_nimlogin
            // 
            lbl_nimlogin.AutoSize = true;
            lbl_nimlogin.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_nimlogin.Location = new Point(76, 185);
            lbl_nimlogin.Name = "lbl_nimlogin";
            lbl_nimlogin.Size = new Size(51, 25);
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
            lbl_loginmahasiswa.Size = new Size(310, 40);
            lbl_loginmahasiswa.TabIndex = 0;
            lbl_loginmahasiswa.Text = "Login Mahasiswa";
            lbl_loginmahasiswa.Click += label1_Click;
            // 
            // lyt_loginmahasiswa
            // 
            lyt_loginmahasiswa.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            lyt_loginmahasiswa.ColumnCount = 2;
            lyt_loginmahasiswa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.28941F));
            lyt_loginmahasiswa.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.71059F));
            lyt_loginmahasiswa.Controls.Add(panel1, 0, 0);
            lyt_loginmahasiswa.Controls.Add(pnl_loginkanan, 1, 0);
            lyt_loginmahasiswa.Location = new Point(12, 12);
            lyt_loginmahasiswa.Name = "lyt_loginmahasiswa";
            lyt_loginmahasiswa.RowCount = 1;
            lyt_loginmahasiswa.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            lyt_loginmahasiswa.Size = new Size(1199, 707);
            lyt_loginmahasiswa.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pic);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(561, 701);
            panel1.TabIndex = 11;
            // 
            // v_LoginMahasiswa
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1216, 731);
            Controls.Add(lyt_loginmahasiswa);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_LoginMahasiswa";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            pnl_loginkanan.ResumeLayout(false);
            pnl_loginkanan.PerformLayout();
            lyt_loginmahasiswa.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pic;
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
    }
}