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
            lyt_lihatmatakuliah.SuspendLayout();
            pnl_carimatkul.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbl_matkulkonversisks).BeginInit();
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
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Percent, 72.16495F));
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Percent, 27.8350525F));
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Absolute, 74F));
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Absolute, 355F));
            lyt_lihatmatakuliah.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            lyt_lihatmatakuliah.Size = new Size(1078, 620);
            lyt_lihatmatakuliah.TabIndex = 0;
            // 
            // lbl_carimatkulkonversisks
            // 
            lbl_carimatkulkonversisks.AutoSize = true;
            lbl_carimatkulkonversisks.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_carimatkulkonversisks.Location = new Point(3, 0);
            lbl_carimatkulkonversisks.Name = "lbl_carimatkulkonversisks";
            lbl_carimatkulkonversisks.Size = new Size(839, 40);
            lbl_carimatkulkonversisks.TabIndex = 0;
            lbl_carimatkulkonversisks.Text = "Rekomendasi Mata Kuliah Sesuai Program Mitra";
            // 
            // btn_kembalikonversisks
            // 
            btn_kembalikonversisks.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btn_kembalikonversisks.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_kembalikonversisks.Location = new Point(976, 379);
            btn_kembalikonversisks.Name = "btn_kembalikonversisks";
            btn_kembalikonversisks.Size = new Size(116, 35);
            btn_kembalikonversisks.TabIndex = 3;
            btn_kembalikonversisks.Text = "Kembali";
            btn_kembalikonversisks.UseVisualStyleBackColor = true;
            btn_kembalikonversisks.Click += button2_Click;
            // 
            // pnl_carimatkul
            // 
            pnl_carimatkul.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnl_carimatkul.Controls.Add(tbl_matkulkonversisks);
            pnl_carimatkul.Controls.Add(btn_kembalikonversisks);
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
            // v_CariMataKuliah
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1156, 666);
            Controls.Add(pnl_carimatkul);
            Controls.Add(lyt_lihatmatakuliah);
            Font = new Font("Microsoft Sans Serif", 7.875F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "v_CariMataKuliah";
            Text = "Baskom";
            WindowState = FormWindowState.Maximized;
            lyt_lihatmatakuliah.ResumeLayout(false);
            lyt_lihatmatakuliah.PerformLayout();
            pnl_carimatkul.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbl_matkulkonversisks).EndInit();
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
    }
}