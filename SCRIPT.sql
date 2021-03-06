USE [master]
GO
/****** Object:  Database [EntityFrameworkP]    Script Date: 3/6/2021 4:42:11 AM ******/
CREATE DATABASE [EntityFrameworkP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'EntityFrameworkP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\EntityFrameworkP.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'EntityFrameworkP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\EntityFrameworkP_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [EntityFrameworkP] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [EntityFrameworkP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [EntityFrameworkP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET ARITHABORT OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [EntityFrameworkP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [EntityFrameworkP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [EntityFrameworkP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [EntityFrameworkP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET RECOVERY FULL 
GO
ALTER DATABASE [EntityFrameworkP] SET  MULTI_USER 
GO
ALTER DATABASE [EntityFrameworkP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [EntityFrameworkP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [EntityFrameworkP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [EntityFrameworkP] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [EntityFrameworkP] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'EntityFrameworkP', N'ON'
GO
ALTER DATABASE [EntityFrameworkP] SET QUERY_STORE = OFF
GO
USE [EntityFrameworkP]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
USE [EntityFrameworkP]
GO
/****** Object:  Table [dbo].[Clients]    Script Date: 3/6/2021 4:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clients](
	[Client_ID] [int] NOT NULL,
	[Client_Name] [nchar](25) NULL,
	[Client_Phone] [int] NULL,
	[Client_Mobile] [int] NULL,
	[Client_Website] [nchar](25) NULL,
	[Client_Mail] [nchar](25) NULL,
	[Client_Fax] [nchar](25) NULL,
 CONSTRAINT [PK_Clients] PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 3/6/2021 4:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[Emp_ID] [int] NOT NULL,
	[Emp_Name] [nchar](25) NULL,
	[Emp_Mail] [nchar](25) NULL,
	[Emp_Address] [nchar](25) NULL,
	[Emp_Phone] [int] NULL,
 CONSTRAINT [PK_Employee] PRIMARY KEY CLUSTERED 
(
	[Emp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Exports]    Script Date: 3/6/2021 4:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Exports](
	[Client_ID] [int] NOT NULL,
	[Item_ID] [int] NOT NULL,
	[Export_Date] [date] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Emp_ID] [int] NOT NULL,
	[Export_ID] [int] NULL,
	[Supplier_Name] [nchar](25) NULL,
 CONSTRAINT [PK_Exports] PRIMARY KEY CLUSTERED 
(
	[Client_ID] ASC,
	[Item_ID] ASC,
	[Emp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Imports]    Script Date: 3/6/2021 4:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Imports](
	[Supplier_ID] [int] NOT NULL,
	[Item_ID] [int] NOT NULL,
	[Import_Date] [date] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Emp_ID] [int] NOT NULL,
	[Import_ID] [int] NULL,
 CONSTRAINT [PK_Imports] PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC,
	[Item_ID] ASC,
	[Emp_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory]    Script Date: 3/6/2021 4:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory](
	[Inventory_ID] [int] NOT NULL,
	[Address] [nchar](25) NULL,
	[Name] [nchar](25) NULL,
	[EmpResp_ID] [int] NULL,
 CONSTRAINT [PK_Inventory] PRIMARY KEY CLUSTERED 
(
	[Inventory_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Inventory_Items]    Script Date: 3/6/2021 4:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventory_Items](
	[Inventory_ID] [int] NOT NULL,
	[Item_ID] [int] NOT NULL,
	[Item_Quantity] [int] NOT NULL,
	[Transfer_from] [int] NULL,
	[Transfer_to] [int] NULL,
	[Transfer_Date] [date] NULL,
	[Quantity_Transferred] [int] NULL,
 CONSTRAINT [PK_Inventory_Items] PRIMARY KEY CLUSTERED 
(
	[Inventory_ID] ASC,
	[Item_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Items]    Script Date: 3/6/2021 4:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Items](
	[Item_Code] [int] NOT NULL,
	[Item_Name] [nchar](25) NOT NULL,
	[Measuring_Unit] [nchar](25) NULL,
	[Production_Date] [date] NOT NULL,
	[Expiry_Date] [date] NOT NULL,
	[Total_Quantity] [int] NULL,
	[Entry_Date] [date] NOT NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Items] PRIMARY KEY CLUSTERED 
(
	[Item_Code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 3/6/2021 4:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[Supplier_ID] [int] NOT NULL,
	[Supplier_Name] [nchar](25) NULL,
	[Supplier_Phone] [int] NULL,
	[Supplier_Mobile] [int] NULL,
	[Supplier_Website] [nchar](25) NULL,
	[Supplier_Mail] [nchar](25) NULL,
	[Supplier_Fax] [nchar](25) NULL,
 CONSTRAINT [PK_Suppliers] PRIMARY KEY CLUSTERED 
(
	[Supplier_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Transactions]    Script Date: 3/6/2021 4:42:11 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Transactions](
	[Transaction_ID] [int] NOT NULL,
	[Trans_Type] [nchar](25) NOT NULL,
 CONSTRAINT [PK_Transactions] PRIMARY KEY CLUSTERED 
(
	[Transaction_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Exports]  WITH CHECK ADD  CONSTRAINT [FK_Exports_Clients1] FOREIGN KEY([Client_ID])
REFERENCES [dbo].[Clients] ([Client_ID])
GO
ALTER TABLE [dbo].[Exports] CHECK CONSTRAINT [FK_Exports_Clients1]
GO
ALTER TABLE [dbo].[Exports]  WITH CHECK ADD  CONSTRAINT [FK_Exports_Employee] FOREIGN KEY([Emp_ID])
REFERENCES [dbo].[Employee] ([Emp_ID])
GO
ALTER TABLE [dbo].[Exports] CHECK CONSTRAINT [FK_Exports_Employee]
GO
ALTER TABLE [dbo].[Exports]  WITH CHECK ADD  CONSTRAINT [FK_Exports_Items1] FOREIGN KEY([Item_ID])
REFERENCES [dbo].[Items] ([Item_Code])
GO
ALTER TABLE [dbo].[Exports] CHECK CONSTRAINT [FK_Exports_Items1]
GO
ALTER TABLE [dbo].[Imports]  WITH CHECK ADD  CONSTRAINT [FK_Imports_Employee] FOREIGN KEY([Emp_ID])
REFERENCES [dbo].[Employee] ([Emp_ID])
GO
ALTER TABLE [dbo].[Imports] CHECK CONSTRAINT [FK_Imports_Employee]
GO
ALTER TABLE [dbo].[Imports]  WITH CHECK ADD  CONSTRAINT [FK_Imports_Items1] FOREIGN KEY([Item_ID])
REFERENCES [dbo].[Items] ([Item_Code])
GO
ALTER TABLE [dbo].[Imports] CHECK CONSTRAINT [FK_Imports_Items1]
GO
ALTER TABLE [dbo].[Imports]  WITH CHECK ADD  CONSTRAINT [FK_Imports_Suppliers1] FOREIGN KEY([Supplier_ID])
REFERENCES [dbo].[Suppliers] ([Supplier_ID])
GO
ALTER TABLE [dbo].[Imports] CHECK CONSTRAINT [FK_Imports_Suppliers1]
GO
ALTER TABLE [dbo].[Inventory]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Employee] FOREIGN KEY([EmpResp_ID])
REFERENCES [dbo].[Employee] ([Emp_ID])
GO
ALTER TABLE [dbo].[Inventory] CHECK CONSTRAINT [FK_Inventory_Employee]
GO
ALTER TABLE [dbo].[Inventory_Items]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Items_Inventory] FOREIGN KEY([Inventory_ID])
REFERENCES [dbo].[Inventory] ([Inventory_ID])
GO
ALTER TABLE [dbo].[Inventory_Items] CHECK CONSTRAINT [FK_Inventory_Items_Inventory]
GO
ALTER TABLE [dbo].[Inventory_Items]  WITH CHECK ADD  CONSTRAINT [FK_Inventory_Items_Items1] FOREIGN KEY([Item_ID])
REFERENCES [dbo].[Items] ([Item_Code])
GO
ALTER TABLE [dbo].[Inventory_Items] CHECK CONSTRAINT [FK_Inventory_Items_Items1]
GO
USE [master]
GO
ALTER DATABASE [EntityFrameworkP] SET  READ_WRITE 
GO
