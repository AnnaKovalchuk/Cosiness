USE [Hotel]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 07.03.2023 20:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[BookingID] [int] IDENTITY(1,1) NOT NULL,
	[RoomID] [int] NOT NULL,
	[GuestID] [int] NOT NULL,
	[ArrivalDate] [datetime] NOT NULL,
	[DepartureDate] [datetime] NOT NULL,
	[StatusBookingID] [int] NOT NULL,
 CONSTRAINT [PK_Booking] PRIMARY KEY CLUSTERED 
(
	[BookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 07.03.2023 20:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NOT NULL,
	[CategoryDescription] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guest]    Script Date: 07.03.2023 20:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guest](
	[GuestID] [int] IDENTITY(1,1) NOT NULL,
	[GuestFullName] [nvarchar](max) NOT NULL,
	[Passport] [nchar](10) NOT NULL,
	[Address] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Guest] PRIMARY KEY CLUSTERED 
(
	[GuestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 07.03.2023 20:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[RoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[RoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room]    Script Date: 07.03.2023 20:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room](
	[RoomID] [int] NOT NULL,
	[RoomCategoryID] [int] NOT NULL,
	[QuantityOfPeople] [int] NOT NULL,
	[StatusID] [int] NOT NULL,
	[Cost] [float] NOT NULL,
	[Photo] [nvarchar](50) NULL,
 CONSTRAINT [PK_Room] PRIMARY KEY CLUSTERED 
(
	[RoomID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 07.03.2023 20:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[StatusName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StatusBooking]    Script Date: 07.03.2023 20:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StatusBooking](
	[StatusBookingID] [int] NOT NULL,
	[StatusBookingName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_StatusBooking] PRIMARY KEY CLUSTERED 
(
	[StatusBookingID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 07.03.2023 20:27:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FullName] [nvarchar](max) NOT NULL,
	[Login] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[RoleID] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Booking] ON 

INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (1, 103, 3, CAST(N'2023-03-03T00:00:00.000' AS DateTime), CAST(N'2023-03-21T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (2, 202, 4, CAST(N'2023-03-04T00:00:00.000' AS DateTime), CAST(N'2023-03-15T00:00:00.000' AS DateTime), 0)
INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (3, 202, 5, CAST(N'2023-03-04T00:00:00.000' AS DateTime), CAST(N'2023-03-15T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (4, 302, 1, CAST(N'2023-02-28T00:00:00.000' AS DateTime), CAST(N'2023-03-16T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (5, 403, 7, CAST(N'2023-03-01T00:00:00.000' AS DateTime), CAST(N'2023-03-31T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (6, 401, 11, CAST(N'2023-03-07T14:05:06.000' AS DateTime), CAST(N'2023-03-08T14:05:06.000' AS DateTime), 1)
INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (7, 402, 12, CAST(N'2023-03-07T14:25:39.000' AS DateTime), CAST(N'2023-03-09T14:25:39.000' AS DateTime), 1)
INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (8, 401, 13, CAST(N'2023-03-07T14:49:21.000' AS DateTime), CAST(N'2023-03-11T14:49:21.000' AS DateTime), 1)
INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (9, 401, 14, CAST(N'2023-03-07T14:52:32.000' AS DateTime), CAST(N'2023-03-16T14:52:32.000' AS DateTime), 1)
INSERT [dbo].[Booking] ([BookingID], [RoomID], [GuestID], [ArrivalDate], [DepartureDate], [StatusBookingID]) VALUES (10, 401, 15, CAST(N'2023-03-07T14:57:54.000' AS DateTime), CAST(N'2023-03-09T14:57:54.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[Booking] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription]) VALUES (1, N'Single room / SGL', N'Стандартный номер с одной кроватью для проживания одного человека')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription]) VALUES (2, N'Double room / DBL', N'Номер с одной двуспальной кроватью для пары')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription]) VALUES (3, N'Twin room / TWIN', N'Номер с двумя отдельными кроватями')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription]) VALUES (4, N'Triple room / TRPL', N'Номер удобен для семью с ребенком - одна двуспальная и одна односпальная кровать')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription]) VALUES (5, N'Quadriple room / QDPL', N'Номер с четырьмя односпальными кроватями')
INSERT [dbo].[Category] ([CategoryID], [CategoryName], [CategoryDescription]) VALUES (6, N'Apartment', N'Номер с двуспальной кроватью, гостиной и кухней')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Guest] ON 

INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (1, N'Никитин Глеб Михайлович', N'5793903275', N'Ленинградская область, город Кашира, пл. Балканская, 37')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (2, N'Семенова Софья Дмитриевна', N'3223584615', N'Калининградская область, город Луховицы, наб. Гоголя, 12')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (3, N'Васильев Егор Германович', N'7224449998', N'Пензенская область, город Истра, пл. Ладыгина, 40')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (4, N'Смирнова Ирина Александровна', N'2375838684', N'Мурманская область, город Чехов, пр. Сталина, 42')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (5, N'Петров Андрей Владимирович', N'5072611344', N'Смоленская область, город Щёлково, проезд 1905 года, 27')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (6, N'Егоров Максим Андреевич', N'3087369495', N'Вологодская область, город Наро-Фоминск, бульвар Космонавтов, 77')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (7, N'Никитин Артур Алексеевич', N'6835827263', N'Нижегородская область, город Серпухов, пр. Бухарестская, 63')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (8, N'Киселев Максим Сергеевич', N'8989641669', N'Ивановская область, город Ногинск, спуск 1905 года, 93')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (9, N'Борисов Тимур Егорович', N'7515768021', N'Омская область, город Раменское, шоссе Чехова, 20')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (10, N'Климов Арсений Тимурович', N'3170576315', N'Калужская область, город Луховицы, пр. Балканская, 69')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (11, N'Ильинова Светлана Александровна', N'5355634987', N'Омск, пр.Науки 23')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (12, N'Ковалев Андрей', N'1234567890', N'Екатеринбург, пр.Металлургов 13')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (13, N'Ким Ян', N'2387387389', N'Москва, пр.Науки 10')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (14, N'Цой Олег Иванович', N'1234817649', N'Москва, ул.Декабристов 1')
INSERT [dbo].[Guest] ([GuestID], [GuestFullName], [Passport], [Address]) VALUES (15, N'Кротов Иван Алексеевич', N'7463859476', N'Курск, ул. Комсомольская 67')
SET IDENTITY_INSERT [dbo].[Guest] OFF
GO
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (1, N'Администратор')
INSERT [dbo].[Role] ([RoleID], [RoleName]) VALUES (2, N'Менеджер')
SET IDENTITY_INSERT [dbo].[Role] OFF
GO
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (101, 1, 1, 2, 1000, N'SGL.jpg')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (102, 1, 1, 2, 1000, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (103, 1, 1, 2, 1000, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (201, 2, 2, 2, 1200, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (202, 2, 2, 2, 1200, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (203, 2, 2, 3, 1200, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (204, 2, 2, 2, 1200, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (205, 2, 2, 1, 1200, N'DBL.jpg')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (206, 3, 2, 1, 1600, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (207, 3, 2, 1, 1600, N'TWIN.jpg')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (208, 3, 2, 1, 1600, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (301, 4, 3, 1, 2200, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (302, 4, 3, 1, 2200, N'TRPL.jpeg')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (305, 5, 4, 1, 3000, N'QDPL.jpeg')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (401, 6, 2, 1, 3500, NULL)
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (402, 6, 2, 1, 3500, N'')
INSERT [dbo].[Room] ([RoomID], [RoomCategoryID], [QuantityOfPeople], [StatusID], [Cost], [Photo]) VALUES (403, 6, 2, 1, 3500, N'APRT.jpg')
GO
SET IDENTITY_INSERT [dbo].[Status] ON 

INSERT [dbo].[Status] ([StatusID], [StatusName]) VALUES (1, N'Свободен')
INSERT [dbo].[Status] ([StatusID], [StatusName]) VALUES (2, N'Занят')
INSERT [dbo].[Status] ([StatusID], [StatusName]) VALUES (3, N'На ремонте')
SET IDENTITY_INSERT [dbo].[Status] OFF
GO
INSERT [dbo].[StatusBooking] ([StatusBookingID], [StatusBookingName]) VALUES (0, N'Открыта')
INSERT [dbo].[StatusBooking] ([StatusBookingID], [StatusBookingName]) VALUES (1, N'Закрыта')
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [FullName], [Login], [Password], [RoleID]) VALUES (1, N'Пахомова Аиша Анатольевна', N'm4ic8j5qgstw@gmail.com', N'2L6KZG', 1)
INSERT [dbo].[User] ([UserID], [FullName], [Login], [Password], [RoleID]) VALUES (2, N'Жуков Роман Богданович', N'd43zfg9tlsyv@gmail.com', N'uzWC67', 1)
INSERT [dbo].[User] ([UserID], [FullName], [Login], [Password], [RoleID]) VALUES (3, N'Киселева Анастасия Максимовна', N'8ohgisf6k45w@outlook.com', N'8ntwUp', 1)
INSERT [dbo].[User] ([UserID], [FullName], [Login], [Password], [RoleID]) VALUES (4, N'Григорьева Арина Арсентьевна', N'hi1brwj46czx@mail.com', N'YOyhfR', 2)
INSERT [dbo].[User] ([UserID], [FullName], [Login], [Password], [RoleID]) VALUES (5, N'Иванов Лев Михайлович', N'fvkbcamhlj52@gmail.com', N'RSbvHv', 2)
INSERT [dbo].[User] ([UserID], [FullName], [Login], [Password], [RoleID]) VALUES (6, N'Григорьев Лев Давидович', N'9qxnce8jwruv@gmail.com', N'rwVDh9', 2)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Guest] FOREIGN KEY([GuestID])
REFERENCES [dbo].[Guest] ([GuestID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Guest]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_Room] FOREIGN KEY([RoomID])
REFERENCES [dbo].[Room] ([RoomID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_Room]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [FK_Booking_StatusBooking] FOREIGN KEY([StatusBookingID])
REFERENCES [dbo].[StatusBooking] ([StatusBookingID])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [FK_Booking_StatusBooking]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Category] FOREIGN KEY([RoomCategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Category]
GO
ALTER TABLE [dbo].[Room]  WITH CHECK ADD  CONSTRAINT [FK_Room_Status] FOREIGN KEY([StatusID])
REFERENCES [dbo].[Status] ([StatusID])
GO
ALTER TABLE [dbo].[Room] CHECK CONSTRAINT [FK_Room_Status]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([RoleID])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Role]
GO
