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
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.bReverse = new System.Windows.Forms.Button();
            this.lbAccountList = new System.Windows.Forms.Label();
            this.pnlList = new System.Windows.Forms.Panel();
            this.bSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbOrder
            // 
            this.cbOrder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Items.AddRange(new object[] {
            "Username",
            "Created"});
            this.cbOrder.Location = new System.Drawing.Point(241, 38);
            this.cbOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(99, 25);
            this.cbOrder.TabIndex = 0;
            this.cbOrder.Text = "sort by";
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(4, 37);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(173, 22);
            this.tbSearch.TabIndex = 2;
            // 
            // bReverse
            // 
            this.bReverse.Location = new System.Drawing.Point(349, 38);
            this.bReverse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bReverse.Name = "bReverse";
            this.bReverse.Size = new System.Drawing.Size(31, 28);
            this.bReverse.TabIndex = 3;
            this.bReverse.Text = "Reverse";
            this.bReverse.UseVisualStyleBackColor = false;
            this.bReverse.Click += new System.EventHandler(this.bReverse_Click);
            // 
            // lbAccountList
            // 
            this.lbAccountList.AutoSize = true;
            this.lbAccountList.Font = new System.Drawing.Font("Arial", 10F);
            this.lbAccountList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAccountList.Location = new System.Drawing.Point(58, 7);
            this.lbAccountList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccountList.Name = "lbAccountList";
            this.lbAccountList.Size = new System.Drawing.Size(230, 22);
            this.lbAccountList.TabIndex = 4;
            this.lbAccountList.Text = "AVAILABLE  ACCOUNTS";
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.AutoSize = true;
            this.pnlList.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlList.Location = new System.Drawing.Point(4, 87);
            this.pnlList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(0, 0);
            this.pnlList.TabIndex = 5;
            // 
            // bSearch
            // 
            this.bSearch.BackgroundImage = global::NoteMakingApp.Properties.Resources.search;
            this.bSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bSearch.Location = new System.Drawing.Point(185, 37);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(31, 28);
            this.bSearch.TabIndex = 1;
            this.bSearch.UseVisualStyleBackColor = true;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.lbAccountList);
            this.Controls.Add(this.bReverse);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cbOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AccountList";
            this.Size = new System.Drawing.Size(384, 91);
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
