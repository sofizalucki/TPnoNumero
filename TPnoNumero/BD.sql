USE [TPnoNum]
GO
/****** Object:  User [alumno]    Script Date: 2/7/2025 09:07:37 ******/
CREATE USER [alumno] FOR LOGIN [alumno] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[Integrante]    Script Date: 2/7/2025 09:07:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Integrante](
	[IdIntegrante] [int] IDENTITY(1,1) NOT NULL,
	[nombreUser] [varchar](50) NOT NULL,
	[password] [varchar](50) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[DNI] [int] NOT NULL,
	[direccion] [varchar](50) NOT NULL,
	[barrio] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Integrante] PRIMARY KEY CLUSTERED 
(
	[IdIntegrante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
