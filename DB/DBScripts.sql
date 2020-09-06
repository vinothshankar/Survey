IF NOT EXISTS(SELECT 1 FROM sys.databases WHERE name='Survey')
    CREATE DATABASE [Survey]
GO
USE [Survey]
GO
/****** Object:  Table [dbo].[answers]    Script Date: 9/6/2020 8:34:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[answers](
	[answer_id] [bigint] IDENTITY(1,1) NOT NULL,
	[question_id] [bigint] NOT NULL,
	[option_id] [bigint] NOT NULL,
	[user_nm] [varchar](128) NOT NULL,
 CONSTRAINT [PK_answers] PRIMARY KEY CLUSTERED 
(
	[answer_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[options]    Script Date: 9/6/2020 8:34:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[options](
	[option_id] [bigint] IDENTITY(1,1) NOT NULL,
	[question_id] [bigint] NOT NULL,
	[text] [text] NOT NULL,
 CONSTRAINT [PK_options] PRIMARY KEY CLUSTERED 
(
	[option_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[questions]    Script Date: 9/6/2020 8:34:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[questions](
	[question_id] [bigint] IDENTITY(1,1) NOT NULL,
	[survey_id] [bigint] NOT NULL,
	[title] [text] NOT NULL,
	[sub_title] [text] NULL,
	[question_typ] [int] NULL,
	[created_by] [varchar](128) NOT NULL,
	[created_date] [datetime] NOT NULL,
 CONSTRAINT [PK_Questions] PRIMARY KEY CLUSTERED 
(
	[question_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[surveys]    Script Date: 9/6/2020 8:34:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[surveys](
	[survey_id] [bigint] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_surveys] PRIMARY KEY CLUSTERED 
(
	[survey_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[answers] ON 
GO
INSERT [dbo].[answers] ([answer_id], [question_id], [option_id], [user_nm]) VALUES (1, 1, 2, N'6cf470f3-d292-4efb-972e-a6bf97c7328a')
GO
SET IDENTITY_INSERT [dbo].[answers] OFF

GO
SET IDENTITY_INSERT [dbo].[questions] ON 

INSERT [dbo].[questions] ([question_id], [survey_id], [title], [sub_title], [question_typ], [created_by], [created_date]) VALUES (1, 1, N'How many astronauts
landed on the moon?', NULL, 3, N'Elisabeth
Winters', CAST(N'2020-09-05 19:22:16.543' AS DateTime))
INSERT [dbo].[questions] ([question_id], [survey_id], [title], [sub_title], [question_typ], [created_by], [created_date]) VALUES (4, 2, N'What Is the highest peak in the world?', NULL, 3, N'Willson', CAST(N'2020-09-07 03:28:18.440' AS DateTime))
INSERT [dbo].[questions] ([question_id], [survey_id], [title], [sub_title], [question_typ], [created_by], [created_date]) VALUES (5, 3, N'What is the largest ocean int earth?', NULL, 3, N'wilson', CAST(N'2020-09-07 03:36:47.030' AS DateTime))
SET IDENTITY_INSERT [dbo].[questions] OFF
SET IDENTITY_INSERT [dbo].[options] ON 

INSERT [dbo].[options] ([option_id], [question_id], [text]) VALUES (1, 1, N'1')
INSERT [dbo].[options] ([option_id], [question_id], [text]) VALUES (2, 1, N'2')
INSERT [dbo].[options] ([option_id], [question_id], [text]) VALUES (3, 1, N'3')
INSERT [dbo].[options] ([option_id], [question_id], [text]) VALUES (8, 4, N'Everest')
INSERT [dbo].[options] ([option_id], [question_id], [text]) VALUES (9, 4, N'Aconcagua')
INSERT [dbo].[options] ([option_id], [question_id], [text]) VALUES (10, 4, N'Kilimanjaro')
INSERT [dbo].[options] ([option_id], [question_id], [text]) VALUES (11, 5, N'Arctic Ocean')
INSERT [dbo].[options] ([option_id], [question_id], [text]) VALUES (12, 5, N'Pacific Ocean')
INSERT [dbo].[options] ([option_id], [question_id], [text]) VALUES (13, 5, N'Atlantic Ocean')
SET IDENTITY_INSERT [dbo].[options] OFF
GO
SET IDENTITY_INSERT [dbo].[surveys] ON 
GO
INSERT [dbo].[surveys] ([survey_id], [name]) VALUES (1, N'Survey1')
GO
INSERT [dbo].[surveys] ([survey_id], [name]) VALUES (2, N'Survey2')
GO
INSERT [dbo].[surveys] ([survey_id], [name]) VALUES (3, N'Survey3')
GO
SET IDENTITY_INSERT [dbo].[surveys] OFF
GO
ALTER TABLE [dbo].[questions] ADD  CONSTRAINT [DF_Questions_created_date]  DEFAULT (getdate()) FOR [created_date]
GO
ALTER TABLE [dbo].[answers]  WITH CHECK ADD  CONSTRAINT [FK_answers_options] FOREIGN KEY([option_id])
REFERENCES [dbo].[options] ([option_id])
GO
ALTER TABLE [dbo].[answers] CHECK CONSTRAINT [FK_answers_options]
GO
ALTER TABLE [dbo].[answers]  WITH CHECK ADD  CONSTRAINT [FK_answers_questions] FOREIGN KEY([question_id])
REFERENCES [dbo].[questions] ([question_id])
GO
ALTER TABLE [dbo].[answers] CHECK CONSTRAINT [FK_answers_questions]
GO
ALTER TABLE [dbo].[options]  WITH CHECK ADD  CONSTRAINT [FK_Options_Questions] FOREIGN KEY([question_id])
REFERENCES [dbo].[questions] ([question_id])
GO
ALTER TABLE [dbo].[options] CHECK CONSTRAINT [FK_Options_Questions]
GO
ALTER TABLE [dbo].[questions]  WITH CHECK ADD  CONSTRAINT [FK_Questions_Survey] FOREIGN KEY([survey_id])
REFERENCES [dbo].[surveys] ([survey_id])
GO
ALTER TABLE [dbo].[questions] CHECK CONSTRAINT [FK_Questions_Survey]
GO
