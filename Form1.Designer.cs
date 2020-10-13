
using NoteMakingApp.Models;
using NoteMakingApp.ViewComponents;

namespace NoteMakingApp
{
    partial class Form1
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
            CloseSessions();
        }
        private void CloseSessions()
        {
            DataHandle.closeDbConnection();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.loginPanel1 = new NoteMakingApp.ViewComponents.LoginPanel();
            this.navigationBar = new NoteMakingApp.ViewComponents.NavigationBar();
            this.SuspendLayout();
            // 
            // loginPanel1
            // 
            this.loginPanel1.Location = new System.Drawing.Point(259, 111);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(428, 192);
            this.loginPanel1.Visible = true;
            this.loginPanel1.TabIndex = 0;
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.navigationBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.navigationBar.Location = new System.Drawing.Point(1, 2);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(189, 424);
            this.navigationBar.Visible = false;
            this.navigationBar.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 434);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Visible = true;
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.loginPanel1);
            this.ResumeLayout(false);

        }

        #endregion

        private LoginPanel loginPanel1;
        private NavigationBar navigationBar;
    }
}

