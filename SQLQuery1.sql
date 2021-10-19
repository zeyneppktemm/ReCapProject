CREATE TABLE Cars(
	Id int not null IDENTITY(1,1) primary key ,
	BrandId int,
	ColorId int,
	CarName varchar(255),
	ModelYear date,
	DailyPrice decimal,
	Description varchar(255)
)

DROP TABLE dbo.Cars

CREATE TABLE Brands(
	BrandId int not null IDENTITY(1,1) primary key,
	BrandName varchar(255)
)

DROP TABLE dbo.Brands

CREATE TABLE Colors(
	ColorId int not null IDENTITY(1,1) primary key,
	ColorName varchar(255)
)

DROP TABLE dbo.Colors
