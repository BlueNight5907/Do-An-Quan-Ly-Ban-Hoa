
Create database QuanLyBanHoa

go
Use QuanLyBanHoa

go



create table NhanVien(
	MaNV int IDENTITY(1,1) primary key,
	TenNV nvarchar(100) not null,
	NgaySinh Date not null,
	GT bit default(0) not null,
	CMND char(20) not null,
	sdt char(11) not null,
	diachi nvarchar(100) not null,
	NgayVaoLam date Default getdate(),
	Luong int default(2800000),
	ChucVu nvarchar(100) default(N'Nhân viên'),
	activated bit default(1)
);
go
create table TaiKhoan(
	TenDangNhap char(20) COLLATE SQL_Latin1_General_CP1_CS_AS primary key,
	MatKhau char(20) COLLATE SQL_Latin1_General_CP1_CS_AS NOT NULL,
	TenHienThi nvarchar(100)  not null,
	MaNV int not null,
);
go
create table PhanQuyen(
	TenDangNhap char(20) COLLATE SQL_Latin1_General_CP1_CS_AS  NOT NULL primary key references TaiKhoan(TenDangNhap),
	permission nvarchar(20) not null,
);
go
create table LoaiHangHoa(
	MaLoai char(10) not null primary key,
	TenLoai nvarchar(100),
);
go
create table NhaCungCap(
	MaNCC int IDENTITY(1,1) primary key,
	TenNCC nvarchar(100) not null,
	sdt char(11) not null,
	diachi nvarchar(100) not null,
);
go
create table HangHoa(
	
	MaHH int IDENTITY(1,1) not null primary key,
	MaNCC int,
	Ten nvarchar(100) not null ,
	MaLoai char(10) references LoaiHangHoa(Maloai) ,
	GiaNhap int default(0) check(gianhap >0),
	GiaBan int default(1000) check(giaban>0),
	foreign key(MaNCC) references NhaCungCap(MaNCC),
	activated bit default(1)
);
go
create table HangHoaIMG(
	MaHH int primary key references HangHoa(MaHH),
	IMG image
);
go
create table KhuyenMai(
	MaHH int primary key references HangHoa(Mahh) not null,
	KhuyenMai int default(0) not null check(khuyenmai>=0),
);
go
create table QuanLyHangHoa(
	MaHH int not null,
	SoLuong int not null check(soluong>=0),
	primary key(MaHH),
);
go
create table NhapHang(
	MaNH int IDENTITY(1,1) primary key not null,
	MaNV int references NhanVien(manv),
	DateCheckIn Date default getdate(),
	MaNCC int references NhaCungCap(MaNCC),
	TongTien int,
);
go
create table ChiTietNhapHang(
	ID int IDENTITY(1,1) primary key,
	MaNH int not null,
	MaHH int not null,
	GiaNhap int,
	SoLuong int not null check(soluong>=0),
	ThanhTien int,
	foreign key(MaHH) references HangHoa(MaHH),
);
go
create table KhachHang(
	MaKH int IDENTITY(1,1) primary key,
	TenKH nvarchar(100) not null,
	sdt char(11) not null,
);
go
create table QuanLyKHThanThiet(
	MaKH int primary key references KhachHang(MaKH),
	Discount int,
);
go
create table HoaDon(
	MaHD int IDENTITY(1,1) primary key not null,
	MaKH int not null,
	MaNV int not null,
	DateCheckIn Date default getdate(),
	TongTien int not null check(tongtien>0),
	TienGiam int not null check(tiengiam>=0),
	ThanhToan int not null check(thanhtoan>0),
	TrangThai bit default(1) not null,
	foreign key(makh) references KhachHang(MaKH),
	foreign key(manv) references NhanVien(manv),
);
go
create table ChiTietHoaDon(
	ID int IDENTITY(1,1) primary key,
	MaHD int not null,
	MaHH int not null,
	SoLuong int not null default(1) check(soluong>=0),
	ThanhTien int not null check(Thanhtien>0),
	foreign key(mahd) references HoaDon(mahd),
);
go
create table Discount(
	ID int IDENTITY(1,1) primary key,
	Discount int
)
go
----------------------------Them tai khoan
create PROC ThemTaiKhoan 
(@user char(20), @pass char(20), @permision nvarchar(20), @hienthi nvarchar(100),@ID int)
AS
BEGIN
	if not exists(select * from TaiKhoan where TenDangNhap = @user)
	begin
		insert into TaiKhoan(TenDangNhap,MatKhau,TenHienThi,MaNV) 
		values(@user,@pass,@hienthi,@ID);
		insert into PhanQuyen(TenDangNhap,permission) values(@user,@permision);
	end
	else
	begin
		update TaiKhoan set MatKhau = @pass , TenHienThi = @hienthi where TenDangNhap = @user;
		update PhanQuyen set permission = @permision where TenDangNhap = @user;
	end
