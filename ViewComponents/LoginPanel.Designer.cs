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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPanel));
            this.iUsername = new System.Windows.Forms.TextBox();
            this.iPassword = new System.Windows.Forms.TextBox();
            this.eUsername = new System.Windows.Forms.Label();
            this.ePassword = new System.Windows.Forms.Label();
            this.bLogin = new System.Windows.Forms.Button();
            this.bRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.LOGIN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // iUsername
            // 
            this.iUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iUsername.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.iUsername.ForeColor = System.Drawing.Color.Transparent;
            this.iUsername.Location = new System.Drawing.Point(212, 150);
            this.iUsername.Margin = new System.Windows.Forms.Padding(4);
            this.iUsername.Name = "iUsername";
            this.iUsername.Size = new System.Drawing.Size(187, 22);
            this.iUsername.TabIndex = 3;
            this.iUsername.Text = "username";
            // 
            // iPassword
            // 
            this.iPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.iPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iPassword.Location = new System.Drawing.Point(212, 223);
            this.iPassword.Margin = new System.Windows.Forms.Padding(4);
            this.iPassword.Name = "iPassword";
            this.iPassword.PasswordChar = '*';
            this.iPassword.Size = new System.Drawing.Size(218, 22);
            this.iPassword.TabIndex = 4;
            // 
            // eUsername
            // 
            this.eUsername.AutoSize = true;
            this.eUsername.ForeColor = System.Drawing.Color.Red;
            this.eUsername.Location = new System.Drawing.Point(208, 178);
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
            this.ePassword.Location = new System.Drawing.Point(208, 251);
            this.ePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ePassword.Name = "ePassword";
            this.ePassword.Size = new System.Drawing.Size(76, 16);
            this.ePassword.TabIndex = 6;
            this.ePassword.Text = "ePassword";
            this.ePassword.Visible = false;
            // 
            // bLogin
            // 
            this.bLogin.BackColor = System.Drawing.Color.Orange;
            this.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.bLogin.Location = new System.Drawing.Point(133, 285);
            this.bLogin.Margin = new System.Windows.Forms.Padding(4);
            this.bLogin.Name = "bLogin";
            this.bLogin.Size = new System.Drawing.Size(100, 28);
            this.bLogin.TabIndex = 7;
            this.bLogin.Text = "Login";
            this.bLogin.UseVisualStyleBackColor = false;
            this.bLogin.Click += new System.EventHandler(this.bLogin_Click);
            // 
            // bRegister
            // 
            this.bRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bRegister.ForeColor = System.Drawing.Color.Transparent;
            this.bRegister.Location = new System.Drawing.Point(280, 285);
            this.bRegister.Margin = new System.Windows.Forms.Padding(4);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(100, 28);
            this.bRegister.TabIndex = 8;
            this.bRegister.Text = "Register";
            this.bRegister.UseVisualStyleBackColor = true;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(133, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(133, 199);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 46);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(133, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 1);
            this.panel1.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(133, 247);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 1);
            this.panel2.TabIndex = 12;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(399, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(226, 221);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN.Font = new System.Drawing.Font("Aztek", 25F);
            this.LOGIN.Location = new System.Drawing.Point(186, 0);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(194, 74);
            this.LOGIN.TabIndex = 14;
            this.LOGIN.Text = "LOGIN";
            this.LOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LoginPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.bLogin);
            this.Controls.Add(this.ePassword);
            this.Controls.Add(this.eUsername);
            this.Controls.Add(this.iPassword);
            this.Controls.Add(this.iUsername);
            this.Controls.Add(this.pictureBox3);
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginPanel";
            this.Size = new System.Drawing.Size(625, 344);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox iUsername;
        private System.Windows.Forms.TextBox iPassword;
        private System.Windows.Forms.Label eUsername;
        private System.Windows.Forms.Label ePassword;
        private System.Windows.Forms.Button bLogin;
        private Button bRegister;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label LOGIN;
    }
}
