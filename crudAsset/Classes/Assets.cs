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
        public string itemAssetID { get; set; }
        public string itemManufacturer { get; set; }
        public string itemType { get; set; }
        public string itemModel { get; set; }
        public string itemAssignedUser { get; set; }

        string connectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ryanh\\source\\repos\\crudAsset\\crudAsset\\AssetRegister_db.mdf;Integrated Security=True";

        public List<Asset> GetAssets()
        {
            List<Asset> assetList = new List<Asset>();

            SqlConnection con = new SqlConnection(connectionString);

            string selectSQL = "select itemAssetID, itemManufacturer, itemType, itemModel, itemAssignedUser from modelInventoryTable";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSQL, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Asset asset = new Asset();

                    asset.itemAssetID = dr["itemAssetID"].ToString();
                    asset.itemManufacturer = dr["itemManufacturer"].ToString();
                    asset.itemType = dr["itemType"].ToString();
                    asset.itemModel = dr["itemModel"].ToString();
                    asset.itemAssignedUser = dr["itemAssignedUser"].ToString();

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
        public string itemAssignedUser { get; set; }


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

        public void RemoveFromInventory(InventoryItem inventoryitem)
        {
            SqlConnection con = new SqlConnection(connectionStringATI);

            SqlCommand cmd = new SqlCommand("RemoveFromInventory", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

//            cmd.Parameters.Add(new SqlParameter("@itemManufacturer", inventoryitem.itemManufacturer));
//            cmd.Parameters.Add(new SqlParameter("@itemType", inventoryitem.itemType));
//            cmd.Parameters.Add(new SqlParameter("@itemModel", inventoryitem.itemModel));
            cmd.Parameters.Add(new SqlParameter("@itemAssetId", inventoryitem.itemAssetId));
//            cmd.Parameters.Add(new SqlParameter("@itemAssignedUser", inventoryitem.itemAssignedUser));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

    public class AssignUser
    { 
        
        public string itemAssignedUser { get; set;}
        public string itemAssetId  { get; set;}

        string connectionStringAI = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ryanh\\source\\repos\\crudAsset\\crudAsset\\AssetRegister_db.mdf;Integrated Security=True";

        public void AssignToAsset(AssignUser assignuser)
        {
            SqlConnection con = new SqlConnection(connectionStringAI);

            SqlCommand cmd = new SqlCommand("UpdateInventory", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.Add(new SqlParameter("@itemAssignedUser", assignuser.itemAssignedUser));
            cmd.Parameters.Add(new SqlParameter("@itemAssetId", assignuser.itemAssetId));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }





    }
}