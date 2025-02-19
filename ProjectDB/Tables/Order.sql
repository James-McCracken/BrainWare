﻿CREATE TABLE [dbo].[Order]
(
    [order_id] INTEGER PRIMARY KEY AUTOINCREMENT,
    [description] NVARCHAR(1000) NOT NULL, 
    [company_id] INT NOT NULL, 
    CONSTRAINT [FK_order_to_company] FOREIGN KEY ([company_id]) REFERENCES [Company]([company_id]);
)