END;
go
------------------------------Lấy toạn bộ thông tin các tài khoản
create Proc GetAllUser
as
BEGIN
	select NhanVien.MaNV,TenNV,TenHienThi,TaiKhoan.TenDangNhap, MatKhau,permission from NhanVien left join TaiKhoan on NhanVien.MaNV = TaiKhoan.MaNV left join PhanQuyen on TaiKhoan.TenDangNhap = PhanQuyen.TenDangNhap;
END;
go


-------------------------------QuanLyTaiKhoan
create PROC	QuanLyTaiKhoan
as
select * from TaiKhoan
go
-------------------------------Danh muc san pham
create PROC	DanhMucSanPham
as
	select HangHoa.MaHH,Ten,LoaiHangHoa.MaLoai,TenLoai,GiaNhap,GiaBan,SoLuong from HangHoa inner join LoaiHangHoa on HangHoa.MaLoai = LoaiHangHoa.MaLoai 
	inner join QuanLyHangHoa on QuanLyHangHoa.MaHH = HangHoa.MaHH where HangHoa.activated = 1;
go

-------------------------------Danh muc san pham kem img
create PROC	DanhMucSanPhamKemAnh
(@ID int,@name nvarchar(100),@MaLoai char(20),@Gia1 int,@Gia2 int)
as
	if @name ='All'
	Begin
		select HangHoa.MaHH,Ten,IMG,GiaNhap,GiaBan from HangHoa left Join HangHoaIMG on HangHoa.MaHH = HangHoaIMG.MaHH where HangHoa.activated = 1;
	end
	else
	Begin
		select HangHoa.MaHH,Ten,IMG,GiaNhap,GiaBan from HangHoa left Join HangHoaIMG on HangHoa.MaHH = HangHoaIMG.MaHH where HangHoa.activated = 1 and(HangHoa.MaLoai = @MaLoai or HangHoa.Ten like concat('%',@name,'%') or HangHoa.MaHH = @ID); 
	end
go

-- Drop proc DanhMucSanPhamKemAnh

------------------------------Tim san pham
create PROC	TimSanPham(@ID int, @Ten nvarchar(100))
as
	select HangHoa.MaHH,Ten,LoaiHangHoa.MaLoai,TenLoai,GiaNhap,GiaBan,SoLuong from HangHoa inner join LoaiHangHoa on HangHoa.MaLoai = LoaiHangHoa.MaLoai 
	inner join QuanLyHangHoa on QuanLyHangHoa.MaHH = HangHoa.MaHH where HangHoa.activated = 1 and (HangHoa.MaHH = @ID or HangHoa.Ten like ConCat('%',@Ten,'%'))
go
--drop proc TimSanPham
-------------------------------XoaTaiKhoan
create PROC XoaTaiKhoan 
(@user char(100))
AS
BEGIN
	if not exists(select * from TaiKhoan inner join PhanQuyen on TaiKhoan.TenDangNhap = PhanQuyen.TenDangNhap
	where TaiKhoan.TenDangNhap = @user and permission = N'Admin')
		delete from TaiKhoan where TenDangNhap = @user;
END;
go
-------------------------------Xoa san pham
create PROC XoaSanPham 
(@ID int)
AS
BEGIN
	delete from HangHoaIMG where MaHH = @ID;
	update HangHoa set activated = 0 where MaHH = @ID;
END;
go

--------------------------------Hien thi loai san pham
create PROC LoaiSanPham 
AS
BEGIN
	select * from LoaiHangHoa;
END;
go
--------------------------------Hien thi nha cung cap
create PROC NhaCC 
AS
BEGIN
	select * from NhaCungCap;
END;
go
----------------------------------------cap nhat img
create Proc CapNhatIMGHangHoa
(@MaHH int,@img image)
as
begin
	if not exists(select * from HangHoaIMG where @MaHH = MaHH)
	 begin
		insert into HangHoaIMG values(@MaHH,@img);
	 end
	 else
	 begin
		update HangHoaIMG
		set IMG = @img
		from HangHoaIMG
		where Mahh = @MaHH
	 end
