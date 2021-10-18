
CREATE DATABASE CakeManagement

USE CakeManagement

/*
USE master
DROP DATABASE CakeManagement
DROP TABLE OrderDetail
DROP TABLE Orders
DROP TABLE Users
DROP TABLE Cake
*/

CREATE TABLE Users(
	userid			INT					PRIMARY KEY IDENTITY(1,1),
	username		NVARCHAR(50)		unique,
	password		NVARCHAR(30)		NOT NULL,
	fullname		NVARCHAR(50)		NOT NULL,
	phonenumber		NVARCHAR(10)		NULL,
	address			NVARCHAR(50)		NULL,
	email			NVARCHAR(50)		NOT NULL,
	role			NVARCHAR(25)		NOT NULL,
	status			BIT					NOT NULL,
)

-- Amount
-- CRUD cake

CREATE TABLE Cake(
	cakeid			INT					PRIMARY KEY IDENTITY(1,1),
	cakename		NVARCHAR(50)		UNIQUE,
	price			MONEY				NOT NULL,
	amount			INT					NOT NULL,
	category		NVARCHAR(50)		NOT NULL,
	status			BIT					NOT NULL 
)

CREATE TABLE Orders(
	orderid					INT					PRIMARY KEY IDENTITY(1,1),
	staffid					INT					REFERENCES Users(userid),
	totalprice				MONEY				NOT NULL,
	customername			NVARCHAR(50)		NOT NULL,
	customeraddress			NVARCHAR(50)		DEFAULT N'Quan 9',
	customerphonenumber		NVARCHAR(10)		DEFAULT N'None',
	shippingfee				MONEY				DEFAULT 0,
	createddate				date				DEFAULT GETDATE(),
	shippingdate			date				DEFAULT GETDATE()		
)


CREATE TABLE OrderDetail(
	orderid			INT				REFERENCES Orders(orderid),
	cakeid			INT				REFERENCES Cake(cakeid),
	amount			INT				NOT NULL,
	totalprice		MONEY			NOT NULL,
)

INSERT INTO Users(username, password, fullname, phonenumber, address, email, role, status)
 VALUES
 (N'vinhnd', '123',N'Nguyen Duc Vinh', '0784691235', N'Quan 9', N'vinhnd@fpt.edu.vn', 'Admin', 1),
 (N'vanntt', '123',N'Nguyen Thi Thanh Van', '0784691235', N'Quan 9', N'vanntt@fpt.edu.vn', 'Admin', 1),
 (N'phuongnn', '456',N'Nguyen Ngoc Phuong', '0799691235', N'Binh Thanh', N'phuongnn@gmail.com', 'Staff', 1),
 (N'tuantm', '456',N'Truong Minh Tuan', '0799691235', N'Binh Tan', N'tuantmse@gmail.com', 'Staff', 1),
 (N'kimnvse', '456',N'Nguyen Vo Kim', '0799691235', N'Quan 4', N'kimnvse@gmail.com', 'Staff', 1)

 --SELECT * FROM dbo.Users
 -- DELETE FROM dbo.Cake WHERE cakeid = 11
 --select * from dbo.Cake

 INSERT INTO Cake(cakename, amount, price, category, status)
 VALUES
 (N'Tiramisu', 5, 100000, N'Desert', 1),
 (N'Gato', 5, 150000, N'Desert',1),
 (N'Gateaux', 5, 90000,N'Cheese Cake', 1),
 (N'Mousse', 5, 50000, N'Desert',1),
 (N'Ice Cream Cake', 5, 120000,N'Desert', 1),
 (N'Buttefly Flower Cookie', 12, 30000, N'Cookie', 1),
 (N'Coconut Cookie', 10, 20000, N'Cookie',1),
 (N'Matcha Cookie', 4, 35000,N'Cheese Cake', 1),
 (N'Corn Cheese Cake', 6, 50000, N'Cheese Cake',1),
 (N'Strawberry Cake', 5, 40000,N'Desert', 1)