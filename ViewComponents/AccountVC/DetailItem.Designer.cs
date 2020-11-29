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
            this.lbSubcategory.Font = new System.Drawing.Font("Arial", 9F);
            this.lbSubcategory.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbSubcategory.Location = new System.Drawing.Point(4, 2);
            this.lbSubcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubcategory.Name = "lbSubcategory";
            this.lbSubcategory.Size = new System.Drawing.Size(51, 19);
            this.lbSubcategory.TabIndex = 0;
            this.lbSubcategory.Text = "label1";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Font = new System.Drawing.Font("Arial", 9F);
            this.lbContent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbContent.Location = new System.Drawing.Point(148, 2);
            this.lbContent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(51, 19);
            this.lbContent.TabIndex = 1;
            this.lbContent.Text = "label2";
            // 
            // DetailItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbSubcategory);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DetailItem";
            this.Size = new System.Drawing.Size(200, 36);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbSubcategory;
        private System.Windows.Forms.Label lbContent;
    }
}