end;
go
--------------------------------
create PROC CapNhatSanPham 
(@ID int,@tenhh nvarchar(100),@maloai char(20),@gianhap int,@giaban int,@img image)
AS
BEGIN
	update HangHoa
	set HangHoa.Ten = @tenhh, HangHoa.MaLoai = @maloai,GiaNhap =@gianhap,GiaBan = @giaban
	from HangHoa
	where HangHoa.MaHH = @ID;
	exec CapNhatIMGHangHoa @ID, @img;

END;
go

--------------------------------Trigger Xoa Phan Quyen
Create trigger trg_XoaPhanQuyen on TaiKhoan after delete as
begin
	delete from PhanQuyen where TenDangNhap = (select TenDangNhap from deleted);
end
go
---------------------------------
Create trigger trg_ChiTietHoaDon on ChiTietHoaDon after insert as
begin
	update QuanLyHangHoa
	set SoLuong = SoLuong - (select SoLuong from inserted)
	from QuanLyHangHoa
	where (select MaHH from inserted) = QuanLyHangHoa.mahh;
	declare @soluong int;
	set @soluong = (select soluong from Quanlyhanghoa where (select MaHH from inserted) = quanlyhanghoa.mahh);
	if @soluong < 0
		rollback tran;
		return;
end
go

----------------------------------------------------------------
Create trigger trg_ChiTietNhapHang on ChiTietNhapHang after insert as
begin
	update HangHoa
	set GiaNhap = (select GiaNhap from inserted)
	from HangHoa
	where (select MaHH from inserted) = HangHoa.mahh;
	update QuanLyHangHoa
	set SoLuong = SoLuong + (select SoLuong from inserted)
	from QuanLyHangHoa
	where QuanLyHangHoa.mahh = (select MaHH from inserted);
end
go

---------------------------------------------------------------
Create trigger CapNhatKhachHangThanThiet on HoaDon after insert as
begin
	declare @TongTien int;
	declare @Discount int;
	set @TongTien = (select Sum(TongTien) from HoaDon where MaKH = HoaDon.MaKH);
	if @TongTien > 5000000 and @TongTien <= 20000000
		set @Discount = 1;
	else if @TongTien >20000000 and @TongTien <= 50000000
		set @Discount = 2;
	else if @TongTien >50000000
		set @Discount = 3;
	if(not exists(select * from QuanLyKHThanThiet where MaKH = QuanLyKHThanThiet.MaKH))
		insert into QuanLyKHThanThiet(MaKH,Discount) 
			select makh,Discount from KhachHang,Discount where MaKH = KhachHang.MaKH and Discount.ID = @Discount;
	else
		update QuanLyKHThanThiet
		set Discount = @Discount
		from QuanLyKHThanThiet
		where MaKH = QuanLyKHThanThiet.MaKH;
	
end
go
----------------Kiem tra tai khoan co ton tai trong he thong khong, neu co thi lay thong tin
create proc CheckAccount(@username char(100),@password char(20))
as
begin
	select TenHienThi,NgaySinh,GT,CMND,sdt,diachi,NgayVaoLam, TaiKhoan.TenDangNhap,MatKhau,NhanVien.MaNV, TenNV,permission  from TaiKhoan inner join NhanVien on TaiKhoan.MaNV = NhanVien.MaNV inner join PhanQuyen on PhanQuyen.TenDangNhap = TaiKhoan.TenDangNhap
	where taikhoan.TenDangNhap = @username and MatKhau = @password;
end
go

-----------------------------------Cap nhat so luong
create PROC CapNhatSoLuong 
(@MaHH int,@Soluong int)
AS
BEGIN
	 if not exists(select * from QuanLyHangHoa where @MaHH = MaHH)
	 begin
		insert into QuanLyHangHoa(MaHH,SoLuong)
		values(@MaHH,@Soluong);
	 end
	 else
	 begin
		update QuanLyHangHoa
		set SoLuong = @Soluong
		from QuanLyHangHoa
		where Mahh = @MaHH
	 end

END;
go
----------------------------------------Load img
create Proc LoadIMG
(@MaHH int)
as
begin
	if not exists(select * from HangHoaIMG where @MaHH = MaHH)
	 begin
		select * from HangHoaIMG where @MaHH = MaHH;
	 end
	 else
	 begin
		select * from HangHoaIMG where @MaHH = MaHH;
	 end
end;
go



-----------------------------------them hang hoa
create PROC ThemSanPham 
(@MANCC int,@tenhh nvarchar(100),@maloai char(20),@gianhap int,@giaban int,@soluong int,@img image)
AS
BEGIN
	declare @id int;
	insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
	(@MANCC,@tenhh,@maloai,@giaban,@giaban);
	select MaHH from HangHoa where MaNCC = @MANCC and Ten = @tenhh and MaLoai = @maloai and GiaNhap = @gianhap and GiaBan = @giaban
	set @id = (SELECT TOP 1 MaHH FROM HangHoa ORDER BY MaHH DESC );
	exec CapNhatSoLuong @id,@soluong;
	exec CapNhatIMGHangHoa @id, @img;
