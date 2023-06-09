USE [WorkshopResults]
GO
/****** Object:  Table [dbo].[MasterPieceAccounting]    Script Date: 03.05.2023 11:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MasterPieceAccounting](
	[FirstName] [nvarchar](50) NOT NULL,
	[SecondName] [nvarchar](50) NOT NULL,
	[ThirdName] [nvarchar](50) NOT NULL,
	[WorkshopName] [nvarchar](50) NULL,
	[WorkshopBossName] [nvarchar](50) NULL,
	[WorkersCount] [int] NULL,
	[ACount] [int] NULL,
	[BCount] [int] NULL,
	[CCount] [int] NULL,
 CONSTRAINT [PK_MasterPieceAccounting] PRIMARY KEY CLUSTERED 
(
	[FirstName] ASC,
	[SecondName] ASC,
	[ThirdName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 03.05.2023 11:30:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Ba', N'Bar', N'Bara', N'Barab', N'Baraba', 3, 2, 0, 2)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Baraba', N'Barab', N'Bara', N'Bar', N'Ba', 2, 0, 2, 3)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Barabashka', N'Barabashk', N'Barabash', N'Barabas', N'Baraba', 2000, 200, 20, 2)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Evgeniy', N'Saranchuk', N'Shereevich', N'Derevyanniy', N'ValeriyK.A', 120, 12, 12, 13)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Gena', N'Generer', N'Genesisovich', N'Genesis', N'GGG', 10, 9, 8, 7)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Gena', N'Kanaev', N'Karanaevich', N'Jelezniy', N'GenaV.A', 50, 1, 2, 3)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Misha', N'Karana', N'Valerich', N'Jelezniy', N'MaksimK.V', 100, 100, 100, 200)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Misha', N'Mishaev', N'Mishaeevich', N'Jelezniy', N'MaksonM.M', 1200, 10, 20, 30)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Petrovich', N'Petrovic', N'Petrovi', N'Petrov', N'Petro', 10, 11, 12, 13)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Petya', N'Genig', N'Ganareev', N'Stalnoi', N'PetyaJ.I', 25, 20, 30, 40)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Sanya', N'Gorov', N'Sharaeevich', N'Derevyanniy', N'DimitriyE.J', 12, 123, 32, 2)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Sergei', N'Kalinen', N'Shyukanuhovich', N'Stalnoi', N'PetrovP.P', 1, 0, 0, 0)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Sie', N'Puan', N'Tyao', N'Tyao', N'PihunSyao', 10, 20, 10, 30)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Vale', N'Valero', N'Valerono', N'Valeronobo', N'VALERONOBODO!', 300, 200, 300, 0)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Valera', N'Valer', N'Vale', N'Val', N'Va', 2, 3, 4, 5)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Vasya', N'Petya', N'Gena', N'Stalnoi', N'VasyaP.G', 13, 12, 12, 12)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Vasya', N'Vasy', N'Vas', N'Va', N'V', 100, 99, 98, 97)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Вася', N'Петя', N'Гена', N'Стальной', N'ВасяП.Г', 13, 12, 12, 12)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Гена', N'Канаев', N'Каранаевич', N'Железный', N'ГенаВ.А', 50, 1, 2, 3)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Евгений', N'Саранчук', N'Шереевич', N'Деревянный', N'ВалерийК.А', 120, 12, 12, 13)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Миша', N'Карана', N'Валерич', N'Железный', N'МаксимК.В', 100, 100, 100, 200)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Миша', N'Мишаев', N'Мишаеевич', N'Железный', N'МаксонМ.М', 1200, 10, 20, 30)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Петя', N'Гениг', N'Ганареев', N'Стальной', N'ПетяЖ.И', 25, 20, 30, 40)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Саня', N'Горов', N'Шараеевич', N'Деревянный', N'ДимитрийЕ.Ж', 12, 123, 32, 2)
INSERT [dbo].[MasterPieceAccounting] ([FirstName], [SecondName], [ThirdName], [WorkshopName], [WorkshopBossName], [WorkersCount], [ACount], [BCount], [CCount]) VALUES (N'Сергей', N'Калинен', N'Щуканюхович', N'Стальной', N'ПетровП.П', 1, 0, 0, 0)
GO
INSERT [dbo].[Users] ([Login], [Password]) VALUES (N'Gena', N'1234')
INSERT [dbo].[Users] ([Login], [Password]) VALUES (N'Max', N'Max')
GO
