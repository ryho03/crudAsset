using System.Drawing;
using System.Windows.Forms;

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
 
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.assetNum_lbl = new System.Windows.Forms.Label();
            this.assetType_lbl = new System.Windows.Forms.Label();
            this.assetModel_lbl = new System.Windows.Forms.Label();
            this.currentAssignedUser_lbl = new System.Windows.Forms.Label();
            this.aaBack_btn = new System.Windows.Forms.Button();
            this.aa_assetType_txtbx = new System.Windows.Forms.TextBox();
            this.aa_assetModel_txtbx = new System.Windows.Forms.TextBox();
            this.aa_cau_txtbx = new System.Windows.Forms.TextBox();
            this.aaUpdate_btn = new System.Windows.Forms.Button();
            this.aa_assetNum_cmb = new System.Windows.Forms.ComboBox();
            this.newAssignedUser_lbl = new System.Windows.Forms.Label();
            this.aa_nau_txtbx = new System.Windows.Forms.TextBox();
            this.assignAsset_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // assetNum_lbl
            // 
            this.assetNum_lbl.AutoSize = true;
            this.assetNum_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetNum_lbl.Location = new System.Drawing.Point(38, 112);
            this.assetNum_lbl.Name = "assetNum_lbl";
            this.assetNum_lbl.Size = new System.Drawing.Size(119, 21);
            this.assetNum_lbl.TabIndex = 1;
            this.assetNum_lbl.Text = "Asset Number";
            // 
            // assetType_lbl
            // 
            this.assetType_lbl.AutoSize = true;
            this.assetType_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetType_lbl.Location = new System.Drawing.Point(38, 150);
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
            // currentAssignedUser_lbl
            // 
            this.currentAssignedUser_lbl.AutoSize = true;
            this.currentAssignedUser_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAssignedUser_lbl.Location = new System.Drawing.Point(38, 227);
            this.currentAssignedUser_lbl.Name = "currentAssignedUser_lbl";
            this.currentAssignedUser_lbl.Size = new System.Drawing.Size(180, 21);
            this.currentAssignedUser_lbl.TabIndex = 4;
            this.currentAssignedUser_lbl.Text = "Current Assigned User";
            // 
            // aaBack_btn
            // 
            this.aaBack_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaBack_btn.Location = new System.Drawing.Point(17, 388);
            this.aaBack_btn.Name = "aaBack_btn";
            this.aaBack_btn.Size = new System.Drawing.Size(174, 50);
            this.aaBack_btn.TabIndex = 5;
            this.aaBack_btn.Text = "Back";
            this.aaBack_btn.UseVisualStyleBackColor = true;
            this.aaBack_btn.Click += new System.EventHandler(this.aaBack_btn_Click);
            // 
            // aa_assetType_txtbx
            // 
            this.aa_assetType_txtbx.Location = new System.Drawing.Point(242, 150);
            this.aa_assetType_txtbx.Name = "aa_assetType_txtbx";
            this.aa_assetType_txtbx.Size = new System.Drawing.Size(210, 22);
            this.aa_assetType_txtbx.TabIndex = 7;
            // 
            // aa_assetModel_txtbx
            // 
            this.aa_assetModel_txtbx.Location = new System.Drawing.Point(242, 188);
            this.aa_assetModel_txtbx.Name = "aa_assetModel_txtbx";
            this.aa_assetModel_txtbx.Size = new System.Drawing.Size(210, 22);
            this.aa_assetModel_txtbx.TabIndex = 8;
            // 
            // aa_cau_txtbx
            // 
            this.aa_cau_txtbx.Location = new System.Drawing.Point(242, 227);
            this.aa_cau_txtbx.Name = "aa_cau_txtbx";
            this.aa_cau_txtbx.Size = new System.Drawing.Size(210, 22);
            this.aa_cau_txtbx.TabIndex = 9;
            // 
            // aaUpdate_btn
            // 
            this.aaUpdate_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaUpdate_btn.Location = new System.Drawing.Point(278, 299);
            this.aaUpdate_btn.Name = "aaUpdate_btn";
            this.aaUpdate_btn.Size = new System.Drawing.Size(128, 78);
            this.aaUpdate_btn.TabIndex = 10;
            this.aaUpdate_btn.Text = "Update Assigned User";
            this.aaUpdate_btn.UseVisualStyleBackColor = true;
            this.aaUpdate_btn.Click += new System.EventHandler(this.aaUpdate_btn_Click);
            // 
            // aa_assetNum_cmb
            // 
            this.aa_assetNum_cmb.FormattingEnabled = true;
            this.aa_assetNum_cmb.Location = new System.Drawing.Point(242, 112);
            this.aa_assetNum_cmb.Name = "aa_assetNum_cmb";
            this.aa_assetNum_cmb.Size = new System.Drawing.Size(210, 24);
            this.aa_assetNum_cmb.TabIndex = 11;
            this.aa_assetNum_cmb.SelectedIndexChanged += new System.EventHandler(this.aa_assetNum_cmb_SelectedIndexChanged);
            // 
            // newAssignedUser_lbl
            // 
            this.newAssignedUser_lbl.AutoSize = true;
            this.newAssignedUser_lbl.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newAssignedUser_lbl.Location = new System.Drawing.Point(38, 264);
            this.newAssignedUser_lbl.Name = "newAssignedUser_lbl";
            this.newAssignedUser_lbl.Size = new System.Drawing.Size(156, 21);
            this.newAssignedUser_lbl.TabIndex = 12;
            this.newAssignedUser_lbl.Text = "New Assigned User";
            // 
            // aa_nau_txtbx
            // 
            this.aa_nau_txtbx.Location = new System.Drawing.Point(242, 264);
            this.aa_nau_txtbx.Name = "aa_nau_txtbx";
            this.aa_nau_txtbx.Size = new System.Drawing.Size(210, 22);
            this.aa_nau_txtbx.TabIndex = 13;
            // 
            // assignAsset_lbl
            // 
            this.assignAsset_lbl.AutoSize = true;
            this.assignAsset_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignAsset_lbl.Location = new System.Drawing.Point(36, 37);
            this.assignAsset_lbl.Name = "assignAsset_lbl";
            this.assignAsset_lbl.Size = new System.Drawing.Size(175, 32);
            this.assignAsset_lbl.TabIndex = 14;
            this.assignAsset_lbl.Text = "Assign Asset";
            // 
            // assignAsset_Form
            // 
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.assignAsset_lbl);
            this.Controls.Add(this.aa_nau_txtbx);
            this.Controls.Add(this.newAssignedUser_lbl);
            this.Controls.Add(this.aa_assetNum_cmb);
            this.Controls.Add(this.aaUpdate_btn);
            this.Controls.Add(this.aa_cau_txtbx);
            this.Controls.Add(this.aa_assetModel_txtbx);
            this.Controls.Add(this.aa_assetType_txtbx);
            this.Controls.Add(this.aaBack_btn);
            this.Controls.Add(this.currentAssignedUser_lbl);
            this.Controls.Add(this.assetModel_lbl);
            this.Controls.Add(this.assetType_lbl);
            this.Controls.Add(this.assetNum_lbl);
            this.Name = "assignAsset_Form";
            this.Text = "allpay Asset Register";
            this.Load += new System.EventHandler(this.assignAsset_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

 
        private System.Windows.Forms.Label assetNum_lbl;
        private System.Windows.Forms.Label assetType_lbl;
        private System.Windows.Forms.Label assetModel_lbl;
        private System.Windows.Forms.Label currentAssignedUser_lbl;


        private Button aaBack_btn;
        private TextBox aa_assetType_txtbx;
        private TextBox aa_assetModel_txtbx;
        private TextBox aa_cau_txtbx;
        private Button aaUpdate_btn;
        private ComboBox aa_assetNum_cmb;
        private Label newAssignedUser_lbl;
        private TextBox aa_nau_txtbx;
        private Label assignAsset_lbl;
    }
}