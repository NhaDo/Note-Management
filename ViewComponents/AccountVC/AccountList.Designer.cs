using NoteMakingApp.ViewComponents.Account;

namespace NoteMakingApp.ViewComponents
{
    partial class AccountList
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
            this.cbOrder = new System.Windows.Forms.ComboBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bReverse = new System.Windows.Forms.Button();
            this.lbAccountList = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // cbOrder
            // 
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Items.AddRange(new object[] {
            "Username",
            "Created"});
            this.cbOrder.Location = new System.Drawing.Point(181, 31);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(75, 21);
            this.cbOrder.TabIndex = 0;
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            // 
            // bSearch
            // 
            this.bSearch.Location = new System.Drawing.Point(2, 29);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(23, 23);
            this.bSearch.TabIndex = 1;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // textBox1
            // 
            this.tbSearch.Location = new System.Drawing.Point(47, 31);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 2;
            // 
            // bReverse
            // 
            this.bReverse.Location = new System.Drawing.Point(262, 31);
            this.bReverse.Name = "bReverse";
            this.bReverse.Size = new System.Drawing.Size(23, 23);
            this.bReverse.TabIndex = 3;
            this.bReverse.Text = "Reverse";
            this.bReverse.UseVisualStyleBackColor = false;
            this.bReverse.Click += new System.EventHandler(this.bReverse_Click);
            // 
            // lbAccountList
            // 
            this.lbAccountList.AutoSize = true;
            this.lbAccountList.Location = new System.Drawing.Point(129, 15);
            this.lbAccountList.Name = "lbAccountList";
            this.lbAccountList.Size = new System.Drawing.Size(52, 13);
            this.lbAccountList.TabIndex = 4;
            this.lbAccountList.Text = "Accounts";
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.Location = new System.Drawing.Point(3, 71);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(282, 29);
            this.pnlList.TabIndex = 5;
            this.pnlList.AutoScroll = true;
            this.pnlList.AutoSize = true;
            //this.pnlList.MaximumSize = new System.Drawing.Size(AccountListItem.size.Width, AccountListItem.size.Height * 5);
            this.pnlList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            // 
            // AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.lbAccountList);
            this.Controls.Add(this.bReverse);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cbOrder);
            this.Name = "AccountList";
            this.Size = new System.Drawing.Size(288, 103);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOrder;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button bReverse;
        private System.Windows.Forms.Label lbAccountList;
        private System.Windows.Forms.Panel pnlList;
    }
}
