CREATE TABLE [dbo].[modelInventoryTable] (
    [inventoryId]      INT          IDENTITY (1, 1) NOT NULL,
    [itemManufacturer] VARCHAR (30) NOT NULL,
    [itemType]         VARCHAR (15) NOT NULL,
    [itemModel]        VARCHAR (30) NOT NULL,
    [itemAssetId]      CHAR(5)          NOT NULL,
    [itemAssignedUser] VARCHAR(50) NULL, 
    PRIMARY KEY CLUSTERED ([inventoryId] ASC)
);

