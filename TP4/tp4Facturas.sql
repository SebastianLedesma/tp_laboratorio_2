USE [Ferreteria]
GO
/****** Object:  Table [dbo].[Facturas]    Script Date: 23/11/2020 9:12:29 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Facturas](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nrofactura] [int] NOT NULL,
	[precioparcial] [float] NOT NULL,
	[mediopago] [varchar](50) NOT NULL,
	[preciototal] [float] NOT NULL,
 CONSTRAINT [PK_Facturas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Facturas] ON 

INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (2, 9184, 687, N'Efectivo', 687)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (4, 6325, 199, N'MercadoPago', 179.10000610351563)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (7, 7584, 499, N'MercadoPago', 449.10000610351562)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (8, 2997, 500, N'Efectivo', 500)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (9, 5142, 2049, N'MercadoPago', 1844.0999755859375)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (10, 7788, 1599, N'Debito', 1519.050048828125)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (11, 3089, 599, N'Efectivo', 599)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (12, 7509, 200, N'Efectivo', 200)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (13, 1660, 500, N'Efectivo', 500)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (15, 7225, 255, N'Efectivo', 255)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (16, 6936, 400, N'Efectivo', 400)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (17, 550, 400, N'Efectivo', 400)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (18, 4104, 499, N'Efectivo', 499)
INSERT [dbo].[Facturas] ([id], [nrofactura], [precioparcial], [mediopago], [preciototal]) VALUES (19, 4675, 340, N'Efectivo', 340)
SET IDENTITY_INSERT [dbo].[Facturas] OFF
