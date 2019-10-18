﻿CREATE TABLE [dbo].[User]
(
	[Id] NVARCHAR(128) NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [Lastname] NVARCHAR(50) NOT NULL, 
    [EmailAdress] NVARCHAR(256) NOT NULL, 
    [CreateDate] DATETIME2 NOT NULL DEFAULT getutcdate()
)
