using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Giao_dien
{
    public partial class frmQuanLy : Form
    {
        List<string> listItem;
        public frmQuanLy()
        {
            InitializeComponent();
            addCombobox();
        }

        public void addCombobox()
        {
            listItem = new List<string>() { "Mã Nhân Viên","Tên Nhân Viên","Tên Phòng Ban" };
            comboTimKiem.DataSource = listItem;
        }

        private void btn2Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
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
            dataGridView1.Columns["TenNGS"].HeaderText = "Tên NGS";
            dataGridView1.Columns["TenPB"].HeaderText = "Tên PB";
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            //{
            //    dataGridView1.Rows.RemoveAt(item.Index);
            //}

            var db = new Database();
            db.del_data(dataGridView1.CurrentRow.Cells["MaNV"].Value.ToString());
            LoadDSNV();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbTimKiem.Text))
            {
                MessageBox.Show("Bạn chưa nhập thông tin tìm kiếm");
            }
            else
            {
                if (comboTimKiem.SelectedValue != null)
                {
                    String valueSearch = txbTimKiem.Text;
                    var db = new Database();
                    if (comboTimKiem.SelectedIndex == 0)
                    {                   
                        if (db.SearchData("searchMNV", 0,valueSearch) != null)
                        {
                            new frmSearchOut(0,valueSearch);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Hello", MessageBoxButtons.YesNoCancel);
                        }
                    }
                    else if (comboTimKiem.SelectedIndex == 1)
                    {
                        if (db.SearchData("searchTNV", 1, valueSearch) != null)
                        {
                            new frmSearchOut(1, valueSearch);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Hello", MessageBoxButtons.YesNoCancel);
                        }
                    }
                    else if (comboTimKiem.SelectedIndex == 2)
                    {
                        if (db.SearchData("searchNVfromTPB", 2, valueSearch) != null)
                        {
                            new frmSearchOut(2, valueSearch);
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy thông tin", "Hello", MessageBoxButtons.YesNoCancel);
                        }
                    }
                }
            }
        }
    }
}