END;
go
---------------------------------------
----------------------------Nhap Hang
create PROC NhapHangVaoKho
(@manv int,  @mancc int, @tongtien int)
AS
BEGIN
	insert into NhapHang(MaNV,MaNCC,TongTien) 
	values(@manv,@mancc,@tongtien);
	SELECT TOP 1 MaNH from NhapHang ORDER BY MaNH DESC;
	
END;
go
---------------------------Nhập hóa đơn
create PROC NhapHoaDon
(@makh int, @manv int, @tongtien int ,@tiengiam int,@pay int)
AS
BEGIN
	insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan) 
	values(@makh, @manv , @tongtien ,@tiengiam ,@pay);
	SELECT TOP 1 MaHD from HoaDon ORDER BY MaHD DESC;
	
END;
go
-----------------------------Nhập hóa đơn chi tiết
create PROC NhapHoaDon_ChiTiet
(@mahd int,  @mahh int, @soluong int, @thanhtien int)
AS
BEGIN
	insert into ChiTietHoaDon
	values(@mahd,  @mahh, @soluong, @thanhtien);
END;
go

---------------------------Nhập thông tin khách hàng

create PROC NhapKhachHang
(@name nvarchar(100),  @sdt char(11))
AS
BEGIN
	if not exists(select MaKH from KhachHang where sdt = @sdt and TenKH = @name)
		begin
			insert into KhachHang
			values(@name, @sdt);
			SELECT TOP 1 MaKH from KhachHang ORDER BY MaKH DESC;
		end
	else
		select MaKH from KhachHang where sdt = @sdt and TenKH = @name
END;
go
----------------
----------------------------Nhap Hang chi tiet
create PROC NhapHangVaoKho_ChiTiet
(@manh int,  @mahh int,@gianhap int,@soluong int, @thanhtien int)
AS
BEGIN
	insert into ChiTietNhapHang
	values(@manh,@mahh,@gianhap,@soluong, @thanhtien);
END;
go
----------------
----------------------------Lich su nhap hang
create PROC LichSuNhapHang
(@thoigian date)
AS
BEGIN
	select Ten,TenNV,NhapHang.MaNH,ChiTietNhapHang.GiaNhap,SoLuong,ThanhTien,TongTien  From ChiTietNhapHang inner join NhapHang on NhapHang.MaNH = ChiTietNhapHang.MaNH inner join HangHoa on HangHoa.MaHH = ChiTietNhapHang.MaHH 
	inner join NhanVien on NhanVien.MaNV = NhapHang.MaNV where NhapHang.DateCheckIn = @thoigian
END;
go
----------------
create proc KhachHangTiemNang
(@month int, @year int)
as
Begin
	select top 10 KhachHang.MaKH,TenKH,Sdt, sum(ThanhToan) as tieuthu,count(KhachHang.MaKH) as solanden from
	KhachHang inner join HoaDon on KhachHang.MaKH = HoaDon.MaKH where month(HoaDon.DateCheckIn)=@month and year(HoaDon.DateCheckIn) = @year group by KhachHang.MaKH,TenKH,sdt
	order by tieuthu desc;
end
go

-- ---------------------------------------Đổ dữ liệu
insert into NhanVien values(N'Nguyễn Văn Huy','11/18/2000',0,'261583149','0376466945',N'632 Lê Văn Lương, Tân Phong, Quận 7, TP.HCM',GETDATE(),4000000,N'Quản Lý',1);
go

insert into NhanVien values(N'Phan Khánh Vinh','03/6/2000',0,'123456789','0888292450',N'Trường đại học Tôn Đức Thắng, Tân Phong, Quận 7, TP.HCM',GETDATE(),3000000,N'Nhân viên',1);
go

insert into NhanVien values(N'Tăng cẩm phú','5/7/2000',0,'987654321','0225104392',N'Phước Kiểng, Quận 7, TP.HCM',GETDATE(),3000000,N'Nhân viên',1);
go
insert into NhanVien values(N'Cao Thị Hà','2/29/2000',1,'973534631','0822365142',N'60/13 Ung Văn Khiêm, Quận Bình Thạnh, TP.HCM',GETDATE(),3000000,N'Nhân viên',1);
go

