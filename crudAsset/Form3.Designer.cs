namespace crudAsset
{
    partial class retireAsset_Form
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
            this.ra_assetNum_cmb = new System.Windows.Forms.ComboBox();
            this.ra_assetNum_lbl = new System.Windows.Forms.Label();
            this.raBack_btn = new System.Windows.Forms.Button();
            this.ra_cau_txtbx = new System.Windows.Forms.TextBox();
            this.ra_assetModel_txtbx = new System.Windows.Forms.TextBox();
            this.ra_assetType_txtbx = new System.Windows.Forms.TextBox();
            this.ra_currentAssignedUser_lbl = new System.Windows.Forms.Label();
            this.ra_assetModel_lbl = new System.Windows.Forms.Label();
            this.ra_assetType_lbl = new System.Windows.Forms.Label();
            this.retireAsset_lbl = new System.Windows.Forms.Label();
            this.retireAsset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ra_assetNum_cmb
            // 
            this.ra_assetNum_cmb.FormattingEnabled = true;
            this.ra_assetNum_cmb.Location = new System.Drawing.Point(257, 108);
            this.ra_assetNum_cmb.Name = "ra_assetNum_cmb";
            this.ra_assetNum_cmb.Size = new System.Drawing.Size(210, 24);
            this.ra_assetNum_cmb.TabIndex = 0;
            this.ra_assetNum_cmb.SelectedIndexChanged += new System.EventHandler(this.ra_assetNum_cmb_SelectedIndexChanged);
            // 
            // ra_assetNum_lbl
            // 
            this.ra_assetNum_lbl.AutoSize = true;
            this.ra_assetNum_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_assetNum_lbl.Location = new System.Drawing.Point(53, 108);
            this.ra_assetNum_lbl.Name = "ra_assetNum_lbl";
            this.ra_assetNum_lbl.Size = new System.Drawing.Size(119, 21);
            this.ra_assetNum_lbl.TabIndex = 1;
            this.ra_assetNum_lbl.Text = "Asset Number";
            // 
            // raBack_btn
            // 
            this.raBack_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raBack_btn.Location = new System.Drawing.Point(282, 314);
            this.raBack_btn.Name = "raBack_btn";
            this.raBack_btn.Size = new System.Drawing.Size(153, 46);
            this.raBack_btn.TabIndex = 2;
            this.raBack_btn.Text = "Back";
            this.raBack_btn.UseVisualStyleBackColor = true;
            this.raBack_btn.Click += new System.EventHandler(this.raBack_btn_Click);
            // 
            // ra_cau_txtbx
            // 
            this.ra_cau_txtbx.Location = new System.Drawing.Point(257, 223);
            this.ra_cau_txtbx.Name = "ra_cau_txtbx";
            this.ra_cau_txtbx.Size = new System.Drawing.Size(210, 22);
            this.ra_cau_txtbx.TabIndex = 15;
            // 
            // ra_assetModel_txtbx
            // 
            this.ra_assetModel_txtbx.Location = new System.Drawing.Point(257, 184);
            this.ra_assetModel_txtbx.Name = "ra_assetModel_txtbx";
            this.ra_assetModel_txtbx.Size = new System.Drawing.Size(210, 22);
            this.ra_assetModel_txtbx.TabIndex = 14;
            // 
            // ra_assetType_txtbx
            // 
            this.ra_assetType_txtbx.Location = new System.Drawing.Point(257, 146);
            this.ra_assetType_txtbx.Name = "ra_assetType_txtbx";
            this.ra_assetType_txtbx.Size = new System.Drawing.Size(210, 22);
            this.ra_assetType_txtbx.TabIndex = 13;
            // 
            // ra_currentAssignedUser_lbl
            // 
            this.ra_currentAssignedUser_lbl.AutoSize = true;
            this.ra_currentAssignedUser_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_currentAssignedUser_lbl.Location = new System.Drawing.Point(53, 223);
            this.ra_currentAssignedUser_lbl.Name = "ra_currentAssignedUser_lbl";
            this.ra_currentAssignedUser_lbl.Size = new System.Drawing.Size(180, 21);
            this.ra_currentAssignedUser_lbl.TabIndex = 12;
            this.ra_currentAssignedUser_lbl.Text = "Current Assigned User";
            // 
            // ra_assetModel_lbl
            // 
            this.ra_assetModel_lbl.AutoSize = true;
            this.ra_assetModel_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_assetModel_lbl.Location = new System.Drawing.Point(53, 184);
            this.ra_assetModel_lbl.Name = "ra_assetModel_lbl";
            this.ra_assetModel_lbl.Size = new System.Drawing.Size(105, 21);
            this.ra_assetModel_lbl.TabIndex = 11;
            this.ra_assetModel_lbl.Text = "Asset Model";
            // 
            // ra_assetType_lbl
            // 
            this.ra_assetType_lbl.AutoSize = true;
            this.ra_assetType_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_assetType_lbl.Location = new System.Drawing.Point(53, 146);
            this.ra_assetType_lbl.Name = "ra_assetType_lbl";
            this.ra_assetType_lbl.Size = new System.Drawing.Size(93, 21);
            this.ra_assetType_lbl.TabIndex = 10;
            this.ra_assetType_lbl.Text = "Asset Type";
            // 
            // retireAsset_lbl
            // 
            this.retireAsset_lbl.AutoSize = true;
            this.retireAsset_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retireAsset_lbl.Location = new System.Drawing.Point(51, 30);
            this.retireAsset_lbl.Name = "retireAsset_lbl";
            this.retireAsset_lbl.Size = new System.Drawing.Size(164, 32);
            this.retireAsset_lbl.TabIndex = 16;
            this.retireAsset_lbl.Text = "Retire Asset";
            // 
            // retireAsset_btn
            // 
            this.retireAsset_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retireAsset_btn.Location = new System.Drawing.Point(282, 262);
            this.retireAsset_btn.Name = "retireAsset_btn";
            this.retireAsset_btn.Size = new System.Drawing.Size(153, 46);
            this.retireAsset_btn.TabIndex = 17;
            this.retireAsset_btn.Text = "Retire";
            this.retireAsset_btn.UseVisualStyleBackColor = true;
            this.retireAsset_btn.Click += new System.EventHandler(this.retireAsset_btn_Click);
            // 
            // retireAsset_Form
            // 
            this.ClientSize = new System.Drawing.Size(758, 447);
            this.Controls.Add(this.retireAsset_btn);
            this.Controls.Add(this.retireAsset_lbl);
            this.Controls.Add(this.ra_cau_txtbx);
            this.Controls.Add(this.ra_assetModel_txtbx);
            this.Controls.Add(this.ra_assetType_txtbx);
            this.Controls.Add(this.ra_currentAssignedUser_lbl);
            this.Controls.Add(this.ra_assetModel_lbl);
            this.Controls.Add(this.ra_assetType_lbl);
            this.Controls.Add(this.raBack_btn);
            this.Controls.Add(this.ra_assetNum_lbl);
            this.Controls.Add(this.ra_assetNum_cmb);
            this.Name = "retireAsset_Form";
            this.Load += new System.EventHandler(this.retireAsset_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ComboBox ra_assetNum_cmb;
        private System.Windows.Forms.Label ra_assetNum_lbl;
        private System.Windows.Forms.Button raBack_btn;
        private System.Windows.Forms.TextBox ra_cau_txtbx;
        private System.Windows.Forms.TextBox ra_assetModel_txtbx;
        private System.Windows.Forms.TextBox ra_assetType_txtbx;
        private System.Windows.Forms.Label ra_currentAssignedUser_lbl;
        private System.Windows.Forms.Label ra_assetModel_lbl;
        private System.Windows.Forms.Label ra_assetType_lbl;
        private System.Windows.Forms.Label retireAsset_lbl;
        private System.Windows.Forms.Button retireAsset_btn;
    }
}