using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace crudAsset
{
    public partial class addNewEquip_Form : Form
    {
        public addNewEquip_Form()
        {
            InitializeComponent();
        }

        private void aneBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            aar_Form myNewForm = new aar_Form();
            myNewForm.Show();
        }

        private void addEquip_btn_Click(object sender, EventArgs e)
        {
            SaveInventoryData();
        }

        void SaveInventoryData()
        {
            InventoryItem inventoryitem = new InventoryItem();
            inventoryitem.itemManufacturer = itemManufacturer_txtbx.Text;
            inventoryitem.itemType = itemType_txtbx.Text;
            inventoryitem.itemModel = itemModel_txtbx.Text;
            inventoryitem.itemAssetId = assetNum_txtbx.Text;

            inventoryitem.AddToInventory(inventoryitem);
        }
    }
}
