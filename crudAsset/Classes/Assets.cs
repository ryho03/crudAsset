using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crudAsset
{
    public class Asset
    {
        public int assetID { get; set; }
        public string assetManufacturer { get; set; }
        public string assetType { get; set; }
        public string assetModel { get; set; }
        public string assignedUser { get; set; }

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ryanh\\source\\repos\\crudAsset\\crudAsset\\AssetRegister_db.mdf;Integrated Security=True";

        public List<Asset> GetAssets()
        {
            List<Asset> assetList = new List<Asset>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "select assetID, assetManufacturer, assetType, assetModel, assignedUser from assetRegisterTable";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Asset asset = new Asset();

                    asset.assetID = Convert.ToInt32(dr["Asset ID"]);
                    asset.assetManufacturer = dr["Asset Manufacturer"].ToString();
                    asset.assetType = dr["Asset Type"].ToString();
                    asset.assetModel = dr["Asset Model"].ToString();
                    asset.assignedUser = dr["Assigned User"].ToString();

                    assetList.Add(asset);

                }
            }
            return assetList;
        }


    }

    public class InventoryItem
    {
        public string itemManufacturer { get; set; }
        public string itemType { get; set; }
        public string itemModel { get; set; }
        public string itemAssetId { get; set; }

        string connectionStringATI = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ryanh\\source\\repos\\crudAsset\\crudAsset\\AssetRegister_db.mdf;Integrated Security=True";

        public void AddToInventory(InventoryItem inventoryitem)
        {
            SqlConnection con = new SqlConnection(connectionStringATI);

            SqlCommand cmd = new SqlCommand("AddToInventory", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@itemManufacturer", inventoryitem.itemManufacturer));
            cmd.Parameters.Add(new SqlParameter("@itemType", inventoryitem.itemType));
            cmd.Parameters.Add(new SqlParameter("@itemModel", inventoryitem.itemModel));
            cmd.Parameters.Add(new SqlParameter("@itemAssetId", inventoryitem.itemAssetId));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

}
