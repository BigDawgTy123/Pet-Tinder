CREATE TABLE [dbo].[Doggos]
(
	[Email] VARCHAR(50) NOT NULL , 
    [Name] VARCHAR(50) NOT NULL, 
    [Breed] VARCHAR(50) NULL, 
    [Weight] VARCHAR(50) NULL, 
    [Gender] VARCHAR(50) NULL, 
    [Personality] VARCHAR(50) NULL, 
    [Playfulness] VARCHAR(50) NULL, 
    [Shedding] VARCHAR(50) NULL, 
    [Age] VARCHAR(50) NULL, 
    PRIMARY KEY ([Email],[Name])
)
