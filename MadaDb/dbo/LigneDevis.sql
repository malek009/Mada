CREATE TABLE [dbo].[LigneDevis]
(
	[Id] INT NOT NULL PRIMARY KEY identity(1,1),
	[DevisId] INT NOT NULL,
	[Description] NVARCHAR(MAX) NOT NULL,
	[Price] DECIMAL(18, 2) NOT NULL,

	CONSTRAINT [FK_LigneDevis_Devis] FOREIGN KEY ([DevisId]) REFERENCES [dbo].[Devis] ([Id])
	
)
