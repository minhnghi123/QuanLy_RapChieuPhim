IF EXISTS(SELECT 1 FROM sys.databases WHERE name ='QL_RapChieuPhim')
	DROP DATABASE [QL_RapChieuPhim]
GO
Create database [QL_RapChieuPhim]
GO

use [QL_RapChieuPhim]
GO

CREATE TABLE [USER](
	Id INT PRIMARY KEY IDENTITY(1, 1),
	UserName VARCHAR(20) NOT NULL,
	[PassWord] VARCHAR(20) NOT NULL
)
GO
INSERT INTO [USER] (UserName,[PassWord]) VALUES ('user','123')
INSERT INTO [USER] (UserName,[PassWord]) VALUES ('admin','123')
GO

CREATE TABLE Phim (
    MaPhim INT PRIMARY KEY IDENTITY(1, 1),
    TenPhim NVARCHAR(250) NOT NULL,
    DaoDien NVARCHAR(250),
    DienVien NVARCHAR(250),
    TheLoai NVARCHAR(250),
    ThoiLuong INT,
    MoTa NVARCHAR(MAX),
)

GO
INSERT INTO [Phim] (TenPhim, DaoDien, DienVien, TheLoai, ThoiLuong, MoTa)
VALUES (N'Bố Già', N'Trấn Thành', N'Trấn Thành, Tuấn Trần, Ngọc Giàu', N'Hài-Chính kịch', 128, N'Lấy bối cảnh tại Thành phố Hồ Chí Minh, nội dung phim xoay quanh mỗi quan hệ giữa ông Sang – một người luôn lo chuyện bao đồng và giúp đỡ người khác – và con trai ông là Quắn – một cậu thanh niên kiếm tiền bằng Youtube rất yêu thương ba và em gái – cùng những rắc rối mà cả hai gặp phải với những người thân trong gia đình mình.')
GO

CREATE TABLE RapChieu (
    MaRapChieu INT PRIMARY KEY IDENTITY(1, 1),
    TenRap NVARCHAR(250) NOT NULL,
    DiaChi NVARCHAR(250)
)
GO
INSERT INTO [RapChieu] (TenRap, DiaChi)
VALUES (N'CGV Bình Dương', N'Bình Dương')
INSERT INTO [RapChieu] (TenRap, DiaChi)
VALUES (N'BETA Cinemas Empire', N'Bình Dương')
GO

CREATE TABLE PhongChieu (
    MaPhongChieu INT PRIMARY KEY IDENTITY(1, 1),
    MaRapChieu INT NOT NULL,
    SoGhe INT,
    FOREIGN KEY (MaRapChieu) REFERENCES RapChieu(MaRapChieu)
)
GO

CREATE TABLE GheNgoi (
    MaGheNgoi INT PRIMARY KEY IDENTITY(1, 1),
    MaPhongChieu INT NOT NULL,
    SoGhe INT NOT NULL,
    LoaiGhe VARCHAR(255),
    TrangThai VARCHAR(255),
    FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhongChieu)
)
GO

CREATE TABLE SuatChieu (
    MaSuatChieu INT PRIMARY KEY IDENTITY(1, 1),
    MaPhim INT NOT NULL,
    MaPhongChieu INT NOT NULL,
    ThoiGianChieu DATETIME NOT NULL,
    GiaVe DECIMAL(10,2),
    FOREIGN KEY (MaPhim) REFERENCES Phim(MaPhim),
    FOREIGN KEY (MaPhongChieu) REFERENCES PhongChieu(MaPhongChieu)
)
GO

CREATE TABLE NguoiDung (
    MaNguoiDung INT PRIMARY KEY IDENTITY(1, 1),
    HoTen VARCHAR(255) NOT NULL,
    Email VARCHAR(255) NOT NULL,
    SDT VARCHAR(255),
    DiaChi VARCHAR(255)
)
GO

CREATE TABLE Ve (
    MaVe INT PRIMARY KEY IDENTITY(1, 1),
    MaSuatChieu INT NOT NULL,
    MaGheNgoi INT NOT NULL,
    MaNguoiDung INT NOT NULL,
    GiaVe DECIMAL(10,2),
    MaGiamGia VARCHAR(255),
    PhuongThucThanhToan VARCHAR(255),
    NgayDat DATETIME NOT NULL,
    TrangThai VARCHAR(255),
    FOREIGN KEY (MaSuatChieu) REFERENCES SuatChieu(MaSuatChieu),
    FOREIGN KEY (MaGheNgoi) REFERENCES GheNgoi(MaGheNgoi),
    FOREIGN KEY (MaNguoiDung) REFERENCES NguoiDung(MaNguoiDung)
)
GO