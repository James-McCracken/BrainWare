CREATE TABLE [dbo].[Product]
(
	[product_id] INTEGER NOT NULL PRIMARY KEY,
	[name] NVARCHAR(128) NOT NULL, 
    [price] DECIMAL(18, 2) NOT NULL
);