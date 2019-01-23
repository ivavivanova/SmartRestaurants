CREATE TABLE [dbo].[MealProduct] (
    [Id]        INT NOT NULL,
    [MealId]    INT NOT NULL,
    [ProductId] INT NOT NULL,
    CONSTRAINT [PK_MealProduct] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_MealProduct_Meal] FOREIGN KEY ([MealId]) REFERENCES [dbo].[Meal] ([Id]),
    CONSTRAINT [FK_MealProduct_Product] FOREIGN KEY ([ProductId]) REFERENCES [dbo].[Product] ([Id])
);

