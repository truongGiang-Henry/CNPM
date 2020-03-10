use master
create database QLPT

use QLPT

/* Nếu không create được Diagram, vào proper của database - option - chọn bản cũ hơn của DB (2016) sau đó vào File, add tên "sa" */
/*
go
create table NhaTro(
	maNT char(5),
	diaChi Nvarchar (50) not null unique,
	primary key (maNT)
)

go 
create table NhanVien(
	maNV char(5),
	tenNV Nvarchar (50) not null,
	dienThoai int not null,
	diaChi nVarchar(50) not null unique,
	maNT char(5),
	constraint  NhanVien_NhaTro_MaNT foreign key (maNT) references NhaTro(maNT),
	primary key (maNV)
)
*/

go 
create FUNCTION DBO.AUTO_IDPT()
RETURNS varchar(5)
AS
BEGIN
	DECLARE @ID VARCHAR(5)
	IF (SELECT COUNT(maPT) FROM PhongTro) = 0
		SET @ID = '0'
	ELSE
		SELECT @ID = MAX(RIGHT(maPT, 3)) FROM PhongTro
		SELECT @ID = CASE
			WHEN @ID >= 0 and @ID < 9 THEN 'PT00' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
			WHEN @ID >= 9 THEN 'PT0' + CONVERT(CHAR, CONVERT(INT, @ID) + 1)
		END
	RETURN @ID
END
go
create table PhongTro(
	maPT char (5) DEFAULT DBO.AUTO_IDPT(),
	giaThue float not null,
	soNguoi int,
	moTa Nvarchar (100),
	primary key (maPT)
)
go 
create table KhachHang(
	CMND char(12),
	hoTen Nvarchar (50) not null,
	dienThoai int not null,
	maPT char(5),
	constraint  KhachHang_PhongTro_MaPT foreign key (maPT) references PhongTro(maPT),
	primary key (CMND)
)
go 
create table TaiKhoan(
	id char (10),
	username char(100),
	pwd char(100),
	primary key (id)
)
go 
create table HoaDon(
	maHD char(12),
	CMND char (12),
	maPT char (5),
	constraint HoaDon_PhongTro_MaPT foreign key (maPT) references PhongTro(maPT),
	constraint HoaDon_KhachHang_MaPT foreign key (CMND) references KhachHang(CMND),
	primary key (maHD)
)
insert into TaiKhoan values
	('3', 'admin', '12345')
	('1','Giang12345' , 'giangnguyen'),
	('2','By678910', 'ruby')

insert into PhongTro(giaThue, soNguoi, moTa) values
	(3000000, 3, N'Phòng cho 3 người thuê, không máy lạnh')
	(6000000, 3, N'Phòng cho 3 người thuê, có máy lạnh')

insert into KhachHang values
(51703010, N'Chế Hoàng Huy', 0123456789, 'PT001'),
(51703190, N'Thái Minh Thông', 0234567890, 'PT001') 