namespace Baskom.View
{
    partial class v_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_Login));
            lbl_loginsebagai = new Label();
            btn_loginmahasiswa = new Button();
            btn_logintimmbkm = new Button();
            btn_loginadmin = new Button();
            pnl_3aktorbawah = new Panel();
            lbl_mbkmfasilkom = new Label();
            pnl_3aktoratas = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox3 = new PictureBox();
            pnl_3aktorbawah.SuspendLayout();
            pnl_3aktoratas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // lbl_loginsebagai
            // 
            lbl_loginsebagai.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lbl_loginsebagai.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_loginsebagai.Location = new Point(429, 118);
            lbl_loginsebagai.Name = "lbl_loginsebagai";
            lbl_loginsebagai.Size = new Size(269, 56);
            lbl_loginsebagai.TabIndex = 1;
            lbl_loginsebagai.Text = "Login Sebagai?";
            lbl_loginsebagai.TextAlign = ContentAlignment.TopCenter;
            lbl_loginsebagai.Click += label2_Click;
            // 
            // btn_loginmahasiswa
            // 
            btn_loginmahasiswa.Anchor = AnchorStyles.None;
            btn_loginmahasiswa.AutoSize = true;
            btn_loginmahasiswa.BackColor = SystemColors.Highlight;
            btn_loginmahasiswa.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loginmahasiswa.ForeColor = Color.White;
            btn_loginmahasiswa.Location = new Point(151, 46);
            btn_loginmahasiswa.Margin = new Padding(3, 4, 3, 4);
            btn_loginmahasiswa.Name = "btn_loginmahasiswa";
            btn_loginmahasiswa.Size = new Size(240, 240);
            btn_loginmahasiswa.TabIndex = 2;
            btn_loginmahasiswa.Text = "Mahasiswa";
            btn_loginmahasiswa.UseVisualStyleBackColor = false;
            btn_loginmahasiswa.Click += button1_Click;
            // 
            // btn_logintimmbkm
            // 
            btn_logintimmbkm.Anchor = AnchorStyles.None;
            btn_logintimmbkm.AutoSize = true;
            btn_logintimmbkm.BackColor = SystemColors.Highlight;
            btn_logintimmbkm.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_logintimmbkm.ForeColor = Color.White;
            btn_logintimmbkm.Location = new Point(458, 46);
            btn_logintimmbkm.Margin = new Padding(3, 4, 3, 4);
            btn_logintimmbkm.Name = "btn_logintimmbkm";
            btn_logintimmbkm.Size = new Size(240, 240);
            btn_logintimmbkm.TabIndex = 3;
            btn_logintimmbkm.Text = "Tim MBKM";
            btn_logintimmbkm.UseVisualStyleBackColor = false;
            btn_logintimmbkm.Click += button2_Click;
            // 
            // btn_loginadmin
            // 
            btn_loginadmin.Anchor = AnchorStyles.None;
            btn_loginadmin.AutoSize = true;
            btn_loginadmin.BackColor = SystemColors.Highlight;
            btn_loginadmin.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loginadmin.ForeColor = Color.White;
            btn_loginadmin.Location = new Point(766, 46);
            btn_loginadmin.Margin = new Padding(3, 4, 3, 4);
            btn_loginadmin.Name = "btn_loginadmin";
            btn_loginadmin.Size = new Size(240, 240);
            btn_loginadmin.TabIndex = 4;
            btn_loginadmin.Text = "Admin";
            btn_loginadmin.UseVisualStyleBackColor = false;
            btn_loginadmin.Click += btn_loginadmin_Click;
            // 
            // pnl_3aktorbawah
            // 
            pnl_3aktorbawah.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_3aktorbawah.Controls.Add(btn_loginadmin);
            pnl_3aktorbawah.Controls.Add(btn_logintimmbkm);
            pnl_3aktorbawah.Controls.Add(btn_loginmahasiswa);
            pnl_3aktorbawah.Location = new Point(1, 204);
            pnl_3aktorbawah.Name = "pnl_3aktorbawah";
            pnl_3aktorbawah.Size = new Size(1149, 348);
            pnl_3aktorbawah.TabIndex = 5;
            pnl_3aktorbawah.Paint += panel1_Paint;
            // 
            // lbl_mbkmfasilkom
            // 
            lbl_mbkmfasilkom.Anchor = AnchorStyles.Top;
            lbl_mbkmfasilkom.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_mbkmfasilkom.Location = new Point(276, 42);
            lbl_mbkmfasilkom.Name = "lbl_mbkmfasilkom";
            lbl_mbkmfasilkom.Size = new Size(620, 76);
            lbl_mbkmfasilkom.TabIndex = 6;
            lbl_mbkmfasilkom.Text = "MBKM Fasilkom (BASKOM)";
            lbl_mbkmfasilkom.TextAlign = ContentAlignment.TopCenter;
            lbl_mbkmfasilkom.Click += label3_Click;
            // 
            // pnl_3aktoratas
            // 
            pnl_3aktoratas.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnl_3aktoratas.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnl_3aktoratas.Controls.Add(pictureBox2);
            pnl_3aktoratas.Controls.Add(pictureBox6);
            pnl_3aktoratas.Controls.Add(pictureBox1);
            pnl_3aktoratas.Controls.Add(lbl_mbkmfasilkom);
            pnl_3aktoratas.Controls.Add(lbl_loginsebagai);
            pnl_3aktoratas.Location = new Point(1, -4);
            pnl_3aktoratas.Name = "pnl_3aktoratas";
            pnl_3aktoratas.Size = new Size(1149, 202);
            pnl_3aktoratas.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(995, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(189, 156);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(40, -20);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 138);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-16, 570);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(445, 636);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 10;
            pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(1035, 528);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(134, 133);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // v_Login
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1149, 702);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pnl_3aktoratas);
            Controls.Add(pnl_3aktorbawah);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_Login";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            pnl_3aktorbawah.ResumeLayout(false);
            pnl_3aktorbawah.PerformLayout();
            pnl_3aktoratas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_loginsebagai;
        private Button btn_loginmahasiswa;
        private Button btn_logintimmbkm;
        private Button btn_loginadmin;
        private Panel pnl_3aktorbawah;
        private Panel pnl_3aktoratas;
        private Label lbl_mbkmfasilkom;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
    }
}

