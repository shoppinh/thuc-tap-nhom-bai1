namespace Giao_dien
{
    partial class frmQuanLy
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.columnMaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnTenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnMaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txbTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.comboTimKiem = new System.Windows.Forms.ComboBox();
            this.btn2Thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnMaNV,
            this.columnTenNV,
            this.columnNgaySinh,
            this.columnDiaChi,
            this.columnGioiTinh,
            this.columnLuong,
            this.columnMaPB});
            this.dataGridView1.Location = new System.Drawing.Point(44, 113);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(929, 292);
            this.dataGridView1.TabIndex = 0;
            // 
            // columnMaNV
            // 
            this.columnMaNV.HeaderText = "Mã NV";
            this.columnMaNV.MinimumWidth = 6;
            this.columnMaNV.Name = "columnMaNV";
            this.columnMaNV.Width = 125;
            // 
            // columnTenNV
            // 
            this.columnTenNV.HeaderText = "Tên NV";
            this.columnTenNV.MinimumWidth = 6;
            this.columnTenNV.Name = "columnTenNV";
            this.columnTenNV.Width = 125;
            // 
            // columnNgaySinh
            // 
            this.columnNgaySinh.HeaderText = "Ngày sinh";
            this.columnNgaySinh.MinimumWidth = 6;
            this.columnNgaySinh.Name = "columnNgaySinh";
            this.columnNgaySinh.Width = 125;
            // 
            // columnDiaChi
            // 
            this.columnDiaChi.HeaderText = "Địa chỉ";
            this.columnDiaChi.MinimumWidth = 6;
            this.columnDiaChi.Name = "columnDiaChi";
            this.columnDiaChi.Width = 125;
            // 
            // columnGioiTinh
            // 
            this.columnGioiTinh.HeaderText = "Giới tính";
            this.columnGioiTinh.MinimumWidth = 6;
            this.columnGioiTinh.Name = "columnGioiTinh";
            this.columnGioiTinh.Width = 125;
            // 
            // columnLuong
            // 
            this.columnLuong.HeaderText = "Lương";
            this.columnLuong.MinimumWidth = 6;
            this.columnLuong.Name = "columnLuong";
            this.columnLuong.Width = 125;
            // 
            // columnMaPB
            // 
            this.columnMaPB.HeaderText = "Mã PB";
            this.columnMaPB.MinimumWidth = 6;
            this.columnMaPB.Name = "columnMaPB";
            this.columnMaPB.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(161, 461);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 38);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(484, 461);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 38);
            this.btnSua.TabIndex = 1;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(795, 461);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 38);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // txbTimKiem
            // 
            this.txbTimKiem.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTimKiem.Location = new System.Drawing.Point(169, 46);
            this.txbTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txbTimKiem.Name = "txbTimKiem";
            this.txbTimKiem.Size = new System.Drawing.Size(316, 21);
            this.txbTimKiem.TabIndex = 3;
            this.txbTimKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTimKiem_KeyPress);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(526, 46);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(65, 21);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // comboTimKiem
            // 
            this.comboTimKiem.FormattingEnabled = true;
            this.comboTimKiem.Items.AddRange(new object[] {
            "Mã nhân viên",
            "Tên nhân viên",
            "Ngày sinh",
            "Địa chỉ",
            "Giới tính",
            "Lương",
            "Mã PB"});
            this.comboTimKiem.Location = new System.Drawing.Point(44, 46);
            this.comboTimKiem.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboTimKiem.Name = "comboTimKiem";
            this.comboTimKiem.Size = new System.Drawing.Size(92, 22);
            this.comboTimKiem.TabIndex = 4;
            // 
            // btn2Thoat
            // 
            this.btn2Thoat.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn2Thoat.Location = new System.Drawing.Point(740, 45);
            this.btn2Thoat.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn2Thoat.Name = "btn2Thoat";
            this.btn2Thoat.Size = new System.Drawing.Size(65, 21);
            this.btn2Thoat.TabIndex = 1;
            this.btn2Thoat.Text = "Thoát";
            this.btn2Thoat.UseVisualStyleBackColor = true;
            this.btn2Thoat.Click += new System.EventHandler(this.btn2Thoat_Click);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btn2Thoat;
            this.ClientSize = new System.Drawing.Size(1028, 595);
            this.Controls.Add(this.comboTimKiem);
            this.Controls.Add(this.txbTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btn2Thoat);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLy";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnTenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnLuong;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txbTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.ComboBox comboTimKiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnMaPB;
        private System.Windows.Forms.Button btn2Thoat;
    }
}