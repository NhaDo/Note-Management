namespace NoteMakingApp.ViewComponents.Network
{
    partial class NetworkSubWindow
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
            this.btnCConnect = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.LCServerIP = new System.Windows.Forms.Label();
            this.LCIServerIP = new System.Windows.Forms.Label();
            this.LCIServerName = new System.Windows.Forms.Label();
            this.LCServerName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCDisconnect = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tbCServerIP = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbSServerName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbSServerIP = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlSClients = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCConnect
            // 
            this.btnCConnect.BackColor = System.Drawing.Color.DarkOrange;
            this.btnCConnect.FlatAppearance.BorderSize = 0;
            this.btnCConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCConnect.ForeColor = System.Drawing.Color.Black;
            this.btnCConnect.Location = new System.Drawing.Point(72, 397);
            this.btnCConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCConnect.Name = "btnCConnect";
            this.btnCConnect.Size = new System.Drawing.Size(112, 45);
            this.btnCConnect.TabIndex = 0;
            this.btnCConnect.Text = "Connect";
            this.btnCConnect.UseVisualStyleBackColor = false;
            this.btnCConnect.Click += new System.EventHandler(this.btnCConnect_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrange;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(531, 397);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generate Server";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // LCServerIP
            // 
            this.LCServerIP.AutoSize = true;
            this.LCServerIP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LCServerIP.Location = new System.Drawing.Point(65, 150);
            this.LCServerIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCServerIP.Name = "LCServerIP";
            this.LCServerIP.Size = new System.Drawing.Size(74, 20);
            this.LCServerIP.TabIndex = 2;
            this.LCServerIP.Text = "Server IP";
            this.LCServerIP.Click += new System.EventHandler(this.label1_Click);
            // 
            // LCIServerIP
            // 
            this.LCIServerIP.AutoSize = true;
            this.LCIServerIP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LCIServerIP.Location = new System.Drawing.Point(194, 150);
            this.LCIServerIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCIServerIP.Name = "LCIServerIP";
            this.LCIServerIP.Size = new System.Drawing.Size(54, 20);
            this.LCIServerIP.TabIndex = 3;
            this.LCIServerIP.Text = "_____";
            this.LCIServerIP.Click += new System.EventHandler(this.label2_Click);
            // 
            // LCIServerName
            // 
            this.LCIServerName.AutoSize = true;
            this.LCIServerName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LCIServerName.Location = new System.Drawing.Point(194, 196);
            this.LCIServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCIServerName.Name = "LCIServerName";
            this.LCIServerName.Size = new System.Drawing.Size(45, 20);
            this.LCIServerName.TabIndex = 5;
            this.LCIServerName.Text = "____";
            this.LCIServerName.Click += new System.EventHandler(this.label3_Click);
            // 
            // LCServerName
            // 
            this.LCServerName.AutoSize = true;
            this.LCServerName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LCServerName.Location = new System.Drawing.Point(65, 196);
            this.LCServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LCServerName.Name = "LCServerName";
            this.LCServerName.Size = new System.Drawing.Size(101, 20);
            this.LCServerName.TabIndex = 4;
            this.LCServerName.Text = "Server Name";
            this.LCServerName.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(131, 37);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 37);
            this.label5.TabIndex = 6;
            this.label5.Text = "As Client";
            // 
            // btnCDisconnect
            // 
            this.btnCDisconnect.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCDisconnect.FlatAppearance.BorderSize = 0;
            this.btnCDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCDisconnect.ForeColor = System.Drawing.Color.Black;
            this.btnCDisconnect.Location = new System.Drawing.Point(198, 397);
            this.btnCDisconnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCDisconnect.Name = "btnCDisconnect";
            this.btnCDisconnect.Size = new System.Drawing.Size(112, 45);
            this.btnCDisconnect.TabIndex = 7;
            this.btnCDisconnect.Text = "Disconnect";
            this.btnCDisconnect.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(198, 262);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 8;
            // 
            // tbCServerIP
            // 
            this.tbCServerIP.AutoSize = true;
            this.tbCServerIP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tbCServerIP.Location = new System.Drawing.Point(65, 268);
            this.tbCServerIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tbCServerIP.Name = "tbCServerIP";
            this.tbCServerIP.Size = new System.Drawing.Size(87, 20);
            this.tbCServerIP.TabIndex = 9;
            this.tbCServerIP.Text = "Connect to";
            this.tbCServerIP.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(543, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "As Server";
            // 
            // lbSServerName
            // 
            this.lbSServerName.AutoSize = true;
            this.lbSServerName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSServerName.Location = new System.Drawing.Point(638, 172);
            this.lbSServerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSServerName.Name = "lbSServerName";
            this.lbSServerName.Size = new System.Drawing.Size(45, 20);
            this.lbSServerName.TabIndex = 13;
            this.lbSServerName.Text = "____";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(525, 172);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Server Name";
            // 
            // lbSServerIP
            // 
            this.lbSServerIP.AutoSize = true;
            this.lbSServerIP.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbSServerIP.Location = new System.Drawing.Point(638, 126);
            this.lbSServerIP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSServerIP.Name = "lbSServerIP";
            this.lbSServerIP.Size = new System.Drawing.Size(54, 20);
            this.lbSServerIP.TabIndex = 11;
            this.lbSServerIP.Text = "_____";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(527, 126);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Server IP";
            // 
            // pnlSClients
            // 
            this.pnlSClients.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.pnlSClients.Location = new System.Drawing.Point(453, 230);
            this.pnlSClients.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSClients.Name = "pnlSClients";
            this.pnlSClients.Size = new System.Drawing.Size(323, 142);
            this.pnlSClients.TabIndex = 15;
            // 
            // NetworkSubWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.pnlSClients);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbSServerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbSServerIP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbCServerIP);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnCDisconnect);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LCIServerName);
            this.Controls.Add(this.LCServerName);
            this.Controls.Add(this.LCIServerIP);
            this.Controls.Add(this.LCServerIP);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCConnect);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NetworkSubWindow";
            this.Size = new System.Drawing.Size(844, 486);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCConnect;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label LCServerIP;
        private System.Windows.Forms.Label LCIServerIP;
        private System.Windows.Forms.Label LCIServerName;
        private System.Windows.Forms.Label LCServerName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCDisconnect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label tbCServerIP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbSServerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbSServerIP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlSClients;
    }
}
