CREATE TABLE [dbo].[Locations] (
    [ID]                  INT             IDENTITY (1, 1) NOT NULL,
	[UserID]			  NVARCHAR (450)  NOT NULL,
    [LocationName]        NVARCHAR (MAX)  NOT NULL,
    [LocationDescription] NVARCHAR (MAX)  NOT NULL,
    [LocationType]        NVARCHAR (MAX)  NOT NULL,
    [Latitiude]           DECIMAL (9, 6)  NOT NULL,
    [Longitude]           DECIMAL (9, 6)  NOT NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_dbo.Locations_dbo.AspNetUsers_Id] FOREIGN KEY ([UserID]) 
        REFERENCES [dbo].[AspNetUsers] ([Id]) ON DELETE CASCADE,
);

