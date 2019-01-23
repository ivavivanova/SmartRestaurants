CREATE TABLE [dbo].[Reservation] (
    [Id]                  INT           NOT NULL,
    [CustomerEmail]       NCHAR (200)   NOT NULL,
    [CustomerPhoneNumber] NCHAR (20)    NOT NULL,
    [ChairsNeeded]        INT           NOT NULL,
    [ReservationDate]     DATETIME2 (7) NOT NULL,
    [ReservationTime]     DATETIME2 (7) NOT NULL,
    [StatusId]            INT           NOT NULL,
    [RegistrationDate]    DATETIME2 (7) NOT NULL,
    CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Reservation_Status] FOREIGN KEY ([StatusId]) REFERENCES [dbo].[ReservationStatus] ([Id])
);

