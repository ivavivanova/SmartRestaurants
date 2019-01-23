CREATE TABLE [dbo].[ReservationTable] (
    [Id]            INT NOT NULL,
    [TableId]       INT NOT NULL,
    [ReservationId] INT NOT NULL,
    CONSTRAINT [PK_ReservationTable] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_ReservationTable_Reservation] FOREIGN KEY ([ReservationId]) REFERENCES [dbo].[Reservation] ([Id]),
    CONSTRAINT [FK_ReservationTable_Table] FOREIGN KEY ([TableId]) REFERENCES [dbo].[Table] ([Id])
);

