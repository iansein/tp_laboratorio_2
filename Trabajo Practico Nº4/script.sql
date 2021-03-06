USE [master]
GO
/****** Object:  Database [TP4-IanSein-Mamiferos]    Script Date: 22/11/2021 14:43:12 ******/
CREATE DATABASE [TP4-IanSein-Mamiferos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'mamiferos_db', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mamiferos_db.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'mamiferos_db_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\mamiferos_db_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TP4-IanSein-Mamiferos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET ARITHABORT OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET RECOVERY FULL 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET  MULTI_USER 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'TP4-IanSein-Mamiferos', N'ON'
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET QUERY_STORE = OFF
GO
USE [TP4-IanSein-Mamiferos]
GO
/****** Object:  Table [dbo].[mamiferos]    Script Date: 22/11/2021 14:43:13 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[mamiferos](
	[Mamifero] [varchar](50) NULL,
	[Nombre] [varchar](50) NULL,
	[Ubicacion] [varchar](50) NULL,
	[Tamaño] [varchar](50) NULL,
	[Id] [int] NULL
) ON [PRIMARY]
GO
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Leon', N'Leonsito', N'Argentina', N'Mediano', 100)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Leon', N'Leonson', N'Argentina', N'Grande', 101)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Elefante', N'Elefantin', N'Argentina', N'Mediano', 102)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Elefante', N'Elefanton', N'Argentina', N'Grande', 103)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Delfin', N'Delfinsito', N'Argentina', N'Mediano', 104)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Delfin', N'Delfinson', N'Argentina', N'Grande', 105)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Hipopotamo', N'Hipopotamito', N'Argentina', N'Mediano', 106)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Hipopotamo', N'Hipopotamon', N'Argentina', N'Grande', 107)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Leon', N'Tatu', N'Uruguay', N'Grande', 108)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Elefante', N'Luz', N'Uruguay', N'Mediano', 109)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Delfin', N'Arania', N'Uruguay', N'Grande', 110)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Hipopotamo', N'Hubi', N'Uruguay', N'Mediano', 111)
INSERT [dbo].[mamiferos] ([Mamifero], [Nombre], [Ubicacion], [Tamaño], [Id]) VALUES (N'Elefante', N'Elefantmon', N'Uruguay', N'Grande', 112)
GO
USE [master]
GO
ALTER DATABASE [TP4-IanSein-Mamiferos] SET  READ_WRITE 
GO
