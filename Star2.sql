USE [School]
GO
/****** Object:  Table [dbo].[Form]    Script Date: 4/8/2018 11:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Form](
	[FormID] [int] IDENTITY(1,1) NOT NULL,
	[StudentName] [varchar](50) NOT NULL,
	[FathersName] [varchar](50) NOT NULL,
	[MothersName] [varchar](50) NOT NULL,
	[Village] [varchar](50) NULL,
	[PostOffice] [varchar](50) NULL,
	[Thana] [varchar](50) NULL,
	[Jila] [varchar](50) NULL,
	[Mobile] [varchar](50) NOT NULL,
	[Birthday] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Form] PRIMARY KEY CLUSTERED 
(
	[FormID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Result]    Script Date: 4/8/2018 11:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Result](
	[StudentName] [varchar](50) NOT NULL,
	[StudentID] [int] NOT NULL,
	[Class] [int] NOT NULL,
	[Bngla] [varchar](50) NULL,
	[English] [varchar](50) NULL,
	[Mathmatics] [varchar](50) NULL,
	[Science] [varchar](50) NULL,
	[Religion] [varchar](50) NULL,
 CONSTRAINT [PK_Result] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 4/8/2018 11:47:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](50) NULL,
	[Password] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
