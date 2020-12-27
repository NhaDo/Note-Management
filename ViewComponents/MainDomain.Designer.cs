﻿namespace NoteMakingApp.ViewComponents
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
            this.customButton2 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton3 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton1 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton4 = new NoteMakingApp.ViewComponents.CustomButton();
            this.SuspendLayout();
            // 
            // flPanel
            // 
            this.flPanel.AutoScroll = true;
            this.flPanel.Location = new System.Drawing.Point(3, 108);
            this.flPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flPanel.Name = "flPanel";
            this.flPanel.Size = new System.Drawing.Size(1285, 551);
            this.flPanel.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(612, 11);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 62);
            this.button1.TabIndex = 12;
            this.button1.Text = "PROJECT";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // customButton2
            // 
            this.customButton2.BackColor = System.Drawing.Color.Transparent;
            this.customButton2.Location = new System.Drawing.Point(994, 2);
            this.customButton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(79, 106);
            this.customButton2.TabIndex = 10;
            // 
            // customButton3
            // 
            this.customButton3.BackColor = System.Drawing.Color.Transparent;
            this.customButton3.Location = new System.Drawing.Point(1080, 2);
            this.customButton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(79, 106);
            this.customButton3.TabIndex = 11;
            // 
            // customButton1
            // 
            this.customButton1.BackColor = System.Drawing.Color.Transparent;
            this.customButton1.Location = new System.Drawing.Point(1166, 2);
            this.customButton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(79, 106);
            this.customButton1.TabIndex = 9;
            // 
            // customButton4
            // 
            this.customButton4.Location = new System.Drawing.Point(777, 0);
            this.customButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.customButton4.Name = "customButton4";
            this.customButton4.Size = new System.Drawing.Size(76, 104);
            this.customButton4.TabIndex = 14;
            // 
            // MainDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.flPanel);
            this.Controls.Add(this.customButton1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainDomain";
            this.Size = new System.Drawing.Size(1264, 668);
            this.Load += new System.EventHandler(this.MainDomain_Load);
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
    }
}
