CREATE TABLE [dbo].[Player] (
    [Id]              INT           IDENTITY (1, 1) NOT NULL,
    [playerID]        INT           NOT NULL,
    [playerName]      NVARCHAR (50) NOT NULL,
    [userName]        NVARCHAR (50) NOT NULL,
    [playerBirthDate] DATE          NOT NULL,
    [playerTeam]      MONEY         NOT NULL,
    [playerEarnings]  INT           NOT NULL,
    [system]          NVARCHAR (50) NOT NULL,
    [timeZone]        NVARCHAR (50) NOT NULL,
    [mmr]             INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);