CREATE TABLE [dbo].[FeedbackQuestionAnswer] (
    [Id]         INT NOT NULL,
    [FeedbackId] INT NOT NULL,
    [QuestionId] INT NOT NULL,
    [AnswerId]   INT NOT NULL,
    CONSTRAINT [PK_FeedbackQuestionAnswer] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_FeedbackQuestionAnswer_Answer] FOREIGN KEY ([AnswerId]) REFERENCES [dbo].[Answer] ([Id]),
    CONSTRAINT [FK_FeedbackQuestionAnswer_Feedback] FOREIGN KEY ([FeedbackId]) REFERENCES [dbo].[Feedback] ([Id]),
    CONSTRAINT [FK_FeedbackQuestionAnswer_Question] FOREIGN KEY ([QuestionId]) REFERENCES [dbo].[Question] ([Id])
);

