using System.Windows.Forms;

namespace NoteMakingApp.ViewComponents
{
    public partial class LoginPanel : UserControl
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
            this.bRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Login.Location = new System.Drawing.Point(256, 16);
            this.Login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(41, 16);
            this.Login.TabIndex = 0;
            this.Login.Text = "Login";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Username.Location = new System.Drawing.Point(80, 66);
            this.Username.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(71, 16);
            this.Username.TabIndex = 1;
            this.Username.Text = "Username";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Password.Location = new System.Drawing.Point(80, 126);
            this.Password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(68, 16);
            this.Password.TabIndex = 2;
            this.Password.Text = "Password";
            // 
            // iUsername
            // 
            this.iUsername.Location = new System.Drawing.Point(208, 58);
            this.iUsername.Margin = new System.Windows.Forms.Padding(4);
            this.iUsername.Name = "iUsername";
            this.iUsername.Size = new System.Drawing.Size(132, 22);
            this.iUsername.TabIndex = 3;
            // 
            // iPassword
            // 
            this.iPassword.Location = new System.Drawing.Point(208, 116);
            this.iPassword.Margin = new System.Windows.Forms.Padding(4);
            this.iPassword.Name = "iPassword";
            this.iPassword.PasswordChar = '*';
            this.iPassword.Size = new System.Drawing.Size(132, 22);
            this.iPassword.TabIndex = 4;
            // 
            // eUsername
            // 
            this.eUsername.AutoSize = true;
            this.eUsername.ForeColor = System.Drawing.Color.Red;
            this.eUsername.Location = new System.Drawing.Point(204, 86);
            this.eUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eUsername.Name = "eUsername";
            this.eUsername.Size = new System.Drawing.Size(79, 16);
            this.eUsername.TabIndex = 5;
            this.eUsername.Text = "eUsername";
            this.eUsername.Visible = false;
            // 
            // ePassword
            // 
            this.ePassword.AutoSize = true;
            this.ePassword.ForeColor = System.Drawing.Color.Red;
            this.ePassword.Location = new System.Drawing.Point(204, 144);
            this.ePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ePassword.Name = "ePassword";
            this.ePassword.Size = new System.Drawing.Size(76, 16);
            this.ePassword.TabIndex = 6;
            this.ePassword.Text = "ePassword";
            this.ePassword.Visible = false;
            // 
            // bLogin
            // 
            this.bLogin.ForeColor = System.Drawing.Color.Black;
            this.bLogin.Location = new System.Drawing.Point(129, 193);
            this.bLogin.Margin = new System.Windows.Forms.Padding(4);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(100, 28);
            this.bLogin.TabIndex = 7;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = true;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bRegister
            // 
            this.bRegister.ForeColor = System.Drawing.Color.Black;
            this.bRegister.Location = new System.Drawing.Point(276, 193);
            this.bRegister.Margin = new System.Windows.Forms.Padding(4);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(100, 28);
            this.bRegister.TabIndex = 8;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.ePassword);
            this.Controls.Add(this.eUsername);
            this.Controls.Add(this.iPassword);
            this.Controls.Add(this.iUsername);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.Login);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(571, 251);
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
        private Button bRegister;
    }
}
