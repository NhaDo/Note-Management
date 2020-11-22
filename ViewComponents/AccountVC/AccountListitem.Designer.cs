namespace NoteMakingApp.ViewComponents.Account
{
    partial class AccountListItem
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
            this.lbIndex = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbCreated = new System.Windows.Forms.Label();
            this.btnMore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbIndex
            // 
            this.lbIndex.AutoSize = true;
            this.lbIndex.Location = new System.Drawing.Point(3, 10);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(35, 13);
            this.lbIndex.TabIndex = 0;
            this.lbIndex.Text = "label1";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(44, 10);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(35, 13);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "label2";
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.Location = new System.Drawing.Point(103, 10);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(35, 13);
            this.lbCreated.TabIndex = 2;
            this.lbCreated.Text = "label3";
            // 
            // btnMore
            // 
            this.btnMore.Location = new System.Drawing.Point(181, 5);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(25, 23);
            this.btnMore.TabIndex = 3;
            this.btnMore.Text = "button1";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // AccountListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.lbCreated);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbIndex);
/*            this.ParentChanged += new System.EventHandler(this.btnMore_Click);
*/            this.Name = "AccountListItem";
            this.Size = new System.Drawing.Size(209, 31);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIndex;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbCreated;
        private System.Windows.Forms.Button btnMore;
    }
}
