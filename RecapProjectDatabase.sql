
Create Table Car(
CarId int primary key IDENTITY(1,1),
CarName varchar(100) NOT NULL,
BrandId int NOT NULL,
ColorId int NOT NULL,
ModelYear varchar(4) NOT NULL,
DailyPrice int NOT NULL,
Description varchar(100) NOT NULL,
)
Create Table Color(
ColorId int primary key IDENTITY(1,1),
ColorName varchar(50) NOT NULL,
)
Create Table Brand(
BrandId int primary key IDENTITY(1,1),
BrandName varchar(50) NOT NULL,
)
Insert Into Car values('Ford',1,1,2010,60000,'Temizdir');
Insert Into Car values('Opel',2,2,2000,30000,'2.el');

DELETE FROM Car WHERE BrandId =2;

Insert Into Brand values('Porshe');
Insert Into Brand values('Mercedes');
Insert Into Color values('white');
Insert Into Color values('black');

select * from Car
select * from Brand
select * from Color
DROP TABLE Car;