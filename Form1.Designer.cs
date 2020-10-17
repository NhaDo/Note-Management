
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
            this.navigationBar = new NoteMakingApp.ViewComponents.NavigationBar();
            this.loginPanel1 = new NoteMakingApp.ViewComponents.LoginPanel();
            this.registerPanel = new NoteMakingApp.ViewComponents.AccountRegister();
            this.SuspendLayout();
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.navigationBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.navigationBar.Location = new System.Drawing.Point(1, 2);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(189, 424);
            this.navigationBar.TabIndex = 1;
            this.navigationBar.Visible = false;
            // 
            // loginPanel1
            // 
            this.loginPanel1.Location = new System.Drawing.Point(259, 111);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(428, 192);
            this.loginPanel1.TabIndex = 0;
            // 
            // accountRegister1
            // 
            this.registerPanel.Location = new System.Drawing.Point(299, 111);
            this.registerPanel.Name = "accountRegister1";
            this.registerPanel.Size = new System.Drawing.Size(307, 234);
            this.registerPanel.TabIndex = 2;
            this.registerPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 434);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.loginPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginPanel loginPanel1;
        private NavigationBar navigationBar;
        private AccountRegister registerPanel;
    }
}

