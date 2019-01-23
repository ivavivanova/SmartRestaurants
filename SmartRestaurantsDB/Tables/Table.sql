CREATE TABLE [dbo].[Table] (
    [Id]             INT          NOT NULL,
    [TableNumber]    NCHAR (100)  NOT NULL,
    [Location]       NCHAR (100)  NOT NULL,
    [MaxChairs]      INT          NOT NULL,
    [StatusId]       INT          NOT NULL,
    [RFIDControler]  NCHAR (100)  NULL,
    [TypeId]         INT          NOT NULL,
    [AdditionalInfo] NCHAR (1000) NULL,
    CONSTRAINT [PK_Table] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Table_TableStatus] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[TableStatus] ([Id]),
    CONSTRAINT [FK_Table_TableType] FOREIGN KEY ([TypeId]) REFERENCES [dbo].[TableType] ([Id])
);

