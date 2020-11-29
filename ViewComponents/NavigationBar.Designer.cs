using System.Collections.Generic;

namespace NoteMakingApp.ViewComponents
{
    partial class NavigationBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NavigationBar));
            this.username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.accountpic = new System.Windows.Forms.PictureBox();
            this.bEdit = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.accountpic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Arial", 12F);
            this.username.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(202)))));
            this.username.Location = new System.Drawing.Point(72, 135);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(113, 26);
            this.username.TabIndex = 1;
            this.username.Text = "username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.Paint += new System.Windows.Forms.PaintEventHandler(this.username_paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(254, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 530);
            this.panel1.TabIndex = 12;
            // 
            // accountpic
            // 
            this.accountpic.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.accountpic.Image = ((System.Drawing.Image)(resources.GetObject("accountpic.Image")));
            this.accountpic.Location = new System.Drawing.Point(39, 135);
            this.accountpic.Name = "accountpic";
            this.accountpic.Size = new System.Drawing.Size(25, 25);
            this.accountpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.accountpic.TabIndex = 10;
            this.accountpic.TabStop = false;
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.Orange;
            this.bEdit.BackgroundImage = global::NoteMakingApp.Properties.Resources.pencil1;
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.ForeColor = System.Drawing.Color.Orange;
            this.bEdit.Location = new System.Drawing.Point(171, 22);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(25, 25);
            this.bEdit.TabIndex = 2;
            this.bEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Visible = false;
            this.bEdit.MouseLeave += new System.EventHandler(this.bEdit_MosueLeave);
            // 
            // avatar
            // 
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.Location = new System.Drawing.Point(87, 22);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(85, 85);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.MouseEnter += new System.EventHandler(this.avt_MouseHover);
            // 
            // NavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.accountpic);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.username);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NavigationBar";
            this.Size = new System.Drawing.Size(255, 550);
            this.MouseHover += new System.EventHandler(this.navBar_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.accountpic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        public void set_username(string username)
        {
            this.username.Text = username;

        }
        private List<NavigationOption> navOptions = new List<NavigationOption>();
        #endregion
        public System.Windows.Forms.Label username;
        public System.Windows.Forms.PictureBox avatar;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.PictureBox accountpic;
        private System.Windows.Forms.Panel panel1;
    }
}
