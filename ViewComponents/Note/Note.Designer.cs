namespace NoteMakingApp.ViewComponents
{
    partial class _Note
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
            this.lbTittle = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(39)))));
            this.lbTittle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.Location = new System.Drawing.Point(15, 18);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(200, 40);
            this.lbTittle.TabIndex = 1;
            this.lbTittle.Text = "Tittle";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTittle.Click += new System.EventHandler(this.lbTittle_Click);
            this.lbTittle.DoubleClick += new System.EventHandler(this.DoubleClick_PinNote);
            this.lbTittle.MouseHover += new System.EventHandler(this.IbTitle_MouseHover);
            // 
            // lbContent
            // 
            this.lbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.lbContent.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lbContent.Location = new System.Drawing.Point(22, 75);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(177, 160);
            this.lbContent.TabIndex = 2;
            this.lbContent.Text = "Content";
            this.lbContent.Click += new System.EventHandler(this.lbContent_Click);
            this.lbContent.DoubleClick += new System.EventHandler(this.DoubleClick_PinNote);
            this.lbContent.MouseHover += new System.EventHandler(this.IbContent_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(224, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.DoubleClick += new System.EventHandler(this.DoubleClick_PinNote);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.picture_MouseLeave);
            this.pictureBox1.MouseHover += new System.EventHandler(this.picture_MouseHover);
            // 
            // _Note
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.Name = "_Note";
            this.Size = new System.Drawing.Size(224, 295);
            this.Load += new System.EventHandler(this._Note_Load);
            this.DoubleClick += new System.EventHandler(this.DoubleClick_PinNote);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Note_MouseClick);
            this.MouseLeave += new System.EventHandler(this.Note_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Note_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.Label lbTittle;
        public System.Windows.Forms.Label lbContent;
        public System.Windows.Forms.PictureBox pictureBox1;
    }
}
