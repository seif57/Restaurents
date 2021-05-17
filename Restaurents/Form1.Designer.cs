
namespace Restaurents
{
    partial class Form1
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
            this.lsRegion = new System.Windows.Forms.ListBox();
            this.lsRestaurents = new System.Windows.Forms.ListBox();
            this.txtSearchRegion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsRegion
            // 
            this.lsRegion.DisplayMember = "Name";
            this.lsRegion.FormattingEnabled = true;
            this.lsRegion.Location = new System.Drawing.Point(12, 44);
            this.lsRegion.Name = "lsRegion";
            this.lsRegion.Size = new System.Drawing.Size(215, 186);
            this.lsRegion.TabIndex = 0;
            this.lsRegion.ValueMember = "Id";
            this.lsRegion.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsRegion_MouseDoubleClick);
            this.lsRegion.SelectedIndexChanged += new System.EventHandler(this.lsRegion_SelectedIndexChanged);
            // 
            // lsRestaurents
            // 
            this.lsRestaurents.DisplayMember = "Name";
            this.lsRestaurents.FormattingEnabled = true;
            this.lsRestaurents.Location = new System.Drawing.Point(467, 44);
            this.lsRestaurents.Name = "lsRestaurents";
            this.lsRestaurents.Size = new System.Drawing.Size(247, 186);
            this.lsRestaurents.TabIndex = 1;
            this.lsRestaurents.ValueMember = "Id";
            this.lsRestaurents.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lsRestaurents_MouseDoubleClick);
            // 
            // txtSearchRegion
            // 
            this.txtSearchRegion.Location = new System.Drawing.Point(281, 55);
            this.txtSearchRegion.Name = "txtSearchRegion";
            this.txtSearchRegion.Size = new System.Drawing.Size(100, 20);
            this.txtSearchRegion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pick Region:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(807, 397);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchRegion);
            this.Controls.Add(this.lsRestaurents);
            this.Controls.Add(this.lsRegion);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchRegion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lsRestaurents;
        private System.Windows.Forms.ListBox lsRegion;
       
        
     
    }
}

