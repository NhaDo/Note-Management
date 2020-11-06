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
            this.button = new System.Windows.Forms.Button();
            this.detail = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button.Location = new System.Drawing.Point(0, 0);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(71, 66);
            this.button.TabIndex = 0;
            this.button.Text = "button";
            this.button.UseVisualStyleBackColor = true;
            this.button.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // detail
            // 
            this.detail.AutoSize = true;
            this.detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.detail.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detail.Location = new System.Drawing.Point(50, 69);
            this.detail.Name = "detail";
            this.detail.Size = new System.Drawing.Size(49, 19);
            this.detail.TabIndex = 1;
            this.detail.Text = "detail";
            // 
            // CustomButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.detail);
            this.Controls.Add(this.button);
            this.Name = "CustomButton";
            this.Size = new System.Drawing.Size(111, 100);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label detail;
    }
}
