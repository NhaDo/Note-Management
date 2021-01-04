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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbOrder
            // 
            this.cbOrder.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Italic);
            this.cbOrder.FormattingEnabled = true;
            this.cbOrder.Items.AddRange(new object[] {
            "Username",
            "Created"});
            this.cbOrder.Location = new System.Drawing.Point(395, 141);
            this.cbOrder.Margin = new System.Windows.Forms.Padding(10);
            this.cbOrder.Name = "cbOrder";
            this.cbOrder.Size = new System.Drawing.Size(123, 27);
            this.cbOrder.TabIndex = 0;
            this.cbOrder.Text = "sort by";
            this.cbOrder.SelectedIndexChanged += new System.EventHandler(this.cbOrder_SelectedIndexChanged);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(17, 142);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(265, 26);
            this.tbSearch.TabIndex = 2;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            // 
            // bReverse
            // 
            this.bReverse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bReverse.CausesValidation = false;
            this.bReverse.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bReverse.FlatAppearance.BorderSize = 0;
            this.bReverse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bReverse.Location = new System.Drawing.Point(532, 132);
            this.bReverse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bReverse.Name = "bReverse";
            this.bReverse.Size = new System.Drawing.Size(103, 45);
            this.bReverse.TabIndex = 3;
            this.bReverse.Text = "Reverse";
            this.bReverse.UseVisualStyleBackColor = false;
            this.bReverse.Click += new System.EventHandler(this.bReverse_Click);
            // 
            // lbAccountList
            // 
            this.lbAccountList.AutoSize = true;
            this.lbAccountList.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountList.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAccountList.Location = new System.Drawing.Point(131, 45);
            this.lbAccountList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAccountList.Name = "lbAccountList";
            this.lbAccountList.Size = new System.Drawing.Size(376, 36);
            this.lbAccountList.TabIndex = 4;
            this.lbAccountList.Text = "AVAILABLE  ACCOUNTS";
            // 
            // pnlList
            // 
            this.pnlList.AutoScroll = true;
            this.pnlList.AutoSize = true;
            this.pnlList.Location = new System.Drawing.Point(21, 270);
            this.pnlList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlList.MaximumSize = new System.Drawing.Size(600, 300);
            this.pnlList.Name = "pnlList";
            this.pnlList.Size = new System.Drawing.Size(600, 300);
            this.pnlList.TabIndex = 5;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bSearch.BackgroundImage = global::NoteMakingApp.Properties.Resources.search;
            this.bSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.bSearch.Location = new System.Drawing.Point(290, 133);
            this.bSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(45, 45);
            this.bSearch.TabIndex = 1;
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(42, 222);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "#";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(133, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Username";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(338, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Created in";
            // 
            // AccountList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlList);
            this.Controls.Add(this.lbAccountList);
            this.Controls.Add(this.bReverse);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.cbOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountList";
            this.Size = new System.Drawing.Size(655, 302);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
