CREATE TABLE [dbo].[DataToOrders] (
    [id]             INT            IDENTITY (1, 1) NOT NULL,
    [name]           NVARCHAR (MAX) NULL,
    [surname]        NVARCHAR (MAX) NULL,
    [email]          NVARCHAR (MAX) NULL,
    [phoneNumber]    NVARCHAR (MAX) NULL,
    [street]         NVARCHAR (MAX) NULL,
    [hoseNumber]     NVARCHAR (MAX) NULL,
    [postalCode]     NVARCHAR (MAX) NULL,
    [city]           NVARCHAR (MAX) NULL,
    [country]        NVARCHAR (MAX) NULL,
    [messageToOrder] NVARCHAR (MAX) NULL,
    [cartId]         INT            NOT NULL,
    CONSTRAINT [PK_dbo.DataToOrders] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_dbo.DataToOrders_dbo.Carts_cartId] FOREIGN KEY ([cartId]) REFERENCES [dbo].[Carts] ([id]) ON DELETE CASCADE
);


GO
CREATE NONCLUSTERED INDEX [IX_cartId]
    ON [dbo].[DataToOrders]([cartId] ASC);

