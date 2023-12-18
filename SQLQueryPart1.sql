create database Day8AssDb

use Day8AssDb

create table Products
(PId nvarchar(50) primary key ,
PName nvarchar(50) not null,
PPrice float not null,
MnfDate date not null,
ExpDate date not null)


insert into Products values('P00001','Laptop',40000.80,'09/05/2018','08/04/2025')
insert into Products values('P00002','Headphones',2000.80,'07/05/2021','03/06/2024')
insert into Products values('P00003','Smartphone',25000.99,'12/12/2023','11/12/2025')
insert into Products values('P00004','Videogame',10000.30,'11/25/2018','06/04/2021')
insert into Products values('P00005','Sunscreen Lotion',250.99,'12/01/2019','12/31/2020')
insert into Products values('P00006','TV',60000.0,'12/01/2022','12/31/2030')
insert into Products values('P00007','Washing Machine',250000,'11/09/2019','12/31/2025')
insert into Products values('P00008','Digital Watch',3000.66,'03/12/2018','12/11/2020')
insert into Products values('P00009','FaceScrub',200.99,'10/25/2023','07/13/2024')
insert into Products values('P00010','Fridge',30000.90,'11/01/2019','12/18/2027')

select  top 5 * from Products order by PName DESC

