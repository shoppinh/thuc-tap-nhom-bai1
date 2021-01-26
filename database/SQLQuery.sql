use TT_Nhom1

create table PHONGBAN (
	MaPB char(10) primary key,
	TenPB nvarchar(45),
	MaTP char(10),
	NgayNhanChuc datetime default (getdate())
)

create table NHANVIEN (
	MaNV char(10) primary key,
	TenNV nvarchar(45),
	NgaySinh datetime,
	DiaChi nvarchar(45),
	GioiTinh char(3) check(GioiTinh in ('Nam','Nu')),
	Luong int default(10000000),
	MaNGS char(10),
	MaPB char(10) references PHONGBAN(MaPB)
)
