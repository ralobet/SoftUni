USE master
GO

IF DB_ID('BlogDB') IS NOT NULL
BEGIN
    ALTER DATABASE BlogDB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;
	DROP DATABASE BlogDB
END
GO

CREATE DATABASE BlogDB
GO

USE BlogDB
GO

CREATE TABLE Users(
	ID int IDENTITY NOT NULL,
	Username varchar(50) NOT NULL,
	PasswordHash varbinary(64) NULL,
	FullName nvarchar(100) NULL,
  CONSTRAINT PK_Users PRIMARY KEY (ID))
GO

CREATE TABLE Posts(
	ID int IDENTITY NOT NULL,
	Title nvarchar(200) NOT NULL,
	Body ntext NOT NULL,
	Date datetime NOT NULL,
	AuthorID int NULL,
  CONSTRAINT PK_Posts PRIMARY KEY (ID))
GO

CREATE TABLE Comments(
	ID int IDENTITY NOT NULL,
	Text nvarchar(max) NOT NULL,
	PostID int NOT NULL,
	AuthorID int NULL,
	AuthorName nvarchar(100) NULL,
	Date datetime NOT NULL,
  CONSTRAINT PK_Comments PRIMARY KEY (ID))
GO

CREATE TABLE Tags(
	ID int IDENTITY NOT NULL,
	Name nvarchar(50) NOT NULL,
  CONSTRAINT PK_Tags PRIMARY KEY (ID))
GO

CREATE TABLE Posts_Tags(
	PostID int NOT NULL,
	TagID int NOT NULL,
  CONSTRAINT PK_Posts_Tags PRIMARY KEY (PostID, TagID))
GO

SET IDENTITY_INSERT Users ON 
GO
INSERT Users (ID, Username, PasswordHash, FullName) VALUES
(1, 'admin', HASHBYTES('SHA2_256', 'P@$$word@123'), NULL),
(2, 'maria', HASHBYTES('SHA2_256', '%merry@@'), 'Maria Petrova'),
(3, 'peter', NULL, 'Peter Petrov')
GO
SET IDENTITY_INSERT Users OFF
GO

SET IDENTITY_INSERT Posts ON 
GO
INSERT Posts (ID, Title, Body, Date, AuthorID) VALUES
(1, 'Java 8', 'Java 8 is the latest Java on the market.', CAST('2016-07-10T15:56:00' AS DateTime), NULL),
(2, 'C# Course', 'A new C# course starts every month at SoftUni', CAST('2016-06-14T12:03:00' AS DateTime), 2),
(4, 'PHP 7', 'Join our PHP 7 webinar to learn about the new features in PHP 7', CAST('2016-05-29T23:51:00' AS DateTime), 1),
(5, 'MySQL and MariaDB', 'Do you know the difference between MySQL and MariaDB?', CAST('2016-04-02T08:06:00' AS DateTime), 1),
(7, 'Java EE Training', 'Welcome to the Java EE training at SoftUni', CAST('2016-05-19T09:55:00' AS DateTime), 3),
(8, 'Java Web', 'Welcome to Java Web development tutorial', CAST('2016-06-14T11:33:00' AS DateTime), 2)
GO
SET IDENTITY_INSERT Posts OFF
GO

SET IDENTITY_INSERT Comments ON
GO
INSERT Comments (ID, Text, PostID, AuthorID, AuthorName, Date) VALUES
(2, 'I like Java 8!', 1, NULL, 'Sahil Jai', CAST('2016-07-11T12:32:56.000' AS DateTime)),
(3, 'Great Java article.', 1, 3, NULL, CAST('2016-06-25T07:03:23.000' AS DateTime)),
(5, 'Can this run on Linux?', 2, NULL, 'Jahil Diab', CAST('2016-07-05T12:51:58.000' AS DateTime)),
(6, 'Try also Spring MVC', 7, 2, NULL, CAST('2016-07-17T11:53:54.000' AS DateTime)),
(8, 'I prefer Spring Framework', 7, NULL, 'Stefa', CAST('2016-07-21T14:16:31.000' AS DateTime))
GO
SET IDENTITY_INSERT Comments OFF
GO

SET IDENTITY_INSERT Tags ON 
GO
INSERT Tags (ID, Name) VALUES
(1, 'C#'),
(2, 'Java'),
(3, 'PHP'),
(4, 'SQL'),
(5, 'databases'),
(6, 'programming'),
(7, 'Web')
GO
SET IDENTITY_INSERT Tags OFF
GO

INSERT Posts_Tags (PostID, TagID) VALUES
(1, 2),
(1, 6),
(2, 1),
(2, 6),
(4, 3),
(4, 6),
(4, 7),
(5, 4),
(5, 5),
(7, 2),
(7, 6),
(8, 2),
(8, 6),
(8, 7)
GO

CREATE UNIQUE INDEX UK_Users_Username ON Users(Username)
GO

ALTER TABLE Comments ADD CONSTRAINT DF_Comments_Date DEFAULT (getdate()) FOR Date
GO

ALTER TABLE Posts ADD CONSTRAINT DF_Posts_Date DEFAULT (getdate()) FOR Date
GO

ALTER TABLE Comments ADD CONSTRAINT FK_Comments_Posts
FOREIGN KEY(PostID) REFERENCES Posts (ID)
GO

ALTER TABLE Comments ADD CONSTRAINT FK_Comments_Users
FOREIGN KEY(AuthorID) REFERENCES Users (ID)
GO

ALTER TABLE Posts ADD CONSTRAINT FK_Posts_Users
FOREIGN KEY(AuthorID) REFERENCES Users (ID)
GO

ALTER TABLE Posts_Tags ADD CONSTRAINT FK_Posts_Tags_Posts
FOREIGN KEY(PostID) REFERENCES Posts (ID)
GO

ALTER TABLE Posts_Tags ADD CONSTRAINT FK_Posts_Tags_Tags
FOREIGN KEY(TagID) REFERENCES Tags (ID)
GO
