namespace NoteMakingApp.ViewComponents
{
    partial class NavigationOption
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
            this.opIcon = new System.Windows.Forms.PictureBox();
            this.opTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.opIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // opIcon
            // 
            this.opIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.opIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.opIcon.Location = new System.Drawing.Point(16, 16);
            this.opIcon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.opIcon.Name = "opIcon";
            this.opIcon.Size = new System.Drawing.Size(69, 69);
            this.opIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.opIcon.TabIndex = 0;
            this.opIcon.TabStop = false;
            // 
            // opTitle
            // 
            this.opTitle.AutoSize = true;
            this.opTitle.Font = new System.Drawing.Font("Arial", 10F);
            this.opTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.opTitle.Location = new System.Drawing.Point(32, 72);
            this.opTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opTitle.Name = "opTitle";
            this.opTitle.Size = new System.Drawing.Size(68, 23);
            this.opTitle.TabIndex = 1;
            this.opTitle.Text = "opTitle";
            this.opTitle.Visible = false;
            // 
            // NavigationOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.Controls.Add(this.opTitle);
            this.Controls.Add(this.opIcon);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NavigationOption";
            this.Size = new System.Drawing.Size(102, 102);
            this.Load += new System.EventHandler(this.NavigationOption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.opIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox opIcon;
        public System.Windows.Forms.Label opTitle;
    }
}
