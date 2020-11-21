namespace NoteMakingApp.ViewComponents
{
    partial class Note
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbTittle = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteMakingApp.Properties.Resources.Note4;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 268);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(21, 24);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(46, 17);
            this.lbTittle.TabIndex = 1;
            this.lbTittle.Text = "label1";
            // 
            // lbContent
            // 
            this.lbContent.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbContent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbContent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbContent.Location = new System.Drawing.Point(19, 65);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(166, 149);
            this.lbContent.TabIndex = 2;
            this.lbContent.Text = "label1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(202, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Note";
            this.Size = new System.Drawing.Size(223, 274);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
