namespace Baskom.View
{
    partial class v_UbahKataSandiProfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_UbahKataSandiProfil));
            tableLayoutPanel1 = new TableLayoutPanel();
            panel2 = new Panel();
            pictureBox6 = new PictureBox();
            btn_simpan = new Button();
            btn_lihat = new Button();
            panel1 = new Panel();
            lbl_katasandilama = new Label();
            tbx_konfirmasikatasandibaru = new TextBox();
            lbl_konfirmasikatasandibaru = new Label();
            tbx_katasandibaru = new TextBox();
            lbl_katasandibaru = new Label();
            lbl_katasandilama1 = new Label();
            lbl_ubahkatasandi = new Label();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 61.0350075F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 38.9649925F));
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Location = new Point(69, 77);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(657, 496);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(btn_simpan);
            panel2.Controls.Add(btn_lihat);
            panel2.Location = new Point(404, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 490);
            panel2.TabIndex = 1;
            // 
            // pictureBox6
            // 
            pictureBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(132, 43);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(37, 38);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 25;
            pictureBox6.TabStop = false;
            // 
            // btn_simpan
            // 
            btn_simpan.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_simpan.BackColor = SystemColors.MenuHighlight;
            btn_simpan.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_simpan.ForeColor = Color.White;
            btn_simpan.Location = new Point(144, 443);
            btn_simpan.Name = "btn_simpan";
            btn_simpan.Size = new Size(105, 44);
            btn_simpan.TabIndex = 0;
            btn_simpan.Text = "Simpan";
            btn_simpan.UseVisualStyleBackColor = false;
            btn_simpan.Click += button2_Click;
            // 
            // btn_lihat
            // 
            btn_lihat.Anchor = AnchorStyles.Left;
            btn_lihat.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_lihat.Location = new Point(3, 146);
            btn_lihat.Name = "btn_lihat";
            btn_lihat.Size = new Size(76, 37);
            btn_lihat.TabIndex = 10;
            btn_lihat.Text = "Lihat";
            btn_lihat.UseVisualStyleBackColor = true;
            btn_lihat.Click += btn_lihat_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(lbl_katasandilama);
            panel1.Controls.Add(tbx_konfirmasikatasandibaru);
            panel1.Controls.Add(lbl_konfirmasikatasandibaru);
            panel1.Controls.Add(tbx_katasandibaru);
            panel1.Controls.Add(lbl_katasandibaru);
            panel1.Controls.Add(lbl_katasandilama1);
            panel1.Controls.Add(lbl_ubahkatasandi);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(395, 490);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // lbl_katasandilama
            // 
            lbl_katasandilama.Anchor = AnchorStyles.Right;
            lbl_katasandilama.AutoSize = true;
            lbl_katasandilama.Location = new Point(3, 149);
            lbl_katasandilama.Name = "lbl_katasandilama";
            lbl_katasandilama.Size = new Size(86, 18);
            lbl_katasandilama.TabIndex = 7;
            lbl_katasandilama.Text = "*************";
            // 
            // tbx_konfirmasikatasandibaru
            // 
            tbx_konfirmasikatasandibaru.Anchor = AnchorStyles.Right;
            tbx_konfirmasikatasandibaru.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_konfirmasikatasandibaru.Location = new Point(4, 342);
            tbx_konfirmasikatasandibaru.Name = "tbx_konfirmasikatasandibaru";
            tbx_konfirmasikatasandibaru.Size = new Size(376, 24);
            tbx_konfirmasikatasandibaru.TabIndex = 6;
            tbx_konfirmasikatasandibaru.TextChanged += tbx_konfirmasikatasandibaru_TextChanged;
            // 
            // lbl_konfirmasikatasandibaru
            // 
            lbl_konfirmasikatasandibaru.Anchor = AnchorStyles.Right;
            lbl_konfirmasikatasandibaru.AutoSize = true;
            lbl_konfirmasikatasandibaru.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_konfirmasikatasandibaru.Location = new Point(3, 303);
            lbl_konfirmasikatasandibaru.Name = "lbl_konfirmasikatasandibaru";
            lbl_konfirmasikatasandibaru.Size = new Size(242, 20);
            lbl_konfirmasikatasandibaru.TabIndex = 5;
            lbl_konfirmasikatasandibaru.Text = "Konfirmasi Kata Sandi Baru";
            // 
            // tbx_katasandibaru
            // 
            tbx_katasandibaru.Anchor = AnchorStyles.Right;
            tbx_katasandibaru.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tbx_katasandibaru.Location = new Point(3, 247);
            tbx_katasandibaru.Name = "tbx_katasandibaru";
            tbx_katasandibaru.Size = new Size(377, 24);
            tbx_katasandibaru.TabIndex = 4;
            tbx_katasandibaru.TextChanged += tbx_katasandibaru_TextChanged;
            // 
            // lbl_katasandibaru
            // 
            lbl_katasandibaru.Anchor = AnchorStyles.Right;
            lbl_katasandibaru.AutoSize = true;
            lbl_katasandibaru.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandibaru.Location = new Point(3, 208);
            lbl_katasandibaru.Name = "lbl_katasandibaru";
            lbl_katasandibaru.Size = new Size(146, 20);
            lbl_katasandibaru.TabIndex = 3;
            lbl_katasandibaru.Text = "Kata Sandi Baru";
            // 
            // lbl_katasandilama1
            // 
            lbl_katasandilama1.Anchor = AnchorStyles.Right;
            lbl_katasandilama1.AutoSize = true;
            lbl_katasandilama1.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_katasandilama1.Location = new Point(3, 110);
            lbl_katasandilama1.Name = "lbl_katasandilama1";
            lbl_katasandilama1.Size = new Size(152, 20);
            lbl_katasandilama1.TabIndex = 2;
            lbl_katasandilama1.Text = "Kata Sandi Lama";
            // 
            // lbl_ubahkatasandi
            // 
            lbl_ubahkatasandi.Anchor = AnchorStyles.Right;
            lbl_ubahkatasandi.AutoSize = true;
            lbl_ubahkatasandi.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_ubahkatasandi.Location = new Point(62, 3);
            lbl_ubahkatasandi.Name = "lbl_ubahkatasandi";
            lbl_ubahkatasandi.Size = new Size(255, 36);
            lbl_ubahkatasandi.TabIndex = 0;
            lbl_ubahkatasandi.Text = "Ubah Kata Sandi";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-18, 511);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 22;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, -16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 128);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(660, -17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(154, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 24;
            pictureBox2.TabStop = false;
            // 
            // v_UbahKataSandiProfil
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 660);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_UbahKataSandiProfil";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            Load += Form4_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label lbl_ubahkatasandi;
        private Label lbl_katasandibaru;
        private Label lbl_katasandilama1;
        private Label lbl_konfirmasikatasandibaru;
        private Button btn_lihat;
        private Button btn_simpan;
        private TextBox tbx_konfirmasikatasandibaru;
        private TextBox tbx_katasandibaru;
        private Label lbl_katasandilama;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
    }
}