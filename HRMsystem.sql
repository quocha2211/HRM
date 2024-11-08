USE [master]
GO
/****** Object:  Database [HRMsystem]    Script Date: 07/11/2024 12:46:05 AM ******/
CREATE DATABASE [HRMsystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'HRMsystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HRMsystem.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HRMsystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HRMsystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [HRMsystem] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HRMsystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HRMsystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HRMsystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HRMsystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HRMsystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HRMsystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [HRMsystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HRMsystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HRMsystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HRMsystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HRMsystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HRMsystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HRMsystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HRMsystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HRMsystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HRMsystem] SET  ENABLE_BROKER 
GO
ALTER DATABASE [HRMsystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HRMsystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HRMsystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HRMsystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HRMsystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HRMsystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HRMsystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HRMsystem] SET RECOVERY FULL 
GO
ALTER DATABASE [HRMsystem] SET  MULTI_USER 
GO
ALTER DATABASE [HRMsystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HRMsystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [HRMsystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [HRMsystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [HRMsystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [HRMsystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'HRMsystem', N'ON'
GO
ALTER DATABASE [HRMsystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [HRMsystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [HRMsystem]
GO
/****** Object:  Table [dbo].[BangLuong]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangLuong](
	[MaBangL] [int] IDENTITY(1,1) NOT NULL,
	[MaCCTL] [int] NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[HSL] [float] NOT NULL,
	[HSPC] [float] NOT NULL,
	[MaMLTT] [int] NULL,
	[MucLuongTTV] [int] NOT NULL,
	[MucLuongTTC] [float] NOT NULL,
	[NgayCong] [float] NOT NULL,
	[MucLuongCoSo] [float] NOT NULL,
	[PhuCapTTCV] [float] NOT NULL,
	[TienLuongBQMN] [float] NOT NULL,
	[LuongThoiGian] [float] NOT NULL,
	[NgayHuongCong100PT] [real] NOT NULL,
	[TienAnGiuaCa] [float] NOT NULL,
	[CongK3] [real] NOT NULL,
	[TienK3] [float] NOT NULL,
	[CongTgNgayThuong] [real] NULL,
	[CongTGNgayNghi] [real] NULL,
	[CongTGNgayLe] [real] NULL,
	[TienThuong] [float] NULL,
	[MaDMXX] [int] NULL,
	[LeTet] [float] NULL,
	[GhiChuLeTet] [nvarchar](150) NULL,
	[TongLuong] [float] NOT NULL,
	[TruBHYT] [float] NOT NULL,
	[TruBHXH] [float] NOT NULL,
	[TruBHTN] [float] NOT NULL,
	[SoTienConNhan] [float] NOT NULL,
	[MucThue] [int] NOT NULL,
	[ThuePhaiNop] [float] NOT NULL,
	[ThueCaNam] [float] NOT NULL,
	[TamUng] [float] NULL,
	[TongThucNhan] [float] NOT NULL,
	[MaPB] [int] NULL,
	[MaChucVu] [int] NULL,
	[MaNV] [int] NULL,
	[MaND] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBangL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BangTamUng]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BangTamUng](
	[MaBTU] [int] IDENTITY(1,1) NOT NULL,
	[NgayTU] [date] NOT NULL,
	[Thang] [int] NOT NULL,
	[Nam] [int] NOT NULL,
	[SoTienTU] [float] NOT NULL,
	[DienGiai] [nvarchar](150) NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBTU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChamCongTL]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChamCongTL](
	[MaCCTL] [int] IDENTITY(1,1) NOT NULL,
	[TenCCTL] [nvarchar](150) NOT NULL,
	[Nam] [int] NOT NULL,
	[Thang] [int] NOT NULL,
	[Khoa] [bit] NULL,
	[NgayTinhCong] [date] NULL,
	[NgayCongTrongThang] [float] NULL,
	[TrangThai] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCCTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucNangPhanMem]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucNangPhanMem](
	[MaCN] [int] IDENTITY(1,1) NOT NULL,
	[TenCN] [nvarchar](100) NOT NULL,
	[DienGiai] [nvarchar](100) NULL,
	[MaND] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucVu]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucVu](
	[MaChucVu] [int] IDENTITY(1,1) NOT NULL,
	[TenChucVu] [nvarchar](150) NOT NULL,
	[CapDo] [int] NOT NULL,
	[HeSoChucDanh] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChungChi]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChungChi](
	[MaCC] [int] IDENTITY(1,1) NOT NULL,
	[TenCC] [nvarchar](100) NOT NULL,
	[MaNV] [int] NULL,
	[NgayCap] [date] NOT NULL,
	[NgayHetHan] [date] NOT NULL,
	[NoiCap] [nvarchar](200) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChuyenMon]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChuyenMon](
	[MaCM] [int] IDENTITY(1,1) NOT NULL,
	[TenCM] [nvarchar](150) NOT NULL,
	[MaTDCM] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanToc]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanToc](
	[MaDT] [int] IDENTITY(1,1) NOT NULL,
	[TenDT] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DienBienTrangThaiLamViec]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienBienTrangThaiLamViec](
	[MaDBTTLV] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[MaPB] [int] NULL,
	[MaCV] [int] NULL,
	[MaTTLV] [int] NULL,
	[TrangThai] [nvarchar](100) NOT NULL,
	[TuNgay] [date] NOT NULL,
	[DenNgay] [date] NOT NULL,
	[SoQD] [nvarchar](50) NOT NULL,
	[NgayQD] [date] NOT NULL,
	[TroCapThoiViec] [int] NOT NULL,
	[GhiChu] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDBTTLV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DieuChuyenCongTac]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DieuChuyenCongTac](
	[MaCCT] [int] IDENTITY(1,1) NOT NULL,
	[NgayChuyen] [date] NOT NULL,
	[SoQD] [nvarchar](10) NOT NULL,
	[MaPB] [int] NULL,
	[MaChucVu] [int] NULL,
	[MaHD] [int] NULL,
	[MaNV] [int] NULL,
	[MaBL] [int] NULL,
	[GhiChu] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaCCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DinhMucXangXe]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DinhMucXangXe](
	[MaDMXX] [int] IDENTITY(1,1) NOT NULL,
	[TenPTien] [nvarchar](150) NULL,
	[DMXX] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaDMXX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[GiaHanHopDong]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GiaHanHopDong](
	[MaGHHD] [int] IDENTITY(1,1) NOT NULL,
	[NgayGiaHan] [date] NOT NULL,
	[NgayHetHanCu] [date] NOT NULL,
	[NgayHetHanMoi] [date] NOT NULL,
	[MaHD] [int] NULL,
	[MaNV] [int] NULL,
	[GhiChu] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaGHHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HeSoThangBacLuong]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeSoThangBacLuong](
	[MaBL] [int] IDENTITY(1,1) NOT NULL,
	[MaTL] [int] NULL,
	[NgayQD] [date] NOT NULL,
	[Bac1] [float] NULL,
	[Bac2] [float] NULL,
	[Bac3] [float] NULL,
	[Bac4] [float] NULL,
	[Bac5] [float] NULL,
	[Bac6] [float] NULL,
	[Bac7] [float] NULL,
	[Bac8] [float] NULL,
	[Bac9] [float] NULL,
	[Bac10] [float] NULL,
	[Bac11] [float] NULL,
	[Bac12] [float] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaBL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HopDong]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HopDong](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[MaLoaiHD] [int] NULL,
	[MaNV] [int] NULL,
	[NgayKy] [date] NOT NULL,
	[NgayHetHan] [date] NOT NULL,
	[ThoiHan] [int] NOT NULL,
	[NguoiKy] [nvarchar](100) NOT NULL,
	[MaBL] [int] NULL,
	[MaTL] [int] NULL,
	[MaChucVu] [int] NULL,
	[NoiCap] [nvarchar](200) NOT NULL,
	[GhiChu] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhenThuongKyLuat]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhenThuongKyLuat](
	[MaHD] [int] IDENTITY(1,1) NOT NULL,
	[SoQD] [int] NOT NULL,
	[NgayQD] [date] NOT NULL,
	[TenKTKL] [nvarchar](200) NOT NULL,
	[LyDo] [nvarchar](100) NOT NULL,
	[HinhThuc] [nvarchar](200) NOT NULL,
	[DonviKTKL] [nvarchar](150) NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiHopDong]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiHopDong](
	[MaLoaiHD] [int] IDENTITY(1,1) NOT NULL,
	[TenLoaiHD] [nvarchar](150) NOT NULL,
	[GhiChu] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaLoaiHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MucLuongToiThieu]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MucLuongToiThieu](
	[MaMLTT] [int] IDENTITY(1,1) NOT NULL,
	[NgayAD] [date] NOT NULL,
	[MLTTVung] [int] NOT NULL,
	[MLTTC] [float] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaMLTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NganHang]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NganHang](
	[MaNH] [int] IDENTITY(1,1) NOT NULL,
	[TenDayDu] [nvarchar](200) NOT NULL,
	[VietTat] [nvarchar](50) NOT NULL,
	[MaChungKhoan] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NgoaiNgu]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NgoaiNgu](
	[MaNN] [int] IDENTITY(1,1) NOT NULL,
	[TenNN] [nvarchar](100) NOT NULL,
	[MaTDNN] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NguoiDung]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDung](
	[MaND] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](100) NOT NULL,
	[MatKhau] [nvarchar](100) NOT NULL,
	[MaChucVu] [int] NULL,
	[Quyen] [nvarchar](100) NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaND] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [int] NOT NULL,
	[TenNV] [nvarchar](150) NOT NULL,
	[BiDanh] [nvarchar](50) NOT NULL,
	[GioiTinh] [nvarchar](5) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[QueQuan] [nvarchar](150) NOT NULL,
	[NoiSinh] [nvarchar](100) NOT NULL,
	[NoiOHienTai] [nvarchar](150) NOT NULL,
	[SoCCCD] [varchar](15) NOT NULL,
	[NgayCap] [date] NOT NULL,
	[NoiCap] [nvarchar](100) NOT NULL,
	[Email] [nvarchar](70) NOT NULL,
	[SoDienThoai] [nvarchar](100) NOT NULL,
	[Anh] [image] NULL,
	[NgayVaoDoan] [date] NOT NULL,
	[NoiVaoDoan] [nvarchar](150) NOT NULL,
	[NgayVaoDang] [date] NOT NULL,
	[NoiVaoDang] [nvarchar](150) NOT NULL,
	[NgayVaoLam] [date] NOT NULL,
	[NgayRoiCoQuan] [date] NULL,
	[LyDo] [nvarchar](150) NULL,
	[HeSoLuong] [float] NULL,
	[HeSoPhuCap] [float] NULL,
	[HeSoTNVK] [float] NULL,
	[SoSocBH] [int] NOT NULL,
	[NgayCapSo] [date] NOT NULL,
	[NoiCapSo] [nvarchar](150) NOT NULL,
	[SoThe] [varchar](30) NOT NULL,
	[SoTaiKhoan] [varchar](20) NOT NULL,
	[NganHang] [nvarchar](100) NOT NULL,
	[TinhTrangHonNhan] [bit] NOT NULL,
	[TinhTrangSuckhoe] [nvarchar](50) NOT NULL,
	[ChieuCao] [float] NOT NULL,
	[CanNang] [float] NOT NULL,
	[NhomMau] [nvarchar](50) NOT NULL,
	[NgayNhapNgu] [date] NULL,
	[NgayXuatNgu] [date] NULL,
	[QuanHamCaoNhat] [nvarchar](50) NULL,
	[ThoiGianNangBacHSL] [int] NULL,
	[KhongChoPhepNangLuong] [bit] NULL,
	[RoiCoQuan] [bit] NULL,
	[NghiHuu] [bit] NULL,
	[LuongCoSo] [float] NULL,
	[MaDMXX] [int] NULL,
	[MaTG] [int] NULL,
	[MaChucVu] [int] NULL,
	[MaXL] [int] NULL,
	[MaTT] [int] NULL,
	[MaTDVH] [int] NULL,
	[MaDT] [int] NULL,
	[MaCM] [int] NULL,
	[MaNN] [int] NULL,
	[MaTDLLCT] [int] NULL,
	[MaTTLV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhongBan]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhongBan](
	[MaPB] [int] IDENTITY(1,1) NOT NULL,
	[TenPB] [nvarchar](150) NOT NULL,
	[CapDo] [int] NOT NULL,
	[DoTuoiVeHuuNam] [int] NULL,
	[DoTuoiVeHuuNu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuanHeThanNhan]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuanHeThanNhan](
	[MaQHTN] [int] IDENTITY(1,1) NOT NULL,
	[TenQHTN] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQHTN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTrinhCongTac]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTrinhCongTac](
	[MaQTCT] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[MaPB] [int] NULL,
	[MaChucVu] [int] NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayKetThuc] [date] NOT NULL,
	[Ngay] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQTCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTrinhDaoTao]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTrinhDaoTao](
	[MaQTDT] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[NgayBatDau] [date] NOT NULL,
	[NgayHetHan] [date] NOT NULL,
	[TruongDaoTao] [nvarchar](150) NOT NULL,
	[NuocDaoTao] [varchar](10) NOT NULL,
	[NganhDaoTao] [nvarchar](200) NOT NULL,
	[HinhThucDaoTao] [varchar](10) NOT NULL,
	[TrinhDoDaoTao] [nvarchar](100) NOT NULL,
	[MaPB] [int] NULL,
	[MaChucVu] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQTDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[QuaTrinhLuong]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[QuaTrinhLuong](
	[MaQTL] [int] IDENTITY(1,1) NOT NULL,
	[NgayQD] [date] NOT NULL,
	[NgayHuong] [date] NOT NULL,
	[NgayNangCapLuong] [date] NOT NULL,
	[MaBL] [int] NULL,
	[HSL] [float] NULL,
	[HSPC] [float] NULL,
	[MaMLTT] [int] NULL,
	[MaNV] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaQTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThangLuong]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThangLuong](
	[MaTL] [int] IDENTITY(1,1) NOT NULL,
	[TenTL] [nvarchar](150) NOT NULL,
	[DienGiai] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ThanNhan]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanNhan](
	[MaTN] [int] IDENTITY(1,1) NOT NULL,
	[HoVaTen] [nvarchar](50) NOT NULL,
	[NgaySinh] [date] NOT NULL,
	[NgheNghiep] [nvarchar](150) NOT NULL,
	[NoiO] [nvarchar](150) NOT NULL,
	[MaQHTN] [int] NULL,
	[MaNV] [int] NULL,
	[GhiChu] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TinhThanh]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TinhThanh](
	[MaTT] [int] IDENTITY(1,1) NOT NULL,
	[TenTT] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TonGiao]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TonGiao](
	[MaTG] [int] IDENTITY(1,1) NOT NULL,
	[TenTG] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrangThaiLamViec]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThaiLamViec](
	[MaTTLV] [int] IDENTITY(1,1) NOT NULL,
	[TenTTLV] [nvarchar](100) NOT NULL,
	[KyHieu] [varchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTTLV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDoChuyenMon]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDoChuyenMon](
	[MaTDCM] [int] IDENTITY(1,1) NOT NULL,
	[TenTDCM] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTDCM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDoLyLuanChinhTri]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDoLyLuanChinhTri](
	[MaTDLLCT] [int] IDENTITY(1,1) NOT NULL,
	[TenTDLLCT] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTDLLCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDoNgoaiNgu]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDoNgoaiNgu](
	[MaTDNN] [int] IDENTITY(1,1) NOT NULL,
	[TenTDNN] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTDNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TrinhDoVanHoa]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrinhDoVanHoa](
	[MaTDVH] [int] IDENTITY(1,1) NOT NULL,
	[TenTDVH] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaTDVH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XepLoai]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XepLoai](
	[MaXL] [int] IDENTITY(1,1) NOT NULL,
	[TenXL] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[XepLoaiCanBo]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[XepLoaiCanBo](
	[MaXLCB] [int] IDENTITY(1,1) NOT NULL,
	[MaNV] [int] NULL,
	[XepLoai] [varchar](100) NOT NULL,
	[DanhHieu] [nvarchar](100) NOT NULL,
	[MaPB] [int] NULL,
	[GhiChu] [nvarchar](150) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaXLCB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ChamCongTL] ON 

INSERT [dbo].[ChamCongTL] ([MaCCTL], [TenCCTL], [Nam], [Thang], [Khoa], [NgayTinhCong], [NgayCongTrongThang], [TrangThai]) VALUES (1, N'Chấm công tháng 1', 2023, 1, 1, CAST(N'2023-01-31' AS Date), 26, 1)
SET IDENTITY_INSERT [dbo].[ChamCongTL] OFF
GO
SET IDENTITY_INSERT [dbo].[ChucVu] ON 

INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (1, N'Tổng Giám đốc', 1, 4.5)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (2, N'Phó Tổng Giám đốc', 2, 4)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (3, N'Giám đốc', 3, 3.5)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (4, N'Phó Giám đốc', 4, 3)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (5, N'Trưởng phòng', 5, 2.5)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (6, N'Phó Trưởng phòng', 6, 2.2)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (7, N'Quản lý', 7, 2)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (8, N'Chuyên viên cao cấp', 8, 1.8)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (9, N'Chuyên viên chính', 9, 1.5)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (10, N'Chuyên viên', 10, 1.2)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (11, N'Nhân viên', 11, 1)
INSERT [dbo].[ChucVu] ([MaChucVu], [TenChucVu], [CapDo], [HeSoChucDanh]) VALUES (12, N'Thực tập sinh', 12, 0.5)
SET IDENTITY_INSERT [dbo].[ChucVu] OFF
GO
SET IDENTITY_INSERT [dbo].[ChuyenMon] ON 

INSERT [dbo].[ChuyenMon] ([MaCM], [TenCM], [MaTDCM]) VALUES (1, N'Kỹ sư phần mềm', 2)
INSERT [dbo].[ChuyenMon] ([MaCM], [TenCM], [MaTDCM]) VALUES (2, N'Kế toán', 1)
INSERT [dbo].[ChuyenMon] ([MaCM], [TenCM], [MaTDCM]) VALUES (3, N'Quản trị kinh doanh', 2)
SET IDENTITY_INSERT [dbo].[ChuyenMon] OFF
GO
SET IDENTITY_INSERT [dbo].[DanToc] ON 

INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (12, N'Ba Na')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (37, N'Bố Y')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (35, N'Brâu')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (23, N'Bru - Vân Kiều')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (47, N'Bung')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (14, N'Chăm')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (29, N'Chơ Ro')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (41, N'Chứt')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (28, N'Co')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (26, N'Cơ Ho')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (46, N'Cơ Lao')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (31, N'Cống')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (9, N'Dao')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (56, N'Diềng Bì')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (48, N'Du Già')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (49, N'Du Hạ')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (11, N'Ê Đê')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (10, N'Gia Rai')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (25, N'Giáy')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (30, N'Ha Nhì')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (8, N'Hmông')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (17, N'Hơ Rê')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (6, N'Hoa')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (53, N'Kháng')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (5, N'Khmer')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (22, N'Khơ Mú')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (1, N'Kinh')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (38, N'La Chí')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (39, N'La Ha')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (43, N'Lào')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (44, N'Lô Lô')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (42, N'Lự')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (27, N'Mạ')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (45, N'Mảng')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (19, N'Mnông')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (4, N'Mường')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (54, N'Ngái')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (7, N'Nùng')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (36, N'Ơ Đu')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (40, N'Phù Lá')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (50, N'Pu Hoong')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (33, N'Pu Péo')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (18, N'Ra Glai')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (34, N'Rơ Măm')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (51, N'Rục')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (13, N'Sán Chay')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (16, N'Sán Dìu')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (32, N'Si La')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (55, N'So Thái')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (21, N'Stiêng')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (24, N'Tà Ôi')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (2, N'Tày')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (3, N'Thái')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (20, N'Thổ')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (57, N'Văn Thân')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (52, N'Xinh Mun')
INSERT [dbo].[DanToc] ([MaDT], [TenDT]) VALUES (15, N'Xơ Đăng')
SET IDENTITY_INSERT [dbo].[DanToc] OFF
GO
SET IDENTITY_INSERT [dbo].[DinhMucXangXe] ON 

INSERT [dbo].[DinhMucXangXe] ([MaDMXX], [TenPTien], [DMXX]) VALUES (1, N'Xe máy', 50)
INSERT [dbo].[DinhMucXangXe] ([MaDMXX], [TenPTien], [DMXX]) VALUES (2, N'Xe ô tô', 150)
SET IDENTITY_INSERT [dbo].[DinhMucXangXe] OFF
GO
SET IDENTITY_INSERT [dbo].[HeSoThangBacLuong] ON 

INSERT [dbo].[HeSoThangBacLuong] ([MaBL], [MaTL], [NgayQD], [Bac1], [Bac2], [Bac3], [Bac4], [Bac5], [Bac6], [Bac7], [Bac8], [Bac9], [Bac10], [Bac11], [Bac12]) VALUES (1, 1, CAST(N'2023-01-01' AS Date), 1, 1.2, 1.4, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[HeSoThangBacLuong] OFF
GO
SET IDENTITY_INSERT [dbo].[LoaiHopDong] ON 

INSERT [dbo].[LoaiHopDong] ([MaLoaiHD], [TenLoaiHD], [GhiChu]) VALUES (1, N'Hợp đồng lao động không xác định thời hạn', N'')
SET IDENTITY_INSERT [dbo].[LoaiHopDong] OFF
GO
SET IDENTITY_INSERT [dbo].[MucLuongToiThieu] ON 

INSERT [dbo].[MucLuongToiThieu] ([MaMLTT], [NgayAD], [MLTTVung], [MLTTC]) VALUES (1, CAST(N'2023-01-01' AS Date), 1, 4500000)
INSERT [dbo].[MucLuongToiThieu] ([MaMLTT], [NgayAD], [MLTTVung], [MLTTC]) VALUES (2, CAST(N'2023-01-01' AS Date), 2, 4000000)
INSERT [dbo].[MucLuongToiThieu] ([MaMLTT], [NgayAD], [MLTTVung], [MLTTC]) VALUES (3, CAST(N'2023-01-01' AS Date), 3, 3500000)
SET IDENTITY_INSERT [dbo].[MucLuongToiThieu] OFF
GO
SET IDENTITY_INSERT [dbo].[NganHang] ON 

INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (1, N'Ngân hàng Nông nghiệp và Phát triển Nông thôn Việt Nam', N'Agribank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (2, N'Ngân hàng TMCP Công Thương Việt Nam', N'VietinBank', N'CTG')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (3, N'Ngân hàng TMCP Đầu tư và Phát triển Việt Nam', N'BIDV', N'BID')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (4, N'Ngân hàng TMCP Ngoại Thương Việt Nam', N'Vietcombank', N'VCB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (5, N'Ngân hàng TMCP Á Châu', N'ACB', N'ACB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (6, N'Ngân hàng TMCP An Bình', N'ABBank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (7, N'Ngân hàng TMCP Bản Việt', N'Viet Capital Bank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (8, N'Ngân hàng TMCP Bảo Việt', N'BaoViet Bank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (9, N'Ngân hàng TMCP Bắc Á', N'Bac A Bank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (10, N'Ngân hàng TMCP Bưu điện Liên Việt', N'LienVietPostBank', N'LPB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (11, N'Ngân hàng TMCP Đại Chúng Việt Nam', N'PVcomBank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (12, N'Ngân hàng TMCP Đông Á', N'DongA Bank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (13, N'Ngân hàng TMCP Đông Nam Á', N'SeABank', N'SSB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (14, N'Ngân hàng TMCP Hàng Hải Việt Nam', N'MSB', N'MSB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (15, N'Ngân hàng TMCP Kiên Long', N'Kienlongbank', N'KLB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (16, N'Ngân hàng TMCP Kỹ Thương Việt Nam', N'Techcombank', N'TCB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (17, N'Ngân hàng TMCP Nam Á', N'Nam A Bank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (18, N'Ngân hàng TMCP Phương Đông', N'OCB', N'OCB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (19, N'Ngân hàng TMCP Quân Đội', N'MB', N'MBB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (20, N'Ngân hàng TMCP Quốc Dân', N'NCB', N'NVB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (21, N'Ngân hàng TMCP Sài Gòn', N'SCB', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (22, N'Ngân hàng TMCP Sài Gòn Công Thương', N'Saigonbank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (23, N'Ngân hàng TMCP Sài Gòn – Hà Nội', N'SHB', N'SHB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (24, N'Ngân hàng TMCP Sài Gòn Thương Tín', N'Sacombank', N'STB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (25, N'Ngân hàng TMCP Tiên Phong', N'TPBank', N'TPB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (26, N'Ngân hàng TMCP Việt Á', N'VietABank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (27, N'Ngân hàng TMCP Việt Nam Thịnh Vượng', N'VPBank', N'VPB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (28, N'Ngân hàng TMCP Việt Nam Thương Tín', N'Vietbank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (29, N'Ngân hàng TMCP Xăng Dầu Petrolimex', N'PG Bank', N'PGB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (30, N'Ngân hàng TMCP Xuất Nhập Khẩu Việt Nam', N'Eximbank', N'EIB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (31, N'Ngân hàng TMCP Phát triển TP.HCM', N'HDBank', N'HDB')
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (32, N'Ngân hàng TNHH MTV ANZ Việt Nam', N'ANZ', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (33, N'Ngân hàng TNHH MTV Hong Leong Việt Nam', N'Hong Leong Bank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (34, N'Ngân hàng TNHH MTV HSBC Việt Nam', N'HSBC', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (35, N'Ngân hàng TNHH MTV Shinhan Việt Nam', N'Shinhan Bank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (36, N'Ngân hàng TNHH MTV Standard Chartered Việt Nam', N'Standard Chartered', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (37, N'Ngân hàng TNHH MTV Public Bank Việt Nam', N'Public Bank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (38, N'Ngân hàng TNHH MTV CIMB Việt Nam', N'CIMB', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (39, N'Ngân hàng TNHH MTV Woori Việt Nam', N'Woori Bank', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (40, N'Ngân hàng TNHH MTV UOB Việt Nam', N'UOB', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (41, N'Ngân hàng Liên doanh Việt – Nga', N'VRB', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (42, N'Ngân hàng TNHH Indovina', N'IVB', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (43, N'Ngân hàng Chính sách Xã hội Việt Nam', N'VBSP', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (44, N'Ngân hàng Phát triển Việt Nam', N'VDB', NULL)
INSERT [dbo].[NganHang] ([MaNH], [TenDayDu], [VietTat], [MaChungKhoan]) VALUES (45, N'Ngân hàng Hợp tác xã Việt Nam', N'Co-opBank', NULL)
SET IDENTITY_INSERT [dbo].[NganHang] OFF
GO
SET IDENTITY_INSERT [dbo].[NgoaiNgu] ON 

INSERT [dbo].[NgoaiNgu] ([MaNN], [TenNN], [MaTDNN]) VALUES (1, N'Tiếng Anh', 1)
INSERT [dbo].[NgoaiNgu] ([MaNN], [TenNN], [MaTDNN]) VALUES (2, N'Tiếng Nhật', 3)
SET IDENTITY_INSERT [dbo].[NgoaiNgu] OFF
GO
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (1, N'Nguyen Van A', N'A', N'Nam', CAST(N'1985-01-01' AS Date), N'Hà Nội', N'Hà Nội', N'123 Phố Huế, Hà Nội', N'012345678901', CAST(N'2005-01-01' AS Date), N'Hà Nội', N'nguyenvana@example.com', N'0909123456', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (2, N'Tran Thi B', N'B', N'Nữ', CAST(N'1986-02-15' AS Date), N'Hồ Chí Minh', N'Hồ Chí Minh', N'456 Nguyễn Huệ, Hồ Chí Minh', N'012345678902', CAST(N'2006-02-01' AS Date), N'Hồ Chí Minh', N'tranthib@example.com', N'0909345678', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (3, N'Pham Van C', N'C', N'Nam', CAST(N'1987-03-25' AS Date), N'Hải Phòng', N'Hải Phòng', N'789 Lạch Tray, Hải Phòng', N'012345678903', CAST(N'2007-03-01' AS Date), N'Hải Phòng', N'phamvanc@example.com', N'0909456789', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (4, N'Le Thi D', N'D', N'Nữ', CAST(N'1988-04-05' AS Date), N'Đà Nẵng', N'Đà Nẵng', N'101 Bạch Đằng, Đà Nẵng', N'012345678904', CAST(N'2008-04-01' AS Date), N'Đà Nẵng', N'lethid@example.com', N'0909567890', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (5, N'Nguyen Van E', N'E', N'Nam', CAST(N'1989-05-15' AS Date), N'Cần Thơ', N'Cần Thơ', N'202 Trần Hưng Đạo, Cần Thơ', N'012345678905', CAST(N'2009-05-01' AS Date), N'Cần Thơ', N'nguyenvane@example.com', N'0909678901', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (6, N'Tran Van F', N'F', N'Nam', CAST(N'1990-06-10' AS Date), N'Nha Trang', N'Nha Trang', N'303 Thống Nhất, Nha Trang', N'012345678906', CAST(N'2010-06-01' AS Date), N'Nha Trang', N'tranvanf@example.com', N'0909789012', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (7, N'Phan Thi G', N'G', N'Nữ', CAST(N'1991-07-25' AS Date), N'Hà Nội', N'Hà Nội', N'404 Láng Hạ, Hà Nội', N'012345678907', CAST(N'2011-07-01' AS Date), N'Hà Nội', N'phanthig@example.com', N'0909890123', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (8, N'Vo Van H', N'H', N'Nam', CAST(N'1992-08-30' AS Date), N'Vũng Tàu', N'Vũng Tàu', N'505 Đồ Chiểu, Vũng Tàu', N'012345678908', CAST(N'2012-08-01' AS Date), N'Vũng Tàu', N'vovanh@example.com', N'0909901234', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (9, N'Le Thi I', N'I', N'Nữ', CAST(N'1993-09-10' AS Date), N'Hồ Chí Minh', N'Hồ Chí Minh', N'606 Võ Văn Kiệt, Hồ Chí Minh', N'012345678909', CAST(N'2013-09-01' AS Date), N'Hồ Chí Minh', N'lethii@example.com', N'0909012345', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
INSERT [dbo].[NhanVien] ([MaNV], [TenNV], [BiDanh], [GioiTinh], [NgaySinh], [QueQuan], [NoiSinh], [NoiOHienTai], [SoCCCD], [NgayCap], [NoiCap], [Email], [SoDienThoai], [Anh], [NgayVaoDoan], [NoiVaoDoan], [NgayVaoDang], [NoiVaoDang], [NgayVaoLam], [NgayRoiCoQuan], [LyDo], [HeSoLuong], [HeSoPhuCap], [HeSoTNVK], [SoSocBH], [NgayCapSo], [NoiCapSo], [SoThe], [SoTaiKhoan], [NganHang], [TinhTrangHonNhan], [TinhTrangSuckhoe], [ChieuCao], [CanNang], [NhomMau], [NgayNhapNgu], [NgayXuatNgu], [QuanHamCaoNhat], [ThoiGianNangBacHSL], [KhongChoPhepNangLuong], [RoiCoQuan], [NghiHuu], [LuongCoSo], [MaDMXX], [MaTG], [MaChucVu], [MaXL], [MaTT], [MaTDVH], [MaDT], [MaCM], [MaNN], [MaTDLLCT], [MaTTLV]) VALUES (10, N'Nguyen Van K', N'K', N'Nam', CAST(N'1994-10-20' AS Date), N'Bình Dương', N'Bình Dương', N'707 Đại lộ Bình Dương, Bình Dương', N'012345678910', CAST(N'2014-10-01' AS Date), N'Bình Dương', N'nguyenvank@example.com', N'0909123456', NULL, CAST(N'2001-06-01' AS Date), N'Hà Nội', CAST(N'2003-08-01' AS Date), N'Hà Nội', CAST(N'2005-09-01' AS Date), NULL, NULL, 4.5, 1.2, 0.8, 123456, CAST(N'2006-01-01' AS Date), N'Hà Nội', N'123456789', N'0123456789', N'Vietcombank', 1, N'Tốt', 1.75, 65, N'O', CAST(N'2003-02-01' AS Date), NULL, N'Thiếu tá', 5, 0, 0, 0, 6500000, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1)
GO
SET IDENTITY_INSERT [dbo].[PhongBan] ON 

INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (1, N'Phòng Hành chính - Nhân sự', 1, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (2, N'Phòng Kế toán - Tài chính', 1, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (3, N'Phòng Kinh doanh', 2, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (4, N'Phòng Marketing', 2, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (5, N'Phòng Nghiên cứu và Phát triển', 3, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (6, N'Phòng Sản xuất', 3, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (7, N'Phòng Kỹ thuật', 3, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (8, N'Phòng Công nghệ Thông tin', 2, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (9, N'Phòng Chăm sóc Khách hàng', 2, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (10, N'Phòng Pháp chế', 1, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (11, N'Phòng Kiểm toán Nội bộ', 1, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (12, N'Phòng Quản lý Chất lượng', 3, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (13, N'Phòng Đào tạo', 2, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (14, N'Phòng Xuất nhập khẩu', 2, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (15, N'Phòng An toàn Lao động', 3, 60, 55)
INSERT [dbo].[PhongBan] ([MaPB], [TenPB], [CapDo], [DoTuoiVeHuuNam], [DoTuoiVeHuuNu]) VALUES (16, N'Phòng Bảo vệ', 4, 60, 55)
SET IDENTITY_INSERT [dbo].[PhongBan] OFF
GO
SET IDENTITY_INSERT [dbo].[QuanHeThanNhan] ON 

INSERT [dbo].[QuanHeThanNhan] ([MaQHTN], [TenQHTN]) VALUES (1, N'Cha')
INSERT [dbo].[QuanHeThanNhan] ([MaQHTN], [TenQHTN]) VALUES (2, N'Mẹ')
INSERT [dbo].[QuanHeThanNhan] ([MaQHTN], [TenQHTN]) VALUES (3, N'Anh chị em')
SET IDENTITY_INSERT [dbo].[QuanHeThanNhan] OFF
GO
SET IDENTITY_INSERT [dbo].[ThangLuong] ON 

INSERT [dbo].[ThangLuong] ([MaTL], [TenTL], [DienGiai]) VALUES (1, N'Bậc 1', N'Nhân viên mới vào')
INSERT [dbo].[ThangLuong] ([MaTL], [TenTL], [DienGiai]) VALUES (2, N'Bậc 2', N'Nhân viên có kinh nghiệm')
SET IDENTITY_INSERT [dbo].[ThangLuong] OFF
GO
SET IDENTITY_INSERT [dbo].[TinhThanh] ON 

INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (1, N'An Giang')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (2, N'Bà Rịa - Vũng Tàu')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (5, N'Bắc Giang')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (4, N'Bắc Kạn')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (3, N'Bạc Liêu')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (6, N'Bắc Ninh')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (7, N'Bến Tre')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (9, N'Bình Định')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (8, N'Bình Dương')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (10, N'Bình Phước')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (11, N'Bình Thuận')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (12, N'Cà Mau')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (14, N'Cần Thơ')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (13, N'Cao Bằng')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (15, N'Đà Nẵng')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (16, N'Đắk Lắk')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (17, N'Đắk Nông')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (18, N'Điện Biên')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (19, N'Đồng Nai')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (20, N'Đồng Tháp')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (21, N'Gia Lai')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (22, N'Hà Giang')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (23, N'Hà Nam')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (24, N'Hà Nội')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (25, N'Hà Tĩnh')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (26, N'Hải Dương')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (27, N'Hải Phòng')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (28, N'Hậu Giang')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (29, N'Hòa Bình')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (30, N'Hưng Yên')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (31, N'Khánh Hòa')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (32, N'Kiên Giang')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (33, N'Kon Tum')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (34, N'Lai Châu')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (35, N'Lâm Đồng')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (36, N'Lạng Sơn')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (37, N'Lào Cai')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (38, N'Long An')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (39, N'Nam Định')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (40, N'Nghệ An')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (41, N'Ninh Bình')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (42, N'Ninh Thuận')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (43, N'Phú Thọ')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (44, N'Phú Yên')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (45, N'Quảng Bình')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (46, N'Quảng Nam')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (47, N'Quảng Ngãi')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (48, N'Quảng Ninh')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (49, N'Quảng Trị')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (50, N'Sóc Trăng')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (51, N'Sơn La')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (52, N'Tây Ninh')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (53, N'Thái Bình')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (54, N'Thái Nguyên')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (55, N'Thanh Hóa')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (56, N'Thừa Thiên Huế')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (57, N'Tiền Giang')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (58, N'TP Hồ Chí Minh')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (59, N'Trà Vinh')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (60, N'Tuyên Quang')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (61, N'Vĩnh Long')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (62, N'Vĩnh Phúc')
INSERT [dbo].[TinhThanh] ([MaTT], [TenTT]) VALUES (63, N'Yên Bái')
SET IDENTITY_INSERT [dbo].[TinhThanh] OFF
GO
SET IDENTITY_INSERT [dbo].[TonGiao] ON 

INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (4, N'Ấn Độ giáo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (2, N'Cơ Đốc giáo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (10, N'Đạo Cao Đài')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (27, N'Đạo Hòa Hảo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (9, N'Đạo Jain')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (8, N'Đạo Sikh')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (7, N'Do Thái giáo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (15, N'Giáo hội Chính Thống Đông Phương')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (17, N'Giáo phái Mormon')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (18, N'Giáo phái Scientology')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (26, N'Giáo phái Tenrikyo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (3, N'Hồi giáo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (1, N'Không')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (32, N'Khổng giáo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (33, N'Lão giáo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (16, N'Ngộ đạo giáo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (30, N'Pháp Luân Công')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (5, N'Phật giáo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (14, N'Rastafarianism')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (6, N'Thần đạo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (20, N'Thuyết bất khả tri')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (22, N'Thuyết ngộ đạo')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (21, N'Thuyết vật linh')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (19, N'Thuyết vô thần')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (13, N'Tín ngưỡng bản địa châu Mỹ')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (28, N'Tín ngưỡng bản địa Úc')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (31, N'Tín ngưỡng Cao Nguyên Andes')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (11, N'Tín ngưỡng dân gian Trung Hoa')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (23, N'Tín ngưỡng Wicca')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (12, N'Tôn giáo bản địa châu Phi')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (29, N'Tôn giáo bản địa Siberia')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (24, N'Tôn giáo Neopagan')
INSERT [dbo].[TonGiao] ([MaTG], [TenTG]) VALUES (25, N'Tôn giáo Zoroastrianism')
SET IDENTITY_INSERT [dbo].[TonGiao] OFF
GO
SET IDENTITY_INSERT [dbo].[TrangThaiLamViec] ON 

INSERT [dbo].[TrangThaiLamViec] ([MaTTLV], [TenTTLV], [KyHieu]) VALUES (1, N'Đang làm việc', N'DLV')
INSERT [dbo].[TrangThaiLamViec] ([MaTTLV], [TenTTLV], [KyHieu]) VALUES (2, N'Nghỉ phép', N'NP')
SET IDENTITY_INSERT [dbo].[TrangThaiLamViec] OFF
GO
SET IDENTITY_INSERT [dbo].[TrinhDoChuyenMon] ON 

INSERT [dbo].[TrinhDoChuyenMon] ([MaTDCM], [TenTDCM]) VALUES (3, N'Chuyên sâu')
INSERT [dbo].[TrinhDoChuyenMon] ([MaTDCM], [TenTDCM]) VALUES (1, N'Cơ bản')
INSERT [dbo].[TrinhDoChuyenMon] ([MaTDCM], [TenTDCM]) VALUES (2, N'Nâng cao')
SET IDENTITY_INSERT [dbo].[TrinhDoChuyenMon] OFF
GO
SET IDENTITY_INSERT [dbo].[TrinhDoLyLuanChinhTri] ON 

INSERT [dbo].[TrinhDoLyLuanChinhTri] ([MaTDLLCT], [TenTDLLCT]) VALUES (2, N'Cao cấp')
INSERT [dbo].[TrinhDoLyLuanChinhTri] ([MaTDLLCT], [TenTDLLCT]) VALUES (3, N'Sơ cấp')
INSERT [dbo].[TrinhDoLyLuanChinhTri] ([MaTDLLCT], [TenTDLLCT]) VALUES (1, N'Trung cấp')
SET IDENTITY_INSERT [dbo].[TrinhDoLyLuanChinhTri] OFF
GO
SET IDENTITY_INSERT [dbo].[TrinhDoNgoaiNgu] ON 

INSERT [dbo].[TrinhDoNgoaiNgu] ([MaTDNN], [TenTDNN]) VALUES (1, N'Tiếng Anh cơ bản')
INSERT [dbo].[TrinhDoNgoaiNgu] ([MaTDNN], [TenTDNN]) VALUES (2, N'Tiếng Anh nâng cao')
INSERT [dbo].[TrinhDoNgoaiNgu] ([MaTDNN], [TenTDNN]) VALUES (3, N'Tiếng Nhật')
SET IDENTITY_INSERT [dbo].[TrinhDoNgoaiNgu] OFF
GO
SET IDENTITY_INSERT [dbo].[TrinhDoVanHoa] ON 

INSERT [dbo].[TrinhDoVanHoa] ([MaTDVH], [TenTDVH]) VALUES (5, N'Cao đẳng')
INSERT [dbo].[TrinhDoVanHoa] ([MaTDVH], [TenTDVH]) VALUES (6, N'Đại học')
INSERT [dbo].[TrinhDoVanHoa] ([MaTDVH], [TenTDVH]) VALUES (2, N'THCS')
INSERT [dbo].[TrinhDoVanHoa] ([MaTDVH], [TenTDVH]) VALUES (3, N'THPT')
INSERT [dbo].[TrinhDoVanHoa] ([MaTDVH], [TenTDVH]) VALUES (1, N'Tiểu học')
INSERT [dbo].[TrinhDoVanHoa] ([MaTDVH], [TenTDVH]) VALUES (4, N'Trung cấp')
SET IDENTITY_INSERT [dbo].[TrinhDoVanHoa] OFF
GO
SET IDENTITY_INSERT [dbo].[XepLoai] ON 

INSERT [dbo].[XepLoai] ([MaXL], [TenXL]) VALUES (3, N'Khá')
INSERT [dbo].[XepLoai] ([MaXL], [TenXL]) VALUES (2, N'Tốt')
INSERT [dbo].[XepLoai] ([MaXL], [TenXL]) VALUES (4, N'Trung bình')
INSERT [dbo].[XepLoai] ([MaXL], [TenXL]) VALUES (1, N'Xuất sắc')
SET IDENTITY_INSERT [dbo].[XepLoai] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ChucNang__4CF9227E513E9FA3]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[ChucNangPhanMem] ADD UNIQUE NONCLUSTERED 
(
	[TenCN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ChucVu__A7E2123E9262C1D5]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[ChucVu] ADD UNIQUE NONCLUSTERED 
(
	[TenChucVu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ChungChi__4CF92273AED4995F]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[ChungChi] ADD UNIQUE NONCLUSTERED 
(
	[TenCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ChuyenMo__4CF9227D5A2D1A22]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[ChuyenMon] ADD UNIQUE NONCLUSTERED 
(
	[TenCM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__DanToc__4CF965627A0D25F2]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[DanToc] ADD UNIQUE NONCLUSTERED 
(
	[TenDT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NgoaiNgu__4CF9B4AC51E17B70]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[NgoaiNgu] ADD UNIQUE NONCLUSTERED 
(
	[TenNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__NguoiDun__55F68FC013A0C567]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[NguoiDung] ADD UNIQUE NONCLUSTERED 
(
	[TenDangNhap] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__PhongBan__4CF9C7C59E9A361C]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[PhongBan] ADD UNIQUE NONCLUSTERED 
(
	[TenPB] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__ThangLuo__4CF9E776555D417A]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[ThangLuong] ADD UNIQUE NONCLUSTERED 
(
	[TenTL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TinhThan__4CF9E77EDD234897]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[TinhThanh] ADD UNIQUE NONCLUSTERED 
(
	[TenTT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TonGiao__4CF9E74B5A308AF3]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[TonGiao] ADD UNIQUE NONCLUSTERED 
(
	[TenTG] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TrinhDoC__F33254EB1B6DF675]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[TrinhDoChuyenMon] ADD UNIQUE NONCLUSTERED 
(
	[TenTDCM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TrinhDoL__2A22EA3EC22E8457]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[TrinhDoLyLuanChinhTri] ADD UNIQUE NONCLUSTERED 
(
	[TenTDLLCT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TrinhDoN__F3332FF6041A9D84]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[TrinhDoNgoaiNgu] ADD UNIQUE NONCLUSTERED 
(
	[TenTDNN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__TrinhDoV__F332EEF6EBF069C9]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[TrinhDoVanHoa] ADD UNIQUE NONCLUSTERED 
(
	[TenTDVH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__XepLoai__4CE606F9D76613D8]    Script Date: 07/11/2024 12:46:05 AM ******/
ALTER TABLE [dbo].[XepLoai] ADD UNIQUE NONCLUSTERED 
(
	[TenXL] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD FOREIGN KEY([MaCCTL])
REFERENCES [dbo].[ChamCongTL] ([MaCCTL])
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD FOREIGN KEY([MaDMXX])
REFERENCES [dbo].[DinhMucXangXe] ([MaDMXX])
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD FOREIGN KEY([MaMLTT])
REFERENCES [dbo].[MucLuongToiThieu] ([MaMLTT])
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD FOREIGN KEY([MaND])
REFERENCES [dbo].[NguoiDung] ([MaND])
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[BangLuong]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[BangTamUng]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChucNangPhanMem]  WITH CHECK ADD FOREIGN KEY([MaND])
REFERENCES [dbo].[NguoiDung] ([MaND])
GO
ALTER TABLE [dbo].[ChungChi]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ChuyenMon]  WITH CHECK ADD FOREIGN KEY([MaTDCM])
REFERENCES [dbo].[TrinhDoChuyenMon] ([MaTDCM])
GO
ALTER TABLE [dbo].[DienBienTrangThaiLamViec]  WITH CHECK ADD FOREIGN KEY([MaTTLV])
REFERENCES [dbo].[TrangThaiLamViec] ([MaTTLV])
GO
ALTER TABLE [dbo].[DienBienTrangThaiLamViec]  WITH CHECK ADD FOREIGN KEY([MaCV])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[DienBienTrangThaiLamViec]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DienBienTrangThaiLamViec]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[DieuChuyenCongTac]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[DieuChuyenCongTac]  WITH CHECK ADD FOREIGN KEY([MaBL])
REFERENCES [dbo].[HeSoThangBacLuong] ([MaBL])
GO
ALTER TABLE [dbo].[DieuChuyenCongTac]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HopDong] ([MaHD])
GO
ALTER TABLE [dbo].[DieuChuyenCongTac]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[DieuChuyenCongTac]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[GiaHanHopDong]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HopDong] ([MaHD])
GO
ALTER TABLE [dbo].[GiaHanHopDong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HeSoThangBacLuong]  WITH CHECK ADD FOREIGN KEY([MaTL])
REFERENCES [dbo].[ThangLuong] ([MaTL])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaBL])
REFERENCES [dbo].[HeSoThangBacLuong] ([MaBL])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaLoaiHD])
REFERENCES [dbo].[LoaiHopDong] ([MaLoaiHD])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HopDong]  WITH CHECK ADD FOREIGN KEY([MaTL])
REFERENCES [dbo].[ThangLuong] ([MaTL])
GO
ALTER TABLE [dbo].[KhenThuongKyLuat]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NgoaiNgu]  WITH CHECK ADD FOREIGN KEY([MaTDNN])
REFERENCES [dbo].[TrinhDoNgoaiNgu] ([MaTDNN])
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NguoiDung]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaCM])
REFERENCES [dbo].[ChuyenMon] ([MaCM])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaDMXX])
REFERENCES [dbo].[DinhMucXangXe] ([MaDMXX])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaDT])
REFERENCES [dbo].[DanToc] ([MaDT])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaNN])
REFERENCES [dbo].[NgoaiNgu] ([MaNN])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDLLCT])
REFERENCES [dbo].[TrinhDoLyLuanChinhTri] ([MaTDLLCT])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaTDVH])
REFERENCES [dbo].[TrinhDoVanHoa] ([MaTDVH])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaTG])
REFERENCES [dbo].[TonGiao] ([MaTG])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaTT])
REFERENCES [dbo].[TinhThanh] ([MaTT])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaTTLV])
REFERENCES [dbo].[TrangThaiLamViec] ([MaTTLV])
GO
ALTER TABLE [dbo].[NhanVien]  WITH CHECK ADD FOREIGN KEY([MaXL])
REFERENCES [dbo].[XepLoai] ([MaXL])
GO
ALTER TABLE [dbo].[QuaTrinhCongTac]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[QuaTrinhCongTac]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[QuaTrinhCongTac]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[QuaTrinhDaoTao]  WITH CHECK ADD FOREIGN KEY([MaChucVu])
REFERENCES [dbo].[ChucVu] ([MaChucVu])
GO
ALTER TABLE [dbo].[QuaTrinhDaoTao]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[QuaTrinhDaoTao]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
ALTER TABLE [dbo].[QuaTrinhLuong]  WITH CHECK ADD FOREIGN KEY([MaMLTT])
REFERENCES [dbo].[MucLuongToiThieu] ([MaMLTT])
GO
ALTER TABLE [dbo].[QuaTrinhLuong]  WITH CHECK ADD FOREIGN KEY([MaBL])
REFERENCES [dbo].[HeSoThangBacLuong] ([MaBL])
GO
ALTER TABLE [dbo].[QuaTrinhLuong]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ThanNhan]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[ThanNhan]  WITH CHECK ADD FOREIGN KEY([MaQHTN])
REFERENCES [dbo].[QuanHeThanNhan] ([MaQHTN])
GO
ALTER TABLE [dbo].[XepLoaiCanBo]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[XepLoaiCanBo]  WITH CHECK ADD FOREIGN KEY([MaPB])
REFERENCES [dbo].[PhongBan] ([MaPB])
GO
/****** Object:  StoredProcedure [dbo].[ExecuteSQLString]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExecuteSQLString]
    @SQLString NVARCHAR(MAX)
AS
BEGIN
    -- Bắt đầu một khối try-catch để xử lý lỗi
    BEGIN TRY
        -- Thực thi câu lệnh SQL động
        EXEC sp_executesql @SQLString;
    END TRY
    BEGIN CATCH
        -- Bắt lỗi nếu có và hiển thị thông báo lỗi
        DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[GetAllColumnsFromTable]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllColumnsFromTable]
    @TableName NVARCHAR(128) -- Tên bảng cần lấy dữ liệu
AS
BEGIN
    -- Bắt đầu một khối try-catch để xử lý lỗi
    BEGIN TRY
        DECLARE @SQLString NVARCHAR(MAX);
        
        -- Tạo câu lệnh SQL động để lấy tất cả các trường trong bảng
        SET @SQLString = N'SELECT * FROM ' + QUOTENAME(@TableName);
        
        -- Thực thi câu lệnh SQL động
        EXEC sp_executesql @SQLString;
    END TRY
    BEGIN CATCH
        -- Bắt lỗi nếu có và hiển thị thông báo lỗi
        DECLARE @ErrorMessage NVARCHAR(4000), @ErrorSeverity INT, @ErrorState INT;
        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();
        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
GO
/****** Object:  StoredProcedure [dbo].[GetNhanVienDetails]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetNhanVienDetails]
AS
BEGIN
    SELECT 
        nv.MaNV,
        nv.TenNV,
        nv.BiDanh,
        nv.GioiTinh,
        nv.NgaySinh,
        nv.QueQuan,
        nv.NoiSinh,
        nv.NoiOHienTai,
        nv.SoCCCD,
        nv.NgayCap,
        nv.NoiCap,
        nv.Email,
        nv.SoDienThoai,
        nv.NgayVaoDoan,
        nv.NoiVaoDoan,
        nv.NgayVaoDang,
        nv.NoiVaoDang,
        nv.NgayVaoLam,
        CONVERT(DATE, nv.NgayRoiCoQuan) AS NgayRoiCoQuan,
        nv.LyDo,
        nv.HeSoLuong,
        nv.HeSoPhuCap,
        nv.HeSoTNVK,
        nv.SoSocBH,
        nv.NgayCapSo,
        nv.NoiCapSo,
        nv.SoThe,
        nv.SoTaiKhoan,
        nv.NganHang,
        nv.TinhTrangHonNhan,
        nv.TinhTrangSuckhoe,
        nv.ChieuCao,
        nv.CanNang,
        nv.NhomMau,
		CONVERT(DATE, nv.NgayNhapNgu) AS NgayNhapNgu,
		CONVERT(DATE, nv.NgayXuatNgu) AS NgayXuatNgu,
        nv.QuanHamCaoNhat,
        nv.ThoiGianNangBacHSL,
        nv.KhongChoPhepNangLuong,
        nv.RoiCoQuan,
        nv.NghiHuu,
        nv.LuongCoSo,
        
        -- Join with related tables to retrieve descriptive names
        tt.TenTT AS TinhThanh,
        tg.TenTG AS TonGiao,
        cv.TenChucVu AS ChucVu,
        xl.TenXL AS XepLoai,
        ttdvh.TenTDVH AS TrinhDoVanHoa,
        dt.TenDT AS DanToc,
        cm.TenCM AS ChuyenMon,
        nn.TenNN AS NgoaiNgu,
        tdllct.TenTDLLCT AS TrinhDoLyLuanChinhTri,
        ttlv.TenTTLV AS TrangThaiLamViec,
        dmxx.TenPTien AS DinhMucXangXe
        
    FROM 
        NhanVien nv
    LEFT JOIN 
        TinhThanh tt ON nv.MaTT = tt.MaTT
    LEFT JOIN 
        TonGiao tg ON nv.MaTG = tg.MaTG
    LEFT JOIN 
        ChucVu cv ON nv.MaChucVu = cv.MaChucVu
    LEFT JOIN 
        XepLoai xl ON nv.MaXL = xl.MaXL
    LEFT JOIN 
        TrinhDoVanHoa ttdvh ON nv.MaTDVH = ttdvh.MaTDVH
    LEFT JOIN 
        DanToc dt ON nv.MaDT = dt.MaDT
    LEFT JOIN 
        ChuyenMon cm ON nv.MaCM = cm.MaCM
    LEFT JOIN 
        NgoaiNgu nn ON nv.MaNN = nn.MaNN
    LEFT JOIN 
        TrinhDoLyLuanChinhTri tdllct ON nv.MaTDLLCT = tdllct.MaTDLLCT
    LEFT JOIN 
        TrangThaiLamViec ttlv ON nv.MaTTLV = ttlv.MaTTLV
    LEFT JOIN 
        DinhMucXangXe dmxx ON nv.MaDMXX = dmxx.MaDMXX
END;
GO
/****** Object:  StoredProcedure [dbo].[GetRecordByKey]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetRecordByKey]
    @TableName NVARCHAR(128),
    @PrimaryKeyColumn NVARCHAR(128),
    @PrimaryKeyValue NVARCHAR(MAX)  -- Sử dụng NVARCHAR thay cho SQL_VARIANT
AS
BEGIN
    DECLARE @SQL NVARCHAR(MAX);

    -- Xây dựng câu truy vấn động với giá trị được chuyển thành chuỗi
    SET @SQL = N'SELECT * FROM ' + QUOTENAME(@TableName) + 
               N' WHERE ' + QUOTENAME(@PrimaryKeyColumn) + N' = ';

    -- Kiểm tra nếu giá trị là số, chuỗi, hoặc NULL
    IF ISNUMERIC(@PrimaryKeyValue) = 1
        SET @SQL = @SQL + @PrimaryKeyValue; -- Không cần dấu nháy cho số
    ELSE IF @PrimaryKeyValue IS NULL
        SET @SQL = @SQL + N'NULL'; -- Xử lý NULL
    ELSE
        SET @SQL = @SQL + N'''' + @PrimaryKeyValue + N''''; -- Thêm dấu nháy cho chuỗi

    -- Thực thi SQL động
    EXEC sp_executesql @SQL;
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertOrUpdateNhanVien]    Script Date: 07/11/2024 12:46:05 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertOrUpdateNhanVien]
    @NhanVienJson NVARCHAR(MAX)
AS
BEGIN
    SET XACT_ABORT ON;  -- Đảm bảo transaction sẽ rollback nếu có lỗi

    BEGIN TRANSACTION;

    BEGIN TRY
        -- Tạo bảng tạm để chứa dữ liệu từ JSON
        DECLARE @NhanVienTemp TABLE (
            MaNV INT,
            TenNV NVARCHAR(150),
            BiDanh NVARCHAR(50),
            GioiTinh NVARCHAR(5),
            NgaySinh DATE,
            QueQuan NVARCHAR(150),
            NoiSinh NVARCHAR(100),
            NoiOHienTai NVARCHAR(150),
            SoCCCD VARCHAR(15),
            NgayCap DATE,
            NoiCap NVARCHAR(100),
            Email NVARCHAR(70),
            SoDienThoai NVARCHAR(100),
            NgayVaoDoan DATE,
            NoiVaoDoan NVARCHAR(150),
            NgayVaoDang DATE,
            NoiVaoDang NVARCHAR(150),
            NgayVaoLam DATE,
            NgayRoiCoQuan DATE,
            LyDo NVARCHAR(150),
            HeSoLuong FLOAT,
            HeSoPhuCap FLOAT,
            HeSoTNVK FLOAT,
            SoSocBH INT,
            NgayCapSo DATE,
            NoiCapSo NVARCHAR(150),
            SoThe VARCHAR(30),
            SoTaiKhoan VARCHAR(20),
            NganHang NVARCHAR(100),
            TinhTrangHonNhan BIT,
            TinhTrangSuckhoe NVARCHAR(50),
            ChieuCao FLOAT,
            CanNang FLOAT,
            NhomMau NVARCHAR(50),
            NgayNhapNgu DATE,
            NgayXuatNgu DATE,
            QuanHamCaoNhat NVARCHAR(50),
            ThoiGianNangBacHSL INT,
            KhongChoPhepNangLuong BIT,
            RoiCoQuan BIT,
            NghiHuu BIT,
            LuongCoSo FLOAT,
            MaDMXX INT,
            MaTG INT,
            MaChucVu INT,
            MaXL INT,
            MaTT INT,
            MaTDVH INT,
            MaDT INT,
            MaCM INT,
            MaNN INT,
            MaTDLLCT INT,
            MaTTLV INT
        );

        -- Insert dữ liệu từ JSON vào bảng tạm
        INSERT INTO @NhanVienTemp
        SELECT 
            MaNV,
            TenNV,
            BiDanh,
            GioiTinh,
            NgaySinh,
            QueQuan,
            NoiSinh,
            NoiOHienTai,
            SoCCCD,
            NgayCap,
            NoiCap,
            Email,
            SoDienThoai,
            NgayVaoDoan,
            NoiVaoDoan,
            NgayVaoDang,
            NoiVaoDang,
            NgayVaoLam,
            NgayRoiCoQuan,
            LyDo,
            HeSoLuong,
            HeSoPhuCap,
            HeSoTNVK,
            SoSocBH,
            NgayCapSo,
            NoiCapSo,
            SoThe,
            SoTaiKhoan,
            NganHang,
            TinhTrangHonNhan,
            TinhTrangSuckhoe,
            ChieuCao,
            CanNang,
            NhomMau,
            NgayNhapNgu,
            NgayXuatNgu,
            QuanHamCaoNhat,
            ThoiGianNangBacHSL,
            KhongChoPhepNangLuong,
            RoiCoQuan,
            NghiHuu,
            LuongCoSo,
            MaDMXX,
            MaTG,
            MaChucVu,
            MaXL,
            MaTT,
            MaTDVH,
            MaDT,
            MaCM,
            MaNN,
            MaTDLLCT,
            MaTTLV
        FROM OPENJSON(@NhanVienJson)
        WITH (
            MaNV INT,
            TenNV NVARCHAR(150),
            BiDanh NVARCHAR(50),
            GioiTinh NVARCHAR(5),
            NgaySinh DATE,
            QueQuan NVARCHAR(150),
            NoiSinh NVARCHAR(100),
            NoiOHienTai NVARCHAR(150),
            SoCCCD VARCHAR(15),
            NgayCap DATE,
            NoiCap NVARCHAR(100),
            Email NVARCHAR(70),
            SoDienThoai NVARCHAR(100),
            NgayVaoDoan DATE,
            NoiVaoDoan NVARCHAR(150),
            NgayVaoDang DATE,
            NoiVaoDang NVARCHAR(150),
            NgayVaoLam DATE,
            NgayRoiCoQuan DATE,
            LyDo NVARCHAR(150),
            HeSoLuong FLOAT,
            HeSoPhuCap FLOAT,
            HeSoTNVK FLOAT,
            SoSocBH INT,
            NgayCapSo DATE,
            NoiCapSo NVARCHAR(150),
            SoThe VARCHAR(30),
            SoTaiKhoan VARCHAR(20),
            NganHang NVARCHAR(100),
            TinhTrangHonNhan BIT,
            TinhTrangSuckhoe NVARCHAR(50),
            ChieuCao FLOAT,
            CanNang FLOAT,
            NhomMau NVARCHAR(50),
            NgayNhapNgu DATE,
            NgayXuatNgu DATE,
            QuanHamCaoNhat NVARCHAR(50),
            ThoiGianNangBacHSL INT,
            KhongChoPhepNangLuong BIT,
            RoiCoQuan BIT,
            NghiHuu BIT,
            LuongCoSo FLOAT,
            MaDMXX INT,
            MaTG INT,
            MaChucVu INT,
            MaXL INT,
            MaTT INT,
            MaTDVH INT,
            MaDT INT,
            MaCM INT,
            MaNN INT,
            MaTDLLCT INT,
            MaTTLV INT
        );

        -- Merge dữ liệu từ bảng tạm vào bảng chính
        MERGE INTO NhanVien AS target
        USING @NhanVienTemp AS source
        ON target.MaNV = source.MaNV
        WHEN MATCHED THEN
            UPDATE SET
                TenNV = source.TenNV,
                BiDanh = source.BiDanh,
                GioiTinh = source.GioiTinh,
                NgaySinh = source.NgaySinh,
                QueQuan = source.QueQuan,
                NoiSinh = source.NoiSinh,
                NoiOHienTai = source.NoiOHienTai,
                SoCCCD = source.SoCCCD,
                NgayCap = source.NgayCap,
                NoiCap = source.NoiCap,
                Email = source.Email,
                SoDienThoai = source.SoDienThoai,
                NgayVaoDoan = source.NgayVaoDoan,
                NoiVaoDoan = source.NoiVaoDoan,
                NgayVaoDang = source.NgayVaoDang,
                NoiVaoDang = source.NoiVaoDang,
                NgayVaoLam = source.NgayVaoLam,
                NgayRoiCoQuan = source.NgayRoiCoQuan,
                LyDo = source.LyDo,
                HeSoLuong = source.HeSoLuong,
                HeSoPhuCap = source.HeSoPhuCap,
                HeSoTNVK = source.HeSoTNVK,
                SoSocBH = source.SoSocBH,
                NgayCapSo = source.NgayCapSo,
                NoiCapSo = source.NoiCapSo,
                SoThe = source.SoThe,
                SoTaiKhoan = source.SoTaiKhoan,
                NganHang = source.NganHang,
                TinhTrangHonNhan = source.TinhTrangHonNhan,
                TinhTrangSuckhoe = source.TinhTrangSuckhoe,
                ChieuCao = source.ChieuCao,
                CanNang = source.CanNang,
                NhomMau = source.NhomMau,
                NgayNhapNgu = source.NgayNhapNgu,
                NgayXuatNgu = source.NgayXuatNgu,
                QuanHamCaoNhat = source.QuanHamCaoNhat,
                ThoiGianNangBacHSL = source.ThoiGianNangBacHSL,
                KhongChoPhepNangLuong = source.KhongChoPhepNangLuong,
                RoiCoQuan = source.RoiCoQuan,
                NghiHuu = source.NghiHuu,
                LuongCoSo = source.LuongCoSo,
                MaDMXX = source.MaDMXX,
                MaTG = source.MaTG,
                MaChucVu = source.MaChucVu,
                MaXL = source.MaXL,
                MaTT = source.MaTT,
                MaTDVH = source.MaTDVH,
                MaDT = source.MaDT,
                MaCM = source.MaCM,
                MaNN = source.MaNN,
                MaTDLLCT = source.MaTDLLCT,
                MaTTLV = source.MaTTLV
        WHEN NOT MATCHED THEN
            INSERT (TenNV, BiDanh, GioiTinh, NgaySinh, QueQuan, NoiSinh, NoiOHienTai, SoCCCD, NgayCap, NoiCap, Email, SoDienThoai, NgayVaoDoan, NoiVaoDoan, NgayVaoDang, NoiVaoDang, NgayVaoLam, NgayRoiCoQuan, LyDo, HeSoLuong, HeSoPhuCap, HeSoTNVK, SoSocBH, NgayCapSo, NoiCapSo, SoThe, SoTaiKhoan, NganHang, TinhTrangHonNhan, TinhTrangSuckhoe, ChieuCao, CanNang, NhomMau, NgayNhapNgu, NgayXuatNgu, QuanHamCaoNhat, ThoiGianNangBacHSL, KhongChoPhepNangLuong, RoiCoQuan, NghiHuu, LuongCoSo, MaDMXX, MaTG, MaChucVu, MaXL, MaTT, MaTDVH, MaDT, MaCM, MaNN, MaTDLLCT, MaTTLV)
            VALUES (source.TenNV, source.BiDanh, source.GioiTinh, source.NgaySinh, source.QueQuan, source.NoiSinh, source.NoiOHienTai, source.SoCCCD, source.NgayCap, source.NoiCap, source.Email, source.SoDienThoai, source.NgayVaoDoan, source.NoiVaoDoan, source.NgayVaoDang, source.NoiVaoDang, source.NgayVaoLam, source.NgayRoiCoQuan, source.LyDo, source.HeSoLuong, source.HeSoPhuCap, source.HeSoTNVK, source.SoSocBH, source.NgayCapSo, source.NoiCapSo, source.SoThe, source.SoTaiKhoan, source.NganHang, source.TinhTrangHonNhan, source.TinhTrangSuckhoe, source.ChieuCao, source.CanNang, source.NhomMau, source.NgayNhapNgu, source.NgayXuatNgu, source.QuanHamCaoNhat, source.ThoiGianNangBacHSL, source.KhongChoPhepNangLuong, source.RoiCoQuan, source.NghiHuu, source.LuongCoSo, source.MaDMXX, source.MaTG, source.MaChucVu, source.MaXL, source.MaTT, source.MaTDVH, source.MaDT, source.MaCM, source.MaNN, source.MaTDLLCT, source.MaTTLV);

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH;
END;
GO
USE [master]
GO
ALTER DATABASE [HRMsystem] SET  READ_WRITE 
GO
