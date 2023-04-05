create database quanlykhachsan
go 
use quanlykhachsan
go 

drop table tb_khachhang
drop table tb_loaiphong
drop table tb_phong
drop table tb_CT_DP
drop table tb_datphong
drop table tb_DP_HH_DV
drop table tb_taikhoan
drop table tb_hanghoa_dichvu
drop table tb_nhacungcap
drop table tb_nhanvien
drop table tb_tang
drop table tb_thietbi



--------------------------Datphong
ALTER TABLE tb_datphong
DROP CONSTRAINT fk_datphong_phong;

ALTER TABLE tb_datphong
DROP CONSTRAINT fk_datphong_khachhang;

ALTER TABLE tb_datphong
DROP CONSTRAINT fk_datphong_nhanvien;


---------------------------Phong
ALTER TABLE tb_phong
DROP CONSTRAINT fk_phong_loaiphong;

ALTER TABLE tb_phong
DROP CONSTRAINT fk_phong_tang;

ALTER TABLE tb_phong
DROP CONSTRAINT fk_phong_thietbi;

--------------------------Chitietdatphong
ALTER TABLE tb_CT_DP
DROP CONSTRAINT fk_CT_DP_phong;

ALTER TABLE tb_CT_DP
DROP CONSTRAINT fk_CT_DP_datphong;

-----------------------------Datphong_hanghoa_dichvu
ALTER TABLE tb_DP_HH_DV
DROP CONSTRAINT fk_DPHHDV_CT_DP;

ALTER TABLE tb_DP_HH_DV
DROP CONSTRAINT fk_DPHHDV_HH_DV;

----------------------------Hanghoa_dichvu
ALTER TABLE tb_hanghoa_dichvu
DROP CONSTRAINT fk_hhdv_nhacungcap;

---------------
truncate table tb_CT_DP
truncate table tb_DP_HH_DV
truncate table tb_datphong
---------------------
create table tb_khachhang
(
	MaKH int primary key not null,
	TenKH nvarchar(50), 
	CCCD nvarchar(15), 
	DiaChi nvarchar(500), 
	DienThoai nvarchar(15), 
	GioiTinh bit,
	CREATED_DATE datetime
)

create table tb_nhanvien
(
	MaNV int primary key not null,
	TenNV nvarchar(50), 
	DiaChi nvarchar(500), 
	Email nvarchar(50), 
	DienThoai nvarchar(10), 
)

create table tb_loaiphong
(
	MaLoai int primary key not null,
	TenLoai  nvarchar(50), 
	DonGia float,
	SoGiuong int,
	SoNguoi int,
)

create table tb_thietbi
(
	MaTB int primary key not null,
	TenTB  nvarchar(50), 
)

create table tb_tang
(
	SoTang int primary key not null,
	TenTang  nvarchar(10), 
)

create table tb_phong
(
	MaPhong int primary key not null,
	TenPhong nvarchar(10), 
	TrangThai bit,
	MaLoai int,
	MaTB int,
	SoTang int,
	constraint fk_phong_loaiphong foreign key(MaLoai) references tb_loaiphong(MaLoai),
	constraint fk_phong_tang foreign key(SoTang) references tb_tang(SoTang),
	constraint fk_phong_thietbi foreign key(MaTB) references tb_thietbi(MaTB)
)

create table tb_nhacungcap
(
	MaNCC int primary key not null,
	TenNCC nvarchar(500), 
	DiaChi nvarchar(500), 
	DienThoai nvarchar(10),
)

create table tb_hanghoa_dichvu
(
	MaHH_DV int primary key not null,
	TenHH_DV nvarchar(50), 
	DonGia float,
	MaNCC int,
	constraint fk_hhdv_nhacungcap foreign key(MaNCC) references tb_nhacungcap(MaNCC)
)

create table tb_datphong
(
	MaDat int primary key not null,
	NgayDat datetime,
	NgayTra datetime,
	SoNguoiO int,
	TrangThai bit,
	SoTien float,
	CREATED_DATE datetime,
	UPDATE_BY int,
	UPDATE_DATE datetime,
	MaPhong int,
	MaKH int,
	MaNV int,
	constraint fk_datphong_phong foreign key(MaPhong) references tb_phong(MaPhong),
	constraint fk_datphong_khachhang foreign key(MaKH) references tb_khachhang(MaKH),
	constraint fk_datphong_nhanvien foreign key(MaNV) references tb_nhanvien(MaNV)
)

