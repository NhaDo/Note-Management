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
            this.lbNameLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.lbNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNameLabel.Location = new System.Drawing.Point(22, 66);
            this.lbNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameLabel.Name = "lbNameLabel";
            this.lbNameLabel.Size = new System.Drawing.Size(54, 18);
            this.lbNameLabel.TabIndex = 0;
            this.lbNameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(22, 8);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACCOUNT";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(180, 8);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(112, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit Info";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlCategories
            // 
            this.pnlCategories.AutoSize = true;
            this.pnlCategories.Location = new System.Drawing.Point(6, 159);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(300, 18);
            this.pnlCategories.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Location = new System.Drawing.Point(208, 66);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(0, 19);
            this.lbName.TabIndex = 4;
            // 
            // lbIntroduction
            // 
            this.lbIntroduction.AutoSize = true;
            this.lbIntroduction.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lbIntroduction.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIntroduction.Location = new System.Drawing.Point(208, 102);
            this.lbIntroduction.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIntroduction.Name = "lbIntroduction";
            this.lbIntroduction.Size = new System.Drawing.Size(0, 19);
            this.lbIntroduction.TabIndex = 5;
            this.lbIntroduction.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbIntroductionLabel
            // 
            this.lbIntroductionLabel.AutoSize = true;
            this.lbIntroductionLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.lbIntroductionLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIntroductionLabel.Location = new System.Drawing.Point(22, 102);
            this.lbIntroductionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIntroductionLabel.Name = "lbIntroductionLabel";
            this.lbIntroductionLabel.Size = new System.Drawing.Size(91, 18);
            this.lbIntroductionLabel.TabIndex = 6;
            this.lbIntroductionLabel.Text = "Introduction:";
            this.lbIntroductionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PersonalDetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.lbIntroductionLabel);
            this.Controls.Add(this.lbIntroduction);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(310, 385);
            this.Name = "PersonalDetailsPanel";
            this.Size = new System.Drawing.Size(310, 182);
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
