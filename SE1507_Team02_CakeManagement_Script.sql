USE [CakeManagement]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [FK__Orders__staffid__4F7CD00D]
GO
ALTER TABLE [dbo].[OrderDetail] DROP CONSTRAINT [FK__OrderDeta__order__571DF1D5]
GO
ALTER TABLE [dbo].[OrderDetail] DROP CONSTRAINT [FK__OrderDeta__cakei__5812160E]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [DF__Orders__shipping__5441852A]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [DF__Orders__createdd__534D60F1]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [DF__Orders__shipping__52593CB8]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [DF__Orders__customer__5165187F]
GO
ALTER TABLE [dbo].[Orders] DROP CONSTRAINT [DF__Orders__customer__5070F446]
GO
/****** Object:  Index [UQ__Users__F3DBC57280934242]    Script Date: 11/6/2021 8:51:16 PM ******/
ALTER TABLE [dbo].[Users] DROP CONSTRAINT [UQ__Users__F3DBC57280934242]
GO
/****** Object:  Index [UQ__Cake__3C7A13CAB90FE469]    Script Date: 11/6/2021 8:51:16 PM ******/
ALTER TABLE [dbo].[Cake] DROP CONSTRAINT [UQ__Cake__3C7A13CAB90FE469]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/6/2021 8:51:16 PM ******/
DROP TABLE [dbo].[Users]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/6/2021 8:51:16 PM ******/
DROP TABLE [dbo].[Orders]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/6/2021 8:51:16 PM ******/
DROP TABLE [dbo].[OrderDetail]
GO
/****** Object:  Table [dbo].[Cake]    Script Date: 11/6/2021 8:51:16 PM ******/
DROP TABLE [dbo].[Cake]
GO
USE [master]
GO
/****** Object:  Database [CakeManagement]    Script Date: 11/6/2021 8:51:16 PM ******/
DROP DATABASE [CakeManagement]
GO
/****** Object:  Database [CakeManagement]    Script Date: 11/6/2021 8:51:16 PM ******/
CREATE DATABASE [CakeManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'CakeManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CakeManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'CakeManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\CakeManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [CakeManagement] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [CakeManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [CakeManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [CakeManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [CakeManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [CakeManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [CakeManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [CakeManagement] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [CakeManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [CakeManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [CakeManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [CakeManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [CakeManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [CakeManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [CakeManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [CakeManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [CakeManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [CakeManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [CakeManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [CakeManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [CakeManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [CakeManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [CakeManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [CakeManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [CakeManagement] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [CakeManagement] SET  MULTI_USER 
GO
ALTER DATABASE [CakeManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [CakeManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [CakeManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [CakeManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [CakeManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [CakeManagement] SET QUERY_STORE = OFF
GO
USE [CakeManagement]
GO
/****** Object:  Table [dbo].[Cake]    Script Date: 11/6/2021 8:51:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cake](
	[cakeid] [int] IDENTITY(1,1) NOT NULL,
	[cakename] [nvarchar](50) NULL,
	[price] [money] NOT NULL,
	[amount] [int] NOT NULL,
	[category] [nvarchar](50) NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[cakeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderDetail]    Script Date: 11/6/2021 8:51:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderDetail](
	[orderid] [int] NOT NULL,
	[cakeid] [int] NOT NULL,
	[amount] [int] NOT NULL,
	[totalprice] [money] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[orderid] ASC,
	[cakeid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 11/6/2021 8:51:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[orderid] [int] IDENTITY(1,1) NOT NULL,
	[staffid] [int] NULL,
	[totalprice] [money] NOT NULL,
	[customername] [nvarchar](50) NOT NULL,
	[customeraddress] [nvarchar](50) NULL,
	[customerphonenumber] [nvarchar](10) NULL,
	[shippingfee] [money] NULL,
	[createddate] [date] NULL,
	[shippingdate] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[orderid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 11/6/2021 8:51:17 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[userid] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NULL,
	[password] [nvarchar](30) NOT NULL,
	[fullname] [nvarchar](50) NOT NULL,
	[phonenumber] [nvarchar](10) NULL,
	[address] [nvarchar](50) NULL,
	[email] [nvarchar](50) NOT NULL,
	[role] [nvarchar](25) NOT NULL,
	[status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[userid] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Cake] ON 

INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (1, N'Tiramisu', 100000.0000, 5, N'Desert', 1)
INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (2, N'Gato', 150000.0000, 0, N'Desert', 1)
INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (3, N'Gateaux', 90000.0000, 5, N'Cheese Cake', 1)
INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (4, N'Mousse', 50000.0000, 2, N'Desert', 1)
INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (5, N'Ice Cream Cake', 120000.0000, 3, N'Desert', 1)
INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (6, N'Buttefly Flower Cookie', 30000.0000, 8, N'Cookie', 1)
INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (7, N'Coconut Cookie', 20000.0000, 4, N'Cookie', 1)
INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (8, N'Matcha Cookie', 35000.0000, 4, N'Cheese Cake', 1)
INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (9, N'Corn Cheese Cake', 50000.0000, 6, N'Cheese Cake', 1)
INSERT [dbo].[Cake] ([cakeid], [cakename], [price], [amount], [category], [status]) VALUES (10, N'Strawberry Cake', 40000.0000, 5, N'Desert', 1)
SET IDENTITY_INSERT [dbo].[Cake] OFF
INSERT [dbo].[OrderDetail] ([orderid], [cakeid], [amount], [totalprice]) VALUES (1, 2, 5, 750000.0000)
INSERT [dbo].[OrderDetail] ([orderid], [cakeid], [amount], [totalprice]) VALUES (2, 4, 2, 100000.0000)
INSERT [dbo].[OrderDetail] ([orderid], [cakeid], [amount], [totalprice]) VALUES (3, 7, 4, 80000.0000)
INSERT [dbo].[OrderDetail] ([orderid], [cakeid], [amount], [totalprice]) VALUES (4, 6, 4, 120000.0000)
INSERT [dbo].[OrderDetail] ([orderid], [cakeid], [amount], [totalprice]) VALUES (5, 4, 1, 50000.0000)
INSERT [dbo].[OrderDetail] ([orderid], [cakeid], [amount], [totalprice]) VALUES (6, 5, 2, 240000.0000)
INSERT [dbo].[OrderDetail] ([orderid], [cakeid], [amount], [totalprice]) VALUES (6, 7, 2, 40000.0000)
SET IDENTITY_INSERT [dbo].[Orders] ON 

INSERT [dbo].[Orders] ([orderid], [staffid], [totalprice], [customername], [customeraddress], [customerphonenumber], [shippingfee], [createddate], [shippingdate]) VALUES (1, 3, 780000.0000, N'Hanh', N'District 9', N'0102123456', 30000.0000, CAST(N'2021-11-06' AS Date), CAST(N'2021-11-06' AS Date))
INSERT [dbo].[Orders] ([orderid], [staffid], [totalprice], [customername], [customeraddress], [customerphonenumber], [shippingfee], [createddate], [shippingdate]) VALUES (2, 3, 100000.0000, N'Truong The Thanh', N'Quan 9', N'0708123456', 0.0000, CAST(N'2021-11-06' AS Date), CAST(N'2021-11-06' AS Date))
INSERT [dbo].[Orders] ([orderid], [staffid], [totalprice], [customername], [customeraddress], [customerphonenumber], [shippingfee], [createddate], [shippingdate]) VALUES (3, 3, 110000.0000, N'Nguyen Van An', N'Binh Thanh District', N'0506123456', 30000.0000, CAST(N'2021-11-06' AS Date), CAST(N'2021-11-06' AS Date))
INSERT [dbo].[Orders] ([orderid], [staffid], [totalprice], [customername], [customeraddress], [customerphonenumber], [shippingfee], [createddate], [shippingdate]) VALUES (4, 3, 150000.0000, N'Nguyen The Binh', N'District 4', N'0102456789', 30000.0000, CAST(N'2021-11-06' AS Date), CAST(N'2021-11-06' AS Date))
INSERT [dbo].[Orders] ([orderid], [staffid], [totalprice], [customername], [customeraddress], [customerphonenumber], [shippingfee], [createddate], [shippingdate]) VALUES (5, 3, 80000.0000, N'Tran Binh Trong', N'District 8', N'0708123456', 30000.0000, CAST(N'2021-11-06' AS Date), CAST(N'2021-11-07' AS Date))
INSERT [dbo].[Orders] ([orderid], [staffid], [totalprice], [customername], [customeraddress], [customerphonenumber], [shippingfee], [createddate], [shippingdate]) VALUES (6, 3, 310000.0000, N'Nguyen Phuc Lam', N'HCM FPTU', N'0405123456', 30000.0000, CAST(N'2021-11-06' AS Date), CAST(N'2021-11-09' AS Date))
SET IDENTITY_INSERT [dbo].[Orders] OFF
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([userid], [username], [password], [fullname], [phonenumber], [address], [email], [role], [status]) VALUES (1, N'vinhnd', N'123', N'Nguyen Duc Vinh', N'0784691235', N'Quan 9', N'vinhnd@fpt.edu.vn', N'Admin', 1)
INSERT [dbo].[Users] ([userid], [username], [password], [fullname], [phonenumber], [address], [email], [role], [status]) VALUES (2, N'vanntt', N'123', N'Nguyen Thi Thanh Van', N'0784691235', N'Quan 9', N'vanntt@fpt.edu.vn', N'Admin', 1)
INSERT [dbo].[Users] ([userid], [username], [password], [fullname], [phonenumber], [address], [email], [role], [status]) VALUES (3, N'phuongnn', N'456', N'Nguyen Ngoc Phuong', N'0799691235', N'Binh Thanh', N'phuongnn@gmail.com', N'Staff', 1)
INSERT [dbo].[Users] ([userid], [username], [password], [fullname], [phonenumber], [address], [email], [role], [status]) VALUES (4, N'tuantm', N'456', N'Truong Minh Tuan', N'0799691235', N'Binh Tan', N'tuantmse@gmail.com', N'Staff', 1)
INSERT [dbo].[Users] ([userid], [username], [password], [fullname], [phonenumber], [address], [email], [role], [status]) VALUES (5, N'kimnvse', N'456', N'Nguyen Vo Kim', N'0799691235', N'Quan 4', N'kimnvse@gmail.com', N'Staff', 1)
SET IDENTITY_INSERT [dbo].[Users] OFF
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Cake__3C7A13CAB90FE469]    Script Date: 11/6/2021 8:51:17 PM ******/
ALTER TABLE [dbo].[Cake] ADD UNIQUE NONCLUSTERED 
(
	[cakename] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__Users__F3DBC57280934242]    Script Date: 11/6/2021 8:51:17 PM ******/
ALTER TABLE [dbo].[Users] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (N'Quan 9') FOR [customeraddress]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (N'None') FOR [customerphonenumber]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT ((0)) FOR [shippingfee]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [createddate]
GO
ALTER TABLE [dbo].[Orders] ADD  DEFAULT (getdate()) FOR [shippingdate]
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([cakeid])
REFERENCES [dbo].[Cake] ([cakeid])
GO
ALTER TABLE [dbo].[OrderDetail]  WITH CHECK ADD FOREIGN KEY([orderid])
REFERENCES [dbo].[Orders] ([orderid])
GO
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([staffid])
REFERENCES [dbo].[Users] ([userid])
GO
USE [master]
GO
ALTER DATABASE [CakeManagement] SET  READ_WRITE 
GO
