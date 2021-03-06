USE [Vet]
GO
/****** Object:  User [SYSADMIN]    Script Date: 25.04.2021 12:23:36 ******/
CREATE USER [SYSADMIN] FOR LOGIN [SYSADMIN] WITH DEFAULT_SCHEMA=[dbo]
GO
/****** Object:  Table [dbo].[patients]    Script Date: 25.04.2021 12:23:38 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[patients](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[HastaAdi] [nvarchar](50) NOT NULL,
	[HastaFotograf] [image] NULL,
	[Cinsi] [nvarchar](50) NOT NULL,
	[Tani] [nvarchar](max) NOT NULL,
	[SahipAdi] [nvarchar](50) NOT NULL,
	[SahipSoyadi] [nvarchar](50) NOT NULL,
	[SahipTel] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_patients] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[patients] ON 

INSERT [dbo].[patients] ([Id], [HastaAdi], [HastaFotograf], [Cinsi], [Tani], [SahipAdi], [SahipSoyadi], [SahipTel]) VALUES (1, N'Duman', NULL, N'Scottish', N'Genel Muayene', N'Çağla Nur', N'Türkmen', N'05355963527')
INSERT [dbo].[patients] ([Id], [HastaAdi], [HastaFotograf], [Cinsi], [Tani], [SahipAdi], [SahipSoyadi], [SahipTel]) VALUES (2, N'Mia', NULL, N'Scottish', N'Genel Muayene', N'Çağla Nur', N'Türkmen', N'05355963527')
INSERT [dbo].[patients] ([Id], [HastaAdi], [HastaFotograf], [Cinsi], [Tani], [SahipAdi], [SahipSoyadi], [SahipTel]) VALUES (3, N'deneme', NULL, N'deneme', N'deneme', N'deneme', N'deneme', N'05355963527')
INSERT [dbo].[patients] ([Id], [HastaAdi], [HastaFotograf], [Cinsi], [Tani], [SahipAdi], [SahipSoyadi], [SahipTel]) VALUES (4, N'Zeytin', NULL, N'Golden', N'muayene', N'deneme', N'deneme', N'05355963527')
INSERT [dbo].[patients] ([Id], [HastaAdi], [HastaFotograf], [Cinsi], [Tani], [SahipAdi], [SahipSoyadi], [SahipTel]) VALUES (5, N'Ares', NULL, N'Golden', N'Muayene', N'deneme', N'deneme', N'05355963527')
SET IDENTITY_INSERT [dbo].[patients] OFF
GO
