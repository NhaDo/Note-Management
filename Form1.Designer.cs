
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
            this.avatarEditor1 = new NoteMakingApp.ViewComponents.AvatarEditor();
            this.mainDomain1 = new NoteMakingApp.ViewComponents.MainDomain();
            this.accountSubwindow2 = new NoteMakingApp.ViewComponents.AccountSubwindow();
            this.navigationBar = new NoteMakingApp.ViewComponents.NavigationBar();
            this.registerPanel = new NoteMakingApp.ViewComponents.AccountRegister();
            this.loginPanel1 = new NoteMakingApp.ViewComponents.LoginPanel();
            this.networkSubWindow1 = new NoteMakingApp.ViewComponents.Network.NetworkSubWindow();
            this.SuspendLayout();
            // 
            // avatarEditor1
            // 
            this.avatarEditor1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.avatarEditor1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.avatarEditor1.Location = new System.Drawing.Point(330, 76);
            this.avatarEditor1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.avatarEditor1.Name = "avatarEditor1";
            this.avatarEditor1.Size = new System.Drawing.Size(492, 351);
            this.avatarEditor1.TabIndex = 8;
            this.avatarEditor1.Visible = false;
            // 
            // mainDomain1
            // 
            this.mainDomain1.Location = new System.Drawing.Point(67, 0);
            this.mainDomain1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.mainDomain1.Name = "mainDomain1";
            this.mainDomain1.Size = new System.Drawing.Size(843, 434);
            this.mainDomain1.TabIndex = 7;
            this.mainDomain1.Visible = false;
            // 
            // accountSubwindow2
            // 
            this.accountSubwindow2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.accountSubwindow2.Location = new System.Drawing.Point(190, 0);
            this.accountSubwindow2.Name = "accountSubwindow2";
            this.accountSubwindow2.Size = new System.Drawing.Size(719, 432);
            this.accountSubwindow2.TabIndex = 6;
            this.accountSubwindow2.Visible = false;
            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.navigationBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationBar.Location = new System.Drawing.Point(0, 0);
            this.navigationBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(67, 434);
            this.navigationBar.TabIndex = 4;
            this.navigationBar.Visible = false;
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.registerPanel.ForeColor = System.Drawing.Color.Silver;
            this.registerPanel.Location = new System.Drawing.Point(225, 86);
            this.registerPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(469, 321);
            this.registerPanel.TabIndex = 2;
            this.registerPanel.Visible = false;
            // 
            // loginPanel1
            // 
            this.loginPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.loginPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel1.Location = new System.Drawing.Point(225, 86);
            this.loginPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(469, 280);
            this.loginPanel1.TabIndex = 0;
            // 
            // networkSubWindow1
            // 
            this.networkSubWindow1.Location = new System.Drawing.Point(290, 91);
            this.networkSubWindow1.Name = "networkSubWindow1";
            this.networkSubWindow1.Size = new System.Drawing.Size(477, 316);
            this.networkSubWindow1.TabIndex = 9;
            this.networkSubWindow1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(912, 434);
            this.Controls.Add(this.networkSubWindow1);
            this.Controls.Add(this.avatarEditor1);
            this.Controls.Add(this.mainDomain1);
            this.Controls.Add(this.accountSubwindow2);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.loginPanel1);
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
        private AvatarEditor avatarEditor1;
        private ViewComponents.Network.NetworkSubWindow networkSubWindow1;
    }
}

