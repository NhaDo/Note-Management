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
            this.button = new System.Windows.Forms.Button();
            this.detail = new System.Windows.Forms.Label();
            this.buttonImage = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(66, 60);
            this.button.TabIndex = 0;
            this.button.Text = "button";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            this.button.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // detail
            // 
            this.detail.AutoSize = true;
            this.detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail.Location = new System.Drawing.Point(31, 63);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(49, 19);
            this.detail.TabIndex = 1;
            this.detail.Text = "detail";
            // 
            // buttonImage
            // 
            this.buttonImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("buttonImage.ImageStream")));
            this.buttonImage.TransparentColor = System.Drawing.Color.Transparent;
            this.buttonImage.Images.SetKeyName(0, "plus.png");
            this.buttonImage.Images.SetKeyName(1, "plus (1).png");
            this.buttonImage.Images.SetKeyName(2, "edit.png");
            this.buttonImage.Images.SetKeyName(3, "edit (1).png");
            this.buttonImage.Images.SetKeyName(4, "delete.png");
            this.buttonImage.Images.SetKeyName(5, "delete (2).png");
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detail);
            this.Controls.Add(this.button);
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(109, 86);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label detail;
        private System.Windows.Forms.ImageList buttonImage;
    }
}
