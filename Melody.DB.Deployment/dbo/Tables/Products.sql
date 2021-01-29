CREATE TABLE [dbo].[Products] (
    [id]         INT             IDENTITY (1, 1) NOT NULL,
    [producer]   NVARCHAR (MAX)  NULL,
    [model]      NVARCHAR (MAX)  NULL,
    [detail]     NVARCHAR (MAX)  NULL,
    [price]      DECIMAL (18, 2) NOT NULL,
    [categoryId] INT             NOT NULL,
    CONSTRAINT [PK_dbo.Products] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_dbo.Products_dbo.Categories_categoryId] FOREIGN KEY ([categoryId]) REFERENCES [dbo].[Categories] ([id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_categoryId]
    ON [dbo].[Products]([categoryId] ASC);

