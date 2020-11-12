namespace NoteMakingApp.ViewComponents
{
    partial class AccountRegister
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
            this.lPassword = new System.Windows.Forms.Label();
            this.uLabel = new System.Windows.Forms.Label();
            this.lConfirmation = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.iUsername = new System.Windows.Forms.TextBox();
            this.iPassword = new System.Windows.Forms.TextBox();
            this.iConfirmation = new System.Windows.Forms.TextBox();
            this.eUser = new System.Windows.Forms.Label();
            this.ePassword = new System.Windows.Forms.Label();
            this.eConfirmation = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lPassword.Location = new System.Drawing.Point(11, 119);
            this.lPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(68, 16);
            this.lPassword.TabIndex = 0;
            this.lPassword.Text = "Password";
            // 
            // uLabel
            // 
            this.uLabel.AutoSize = true;
            this.uLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.uLabel.Location = new System.Drawing.Point(11, 59);
            this.uLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uLabel.Name = "uLabel";
            this.uLabel.Size = new System.Drawing.Size(71, 16);
            this.uLabel.TabIndex = 1;
            this.uLabel.Text = "Username";
            // 
            // lConfirmation
            // 
            this.lConfirmation.AutoSize = true;
            this.lConfirmation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.lConfirmation.Location = new System.Drawing.Point(11, 181);
            this.lConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lConfirmation.Name = "lConfirmation";
            this.lConfirmation.Size = new System.Drawing.Size(145, 16);
            this.lConfirmation.TabIndex = 2;
            this.lConfirmation.Text = "Password Confirmation";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Title.Location = new System.Drawing.Point(161, 25);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(59, 16);
            this.Title.TabIndex = 3;
            this.Title.Text = "Register";
            // 
            // iUsername
            // 
            this.iUsername.Location = new System.Drawing.Point(172, 55);
            this.iUsername.Margin = new System.Windows.Forms.Padding(4);
            this.iUsername.Name = "iUsername";
            this.iUsername.Size = new System.Drawing.Size(132, 22);
            this.iUsername.TabIndex = 4;
            // 
            // iPassword
            // 
            this.iPassword.Location = new System.Drawing.Point(172, 119);
            this.iPassword.Margin = new System.Windows.Forms.Padding(4);
            this.iPassword.Name = "iPassword";
            this.iPassword.PasswordChar = '*';
            this.iPassword.Size = new System.Drawing.Size(132, 22);
            this.iPassword.TabIndex = 5;
            // 
            // iConfirmation
            // 
            this.iConfirmation.Location = new System.Drawing.Point(172, 172);
            this.iConfirmation.Margin = new System.Windows.Forms.Padding(4);
            this.iConfirmation.Name = "iConfirmation";
            this.iConfirmation.PasswordChar = '*';
            this.iConfirmation.Size = new System.Drawing.Size(132, 22);
            this.iConfirmation.TabIndex = 6;
            // 
            // eUser
            // 
            this.eUser.AutoSize = true;
            this.eUser.ForeColor = System.Drawing.Color.Red;
            this.eUser.Location = new System.Drawing.Point(168, 84);
            this.eUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eUser.Name = "eUser";
            this.eUser.Size = new System.Drawing.Size(198, 16);
            this.eUser.TabIndex = 7;
            this.eUser.Text = "Your Username is inappropriate";
            this.eUser.Visible = false;
            // 
            // ePassword
            // 
            this.ePassword.AutoSize = true;
            this.ePassword.ForeColor = System.Drawing.Color.Red;
            this.ePassword.Location = new System.Drawing.Point(168, 148);
            this.ePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ePassword.Name = "ePassword";
            this.ePassword.Size = new System.Drawing.Size(194, 16);
            this.ePassword.TabIndex = 8;
            this.ePassword.Text = "Your password is inappropriate";
            this.ePassword.Visible = false;
            // 
            // eConfirmation
            // 
            this.eConfirmation.AutoSize = true;
            this.eConfirmation.ForeColor = System.Drawing.Color.Red;
            this.eConfirmation.Location = new System.Drawing.Point(168, 201);
            this.eConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eConfirmation.Name = "eConfirmation";
            this.eConfirmation.Size = new System.Drawing.Size(184, 16);
            this.eConfirmation.TabIndex = 9;
            this.eConfirmation.Text = "Your passwords do not match";
            this.eConfirmation.Visible = false;
            // 
            // Register
            // 
            this.Register.Location = new System.Drawing.Point(205, 240);
            this.Register.Margin = new System.Windows.Forms.Padding(4);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(100, 28);
            this.Register.TabIndex = 10;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = true;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // bBack
            // 
            this.bBack.Location = new System.Drawing.Point(80, 240);
            this.bBack.Margin = new System.Windows.Forms.Padding(4);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(100, 28);
            this.bBack.TabIndex = 11;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // AccountRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.eConfirmation);
            this.Controls.Add(this.ePassword);
            this.Controls.Add(this.eUser);
            this.Controls.Add(this.iConfirmation);
            this.Controls.Add(this.iPassword);
            this.Controls.Add(this.iUsername);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.lConfirmation);
            this.Controls.Add(this.uLabel);
            this.Controls.Add(this.lPassword);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AccountRegister";
            this.Size = new System.Drawing.Size(409, 288);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.Label uLabel;
        private System.Windows.Forms.Label lConfirmation;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox iUsername;
        private System.Windows.Forms.TextBox iPassword;
        private System.Windows.Forms.TextBox iConfirmation;
        private System.Windows.Forms.Label eUser;
        private System.Windows.Forms.Label ePassword;
        private System.Windows.Forms.Label eConfirmation;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button bBack;
    }
}
