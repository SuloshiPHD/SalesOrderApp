USE [SalesOrderDB]
GO
/****** Object:  Table [dbo].[orderDetail]    Script Date: 7/4/2021 2:47:51 PM ******/
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
/****** Object:  Table [dbo].[OrderTable]    Script Date: 7/4/2021 2:47:51 PM ******/
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