exec ThemTaiKhoan 'HuyAdmin', 'admin', N'Admin', N'Huy(Admin)',1;
exec ThemTaiKhoan 'Usertest1', 'nopassword', N'Nhân viên', N'Vinh(Nhân viên)',2;
go
insert into NhaCungCap(TenNCC,diachi,sdt) values(N'Long thương lái','632, lê văn lương,tân phong quận 7','0376466945');
go
insert into NhaCungCap(TenNCC,diachi,sdt) values(N'Vườn ươm Nụ Hồng','632, lê văn lương,tân phong quận 7','0123456789');
go
insert into LoaiHangHoa(MaLoai,TenLoai) values
('H01',N'Hoa tươi');
go
insert into LoaiHangHoa(MaLoai,TenLoai) values
('H02',N'Hoa lụa');
go
insert into LoaiHangHoa(MaLoai,TenLoai) values
('H03',N'Hoa giấy');
go
insert into LoaiHangHoa(MaLoai,TenLoai) values
('X01',N'Xương rồng');
go
insert into LoaiHangHoa(MaLoai,TenLoai) values
('P01',N'Chậu cảnh');
go
insert into LoaiHangHoa(MaLoai,TenLoai) values
('G01',N'Vật dụng trang trí');
go
insert into NhaCungCap(TenNCC,sdt,diachi) values
('Huy','12345','tp HCM');
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Hoa Lan','H01',5000,10000);
go

insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Hoa Lan','H01',5000,10000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Hoa Huệ','H01',5000,10000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Hoa Hướng Dương','H01',5000,10000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Hoa Hồng','H01',5000,10000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Hoa Vạn Thọ','H01',5000,10000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Tình yêu vĩnh cửu','H01',500000,10000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Lẳng Hoa Cẩm tú cầu','H02',5000,10000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Giấy bóng','G01',7000,9000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Nơ','G01',5000,60000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Xương rồng tai thỏ','X01',150000,200000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Xương rồng tai thỏ','X01',100000,130000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Xương rồng bát tiên','X01',200000,240000);
go
insert into HangHoa(MaNCC,Ten,MaLoai,GiaNhap,GiaBan) values
(1,N'Xương rồng thanh sơn','X01',150000,180000);
go

-- ---------------------------------- Thêm dữ liệu vào bảng nhân viên
insert into QuanLyHangHoa(MaHH,SoLuong)
values(1,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(2,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(3,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(4,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(5,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(6,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(7,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(8,10000);
insert into QuanLyHangHoa(MaHH,SoLuong)
values(9,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(10,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(11,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(12,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(13,10000);
go
insert into QuanLyHangHoa(MaHH,SoLuong)
values(14,10000);
go
insert into Discount(Discount) values(5);
go
insert into Discount(Discount) values(10);
go
insert into Discount(Discount) values(15);
go
insert into KhachHang(TenKH,sdt) values
(N'Nguyễn Văn Hùng','0375466945');
go
insert into KhachHang(TenKH,sdt) values
(N'Nguyễn Thị Lụa','0376556945');
go
insert into KhachHang(TenKH,sdt) values
(N'Nguyễn Văn Chương','0377233045');
go
insert into KhachHang(TenKH,sdt) values
(N'Hồng Thất Công','0373412333');
go
insert into KhachHang(TenKH,sdt) values
(N'Tạ Văn Nam','0225114321');
go
insert into KhachHang(TenKH,sdt) values
(N'Trần Văn Hùng','0377466945');
go
insert into KhachHang(TenKH,sdt) values
(N'Hà Thị Lụa','0376557945');
go
insert into KhachHang(TenKH,sdt) values
(N'Phùng Văn Chương','0371233045');
go
insert into KhachHang(TenKH,sdt) values
(N'Hoàng Thất Công','0353412333');
go
insert into KhachHang(TenKH,sdt) values
(N'Lê Văn Nam','0224114321');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(1,1,1000000,100000,900000,1,'12/5/2020');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(2,1,400000,0,400000,1,'12/5/2020');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(3,1,900000,0,900000,1,'12/5/2020');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(4,1,900000,90000,810000,1,'12/5/2020');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(5,1,900000,0,900000,1,'12/5/2020');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(6,1,1000000,0,1000000,1,'12/5/2020');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(7,1,170000,20000,150000,1,'12/5/2020');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(8,1,150000,0,150000,1,'12/5/2020');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(9,1,2000000,0,2000000,1,'12/5/2020');
go
insert into HoaDon(MaKH,MaNV,TongTien,TienGiam,ThanhToan,TrangThai,DateCheckIn)
values(10,1,100000,0,100000,1,'12/5/2020');
go


