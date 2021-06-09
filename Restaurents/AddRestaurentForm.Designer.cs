
namespace Restaurents
{
    partial class AddRestaurentForm
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtResturantName = new System.Windows.Forms.TextBox();
            this.InsertButton = new System.Windows.Forms.Button();
            this.ShowAvailableRegions = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHotline = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 9);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(114, 20);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "EnterName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Region :";
            // 
            // txtResturantName
            // 
            this.txtResturantName.Location = new System.Drawing.Point(167, 11);
            this.txtResturantName.Name = "txtResturantName";
            this.txtResturantName.Size = new System.Drawing.Size(157, 20);
            this.txtResturantName.TabIndex = 2;
            // 
            // InsertButton
            // 
            this.InsertButton.BackColor = System.Drawing.Color.Coral;
            this.InsertButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.InsertButton.Location = new System.Drawing.Point(414, 204);
            this.InsertButton.Name = "InsertButton";
            this.InsertButton.Size = new System.Drawing.Size(156, 73);
            this.InsertButton.TabIndex = 4;
            this.InsertButton.Text = "Insert";
            this.InsertButton.UseVisualStyleBackColor = false;
            this.InsertButton.Click += new System.EventHandler(this.InsertButton_Click);
            // 
            // ShowAvailableRegions
            // 
            this.ShowAvailableRegions.DisplayMember = "Name";
            this.ShowAvailableRegions.FormattingEnabled = true;
            this.ShowAvailableRegions.Location = new System.Drawing.Point(167, 68);
            this.ShowAvailableRegions.MaximumSize = new System.Drawing.Size(200, 0);
            this.ShowAvailableRegions.Name = "ShowAvailableRegions";
            this.ShowAvailableRegions.Size = new System.Drawing.Size(157, 21);
            this.ShowAvailableRegions.TabIndex = 5;
            this.ShowAvailableRegions.ValueMember = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(20, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Address :";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(167, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(228, 20);
            this.txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hotline :";
            // 
            // txtHotline
            // 
            this.txtHotline.Location = new System.Drawing.Point(167, 175);
            this.txtHotline.Name = "txtHotline";
            this.txtHotline.Size = new System.Drawing.Size(106, 20);
            this.txtHotline.TabIndex = 9;
            // 
            // AddRestaurentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(623, 300);
            this.Controls.Add(this.txtHotline);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ShowAvailableRegions);
            this.Controls.Add(this.InsertButton);
            this.Controls.Add(this.txtResturantName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddRestaurentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddRestaurent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddRestaurentForm_FormClosing);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtResturantName;
        private System.Windows.Forms.Button InsertButton;
        private System.Windows.Forms.ComboBox ShowAvailableRegions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHotline;
    }
}