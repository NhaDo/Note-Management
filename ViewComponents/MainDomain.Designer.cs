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
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customButton4 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton2 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton3 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton1 = new NoteMakingApp.ViewComponents.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.Location = new System.Drawing.Point(3, 86);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(1142, 441);
            this.flPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(241, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 33);
            this.button1.TabIndex = 12;
            this.button1.Text = "PROJECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = global::NoteMakingApp.Properties.Resources.free_exit_logout_icon_2857_thumb;
            this.pictureBox1.Location = new System.Drawing.Point(687, 6);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(55, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // customButton4
            // 
            this.customButton4.Location = new System.Drawing.Point(807, 2);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(68, 83);
            this.customButton4.TabIndex = 14;
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Transparent;
            this.customButton2.Location = new System.Drawing.Point(884, 2);
            this.customButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(70, 85);
            this.customButton2.TabIndex = 10;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.Transparent;
            this.customButton3.Location = new System.Drawing.Point(960, 2);
            this.customButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(70, 85);
            this.customButton3.TabIndex = 11;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.Location = new System.Drawing.Point(1036, 2);
            this.customButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(70, 85);
            this.customButton1.TabIndex = 9;
            // 
            // MainDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.customButton1);
            this.Name = "MainDomain";
            this.Size = new System.Drawing.Size(1124, 534);
            this.Load += new System.EventHandler(this.MainDomain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flPanel;
        private CustomButton customButton3;
        private CustomButton customButton2;
        private CustomButton customButton1;
        private System.Windows.Forms.Button button1;
        private Project.ListProject listProject1;
        private CustomButton customButton4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
