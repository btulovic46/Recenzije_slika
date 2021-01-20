CREATE TABLE [dbo].[Review] (
    [Id]         INT            IDENTITY (1, 1) NOT NULL,
    [Comment]    NVARCHAR (250) NOT NULL,
    [Grade]      FLOAT (53)     NOT NULL,
    [ReviewerId] INT            NOT NULL,
    [PictureId]  INT            NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Review_Picture] FOREIGN KEY ([PictureId]) REFERENCES [dbo].[Picture] ([Id]),
    CONSTRAINT [FK_Review_Reviewer] FOREIGN KEY ([ReviewerId]) REFERENCES [dbo].[Reviewer] ([Id])
);