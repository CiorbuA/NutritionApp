USE [Nutrition]
GO
/****** Object:  Table [dbo].[Bauturi]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Bauturi](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
 CONSTRAINT [PK_Bauturi] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Carne]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Carne](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
 CONSTRAINT [PK_Carne] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cereale]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cereale](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Dulciuri]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dulciuri](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fast_Food]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fast_Food](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Fructe]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Fructe](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Grasimi]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Grasimi](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lactate]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lactate](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
 CONSTRAINT [PK_Lactate] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Legume]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Legume](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
 CONSTRAINT [PK_Legume] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Peste]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Peste](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Seminte]    Script Date: 11/14/2017 7:01:11 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Seminte](
	[Id] [int] NOT NULL,
	[Nume] [varchar](50) NOT NULL,
	[kCal] [int] NOT NULL,
	[Proteine] [int] NOT NULL,
	[Glucide] [int] NOT NULL,
	[Lipide] [int] NOT NULL,
	[Fibre] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
