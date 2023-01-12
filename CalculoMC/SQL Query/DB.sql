/*
 Navicat Premium Data Transfer

 Source Server         : SQL Server local
 Source Server Type    : SQL Server
 Source Server Version : 15002095 (15.00.2095)
 Source Host           : localhost\SQLEXPRESS:1433
 Source Catalog        : calculeMC
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 15002095 (15.00.2095)
 File Encoding         : 65001

 Date: 11/01/2023 20:57:17
*/
/*EJECUTAR PRIMERO ESTA LINEA SOLA*/
create database calculeMC;
/*EJECUTAR LUEGO ESTA LINEA SOLA*/
use calculeMC;
/*EJECUTAR DE AQUÍ HASTA ABAJO POR ÚLTIMO*/
-- ----------------------------
-- Table structure for Rate
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Rate]') AND type IN ('U'))
	DROP TABLE [dbo].[Rate]
GO

CREATE TABLE [dbo].[Rate] (
  [Id] int  IDENTITY(1,1) NOT NULL,
  [Color] nvarchar(25) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Text1] nvarchar(50) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Text2] nvarchar(50) COLLATE Modern_Spanish_CI_AS  NULL,
  [Sex] char(1) COLLATE Modern_Spanish_CI_AS  NOT NULL,
  [Orden] int  NULL
)
GO

ALTER TABLE [dbo].[Rate] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of Rate
-- ----------------------------
SET IDENTITY_INSERT [dbo].[Rate] ON
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'1', N'#3fa1df', N'2 - 5%', N'Esencial', N'M', N'1')
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'2', N'#297c30', N'6 - 13%', N'Deportista', N'M', N'2')
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'3', N'#97b531', N'14 - 17%', N'Fitness', N'M', N'3')
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'4', N'#c2a600', N'18 - 24%', N'Aceptable', N'M', N'4')
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'5', N'#b85622', N'25% +', N'Obeso', N'M', N'5')
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'6', N'#3fa1df', N'10 - 13%', N'Esencial', N'F', N'1')
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'7', N'#297c30', N'14 - 20%', N'Deportista', N'F', N'2')
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'8', N'#97b531', N'21 - 24%', N'Fitness', N'F', N'3')
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'9', N'#c2a600', N'25 - 31%', N'Aceptable', N'F', N'4')
GO

INSERT INTO [dbo].[Rate] ([Id], [Color], [Text1], [Text2], [Sex], [Orden]) VALUES (N'10', N'#b85622', N'32% +', N'Obeso', N'F', N'5')
GO

SET IDENTITY_INSERT [dbo].[Rate] OFF
GO


-- ----------------------------
-- Auto increment value for Rate
-- ----------------------------
DBCC CHECKIDENT ('[dbo].[Rate]', RESEED, 10)
GO


-- ----------------------------
-- Primary Key structure for table Rate
-- ----------------------------
ALTER TABLE [dbo].[Rate] ADD CONSTRAINT [PK_Rate] PRIMARY KEY CLUSTERED ([Id])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO

