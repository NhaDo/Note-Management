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
            this.btnNone = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbConent
            // 
            this.lbConent.AutoSize = true;
            this.lbConent.Font = new System.Drawing.Font("Arial", 8F);
            this.lbConent.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbConent.Location = new System.Drawing.Point(186, 29);
            this.lbConent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbConent.Name = "lbConent";
            this.lbConent.Size = new System.Drawing.Size(50, 18);
            this.lbConent.TabIndex = 0;
            this.lbConent.Text = "label1";
            // 
            // cbSubcatgory
            // 
            this.cbSubcatgory.FormattingEnabled = true;
            this.cbSubcatgory.Location = new System.Drawing.Point(61, 24);
            this.cbSubcatgory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbSubcatgory.Name = "cbSubcatgory";
            this.cbSubcatgory.Size = new System.Drawing.Size(115, 28);
            this.cbSubcatgory.TabIndex = 1;
            this.cbSubcatgory.Visible = false;
            // 
            // lbSubcategory
            // 
            this.lbSubcategory.AutoSize = true;
            this.lbSubcategory.Font = new System.Drawing.Font("Arial", 8F);
            this.lbSubcategory.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSubcategory.Location = new System.Drawing.Point(11, 29);
            this.lbSubcategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSubcategory.Name = "lbSubcategory";
            this.lbSubcategory.Size = new System.Drawing.Size(50, 18);
            this.lbSubcategory.TabIndex = 2;
            this.lbSubcategory.Text = "label2";
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(243, 26);
            this.tbContent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(148, 26);
            this.tbContent.TabIndex = 3;
            this.tbContent.Visible = false;
            // 
            // btnNone
            // 
            this.btnNone.BackColor = System.Drawing.Color.Firebrick;
            this.btnNone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnNone.Location = new System.Drawing.Point(464, 21);
            this.btnNone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(60, 37);
            this.btnNone.TabIndex = 4;
            this.btnNone.Text = "None";
            this.btnNone.UseVisualStyleBackColor = false;
            this.btnNone.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Firebrick;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDelete.Location = new System.Drawing.Point(521, 21);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(71, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.BackColor = System.Drawing.Color.Firebrick;
            this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModify.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnModify.Location = new System.Drawing.Point(587, 21);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(74, 37);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = false;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // EditionItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnNone);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.lbSubcategory);
            this.Controls.Add(this.cbSubcatgory);
            this.Controls.Add(this.lbConent);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditionItem";
            this.Size = new System.Drawing.Size(678, 79);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbConent;
        private System.Windows.Forms.ComboBox cbSubcatgory;
        private System.Windows.Forms.Label lbSubcategory;
        private System.Windows.Forms.TextBox tbContent;
        private System.Windows.Forms.Button btnNone;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnModify;
    }
}
