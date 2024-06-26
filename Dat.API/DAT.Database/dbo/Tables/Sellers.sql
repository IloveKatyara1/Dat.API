﻿CREATE TABLE [dbo].[Sellers] (
    [Id]   UNIQUEIDENTIFIER CONSTRAINT [DEFAULT_Sellers_Id] DEFAULT (newid()) NOT NULL,
    [Name] NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_Sellers] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Seller_Id]
    ON [dbo].[Sellers]([Id] ASC);

