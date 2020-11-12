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
            this.opIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.opIcon.Location = new System.Drawing.Point(0, 0);
            this.opIcon.Margin = new System.Windows.Forms.Padding(4);
            this.opIcon.Name = "opIcon";
            this.opIcon.Size = new System.Drawing.Size(50, 44);
            this.opIcon.TabIndex = 0;
            this.opIcon.TabStop = false;
            //this.opIcon.Click += new System.EventHandler(this.opIcon_Click);
            // 
            // opTitle
            // 
            this.opTitle.AutoSize = true;
            this.opTitle.Font = new System.Drawing.Font("Palatino Linotype", 12.89552F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(130)))));
            this.opTitle.Location = new System.Drawing.Point(58, 6);
            this.opTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.opTitle.Name = "opTitle";
            this.opTitle.Size = new System.Drawing.Size(88, 32);
            this.opTitle.TabIndex = 1;
            this.opTitle.Text = "opTitle";
            //this.opTitle.Click += new System.EventHandler(this.opTitle_Click);
            // 
            // NavigationOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.opTitle);
            this.Controls.Add(this.opIcon);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NavigationOption";
            this.Size = new System.Drawing.Size(221, 44);
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
