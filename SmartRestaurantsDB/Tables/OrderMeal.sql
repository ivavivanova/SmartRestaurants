CREATE TABLE [dbo].[OrderMeal] (
    [Id]          INT NOT NULL,
    [OrderId]     INT NOT NULL,
    [MealId]      INT NOT NULL,
    [NumberMeals] INT NOT NULL,
    CONSTRAINT [PK_OrderMeal] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_OrderMeal_Meal] FOREIGN KEY ([MealId]) REFERENCES [dbo].[Meal] ([Id]),
    CONSTRAINT [FK_OrderMeal_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([Id])
);

