namespace NoteMakingApp.ViewComponents.Network
{
    partial class ClientItem
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbIP = new System.Windows.Forms.Label();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.ForeColor = System.Drawing.SystemColors.Control;
            this.lbName.Location = new System.Drawing.Point(29, 19);
            this.lbName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "label1";
            // 
            // lbIP
            // 
            this.lbIP.AutoSize = true;
            this.lbIP.ForeColor = System.Drawing.SystemColors.Control;
            this.lbIP.Location = new System.Drawing.Point(149, 19);
            this.lbIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbIP.Name = "lbIP";
            this.lbIP.Size = new System.Drawing.Size(51, 20);
            this.lbIP.TabIndex = 1;
            this.lbIP.Text = "label2";
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.BackColor = System.Drawing.Color.DarkOrange;
            this.btnDisconnect.FlatAppearance.BorderSize = 0;
            this.btnDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisconnect.Location = new System.Drawing.Point(285, 12);
            this.btnDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(44, 35);
            this.btnDisconnect.TabIndex = 2;
            this.btnDisconnect.Text = "-";
            this.btnDisconnect.UseVisualStyleBackColor = false;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // ClientItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.lbIP);
            this.Controls.Add(this.lbName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ClientItem";
            this.Size = new System.Drawing.Size(366, 60);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbIP;
        private System.Windows.Forms.Button btnDisconnect;
    }
}
