CREATE TABLE [dbo].[Order] (
    [Id]                             INT           NOT NULL,
    [TableId]                        INT           NOT NULL,
    [StatusId]                       INT           NOT NULL,
    [RegistationDate]                DATETIME2 (7) NOT NULL,
    [AdditionalCustomerRequirements] NCHAR (1000)  NULL,
    [FinalPrice]                     DECIMAL (18)  NULL,
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Order_Status] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[OrderStatus] ([Id]),
    CONSTRAINT [FK_Order_Table] FOREIGN KEY ([TableId]) REFERENCES [dbo].[Table] ([Id])
);

