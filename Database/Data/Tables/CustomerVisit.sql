CREATE TABLE [dbo].[CustomerVisit]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [CustomerId] INT NOT NULL, 
    [FirstName] NVARCHAR(50) NOT NULL, 
    [LastName] NVARCHAR(50) NOT NULL, 
    [CardResult] NVARCHAR(50) NOT NULL
)
