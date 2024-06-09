CREATE TABLE [dbo].[Product] (
    [Id]          UNIQUEIDENTIFIER CONSTRAINT [DEFAULT_Product_Id] DEFAULT (newid()) NOT NULL,
    [Name]        NVARCHAR (MAX)   NOT NULL,
    [Price]       INT              NOT NULL,
    [LeftItems]   INT              NOT NULL,
    [Description] NVARCHAR (MAX)   NOT NULL,
    CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED ([Id] ASC)
);


GO
CREATE NONCLUSTERED INDEX [IX_Product_Id]
    ON [dbo].[Product]([Id] ASC);

