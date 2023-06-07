using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace crudAsset
{
    public partial class retireAsset_Form : Form
    {
        public retireAsset_Form()
        {
            InitializeComponent();

        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ryanh\\source\\repos\\crudAsset\\crudAsset\\AssetRegister_db.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void retireAsset_Form_Load(object sender, EventArgs e)
        {
              
            string sql = "select itemAssetId from modelInventoryTable";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                ra_assetNum_cmb.Items.Add(dr["itemAssetId"]);

            }
            con.Close();
            
        }

        private void raBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            aar_Form myNewForm = new aar_Form();
            myNewForm.Show();
        }

        private void ra_assetNum_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from modelInventoryTable WHERE itemAssetID=@itemAssetId", con);
            cmd.Parameters.AddWithValue("@itemAssetId", ra_assetNum_cmb.Text);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string itemType = dr["itemType"].ToString();
                string itemModel = dr["itemModel"].ToString();
                string itemAssignedUser = dr["itemAssignedUser"].ToString();

                ra_assetType_txtbx.Text = itemType;
                ra_assetModel_txtbx.Text = itemModel;
                ra_cau_txtbx.Text = itemAssignedUser;
            }
            con.Close();
        }

        private void retireAsset_btn_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to retire this asset and remove it from the database?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                RemoveInventoryData();
            }
        }
        void RemoveInventoryData()
        {
            InventoryItem inventoryitem = new InventoryItem();
            inventoryitem.itemAssetId = ra_assetNum_cmb.Text;
            inventoryitem.RemoveFromInventory(inventoryitem);
        }
    }
}
