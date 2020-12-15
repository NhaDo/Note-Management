
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
            this.mainDomain1 = new NoteMakingApp.ViewComponents.MainDomain();
            this.accountSubwindow2 = new NoteMakingApp.ViewComponents.AccountSubwindow();
            this.navigationBar = new NoteMakingApp.ViewComponents.NavigationBar();
            this.registerPanel = new NoteMakingApp.ViewComponents.AccountRegister();
            this.loginPanel1 = new NoteMakingApp.ViewComponents.LoginPanel();
            this.SuspendLayout();
            // 
            // mainDomain1
            // 
            this.mainDomain1.Location = new System.Drawing.Point(307, 28);
            this.mainDomain1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.mainDomain1.Name = "mainDomain1";
            this.mainDomain1.Size = new System.Drawing.Size(1058, 638);
            this.mainDomain1.TabIndex = 7;
            this.mainDomain1.Visible = false;
            // 
            // accountSubwindow2
            // 
            this.accountSubwindow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountSubwindow2.Location = new System.Drawing.Point(286, 0);
            this.accountSubwindow2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.accountSubwindow2.Name = "accountSubwindow2";
            this.accountSubwindow2.Size = new System.Drawing.Size(1079, 665);
            this.accountSubwindow2.TabIndex = 6;
            this.accountSubwindow2.Visible = false;
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.navigationBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationBar.Location = new System.Drawing.Point(0, 0);
            this.navigationBar.Margin = new System.Windows.Forms.Padding(6);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(100, 668);
            this.navigationBar.TabIndex = 4;
            this.navigationBar.Visible = false;
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.registerPanel.ForeColor = System.Drawing.Color.Silver;
            this.registerPanel.Location = new System.Drawing.Point(338, 132);
            this.registerPanel.Margin = new System.Windows.Forms.Padding(6);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(703, 494);
            this.registerPanel.TabIndex = 2;
            this.registerPanel.Visible = false;
            // 
            // loginPanel1
            // 
            this.loginPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loginPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel1.Location = new System.Drawing.Point(338, 132);
            this.loginPanel1.Margin = new System.Windows.Forms.Padding(6);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(703, 430);
            this.loginPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1368, 668);
            this.Controls.Add(this.mainDomain1);
            this.Controls.Add(this.accountSubwindow2);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.loginPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        private void InitAccountSubwindow()
        {
            this.accountSubwindow1 = NoteMakingApp.ViewComponents.AccountSubwindow.GetInstance();
            // 
            // accountSubwindow1
            // 
            this.accountSubwindow1.Location = new System.Drawing.Point(290, 92);
            this.accountSubwindow1.Name = "accountSubwindow1";
            this.accountSubwindow1.Size = new System.Drawing.Size(600, 257);
            this.accountSubwindow1.TabIndex = 5;
            // add controls
            this.Controls.Add(this.accountSubwindow1);
        }

        #endregion

        private LoginPanel loginPanel1;
        private AccountRegister registerPanel;
        private NavigationBar navigationBar;
        private AccountSubwindow accountSubwindow1;
        private AccountSubwindow accountSubwindow2;
        
        private MainDomain mainDomain1;
    }
}

