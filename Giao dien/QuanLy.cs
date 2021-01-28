using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien
{
    public partial class frmQuanLy : Form
    {
        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void btn2Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txbTimKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                // Cái này sẽ bắt phím enter khi đã nhập thông tin tìm kiếm
            }
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            //var db = new Database();
            //dataGridView1.DataSource = db.SelectData(null, null);
            LoadDSNV();

        }

        private void LoadDSNV()
        {
            dataGridView1.DataSource = null;
            //var db = new Database();
            dataGridView1.DataSource = new Database().SelectData("exec SelectAllNV");

            dataGridView1.Columns["MaNV"].HeaderText = "Mã NV";
            dataGridView1.Columns["TenNV"].HeaderText = "Tên NV";
            dataGridView1.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dataGridView1.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dataGridView1.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dataGridView1.Columns["Luong"].HeaderText = "Lương";
            dataGridView1.Columns["MaNGS"].HeaderText = "Mã NGS";
            dataGridView1.Columns["MaPB"].HeaderText = "Mã PB";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                //MessageBox.Show("Mã nhân viên: " + dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString());
                var msv = dataGridView1.Rows[e.RowIndex].Cells["MaNV"].Value.ToString();
                new frmThemNV(msv).ShowDialog();
                LoadDSNV();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            new frmThemNV(null).ShowDialog();
            LoadDSNV();
        }
    }
}
