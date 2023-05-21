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
	Thang FLOAT ,
	TongTien FLOAT 
)
GO


INSERT INTO THONGKE (Thang) VALUES 
 (1),
 (2),
 (3),
 (4),
 (5),
 (6),
 (7),
 (8),
 (9),
 (10),
 (11),
 (12);
GO