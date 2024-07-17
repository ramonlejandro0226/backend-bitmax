USE [master]
GO
/****** Object:  Database [bitmex]    Script Date: 7/17/2024 12:35:35 AM ******/
CREATE DATABASE [bitmex]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'bitmex', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\bitmex.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'bitmex_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER01\MSSQL\DATA\bitmex_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [bitmex] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [bitmex].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [bitmex] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [bitmex] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [bitmex] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [bitmex] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [bitmex] SET ARITHABORT OFF 
GO
ALTER DATABASE [bitmex] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [bitmex] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [bitmex] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [bitmex] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [bitmex] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [bitmex] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [bitmex] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [bitmex] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [bitmex] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [bitmex] SET  ENABLE_BROKER 
GO
ALTER DATABASE [bitmex] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [bitmex] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [bitmex] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [bitmex] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [bitmex] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [bitmex] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [bitmex] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [bitmex] SET RECOVERY FULL 
GO
ALTER DATABASE [bitmex] SET  MULTI_USER 
GO
ALTER DATABASE [bitmex] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [bitmex] SET DB_CHAINING OFF 
GO
ALTER DATABASE [bitmex] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [bitmex] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [bitmex] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [bitmex] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'bitmex', N'ON'
GO
ALTER DATABASE [bitmex] SET QUERY_STORE = ON
GO
ALTER DATABASE [bitmex] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [bitmex]
GO
/****** Object:  Table [dbo].[announcement]    Script Date: 7/17/2024 12:35:37 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[announcement](
	[id] [int] NOT NULL,
	[title] [nchar](150) NULL,
 CONSTRAINT [PK_announcement] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [bitmex] SET  READ_WRITE 
GO