create table tb_CT_DP
(
	MaCT_DP int primary key not null,
	DonGia float,
	SoNgayO int,
	ThanhTien float,
	MaPhong int,
	MaDat int,
	constraint fk_CT_DP_phong foreign key(MaPhong) references tb_phong(MaPhong),
	constraint fk_CT_DP_datphong foreign key(MaDat) references tb_datphong(MaDat)
)

create table tb_DP_HH_DV
(
	MaDP_HH_DV int primary key not null,
	SoLuong int,
	DonGia float,
	ThanhTien float,
	MaPhong int,
	MaDat int,
	MaCT_DP int,
	MaHH_DV int,
	constraint fk_DPHHDV_CT_DP foreign key(MaCT_DP) references tb_CT_DP(MaCT_DP),
	constraint fk_DPHHDV_HH_DV foreign key(MaHH_DV) references tb_hanghoa_dichvu(MaHH_DV)
)

create table tb_func
(
	Func_Code nvarchar(50)  not null,
	Sort int not null,
	Description nvarchar(200),
	Isgroup bit,
	Parent nvarchar(50),
	Menu bit,
	Tips nvarchar(500),
	primary key(Func_Code,Sort)
)

create table tb_taikhoan
(
	TenDN nvarchar(40),
	TenNV nvarchar(40),
	MatKhau nvarchar(40),
	Quyen nvarchar(40)
)

/*-----------hanghoa_dichvu-------------*/
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (1,N'Giặc ủi quần áo','50000')
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (2,N'Cho thuê xe tự lái','200000')
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (3,N'Đặt vé máy bay, tour du lịch','100000')
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (4,N'Coca Cola','20000')
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (5,N'Nước suối','10000')
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (6,N'Redbull','20000')
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (7,N'Snack Khoai tây','15000')
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (8,N'Bánh quy Ritz','30000')
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (9,N'Bánh Kitkat','20000')
insert into tb_hanghoa_dichvu(MaHH_DV,TenHH_DV,DonGia) values (10,N'Trái cây','100000')

select * from tb_hanghoa_dichvu

/*-----------khachhang-------------*/
insert into tb_khachhang(MaKH,TenKH,CCCD,DiaChi,DienThoai,GioiTinh,CREATED_DATE) values (1,N'Nguyễn Văn Định','0791002223455',N'30 Trần Cao Vân, Phường 6, Quận 3, TP. Hồ Chí Minh','0842234234','True',NULL)
insert into tb_khachhang(MaKH,TenKH,CCCD,DiaChi,DienThoai,GioiTinh,CREATED_DATE) values (2,N'Trần Huyền Trang','079526473253',N'12 Thi Sách, Phường Bến Nghé, Quận 1, Thành phố Hồ Chí Minh','0363545444','False',NULL)
insert into tb_khachhang(MaKH,TenKH,CCCD,DiaChi,DienThoai,GioiTinh,CREATED_DATE) values (3,N'Võ Hoàng Khang','079213241323',N'364 Cộng Hòa, Q.Tân Bình, TP.Hồ Chí Minh','0954645666','True',NULL)
insert into tb_khachhang(MaKH,TenKH,CCCD,DiaChi,DienThoai,GioiTinh,CREATED_DATE) values (4,N'Lê Hoàng Nhất','079342341213',N'542 Cách Mạng Tháng 8, Phường 11, Quận 03 , Thành Phố Hồ Chí Minh','0353454355','True',NULL)
insert into tb_khachhang(MaKH,TenKH,CCCD,DiaChi,DienThoai,GioiTinh,CREATED_DATE) values (5,N'Hồ Thị Hoài Thương','079423523523',N'Số 1, Hoàng Diệu, Phường 13, Quận 4, Tp. Hồ Chí Minh','0923523535','False',NULL)
insert into tb_khachhang(MaKH,TenKH,CCCD,DiaChi,DienThoai,GioiTinh,CREATED_DATE) values (6,N'Nguyễn Minh Trong','097324324234',N'50 Lê Văn Việt, Thủ Đức, Hồ Chí Minh','0231231323','True',NULL)
insert into tb_khachhang(MaKH,TenKH,CCCD,DiaChi,DienThoai,GioiTinh,CREATED_DATE) values (7,N'Trần Thị Trà Mi','097213123213',N'100 Nguyễn Văn Tăng, Quận 9, Hồ Chí Minh','0945646343','False',NULL)
insert into tb_khachhang(MaKH,TenKH,CCCD,DiaChi,DienThoai,GioiTinh,CREATED_DATE) values (8,N'Nguyễn Văn Tiến','079234234388',N'88 Kha Vạn Cân, Thủ Đức, Hồ Chí Minh','0945345345','True',NULL)

