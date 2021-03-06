USE [TT_Nhom1]
GO
/****** Object:  StoredProcedure [dbo].[SelectAllNV]    Script Date: 2/2/2021 10:21:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
----------------------------------------------------

ALTER procedure [dbo].[SelectAllNV]
as
	select NV.MaNV, NV.TenNV, convert(varchar(10),NV.NgaySinh,103) as NgaySinh, NV.DiaChi, NV.GioiTinh, NV.Luong, NGS.TenNV as TenNGS, TenPB
	from NHANVIEN NV
	left join PHONGBAN PB on NV.MaPB = PB.MaPB
	left join NHANVIEN NGS on NV.MaNGS = NGS.MaNV
go

----------------------------------------------------
exec SelectAllNV
