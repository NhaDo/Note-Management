namespace NoteMakingApp.ViewComponents
{
    partial class CommandBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommandBar));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customButton1 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton2 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton3 = new NoteMakingApp.ViewComponents.CustomButton();
            this.ButtonImage = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "Dog",
            "Cat",
            "Buffalo",
            "Duck",
            "Pig",
            "Snake",
            "Goat",
            "Dragon",
            "Nasus"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.Location = new System.Drawing.Point(19, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 22);
            this.textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteMakingApp.Properties.Resources.search3;
            this.pictureBox1.Location = new System.Drawing.Point(270, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // customButton1
            // 
            this.customButton1.Location = new System.Drawing.Point(362, 3);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(109, 86);
            this.customButton1.TabIndex = 5;
            this.customButton1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.customButton1_MouseClick);
            // 
            // customButton2
            // 
            this.customButton2.Location = new System.Drawing.Point(477, 3);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(109, 86);
            this.customButton2.TabIndex = 6;
            // 
            // customButton3
            // 
            this.customButton3.Location = new System.Drawing.Point(592, 3);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(109, 86);
            this.customButton3.TabIndex = 7;
            // 
            // ButtonImage
            // 
            this.ButtonImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ButtonImage.ImageStream")));
            this.ButtonImage.TransparentColor = System.Drawing.Color.Transparent;
            this.ButtonImage.Images.SetKeyName(0, "add.png");
            this.ButtonImage.Images.SetKeyName(1, "edit.png");
            this.ButtonImage.Images.SetKeyName(2, "delete.png");
            // 
            // CommandBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "CommandBar";
            this.Size = new System.Drawing.Size(704, 100);
            this.Load += new System.EventHandler(this.CommandBar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private CustomButton customButton1;
        private CustomButton customButton2;
        private CustomButton customButton3;
        private System.Windows.Forms.ImageList ButtonImage;
    }
}
