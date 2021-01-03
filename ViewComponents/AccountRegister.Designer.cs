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
            this.eUser = new System.Windows.Forms.Label();
            this.ePassword = new System.Windows.Forms.Label();
            this.eConfirmation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LOGIN = new System.Windows.Forms.Label();
            this.iUsername = new System.Windows.Forms.TextBox();
            this.iPassword = new System.Windows.Forms.TextBox();
            this.iConfirmation = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Register = new System.Windows.Forms.Button();
            this.bBack = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // eUser
            // 
            this.eUser.AutoSize = true;
            this.eUser.ForeColor = System.Drawing.Color.Red;
            this.eUser.Location = new System.Drawing.Point(224, 179);
            this.eUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eUser.Name = "eUser";
            this.eUser.Size = new System.Drawing.Size(233, 20);
            this.eUser.TabIndex = 7;
            this.eUser.Text = "Your Username is inappropriate";
            this.eUser.Visible = false;
            // 
            // ePassword
            // 
            this.ePassword.AutoSize = true;
            this.ePassword.ForeColor = System.Drawing.Color.Red;
            this.ePassword.Location = new System.Drawing.Point(224, 269);
            this.ePassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ePassword.Name = "ePassword";
            this.ePassword.Size = new System.Drawing.Size(227, 20);
            this.ePassword.TabIndex = 8;
            this.ePassword.Text = "Your password is inappropriate";
            this.ePassword.Visible = false;
            // 
            // eConfirmation
            // 
            this.eConfirmation.AutoSize = true;
            this.eConfirmation.ForeColor = System.Drawing.Color.Red;
            this.eConfirmation.Location = new System.Drawing.Point(225, 366);
            this.eConfirmation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eConfirmation.Name = "eConfirmation";
            this.eConfirmation.Size = new System.Drawing.Size(220, 20);
            this.eConfirmation.TabIndex = 9;
            this.eConfirmation.Text = "Your passwords do not match";
            this.eConfirmation.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(156, 174);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(338, 1);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Location = new System.Drawing.Point(156, 264);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(338, 1);
            this.panel2.TabIndex = 16;
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.LOGIN.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LOGIN.Location = new System.Drawing.Point(162, 0);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(280, 58);
            this.LOGIN.TabIndex = 17;
            this.LOGIN.Text = "REGISTER";
            this.LOGIN.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iUsername
            // 
            this.iUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iUsername.Font = new System.Drawing.Font("Arial Narrow", 10F);
            this.iUsername.ForeColor = System.Drawing.Color.Transparent;
            this.iUsername.Location = new System.Drawing.Point(236, 142);
            this.iUsername.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iUsername.Name = "iUsername";
            this.iUsername.Size = new System.Drawing.Size(210, 23);
            this.iUsername.TabIndex = 18;
            // 
            // iPassword
            // 
            this.iPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iPassword.Font = new System.Drawing.Font("Arial", 10F);
            this.iPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iPassword.Location = new System.Drawing.Point(228, 228);
            this.iPassword.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iPassword.Name = "iPassword";
            this.iPassword.PasswordChar = '*';
            this.iPassword.Size = new System.Drawing.Size(245, 23);
            this.iPassword.TabIndex = 19;
            // 
            // iConfirmation
            // 
            this.iConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.iConfirmation.Font = new System.Drawing.Font("Arial", 10F);
            this.iConfirmation.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iConfirmation.Location = new System.Drawing.Point(227, 325);
            this.iConfirmation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iConfirmation.Name = "iConfirmation";
            this.iConfirmation.PasswordChar = '*';
            this.iConfirmation.Size = new System.Drawing.Size(245, 23);
            this.iConfirmation.TabIndex = 22;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Location = new System.Drawing.Point(155, 361);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(338, 1);
            this.panel3.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.059701F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SkyBlue;
            this.label1.Location = new System.Drawing.Point(518, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 22);
            this.label1.TabIndex = 23;
            this.label1.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 8.059701F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.SkyBlue;
            this.label2.Location = new System.Drawing.Point(516, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 22);
            this.label2.TabIndex = 24;
            this.label2.Text = "password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 8.059701F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Sienna;
            this.label3.Location = new System.Drawing.Point(516, 338);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 22);
            this.label3.TabIndex = 25;
            this.label3.Text = "confirm password";
            // 
            // Register
            // 
            this.Register.BackColor = System.Drawing.Color.Orange;
            this.Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Register.Location = new System.Drawing.Point(350, 435);
            this.Register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(112, 35);
            this.Register.TabIndex = 26;
            this.Register.Text = "Register";
            this.Register.UseVisualStyleBackColor = false;
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // bBack
            // 
            this.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBack.ForeColor = System.Drawing.Color.Transparent;
            this.bBack.Location = new System.Drawing.Point(177, 435);
            this.bBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bBack.Name = "bBack";
            this.bBack.Size = new System.Drawing.Size(112, 35);
            this.bBack.TabIndex = 27;
            this.bBack.Text = "Back";
            this.bBack.UseVisualStyleBackColor = true;
            this.bBack.Click += new System.EventHandler(this.bBack_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::NoteMakingApp.Properties.Resources.password;
            this.pictureBox3.Location = new System.Drawing.Point(156, 295);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(52, 58);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::NoteMakingApp.Properties.Resources.password;
            this.pictureBox2.Location = new System.Drawing.Point(156, 204);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteMakingApp.Properties.Resources.ACCOUNT;
            this.pictureBox1.Location = new System.Drawing.Point(156, 112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 58);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // AccountRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.bBack);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iConfirmation);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.iPassword);
            this.Controls.Add(this.iUsername);
            this.Controls.Add(this.LOGIN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.eConfirmation);
            this.Controls.Add(this.ePassword);
            this.Controls.Add(this.eUser);
            this.ForeColor = System.Drawing.Color.Silver;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AccountRegister";
            this.Size = new System.Drawing.Size(703, 494);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label eUser;
        private System.Windows.Forms.Label ePassword;
        private System.Windows.Forms.Label eConfirmation;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.TextBox iUsername;
        private System.Windows.Forms.TextBox iPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.TextBox iConfirmation;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Register;
        private System.Windows.Forms.Button bBack;
    }
}
