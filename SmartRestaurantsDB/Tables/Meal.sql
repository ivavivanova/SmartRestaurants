CREATE TABLE [dbo].[Meal] (
    [Id]     INT             NOT NULL,
    [Name]   NCHAR (200)     NOT NULL,
    [Price]  DECIMAL (18)    NOT NULL,
    [Image]  VARBINARY (MAX) NULL,
    [Weight] DECIMAL (18)    NOT NULL,
    CONSTRAINT [PK_Meal] PRIMARY KEY CLUSTERED ([Id] ASC)
);

