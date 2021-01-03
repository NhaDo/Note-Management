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
            this.username = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bEdit = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.PictureBox();
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
            this.username.Location = new System.Drawing.Point(30, 145);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(119, 27);
            this.username.TabIndex = 1;
            this.username.Text = "username";
            this.username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.username.Paint += new System.Windows.Forms.PaintEventHandler(this.username_paint);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Orange;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.panel1.Location = new System.Drawing.Point(159, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 662);
            this.panel1.TabIndex = 12;
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.Orange;
            this.bEdit.BackgroundImage = global::NoteMakingApp.Properties.Resources.pencil1;
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.ForeColor = System.Drawing.Color.Orange;
            this.bEdit.Location = new System.Drawing.Point(69, 35);
            this.bEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(28, 31);
            this.bEdit.TabIndex = 2;
            this.bEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Visible = false;
            this.bEdit.Click += new System.EventHandler(this.bEdit_Click);
            this.bEdit.MouseLeave += new System.EventHandler(this.bEdit_MosueLeave);
            // 
            // avatar
            // 
            this.avatar.Image = global::NoteMakingApp.Properties.Resources._802043_man_512x512;
            this.avatar.Location = new System.Drawing.Point(19, 49);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(60, 60);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            this.avatar.MouseEnter += new System.EventHandler(this.avt_MouseHover);
            // 
            // NavigationBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.avatar);
            this.Controls.Add(this.username);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NavigationBar";
            this.Size = new System.Drawing.Size(100, 688);
            this.MouseHover += new System.EventHandler(this.navBar_MouseHover);
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
        private System.Windows.Forms.Panel panel1;
    }
}
