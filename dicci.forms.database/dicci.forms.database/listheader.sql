CREATE TABLE [dbo].[listheader]
(
	[ID] INT IDENTITY NOT NULL PRIMARY KEY, 
    [guid] UNIQUEIDENTIFIER NULL, 
    [status] SMALLINT NOT NULL DEFAULT 1, 
    [name] NCHAR(50) NOT NULL, 
    [type] NCHAR(100) NOT NULL
)
