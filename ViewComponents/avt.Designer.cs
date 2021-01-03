namespace NoteMakingApp.ViewComponents
{
    partial class avt
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
            this.bEdit = new System.Windows.Forms.Button();
            this.avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // bEdit
            // 
            this.bEdit.BackColor = System.Drawing.Color.Orange;
            this.bEdit.BackgroundImage = global::NoteMakingApp.Properties.Resources.pencil1;
            this.bEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEdit.ForeColor = System.Drawing.Color.Orange;
            this.bEdit.Location = new System.Drawing.Point(105, 0);
            this.bEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(28, 31);
            this.bEdit.TabIndex = 4;
            this.bEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bEdit.UseVisualStyleBackColor = false;
            this.bEdit.Visible = false;
            // 
            // avatar
            // 
            this.avatar.Image = global::NoteMakingApp.Properties.Resources._802043_man_512x512;
            this.avatar.Location = new System.Drawing.Point(0, 0);
            this.avatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.avatar.Name = "avatar";
            this.avatar.Size = new System.Drawing.Size(114, 124);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 3;
            this.avatar.TabStop = false;
            // 
            // avt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.avatar);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "avt";
            this.Size = new System.Drawing.Size(134, 124);
            this.MouseEnter += new System.EventHandler(this.avt_MouseHover);
            this.MouseLeave += new System.EventHandler(this.avt_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bEdit;
        public System.Windows.Forms.PictureBox avatar;
    }
}
