USE [dbToDoTasks]
GO
/****** Object:  Table [dbo].[Account]    Script Date: 02/03/2014 23:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Account](
	[email] [nvarchar](200) NOT NULL,
	[password] [nvarchar](100) NOT NULL,
	[name] [nvarchar](150) NULL,
 CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED 
(
	[email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sync]    Script Date: 02/03/2014 23:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sync](
	[email] [nvarchar](200) NOT NULL,
	[datesync] [datetime] NOT NULL,
	[filesync] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Sync] PRIMARY KEY CLUSTERED 
(
	[email] ASC,
	[datesync] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  ForeignKey [FK_Sync_Account]    Script Date: 02/03/2014 23:25:49 ******/
ALTER TABLE [dbo].[Sync]  WITH CHECK ADD  CONSTRAINT [FK_Sync_Account] FOREIGN KEY([email])
REFERENCES [dbo].[Account] ([email])
GO
ALTER TABLE [dbo].[Sync] CHECK CONSTRAINT [FK_Sync_Account]
GO
