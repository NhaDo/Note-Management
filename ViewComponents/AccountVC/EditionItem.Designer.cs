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
            this.lbConent.Location = new System.Drawing.Point(116, 11);
            this.lbConent.Name = "lbConent";
            this.lbConent.Size = new System.Drawing.Size(35, 13);
            this.lbConent.TabIndex = 0;
            this.lbConent.Text = "label1";
            // 
            // cbSubcatgory
            // 
            this.cbSubcatgory.FormattingEnabled = true;
            this.cbSubcatgory.Location = new System.Drawing.Point(8, 8);
            this.cbSubcatgory.Name = "cbSubcatgory";
            this.cbSubcatgory.Size = new System.Drawing.Size(65, 21);
            this.cbSubcatgory.TabIndex = 1;
            this.cbSubcatgory.Visible = false;
            // 
            // lbSubcategory
            // 
            this.lbSubcategory.AutoSize = true;
            this.lbSubcategory.Location = new System.Drawing.Point(5, 11);
            this.lbSubcategory.Name = "lbSubcategory";
            this.lbSubcategory.Size = new System.Drawing.Size(35, 13);
            this.lbSubcategory.TabIndex = 2;
            this.lbSubcategory.Text = "label2";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(109, 8);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(100, 20);
            this.tbContent.TabIndex = 3;
            this.tbContent.Visible = false;
            // 
            // btnFunction
            // 
            this.btnFunction.Location = new System.Drawing.Point(241, 10);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(22, 19);
            this.btnFunction.TabIndex = 4;
            this.btnFunction.Text = "button1";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // EditionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lbSubcategory);
            this.Controls.Add(this.cbSubcatgory);
            this.Controls.Add(this.lbConent);
            this.Name = "EditionItem";
            this.Size = new System.Drawing.Size(266, 38);
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
