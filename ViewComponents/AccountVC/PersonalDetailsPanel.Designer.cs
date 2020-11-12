namespace NoteMakingApp.ViewComponents.AccountVC
{
    partial class PersonalDetailsPanel
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
            this.lbNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbIntroduction = new System.Windows.Forms.Label();
            this.lbIntroductionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNameLabel
            // 
            this.lbNameLabel.AutoSize = true;
            this.lbNameLabel.Location = new System.Drawing.Point(15, 43);
            this.lbNameLabel.Name = "lbNameLabel";
            this.lbNameLabel.Size = new System.Drawing.Size(35, 13);
            this.lbNameLabel.TabIndex = 0;
            this.lbNameLabel.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(120, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "button1";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlCategories
            // 
            this.pnlCategories.AutoScroll = true;
            this.pnlCategories.AutoSize = true;
            this.pnlCategories.Location = new System.Drawing.Point(4, 103);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(200, 11);
            this.pnlCategories.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(139, 43);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(35, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "label1";
            // 
            // lbIntroduction
            // 
            this.lbIntroduction.AutoSize = true;
            this.lbIntroduction.Location = new System.Drawing.Point(139, 67);
            this.lbIntroduction.Name = "lbIntroduction";
            this.lbIntroduction.Size = new System.Drawing.Size(35, 13);
            this.lbIntroduction.TabIndex = 5;
            this.lbIntroduction.Text = "Name";
            this.lbIntroduction.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbIntroductionLabel
            // 
            this.lbIntroductionLabel.AutoSize = true;
            this.lbIntroductionLabel.Location = new System.Drawing.Point(15, 67);
            this.lbIntroductionLabel.Name = "lbIntroductionLabel";
            this.lbIntroductionLabel.Size = new System.Drawing.Size(63, 13);
            this.lbIntroductionLabel.TabIndex = 6;
            this.lbIntroductionLabel.Text = "Introduction";
            this.lbIntroductionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PersonalDetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.lbIntroductionLabel);
            this.Controls.Add(this.lbIntroduction);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNameLabel);
            this.MaximumSize = new System.Drawing.Size(207, 250);
            this.Name = "PersonalDetailsPanel";
            this.Size = new System.Drawing.Size(207, 117);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Panel pnlCategories;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbIntroduction;
        private System.Windows.Forms.Label lbIntroductionLabel;
    }
}
