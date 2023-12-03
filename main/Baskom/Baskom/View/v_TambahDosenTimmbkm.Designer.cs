namespace Baskom.View
{
    partial class v_TambahDosenTimmbkm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_TambahDosenTimmbkm));
            panel1 = new Panel();
            cbx_jabatandosen = new ComboBox();
            label1 = new Label();
            label5 = new Label();
            label4 = new Label();
            tbx_nidntambahdosen = new TextBox();
            label3 = new Label();
            tbx_niptambahdosen = new TextBox();
            label2 = new Label();
            tbx_namatambahdosen = new TextBox();
            panel2 = new Panel();
            btn_tambahtambahdosen = new Button();
            label8 = new Label();
            tbx_katasanditambahdosen = new TextBox();
            label9 = new Label();
            tbx_emailtambahdosen = new TextBox();
            label10 = new Label();
            tbx_nowatambahdosen = new TextBox();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(cbx_jabatandosen);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(tbx_nidntambahdosen);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(tbx_niptambahdosen);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(tbx_namatambahdosen);
            panel1.Location = new Point(194, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(893, 1180);
            panel1.TabIndex = 0;
            // 
            // cbx_jabatandosen
            // 
            cbx_jabatandosen.FormattingEnabled = true;
            cbx_jabatandosen.Items.AddRange(new object[] { "Tim MBKM", "Dosen" });
            cbx_jabatandosen.Location = new Point(2, 442);
            cbx_jabatandosen.Margin = new Padding(2);
            cbx_jabatandosen.Name = "cbx_jabatandosen";
            cbx_jabatandosen.Size = new Size(637, 28);
            cbx_jabatandosen.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Poppins", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 62);
            label1.Name = "label1";
            label1.Size = new Size(255, 53);
            label1.TabIndex = 9;
            label1.Text = "Tambah Dosen";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(3, 409);
            label5.Name = "label5";
            label5.Size = new Size(75, 26);
            label5.TabIndex = 7;
            label5.Text = "Jabatan";
            label5.Click += label5_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(3, 341);
            label4.Name = "label4";
            label4.Size = new Size(49, 26);
            label4.TabIndex = 5;
            label4.Text = "NIDN";
            label4.Click += label4_Click_1;
            // 
            // tbx_nidntambahdosen
            // 
            tbx_nidntambahdosen.Location = new Point(3, 368);
            tbx_nidntambahdosen.Multiline = true;
            tbx_nidntambahdosen.Name = "tbx_nidntambahdosen";
            tbx_nidntambahdosen.Size = new Size(637, 31);
            tbx_nidntambahdosen.TabIndex = 4;
            tbx_nidntambahdosen.TextChanged += textBox3_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 268);
            label3.Name = "label3";
            label3.Size = new Size(36, 26);
            label3.TabIndex = 3;
            label3.Text = "NIP";
            label3.Click += label3_Click;
            // 
            // tbx_niptambahdosen
            // 
            tbx_niptambahdosen.Location = new Point(3, 295);
            tbx_niptambahdosen.Multiline = true;
            tbx_niptambahdosen.Name = "tbx_niptambahdosen";
            tbx_niptambahdosen.Size = new Size(637, 31);
            tbx_niptambahdosen.TabIndex = 2;
            tbx_niptambahdosen.TextChanged += textBox2_TextChanged_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 197);
            label2.Name = "label2";
            label2.Size = new Size(58, 26);
            label2.TabIndex = 1;
            label2.Text = "Nama";
            label2.Click += label2_Click;
            // 
            // tbx_namatambahdosen
            // 
            tbx_namatambahdosen.Location = new Point(3, 225);
            tbx_namatambahdosen.Multiline = true;
            tbx_namatambahdosen.Name = "tbx_namatambahdosen";
            tbx_namatambahdosen.Size = new Size(637, 32);
            tbx_namatambahdosen.TabIndex = 0;
            tbx_namatambahdosen.TextChanged += textBox1_TextChanged_1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Controls.Add(btn_tambahtambahdosen);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(tbx_katasanditambahdosen);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(tbx_emailtambahdosen);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(tbx_nowatambahdosen);
            panel2.Location = new Point(931, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(1570, 1180);
            panel2.TabIndex = 1;
            // 
            // btn_tambahtambahdosen
            // 
            btn_tambahtambahdosen.BackColor = SystemColors.Highlight;
            btn_tambahtambahdosen.Font = new Font("Poppins SemiBold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_tambahtambahdosen.ForeColor = SystemColors.HighlightText;
            btn_tambahtambahdosen.Location = new Point(563, 442);
            btn_tambahtambahdosen.Name = "btn_tambahtambahdosen";
            btn_tambahtambahdosen.Size = new Size(125, 42);
            btn_tambahtambahdosen.TabIndex = 6;
            btn_tambahtambahdosen.Text = "Tambah";
            btn_tambahtambahdosen.UseVisualStyleBackColor = false;
            btn_tambahtambahdosen.Click += btn_tambahtambahdosen_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(51, 355);
            label8.Name = "label8";
            label8.Size = new Size(93, 26);
            label8.TabIndex = 5;
            label8.Text = "Kata Sandi";
            label8.Click += label8_Click;
            // 
            // tbx_katasanditambahdosen
            // 
            tbx_katasanditambahdosen.Location = new Point(51, 384);
            tbx_katasanditambahdosen.Multiline = true;
            tbx_katasanditambahdosen.Name = "tbx_katasanditambahdosen";
            tbx_katasanditambahdosen.Size = new Size(637, 31);
            tbx_katasanditambahdosen.TabIndex = 4;
            tbx_katasanditambahdosen.TextChanged += textBox6_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(51, 273);
            label9.Name = "label9";
            label9.Size = new Size(61, 26);
            label9.TabIndex = 3;
            label9.Text = "E-mail";
            label9.Click += label9_Click;
            // 
            // tbx_emailtambahdosen
            // 
            tbx_emailtambahdosen.Location = new Point(50, 302);
            tbx_emailtambahdosen.Multiline = true;
            tbx_emailtambahdosen.Name = "tbx_emailtambahdosen";
            tbx_emailtambahdosen.Size = new Size(637, 32);
            tbx_emailtambahdosen.TabIndex = 2;
            tbx_emailtambahdosen.TextChanged += textBox7_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Poppins", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(51, 194);
            label10.Name = "label10";
            label10.Size = new Size(146, 26);
            label10.TabIndex = 1;
            label10.Text = "Nomor WhatsApp";
            label10.Click += label10_Click;
            // 
            // tbx_nowatambahdosen
            // 
            tbx_nowatambahdosen.Location = new Point(50, 225);
            tbx_nowatambahdosen.Multiline = true;
            tbx_nowatambahdosen.Name = "tbx_nowatambahdosen";
            tbx_nowatambahdosen.Size = new Size(637, 33);
            tbx_nowatambahdosen.TabIndex = 0;
            tbx_nowatambahdosen.TextChanged += textBox8_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 119);
            pictureBox1.TabIndex = 14;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel4.Controls.Add(pictureBox1);
            panel4.Location = new Point(1375, -1);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 125);
            panel4.TabIndex = 18;
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-4, 766);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 19;
            pictureBox4.TabStop = false;
            // 
            // v_TambahDosenTimmbkm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 902);
            Controls.Add(pictureBox4);
            Controls.Add(panel4);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "v_TambahDosenTimmbkm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += daftardosen_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox tbx_namatambahdosen;
        private Label label3;
        private TextBox tbx_niptambahdosen;
        private Label label2;
        private Label label5;
        private Label label4;
        private TextBox tbx_nidntambahdosen;
        private Panel panel2;
        private Label label8;
        private TextBox tbx_katasanditambahdosen;
        private Label label9;
        private TextBox tbx_emailtambahdosen;
        private Label label10;
        private TextBox tbx_nowatambahdosen;
        private Label label1;
        private Button btn_tambahtambahdosen;
        private ComboBox cbx_jabatandosen;
        private PictureBox pictureBox1;
        private Panel panel4;
        private PictureBox pictureBox4;
    }
}