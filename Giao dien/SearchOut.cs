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
        string sqlSearch;
        public frmSearchOut()
        {
            InitializeComponent();
        }

        public frmSearchOut(string sql)
        {
            sqlSearch = sql;
            InitializeComponent(); 
        }


        private void LoadDSNV()
        {
            dvgSearch.DataSource = null;
            dvgSearch.DataSource = new Database().SelectData(sqlSearch);
            dvgSearch.Columns["MaNV"].HeaderText = "Mã NV";
            dvgSearch.Columns["TenNV"].HeaderText = "Tên NV";
            dvgSearch.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dvgSearch.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dvgSearch.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dvgSearch.Columns["Luong"].HeaderText = "Lương";
            dvgSearch.Columns["MaNGS"].HeaderText = "Mã NGS";
            dvgSearch.Columns["MaPB"].HeaderText = "Mã PB";
        }

        private void frmSearchOut_Load(object sender, EventArgs e)
        {
            LoadDSNV();
        }
    }
}
