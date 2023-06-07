
CREATE PROCEDURE AddToInventory
@itemManufacturer varchar(30),
@itemType varchar(15),
@itemModel varchar(30),
@itemAssetId int

AS

if not exists (select * from modelInventoryTable where itemManufacturer = @itemManufacturer)
	INSERT INTO modelInventoryTable (itemManufacturer) VALUES (@itemManufacturer)

if not exists (select * from modelInventoryTable where itemType = @itemType)
	INSERT INTO modelInventoryTable (itemType) VALUES (@itemType)

if not exists (select * from modelInventoryTable where itemModel = @itemModel)
	INSERT INTO modelInventoryTable (itemModel) VALUES (@itemModel)

if not exists (select * from modelInventoryTable where itemAssetId = @itemAssetId)
	INSERT INTO modelInventoryTable (itemManufacturer, itemType, itemModel, itemAssetId)
	VALUES
	(
	(select itemManufacturer from modelInventoryTable where itemManufacturer=@itemManufacturer),
	(select itemType from modelInventoryTable where itemType=@itemType),
	(select itemModel from modelInventoryTable where itemModel=@itemModel),
	@itemAssetId
	)