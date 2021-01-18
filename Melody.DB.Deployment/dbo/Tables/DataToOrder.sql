CREATE TABLE [dbo].[DataToOrder] (
    [id]             INT           IDENTITY (1, 1) NOT NULL,
    [name]           VARCHAR (100) NOT NULL,
    [surname]        VARCHAR (100) NOT NULL,
    [email]          VARCHAR (100) NOT NULL,
    [phoneNumber]    VARCHAR (100) NOT NULL,
    [street]         VARCHAR (100) NOT NULL,
    [hoseNumber]     VARCHAR (10)  NOT NULL,
    [postalCode]     VARCHAR (10)  NOT NULL,
    [city]           VARCHAR (100) NOT NULL,
    [country]        VARCHAR (100) NOT NULL,
    [messageToOrder] VARCHAR (MAX) NOT NULL,
    [cartId]         INT           NOT NULL,
    CONSTRAINT [PK_DataToOrder] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_DataToOrder_Cart] FOREIGN KEY ([cartId]) REFERENCES [dbo].[Cart] ([id])
);