select * from tb_khachhang

/*-----------nhanvien-------------*/
insert into tb_nhanvien(MaNV,TenNV,DiaChi,Email,DienThoai) values (1,N'Nguyễn Thị Trà Mi',N'57A Tháp Mười, P.2, Q.6','trami@gmail.com','0635345342')
insert into tb_nhanvien(MaNV,TenNV,DiaChi,Email,DienThoai) values (2,N'Trần Thanh Nam',N'50 Lê Lợi, P. Bến Thành, Q.1','thanhnam@gmail.com','9346456456')
insert into tb_nhanvien(MaNV,TenNV,DiaChi,Email,DienThoai) values (3,N'Võ Hoàng Khang ',N'36 An Dương Vương, P.9, Q.5','hoangkhang@gmail.com','0845646363')
insert into tb_nhanvien(MaNV,TenNV,DiaChi,Email,DienThoai) values (4,N'Nguyễn Văn Tiến',N'69 Lý Thường Kiệt, P.8, Q. Tân Bình','vantien@gmail.com','0653453453')
insert into tb_nhanvien(MaNV,TenNV,DiaChi,Email,DienThoai) values (5,N'Lê Thị Bảo Ngọc',N'545 Trần Hưng Đạo, P.14, Q.5','baongoc@gmail.com','0823534346')
insert into tb_nhanvien(MaNV,TenNV,DiaChi,Email,DienThoai) values (6,N'Võ Ngọc Bảo Trâm ',N'35 Châu Văn Liêm,  P.14, Q.5','baotram@gmail.com','0933463655')

select * from tb_nhanvien


/*-----------loaiphong-------------*/
insert into tb_loaiphong(MaLoai,TenLoai,DonGia,SoGiuong,SoNguoi) values (1,N'Thường',300000,1,2)
insert into tb_loaiphong(MaLoai,TenLoai,DonGia,SoGiuong,SoNguoi) values (2,N'Thường',400000,2,4)
insert into tb_loaiphong(MaLoai,TenLoai,DonGia,SoGiuong,SoNguoi) values (3,N'VIP',500000,1,2)
insert into tb_loaiphong(MaLoai,TenLoai,DonGia,SoGiuong,SoNguoi) values (4,N'VIP',700000,2,4)

select * from tb_loaiphong

/*-----------tang-------------*/
insert into tb_tang(SoTang,TenTang) values (1,N'Tầng 1')
insert into tb_tang(SoTang,TenTang) values (2,N'Tầng 2')
insert into tb_tang(SoTang,TenTang) values (3,N'Tầng 3')
insert into tb_tang(SoTang,TenTang) values (4,N'Tầng 4')

select * from tb_tang


/*-----------thietbi-------------*/
insert into tb_thietbi(MaTB,TenTB) values (1,N'Giường ngủ')
insert into tb_thietbi(MaTB,TenTB) values (2,N'Tủ quần áo')
insert into tb_thietbi(MaTB,TenTB) values (3,N'Bàn, ghế')
insert into tb_thietbi(MaTB,TenTB) values (4,N'Ga, gối, chăn')
insert into tb_thietbi(MaTB,TenTB) values (5,N'Máy lạnh')
insert into tb_thietbi(MaTB,TenTB) values (6,N'Điện thoại bàn')
insert into tb_thietbi(MaTB,TenTB) values (7,N'Tivi')
insert into tb_thietbi(MaTB,TenTB) values (8,N'Tủ lạnh')

