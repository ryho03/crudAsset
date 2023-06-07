namespace crudAsset
{
    partial class vaa_Form
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
            this.vaaBack_btn = new System.Windows.Forms.Button();
            this.AssetTable_dgv = new System.Windows.Forms.DataGridView();
            this.viewAllAssets_lbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.AssetTable_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // vaaBack_btn
            // 
            this.vaaBack_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaaBack_btn.Location = new System.Drawing.Point(313, 351);
            this.vaaBack_btn.Name = "vaaBack_btn";
            this.vaaBack_btn.Size = new System.Drawing.Size(185, 57);
            this.vaaBack_btn.TabIndex = 0;
            this.vaaBack_btn.Text = "Back";
            this.vaaBack_btn.UseVisualStyleBackColor = true;
            this.vaaBack_btn.Click += new System.EventHandler(this.vaaBack_btn_Click);
            // 
            // AssetTable_dgv
            // 
            this.AssetTable_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssetTable_dgv.Location = new System.Drawing.Point(12, 65);
            this.AssetTable_dgv.Name = "AssetTable_dgv";
            this.AssetTable_dgv.Size = new System.Drawing.Size(776, 280);
            this.AssetTable_dgv.TabIndex = 1;
            // 
            // viewAllAssets_lbl
            // 
            this.viewAllAssets_lbl.AutoSize = true;
            this.viewAllAssets_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewAllAssets_lbl.Location = new System.Drawing.Point(12, 9);
            this.viewAllAssets_lbl.Name = "viewAllAssets_lbl";
            this.viewAllAssets_lbl.Size = new System.Drawing.Size(207, 32);
            this.viewAllAssets_lbl.TabIndex = 2;
            this.viewAllAssets_lbl.Text = "View All Assets";
            // 
            // vaa_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.viewAllAssets_lbl);
            this.Controls.Add(this.AssetTable_dgv);
            this.Controls.Add(this.vaaBack_btn);
            this.Name = "vaa_Form";
            this.Text = "allpay Asset Register";
            ((System.ComponentModel.ISupportInitialize)(this.AssetTable_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vaaBack_btn;
        private System.Windows.Forms.DataGridView AssetTable_dgv;
        private System.Windows.Forms.Label viewAllAssets_lbl;
    }
}