namespace NoteMakingApp.ViewComponents.AccountVC
{
    partial class DetailItem
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbSubcategory = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbSubcategory
            // 
            this.lbSubcategory.AutoSize = true;
            this.lbSubcategory.Location = new System.Drawing.Point(3, 16);
            this.lbSubcategory.Name = "lbSubcategory";
            this.lbSubcategory.Size = new System.Drawing.Size(35, 13);
            this.lbSubcategory.TabIndex = 0;
            this.lbSubcategory.Text = "label1";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(102, 16);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(35, 13);
            this.lbContent.TabIndex = 1;
            this.lbContent.Text = "label2";
            // 
            // DetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbSubcategory);
            this.Name = "DetailItem";
            this.Size = new System.Drawing.Size(150, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubcategory;
        private System.Windows.Forms.Label lbContent;
    }
}
