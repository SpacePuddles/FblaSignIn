CREATE DATABASE FBLA
GO

USE FBLA
GO

CREATE TABLE DBO.[Events]
	(ID INT IDENTITY(1, 1) PRIMARY KEY,
	 [Event Name] NVARCHAR(40) NOT NULL,
	 [Event Desc] NVARCHAR(500) NULL)
GO

CREATE TABLE DBO.Teams
	(ID INT IDENTITY(1, 1) PRIMARY KEY) -- Maybe make more better table later
GO

CREATE TABLE DBO.Users -- Make table better. Later.
	(ID INT IDENTITY(1, 1) PRIMARY KEY,
	 [First Name] VARCHAR(30) NOT NULL,
	 [Last Name] VARCHAR(30) NOT NULL,
	 [Student ID] NVARCHAR(20) NOT NULL,
	 Grade INT NOT NULL,
	 [FBLA ID] NVARCHAR(10) NULL,
	 [Team IDs] VARCHAR(50) NULL, -- Possibly make a better storing method.
	 [Event IDs] VARCHAR(50) NULL) -- Same here.
GO

CREATE TABLE DBO.Admins
	(ID INT IDENTITY(1, 1) PRIMARY KEY,
	 username NVARCHAR(30) NOT NULL,
	 [password] NVARCHAR(900) NOT NULL)
GO

