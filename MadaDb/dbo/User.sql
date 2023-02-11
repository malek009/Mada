CREATE TABLE [dbo].[User]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
    [FirstName] NVARCHAR(100) NOT NULL, 
    [LastName] NVARCHAR(100) NOT NULL, 
    [Email] NVARCHAR(256) NOT NULL, 
    [Password] NVARCHAR(MAX) NOT NULL,
    [Salt] NVARCHAR(MAX) NOT NULL, 
	[Role] NVARCHAR(MAX) NOT NULL,
	[CreatedDate] DATETIME NOT NULL DEFAULT GETDATE(),
	
    Constraint UQ_USER_EMAIL unique (Email)
)
