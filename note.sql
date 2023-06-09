create database [NotingFication]
USE [NotingFication]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 09/07/2023 1:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [varchar](50) NOT NULL,
 CONSTRAINT [PK__Category__19093A2BBF964CD3] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Note]    Script Date: 09/07/2023 1:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Note](
	[NoteID] [int] IDENTITY(1,1) NOT NULL,
	[CreateDate] [date] NULL,
	[Name] [varchar](100) NOT NULL,
	[UserID] [int] NOT NULL,
	[CategoryID] [int] NULL,
	[Status] [bit] NULL,
	[Deadline] [date] NULL,
	[Content] [varchar](max) NULL,
 CONSTRAINT [PK__Note__EACE357F611C4746] PRIMARY KEY CLUSTERED 
(
	[NoteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 09/07/2023 1:15:00 CH ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[Email] [varchar](100) NOT NULL,
 CONSTRAINT [PK__User__1788CCAC5FF189B7] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (1, N'Viec can lam')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (2, N'Viec du dinh')
INSERT [dbo].[Category] ([CategoryID], [CategoryName]) VALUES (3, N'Viec chuan bi')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Note] ON 

INSERT [dbo].[Note] ([NoteID], [CreateDate], [Name], [UserID], [CategoryID], [Status], [Deadline], [Content]) VALUES (1, CAST(N'2023-07-09' AS Date), N'Lam project PRN', 1, 1, 1, NULL, N'Lam project cuoi ki')
INSERT [dbo].[Note] ([NoteID], [CreateDate], [Name], [UserID], [CategoryID], [Status], [Deadline], [Content]) VALUES (2, CAST(N'2023-07-09' AS Date), N'Lam viec nha', 1, 1, 1, CAST(N'2023-07-10' AS Date), N'Quet nha, don nha ...')
SET IDENTITY_INSERT [dbo].[Note] OFF
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [Username], [Password], [Email]) VALUES (1, N'sa', N'123', N'sa@gmail.com')
INSERT [dbo].[User] ([UserID], [Username], [Password], [Email]) VALUES (2, N'user1', N'123', N'user1@gmail.com')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD  CONSTRAINT [FK__Note__CategoryID__29572725] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Note] CHECK CONSTRAINT [FK__Note__CategoryID__29572725]
GO
ALTER TABLE [dbo].[Note]  WITH CHECK ADD  CONSTRAINT [FK__Note__UserID__286302EC] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Note] CHECK CONSTRAINT [FK__Note__UserID__286302EC]
GO
