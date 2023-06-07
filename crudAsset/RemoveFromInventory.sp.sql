
CREATE PROCEDURE RemoveFromInventory
@itemAssetId char(5),
@itemAssignedUser varchar(50),
@itemManufacturer varchar(30),
@itemType varchar(15),
@itemModel varchar(30)
AS

BEGIN
	DELETE modelInventoryTable  WHERE itemAssetId = @itemAssetId
END
