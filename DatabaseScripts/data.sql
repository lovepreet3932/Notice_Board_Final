INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'19d2e3bf-f638-4957-929d-0c0ae728afcb', N'student', N'student', N'27295390-7171-423f-bb84-87297f5948a8')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'6972a704-d6c9-4fa5-9836-8bdb26c13d77', N'notice_admin', N'notice_admin', N'4564cbab-942b-49cf-aa75-b4ec837c13ab')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'508f0932-e650-4927-bddc-bc45e21095e9', N'sam@gmail.com', N'SAM@GMAIL.COM', N'sam@gmail.com', N'SAM@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEDlcN0AttaI6471ernpcrmKAoghi2Ns8Ia0/yu7s9GVffzlRV8RyIC8Fb6fRyr1utw==', N'X7I6RNMPJN4R7MYPUXSC4Z3NVLQ3A5RR', N'fe735f92-8fb1-4e7f-bbce-ee01662edcc6', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd88aa4d5-8b83-4ac7-8b9a-34510cb2f0e5', N'jay@gmail.com', N'JAY@GMAIL.COM', N'jay@gmail.com', N'JAY@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEEYdGnKTE2acspEnGgei+ZdS80IB0hWgY0RSMjI+fR9Gq7GZ7CF4Q93H8bxAanjGOw==', N'PFONHZGIQC6J4R3N25G3TTGBB6YKHE2R', N'83ed35d6-d369-459b-82c9-afe758857636', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e88e4576-743c-4afb-9c46-01751f46e821', N'admin@notice.com', N'ADMIN@NOTICE.COM', N'admin@notice.com', N'ADMIN@NOTICE.COM', 1, N'AQAAAAEAACcQAAAAEFpovIyqAZLzii6B72NFTxfD2VX3aqg5fDVKhjncg7fuwN4FSIGhLb+lKkjGKVX8MQ==', N'MC5SFGU3MMFOP3ILAD6I2FGWKNUJSTQW', N'da384e62-7030-4a89-8bb5-9f3b66d34a81', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'508f0932-e650-4927-bddc-bc45e21095e9', N'19d2e3bf-f638-4957-929d-0c0ae728afcb')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd88aa4d5-8b83-4ac7-8b9a-34510cb2f0e5', N'19d2e3bf-f638-4957-929d-0c0ae728afcb')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e88e4576-743c-4afb-9c46-01751f46e821', N'6972a704-d6c9-4fa5-9836-8bdb26c13d77')
SET IDENTITY_INSERT [dbo].[Notice] ON
INSERT INTO [dbo].[Notice] ([Id], [NoticeTitle], [NoticeInformation]) VALUES (1, N'Techno Exhibition 2020', N'The University Management has decided  to hold the exhibition on 23 February this year. All  Science and IT students are required to present a tech project in the event. Please consult your Lecturers for more information')
INSERT INTO [dbo].[Notice] ([Id], [NoticeTitle], [NoticeInformation]) VALUES (2, N'Arts Concert  2020', N'The Faculty of Arts students  will perform in their annual concert on 25 March . Please arrange meetings with your supervisors to discuss about the event')
SET IDENTITY_INSERT [dbo].[Notice] OFF
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT INTO [dbo].[Student] ([Id], [Name], [StudentEmail]) VALUES (1, N'Jay Houston', N'jay@gmail.com')
INSERT INTO [dbo].[Student] ([Id], [Name], [StudentEmail]) VALUES (2, N'Sam Smith', N'sam@gmail.com')
SET IDENTITY_INSERT [dbo].[Student] OFF
SET IDENTITY_INSERT [dbo].[NoticeView] ON
INSERT INTO [dbo].[NoticeView] ([Id], [NoticeId], [StudentId]) VALUES (1, 1, 1)
INSERT INTO [dbo].[NoticeView] ([Id], [NoticeId], [StudentId]) VALUES (2, 2, 2)
INSERT INTO [dbo].[NoticeView] ([Id], [NoticeId], [StudentId]) VALUES (3, 1, 2)
SET IDENTITY_INSERT [dbo].[NoticeView] OFF
