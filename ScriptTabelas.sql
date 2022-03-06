/******Database [DigiBD]******/
CREATE DATABASE [DigiBD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DigiBD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DigiBD.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'DigiBD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\DigiBD_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO

USE [DigiBD]

/******Table [dbo].[Digimon]******/

CREATE TABLE [dbo].[Digimon](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Stage] [varchar](20) NOT NULL,
	[Type] [varchar](30) NOT NULL,
 CONSTRAINT [PK_dbo.Digimon] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/******Table [dbo].[Tamer]******/

CREATE TABLE [dbo].[Tamer](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Age] [int] NOT NULL,
	[Nationality] [varchar](30) NOT NULL,
 CONSTRAINT [PK_dbo.Tamer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

/** Insert Into Table Digimon **/
INSERT into [dbo].[Digimon]  VALUES ('Agumon', 'Rookie','Vaccine');
INSERT into [dbo].[Digimon]  VALUES ('Gabumon', 'Rookie','Data');
INSERT into [dbo].[Digimon]  VALUES ('Patamon', 'Rookie','Data');
INSERT into [dbo].[Digimon]  VALUES ('Palmon', 'Rookie','Data');
INSERT into [dbo].[Digimon]  VALUES ('Gatomon', 'Champion','Vaccine');
INSERT into [dbo].[Digimon]  VALUES ('DemiDevimon', 'Rookie','Virus');
INSERT into [dbo].[Digimon]  VALUES ('Terriermon', 'Rookie','Vaccine');

/** Insert Into Table Tamer **/
INSERT into [dbo].[Tamer]  VALUES ('Taichi Kamiya', 11 ,'Japanese');
INSERT into [dbo].[Tamer]  VALUES ('Kari Kamiya ', 8 ,'Japanese');
INSERT into [dbo].[Tamer]  VALUES ('Yamato Ishida ', 11 ,'Japanese');
INSERT into [dbo].[Tamer]  VALUES ('Mimi Tachikawa', 10 ,'Japanese');
INSERT into [dbo].[Tamer]  VALUES ('Takeru Takaishi', 7 ,'Japanese');
INSERT into [dbo].[Tamer]  VALUES ('Skull', 30 ,'Unknown');
INSERT into [dbo].[Tamer]  VALUES ('Henry Wong', 12 ,'Half-Japanese, Half-Chinese');
