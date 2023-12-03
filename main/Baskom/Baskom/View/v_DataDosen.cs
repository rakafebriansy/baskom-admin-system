using Baskom.Controller;
using Baskom.Model;

namespace Baskom.View
{
    partial class v_DataDosen : Form
    {
        c_Dashboard c_Dashboard;
        c_DataDosen c_DataDosen;

        public v_DataDosen(c_Dashboard c_Dashboard, m_DataAkunDosen m_DataAkunDosen)
        {
            InitializeComponent();
            this.c_Dashboard = c_Dashboard;
            this.c_DataDosen = new c_DataDosen(m_DataAkunDosen);
            this.init();
        }
        public void init()
        {
            tbl_daftardosenadmin.Rows.Clear();
            List<object[]> data_dosen = this.c_DataDosen.initDataGridView();
            foreach (object[] item in data_dosen)
            {
                tbl_daftardosenadmin.Rows.Add(item[3], item[1]);
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void akunDosenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.init();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.ColumnIndex == 2)
            {
                c_Dashboard.setDetailDosen((string)tbl_daftardosenadmin.Rows[index].Cells[1].Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            c_Dashboard.setTambahDosenTimmbkm(this);
            this.init();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void akunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDataMahasiswa();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setDashboardAdmin();
        }

        private void informasiAkunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setProfilAdmin();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tambagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMataKuliah();
        }

        private void mitraToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tambahProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahProgram();
        }

        private void mataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMataKuliah();
        }

        private void tambahMitraProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahMitraProgram();
        }

        private void tambahProgramMataKuliahToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            c_Dashboard.setTambahProgramMataKuliah();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}