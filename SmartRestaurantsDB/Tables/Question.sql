CREATE TABLE [dbo].[Question] (
    [Id]          INT         NOT NULL,
    [Description] NCHAR (200) NOT NULL,
    CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED ([Id] ASC)
);

