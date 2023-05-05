﻿CREATE DATABASE QuanLyChiTieu
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
GO

-- Tạo bảng danh mục chi tiêu
CREATE TABLE DanhMucChiTieu 
(
	STT_DMCT INT IDENTITY PRIMARY KEY ,
	TenDMCT NVARCHAR(255) NOT NULL,
	MaTK INT NOT NULL,
	CONSTRAINT fk_TaiKhoan_DMCT FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK)
)
GO

-- Tạo bảng chi tiêu
CREATE TABLE ChiTieu 
(
	STT_CT INT IDENTITY PRIMARY KEY ,
	SoTien INT NOT NULL,
	NgayChi DATE NOT NULL,
	GhiChu NVARCHAR(MAX),
	MaDMCT INT NOT NULL,
	CONSTRAINT fk_DanhMucChiTieu_ChiTieu FOREIGN KEY (MaDMCT) REFERENCES DanhMucChiTieu(MaDMCT)
)
GO

-- Tạo bảng thu nhập
CREATE TABLE ThuNhap 
(
	STT_TN INT IDENTITY PRIMARY KEY ,
	SoTien INT NOT NULL,
	NgayThu DATE NOT NULL,
	GhiChu NVARCHAR(MAX),
	MaTK INT NOT NULL,
	CONSTRAINT fk_TaiKhoan_ThuNhap FOREIGN KEY (MaTK) REFERENCES TaiKhoan(MaTK)
)
GO