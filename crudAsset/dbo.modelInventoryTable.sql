CREATE TABLE [dbo].[modelInventoryTable] (
    [inventoryId]      INT          NOT NULL IDENTITY (1,1),
    [itemManufacturer] VARCHAR (30) NOT NULL,
    [itemType]         VARCHAR (15) NOT NULL,
    [itemModel]        VARCHAR (30)   NOT NULL,
    [itemAssetId]      INT          NULL,
    PRIMARY KEY CLUSTERED ([inventoryId] ASC)
);

