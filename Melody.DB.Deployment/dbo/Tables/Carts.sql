CREATE TABLE [dbo].[Carts] (
    [id]        INT             IDENTITY (1, 1) NOT NULL,
    [productId] INT             NOT NULL,
    [quantity]  INT             NOT NULL,
    [price]     DECIMAL (18, 2) NULL,
    CONSTRAINT [PK_dbo.Carts] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_dbo.Carts_dbo.Products_productId] FOREIGN KEY ([productId]) REFERENCES [dbo].[Products] ([id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_productId]
    ON [dbo].[Carts]([productId] ASC);