select * from tb_thietbi

/*-----------nhacungcap-------------*/
insert into tb_nhacungcap(MaNCC,TenNCC,DiaChi,DienThoai) values (1,N'Công Ty TNHH phát triển thương mại tổng hợp Thiên Việt',N'121 Trần Bình Trọng, Phường 02, Quận 5, Tp. Hồ Chí Minh','0935345345')
insert into tb_nhacungcap(MaNCC,TenNCC,DiaChi,DienThoai) values (2,N'Công Ty TNHH phát triển thương mại ACCORD',N'39 Bế Văn Đàn, Phường 14, Quận Tân Bình, Tp. Hồ Chí Minh','0834343444')
insert into tb_nhacungcap(MaNCC,TenNCC,DiaChi,DienThoai) values (3,N'Doanh nghiệp tư nhân Ngọc Cường',N'Đường E1, Phường 7, Quận 8, Tp. Hồ Chí Minh','0945457454')

select * from tb_nhacungcap

/*-----------taikhoan-------------*/
insert into tb_taikhoan(TenDN,TenNV,MatKhau,Quyen) values (N'User01',N'Trần Thanh Nam','nam123', 'user')
insert into tb_taikhoan(TenDN,TenNV,MatKhau,Quyen) values (N'Admin',N'Võ Hoàng Khang','khang321', 'admin')

select * from tb_taikhoan

/*-----------phong-------------*/
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (101,1,1,N'Phòng 101','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (102,2,1,N'Phòng 102','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (103,3,1,N'Phòng 103','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (104,3,1,N'Phòng 104','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (201,2,2,N'Phòng 201','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (202,3,2,N'Phòng 202','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (203,4,2,N'Phòng 203','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (204,4,2,N'Phòng 204','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (301,3,3,N'Phòng 301','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (302,3,3,N'Phòng 302','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (303,4,3,N'Phòng 303','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (304,4,3,N'Phòng 304','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (401,3,4,N'Phòng 401','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (402,4,4,N'Phòng 402','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (403,4,4,N'Phòng 403','False')
insert into tb_phong(MaPhong,MaLoai,SoTang,TenPhong,TrangThai) values (404,4,4,N'Phòng 404','False')


select * from tb_phong

truncate table tb_phong

/*-----------func-------------*/
insert into tb_func(Func_Code,Sort,Description,Isgroup,Parent,Menu,Tips) values ('DANHMUC','1',N'DANHMUC','true',NULL,'true',N'Danh mục chung')
insert into tb_func(Func_Code,Sort,Description,Isgroup,Parent,Menu,Tips) values ('DATPHONG','1',N'Quản lý đặt phòng','False','DANHMUC','true',NULL)
insert into tb_func(Func_Code,Sort,Description,Isgroup,Parent,Menu,Tips) values ('DICHVU','4',N'Quản lý dịch vụ','False','DANHMUC','true',NULL)
insert into tb_func(Func_Code,Sort,Description,Isgroup,Parent,Menu,Tips) values ('LOAIPHONG','2',N'Quản lý loại phòng','False','DANHMUC','true',NULL)
insert into tb_func(Func_Code,Sort,Description,Isgroup,Parent,Menu,Tips) values ('THIETBI','3',N'Quản lý thiết bị','False','DANHMUC','true',NULL)

select * from tb_func



select A.MaPhong,A.TenPhong, C.DonGia, A.SoTang, B.TenTang from tb_phong A, tb_tang B,tb_loaiphong C where A.SoTang = B.SoTang and A.TrangThai = 0 and A.MaLoai = C.MaLoai


select A.MaPhong,A.TenPhong, C.DonGia, A.SoTang, B.TenTang from tb_phong A, tb_tang B,tb_loaiphong C, tb_CT_DP D where A.SoTang = B.SoTang and A.MaLoai = C.MaLoai and A.MaPhong = D.MaPhong 
