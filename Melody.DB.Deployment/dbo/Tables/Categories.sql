CREATE TABLE [dbo].[Categories] (
    [id]   INT            IDENTITY (1, 1) NOT NULL,
    [name] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Categories] PRIMARY KEY CLUSTERED ([id] ASC)
);

