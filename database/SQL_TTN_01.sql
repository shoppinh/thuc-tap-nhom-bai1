﻿use TT_Nhom1

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
----------------------------------------------------------------------------------------------------
select * from NHANVIEN;
----------------------------------------------------------------------------------------------------
--tao sequence tu dong tang cho danh ma NV tu dong
create sequence sinhvienSeq
	start with 1000 --bat dau tu 1000
	increment by 1; --moi lan tang 1 don vi
----------------------------------------------------------------------------------------------------
	select next value for sinhvienSeq
----------------------------------------------------------------------------------------------------
insert into PHONGBAN(MaPB,TenPB)values('PB01',N'Thông Tin')
insert into PHONGBAN(MaPB,TenPB)values('PB02',N'Tài Chính')
insert into PHONGBAN(MaPB,TenPB)values('PB03',N'Nhân sự')
----------------------------------------------------
insert into NHANVIEN
(
	MaNV,
	TenNV,
	NgaySinh,
	DiaChi,
	GioiTinh,
	Luong,
	MaPB
)values(
	'17KS' + cast(next value for sinhvienSeq as char(10)),
	N'Mạc Trung Kiên',
	'2000-01-01',
	N'Hà Nội',
	N'Nam',
	20000000,
	'PB01'
);
------------------------------------------------------
select * from NHANVIEN;
select * from PHONGBAN
------------------------------------------------------
insert into NHANVIEN
(
	MaNV,
	TenNV,
	NgaySinh,
	DiaChi,
	GioiTinh,
	Luong,
	MaPB
)values(
	'17KS' + cast(next value for sinhvienSeq as char(10)),
	N'Bùi Doãn Hưng',
	'2000-02-01',
	N'Hà Nội',
	N'Nam',
	20000000,
	'PB02'
);
-----------------------------------------------------
insert into NHANVIEN
(
	MaNV,
	TenNV,
	NgaySinh,
	DiaChi,
	GioiTinh,
	Luong,
	MaPB
)values(
	'17KS' + cast(next value for sinhvienSeq as char(10)),
	N'Nguyễn Hoàng Lam',
	'2000-06-01',
	N'Hà Nội',
	N'Nam',
	20000000,
	'PB03'
);
----------------------------------------------------
select MaNV, TenNV, convert(varchar(10),NgaySinh,103), DiaChi, GioiTinh, Luong, MaNGS, MaPB from NHANVIEN; --dinh dang NS theo dd/mm/yyyy
----------------------------------------------------

create procedure SelectAllNV
as
	select MaNV, TenNV, convert(varchar(10),NgaySinh,103) as NgaySinh, DiaChi, GioiTinh, Luong, MaNGS, MaPB from NHANVIEN
go;

----------------------------------------------------
exec SelectAllNV
----------------------------------------------------

create procedure ThemMoiNV
	--@MaNV char(10),
	@TenNV nvarchar(45),
	@NS datetime,
	@DC nvarchar(45),
	@GT char(3),
	@Luong int,
	@MaNGS char(10),
	@MaPB char(10)
as 
begin
	insert into NHANVIEN
	(
		MaNV,TenNV,NgaySinh,DiaChi,GioiTinh,Luong,MaNGS,MaPB
	)values(
		'17KS' + CAST(next value for sinhvienSeq as char(10)),
		@TenNV,
		@NS,
		@DC,
		@GT,
		@Luong,
		@MaNGS,
		@MaPB
		);

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end

----------------------------------------------
exec ThemMoiNV 'Nguyễn Thanh Tùng','2000-10-08','Hà Nội','Nam',10000000,'17KS1001','PB01'

----------------------------------------------

create procedure UpdateNV
	@MaNV char(10),
	@TenNV nvarchar(45),
	@NS datetime,
	@DC nvarchar(45),
	@GT char(3),
	@Luong int,
	@MaNGS char(10),
	@MaPB char(10)
as 
begin
	update NHANVIEN
	set 
		TenNV = @TenNV,
		NgaySinh = @NS,
		DiaChi = @DC,
		GioiTinh = @GT,
		Luong = @Luong,
		MaNGS = @MaNGS,
		MaPB = @MaPB
	where MaNV = @MaNV;

		if @@ROWCOUNT > 0 begin return 1 end
		else begin return 0 end;
end
----------------------------------------------

exec UpdateNV '17KS1002','Bùi Doãn Hưng','2000-02-01','Hà Nội','Nam',20000000,'17KS1001','PB02'

----------------------------------------------

create procedure selectNV
	@MaNV char(10)
as
begin 
	select
		TenNV, convert(varchar(10),NgaySinh,103) as NgaySinh, DiaChi, GioiTinh, Luong, MaNGS, MaPB from NHANVIEN
		where MaNV = @MaNV;
end

---------------------------------------------

exec selectNV '17KS1001'


----------------------------------- TIM KIEM THEO MA NV----------------
create procedure searchMNV @MaNV char(10)
as 
begin
	select MaNV, TenNV, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, Luong, MaNGS, MaPB 
	from NHANVIEN
	where MaNV = @MaNV
end

----------------------------------------------
exec searchMNV '17KS1001'




select * from NHANVIEN


----------------------------------- TIM KIEM THEO Ten NV----------------
create procedure searchTNV @TenNV nvarchar(45)
as 
begin
	select MaNV, TenNV, convert(varchar(10),NgaySinh,103) 
	as NgaySinh, DiaChi, GioiTinh, Luong, MaNGS, MaPB 
	from NHANVIEN
	where TenNV = @TenNV
end

----------------------------------------------
exec searchTNV N'Bùi Doãn Hưng'




select * from NHANVIEN

----------------------------------- TIM KIEM Tat ca nhan vien thuoc ten phong ban----------------
create procedure searchNVfromTPB @TenPB nvarchar(45)
as 
begin
	select nv.MaNV, nv.TenNV, convert(varchar(10),nv.NgaySinh,103) 
	as NgaySinh, nv.DiaChi, nv.GioiTinh, nv.Luong, nv.MaNGS,nv.MaPB
	from NHANVIEN as nv, PHONGBAN as pb
	where nv.MaPB = pb.MaPB and pb.TenPB = @TenPB
end

----------------------------------------------
exec searchNVfromTPB N'Tài Chính'




select * from NHANVIEN
select * from PHONGBAN