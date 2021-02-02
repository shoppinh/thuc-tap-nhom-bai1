using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giao_dien
{
    public partial class frmThemNV : Form
    {
        public frmThemNV(string msv)
        {
            this.msv = msv;
            InitializeComponent();

        }

        private string msv;

        private void frmThemNV_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Mã SV nhận được: " + msv);
            Database db = new Database();
            string getAllMaNGS = "SELECT TenNV FROM NHANVIEN";
            string getAllMaPB = "SELECT TenPB FROM PHONGBAN";
            DataTable TenNGSTable = db.SelectData(getAllMaNGS);
            DataTable TenPBTable = db.SelectData(getAllMaPB);
            cbTenNGS.DataSource = TenNGSTable.Copy();
            cbTenNGS.DisplayMember = "TenNV";
            cbTenNGS.ValueMember = "TenNV";
            cbTenPB.DataSource = TenPBTable.Copy();
            cbTenPB.DisplayMember = "TenPB";
            cbTenPB.ValueMember = "TenPB";
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Thêm mới nhân viên";
            }
            else
            {
                this.Text = "Cập nhật thông tin nhân viên";
               
                var r = new Database().Select(string.Format("selectNV '" + msv + "'"));
                //MessageBox.Show(r[0].ToString());

                txtTenNV.Text = r["TenNV"].ToString();
                //mtbNS.Text = r["NgaySinh"].ToString();
                dtpBirthday.Value = DateTime.ParseExact(r["NgaySinh"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                txtDC.Text = r["DiaChi"].ToString();
                if (r["GioiTinh"].ToString() == "Nam")
                {
                    rbtNam.Checked = true;
                }
                else
                {
                    rbtNu.Checked = true;
                }
                txtLuong.Text = r["Luong"].ToString();
                //cbTenNGS.SelectedText = r["TenNGS"].ToString();
                //cbTenPB.SelectedText = r["TenPB"].ToString();
            }
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string sql;
            string TenNV = txtTenNV.Text;
            DateTime NgaySinh = dtpBirthday.Value;
            //try
            //{
                //NgaySinh = DateTime.ParseExact(mtbNS.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Ngày sinh không hợp lệ!");
            //    //mtbNS.Select();
            //    return;
            //}
            string DiaChi = txtDC.Text;
            string GioiTinh = rbtNam.Checked ? "Nam" : "Nu";
            string Luong = txtLuong.Text;
            //string MaNGS = txtMaNGS.Text;
            //string MaPB = txtMaPB.Text;
            DataRowView drvTenNGS = (DataRowView)cbTenNGS.SelectedItem;
            string TenNGS = drvTenNGS.Row.Field<string>("TenNV");
            DataRowView drvTenPB = (DataRowView)cbTenPB.SelectedItem;
            string TenPB = drvTenPB.Row.Field<string>("TenPB");
            Database db = new Database();
            string sql1 = "SELECT MaNV FROM NHANVIEN WHERE TenNV = N'" + TenNGS + "'";
            string sql2 = "SELECT MaPB FROM PHONGBAN WHERE TenPB = N'" + TenPB + "'";
            string MaNGS = db.Select(sql1).Field<string>("MaNV");
            string MaPB = db.Select(sql2).Field<string>("MaPB");

            List<CustomParameter> lstPara = new List<CustomParameter>();

            if (string.IsNullOrEmpty(msv))
            {
                sql = "ThemMoiNV";
            }
            else
            {
                sql = "UpdateNV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MaNV",
                    value = msv
                });
            }

            lstPara.Add(new CustomParameter()
            {
                key = "@TenNV",
                value = TenNV
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@NS",
                value = NgaySinh.ToString("yyyy-MM-dd")
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@DC",
                value = DiaChi
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@GT",
                value = GioiTinh
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@Luong",
                value = Luong
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@MaNGS",
                value = MaNGS
            });

            lstPara.Add(new CustomParameter()
            {
                key = "@MaPB",
                value = MaPB
            });

            var rs = new Database().ExeCute(sql, lstPara);
            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Thêm mới thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Thao tác không thành công");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
