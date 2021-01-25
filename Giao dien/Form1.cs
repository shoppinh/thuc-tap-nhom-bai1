﻿using System;
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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txbTenTruyCap.Text == "admin" && txbMatKhau.Text == "admin")
            {
                frmQuanLy quanLy = new frmQuanLy();
                quanLy.Visible = true;
            }
            else
            {
                MessageBox.Show("Tên truy cập hoặc mật khẩu sai");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lilbTaiKhoan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Tên truy cập: admin\n" +
                            "Mật khẩu: admin");
        }
        private void lilbHuongDan_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Viết hướng dẫn sử dụng tại đây");
        }
    }
}
