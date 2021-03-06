USE [master]
GO
/****** Object:  Database [studentvotingsystem2]    Script Date: 2/15/2020 4:34:00 PM ******/
CREATE DATABASE [studentvotingsystem2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'studentvotingsystem2', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\studentvotingsystem2.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'studentvotingsystem2_log', FILENAME = N'C:\Program Files (x86)\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\studentvotingsystem2_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [studentvotingsystem2] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [studentvotingsystem2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [studentvotingsystem2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET ARITHABORT OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [studentvotingsystem2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [studentvotingsystem2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [studentvotingsystem2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET  DISABLE_BROKER 
GO
ALTER DATABASE [studentvotingsystem2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [studentvotingsystem2] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET RECOVERY FULL 
GO
ALTER DATABASE [studentvotingsystem2] SET  MULTI_USER 
GO
ALTER DATABASE [studentvotingsystem2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [studentvotingsystem2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [studentvotingsystem2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [studentvotingsystem2] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [studentvotingsystem2]
GO
/****** Object:  Table [dbo].[candidate]    Script Date: 2/15/2020 4:34:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[candidate](
	[candidate_id] [int] IDENTITY(1,1) NOT NULL,
	[candidate_photo] [varchar](max) NOT NULL,
	[student_id] [varchar](50) NOT NULL,
	[position_id] [int] NOT NULL,
	[votes] [int] NOT NULL,
 CONSTRAINT [PK_candidate] PRIMARY KEY CLUSTERED 
(
	[candidate_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login]    Script Date: 2/15/2020 4:34:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login](
	[uname] [varchar](50) NOT NULL,
	[password] [varbinary](50) NULL,
	[type] [varchar](50) NULL,
 CONSTRAINT [PK_login] PRIMARY KEY CLUSTERED 
(
	[uname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[login1]    Script Date: 2/15/2020 4:34:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[login1](
	[uname] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[type] [varchar](50) NOT NULL,
 CONSTRAINT [PK_login1] PRIMARY KEY CLUSTERED 
(
	[uname] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[position]    Script Date: 2/15/2020 4:34:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[position](
	[position_id] [int] IDENTITY(1,1) NOT NULL,
	[position_name] [varchar](max) NOT NULL,
	[position_description] [varchar](max) NULL,
 CONSTRAINT [PK_position] PRIMARY KEY CLUSTERED 
(
	[position_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[student]    Script Date: 2/15/2020 4:34:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[student](
	[student_id] [varchar](50) NOT NULL,
	[student_name] [varchar](max) NOT NULL,
	[student_department] [varchar](max) NOT NULL,
	[student_class] [varchar](max) NOT NULL,
	[voting_status] [varchar](max) NULL,
 CONSTRAINT [PK_student] PRIMARY KEY CLUSTERED 
(
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[candidate]  WITH CHECK ADD  CONSTRAINT [FK_candidate_position] FOREIGN KEY([position_id])
REFERENCES [dbo].[position] ([position_id])
GO
ALTER TABLE [dbo].[candidate] CHECK CONSTRAINT [FK_candidate_position]
GO
ALTER TABLE [dbo].[candidate]  WITH CHECK ADD  CONSTRAINT [FK_candidate_student] FOREIGN KEY([student_id])
REFERENCES [dbo].[student] ([student_id])
GO
ALTER TABLE [dbo].[candidate] CHECK CONSTRAINT [FK_candidate_student]
GO
USE [master]
GO
ALTER DATABASE [studentvotingsystem2] SET  READ_WRITE 
GO
