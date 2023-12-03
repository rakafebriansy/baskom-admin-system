namespace Baskom.View
{
    partial class v_LihatMataKuliahProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(v_LihatMataKuliahProgram));
            lyt_lihatmatakuliah = new TableLayoutPanel();
            lbl_carimatkulkonversisks = new Label();
            btn_kembalikonversisks = new Button();
            pnl_carimatkul = new Panel();
            tbl_matkulkonversisks = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            lyt_lihatmatakuliah.SuspendLayout();
            pnl_carimatkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_matkulkonversisks).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // lyt_lihatmatakuliah
            // 
            lyt_lihatmatakuliah.ColumnCount = 1;
            lyt_lihatmatakuliah.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            lyt_lihatmatakuliah.Controls.Add(lbl_carimatkulkonversisks, 0, 0);
            lyt_lihatmatakuliah.Location = new Point(39, 42);
            lyt_lihatmatakuliah.Name = "lyt_lihatmatakuliah";
            lyt_lihatmatakuliah.RowCount = 5;
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Percent, 52.12766F));
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Percent, 47.87234F));
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Absolute, 98F));
            lyt_lihatmatakuliah.Size = new Size(1078, 522);
            lyt_lihatmatakuliah.TabIndex = 0;
            // 
            // lbl_carimatkulkonversisks
            // 
            lbl_carimatkulkonversisks.AutoSize = true;
            lbl_carimatkulkonversisks.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_carimatkulkonversisks.Location = new Point(3, 0);
            lbl_carimatkulkonversisks.Name = "lbl_carimatkulkonversisks";
            lbl_carimatkulkonversisks.Size = new Size(699, 36);
            lbl_carimatkulkonversisks.TabIndex = 0;
            lbl_carimatkulkonversisks.Text = "Rekomendasi Mata Kuliah Sesuai Program Mitra";
            // 
            // btn_kembalikonversisks
            // 
            btn_kembalikonversisks.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_kembalikonversisks.BackColor = SystemColors.Highlight;
            btn_kembalikonversisks.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_kembalikonversisks.ForeColor = Color.White;
            btn_kembalikonversisks.Location = new Point(1001, 570);
            btn_kembalikonversisks.Name = "btn_kembalikonversisks";
            btn_kembalikonversisks.Size = new Size(116, 35);
            btn_kembalikonversisks.TabIndex = 3;
            btn_kembalikonversisks.Text = "Kembali";
            btn_kembalikonversisks.UseVisualStyleBackColor = false;
            btn_kembalikonversisks.Click += button2_Click;
            // 
            // pnl_carimatkul
            // 
            pnl_carimatkul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_carimatkul.Controls.Add(tbl_matkulkonversisks);
            pnl_carimatkul.Location = new Point(22, 150);
            pnl_carimatkul.Name = "pnl_carimatkul";
            pnl_carimatkul.Size = new Size(1095, 414);
            pnl_carimatkul.TabIndex = 1;
            // 
            // tbl_matkulkonversisks
            // 
            tbl_matkulkonversisks.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbl_matkulkonversisks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tbl_matkulkonversisks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tbl_matkulkonversisks.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3 });
            tbl_matkulkonversisks.Location = new Point(19, 2);
            tbl_matkulkonversisks.Name = "tbl_matkulkonversisks";
            tbl_matkulkonversisks.RowHeadersWidth = 82;
            tbl_matkulkonversisks.RowTemplate.Height = 33;
            tbl_matkulkonversisks.Size = new Size(1073, 370);
            tbl_matkulkonversisks.TabIndex = 0;
            // 
            // Column1
            // 
            Column1.HeaderText = "Kode Mata Kuliah";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "Nama Mata Kuliah";
            Column2.MinimumWidth = 8;
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Jumlah SKS";
            Column3.MinimumWidth = 8;
            Column3.Name = "Column3";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(-16, 540);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(154, 197);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 21;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(299, 570);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 48);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 22;
            pictureBox5.TabStop = false;
            // 
            // v_LihatMataKuliahProgram
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 666);
            Controls.Add(pictureBox5);
            Controls.Add(btn_kembalikonversisks);
            Controls.Add(pictureBox4);
            Controls.Add(pnl_carimatkul);
            Controls.Add(lyt_lihatmatakuliah);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_LihatMataKuliahProgram";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            lyt_lihatmatakuliah.ResumeLayout(false);
            lyt_lihatmatakuliah.PerformLayout();
            pnl_carimatkul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_matkulkonversisks).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel lyt_lihatmatakuliah;
        private Label lbl_carimatkulkonversisks;
        private Panel pnl_carimatkul;
        private DataGridView tbl_matkulkonversisks;
        private Button btn_kembalikonversisks;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}