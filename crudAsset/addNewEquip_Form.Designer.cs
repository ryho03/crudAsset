namespace crudAsset
{
    partial class addNewEquip_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addNewEquip_lbl = new System.Windows.Forms.Label();
            this.itemMake_lbl = new System.Windows.Forms.Label();
            this.itemType_lbl = new System.Windows.Forms.Label();
            this.itemModel_lbl = new System.Windows.Forms.Label();
            this.itemAssetNum_lbl = new System.Windows.Forms.Label();
            this.itemManufacturer_txtbx = new System.Windows.Forms.TextBox();
            this.itemModel_txtbx = new System.Windows.Forms.TextBox();
            this.assetNum_txtbx = new System.Windows.Forms.TextBox();
            this.itemType_txtbx = new System.Windows.Forms.TextBox();
            this.addEquip_btn = new System.Windows.Forms.Button();
            this.aneBack_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addNewEquip_lbl
            // 
            this.addNewEquip_lbl.AutoSize = true;
            this.addNewEquip_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewEquip_lbl.Location = new System.Drawing.Point(12, 9);
            this.addNewEquip_lbl.Name = "addNewEquip_lbl";
            this.addNewEquip_lbl.Size = new System.Drawing.Size(283, 32);
            this.addNewEquip_lbl.TabIndex = 0;
            this.addNewEquip_lbl.Text = "Add New Equipment";
            // 
            // itemMake_lbl
            // 
            this.itemMake_lbl.AutoSize = true;
            this.itemMake_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemMake_lbl.Location = new System.Drawing.Point(38, 87);
            this.itemMake_lbl.Name = "itemMake_lbl";
            this.itemMake_lbl.Size = new System.Drawing.Size(160, 21);
            this.itemMake_lbl.TabIndex = 1;
            this.itemMake_lbl.Text = "Item Manufacturer";
            // 
            // itemType_lbl
            // 
            this.itemType_lbl.AutoSize = true;
            this.itemType_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemType_lbl.Location = new System.Drawing.Point(38, 121);
            this.itemType_lbl.Name = "itemType_lbl";
            this.itemType_lbl.Size = new System.Drawing.Size(88, 21);
            this.itemType_lbl.TabIndex = 2;
            this.itemType_lbl.Text = "Item Type";
            // 
            // itemModel_lbl
            // 
            this.itemModel_lbl.AutoSize = true;
            this.itemModel_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemModel_lbl.Location = new System.Drawing.Point(38, 156);
            this.itemModel_lbl.Name = "itemModel_lbl";
            this.itemModel_lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemModel_lbl.Size = new System.Drawing.Size(100, 21);
            this.itemModel_lbl.TabIndex = 3;
            this.itemModel_lbl.Text = "Item Model";
            // 
            // itemAssetNum_lbl
            // 
            this.itemAssetNum_lbl.AutoSize = true;
            this.itemAssetNum_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemAssetNum_lbl.Location = new System.Drawing.Point(38, 192);
            this.itemAssetNum_lbl.Name = "itemAssetNum_lbl";
            this.itemAssetNum_lbl.Size = new System.Drawing.Size(119, 21);
            this.itemAssetNum_lbl.TabIndex = 4;
            this.itemAssetNum_lbl.Text = "Asset Number";
            // 
            // itemManufacturer_txtbx
            // 
            this.itemManufacturer_txtbx.Location = new System.Drawing.Point(206, 87);
            this.itemManufacturer_txtbx.Name = "itemManufacturer_txtbx";
            this.itemManufacturer_txtbx.Size = new System.Drawing.Size(200, 20);
            this.itemManufacturer_txtbx.TabIndex = 5;
            // 
            // itemModel_txtbx
            // 
            this.itemModel_txtbx.Location = new System.Drawing.Point(206, 156);
            this.itemModel_txtbx.Name = "itemModel_txtbx";
            this.itemModel_txtbx.Size = new System.Drawing.Size(200, 20);
            this.itemModel_txtbx.TabIndex = 6;
            // 
            // assetNum_txtbx
            // 
            this.assetNum_txtbx.Location = new System.Drawing.Point(206, 192);
            this.assetNum_txtbx.Name = "assetNum_txtbx";
            this.assetNum_txtbx.Size = new System.Drawing.Size(200, 20);
            this.assetNum_txtbx.TabIndex = 7;
            // 
            // itemType_txtbx
            // 
            this.itemType_txtbx.Location = new System.Drawing.Point(206, 121);
            this.itemType_txtbx.Name = "itemType_txtbx";
            this.itemType_txtbx.Size = new System.Drawing.Size(200, 20);
            this.itemType_txtbx.TabIndex = 8;
            // 
            // addEquip_btn
            // 
            this.addEquip_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEquip_btn.Location = new System.Drawing.Point(206, 245);
            this.addEquip_btn.Name = "addEquip_btn";
            this.addEquip_btn.Size = new System.Drawing.Size(200, 57);
            this.addEquip_btn.TabIndex = 9;
            this.addEquip_btn.Text = "Add Asset";
            this.addEquip_btn.UseVisualStyleBackColor = true;
            this.addEquip_btn.Click += new System.EventHandler(this.addEquip_btn_Click);
            // 
            // aneBack_btn
            // 
            this.aneBack_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aneBack_btn.Location = new System.Drawing.Point(12, 381);
            this.aneBack_btn.Name = "aneBack_btn";
            this.aneBack_btn.Size = new System.Drawing.Size(185, 57);
            this.aneBack_btn.TabIndex = 10;
            this.aneBack_btn.Text = "Back";
            this.aneBack_btn.UseVisualStyleBackColor = true;
            this.aneBack_btn.Click += new System.EventHandler(this.aneBack_btn_Click);
            // 
            // addNewEquip_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aneBack_btn);
            this.Controls.Add(this.addEquip_btn);
            this.Controls.Add(this.itemType_txtbx);
            this.Controls.Add(this.assetNum_txtbx);
            this.Controls.Add(this.itemModel_txtbx);
            this.Controls.Add(this.itemManufacturer_txtbx);
            this.Controls.Add(this.itemAssetNum_lbl);
            this.Controls.Add(this.itemModel_lbl);
            this.Controls.Add(this.itemType_lbl);
            this.Controls.Add(this.itemMake_lbl);
            this.Controls.Add(this.addNewEquip_lbl);
            this.Name = "addNewEquip_Form";
            this.Text = "allpay Asset Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addNewEquip_lbl;
        private System.Windows.Forms.Label itemMake_lbl;
        private System.Windows.Forms.Label itemType_lbl;
        private System.Windows.Forms.Label itemModel_lbl;
        private System.Windows.Forms.Label itemAssetNum_lbl;
        private System.Windows.Forms.TextBox itemManufacturer_txtbx;
        private System.Windows.Forms.TextBox itemModel_txtbx;
        private System.Windows.Forms.TextBox assetNum_txtbx;
        private System.Windows.Forms.TextBox itemType_txtbx;
        private System.Windows.Forms.Button addEquip_btn;
        private System.Windows.Forms.Button aneBack_btn;
    }
}