CREATE TABLE [dbo].[Vehicle]
(
	[Id] INT NOT NULL PRIMARY KEY	IDENTITY(1,1),
	[ClientId] INT NOT NULL,
	[brandId] INT NOT NULL,
	[Description] NVARCHAR(MAX) NULL,
	[Year] INT NOT NULL,
	[Vin] NVARCHAR(MAX) NULL,
	
	CONSTRAINT [FK_Vehicle_Client] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Client] ([Id]),
	CONSTRAINT [FK_Vehicle_Brand] FOREIGN KEY ([brandId]) REFERENCES [dbo].[Brand] ([Id])
	
)
