namespace NoteMakingApp.ViewComponents
{
    partial class MainDomain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDomain));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.ButtonImage = new System.Windows.Forms.ImageList(this.components);
            this.customButton3 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton2 = new NoteMakingApp.ViewComponents.CustomButton();
            this.customButton1 = new NoteMakingApp.ViewComponents.CustomButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(828, 424);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteMakingApp.Properties.Resources.search3;
            this.pictureBox1.Location = new System.Drawing.Point(364, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 22);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
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
            this.textBox1.Location = new System.Drawing.Point(88, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(276, 22);
            this.textBox1.TabIndex = 8;
            // 
            // ButtonImage
            // 
            this.ButtonImage.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ButtonImage.ImageStream")));
            this.ButtonImage.TransparentColor = System.Drawing.Color.Transparent;
            this.ButtonImage.Images.SetKeyName(0, "add.png");
            this.ButtonImage.Images.SetKeyName(1, "edit.png");
            this.ButtonImage.Images.SetKeyName(2, "delete.png");
            // 
            // customButton3
            // 
            this.customButton3.Location = new System.Drawing.Point(722, 9);
            this.customButton3.Name = "customButton3";
            this.customButton3.Size = new System.Drawing.Size(109, 86);
            this.customButton3.TabIndex = 12;
            // 
            // customButton2
            // 
            this.customButton2.Location = new System.Drawing.Point(607, 9);
            this.customButton2.Name = "customButton2";
            this.customButton2.Size = new System.Drawing.Size(109, 86);
            this.customButton2.TabIndex = 11;
            // 
            // customButton1
            // 
            this.customButton1.Location = new System.Drawing.Point(492, 9);
            this.customButton1.Name = "customButton1";
            this.customButton1.Size = new System.Drawing.Size(109, 86);
            this.customButton1.TabIndex = 10;
            // 
            // MainDomain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.customButton1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainDomain";
            this.Size = new System.Drawing.Size(834, 536);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private CustomButton customButton3;
        private CustomButton customButton2;
        private CustomButton customButton1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList ButtonImage;
    }
}
