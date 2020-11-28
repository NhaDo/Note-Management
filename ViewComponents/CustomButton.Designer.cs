namespace NoteMakingApp.ViewComponents
{
    partial class CustomButton
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomButton));
            this.CustomBtn = new System.Windows.Forms.Button();
            this.lbDetail = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // CustomBtn
            // 
            this.CustomBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CustomBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomBtn.Location = new System.Drawing.Point(0, 0);
            this.CustomBtn.Name = "CustomBtn";
            this.CustomBtn.Size = new System.Drawing.Size(66, 60);
            this.CustomBtn.TabIndex = 0;
            this.CustomBtn.Text = "button1";
            this.CustomBtn.UseVisualStyleBackColor = true;
            this.CustomBtn.Click += new System.EventHandler(this.button_Click);
            this.CustomBtn.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.CustomBtn.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.CustomBtn.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // lbDetail
            // 
            this.lbDetail.AutoSize = true;
            this.lbDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetail.Location = new System.Drawing.Point(20, 63);
            this.lbDetail.Name = "lbDetail";
            this.lbDetail.Size = new System.Drawing.Size(46, 17);
            this.lbDetail.TabIndex = 1;
            this.lbDetail.Text = "label1";
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "add (1).png");
            this.imageList.Images.SetKeyName(1, "plus (1).png");
            this.imageList.Images.SetKeyName(2, "edit.png");
            this.imageList.Images.SetKeyName(3, "edit (1).png");
            this.imageList.Images.SetKeyName(4, "delete.png");
            this.imageList.Images.SetKeyName(5, "delete (2).png");
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbDetail);
            this.Controls.Add(this.CustomBtn);
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(68, 83);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CustomBtn;
        private System.Windows.Forms.Label lbDetail;
        private System.Windows.Forms.ImageList imageList;
    }
}
