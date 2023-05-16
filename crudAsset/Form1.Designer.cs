namespace crudAsset
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.addAsset_pnl = new System.Windows.Forms.Panel();
            this.addAssetUpload_btn = new System.Windows.Forms.Button();
            this.addAssignUser_combox = new System.Windows.Forms.ComboBox();
            this.userTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetRegister_dbDataSet = new crudAsset.AssetRegister_dbDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.addAssetMod_combox = new System.Windows.Forms.ComboBox();
            this.modelInventoryTableBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.assetRegister_dbDataSet1 = new crudAsset.AssetRegister_dbDataSet1();
            this.label5 = new System.Windows.Forms.Label();
            this.addAssetBack_btn = new System.Windows.Forms.Button();
            this.addAssetType_combox = new System.Windows.Forms.ComboBox();
            this.modelInventoryTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.addAssetNum_txtbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.vaa_btn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addAsset_btn = new System.Windows.Forms.Button();
            this.userTableTableAdapter = new crudAsset.AssetRegister_dbDataSetTableAdapters.userTableTableAdapter();
            this.assetRegisterdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.modelInventoryTableTableAdapter = new crudAsset.AssetRegister_dbDataSet1TableAdapters.modelInventoryTableTableAdapter();
            this.exitApp_btn = new System.Windows.Forms.Button();
            this.ane_btn = new System.Windows.Forms.Button();
            this.addAsset_pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegister_dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelInventoryTableBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegister_dbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelInventoryTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegisterdbDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "allpay Asset Register";
            // 
            // addAsset_pnl
            // 
            this.addAsset_pnl.Controls.Add(this.addAssetUpload_btn);
            this.addAsset_pnl.Controls.Add(this.addAssignUser_combox);
            this.addAsset_pnl.Controls.Add(this.label6);
            this.addAsset_pnl.Controls.Add(this.addAssetMod_combox);
            this.addAsset_pnl.Controls.Add(this.label5);
            this.addAsset_pnl.Controls.Add(this.addAssetBack_btn);
            this.addAsset_pnl.Controls.Add(this.addAssetType_combox);
            this.addAsset_pnl.Controls.Add(this.label4);
            this.addAsset_pnl.Controls.Add(this.addAssetNum_txtbx);
            this.addAsset_pnl.Controls.Add(this.label3);
            this.addAsset_pnl.Controls.Add(this.label2);
            this.addAsset_pnl.Location = new System.Drawing.Point(-2, -7);
            this.addAsset_pnl.Name = "addAsset_pnl";
            this.addAsset_pnl.Size = new System.Drawing.Size(800, 459);
            this.addAsset_pnl.TabIndex = 5;
            this.addAsset_pnl.Visible = false;
            // 
            // addAssetUpload_btn
            // 
            this.addAssetUpload_btn.Location = new System.Drawing.Point(514, 140);
            this.addAssetUpload_btn.Name = "addAssetUpload_btn";
            this.addAssetUpload_btn.Size = new System.Drawing.Size(149, 59);
            this.addAssetUpload_btn.TabIndex = 16;
            this.addAssetUpload_btn.Text = "Add Asset";
            this.addAssetUpload_btn.UseVisualStyleBackColor = true;
            this.addAssetUpload_btn.Click += new System.EventHandler(this.button4_Click);
            // 
            // addAssignUser_combox
            // 
            this.addAssignUser_combox.BackColor = System.Drawing.SystemColors.Window;
            this.addAssignUser_combox.DataSource = this.userTableBindingSource;
            this.addAssignUser_combox.DisplayMember = "userName";
            this.addAssignUser_combox.FormattingEnabled = true;
            this.addAssignUser_combox.Location = new System.Drawing.Point(124, 213);
            this.addAssignUser_combox.Name = "addAssignUser_combox";
            this.addAssignUser_combox.Size = new System.Drawing.Size(245, 21);
            this.addAssignUser_combox.TabIndex = 15;
            this.addAssignUser_combox.ValueMember = "userName";
            // 
            // userTableBindingSource
            // 
            this.userTableBindingSource.DataMember = "userTable";
            this.userTableBindingSource.DataSource = this.assetRegister_dbDataSet;
            // 
            // assetRegister_dbDataSet
            // 
            this.assetRegister_dbDataSet.DataSetName = "AssetRegister_dbDataSet";
            this.assetRegister_dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Assigned User";
            // 
            // addAssetMod_combox
            // 
            this.addAssetMod_combox.DataSource = this.modelInventoryTableBindingSource1;
            this.addAssetMod_combox.DisplayMember = "itemModel";
            this.addAssetMod_combox.FormattingEnabled = true;
            this.addAssetMod_combox.Location = new System.Drawing.Point(124, 178);
            this.addAssetMod_combox.Name = "addAssetMod_combox";
            this.addAssetMod_combox.Size = new System.Drawing.Size(245, 21);
            this.addAssetMod_combox.TabIndex = 13;
            this.addAssetMod_combox.ValueMember = "itemModel";
            // 
            // modelInventoryTableBindingSource1
            // 
            this.modelInventoryTableBindingSource1.DataMember = "modelInventoryTable";
            this.modelInventoryTableBindingSource1.DataSource = this.assetRegister_dbDataSet1;
            // 
            // assetRegister_dbDataSet1
            // 
            this.assetRegister_dbDataSet1.DataSetName = "AssetRegister_dbDataSet1";
            this.assetRegister_dbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Asset Model";
            // 
            // addAssetBack_btn
            // 
            this.addAssetBack_btn.Location = new System.Drawing.Point(124, 259);
            this.addAssetBack_btn.Name = "addAssetBack_btn";
            this.addAssetBack_btn.Size = new System.Drawing.Size(245, 42);
            this.addAssetBack_btn.TabIndex = 11;
            this.addAssetBack_btn.Text = "Back";
            this.addAssetBack_btn.UseVisualStyleBackColor = true;
            this.addAssetBack_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // addAssetType_combox
            // 
            this.addAssetType_combox.DataSource = this.modelInventoryTableBindingSource;
            this.addAssetType_combox.DisplayMember = "itemType";
            this.addAssetType_combox.FormattingEnabled = true;
            this.addAssetType_combox.Location = new System.Drawing.Point(124, 140);
            this.addAssetType_combox.Name = "addAssetType_combox";
            this.addAssetType_combox.Size = new System.Drawing.Size(245, 21);
            this.addAssetType_combox.TabIndex = 10;
            this.addAssetType_combox.ValueMember = "itemType";
            // 
            // modelInventoryTableBindingSource
            // 
            this.modelInventoryTableBindingSource.DataMember = "modelInventoryTable";
            this.modelInventoryTableBindingSource.DataSource = this.assetRegister_dbDataSet1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Asset Type";
            // 
            // addAssetNum_txtbx
            // 
            this.addAssetNum_txtbx.Location = new System.Drawing.Point(124, 104);
            this.addAssetNum_txtbx.Name = "addAssetNum_txtbx";
            this.addAssetNum_txtbx.Size = new System.Drawing.Size(245, 20);
            this.addAssetNum_txtbx.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Asset Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Add Asset";
            // 
            // vaa_btn
            // 
            this.vaa_btn.Location = new System.Drawing.Point(295, 229);
            this.vaa_btn.Name = "vaa_btn";
            this.vaa_btn.Size = new System.Drawing.Size(146, 40);
            this.vaa_btn.TabIndex = 8;
            this.vaa_btn.Text = "View All Assets";
            this.vaa_btn.UseVisualStyleBackColor = true;
            this.vaa_btn.Click += new System.EventHandler(this.vaa_btn_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(295, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Remove Asset";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addAsset_btn
            // 
            this.addAsset_btn.Location = new System.Drawing.Point(295, 137);
            this.addAsset_btn.Name = "addAsset_btn";
            this.addAsset_btn.Size = new System.Drawing.Size(146, 40);
            this.addAsset_btn.TabIndex = 6;
            this.addAsset_btn.Text = "Add Asset";
            this.addAsset_btn.UseVisualStyleBackColor = true;
            this.addAsset_btn.Click += new System.EventHandler(this.addAsset_btn_Click_1);
            // 
            // userTableTableAdapter
            // 
            this.userTableTableAdapter.ClearBeforeFill = true;
            // 
            // assetRegisterdbDataSetBindingSource
            // 
            this.assetRegisterdbDataSetBindingSource.DataSource = this.assetRegister_dbDataSet;
            this.assetRegisterdbDataSetBindingSource.Position = 0;
            // 
            // modelInventoryTableTableAdapter
            // 
            this.modelInventoryTableTableAdapter.ClearBeforeFill = true;
            // 
            // exitApp_btn
            // 
            this.exitApp_btn.Location = new System.Drawing.Point(327, 228);
            this.exitApp_btn.Name = "exitApp_btn";
            this.exitApp_btn.Size = new System.Drawing.Size(146, 40);
            this.exitApp_btn.TabIndex = 20;
            this.exitApp_btn.Text = "Exit";
            this.exitApp_btn.UseVisualStyleBackColor = true;
            // 
            // ane_btn
            // 
            this.ane_btn.Location = new System.Drawing.Point(327, 182);
            this.ane_btn.Name = "ane_btn";
            this.ane_btn.Size = new System.Drawing.Size(146, 40);
            this.ane_btn.TabIndex = 21;
            this.ane_btn.Text = "Add New Equipment";
            this.ane_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitApp_btn);
            this.Controls.Add(this.ane_btn);
            this.Controls.Add(this.addAsset_pnl);
            this.Controls.Add(this.vaa_btn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addAsset_btn);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "allpay Asset Register";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.addAsset_pnl.ResumeLayout(false);
            this.addAsset_pnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegister_dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelInventoryTableBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegister_dbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelInventoryTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetRegisterdbDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel addAsset_pnl;
        private System.Windows.Forms.ComboBox addAssetType_combox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addAssetNum_txtbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button vaa_btn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addAsset_btn;
        private System.Windows.Forms.Button addAssetBack_btn;
        private System.Windows.Forms.ComboBox addAssetMod_combox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addAssetUpload_btn;
        private System.Windows.Forms.ComboBox addAssignUser_combox;
        private System.Windows.Forms.Label label6;
        private AssetRegister_dbDataSet assetRegister_dbDataSet;
        private System.Windows.Forms.BindingSource userTableBindingSource;
        private AssetRegister_dbDataSetTableAdapters.userTableTableAdapter userTableTableAdapter;
        private System.Windows.Forms.BindingSource assetRegisterdbDataSetBindingSource;
        private AssetRegister_dbDataSet1 assetRegister_dbDataSet1;
        private System.Windows.Forms.BindingSource modelInventoryTableBindingSource;
        private AssetRegister_dbDataSet1TableAdapters.modelInventoryTableTableAdapter modelInventoryTableTableAdapter;
        private System.Windows.Forms.BindingSource modelInventoryTableBindingSource1;
        private System.Windows.Forms.Button exitApp_btn;
        private System.Windows.Forms.Button ane_btn;
    }
}

