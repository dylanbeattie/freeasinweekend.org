CREATE DATABASE [Packages]
GO
USE [Packages]
GO

CREATE TABLE [dbo].[Packages](
	[Id] [nvarchar](2048) NOT NULL,
	[CommitId] [uniqueidentifier] NOT NULL,
	[PackageId] [nvarchar](1024) NOT NULL,
	[PackageVersion] [nvarchar](1024) NOT NULL,
	[CommitTimestamp] [datetimeoffset](7) NULL,
	[Type] [varchar](64) NOT NULL
) ON [PRIMARY]
GO
