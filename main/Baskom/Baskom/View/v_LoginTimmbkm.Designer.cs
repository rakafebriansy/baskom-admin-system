namespace Baskom.View
{
    partial class v_LoginTimmbkm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_LoginTimmbkm));
            panel2 = new Panel();
            btn_lihat = new Button();
            btn_login = new Button();
            tbx_katasandi = new TextBox();
            tbx_NIDN = new TextBox();
            lnk_loginsebagaiyanglain = new LinkLabel();
            lbl_KataSandi = new Label();
            lbl_NIDN = new Label();
            lbl_logintimMBKM = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            panel2.Controls.Add(btn_lihat);
            panel2.Controls.Add(btn_login);
            panel2.Controls.Add(tbx_katasandi);
            panel2.Controls.Add(tbx_NIDN);
            panel2.Controls.Add(lnk_loginsebagaiyanglain);
            panel2.Controls.Add(lbl_KataSandi);
            panel2.Controls.Add(lbl_NIDN);
            panel2.Controls.Add(lbl_logintimMBKM);
            panel2.Location = new Point(516, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(507, 650);
            panel2.TabIndex = 2;
            // 
            // btn_lihat
            // 
            btn_lihat.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lihat.Location = new Point(360, 349);
            btn_lihat.Margin = new Padding(3, 4, 3, 4);
            btn_lihat.Name = "btn_lihat";
            btn_lihat.Size = new Size(113, 31);
            btn_lihat.TabIndex = 8;
            btn_lihat.Text = "Lihat";
            btn_lihat.UseVisualStyleBackColor = true;
            btn_lihat.Click += btn_lihat_Click;
            // 
            // btn_login
            // 
            btn_login.BackColor = SystemColors.MenuHighlight;
            btn_login.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(26, 451);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(448, 59);
            btn_login.TabIndex = 7;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // tbx_katasandi
            // 
            tbx_katasandi.Location = new Point(26, 349);
            tbx_katasandi.Margin = new Padding(3, 4, 3, 4);
            tbx_katasandi.Name = "tbx_katasandi";
            tbx_katasandi.Size = new Size(314, 31);
            tbx_katasandi.TabIndex = 6;
            tbx_katasandi.TextChanged += tbx_katasandi_TextChanged;
            // 
            // tbx_NIDN
            // 
            tbx_NIDN.Location = new Point(26, 250);
            tbx_NIDN.Margin = new Padding(3, 4, 3, 4);
            tbx_NIDN.Name = "tbx_NIDN";
            tbx_NIDN.Size = new Size(447, 31);
            tbx_NIDN.TabIndex = 5;
            tbx_NIDN.TextChanged += tbx_NIDN_TextChanged;
            // 
            // lnk_loginsebagaiyanglain
            // 
            lnk_loginsebagaiyanglain.AutoSize = true;
            lnk_loginsebagaiyanglain.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            lnk_loginsebagaiyanglain.Location = new Point(141, 536);
            lnk_loginsebagaiyanglain.Name = "lnk_loginsebagaiyanglain";
            lnk_loginsebagaiyanglain.Size = new Size(174, 20);
            lnk_loginsebagaiyanglain.TabIndex = 4;
            lnk_loginsebagaiyanglain.TabStop = true;
            lnk_loginsebagaiyanglain.Text = "Login sebagai yang lain";
            lnk_loginsebagaiyanglain.LinkClicked += lnk_loginsebagaiyanglain_LinkClicked;
            // 
            // lbl_KataSandi
            // 
            lbl_KataSandi.AutoSize = true;
            lbl_KataSandi.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_KataSandi.Location = new Point(29, 300);
            lbl_KataSandi.Name = "lbl_KataSandi";
            lbl_KataSandi.Size = new Size(119, 25);
            lbl_KataSandi.TabIndex = 2;
            lbl_KataSandi.Text = "Kata Sandi";
            // 
            // lbl_NIDN
            // 
            lbl_NIDN.AutoSize = true;
            lbl_NIDN.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_NIDN.Location = new Point(23, 200);
            lbl_NIDN.Name = "lbl_NIDN";
            lbl_NIDN.Size = new Size(63, 25);
            lbl_NIDN.TabIndex = 1;
            lbl_NIDN.Text = "NIDN";
            // 
            // lbl_logintimMBKM
            // 
            lbl_logintimMBKM.AutoSize = true;
            lbl_logintimMBKM.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_logintimMBKM.Location = new Point(79, 51);
            lbl_logintimMBKM.Name = "lbl_logintimMBKM";
            lbl_logintimMBKM.Size = new Size(318, 40);
            lbl_logintimMBKM.TabIndex = 0;
            lbl_logintimMBKM.Text = "Log in Tim MBKM";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(13, 15);
            tableLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1026, 658);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(507, 652);
            panel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = Properties.Resources.baskom_logo_fit;
            pictureBox1.Location = new Point(6, 201);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(501, 291);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // v_LoginTimmbkm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1041, 676);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_LoginTimmbkm";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label lbl_logintimMBKM;
        private Button btn_lihat;
        private Button btn_login;
        private TextBox tbx_katasandi;
        private TextBox tbx_NIDN;
        private LinkLabel lnk_loginsebagaiyanglain;
        private Label lbl_KataSandi;
        private Label lbl_NIDN;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
    }
}

