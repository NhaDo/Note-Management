using System.Windows.Forms;

namespace NoteMakingApp.ViewComponents
{
    public partial class LoginPanel:UserControl
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
            this.Login = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.iUsername = new System.Windows.Forms.TextBox();
            this.iPassword = new System.Windows.Forms.TextBox();
            this.eUsername = new System.Windows.Forms.Label();
            this.ePassword = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Location = new System.Drawing.Point(192, 13);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(33, 13);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Location = new System.Drawing.Point(60, 54);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(55, 13);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(60, 102);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(53, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // iUsername
            // 
            this.iUsername.Location = new System.Drawing.Point(156, 47);
            this.iUsername.Name = "iUsername";
            this.iUsername.Size = new System.Drawing.Size(100, 20);
            this.iUsername.TabIndex = 3;
            // 
            // iPassword
            // 
            this.iPassword.Location = new System.Drawing.Point(156, 94);
            this.iPassword.Name = "iPassword";
            this.iPassword.Size = new System.Drawing.Size(100, 20);
            this.iPassword.TabIndex = 4;
            // 
            // eUsername
            // 
            this.eUsername.AutoSize = true;
            this.eUsername.Location = new System.Drawing.Point(153, 70);
            this.eUsername.Name = "eUsername";
            this.eUsername.ForeColor = System.Drawing.Color.Red;
            this.eUsername.Visible = false;
            this.eUsername.Size = new System.Drawing.Size(61, 13);
            this.eUsername.TabIndex = 5;
            this.eUsername.Text = "eUsername";
            // 
            // ePassword
            // 
            this.ePassword.AutoSize = true;
            this.ePassword.Location = new System.Drawing.Point(153, 117);
            this.ePassword.Name = "ePassword";
            this.ePassword.ForeColor = System.Drawing.Color.Red;
            this.ePassword.Visible = false;
            this.ePassword.Size = new System.Drawing.Size(59, 13);
            this.ePassword.TabIndex = 6;
            this.ePassword.Text = "ePassword";
            // 
            // bLogin
            // 
            this.bLogin.Location = new System.Drawing.Point(156, 156);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(75, 23);
            this.bLogin.TabIndex = 7;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.ePassword);
            this.Controls.Add(this.eUsername);
            this.Controls.Add(this.iPassword);
            this.Controls.Add(this.iUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Login);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(428, 204);
            this.Visible = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.TextBox iUsername;
        private System.Windows.Forms.TextBox iPassword;
        private System.Windows.Forms.Label eUsername;
        private System.Windows.Forms.Label ePassword;
        private System.Windows.Forms.Button bLogin;
    }
}
