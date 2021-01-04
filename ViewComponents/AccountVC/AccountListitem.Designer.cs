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
            this.lbIndex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbIndex.Font = new System.Drawing.Font("Arial", 8F);
            this.lbIndex.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIndex.Location = new System.Drawing.Point(32, 21);
            this.lbIndex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIndex.Name = "lbIndex";
            this.lbIndex.Size = new System.Drawing.Size(50, 18);
            this.lbIndex.TabIndex = 0;
            this.lbIndex.Text = "label1";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbUsername.Font = new System.Drawing.Font("Arial", 8F);
            this.lbUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbUsername.Location = new System.Drawing.Point(135, 21);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(50, 18);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "label2";
            // 
            // lbCreated
            // 
            this.lbCreated.AutoSize = true;
            this.lbCreated.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbCreated.Font = new System.Drawing.Font("Arial", 8F);
            this.lbCreated.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCreated.Location = new System.Drawing.Point(279, 21);
            this.lbCreated.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCreated.Name = "lbCreated";
            this.lbCreated.Size = new System.Drawing.Size(50, 18);
            this.lbCreated.TabIndex = 2;
            this.lbCreated.Text = "label3";
            // 
            // btnMore
            // 
            this.btnMore.BackgroundImage = global::NoteMakingApp.Properties.Resources.plus2;
            this.btnMore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnMore.Location = new System.Drawing.Point(492, 15);
            this.btnMore.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(30, 30);
            this.btnMore.TabIndex = 3;
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // AccountListItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.lbCreated);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbIndex);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountListItem";
            this.Size = new System.Drawing.Size(567, 60);
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
