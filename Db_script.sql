USE [PetDb]
GO
/****** Object:  Table [dbo].[Pets]    Script Date: 1/1/2024 3:12:34 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pets](
	[PetId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](50) NULL,
	[Age] [int] NULL,
	[Color] [varchar](50) NULL,
	[Gender] [varchar](50) NULL,
	[OwnerName] [varchar](50) NULL,
	[Address] [varchar](50) NULL,
	[ImageName] [varchar](300) NULL,
	[Price] [int] NULL,
 CONSTRAINT [PK_Pets] PRIMARY KEY CLUSTERED 
(
	[PetId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pets] ON 

INSERT [dbo].[Pets] ([PetId], [Name], [Age], [Color], [Gender], [OwnerName], [Address], [ImageName], [Price]) VALUES (1002, N'Flinch', 10, N'Brown', N'Male', N'Mike', N'17 The Avenue ROMFORD RM80 9SN', N'Screenshot_80235259368.png', 100)
INSERT [dbo].[Pets] ([PetId], [Name], [Age], [Color], [Gender], [OwnerName], [Address], [ImageName], [Price]) VALUES (1003, N'Pez', 4, N'White', N'Female', N'Cita', N'4 New Street GLOUCESTER GL18 2QL', N'Screenshot_81235516387.png', 150)
INSERT [dbo].[Pets] ([PetId], [Name], [Age], [Color], [Gender], [OwnerName], [Address], [ImageName], [Price]) VALUES (1004, N'Trixie', 10, N'Red & Yellow ', N'Male', N'Jakob', N'1 George Street PLYMOUTH PL18 9HO', N'Screenshot_82235825241.png', 200)
INSERT [dbo].[Pets] ([PetId], [Name], [Age], [Color], [Gender], [OwnerName], [Address], [ImageName], [Price]) VALUES (1005, N'Belle', 2, N'White and Grey', N'Female', N'Rizwan', N'4 Manchester Road PRESTON PR26 0DC', N'Screenshot_83230214177.png', 300)
INSERT [dbo].[Pets] ([PetId], [Name], [Age], [Color], [Gender], [OwnerName], [Address], [ImageName], [Price]) VALUES (2003, N'test', 10, N'test', N'Male', N'test', N'lahore', N'profile-pic231440732.png', 100)
INSERT [dbo].[Pets] ([PetId], [Name], [Age], [Color], [Gender], [OwnerName], [Address], [ImageName], [Price]) VALUES (2004, N'Test Pet', 10, N'White', N'Male', N'Test Owner', N'test Address', N'profile-pic235710081.png', 120)
SET IDENTITY_INSERT [dbo].[Pets] OFF
GO
