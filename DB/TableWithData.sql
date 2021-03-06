USE [SalesOrderDB]
GO
/****** Object:  Table [dbo].[orderDetail]    Script Date: 7/4/2021 2:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[orderDetail](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[OrderInvoiceNo] [int] NOT NULL,
	[ItemCode] [varchar](255) NULL,
	[ItemDescription] [varchar](255) NULL,
	[ItemNote] [varchar](50) NULL,
	[Qty] [int] NULL,
	[Price] [float] NULL,
	[Tax] [float] NULL,
	[ExclAmount] [float] NULL,
	[TaxAmount] [float] NULL,
	[InclAmount] [float] NULL,
 CONSTRAINT [PK_orderDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[OrderTable]    Script Date: 7/4/2021 2:49:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[OrderTable](
	[OrderId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerId] [int] NOT NULL,
	[InvoiceNo] [int] NOT NULL,
	[InvoiceDate] [smalldatetime] NULL,
	[InvoiceNote] [varchar](50) NULL,
	[InvoiceReferenceNo] [varchar](20) NULL,
	[TotExclAmt] [float] NULL,
	[TotTaxAmt] [float] NULL,
	[TotInclAmt] [float] NULL,
 CONSTRAINT [PK_OrderTable_1] PRIMARY KEY CLUSTERED 
(
	[InvoiceNo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[orderDetail] ON 

INSERT [dbo].[orderDetail] ([Id], [OrderInvoiceNo], [ItemCode], [ItemDescription], [ItemNote], [Qty], [Price], [Tax], [ExclAmount], [TaxAmount], [InclAmount]) VALUES (1, 3, N'141', N'133', N'thisi s note for item 1', 45, 101, 25, 4545, 1136.25, 5681.25)
INSERT [dbo].[orderDetail] ([Id], [OrderInvoiceNo], [ItemCode], [ItemDescription], [ItemNote], [Qty], [Price], [Tax], [ExclAmount], [TaxAmount], [InclAmount]) VALUES (2, 3, N'148', N'136', N'note item 2', 10, 100, 53, 1000, 530, 1530)
INSERT [dbo].[orderDetail] ([Id], [OrderInvoiceNo], [ItemCode], [ItemDescription], [ItemNote], [Qty], [Price], [Tax], [ExclAmount], [TaxAmount], [InclAmount]) VALUES (3, 7, N'136', N'139', N'nout', 4, 10, 45, 40, 18, 58)
INSERT [dbo].[orderDetail] ([Id], [OrderInvoiceNo], [ItemCode], [ItemDescription], [ItemNote], [Qty], [Price], [Tax], [ExclAmount], [TaxAmount], [InclAmount]) VALUES (4, 7, N'140', N'135', N'this is a test note', 45, 12, 78, 540, 421.2, 961.2)
INSERT [dbo].[orderDetail] ([Id], [OrderInvoiceNo], [ItemCode], [ItemDescription], [ItemNote], [Qty], [Price], [Tax], [ExclAmount], [TaxAmount], [InclAmount]) VALUES (5, 11, N'136', N'174', N'note Test', 75, 1000, 78, 75000, 58500, 133500)
INSERT [dbo].[orderDetail] ([Id], [OrderInvoiceNo], [ItemCode], [ItemDescription], [ItemNote], [Qty], [Price], [Tax], [ExclAmount], [TaxAmount], [InclAmount]) VALUES (6, 11, N'140', N'133', N'Item is ordered ', 54, 1700, 52.12, 91800, 47846.16, 139646.16)
INSERT [dbo].[orderDetail] ([Id], [OrderInvoiceNo], [ItemCode], [ItemDescription], [ItemNote], [Qty], [Price], [Tax], [ExclAmount], [TaxAmount], [InclAmount]) VALUES (7, 12, N'132', N'130', N'S-del item ', 45, 12, 23, 540, 124.2, 664.2)
SET IDENTITY_INSERT [dbo].[orderDetail] OFF
SET IDENTITY_INSERT [dbo].[OrderTable] ON 

INSERT [dbo].[OrderTable] ([OrderId], [CustomerId], [InvoiceNo], [InvoiceDate], [InvoiceNote], [InvoiceReferenceNo], [TotExclAmt], [TotTaxAmt], [TotInclAmt]) VALUES (3, 427, 1, CAST(N'2021-07-03 00:00:00' AS SmallDateTime), N'this is a note', N'563', 50, 2.625, 52.625)
INSERT [dbo].[OrderTable] ([OrderId], [CustomerId], [InvoiceNo], [InvoiceDate], [InvoiceNote], [InvoiceReferenceNo], [TotExclAmt], [TotTaxAmt], [TotInclAmt]) VALUES (2, 440, 2, CAST(N'2021-07-04 00:00:00' AS SmallDateTime), N'Test invoice note', N'874', 615420, 276939, 892359)
INSERT [dbo].[OrderTable] ([OrderId], [CustomerId], [InvoiceNo], [InvoiceDate], [InvoiceNote], [InvoiceReferenceNo], [TotExclAmt], [TotTaxAmt], [TotInclAmt]) VALUES (6, 428, 3, CAST(N'2021-04-05 00:00:00' AS SmallDateTime), N'note test 2', N'753', 5545, 1666.25, 7211.25)
INSERT [dbo].[OrderTable] ([OrderId], [CustomerId], [InvoiceNo], [InvoiceDate], [InvoiceNote], [InvoiceReferenceNo], [TotExclAmt], [TotTaxAmt], [TotInclAmt]) VALUES (1, 423, 4, CAST(N'2020-04-19 00:00:00' AS SmallDateTime), N'testNote', N'789', NULL, NULL, NULL)
INSERT [dbo].[OrderTable] ([OrderId], [CustomerId], [InvoiceNo], [InvoiceDate], [InvoiceNote], [InvoiceReferenceNo], [TotExclAmt], [TotTaxAmt], [TotInclAmt]) VALUES (4, 425, 5, CAST(N'2014-02-08 00:00:00' AS SmallDateTime), N'Sales order testing note', N'236', 366.75, 199.07684326171875, 565.82684326171875)
INSERT [dbo].[OrderTable] ([OrderId], [CustomerId], [InvoiceNo], [InvoiceDate], [InvoiceNote], [InvoiceReferenceNo], [TotExclAmt], [TotTaxAmt], [TotInclAmt]) VALUES (7, 428, 7, CAST(N'2010-02-04 00:00:00' AS SmallDateTime), N'sales order note test', N'555', 580, 439.20001220703125, 1019.2000122070313)
INSERT [dbo].[OrderTable] ([OrderId], [CustomerId], [InvoiceNo], [InvoiceDate], [InvoiceNote], [InvoiceReferenceNo], [TotExclAmt], [TotTaxAmt], [TotInclAmt]) VALUES (5, 430, 10, CAST(N'2021-08-05 00:00:00' AS SmallDateTime), N'ja hajshd hajkds', N'231', 15600, 1192, 16792)
INSERT [dbo].[OrderTable] ([OrderId], [CustomerId], [InvoiceNo], [InvoiceDate], [InvoiceNote], [InvoiceReferenceNo], [TotExclAmt], [TotTaxAmt], [TotInclAmt]) VALUES (8, 435, 11, CAST(N'2021-07-04 00:00:00' AS SmallDateTime), N'regarding the sales order', N'238', 166800, 106346.15625, 273146.15625)
INSERT [dbo].[OrderTable] ([OrderId], [CustomerId], [InvoiceNo], [InvoiceDate], [InvoiceNote], [InvoiceReferenceNo], [TotExclAmt], [TotTaxAmt], [TotInclAmt]) VALUES (9, 426, 12, CAST(N'2021-03-02 00:00:00' AS SmallDateTime), N'noting the sales order', N'15', 540, 124.19999694824219, 664.20001220703125)
SET IDENTITY_INSERT [dbo].[OrderTable] OFF
ALTER TABLE [dbo].[orderDetail]  WITH CHECK ADD  CONSTRAINT [FK_orderDetail_orderDetail] FOREIGN KEY([OrderInvoiceNo])
REFERENCES [dbo].[OrderTable] ([InvoiceNo])
GO
ALTER TABLE [dbo].[orderDetail] CHECK CONSTRAINT [FK_orderDetail_orderDetail]
GO
ALTER TABLE [dbo].[OrderTable]  WITH CHECK ADD  CONSTRAINT [FK_OrderTable_Client] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Client] ([DCLink])
GO
ALTER TABLE [dbo].[OrderTable] CHECK CONSTRAINT [FK_OrderTable_Client]
GO
