IF EXISTS (SELECT name
		FROM sysobjects
		WHERE name = 'AddToInventory'
		AND type = 'P')
	DROP PROCEDURE AddToInventory
GO

CREATE PROCEDURE AddToInventory
	@itemManufacturer varchar = 30,
	@itemType varchar = 15,
	@itemModel varchar = 30,
	@itemAssetId int

AS

if not exists (select * from MANUFACTURER where itemManufacturer = @itemManufacturer)
	INSERT INTO MANUFACTURER (itemManufacturer) VALUES (@itemManufacturer)

if not exists (select * from ITYPE where itemType = @itemType)
	INSERT INTO ITYPE (itemType) VALUES (@itemType)

if not exists (select * from MODEL where itemModel = @itemModel)
	INSERT INTO MODEL (itemModel) VALUES (@itemModel)

if not exists (select * from INVENTORYITEM where itemAssetId = @itemAssetId)
	INSERT INTO INVENTORYITEM (itemManufacturerID, itemTypeID, itemModelID, itemAssetId)
	VALUES
	(
	(select itemManufacturerID from MANUFACTURER where itemManufacturer=@itemManufacturer),
	(select itemTypeID from ITYPE where itemType=@itemType),
	(select itemModelID from MODEL where itemModel=@itemModel),
	@itemAssetId
	)


GO