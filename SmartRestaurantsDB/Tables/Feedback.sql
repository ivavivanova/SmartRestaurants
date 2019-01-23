CREATE TABLE [dbo].[Feedback] (
    [Id]               INT           NOT NULL,
    [OrderId]          INT           NOT NULL,
    [RegistrationDate] DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Feedback] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Feedback_Order] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Order] ([Id])
);

