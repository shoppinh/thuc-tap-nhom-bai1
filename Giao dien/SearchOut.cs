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
    public partial class frmSearchOut : Form
    {
        public frmSearchOut()
        {
            InitializeComponent();
        }

        public frmSearchOut(string searchKeyString,string searchValueString)
        {

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

        private void SearchOut_Load(object sender, EventArgs e)
        {
            LoadDSNV();
        }
    }
}
