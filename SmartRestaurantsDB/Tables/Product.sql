CREATE TABLE [dbo].[Product] (
    [Id]             INT           NOT NULL,
    [Name]           NCHAR (200)   NOT NULL,
    [ProductTypeId]  INT           NOT NULL,
    [Quantity]       INT           NOT NULL,
    [QuantityTypeId] INT           NOT NULL,
    [Аllergen]       BIT           NOT NULL,
    [ExpirationDate] DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Product_ProductType] FOREIGN KEY ([ProductTypeId]) REFERENCES [dbo].[ProductType] ([Id]),
    CONSTRAINT [FK_Product_QuantityType] FOREIGN KEY ([QuantityTypeId]) REFERENCES [dbo].[QuantityType] ([Id])
);

