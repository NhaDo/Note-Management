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
            this.components = new System.ComponentModel.Container();
            this.lbNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.pnlCategories = new System.Windows.Forms.Panel();
            this.lbName = new System.Windows.Forms.Label();
            this.lbIntroduction = new System.Windows.Forms.Label();
            this.lbIntroductionLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNameLabel
            // 
            this.lbNameLabel.AutoSize = true;
            this.lbNameLabel.Font = new System.Drawing.Font("Arial", 8F);
            this.lbNameLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNameLabel.Location = new System.Drawing.Point(22, 157);
            this.lbNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNameLabel.Name = "lbNameLabel";
            this.lbNameLabel.Size = new System.Drawing.Size(54, 18);
            this.lbNameLabel.TabIndex = 0;
            this.lbNameLabel.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(139, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "ACCOUNT";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DarkOrange;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(314, 40);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(64, 35);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // pnlCategories
            // 
            this.pnlCategories.AutoSize = true;
            this.pnlCategories.Location = new System.Drawing.Point(6, 208);
            this.pnlCategories.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlCategories.Name = "pnlCategories";
            this.pnlCategories.Size = new System.Drawing.Size(420, 222);
            this.pnlCategories.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Bold);
            this.lbName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbName.Location = new System.Drawing.Point(208, 109);
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
            this.lbIntroduction.Location = new System.Drawing.Point(208, 157);
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
            this.lbIntroductionLabel.Location = new System.Drawing.Point(22, 157);
            this.lbIntroductionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIntroductionLabel.Name = "lbIntroductionLabel";
            this.lbIntroductionLabel.Size = new System.Drawing.Size(91, 18);
            this.lbIntroductionLabel.TabIndex = 6;
            this.lbIntroductionLabel.Text = "Introduction:";
            this.lbIntroductionLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrange;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(160, 585);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "No information";
            this.label1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 8F);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(22, 109);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Name:";
            // 
            // PersonalDetailsPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbIntroductionLabel);
            this.Controls.Add(this.lbIntroduction);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.pnlCategories);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbNameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(500, 700);
            this.Name = "PersonalDetailsPanel";
            this.Size = new System.Drawing.Size(430, 700);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
    }
}
