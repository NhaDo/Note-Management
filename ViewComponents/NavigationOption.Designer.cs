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
            this.opIcon.Location = new System.Drawing.Point(0, 24);
            this.opIcon.Name = "opIcon";
            this.opIcon.Size = new System.Drawing.Size(58, 50);
            this.opIcon.TabIndex = 0;
            this.opIcon.TabStop = false;
            this.opIcon.Click += new System.EventHandler(this.opIcon_Click);
            // 
            // opTitle
            // 
            this.opTitle.AutoSize = true;
            this.opTitle.Location = new System.Drawing.Point(81, 42);
            this.opTitle.Name = "opTitle";
            this.opTitle.Size = new System.Drawing.Size(39, 13);
            this.opTitle.TabIndex = 1;
            this.opTitle.Text = "opTitle";
            this.opTitle.Click += new System.EventHandler(this.opTitle_Click);
            // 
            // NavigationOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Controls.Add(this.opTitle);
            this.Controls.Add(this.opIcon);
            this.Name = "NavigationOption";
            this.Size = new System.Drawing.Size(163, 90);
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
