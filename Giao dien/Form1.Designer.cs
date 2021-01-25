namespace Giao_dien
{
    partial class frmDangNhap
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
            this.txbTenTruyCap = new System.Windows.Forms.TextBox();
            this.txbMatKhau = new System.Windows.Forms.TextBox();
            this.lbTenTruyCap = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.btnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lilbHuongDan = new System.Windows.Forms.LinkLabel();
            this.lilbTaiKhoan = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // txbTenTruyCap
            // 
            this.txbTenTruyCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTenTruyCap.Location = new System.Drawing.Point(375, 175);
            this.txbTenTruyCap.Name = "txbTenTruyCap";
            this.txbTenTruyCap.Size = new System.Drawing.Size(214, 24);
            this.txbTenTruyCap.TabIndex = 0;
            // 
            // txbMatKhau
            // 
            this.txbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMatKhau.Location = new System.Drawing.Point(375, 272);
            this.txbMatKhau.Name = "txbMatKhau";
            this.txbMatKhau.PasswordChar = '*';
            this.txbMatKhau.Size = new System.Drawing.Size(214, 24);
            this.txbMatKhau.TabIndex = 1;
            // 
            // lbTenTruyCap
            // 
            this.lbTenTruyCap.AutoSize = true;
            this.lbTenTruyCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTenTruyCap.Location = new System.Drawing.Point(216, 175);
            this.lbTenTruyCap.Name = "lbTenTruyCap";
            this.lbTenTruyCap.Size = new System.Drawing.Size(89, 18);
            this.lbTenTruyCap.TabIndex = 1;
            this.lbTenTruyCap.Text = "Tên truy cập";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMatKhau.Location = new System.Drawing.Point(216, 272);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(69, 18);
            this.lbMatKhau.TabIndex = 1;
            this.lbMatKhau.Text = "Mật khẩu";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.Location = new System.Drawing.Point(260, 387);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.Size = new System.Drawing.Size(127, 29);
            this.btnDangNhap.TabIndex = 2;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.UseVisualStyleBackColor = true;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(494, 387);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(127, 29);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lilbHuongDan
            // 
            this.lilbHuongDan.AutoSize = true;
            this.lilbHuongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilbHuongDan.Location = new System.Drawing.Point(844, 24);
            this.lilbHuongDan.Name = "lilbHuongDan";
            this.lilbHuongDan.Size = new System.Drawing.Size(46, 18);
            this.lilbHuongDan.TabIndex = 5;
            this.lilbHuongDan.TabStop = true;
            this.lilbHuongDan.Text = "About";
            this.lilbHuongDan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilbHuongDan_LinkClicked);
            // 
            // lilbTaiKhoan
            // 
            this.lilbTaiKhoan.AutoSize = true;
            this.lilbTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lilbTaiKhoan.Location = new System.Drawing.Point(719, 24);
            this.lilbTaiKhoan.Name = "lilbTaiKhoan";
            this.lilbTaiKhoan.Size = new System.Drawing.Size(73, 18);
            this.lilbTaiKhoan.TabIndex = 6;
            this.lilbTaiKhoan.TabStop = true;
            this.lilbTaiKhoan.Text = "Tài khoản";
            this.lilbTaiKhoan.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lilbTaiKhoan_LinkClicked);
            // 
            // frmDangNhap
            // 
            this.AcceptButton = this.btnDangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnThoat;
            this.ClientSize = new System.Drawing.Size(1006, 636);
            this.Controls.Add(this.lilbTaiKhoan);
            this.Controls.Add(this.lilbHuongDan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangNhap);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbTenTruyCap);
            this.Controls.Add(this.txbMatKhau);
            this.Controls.Add(this.txbTenTruyCap);
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbTenTruyCap;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label lbTenTruyCap;
        private System.Windows.Forms.Label lbMatKhau;
        private System.Windows.Forms.Button btnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.LinkLabel lilbHuongDan;
        private System.Windows.Forms.LinkLabel lilbTaiKhoan;
    }
}

