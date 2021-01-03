
namespace NoteMakingApp
{
    partial class PinForm
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
            this.TextBox = new System.Windows.Forms.RichTextBox();
            this.openHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.TextBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox.Location = new System.Drawing.Point(0, 36);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(365, 188);
            this.TextBox.TabIndex = 0;
            this.TextBox.Text = "";
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // openHome
            // 
            this.openHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.openHome.BackgroundImage = global::NoteMakingApp.Properties.Resources.HOME2;
            this.openHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openHome.Location = new System.Drawing.Point(0, 0);
            this.openHome.Name = "openHome";
            this.openHome.Size = new System.Drawing.Size(30, 30);
            this.openHome.TabIndex = 1;
            this.openHome.UseVisualStyleBackColor = false;
            this.openHome.Click += new System.EventHandler(this.openHome_Click);
            // 
            // PinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(366, 222);
            this.Controls.Add(this.openHome);
            this.Controls.Add(this.TextBox);
            this.Name = "PinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "PinForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PinForm_FormClosed);
            this.ClientSizeChanged += new System.EventHandler(this.PinForm_ClientSizeChanged);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox TextBox;
        private System.Windows.Forms.Button openHome;
    }
}