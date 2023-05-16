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
    public partial class vaa_Form: Form
    {
        public vaa_Form()
        {
            InitializeComponent();
            fillGridView();
        }

        void fillGridView()
        {
           List<Asset> assetList = new List<Asset>();

           Asset asset = new Asset();

           assetList = asset.GetAssets();

           AssetTable_dgv.DataSource = assetList;
        }
        private void vaaBack_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            aar_Form myNewForm = new aar_Form();
            myNewForm.Show();
        }
    }
}
