CREATE TABLE [dbo].[Product] (
    [id]         INT             IDENTITY (1, 1) NOT NULL,
    [producer]   VARCHAR (100)   NOT NULL,
    [model]      VARCHAR (100)   NOT NULL,
    [detail]     VARCHAR (MAX)   NOT NULL,
    [price]      DECIMAL (18, 2) NOT NULL,
    [categoryId] INT             NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [FK_Product_Category] FOREIGN KEY ([categoryId]) REFERENCES [dbo].[Category] ([id])
);

