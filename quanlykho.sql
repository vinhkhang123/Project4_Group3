create database kho
use kho 
go
create table phieunhap(
maphieunhap int identity(1,1) primary key not null,
ngaynhap datetime )
create table linhkien(
maphieunhap int not null,
malinhkien int identity primary key not null,
tenlinhkien varchar(20) not null,
soluong int not null )
select * from phieunhap
insert into phieunhap(ngaynhap) values('2023/08/11')
insert into phieunhap(ngaynhap) values('2023/08/12')

insert into linhkien(maphieunhap,tenlinhkien,soluong) values(1,'SDD 128GB',2)
insert into linhkien(maphieunhap,tenlinhkien,soluong) values(2,'HDD 128GB',4)

select * from linhkien

alter table linhkien ADD CONSTRAINT fk_ngoai  foreign key(maphieunhap)references phieunhap(maphieunhap) 
