
namespace Restaurents
{
    partial class RestaurentDetailsForm
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
            this.lblRestaurent = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHotline = new System.Windows.Forms.Label();
            this.lblResturantName = new System.Windows.Forms.Label();
            this.lblRegionName = new System.Windows.Forms.Label();
            this.lblAddressinfo = new System.Windows.Forms.Label();
            this.lblHotlineinfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblRestaurent
            // 
            this.lblRestaurent.AutoSize = true;
            this.lblRestaurent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurent.Location = new System.Drawing.Point(30, 9);
            this.lblRestaurent.Name = "lblRestaurent";
            this.lblRestaurent.Size = new System.Drawing.Size(68, 22);
            this.lblRestaurent.TabIndex = 4;
            this.lblRestaurent.Text = "Name :";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegion.Location = new System.Drawing.Point(30, 76);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(78, 22);
            this.lblRegion.TabIndex = 5;
            this.lblRegion.Text = "Region :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(30, 144);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 22);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address :";
            // 
            // lblHotline
            // 
            this.lblHotline.AutoSize = true;
            this.lblHotline.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHotline.Location = new System.Drawing.Point(41, 207);
            this.lblHotline.Name = "lblHotline";
            this.lblHotline.Size = new System.Drawing.Size(79, 22);
            this.lblHotline.TabIndex = 7;
            this.lblHotline.Text = "Hotline :";
            // 
            // lblResturantName
            // 
            this.lblResturantName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResturantName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblResturantName.Location = new System.Drawing.Point(148, 9);
            this.lblResturantName.Name = "lblResturantName";
            this.lblResturantName.Size = new System.Drawing.Size(263, 22);
            this.lblResturantName.TabIndex = 8;
            // 
            // lblRegionName
            // 
            this.lblRegionName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegionName.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblRegionName.Location = new System.Drawing.Point(148, 76);
            this.lblRegionName.Name = "lblRegionName";
            this.lblRegionName.Size = new System.Drawing.Size(263, 22);
            this.lblRegionName.TabIndex = 9;
            // 
            // lblAddressinfo
            // 
            this.lblAddressinfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAddressinfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblAddressinfo.Location = new System.Drawing.Point(134, 144);
            this.lblAddressinfo.Name = "lblAddressinfo";
            this.lblAddressinfo.Size = new System.Drawing.Size(263, 22);
            this.lblAddressinfo.TabIndex = 10;
            // 
            // lblHotlineinfo
            // 
            this.lblHotlineinfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHotlineinfo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblHotlineinfo.Location = new System.Drawing.Point(134, 207);
            this.lblHotlineinfo.Name = "lblHotlineinfo";
            this.lblHotlineinfo.Size = new System.Drawing.Size(263, 22);
            this.lblHotlineinfo.TabIndex = 11;
            // 
            // RestaurentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(513, 322);
            this.Controls.Add(this.lblHotlineinfo);
            this.Controls.Add(this.lblAddressinfo);
            this.Controls.Add(this.lblRegionName);
            this.Controls.Add(this.lblResturantName);
            this.Controls.Add(this.lblHotline);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblRegion);
            this.Controls.Add(this.lblRestaurent);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RestaurentDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RestaurentDetailsForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRestaurent;
        private System.Windows.Forms.Label lblRegion;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblHotline;
        private System.Windows.Forms.Label lblResturantName;
        private System.Windows.Forms.Label lblRegionName;
        private System.Windows.Forms.Label lblAddressinfo;
        private System.Windows.Forms.Label lblHotlineinfo;
    }
}