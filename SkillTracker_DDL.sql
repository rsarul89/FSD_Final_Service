CREATE TABLE Associate
(
 Associate_Id INT PRIMARY KEY IDENTITY(1,1)
,Name VARCHAR(50)
,Email VARCHAR(50)
,Mobile  VARCHAR(10)
,Pic VARCHAR(100)
,Status_Green VARCHAR(1)
,Status_Blue VARCHAR(1)
,Status_Red VARCHAR(1)
,Level_1 VARCHAR(1)
,Level_2 VARCHAR(1)
,Level_3 VARCHAR(1)
,Remark VARCHAR(100)
,Strength VARCHAR(500)
,Weakness VARCHAR(500)
)

CREATE TABLE Skills
(
Skill_Id INT PRIMARY KEY IDENTITY(1,1)
,Skill_Name VARCHAR(50)
)

CREATE TABLE Associate_Skills
(
  [Id] INT PRIMARY KEY IDENTITY(1,1),
  Associate_Id INT NOT NULL
 ,Skill_Id INT NOT NULL
)

CREATE TABLE [User](
	[user_id] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL
)

GO
ALTER TABLE [dbo].[Associate_Skills]  WITH CHECK ADD  CONSTRAINT [FK_Associate_Skills_Associate] FOREIGN KEY([Associate_Id])
REFERENCES [dbo].[Associate] ([Associate_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Associate_Skills]  WITH CHECK ADD  CONSTRAINT [FK_Associate_Skills_Skills] FOREIGN KEY([Skill_Id])
REFERENCES [dbo].[Skills] ([Skill_Id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO