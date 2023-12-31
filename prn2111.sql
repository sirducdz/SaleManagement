USE [master]
GO
/****** Object:  Database [prn_project]    Script Date: 7/19/2023 12:46:36 AM ******/
CREATE DATABASE [prn_project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'prn_project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\prn_project.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'prn_project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\prn_project_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [prn_project] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [prn_project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [prn_project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [prn_project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [prn_project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [prn_project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [prn_project] SET ARITHABORT OFF 
GO
ALTER DATABASE [prn_project] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [prn_project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [prn_project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [prn_project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [prn_project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [prn_project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [prn_project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [prn_project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [prn_project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [prn_project] SET  ENABLE_BROKER 
GO
ALTER DATABASE [prn_project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [prn_project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [prn_project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [prn_project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [prn_project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [prn_project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [prn_project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [prn_project] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [prn_project] SET  MULTI_USER 
GO
ALTER DATABASE [prn_project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [prn_project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [prn_project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [prn_project] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [prn_project] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [prn_project] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [prn_project] SET QUERY_STORE = OFF
GO
USE [prn_project]
GO
/****** Object:  Table [dbo].[CategoryProduct]    Script Date: 7/19/2023 12:46:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CategoryProduct](
	[cp_id] [int] IDENTITY(1,1) NOT NULL,
	[cp_name] [nvarchar](50) NULL,
 CONSTRAINT [PK__Category__1AEC0C8C7040AA78] PRIMARY KEY CLUSTERED 
(
	[cp_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 7/19/2023 12:46:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[order_id] [int] IDENTITY(1,1) NOT NULL,
	[customer_name] [nvarchar](50) NULL,
	[seller_id] [int] NULL,
	[total_cost] [int] NULL,
	[pay_method] [nvarchar](50) NULL,
	[phone] [varchar](50) NULL,
	[note] [nvarchar](50) NULL,
	[sold_date] [date] NULL,
 CONSTRAINT [PK__Order__4659622955D329AB] PRIMARY KEY CLUSTERED 
(
	[order_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order_Detail]    Script Date: 7/19/2023 12:46:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order_Detail](
	[od_id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [int] NULL,
	[product_id] [int] NULL,
	[price] [int] NULL,
	[quantity] [int] NULL,
	[total_cost] [int] NULL,
 CONSTRAINT [PK__Order_De__FB4B2EFEF26517D3] PRIMARY KEY CLUSTERED 
(
	[od_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 7/19/2023 12:46:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[product_id] [int] IDENTITY(1,1) NOT NULL,
	[product_name] [nvarchar](50) NULL,
	[quantity] [int] NULL,
	[price] [int] NULL,
	[updated_date] [date] NULL,
	[cp_id] [int] NULL,
 CONSTRAINT [PK__Product__47027DF5F0F12DCA] PRIMARY KEY CLUSTERED 
(
	[product_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 7/19/2023 12:46:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[role_id] [int] IDENTITY(1,1) NOT NULL,
	[role_name] [nvarchar](50) NULL,
 CONSTRAINT [PK__Role__760965CCFECE0C5E] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 7/19/2023 12:46:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[fullName] [nvarchar](50) NOT NULL,
	[phone] [varchar](50) NULL,
	[email] [varchar](50) NULL,
	[dob] [date] NULL,
	[gender] [varchar](50) NULL,
	[status] [varchar](50) NULL,
	[updated_date] [date] NULL,
	[role_id] [int] NULL,
 CONSTRAINT [PK__User__B9BE370F05DC050F] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserHistoryUpdate]    Script Date: 7/19/2023 12:46:36 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserHistoryUpdate](
	[uhu_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NULL,
	[fullname_updated] [nvarchar](50) NULL,
	[phone_updated] [varchar](50) NULL,
	[gender_updated] [bit] NULL,
	[email_updated] [varchar](50) NULL,
	[updated_time] [date] NULL,
	[updated_by] [int] NULL,
 CONSTRAINT [PK__UserHist__A1A1ED0C649CA3D2] PRIMARY KEY CLUSTERED 
(
	[uhu_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CategoryProduct] ON 

INSERT [dbo].[CategoryProduct] ([cp_id], [cp_name]) VALUES (1, N'Thực phẩm')
INSERT [dbo].[CategoryProduct] ([cp_id], [cp_name]) VALUES (2, N'Đồ dùng')
SET IDENTITY_INSERT [dbo].[CategoryProduct] OFF
GO
SET IDENTITY_INSERT [dbo].[Order] ON 

INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (1, N'AAA', 1, 1015000, N'online', N'012345666', N'', CAST(N'2023-03-24' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (6, N'BBBB', 1, 1100000, N'online', N'0123123123', N'', CAST(N'2023-03-24' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (7, N'CCC', 1, 20000, N'offline', N'098765544', N'', CAST(N'2023-03-24' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (11, N'Nguyen Van C', 1, 80000, N'online', N'1231231231', N'', CAST(N'2023-03-25' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (12, N'Nguyen Nguyen', 1, 180000, N'online', N'0123123123', N'', CAST(N'2023-03-26' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (13, N'Nguyen', 1, 3010000, N'online', N'012312312312', N'', CAST(N'2023-03-26' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (14, N'Nguyen kkkk', 1, 3000000, N'offline', N'0123123123123', N'', CAST(N'2023-03-26' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (15, N'nnnn', 1, 110000, N'online', N'0123123123', N'', CAST(N'2023-03-26' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (16, N'vvv', 1, 120000, N'online', N'0123123213', N'', CAST(N'2023-03-26' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (17, N'qqq', 1, 200000, N'online', N'012312313', N'', CAST(N'2023-03-26' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (18, N'CCCCD', 1, 5000000, N'offline', N'0123123123', N'', CAST(N'2023-03-26' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (19, N'Nguyen Nguyen A', 1, 570000, N'offline', N'0213213213', N'', CAST(N'2023-03-27' AS Date))
INSERT [dbo].[Order] ([order_id], [customer_name], [seller_id], [total_cost], [pay_method], [phone], [note], [sold_date]) VALUES (20, N'Hai Dang1', 1, 3280000, N'online', N'0123123132', N'', CAST(N'2023-07-19' AS Date))
SET IDENTITY_INSERT [dbo].[Order] OFF
GO
SET IDENTITY_INSERT [dbo].[Order_Detail] ON 

INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (5, 6, 3, 1000000, 1, 1000000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (6, 6, 4, 100000, 1, 100000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (7, 7, 2, 10000, 1, 10000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (8, 7, 6, 10000, 1, 10000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (14, 11, 2, 10000, 2, 20000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (15, 11, 6, 10000, 6, 60000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (16, 12, 1, 50000, 5, 150000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (17, 12, 11, 30000, 1, 30000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (18, 13, 3, 1000000, 6, 3000000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (19, 13, 2, 10000, 1, 10000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (20, 14, 3, 1000000, 3, 3000000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (21, 15, 6, 10000, 11, 110000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (22, 16, 6, 10000, 12, 120000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (23, 17, 1, 50000, 4, 200000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (24, 18, 3, 1000000, 5, 5000000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (25, 19, 2, 10000, 307, 70000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (26, 19, 1, 50000, 10, 500000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (27, 20, 3, 1000000, 3, 3000000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (28, 20, 2, 10000, 3, 30000)
INSERT [dbo].[Order_Detail] ([od_id], [order_id], [product_id], [price], [quantity], [total_cost]) VALUES (29, 20, 1, 50000, 5, 250000)
SET IDENTITY_INSERT [dbo].[Order_Detail] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (1, N'Chocopie', 31, 50000, CAST(N'2023-03-26' AS Date), 1)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (2, N'Kẹo', 53, 10000, CAST(N'2023-03-25' AS Date), 1)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (3, N'Ti vi', 33, 1000000, CAST(N'2023-03-23' AS Date), 2)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (4, N'Túi xách', 50, 100000, CAST(N'2023-03-23' AS Date), 2)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (6, N'Rau', 487, 10000, CAST(N'2023-03-25' AS Date), 1)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (10, N'Tôm', 0, 200000, CAST(N'2023-03-25' AS Date), 1)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (11, N'Cuaa', 50, 30000, CAST(N'2023-03-27' AS Date), 1)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (12, N'Chocopie', 50, 50000, CAST(N'2023-03-26' AS Date), 1)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (13, N'Tủ lạnh', 100, 2000000, CAST(N'2023-03-27' AS Date), 2)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (14, N'Banh', 50, 10000, CAST(N'2023-03-27' AS Date), 1)
INSERT [dbo].[Product] ([product_id], [product_name], [quantity], [price], [updated_date], [cp_id]) VALUES (15, N'Rau1', 123, 100000, CAST(N'2023-07-19' AS Date), 1)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([role_id], [role_name]) VALUES (1, N'admin')
INSERT [dbo].[Role] ([role_id], [role_name]) VALUES (2, N'staff')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (1, N'admin', N'admin', N'admin111', N'0123456789', N'admin@gmail.com', CAST(N'2001-10-16' AS Date), N'female', N'active', CAST(N'2023-07-19' AS Date), 1)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (2, N'mra', N'mra', N'Mr.A', N'0123456789', N'mra@gmail.com', CAST(N'2000-02-20' AS Date), N'male', N'active', CAST(N'2023-03-25' AS Date), 2)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (3, N'mrb', N'mrb', N'Mr.BB', N'0123456789', N'mrb@gmail.com', CAST(N'2005-02-03' AS Date), N'Male', N'active', CAST(N'2023-03-25' AS Date), 2)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (4, N'mrc', N'mrc', N'Mr.CCC', N'0123123123', N'mrc@gmail.com', CAST(N'2023-03-13' AS Date), N'Female', N'inactive', CAST(N'2023-03-26' AS Date), 2)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (5, N'mrd', N'mrd', N'Mr.D', N'9876543210', N'mrd123@gmail.com', CAST(N'2023-02-15' AS Date), N'Male', N'inactive', CAST(N'2023-03-23' AS Date), 2)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (6, N'abc', N'abc', N'abc', N'0123123123', N'abc@gmail.com', CAST(N'2023-03-01' AS Date), N'male', N'active', CAST(N'2023-03-25' AS Date), 2)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (7, N'aaaaa', N'aaaaa', N'AAAAA', N'0123123123', N'aaaaa@gmail.com', CAST(N'2023-03-01' AS Date), N'Female', N'inactive', CAST(N'2023-03-26' AS Date), 2)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (8, N'nvb', N'nvb', N'Nguyen Van Binhh', N'012344561233', N'nvb@gmail.com', CAST(N'2023-03-01' AS Date), N'Male', N'active', CAST(N'2023-03-27' AS Date), 2)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (9, N'nvc', N'nvc', N'Nguyen Van CCCC', N'012312312312321', N'nvc@gmail.com', CAST(N'2023-03-02' AS Date), N'Male', N'active', CAST(N'2023-03-27' AS Date), 2)
INSERT [dbo].[User] ([user_id], [username], [password], [fullName], [phone], [email], [dob], [gender], [status], [updated_date], [role_id]) VALUES (10, N'haidang', N'123', N'Nguyen Hai Dang', N'013213213', N'Haidang@gmail.com', CAST(N'2023-07-10' AS Date), N'Female', N'active', CAST(N'2023-07-19' AS Date), 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK__Order__seller_id__46E78A0C] FOREIGN KEY([seller_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK__Order__seller_id__46E78A0C]
GO
ALTER TABLE [dbo].[Order_Detail]  WITH CHECK ADD  CONSTRAINT [FK__Order_Det__order__4AB81AF0] FOREIGN KEY([order_id])
REFERENCES [dbo].[Order] ([order_id])
GO
ALTER TABLE [dbo].[Order_Detail] CHECK CONSTRAINT [FK__Order_Det__order__4AB81AF0]
GO
ALTER TABLE [dbo].[Order_Detail]  WITH CHECK ADD  CONSTRAINT [FK__Order_Det__produ__4BAC3F29] FOREIGN KEY([product_id])
REFERENCES [dbo].[Product] ([product_id])
GO
ALTER TABLE [dbo].[Order_Detail] CHECK CONSTRAINT [FK__Order_Det__produ__4BAC3F29]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_CategoryProduct] FOREIGN KEY([cp_id])
REFERENCES [dbo].[CategoryProduct] ([cp_id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_CategoryProduct]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK__User__role_id__3D5E1FD2] FOREIGN KEY([role_id])
REFERENCES [dbo].[Role] ([role_id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK__User__role_id__3D5E1FD2]
GO
ALTER TABLE [dbo].[UserHistoryUpdate]  WITH CHECK ADD  CONSTRAINT [FK__UserHisto__updat__412EB0B6] FOREIGN KEY([updated_by])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[UserHistoryUpdate] CHECK CONSTRAINT [FK__UserHisto__updat__412EB0B6]
GO
ALTER TABLE [dbo].[UserHistoryUpdate]  WITH CHECK ADD  CONSTRAINT [FK__UserHisto__user___403A8C7D] FOREIGN KEY([user_id])
REFERENCES [dbo].[User] ([user_id])
GO
ALTER TABLE [dbo].[UserHistoryUpdate] CHECK CONSTRAINT [FK__UserHisto__user___403A8C7D]
GO
USE [master]
GO
ALTER DATABASE [prn_project] SET  READ_WRITE 
GO
