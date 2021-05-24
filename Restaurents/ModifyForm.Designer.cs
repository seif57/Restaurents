
namespace Restaurents
{
    partial class ModifyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ResName = new System.Windows.Forms.TextBox();
            this.ShowAvailableRegions = new System.Windows.Forms.ComboBox();
            this.Addressbox = new System.Windows.Forms.TextBox();
            this.Hotlinebox = new System.Windows.Forms.TextBox();
            this.ModifyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(16, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "EnterName :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(42, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Region :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(40, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Address :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(40, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hotline :";
            // 
            // ResName
            // 
            this.ResName.Location = new System.Drawing.Point(161, 31);
            this.ResName.Name = "ResName";
            this.ResName.Size = new System.Drawing.Size(288, 20);
            this.ResName.TabIndex = 4;
            // 
            // ShowAvailableRegions
            // 
            this.ShowAvailableRegions.DisplayMember = "Name";
            this.ShowAvailableRegions.FormattingEnabled = true;
            this.ShowAvailableRegions.Location = new System.Drawing.Point(161, 75);
            this.ShowAvailableRegions.Name = "ShowAvailableRegions";
            this.ShowAvailableRegions.Size = new System.Drawing.Size(299, 21);
            this.ShowAvailableRegions.TabIndex = 5;
            this.ShowAvailableRegions.ValueMember = "Id";
            // 
            // Addressbox
            // 
            this.Addressbox.Location = new System.Drawing.Point(161, 131);
            this.Addressbox.Name = "Addressbox";
            this.Addressbox.Size = new System.Drawing.Size(298, 20);
            this.Addressbox.TabIndex = 6;
            // 
            // Hotlinebox
            // 
            this.Hotlinebox.Location = new System.Drawing.Point(161, 186);
            this.Hotlinebox.Name = "Hotlinebox";
            this.Hotlinebox.Size = new System.Drawing.Size(315, 20);
            this.Hotlinebox.TabIndex = 7;
            // 
            // ModifyButton
            // 
            this.ModifyButton.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold);
            this.ModifyButton.Location = new System.Drawing.Point(488, 258);
            this.ModifyButton.Name = "ModifyButton";
            this.ModifyButton.Size = new System.Drawing.Size(190, 69);
            this.ModifyButton.TabIndex = 8;
            this.ModifyButton.Text = "Modify";
            this.ModifyButton.UseVisualStyleBackColor = true;
            this.ModifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // ModifyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(749, 355);
            this.Controls.Add(this.ModifyButton);
            this.Controls.Add(this.Hotlinebox);
            this.Controls.Add(this.Addressbox);
            this.Controls.Add(this.ShowAvailableRegions);
            this.Controls.Add(this.ResName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModifyForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.ModifyForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ResName;
        private System.Windows.Forms.ComboBox ShowAvailableRegions;
        private System.Windows.Forms.TextBox Addressbox;
        private System.Windows.Forms.TextBox Hotlinebox;
        private System.Windows.Forms.Button ModifyButton;
    }
}