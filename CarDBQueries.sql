CREATE DATABASE CarDatabase

CREATE TABLE Car (
	Id int,
	BrandId int,
	ColorId int,
	CarName nvarchar(20),
	ModelYear int,
	DailyPrice decimal,
	Info text
)

CREATE TABLE Brand (
	Id int,
	BrandName nvarchar(20)
)

CREATE TABLE Color (
	Id int,
	ColorName nvarchar(20)
)

INSERT INTO Brand VALUES (1, 'BMW')
INSERT INTO Brand VALUES (2, 'Mercedes')
INSERT INTO Brand VALUES (3, 'Honda')
INSERT INTO Color VALUES (1, 'Black')
INSERT INTO Color VALUES (2, 'White')
INSERT INTO Color VALUES (3, 'Blue')

INSERT INTO Car VALUES (1, 2, 1, 'C Series', 2013, 1500.00, 'C Serisi 13 model Mercedes araba')
INSERT INTO Car VALUES (2, 3, 2, 'Civic', 2003, 250.00, 'Honda Civic eski kasa')
INSERT INTO Car VALUES (3, 1, 3, '320i', 2018, 2800.00, 'Yeni BMW 320i')

SELECT * FROM Car