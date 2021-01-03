
namespace NoteMakingApp
{
    partial class PinTDL
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.addbtn = new System.Windows.Forms.PictureBox();
            this.deletebtn = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.addbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(329, 209);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.Transparent;
            this.addbtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addbtn.Image = global::NoteMakingApp.Properties.Resources.plus;
            this.addbtn.Location = new System.Drawing.Point(14, 3);
            this.addbtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(29, 30);
            this.addbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addbtn.TabIndex = 13;
            this.addbtn.TabStop = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // deletebtn
            // 
            this.deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.deletebtn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deletebtn.Image = global::NoteMakingApp.Properties.Resources.delete2;
            this.deletebtn.Location = new System.Drawing.Point(49, 3);
            this.deletebtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.Size = new System.Drawing.Size(29, 30);
            this.deletebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.deletebtn.TabIndex = 12;
            this.deletebtn.TabStop = false;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // PinTDL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 244);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.deletebtn);
            this.Name = "PinTDL";
            this.Text = "PinTDL";
            this.Load += new System.EventHandler(this.PinTDL_Load);
            ((System.ComponentModel.ISupportInitialize)(this.addbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deletebtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox addbtn;
        private System.Windows.Forms.PictureBox deletebtn;
    }
}