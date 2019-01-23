CREATE TABLE [dbo].[OrderStatus] (
    [Id]   INT         NOT NULL,
    [Name] NCHAR (200) NOT NULL,
    CONSTRAINT [PK_OrderStatus] PRIMARY KEY CLUSTERED ([Id] ASC)
);

