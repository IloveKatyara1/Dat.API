CREATE TABLE [dbo].[Products] (
    [Id]          UNIQUEIDENTIFIER CONSTRAINT [DEFAULT_Product_Id] DEFAULT (newid()) NOT NULL,
    [Name]        NVARCHAR (MAX)   NOT NULL,
    [Price]       INT              NOT NULL,
    [LeftItems]   INT              NOT NULL,
    [Description] NVARCHAR (MAX)   NOT NULL,
    [SellerId]    UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Product_Seller] FOREIGN KEY ([SellerId]) REFERENCES [dbo].[Sellers] ([Id])
);

