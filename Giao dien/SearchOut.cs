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
        int keySearch;
        string valueSearch;
        public frmSearchOut()
        {
            InitializeComponent();
        }

        public frmSearchOut(int keysearch1,string value)
        {
            InitializeComponent();
            valueSearch = value;
            keySearch = keysearch1;
        }

        private void LoadDSNV()
        {
            dvgSearch.DataSource = null;
            //var db = new Database();
            if (keySearch == 0)
            {
                dvgSearch.DataSource = new Database().SelectData("exec searchMNV '" + valueSearch + "'");
            }else if (keySearch == 1)
            {
                dvgSearch.DataSource = new Database().SelectData("exec searchTNV N'" + valueSearch + "'");
            }else if (keySearch == 2)
            {
                dvgSearch.DataSource = new Database().SelectData("exec searchNVfromTPB N'" + valueSearch + "'");
            }

            dvgSearch.Columns["MaNV"].HeaderText = "Mã NV";
            dvgSearch.Columns["TenNV"].HeaderText = "Tên NV";
            dvgSearch.Columns["NgaySinh"].HeaderText = "Ngày Sinh";
            dvgSearch.Columns["DiaChi"].HeaderText = "Địa Chỉ";
            dvgSearch.Columns["GioiTinh"].HeaderText = "Giới Tính";
            dvgSearch.Columns["Luong"].HeaderText = "Lương";
            dvgSearch.Columns["MaNGS"].HeaderText = "Mã NGS";
            dvgSearch.Columns["MaPB"].HeaderText = "Mã PB";
        }

        private void SearchOut_Load(object sender, EventArgs e)
        {
            LoadDSNV();
        }
    }
}
