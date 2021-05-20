
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
            this.listView = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lsRegion
            // 
            this.lsRegion.DisplayMember = "Name";
            this.lsRegion.FormattingEnabled = true;
            this.lsRegion.Location = new System.Drawing.Point(12, 18);
            this.lsRegion.Name = "lsRegion";
            this.lsRegion.Size = new System.Drawing.Size(161, 368);
            this.lsRegion.TabIndex = 0;
            this.lsRegion.ValueMember = "Id";
            this.lsRegion.SelectedIndexChanged += new System.EventHandler(this.lsRegion_SelectedIndexChanged);
            // 
            // listView
            // 
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(179, 56);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(616, 329);
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(205, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(287, 32);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click Me To Add A Restaurent";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_AddRestaurent);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(807, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lsRegion);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox lsRegion;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button button1;
    }
}

