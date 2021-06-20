
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRestaurent = new System.Windows.Forms.Label();
            this.lblRegion = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblHotline = new System.Windows.Forms.Label();
            this.lblResturantName = new System.Windows.Forms.Label();
            this.lblRegionName = new System.Windows.Forms.Label();
            this.lblAddressinfo = new System.Windows.Forms.Label();
            this.lblHotlineinfo = new System.Windows.Forms.Label();
            this.dataGridMenu = new System.Windows.Forms.DataGridView();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RestaurentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modify = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblMenu = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRestaurent
            // 
            this.lblRestaurent.AutoSize = true;
            this.lblRestaurent.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRestaurent.Location = new System.Drawing.Point(12, 9);
            this.lblRestaurent.Name = "lblRestaurent";
            this.lblRestaurent.Size = new System.Drawing.Size(68, 22);
            this.lblRestaurent.TabIndex = 4;
            this.lblRestaurent.Text = "Name :";
            // 
            // lblRegion
            // 
            this.lblRegion.AutoSize = true;
            this.lblRegion.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegion.Location = new System.Drawing.Point(2, 52);
            this.lblRegion.Name = "lblRegion";
            this.lblRegion.Size = new System.Drawing.Size(78, 22);
            this.lblRegion.TabIndex = 5;
            this.lblRegion.Text = "Region :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAddress.Location = new System.Drawing.Point(2, 97);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(86, 22);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "Address :";
            // 
            // lblHotline
            // 
            this.lblHotline.AutoSize = true;
            this.lblHotline.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHotline.Location = new System.Drawing.Point(9, 134);
            this.lblHotline.Name = "lblHotline";
            this.lblHotline.Size = new System.Drawing.Size(79, 22);
            this.lblHotline.TabIndex = 7;
            this.lblHotline.Text = "Hotline :";
            // 
            // lblResturantName
            // 
            this.lblResturantName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResturantName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblResturantName.Location = new System.Drawing.Point(86, 9);
            this.lblResturantName.Name = "lblResturantName";
            this.lblResturantName.Size = new System.Drawing.Size(263, 22);
            this.lblResturantName.TabIndex = 8;
            // 
            // lblRegionName
            // 
            this.lblRegionName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRegionName.ForeColor = System.Drawing.Color.DarkRed;
            this.lblRegionName.Location = new System.Drawing.Point(86, 52);
            this.lblRegionName.Name = "lblRegionName";
            this.lblRegionName.Size = new System.Drawing.Size(263, 22);
            this.lblRegionName.TabIndex = 9;
            // 
            // lblAddressinfo
            // 
            this.lblAddressinfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAddressinfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblAddressinfo.Location = new System.Drawing.Point(105, 97);
            this.lblAddressinfo.Name = "lblAddressinfo";
            this.lblAddressinfo.Size = new System.Drawing.Size(263, 22);
            this.lblAddressinfo.TabIndex = 10;
            // 
            // lblHotlineinfo
            // 
            this.lblHotlineinfo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHotlineinfo.ForeColor = System.Drawing.Color.DarkRed;
            this.lblHotlineinfo.Location = new System.Drawing.Point(123, 134);
            this.lblHotlineinfo.Name = "lblHotlineinfo";
            this.lblHotlineinfo.Size = new System.Drawing.Size(263, 22);
            this.lblHotlineinfo.TabIndex = 11;
            // 
            // dataGridMenu
            // 
            this.dataGridMenu.AllowUserToAddRows = false;
            this.dataGridMenu.AllowUserToDeleteRows = false;
            this.dataGridMenu.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridMenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemId,
            this.ItemName,
            this.RestaurentId,
            this.ItemPrice,
            this.ItemInfo,
            this.Modify,
            this.Delete});
            this.dataGridMenu.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridMenu.Location = new System.Drawing.Point(6, 191);
            this.dataGridMenu.MultiSelect = false;
            this.dataGridMenu.Name = "dataGridMenu";
            this.dataGridMenu.ReadOnly = true;
            this.dataGridMenu.Size = new System.Drawing.Size(938, 254);
            this.dataGridMenu.TabIndex = 12;
            this.dataGridMenu.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridMenu_CellContentClick);
            // 
            // ItemId
            // 
            this.ItemId.DataPropertyName = "ID";
            this.ItemId.HeaderText = "ItemId";
            this.ItemId.Name = "ItemId";
            this.ItemId.ReadOnly = true;
            this.ItemId.Visible = false;
            this.ItemId.Width = 61;
            // 
            // ItemName
            // 
            this.ItemName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemName.DataPropertyName = "Name";
            this.ItemName.HeaderText = "ItemName";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            this.ItemName.Width = 80;
            // 
            // RestaurentId
            // 
            this.RestaurentId.DataPropertyName = "RestaurentId";
            this.RestaurentId.HeaderText = "RestaurentId";
            this.RestaurentId.Name = "RestaurentId";
            this.RestaurentId.ReadOnly = true;
            this.RestaurentId.Visible = false;
            this.RestaurentId.Width = 93;
            // 
            // ItemPrice
            // 
            this.ItemPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ItemPrice.DataPropertyName = "Price";
            this.ItemPrice.HeaderText = "Price";
            this.ItemPrice.Name = "ItemPrice";
            this.ItemPrice.ReadOnly = true;
            this.ItemPrice.Width = 56;
            // 
            // ItemInfo
            // 
            this.ItemInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemInfo.DataPropertyName = "Info";
            this.ItemInfo.HeaderText = "Info";
            this.ItemInfo.Name = "ItemInfo";
            this.ItemInfo.ReadOnly = true;
            // 
            // Modify
            // 
            this.Modify.HeaderText = "Modify";
            this.Modify.Name = "Modify";
            this.Modify.ReadOnly = true;
            this.Modify.Text = "Modify";
            this.Modify.UseColumnTextForButtonValue = true;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblMenu.Location = new System.Drawing.Point(852, 161);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(73, 27);
            this.lblMenu.TabIndex = 13;
            this.lblMenu.Text = "Menu ";
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(37, 162);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(72, 25);
            this.btnAddItem.TabIndex = 14;
            this.btnAddItem.Text = "New+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // RestaurentDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 447);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.dataGridMenu);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridMenu)).EndInit();
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
        private System.Windows.Forms.DataGridView dataGridMenu;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RestaurentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemInfo;
        private System.Windows.Forms.DataGridViewButtonColumn Modify;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btnAddItem;
    }
}