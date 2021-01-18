CREATE TABLE [dbo].[Category] (
    [id]   INT           IDENTITY (1, 1) NOT NULL,
    [name] VARCHAR (100) NOT NULL,
    CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED ([id] ASC)
);

