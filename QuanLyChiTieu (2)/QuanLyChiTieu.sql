use master
go
CREATE DATABASE QuanLyChiTieu
GO

USE QuanLyChiTieu
GO

-- Tạo bảng tài khoản
CREATE TABLE TaiKhoan 
(
	MaTK INT PRIMARY KEY IDENTITY,
	TenTK VARCHAR(255) NOT NULL,
	MatKhau VARCHAR(1000) NOT NULL,
	Email_TK VARCHAR(255) NOT NULL,
)
select * from TaiKhoan
select * from ChiTieu
GO
-- Tạo bảng chi tiêu
CREATE TABLE ChiTieu 
(
	STT_CT INT IDENTITY PRIMARY KEY ,
	TenCT NVARCHAR(256),
	DMCT NVARCHAR(256) NOT NULL,
	SoTien FLOAT NOT NULL,
	SoLuong INT NOT NULL,
	GhiChu NVARCHAR(MAX),
	NgayChi DATE,
	SumChiTieu FLOAT, 
	MaCT INT NOT NULL,
	CONSTRAINT fk_TaiKhoan_ChiTieu FOREIGN KEY (MaCT) REFERENCES TaiKhoan(MaTK)
)
GO
-- Tạo bảng thu nhập
CREATE TABLE ThuNhap 
(
	STT_TN INT IDENTITY PRIMARY KEY ,
	SoTien FLOAT NOT NULL,
	GhiChu NVARCHAR(MAX),
	NgayThu DATE,
	SumThuNhap FLOAT,
	MaTN INT NOT NULL,
	CONSTRAINT fk_TaiKhoan_ThuNhap FOREIGN KEY (MaTN) REFERENCES TaiKhoan(MaTK)
)
GO

-- Cập nhật tổng chi tiêu
--UPDATE ChiTieu SET SumChiTieu = (SELECT SUM(ct.SoTien) FROM ChiTieu ct WHERE ct.MaCT = ChiTieu.MaCT) WHERE MaCT IN (SELECT MaTK FROM TaiKhoan)

-- Cập nhật tổng thu nhập
--UPDATE ThuNhap SET SumThuNhap = (SELECT SUM(tn.SoTien) FROM ThuNhap tn WHERE tn.MaTN = ThuNhap.MaTN) WHERE MaTN IN (SELECT MaTK FROM TaiKhoan)
