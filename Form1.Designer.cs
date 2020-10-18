
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
            this.registerPanel = new NoteMakingApp.ViewComponents.AccountRegister();
            this.loginPanel1 = new NoteMakingApp.ViewComponents.LoginPanel();
            this.navigationBar = new NoteMakingApp.ViewComponents.NavigationBar();
            this.SuspendLayout();
            // 
            // registerPanel
            // 
            this.registerPanel.Location = new System.Drawing.Point(399, 137);
            this.registerPanel.Margin = new System.Windows.Forms.Padding(5);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(409, 288);
            this.registerPanel.TabIndex = 2;
            this.registerPanel.Visible = false;
            // 
            // loginPanel1
            // 
            this.loginPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel1.Location = new System.Drawing.Point(345, 137);
            this.loginPanel1.Margin = new System.Windows.Forms.Padding(5);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(571, 236);
            this.loginPanel1.TabIndex = 0;
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.navigationBar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.navigationBar.Location = new System.Drawing.Point(1, 2);
            this.navigationBar.Margin = new System.Windows.Forms.Padding(5);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(252, 522);
            this.navigationBar.TabIndex = 1;
            this.navigationBar.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1216, 534);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.loginPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private LoginPanel loginPanel1;
        private AccountRegister registerPanel;
        private NavigationBar navigationBar;
    }
}

