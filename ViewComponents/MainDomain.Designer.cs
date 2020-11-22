namespace NoteMakingApp.ViewComponents
{
    partial class MainDomain
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
            this.flPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.customButton3 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton2 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton1 = new NoteMakingApp.ViewComponents.CustomButton();
            this.SuspendLayout();
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.Location = new System.Drawing.Point(3, 113);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(934, 394);
            this.flPanel.TabIndex = 3;
            // 
            // customButton3
            // 
            this.customButton3.Location = new System.Drawing.Point(801, 22);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(104, 85);
            this.customButton3.TabIndex = 2;
            // 
            // customButton2
            // 
            this.customButton2.Location = new System.Drawing.Point(691, 22);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(104, 85);
            this.customButton2.TabIndex = 1;
            // 
            // customButton1
            // 
            this.customButton1.Location = new System.Drawing.Point(581, 22);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(104, 85);
            this.customButton1.TabIndex = 0;
            // 
            // MainDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Name = "MainDomain";
            this.Size = new System.Drawing.Size(940, 510);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private System.Windows.Forms.FlowLayoutPanel flPanel;
    }
}
