USE [RickLocalization]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 30/05/2021 22:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dimensao]    Script Date: 30/05/2021 22:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Dimensao](
	[DimensaoId] [int] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](50) NOT NULL,
	[Ativo] [bit] NOT NULL,
	[DataInclusao] [datetime] NULL,
	[NaturezaOperacao] [char](1) NOT NULL,
	[DataOperacao] [datetime] NOT NULL,
 CONSTRAINT [PK_Dimensao] PRIMARY KEY CLUSTERED 
(
	[DimensaoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Rick]    Script Date: 30/05/2021 22:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Rick](
	[RickId] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Foto] [varchar](max) NOT NULL,
	[DimensaoId] [int] NOT NULL,
	[Ativo] [bit] NOT NULL,
	[DataInclusao] [datetime] NULL,
	[NaturezaOperacao] [char](1) NOT NULL,
	[DataOperacao] [datetime] NOT NULL,
 CONSTRAINT [PK_Rick] PRIMARY KEY CLUSTERED 
(
	[RickId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Viagem]    Script Date: 30/05/2021 22:04:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Viagem](
	[ViagemId] [int] IDENTITY(1,1) NOT NULL,
	[DimensaoId] [int] NOT NULL,
	[RickId] [int] NOT NULL,
	[Motivo] [varchar](50) NULL,
	[DataViagem] [datetime] NOT NULL,
	[Ativo] [bit] NOT NULL,
	[DataInclusao] [datetime] NULL,
	[NaturezaOperacao] [char](1) NOT NULL,
	[DataOperacao] [datetime] NOT NULL,
 CONSTRAINT [PK_Viagem] PRIMARY KEY CLUSTERED 
(
	[ViagemId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Rick]  WITH CHECK ADD  CONSTRAINT [FK_Rick_Dimensao_DimensaoId] FOREIGN KEY([DimensaoId])
REFERENCES [dbo].[Dimensao] ([DimensaoId])
GO
ALTER TABLE [dbo].[Rick] CHECK CONSTRAINT [FK_Rick_Dimensao_DimensaoId]
GO
ALTER TABLE [dbo].[Viagem]  WITH CHECK ADD  CONSTRAINT [FK_Viagem_Dimensao_DimensaoId] FOREIGN KEY([DimensaoId])
REFERENCES [dbo].[Dimensao] ([DimensaoId])
GO
ALTER TABLE [dbo].[Viagem] CHECK CONSTRAINT [FK_Viagem_Dimensao_DimensaoId]
GO
ALTER TABLE [dbo].[Viagem]  WITH CHECK ADD  CONSTRAINT [FK_Viagem_Rick_RickId] FOREIGN KEY([RickId])
REFERENCES [dbo].[Rick] ([RickId])
GO
ALTER TABLE [dbo].[Viagem] CHECK CONSTRAINT [FK_Viagem_Rick_RickId]
GO
