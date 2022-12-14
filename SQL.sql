USE [QL_CAFE]
GO
/****** Object:  Table [dbo].[NguyenLieu]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguyenLieu](
	[MaNL] [int] IDENTITY(1,1) NOT NULL,
	[TenNL] [nvarchar](max) NULL,
	[Gia] [int] NULL,
	[SoLuong] [int] NULL,
	[DVT] [nvarchar](max) NULL,
	[NgayNhap] [datetime] NULL,
	[NgayHet] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] IDENTITY(1,1) NOT NULL,
	[TenNV] [nvarchar](50) NULL,
	[GioiTinh] [nvarchar](50) NULL,
	[SoDT] [char](20) NULL,
	[TaiKhoan] [nvarchar](50) NULL,
	[MatKhau] [nvarchar](50) NULL,
	[ChucVu] [nvarchar](50) NULL,
	[MaQ] [int] NULL,
	[Img] [char](10) NULL,
	[TrangThai] [nvarchar](50) NULL,
	[GioOnl] [char](50) NULL,
	[GioOff] [char](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhomMon]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhomMon](
	[MaN] [int] NOT NULL,
	[TenN] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuDatBan]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuDatBan](
	[MaBan] [int] NOT NULL,
	[TrangThai] [nvarchar](50) NULL,
	[DoUong] [nvarchar](500) NULL,
	[DonGia] [int] NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuyenNV]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuyenNV](
	[MaQ] [int] NOT NULL,
	[TenQ] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQ] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThucDon]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThucDon](
	[MaTD] [int] NOT NULL,
	[Ten] [nvarchar](50) NULL,
	[Gia] [int] NULL,
	[MaN] [int] NULL,
	[Img] [char](20) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TongDoanhThu]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TongDoanhThu](
	[Ngay] [int] NULL,
	[Thang] [int] NULL,
	[TongTien] [int] NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[NguyenLieu] ON 

INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (1, N'Cafe', 500000, 10, N'Bịch', CAST(N'2021-11-25T00:00:00.000' AS DateTime), CAST(N'2021-12-03T00:00:00.000' AS DateTime))
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (2, N'Sữa', 180000, 10, N'Hộp', CAST(N'2021-11-29T00:00:00.000' AS DateTime), CAST(N'2021-12-01T00:00:00.000' AS DateTime))
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (3, N'Trà', 300000, 5, N'Bịch', CAST(N'2021-11-24T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (4, N'Trân Châu', 162000, 10, N'Bịch', CAST(N'2021-11-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (5, N'Đường Đen', 210000, 3, N'Bịch', CAST(N'2021-11-27T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (6, N'Dâu', 180000, 3, N'Kg', CAST(N'2021-11-25T00:00:00.000' AS DateTime), CAST(N'2021-12-03T00:00:00.000' AS DateTime))
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (7, N'Bơ', 250000, 10, N'Kg', CAST(N'2021-11-25T00:00:00.000' AS DateTime), CAST(N'2021-12-03T00:00:00.000' AS DateTime))
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (8, N'Phúc Bồn Tử', 240000, 3, N'Kg', CAST(N'2021-11-23T00:00:00.000' AS DateTime), CAST(N'2021-12-03T00:00:00.000' AS DateTime))
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (9, N'Đào Ngâm', 450000, 6, N'Hộp', CAST(N'2021-11-25T00:00:00.000' AS DateTime), NULL)
INSERT [dbo].[NguyenLieu] ([MaNL], [TenNL], [Gia], [SoLuong], [DVT], [NgayNhap], [NgayHet]) VALUES (10, N'Đào Ngâm', 420000, 6, N'Hộp', CAST(N'2021-11-25T00:00:00.000' AS DateTime), NULL)
SET IDENTITY_INSERT [dbo].[NguyenLieu] OFF
GO
SET IDENTITY_INSERT [dbo].[NhanVien] ON 

INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [SoDT], [TaiKhoan], [MatKhau], [ChucVu], [MaQ], [Img], [TrangThai], [GioOnl], [GioOff]) VALUES (1, N'Kim Quyên', N'Nữ', N'0397495029          ', N'Admin', N'123', N'Admin', 1, N'nv1.png   ', N'offline', N'2:49 CH                                           ', N'2:54 CH                                           ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [SoDT], [TaiKhoan], [MatKhau], [ChucVu], [MaQ], [Img], [TrangThai], [GioOnl], [GioOff]) VALUES (2, N'Minh Nhật', N'Nam', N'0395195732          ', N'nv', N'123', N'nv', 2, N'nv2.jpg   ', N'offline', N'2:29 CH                                           ', N'2:30 CH                                           ')
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [SoDT], [TaiKhoan], [MatKhau], [ChucVu], [MaQ], [Img], [TrangThai], [GioOnl], [GioOff]) VALUES (22, N'Siu Nhân Vàng', N'Nữ', N'039999999           ', N'vang', N'123', N'Kế Toán', 2, N'duck.png  ', N'offline', NULL, NULL)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [GioiTinh], [SoDT], [TaiKhoan], [MatKhau], [ChucVu], [MaQ], [Img], [TrangThai], [GioOnl], [GioOff]) VALUES (25, N'quin', N'Nữ', N'0397495029          ', N'quin', N'123', N'Kế Toán', 2, N'duck.png  ', N'offline', NULL, NULL)
SET IDENTITY_INSERT [dbo].[NhanVien] OFF
GO
INSERT [dbo].[NhomMon] ([MaN], [TenN]) VALUES (1, N'Coffee')
INSERT [dbo].[NhomMon] ([MaN], [TenN]) VALUES (2, N'Trà sữa')
INSERT [dbo].[NhomMon] ([MaN], [TenN]) VALUES (3, N'Yogurt')
INSERT [dbo].[NhomMon] ([MaN], [TenN]) VALUES (4, N'Sữa Tươi')
INSERT [dbo].[NhomMon] ([MaN], [TenN]) VALUES (5, N'Trà trái cây')
INSERT [dbo].[NhomMon] ([MaN], [TenN]) VALUES (6, N'Đá Xay')
GO
INSERT [dbo].[QuyenNV] ([MaQ], [TenQ]) VALUES (1, N'Admin')
INSERT [dbo].[QuyenNV] ([MaQ], [TenQ]) VALUES (2, N'nv')
GO
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (1, N'Coffee Đen', 15000, 1, N'01.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (2, N'Coffee Sữa', 18000, 1, N'02.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (3, N'Bạc Xĩu', 12000, 1, N'03.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (4, N'Coffee Latte', 25000, 1, N'04.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (5, N'Coffee Latte Kem Sữa', 27000, 1, N'05.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (6, N'Cafe Caramel Foam', 25000, 1, N'06.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (7, N'Coffee Dalgona', 25000, 1, N'07.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (8, N'Coffee Cốt Dừa', 24000, 1, N'08.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (9, N'Socola Hạnh Nhân Expresso', 32000, 6, N'09.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (10, N'Matcha Oreo', 30000, 6, N'10.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (11, N'Trà Sữa Truyền Thống', 15000, 2, N'11.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (12, N'Trà Sữa Socola', 17000, 2, N'12.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (13, N'Trà Sữa Matcha', 18000, 2, N'13.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (14, N'Trà Sữa Khoai Tím', 22000, 2, N'14.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (15, N'Trà Sữa Than Tre Chesse Trứng Nướng', 29000, 2, N'15.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (16, N'Trà Sữa Than Tre', 25000, 2, N'16.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (17, N'Trà Sữa Cacao Than Tre', 30000, 2, N'17.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (18, N'Yogurt Việt Quốc', 22000, 3, N'18.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (19, N'Yogurt Phúc Bồn Tử', 22000, 3, N'19.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (20, N'Yogurt Bơ', 22000, 3, N'20.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (21, N'Trà Dâu xinh', 16000, 5, N'21.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (22, N'Trà Lựu Đỏ', 20000, 5, N'22.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (23, N'Yogurt Dâu Rừng', 22000, 3, N'23.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (24, N'Sữa Tươi Trân Châu Đường Đen', 25000, 4, N'24.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (25, N'Sữa Tươi Socola trân Châu Đường Đen', 10000, 4, N'25.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (26, N'Trà Thảo Mộc Hoa Quả', 29000, 5, N'26.JPG              ')
INSERT [dbo].[ThucDon] ([MaTD], [Ten], [Gia], [MaN], [Img]) VALUES (27, N'Trà Mận Đỏ', 29000, 5, N'27.JPG              ')
GO
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (4, 12, 50000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (4, 12, 30000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (5, 12, 27000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (5, 12, 0)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (5, 12, 18000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (5, 12, 22000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (5, 12, 12000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (5, 12, 109000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (6, 12, 22000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (7, 12, 87000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (8, 12, 58000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (13, 12, 32000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (13, 12, 80000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (13, 12, 15000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (13, 12, 54000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (13, 12, 22000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (13, 12, 30000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (13, 12, 75000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (16, 12, 41000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (16, 12, 29000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (5, 12, 25000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (16, 12, 12000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (4, 12, 68000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (13, 12, 24000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (16, 12, 54000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (4, 12, 25000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (5, 12, 49000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (8, 12, 89000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (8, 12, 114000)
INSERT [dbo].[TongDoanhThu] ([Ngay], [Thang], [TongTien]) VALUES (7, 12, 130000)
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD  CONSTRAINT [fk_NhanVien_QuyenNV] FOREIGN KEY([MaQ])
REFERENCES [dbo].[QuyenNV] ([MaQ])
GO
ALTER TABLE [dbo].[NhanVien] CHECK CONSTRAINT [fk_NhanVien_QuyenNV]
GO
ALTER TABLE [dbo].[ThucDon]  WITH CHECK ADD  CONSTRAINT [fk_ThucDon_NhomMon] FOREIGN KEY([MaN])
REFERENCES [dbo].[NhomMon] ([MaN])
GO
ALTER TABLE [dbo].[ThucDon] CHECK CONSTRAINT [fk_ThucDon_NhomMon]
GO
/****** Object:  StoredProcedure [dbo].[Ban_ThanhToanTungBan]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Ban_ThanhToanTungBan]
@ma int 
as
if(@ma = 0)
begin
	select DISTINCT MaBan From PhieuDatBan Where TrangThai = N'Có Khách'
end
else
begin
	select DoUong, DonGia From PhieuDatBan Where MaBan = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[Ban_them]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Ban_them]
@maban int,
@trangthai nvarchar(50),
@douong nvarchar(50),
@dongia int
as
insert into PhieuDatBan(MaBan, TrangThai, DoUong, DonGia) values(@maban, @trangthai, @douong, @dongia)
GO
/****** Object:  StoredProcedure [dbo].[Ban_xemTrangThaiBan]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Ban_xemTrangThaiBan]
@maban int
as
if(@maban = 0)
begin
	select TrangThai from PhieuDatBan 
end
else
begin
	select DISTINCT TrangThai from PhieuDatBan where MaBan = @maban
end
GO
/****** Object:  StoredProcedure [dbo].[Ban_xoaBan]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[Ban_xoaBan]
@maban int
as
delete PhieuDatBan where MaBan = @maban
GO
/****** Object:  StoredProcedure [dbo].[BH_loadThucDon]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[BH_loadThucDon]
@nhom nvarchar(20)
as
if(@nhom = N'Tất Cả')
begin
	select Ten, Gia from ThucDon, NhomMon where ThucDon.MaN=NhomMon.MaN
end
else
begin
	select Ten, Gia from ThucDon, NhomMon where ThucDon.MaN=NhomMon.MaN and NhomMon.TenN = @nhom
end
GO
/****** Object:  StoredProcedure [dbo].[DangXuat]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[DangXuat]
@gioOff char(50)
as
begin
	update NhanVien set TrangThai=N'offline',GioOff=@gioOff from NhanVien where TrangThai=N'online'
end
GO
/****** Object:  StoredProcedure [dbo].[DoiMatKhau]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Proc [dbo].[DoiMatKhau]
@taikhoan nvarchar(50),
@matkhaucu nvarchar(50),
@matkhaumoi nvarchar(50)
as
if(exists(select TaiKhoan From NhanVien where TaiKhoan = @taikhoan and MatKhau = @matkhaucu))
begin
	update NhanVien set MatKhau = @matkhaumoi
	where TaiKhoan = @taikhoan
	select err = 0
end
else
	select err = 1
GO
/****** Object:  StoredProcedure [dbo].[InThucDon]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[InThucDon]
@nhom nvarchar(20)
as
if(@nhom = N'Tất Cả')
begin
	select Ten, Gia,TenN=N'Tất Cả' from ThucDon, NhomMon where ThucDon.MaN=NhomMon.MaN
end
else
begin
	select Ten, Gia,TenN from ThucDon, NhomMon where ThucDon.MaN=NhomMon.MaN and NhomMon.TenN = @nhom
end
GO
/****** Object:  StoredProcedure [dbo].[KiemTra]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[KiemTra]
@taikhoan nvarchar(50),
@matkhau nvarchar(50),
@gioOnl char(50)
as
begin
	update NhanVien set TrangThai=N'online',GioOnl=@gioOnl
	where TaiKhoan = @taikhoan	
end
GO
/****** Object:  StoredProcedure [dbo].[KiemTraDangNhap]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[KiemTraDangNhap]
@taikhoan nvarchar(50),
@matkhau nvarchar(50)
as
if(exists(select TaiKhoan from NhanVien,QuyenNV where TaiKhoan = @taikhoan and MatKhau = @matkhau and QuyenNV.MaQ=1 and NhanVien.MaQ=QuyenNV.MaQ))
begin
	select err = 0
end
if(exists(select TaiKhoan from NhanVien,QuyenNV where TaiKhoan = @taikhoan and MatKhau = @matkhau and QuyenNV.MaQ=2 and NhanVien.MaQ=QuyenNV.MaQ))
		begin
			select err = 1
		end
else 
	select err = 2
GO
/****** Object:  StoredProcedure [dbo].[NL_load]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[NL_load]
as
begin
	select * from NguyenLieu
end

GO
/****** Object:  StoredProcedure [dbo].[NL_sua]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[NL_sua]
@ma int,
@ten nvarchar(50),
@gia int,
@soluong int,
@dvt nvarchar(50),
@ngaynhap datetime,
@ngayhet datetime
as
if(exists(select MaNL From NguyenLieu where MaNL = @ma))
begin
	update NguyenLieu set TenNL = @ten, Gia = @gia, SoLuong = @soluong, DVT = @dvt, NgayNhap = @ngaynhap , NgayHet = @ngayhet
	where MaNL = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[NL_them]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[NL_them]
@ten nvarchar(50),
@gia int,
@soluong int,
@dvt nvarchar(50),
@ngaynhap datetime
as
insert into NguyenLieu(TenNL, Gia, SoLuong, DVT, NgayNhap) values(@ten,@gia,@soluong,@dvt,@ngaynhap)
GO
/****** Object:  StoredProcedure [dbo].[NL_xoa]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[NL_xoa]
@ma int
as
if(exists(select MaNL From NguyenLieu where MaNL = @ma))
begin
	delete NguyenLieu where MaNL = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[NV_load]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[NV_load]
as
begin
	select * from NhanVien
end
GO
/****** Object:  StoredProcedure [dbo].[NV_sua]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[NV_sua]
@ma int,
@ten nvarchar(50),
@gioitinh nvarchar(50),
@sodt char(20),
@taikhoan nvarchar(50),
@matkhau nvarchar(50),
@chucvu nvarchar(50),
@maq int,
@img char(10)
as
if(exists(select MaNV From NhanVien where MaNV = @ma))
begin
	update NhanVien set TenNV = @ten, GioiTinh = @gioitinh, SoDT = @sodt, TaiKhoan = @taikhoan, MatKhau = @matkhau , ChucVu = @chucvu, MaQ=@maq, Img=@img
	where MaNV = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[NV_them]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[NV_them]
@ten nvarchar(50),
@gioitinh nvarchar(50),
@sodt char(20),
@taikhoan nvarchar(50),
@matkhau nvarchar(50),
@chucvu nvarchar(50),
@maq int,
@img char(10)
as
insert into NhanVien(TenNV, GioiTinh, SoDT, TaiKhoan, MatKhau, ChucVu,MaQ,Img, TrangThai) values(@ten,@gioitinh,@sodt,@taikhoan,@matkhau,@chucvu, @maq,@img,N'offline')
GO
/****** Object:  StoredProcedure [dbo].[NV_xoa]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[NV_xoa]
@ma int
as
if(exists(select MaNV From NhanVien where MaNV = @ma))
begin
	delete NhanVien where MaNV = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[TD_load]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TD_load] 
@ma int
as
if(@ma = 0)
	begin
		select MaTD, Ten, Gia,NhomMon.MaN, TenN,Img from ThucDon, NhomMon where ThucDon.MaN=NhomMon.MaN
	end
else
	begin
		select MaTD, Ten, Gia,NhomMon.MaN, TenN,Img from ThucDon, NhomMon where ThucDon.MaN=NhomMon.MaN and MaTD = @ma
	end
GO
/****** Object:  StoredProcedure [dbo].[TD_sua]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TD_sua]
@ma int,
@ten nvarchar(50),
@gia int,
@nhom int,
@img char(20)
as
if(exists(select MaTD from ThucDon where MaTD = @ma))
begin
	update ThucDon
	set Ten = @ten, Gia = @gia, MaN = @nhom,Img = @img
	where MaTD = @ma
end
else
begin
	insert into ThucDon(Ten, Gia, MaN,Img) values(@ten, @gia, @nhom,@img)
end
GO
/****** Object:  StoredProcedure [dbo].[TD_them]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[TD_them]
@matd int,
@ten nvarchar(50),
@gia int,
@man int,
@img char(20)
as
insert into ThucDon(MaTD,Ten,Gia,MaN,Img) values(@matd,@ten,@gia,@man,@img)
GO
/****** Object:  StoredProcedure [dbo].[TD_xoa]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TD_xoa]
@ma int
as
if(exists(select MaTD from ThucDon where MaTD = @ma))
begin
	delete ThucDon
	where MaTD = @ma
end
GO
/****** Object:  StoredProcedure [dbo].[ThanhToan]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[ThanhToan]
@ngay int,
@thang int,
@tongtien int
as
insert into TongDoanhThu(Ngay, Thang, TongTien) values(@ngay, @thang, @tongtien)
GO
/****** Object:  StoredProcedure [dbo].[ThongKe]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[ThongKe]
as
begin
	select Ngay, Thang, TongTien From TongDoanhThu  ORDER BY Ngay
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKe_xoa]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Proc [dbo].[ThongKe_xoa] 
@ma int
as
if(@ma = 0)
begin
	delete TongDoanhThu 
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKeTheoNgay]    Script Date: 16/12/2021 2:58:59 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE Proc [dbo].[ThongKeTheoNgay]
@ngaydau int,
@ngaycuoi int
as
begin
	Select Ngay, Thang, TongTien From TongDoanhThu where (Ngay between @ngaydau and @ngaycuoi)  ORDER BY Ngay
end
GO
