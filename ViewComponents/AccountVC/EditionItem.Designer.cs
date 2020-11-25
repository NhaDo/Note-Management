namespace NoteMakingApp.ViewComponents.AccountVC
{
    partial class EditionItem
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
            this.lbConent = new System.Windows.Forms.Label();
            this.cbSubcatgory = new System.Windows.Forms.ComboBox();
            this.lbSubcategory = new System.Windows.Forms.Label();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnFunction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConent
            // 
            this.lbConent.AutoSize = true;
            this.lbConent.Font = new System.Drawing.Font("Arial", 8F);
            this.lbConent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbConent.Location = new System.Drawing.Point(163, 14);
            this.lbConent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConent.Name = "lbConent";
            this.lbConent.Size = new System.Drawing.Size(46, 17);
            this.lbConent.TabIndex = 0;
            this.lbConent.Text = "label1";
            // 
            // cbSubcatgory
            // 
            this.cbSubcatgory.FormattingEnabled = true;
            this.cbSubcatgory.Location = new System.Drawing.Point(52, 10);
            this.cbSubcatgory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSubcatgory.Name = "cbSubcatgory";
            this.cbSubcatgory.Size = new System.Drawing.Size(103, 24);
            this.cbSubcatgory.TabIndex = 1;
            this.cbSubcatgory.Visible = false;
            // 
            // lbSubcategory
            // 
            this.lbSubcategory.AutoSize = true;
            this.lbSubcategory.Font = new System.Drawing.Font("Arial", 8F);
            this.lbSubcategory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSubcategory.Location = new System.Drawing.Point(7, 14);
            this.lbSubcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubcategory.Name = "lbSubcategory";
            this.lbSubcategory.Size = new System.Drawing.Size(46, 17);
            this.lbSubcategory.TabIndex = 2;
            this.lbSubcategory.Text = "label2";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(214, 11);
            this.tbContent.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(132, 22);
            this.tbContent.TabIndex = 3;
            this.tbContent.Visible = false;
            // 
            // btnFunction
            // 
            this.btnFunction.BackColor = System.Drawing.Color.Firebrick;
            this.btnFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunction.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnFunction.Location = new System.Drawing.Point(354, 6);
            this.btnFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(80, 30);
            this.btnFunction.TabIndex = 4;
            this.btnFunction.Text = "button1";
            this.btnFunction.UseVisualStyleBackColor = false;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // EditionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lbSubcategory);
            this.Controls.Add(this.cbSubcatgory);
            this.Controls.Add(this.lbConent);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "EditionItem";
            this.Size = new System.Drawing.Size(438, 47);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConent;
        private System.Windows.Forms.ComboBox cbSubcatgory;
        private System.Windows.Forms.Label lbSubcategory;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btnFunction;
    }
}
