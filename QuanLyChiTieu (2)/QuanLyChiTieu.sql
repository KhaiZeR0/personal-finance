﻿USE master
GO

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
--select * from TaiKhoan
--select * from ChiTieu
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
	Thang FLOAT NOT NULL,
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
	MaTN INT NOT NULL,
	CONSTRAINT fk_TaiKhoan_ThuNhap FOREIGN KEY (MaTN) REFERENCES TaiKhoan(MaTK)
)
GO
-- Tạo bảng thu nhập
CREATE TABLE THONGKE
(
	ID INT IDENTITY PRIMARY KEY ,
	Thang FLOAT NOT NULL,
	TongTien FLOAT NOT NULL
)
GO


INSERT INTO THONGKE (Thang,TongTien) VALUES 
 (1,100000),
 (2,100000),
 (3,100000),
 (4,100000),
 (5,100000),
 (6,100000),
 (7,100000),
 (8,100000),
 (9,100000),
 (10,100000),
 (11,100000),
 (12,100000);
GO