
Create Table Car(
Id int primary key IDENTITY(1,1),
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
Insert Into Car values(1,1,2010,60000,'Hyundai');
Insert Into Car values(2,4,2000,30000,'Opel');

DELETE FROM Car WHERE BrandId =2;

Insert Into Brand values('Porshe');
Insert Into Brand values('Mercedes');
Insert Into Color values('white');
Insert Into Color values('black');

select * from Car
select * from Brand
select * from Color