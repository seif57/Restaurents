
namespace Restaurents
{
    partial class ModifyMenu
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.BtnMode = new System.Windows.Forms.Button();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblName.Location = new System.Drawing.Point(33, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name :";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblPrice.Location = new System.Drawing.Point(33, 133);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(65, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "Price :";
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.lblInfo.Location = new System.Drawing.Point(33, 209);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(52, 20);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Info :";
            // 
            // BtnMode
            // 
            this.BtnMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.BtnMode.Location = new System.Drawing.Point(468, 286);
            this.BtnMode.Name = "BtnMode";
            this.BtnMode.Size = new System.Drawing.Size(145, 65);
            this.BtnMode.TabIndex = 4;
            this.BtnMode.Text = "BtnMode";
            this.BtnMode.UseVisualStyleBackColor = true;
            this.BtnMode.Click += new System.EventHandler(this.BtnMode_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.Location = new System.Drawing.Point(113, 52);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(232, 20);
            this.txtItemName.TabIndex = 5;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(113, 135);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(232, 20);
            this.txtPrice.TabIndex = 6;
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(117, 209);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(228, 20);
            this.txtInfo.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ModifyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 363);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.BtnMode);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblName);
            this.Name = "ModifyMenu";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModifyMenu_FormClosing);
            this.Load += new System.EventHandler(this.ModifyMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button BtnMode;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}