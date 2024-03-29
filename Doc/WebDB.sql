CREATE DATABASE WebDB

USE [WebDB]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/12/2019 8:20:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDHoaDon] [int] NULL,
	[IDSanPham] [int] NULL,
	[TenKhachHang] [nvarchar](100) NULL,
	[ThanhTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/12/2019 8:20:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[IDKhachHang] [int] NULL,
	[Ngay] [varchar](20) NULL,
	[TongTien] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 12/12/2019 8:20:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenKhachHang] [nvarchar](100) NULL,
	[TaiKhoan] [varchar](50) NULL,
	[MatKhau] [varchar](50) NULL,
	[SDT] [varchar](20) NULL,
	[Email] [varchar](50) NULL,
	[VaiTro] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/12/2019 8:20:31 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [varchar](50) NULL,
	[TenSanPham] [nvarchar](50) NULL,
	[Size] [int] NULL,
	[Gia] [int] NULL,
	[Hinh] [varchar](50) NULL,
	[SoLuong] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[KhachHang] ADD  DEFAULT ((1)) FOR [VaiTro]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [HoaDon_ChiTietHoaDon] FOREIGN KEY([IDHoaDon])
REFERENCES [dbo].[HoaDon] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [HoaDon_ChiTietHoaDon]
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD  CONSTRAINT [SanPham_ChiTietHoaDon] FOREIGN KEY([IDSanPham])
REFERENCES [dbo].[SanPham] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ChiTietHoaDon] CHECK CONSTRAINT [SanPham_ChiTietHoaDon]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [KhachHang_HoaDon] FOREIGN KEY([IDKhachHang])
REFERENCES [dbo].[KhachHang] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [KhachHang_HoaDon]
GO


insert into KhachHang(TenKhachHang, TaiKhoan, MatKhau, SDT, Email, VaiTro)
output inserted.ID
values (N'Nguyễn Minh Quang', 'minhquang', '123456', '0396997875', 'minhquangkt@gmail.com', 1);

insert into KhachHang(TenKhachHang, TaiKhoan, MatKhau, SDT, Email, VaiTro)
output inserted.ID
values (N'Lê Thanh Phương', 'thanhphuong', '1234567', '039343242', 'ltthasda@gmail.com', 1);

insert into KhachHang(TenKhachHang, TaiKhoan, MatKhau, SDT, Email, VaiTro)
output inserted.ID
values (N'Nguyễn Văn Toàn', 'vantoan', '123456', '039699533', 'akirqca@gmail.com', 1);

insert into SanPham(TenLoai, TenSanPham, Gia, Hinh,Size,SoLuong)
output inserted.ID
values (N'ad', 'ADIDAS COPA SALA 18.3', '2000000', 'ad1.jpg','39','10')

insert into SanPham(TenLoai, TenSanPham, Gia, Hinh,Size,SoLuong)
output inserted.ID
values (N'ad', 'ADIDAS MESSI 19.3', '2200000', 'ad2.jpg','40','15')

insert into SanPham(TenLoai, TenSanPham, Gia, Hinh,Size,SoLuong)
output inserted.ID
values (N'ad', 'ADIDAS MIMI 8', '1900000', 'ad3.jpg','41','20')

insert into HoaDon(IDKhachHang,Ngay,TongTien)
output inserted.ID
values ('1', '5/12/2019', '1900000')
insert into HoaDon(IDKhachHang,Ngay,TongTien)
output inserted.ID
values ('2', '6/12/2019', '1900000')
insert into HoaDon(IDKhachHang,Ngay,TongTien)
output inserted.ID
values ('3', '7/12/2019', '1900000')
insert into ChiTietHoaDon(IDHoaDon,IDSanPham,TenKhachHang,ThanhTien)
output inserted.ID
values ('1', '1', '1','1900000')
insert into ChiTietHoaDon(IDHoaDon,IDSanPham,TenKhachHang,ThanhTien)
output inserted.ID
values ('2', '2', '2','1900000')
insert into ChiTietHoaDon(IDHoaDon,IDSanPham,TenKhachHang,ThanhTien)
output inserted.ID
values ('3', '3', '3','1900000')