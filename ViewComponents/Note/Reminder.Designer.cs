namespace NoteMakingApp.ViewComponents
{
    partial class Reminder
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
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.lbTime = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::NoteMakingApp.Properties.Resources.Reminder;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(199, 236);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.PictureBox_MouseHover);
            // 
            // lbContent
            // 
            this.lbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.lbContent.Location = new System.Drawing.Point(17, 61);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(173, 165);
            this.lbContent.TabIndex = 5;
            this.lbContent.Text = "lbContent";
            this.lbContent.Click += new System.EventHandler(this.lbContent_Click);
            this.lbContent.MouseHover += new System.EventHandler(this.Content_MouseHover);
            // 
            // lbTittle
            // 
            this.lbTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.lbTittle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTittle.ForeColor = System.Drawing.Color.Black;
            this.lbTittle.Location = new System.Drawing.Point(8, 12);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(130, 29);
            this.lbTittle.TabIndex = 4;
            this.lbTittle.Text = "lbTittle";
            this.lbTittle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbTittle.Click += new System.EventHandler(this.lbTittle_Click);
            this.lbTittle.MouseHover += new System.EventHandler(this.Title_MouseHover);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoCheck = false;
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Location = new System.Drawing.Point(171, 20);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lbTime.Location = new System.Drawing.Point(117, 202);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(71, 25);
            this.lbTime.TabIndex = 7;
            this.lbTime.Text = "lbTime";
            // 
            // Reminder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "Reminder";
            this.Size = new System.Drawing.Size(199, 236);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Reminder_MouseClick);
            this.MouseLeave += new System.EventHandler(this.Reminder_MouseLeave);
            this.MouseHover += new System.EventHandler(this.Reminder_MouseHover);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lbTime;
    }
}
