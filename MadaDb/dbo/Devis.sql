CREATE TABLE [dbo].[Devis]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	[UserId] INT NOT NULL,
	[ClientId] INT NOT NULL,
	[vehicleId] INT NOT NULL,
	[Date] DATETIME NOT NULL,
	[Total] FLOAT NOT NULL,
	
	CONSTRAINT [FK_Devis_User] FOREIGN KEY ([UserId]) REFERENCES [dbo].[User] ([Id]),
	CONSTRAINT [FK_Devis_Client] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Client] ([Id]),
	CONSTRAINT [FK_Devis_Vehicle] FOREIGN KEY ([vehicleId]) REFERENCES [dbo].[Vehicle] ([Id])
	
)
