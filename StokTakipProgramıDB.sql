USE [StokTakip]
GO
/****** Object:  Table [dbo].[StokTakipTablosu]    Script Date: 26.10.2023 13:38:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StokTakipTablosu](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Kod] [nchar](20) NOT NULL,
	[Ad] [nchar](30) NOT NULL,
	[AlışFiyatı] [nchar](10) NOT NULL,
	[SatışFiyatı] [nchar](10) NOT NULL,
	[Birim] [nchar](10) NOT NULL,
	[Miktar] [nchar](10) NOT NULL,
	[Tarih] [nchar](10) NOT NULL
) ON [PRIMARY]
GO
