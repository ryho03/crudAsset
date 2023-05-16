namespace crudAsset
{
    partial class aar_Form
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
            this.aarExit_btn = new System.Windows.Forms.Button();
            this.ane_btn = new System.Windows.Forms.Button();
            this.ra_btn = new System.Windows.Forms.Button();
            this.aa_btn = new System.Windows.Forms.Button();
            this.vaa_btn = new System.Windows.Forms.Button();
            this.allpayAssetRegister_lbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aarExit_btn
            // 
            this.aarExit_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aarExit_btn.Location = new System.Drawing.Point(313, 351);
            this.aarExit_btn.Name = "aarExit_btn";
            this.aarExit_btn.Size = new System.Drawing.Size(185, 57);
            this.aarExit_btn.TabIndex = 11;
            this.aarExit_btn.Text = "Exit";
            this.aarExit_btn.UseVisualStyleBackColor = true;
            this.aarExit_btn.Click += new System.EventHandler(this.aarExit_btn_Click);
            // 
            // ane_btn
            // 
            this.ane_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ane_btn.Location = new System.Drawing.Point(313, 288);
            this.ane_btn.Name = "ane_btn";
            this.ane_btn.Size = new System.Drawing.Size(185, 57);
            this.ane_btn.TabIndex = 10;
            this.ane_btn.Text = "Add New Equipment";
            this.ane_btn.UseVisualStyleBackColor = true;
            this.ane_btn.Click += new System.EventHandler(this.ane_btn_Click);
            // 
            // ra_btn
            // 
            this.ra_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ra_btn.Location = new System.Drawing.Point(313, 225);
            this.ra_btn.Name = "ra_btn";
            this.ra_btn.Size = new System.Drawing.Size(185, 57);
            this.ra_btn.TabIndex = 9;
            this.ra_btn.Text = "Remove Asset";
            this.ra_btn.UseVisualStyleBackColor = true;
            this.ra_btn.Click += new System.EventHandler(this.ra_btn_Click);
            // 
            // aa_btn
            // 
            this.aa_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aa_btn.Location = new System.Drawing.Point(313, 162);
            this.aa_btn.Name = "aa_btn";
            this.aa_btn.Size = new System.Drawing.Size(185, 57);
            this.aa_btn.TabIndex = 8;
            this.aa_btn.Text = "Assign Asset";
            this.aa_btn.UseVisualStyleBackColor = true;
            this.aa_btn.Click += new System.EventHandler(this.aa_btn_Click);
            // 
            // vaa_btn
            // 
            this.vaa_btn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vaa_btn.Location = new System.Drawing.Point(313, 99);
            this.vaa_btn.Name = "vaa_btn";
            this.vaa_btn.Size = new System.Drawing.Size(185, 57);
            this.vaa_btn.TabIndex = 7;
            this.vaa_btn.Text = "View All Assets";
            this.vaa_btn.UseVisualStyleBackColor = true;
            this.vaa_btn.Click += new System.EventHandler(this.vaa_btn_Click);
            // 
            // allpayAssetRegister_lbl
            // 
            this.allpayAssetRegister_lbl.AutoSize = true;
            this.allpayAssetRegister_lbl.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allpayAssetRegister_lbl.Location = new System.Drawing.Point(74, 42);
            this.allpayAssetRegister_lbl.Name = "allpayAssetRegister_lbl";
            this.allpayAssetRegister_lbl.Size = new System.Drawing.Size(284, 32);
            this.allpayAssetRegister_lbl.TabIndex = 6;
            this.allpayAssetRegister_lbl.Text = "allpay Asset Register";
            // 
            // aar_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aarExit_btn);
            this.Controls.Add(this.ane_btn);
            this.Controls.Add(this.ra_btn);
            this.Controls.Add(this.aa_btn);
            this.Controls.Add(this.vaa_btn);
            this.Controls.Add(this.allpayAssetRegister_lbl);
            this.Name = "aar_Form";
            this.Text = "allpay Asset Register";
            this.Load += new System.EventHandler(this.aar_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aarExit_btn;
        private System.Windows.Forms.Button ane_btn;
        private System.Windows.Forms.Button ra_btn;
        private System.Windows.Forms.Button aa_btn;
        private System.Windows.Forms.Button vaa_btn;
        private System.Windows.Forms.Label allpayAssetRegister_lbl;
    }
}

