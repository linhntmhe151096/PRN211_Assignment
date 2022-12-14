USE [CenimaDB]
GO
/****** Object:  Table [dbo].[Genres]    Script Date: 8/8/2022 10:08:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genres](
	[GenreID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [nvarchar](200) NULL,
 CONSTRAINT [PK_Genres] PRIMARY KEY CLUSTERED 
(
	[GenreID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movies]    Script Date: 8/8/2022 10:08:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movies](
	[MovieID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](200) NULL,
	[Year] [int] NULL,
	[Image] [nvarchar](255) NULL,
	[Description] [ntext] NULL,
	[GenreID] [int] NULL,
 CONSTRAINT [PK_Movies] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Persons]    Script Date: 8/8/2022 10:08:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Persons](
	[PersonID] [int] IDENTITY(1,1) NOT NULL,
	[Fullname] [nvarchar](200) NULL,
	[Gender] [nvarchar](10) NULL,
	[Email] [varchar](50) NULL,
	[Password] [varchar](100) NULL,
	[Type] [int] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED 
(
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rates]    Script Date: 8/8/2022 10:08:24 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rates](
	[MovieID] [int] NOT NULL,
	[PersonID] [int] NOT NULL,
	[Comment] [ntext] NULL,
	[NumericRating] [float] NULL,
	[Time] [datetime] NULL,
 CONSTRAINT [PK_Rates] PRIMARY KEY CLUSTERED 
(
	[MovieID] ASC,
	[PersonID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Genres] ON 

INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (1, N'Hành động ')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (2, N'Tâm lý tình cảm')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (3, N'Kinh dị')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (4, N'Hoạt hình')
INSERT [dbo].[Genres] ([GenreID], [Description]) VALUES (5, N'Khoa học - Nghệ thuật')
SET IDENTITY_INSERT [dbo].[Genres] OFF
GO
SET IDENTITY_INSERT [dbo].[Movies] ON 

INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (1, N'Vua hải tặc', 2020, N'https://truyencool.net/wp-content/uploads/2021/08/Ln4YSoq.jpg', N'One Piece - Đảo Hải Tặc là chuyện về cậu bé Monkey D.Luffy do ăn nhầm Trái Ác Qủy, biến thành người cao su và sẽ không bao giờ biết bơi. 10 năm sau sự việc đó, cậu rời quê nhà mình và lên đường kiếm đủ nhằm tập hợp cho mình 10 thành viên thủy thủ để thành băng hải tặc với biệt hiệu là Băng Hải Tặc Mủ Rơm.', 4)
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (2, N'Mặt nạ gương', 2020, N'https://afamilycdn.com/150157425591193600/2021/10/9/poster-mat-na-guong-poster-printart-1633755811868240956829.jpg', N'''Mặt nạ gương'' xoay quanh nhân vật Hoa - một nhà văn trinh thám đang tìm chất liệu để hoàn thành series Mật danh K. Cô tìm đến bố là ông Nghị - một bác sĩ thẩm mỹ có tiếng, và Tùng - người bạn thân, cũng là đội trưởng đội trọng án để có thêm thông tin. Nhưng không ngờ, những tình tiết tạo nên câu chuyện hư cấu lại liên quan đến cái chết của mẹ cô 20 năm về trước mà nghi phạm, bi kịch thay, chính là ông Nghị… ', 1)
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (4, N'Về nhà đi con', 2021, N'https://static.kinhtedothi.vn/w960/images/upload/2021/12/25/lien-hoan-1.jpg', N'Câu chuyện phim Về nhà đi con xoay quanh 3 chị em gái Thu Huệ, Anh Thư, Ánh Dương mồ côi mẹ từ thuở nhỏ, mỗi người một tính cách, một lối sống. Chị cả Thu Huệ dịu dàng, điềm đạm; cô hai Anh Thư xinh đẹp, sắc sảo, thực dụng; cô út Ánh Dương bộc trực, hoang dã, sống như một cậu con trai. Cả 3 chị em đều gặp phải những biến cố của riêng mình nhưng họ may mắn khi có chung một điểm tựa là ông Sơn - một người bố tận tuỵ, hết mực yêu thương các con. Sau nhiều biến cố, cuối cùng, 3 cô con gái đều nhận ra hạnh phúc lớn nhất mà họ có được chính là một người bố luôn sẵn sàng bao bọc và nói "Về nhà đi con" bất cứ khi nào họ cần một mái ấm...', 2)
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (5, N'Ngõ nhỏ vào đời', 2022, N'https://vtv1.mediacdn.vn/thumb_w/640/2022/6/17/lnvd1-1655432338940733463141.jpg', N'Demo', 2)
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (6, N'Nỗi ám ảnh', 2021, N'https://static.247phim.com/146564/conversions/5ebe080b5e83f_pulse_d-435_627.jpg', N'demo', 3)
INSERT [dbo].[Movies] ([MovieID], [Title], [Year], [Image], [Description], [GenreID]) VALUES (8, N'Oxygen', 2021, N'https://upload.wikimedia.org/wikipedia/en/d/de/Oxygen_2021_poster.jpg', N'Demo', 5)
SET IDENTITY_INSERT [dbo].[Movies] OFF
GO
SET IDENTITY_INSERT [dbo].[Persons] ON 

INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (1, N'Phạm Minh Hùng', N'Nam', N'user1@gmail.com', N'123', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (2, N'Phạm Ngọc Minh Châu', N'Nữ', N'user2@gmail.com', N'1234', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (3, N'Hoàng Đức Hải', N'Nam', N'user3@gmail.com', N'12345', 2, 0)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (4, N'Quách Như Thế', N'Nam', N'user4@gmail.com', N'123456', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (5, N'Nguyễn Thùy Dương', N'Nữ', N'user5@gmail.com', N'1234567', 2, 0)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (6, N'Trịnh Thị Trang', N'Nữ', N'user6@gmail.com', N'12345678', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (7, N'Hoàng Tùng', N'Nam', N'user7@gmail.com', N'123456789', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (8, N'Linh Nguyen', N'Nữ', N'linh@gmail.com', N'123', 1, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (9, N'hihihihi', N'Nữ', N'user9@gmail.com', N'123456', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (10, N'aaaa', N'Nam', N'user44@gmail.com', N'123456', 2, 1)
INSERT [dbo].[Persons] ([PersonID], [Fullname], [Gender], [Email], [Password], [Type], [IsActive]) VALUES (11, N'aaaa', N'Nữ', N'test@gmail.com', N'123', 2, 1)
SET IDENTITY_INSERT [dbo].[Persons] OFF
GO
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (1, 1, N'Phim rất hay nhé các bạn', 9.6, CAST(N'2022-10-06T00:00:00.000' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (1, 2, N'Phim ok', 8, CAST(N'2022-07-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (1, 3, N'Không hay', 4, CAST(N'2022-07-22T00:00:00.000' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (1, 4, N'aaaaaaaaaaaaaaaaa
', 9, NULL)
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (1, 5, N'sao ta', 5, NULL)
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (1, 11, N'hay', 10, NULL)
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (2, 1, N'Cx dc', 7, CAST(N'2022-07-23T00:00:00.000' AS DateTime))
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (2, 5, N'sao nhỉ', 6, NULL)
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (4, 4, N'hay phwt', 8, NULL)
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (4, 5, N'cx ổn', 7, NULL)
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (5, 2, N'Phản ánh đời thực', 8, NULL)
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (6, 2, N'Gay cấn', 9, NULL)
INSERT [dbo].[Rates] ([MovieID], [PersonID], [Comment], [NumericRating], [Time]) VALUES (8, 2, N'Hình ảnh đẹp', 8, NULL)
GO
ALTER TABLE [dbo].[Movies]  WITH CHECK ADD  CONSTRAINT [FK_Movies_Genres] FOREIGN KEY([GenreID])
REFERENCES [dbo].[Genres] ([GenreID])
GO
ALTER TABLE [dbo].[Movies] CHECK CONSTRAINT [FK_Movies_Genres]
GO
ALTER TABLE [dbo].[Rates]  WITH CHECK ADD  CONSTRAINT [FK_Rates_Movies] FOREIGN KEY([MovieID])
REFERENCES [dbo].[Movies] ([MovieID])
GO
ALTER TABLE [dbo].[Rates] CHECK CONSTRAINT [FK_Rates_Movies]
GO
ALTER TABLE [dbo].[Rates]  WITH CHECK ADD  CONSTRAINT [FK_Rates_Persons] FOREIGN KEY([PersonID])
REFERENCES [dbo].[Persons] ([PersonID])
GO
ALTER TABLE [dbo].[Rates] CHECK CONSTRAINT [FK_Rates_Persons]
GO
