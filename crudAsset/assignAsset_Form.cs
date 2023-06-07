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
    public partial class assignAsset_Form : Form
    {
        public assignAsset_Form()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\ryanh\\source\\repos\\crudAsset\\crudAsset\\AssetRegister_db.mdf;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        private void aaBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            aar_Form myNewForm = new aar_Form();
            myNewForm.Show();
        }



        private void assignAsset_Form_Load(object sender, EventArgs e)
        {
            string sql = "select itemAssetId from modelInventoryTable";
            cmd = new SqlCommand(sql, con);
            con.Open();
            dr = cmd.ExecuteReader();
            while (dr.Read()) 
            {
                aa_assetNum_cmb.Items.Add(dr["itemAssetId"]);

            }
            con.Close();
        }

        private void aa_assetNum_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("select * from modelInventoryTable WHERE itemAssetID=@itemAssetId", con);
            cmd.Parameters.AddWithValue("@itemAssetId", aa_assetNum_cmb.Text);
            con.Open() ;
            dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                string itemType = dr["itemType"].ToString();
                string itemModel = dr["itemModel"].ToString() ;
                string itemAssignedUser = dr["itemAssignedUser"].ToString();

                aa_assetType_txtbx.Text = itemType;
                aa_assetModel_txtbx.Text= itemModel;
                aa_cau_txtbx.Text = itemAssignedUser;
            }
            con.Close() ;
        }

        private void aaUpdate_btn_Click(object sender, EventArgs e)
        {
            UpdateInventoryData();
        }

        void UpdateInventoryData()
        {
            AssignUser assignuser = new AssignUser();
            assignuser.itemAssignedUser = aa_nau_txtbx.Text;
            assignuser.itemAssetId = aa_assetNum_cmb.Text;

            assignuser.AssignToAsset(assignuser);
        }
    }
   
}
