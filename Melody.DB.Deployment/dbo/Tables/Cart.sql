CREATE TABLE [dbo].[Cart] (
    [id]        INT             IDENTITY (1, 1) NOT NULL,
    [productId] INT             NOT NULL,
    [quantity]  INT             NOT NULL,
    [price]     DECIMAL (18, 2) NOT NULL,
    CONSTRAINT [PK_Cart] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Cart_Product] FOREIGN KEY ([productId]) REFERENCES [dbo].[Product] ([id])
);

