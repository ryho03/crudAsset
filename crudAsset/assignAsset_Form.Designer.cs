namespace crudAsset
{
    partial class assignAsset_Form
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
            this.assignAsset_lbl = new System.Windows.Forms.Label();
            this.assetNum_lbl = new System.Windows.Forms.Label();
            this.assetType_lbl = new System.Windows.Forms.Label();
            this.assetModel_lbl = new System.Windows.Forms.Label();
            this.currentAssignUser_lbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // assignAsset_lbl
            // 
            this.assignAsset_lbl.AutoSize = true;
            this.assignAsset_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignAsset_lbl.Location = new System.Drawing.Point(12, 9);
            this.assignAsset_lbl.Name = "assignAsset_lbl";
            this.assignAsset_lbl.Size = new System.Drawing.Size(175, 32);
            this.assignAsset_lbl.TabIndex = 0;
            this.assignAsset_lbl.Text = "Assign Asset";
            // 
            // assetNum_lbl
            // 
            this.assetNum_lbl.AutoSize = true;
            this.assetNum_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetNum_lbl.Location = new System.Drawing.Point(38, 99);
            this.assetNum_lbl.Name = "assetNum_lbl";
            this.assetNum_lbl.Size = new System.Drawing.Size(119, 21);
            this.assetNum_lbl.TabIndex = 1;
            this.assetNum_lbl.Text = "Asset Number";
            // 
            // assetType_lbl
            // 
            this.assetType_lbl.AutoSize = true;
            this.assetType_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetType_lbl.Location = new System.Drawing.Point(38, 145);
            this.assetType_lbl.Name = "assetType_lbl";
            this.assetType_lbl.Size = new System.Drawing.Size(93, 21);
            this.assetType_lbl.TabIndex = 2;
            this.assetType_lbl.Text = "Asset Type";
            // 
            // assetModel_lbl
            // 
            this.assetModel_lbl.AutoSize = true;
            this.assetModel_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetModel_lbl.Location = new System.Drawing.Point(38, 188);
            this.assetModel_lbl.Name = "assetModel_lbl";
            this.assetModel_lbl.Size = new System.Drawing.Size(105, 21);
            this.assetModel_lbl.TabIndex = 3;
            this.assetModel_lbl.Text = "Asset Model";
            // 
            // currentAssignUser_lbl
            // 
            this.currentAssignUser_lbl.AutoSize = true;
            this.currentAssignUser_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAssignUser_lbl.Location = new System.Drawing.Point(38, 227);
            this.currentAssignUser_lbl.Name = "currentAssignUser_lbl";
            this.currentAssignUser_lbl.Size = new System.Drawing.Size(180, 21);
            this.currentAssignUser_lbl.TabIndex = 4;
            this.currentAssignUser_lbl.Text = "Current Assigned User";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 268);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Assign to New User";
            // 
            // assignAsset_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentAssignUser_lbl);
            this.Controls.Add(this.assetModel_lbl);
            this.Controls.Add(this.assetType_lbl);
            this.Controls.Add(this.assetNum_lbl);
            this.Controls.Add(this.assignAsset_lbl);
            this.Name = "assignAsset_Form";
            this.Text = "allpay Asset Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label assignAsset_lbl;
        private System.Windows.Forms.Label assetNum_lbl;
        private System.Windows.Forms.Label assetType_lbl;
        private System.Windows.Forms.Label assetModel_lbl;
        private System.Windows.Forms.Label currentAssignUser_lbl;
        private System.Windows.Forms.Label label1;
    }
}