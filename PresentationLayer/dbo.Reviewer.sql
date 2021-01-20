CREATE TABLE [dbo].[Reviewer] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (50) NOT NULL,
    [LastName]    NVARCHAR (50) NOT NULL,
    [Email]       NVARCHAR (50) NOT NULL,
    [Password]    NVARCHAR (50) NOT NULL,
    [Adress]      NVARCHAR (50) NOT NULL,
    [City]        NVARCHAR (50) NOT NULL,
    [PhoneNumber] NVARCHAR (13) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

