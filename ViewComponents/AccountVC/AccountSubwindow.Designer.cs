namespace NoteMakingApp.ViewComponents
{
    partial class AccountSubwindow
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
            this.informationEditor1 = new NoteMakingApp.ViewComponents.AccountVC.InformationEditor();
            this.personalDetailsPanel1 = new NoteMakingApp.ViewComponents.AccountVC.PersonalDetailsPanel();
            this.accountList1 = new NoteMakingApp.ViewComponents.AccountList();
            this.btnShare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // informationEditor1
            // 
            this.informationEditor1.AutoScroll = true;
            this.informationEditor1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.informationEditor1.Location = new System.Drawing.Point(345, 208);
            this.informationEditor1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.informationEditor1.Name = "informationEditor1";
            this.informationEditor1.Size = new System.Drawing.Size(364, 113);
            this.informationEditor1.TabIndex = 2;
            this.informationEditor1.Visible = false;
            // 
            // personalDetailsPanel1
            // 
            this.personalDetailsPanel1.AutoScroll = true;
            this.personalDetailsPanel1.AutoSize = true;
            this.personalDetailsPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.personalDetailsPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.personalDetailsPanel1.Location = new System.Drawing.Point(464, 14);
            this.personalDetailsPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.personalDetailsPanel1.MaximumSize = new System.Drawing.Size(207, 250);
            this.personalDetailsPanel1.Name = "personalDetailsPanel1";
            this.personalDetailsPanel1.Size = new System.Drawing.Size(207, 117);
            this.personalDetailsPanel1.TabIndex = 1;
            // 
            // accountList1
            // 
            this.accountList1.AutoScroll = true;
            this.accountList1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.accountList1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.accountList1.Location = new System.Drawing.Point(0, 0);
            this.accountList1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.accountList1.Name = "accountList1";
            this.accountList1.Size = new System.Drawing.Size(338, 432);
            this.accountList1.TabIndex = 0;
            // 
            // btnShare
            // 
            this.btnShare.Location = new System.Drawing.Point(93, 285);
            this.btnShare.Name = "btnShare";
            this.btnShare.Size = new System.Drawing.Size(141, 23);
            this.btnShare.TabIndex = 3;
            this.btnShare.Text = "Share your information";
            this.btnShare.UseVisualStyleBackColor = true;
            this.btnShare.Click += new System.EventHandler(this.btnShare_Click);
            // 
            // AccountSubwindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnShare);
            this.Controls.Add(this.informationEditor1);
            this.Controls.Add(this.personalDetailsPanel1);
            this.Controls.Add(this.accountList1);
            this.Name = "AccountSubwindow";
            this.Size = new System.Drawing.Size(709, 432);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NoteMakingApp.ViewComponents.AccountList accountList1;
        private AccountVC.PersonalDetailsPanel personalDetailsPanel1;
        private AccountVC.InformationEditor informationEditor1;
        private System.Windows.Forms.Button btnShare;
    }
}
