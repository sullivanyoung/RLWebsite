CREATE TABLE [dbo].[Player]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [playerID] INT NOT NULL, 
    [playerName] NVARCHAR(50) NOT NULL, 
    [userName] NVARCHAR(50) NOT NULL, 
    [playerBirthDate] DATE NOT NULL, 
    [playerTeam] NVARCHAR(50) NOT NULL, 
    [playerEarnings] INT NOT NULL, 
    [system] NVARCHAR(50) NOT NULL, 
    [timeZone] NVARCHAR(50) NOT NULL, 
    [mmr] INT NOT NULL
)
