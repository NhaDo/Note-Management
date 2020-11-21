
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
            this.commandBar1 = new NoteMakingApp.ViewComponents.CommandBar();
            this.registerPanel = new NoteMakingApp.ViewComponents.AccountRegister();
            this.loginPanel1 = new NoteMakingApp.ViewComponents.LoginPanel();
            this.SuspendLayout();

            // 
            // navigationBar
            // 
            this.navigationBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.navigationBar.Location = new System.Drawing.Point(1, 2);
            this.navigationBar.Name = "navigationBar";
            this.navigationBar.Size = new System.Drawing.Size(171, 389);
            this.navigationBar.TabIndex = 4;
            this.navigationBar.Visible = false;
            // 
            // commandBar1
            // 
            this.commandBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.commandBar1.Location = new System.Drawing.Point(310, 31);
            this.commandBar1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.commandBar1.Name = "commandBar1";
            this.commandBar1.Size = new System.Drawing.Size(600, 56);
            this.commandBar1.TabIndex = 3;
            this.commandBar1.Visible = false;
            // 
            // registerPanel
            // 
            this.registerPanel.Location = new System.Drawing.Point(299, 111);
            this.registerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Size = new System.Drawing.Size(307, 234);
            this.registerPanel.TabIndex = 2;
            this.registerPanel.Visible = false;
            // 
            // loginPanel1
            // 
            this.loginPanel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.loginPanel1.Location = new System.Drawing.Point(259, 111);
            this.loginPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.loginPanel1.Name = "loginPanel1";
            this.loginPanel1.Size = new System.Drawing.Size(428, 192);
            this.loginPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(912, 434);
            this.Controls.Add(this.navigationBar);
            this.Controls.Add(this.commandBar1);
            this.Controls.Add(this.registerPanel);
            this.Controls.Add(this.loginPanel1);
            this.Name = "Form1";
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
        private CommandBar commandBar1;
        private NavigationBar navigationBar;
        private AccountSubwindow accountSubwindow1;
    }
}

