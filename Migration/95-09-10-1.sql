USE [GasStation]
GO
ALTER TABLE [dbo].[Plate] DROP CONSTRAINT [FK_Plate_Base.PlateCity]
GO

ALTER TABLE [dbo].[Base.PlateCity] DROP CONSTRAINT [FK_Base.PlateCity_User_Modify]
GO

ALTER TABLE [dbo].[Base.PlateCity] DROP CONSTRAINT [FK_Base.PlateCity_User_Insert]
GO

/****** Object:  Table [dbo].[Base.PlateCity]    Script Date: 30/11/2016 03:23:16 ب.ظ ******/
DROP TABLE [dbo].[Base.PlateCity]
GO

/****** Object:  Table [dbo].[Base.PlateCity]    Script Date: 30/11/2016 03:20:06 ب.ظ ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Base.PlateCity](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[viewId] [uniqueidentifier] NOT NULL CONSTRAINT [DF_Base.PlateCity_viewId]  DEFAULT (newid()),
	[code] [varchar](3) NOT NULL,
	[city] [varchar](50) NOT NULL,
	[insertedById] [int] NOT NULL,
	[insertDate] [datetime] NOT NULL CONSTRAINT [DF_Base.PlateCity_insertDate]  DEFAULT (getdate()),
	[updatedById] [int] NULL,
	[updateDate] [datetime] NULL,
 CONSTRAINT [PK_Base.PlateCity] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCity] ON 

GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (166, N'd89f3e65-4614-42f1-90b4-116a4f68e9e4', N'11', N'تهران شمال', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (167, N'13580c42-81d3-4e88-ac47-0e8e024f4920', N'12', N'مشهد', 2, CAST(N'2016-11-30 15:13:34.030' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (168, N'fa56f2d6-b345-4818-adc4-f15d42a9bba1', N'13', N'اصفهان', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (169, N'17dccf50-8fc6-4dff-b2b9-c2b267d4b77d', N'14', N'اهواز', 2, CAST(N'2016-11-30 15:13:34.033' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (170, N'81f2d663-e19c-4044-9877-8a2d55e36c6a', N'15', N'تبريز', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (171, N'b85d1a14-b7b6-4be0-a0c5-90e52e9102c8', N'16', N'قم', 2, CAST(N'2016-11-30 15:13:34.037' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (172, N'972d9a92-46fb-41e9-8f24-56753fab5b50', N'17', N'اروميه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (173, N'd62b0e6c-6a6b-42e8-a17e-e8db0bdf6501', N'18', N'همدان', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (174, N'dbdd3de0-af94-4cb6-ab8d-5b3c44f72d74', N'19', N'کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.040' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (175, N'48f9c2b5-c812-4c02-ba43-15bcedf9771c', N'21', N'استان تهران', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (176, N'b0dee809-3e46-4e9b-98dd-b2e586e685e9', N'22', N'تهران مرکز', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (177, N'b04dbae6-1a7d-4ddd-b6ea-173af9f1da65', N'23', N'استان اصفهان', 2, CAST(N'2016-11-30 15:13:34.043' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (178, N'48335aae-6a91-45e1-8657-f523ac56db00', N'24', N'استان خوزستان', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (179, N'4d1e6965-8c9f-4cab-8e0d-10c62b691c2a', N'25', N'استان آذربايجان شرقي', 2, CAST(N'2016-11-30 15:13:34.047' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (180, N'cd3b580d-e649-49b9-a3a3-6188472bfd12', N'26', N'استان قم', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (181, N'a4b15a25-9f77-423c-934b-898ed12643a3', N'27', N'استان آربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (182, N'37445188-1dab-4dce-abdf-facf6ed8d9b9', N'28', N'استان همدان', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (183, N'60d5c0c0-4b88-44ac-bd15-f80022dd9b3d', N'29', N'استان کرمانشاه', 2, CAST(N'2016-11-30 15:13:34.050' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (184, N'e415725c-ce86-4305-8366-cd2e1c1d155e', N'31', N'سنندج', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (185, N'0a0edc4f-5cbd-46c4-a169-d65c92f94ce1', N'32', N'استان خراسان', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (186, N'55834de5-744d-418a-85b8-e07f97a89e8b', N'33', N'تهران جنوب', 2, CAST(N'2016-11-30 15:13:34.053' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (190, N'b64df916-d05f-43c1-8993-81142dad7515', N'37', N'استان آذربايجان غربي', 2, CAST(N'2016-11-30 15:13:34.137' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (193, N'71212ea5-81df-4b98-8695-eed4d4429bc5', N'41', N'استان کردستان', 2, CAST(N'2016-11-30 15:13:34.143' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (197, N'859de2f5-1457-4219-97ac-f388839b6a3b', N'45', N'کرمان', 2, CAST(N'2016-11-30 15:13:34.163' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (198, N'f53c5c34-1876-4e95-aa62-19a7a2aa1dd0', N'46', N'رشت', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (199, N'9e959359-3cbf-4abc-a6fd-8e50454026f0', N'47', N'اراک', 2, CAST(N'2016-11-30 15:13:34.167' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (200, N'404d7e25-67b6-481d-98b6-46fa6cd38293', N'48', N'بوشهر', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (201, N'd36c8d08-e481-4fdc-bb2b-6df98b2f30b9', N'49', N'استان کهکيلويه و بوير احمد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (202, N'e2c28ca4-1d6f-4243-a606-de919c50f136', N'51', N'خرم آباد', 2, CAST(N'2016-11-30 15:13:34.170' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (205, N'8710b474-9a56-43ed-a895-15d923ed91bc', N'54', N'يزد', 2, CAST(N'2016-11-30 15:13:34.173' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (206, N'6bb8f311-1b12-46a3-8497-2a38474be6dc', N'55', N'تهران مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (207, N'4f1a41c4-594c-4ebb-9c78-b093ae9d1b8f', N'56', N'گيلان', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (208, N'dca07382-9cb8-4561-a74e-4bd710251a3f', N'57', N'استان مرکزي', 2, CAST(N'2016-11-30 15:13:34.177' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (209, N'cbf80c6d-eba4-4168-ba88-ce2ebe239483', N'58', N'استان بوشهر', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (210, N'c1c56ac3-5960-45d0-98c6-4e163fa43ead', N'59', N'گرگان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (211, N'5cc3434a-59f1-425c-80bc-5c53870854ce', N'61', N'استان لرستان', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (212, N'73e3e333-2acf-4722-bb0b-83e2bf04fb96', N'62', N'ساري', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (213, N'21ffd625-4f7d-49a1-ac68-6649eb7faeaa', N'63', N'شيراز', 2, CAST(N'2016-11-30 15:13:34.180' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (214, N'886c7321-954e-4250-b779-71bd090ea8b4', N'64', N'استان يزد', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (215, N'e6cac1e3-bd5b-40c3-8bc4-1dd8d5507640', N'65', N'استان کرمان', 2, CAST(N'2016-11-30 15:13:34.183' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (218, N'6e5ee6e0-55e8-4dd4-a043-d2c35c144d95', N'68', N'کرج', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (219, N'7bcb20a2-f287-4bc2-9653-94ab67a5be93', N'69', N'استان گرگان', 2, CAST(N'2016-11-30 15:13:34.187' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (220, N'b0ee0e4f-0d89-4575-90fb-dd3cfbd7c488', N'71', N'شهرکرد', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (221, N'2dce554a-8272-4805-85f5-7e9a5f34dd5b', N'72', N'استان مازندران', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (222, N'e36e9e76-7427-470f-95b9-25a3963eaaa9', N'73', N'استان فارس', 2, CAST(N'2016-11-30 15:13:34.190' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (225, N'b8d54fe7-3584-4f02-9801-50ba84d73064', N'76', N'استان گيلان', 2, CAST(N'2016-11-30 15:13:34.193' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (227, N'7261c50b-23c7-40a1-9e71-3eb1cc125e7b', N'78', N'شهرستان هاي تهران', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (228, N'd140671e-f99d-4044-b984-851ef9fccadf', N'79', N'قزوين', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (229, N'42d92392-780b-47a1-8a33-1341252a5e11', N'81', N'استان چهار محال و بختياري', 2, CAST(N'2016-11-30 15:13:34.197' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (232, N'f1d08f21-4690-41b3-bdec-5f920c52ee74', N'84', N'بندرعباس', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (233, N'19935827-e134-4371-9171-b00891200bb1', N'85', N'زاهدان', 2, CAST(N'2016-11-30 15:13:34.200' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (234, N'd3c08b03-94cb-43d2-92bc-4ca7c5bf2104', N'86', N'سمنان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (235, N'12a1126e-24f2-44ab-9507-26611a6d0160', N'87', N'زنجان', 2, CAST(N'2016-11-30 15:13:34.203' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (237, N'e5109647-b0c5-4587-a6da-587a15b29047', N'89', N'استان قزوين', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (238, N'ddc5677d-0fd6-4fe2-baff-7430389dfbc0', N'91', N'اردبيل', 2, CAST(N'2016-11-30 15:13:34.207' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (241, N'5695724b-9f54-45fa-9a95-bd7d6f67e652', N'94', N'استان هرمزگان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (242, N'3fa1a814-c237-429c-8e08-a558084ee817', N'95', N'استان سيستان و بلوچستان', 2, CAST(N'2016-11-30 15:13:34.210' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (243, N'15df7003-a5cc-44e9-88e5-8c5e4230d44f', N'96', N'استان سمنان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (244, N'4a8e8504-7539-4db7-8978-c20fabb72894', N'97', N'استان زنجان', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (245, N'7272f1f3-6df9-4616-b84d-bf25f5c55d0b', N'98', N'ايلام', 2, CAST(N'2016-11-30 15:13:34.213' AS DateTime), NULL, NULL)
GO
INSERT [dbo].[Base.PlateCity] ([id], [viewId], [code], [city], [insertedById], [insertDate], [updatedById], [updateDate]) VALUES (249, N'7c8964a8-fdd3-4a1b-b7b5-b7d66ec3a87c', N'99', N'تهران جنوب', 2, CAST(N'2016-11-30 15:18:52.400' AS DateTime), NULL, NULL)
GO
SET IDENTITY_INSERT [dbo].[Base.PlateCity] OFF
GO
ALTER TABLE [dbo].[Base.PlateCity]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateCity_User_Insert] FOREIGN KEY([insertedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateCity] CHECK CONSTRAINT [FK_Base.PlateCity_User_Insert]
GO
ALTER TABLE [dbo].[Base.PlateCity]  WITH CHECK ADD  CONSTRAINT [FK_Base.PlateCity_User_Modify] FOREIGN KEY([updatedById])
REFERENCES [dbo].[User] ([id])
GO
ALTER TABLE [dbo].[Base.PlateCity] CHECK CONSTRAINT [FK_Base.PlateCity_User_Modify]
GO

ALTER TABLE [dbo].[Plate]  WITH CHECK ADD  CONSTRAINT [FK_Plate_Base.PlateCity] FOREIGN KEY([plateCityId])
REFERENCES [dbo].[Base.PlateCity] ([id])
ON UPDATE CASCADE
GO

ALTER TABLE [dbo].[Plate] CHECK CONSTRAINT [FK_Plate_Base.PlateCity]
GO

/*
	UPDATE DB VERSION
*/
DECLARE @version	varchar(50) = '95-09-10-1';

IF EXISTS (SELECT * FROM [System.Data] WHERE ([name] = 'DB-Version'))
	BEGIN
		UPDATE [System.Data] SET [value]=@version WHERE ([name] = 'DB-Version')
	END
ELSE
	BEGIN
		INSERT INTO [System.Data] ([name], [value]) VALUES ('DB-Version', @version)
	END
GO