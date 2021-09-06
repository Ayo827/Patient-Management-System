USE [Hospital_Management]
GO

/****** Object: Table [dbo].[registration] Script Date: 8/18/2021 1:47:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[registration] (
   [ID]        INT           IDENTITY (1, 1) NOT NULL,
   [FirstName] VARCHAR (255) NULL,
   [LastName]  VARCHAR (255) NULL,
    [Birthday]  VARCHAR (255) NULL,
    [Gender]      CHAR (10)     NULL,
    [Phone]     VARCHAR (255) NULL,
 [Email]     VARCHAR (255) NULL,
 [Address_]  VARCHAR (255) NULL,
  [Picture]   VARCHAR (255) NULL
);




