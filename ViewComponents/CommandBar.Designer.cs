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
            this.customButton1 = new CustomButton.CustomButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.customButton2 = new CustomButton.CustomButton();
            this.customButton3 = new CustomButton.CustomButton();
            this.customButton4 = new CustomButton.CustomButton();
            this.SuspendLayout();
            // 
            // customButton1
            // 
            this.customButton1.BorderColor = System.Drawing.Color.Silver;
            this.customButton1.ButtonColor = System.Drawing.Color.White;
            this.customButton1.FlatAppearance.BorderSize = 0;
            this.customButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton1.Location = new System.Drawing.Point(38, 20);
            this.customButton1.Name = "customButton1";
            this.customButton1.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.customButton1.OnHoverButtonColor = System.Drawing.Color.DeepSkyBlue;
            this.customButton1.OnHoverTextColor = System.Drawing.Color.Red;
            this.customButton1.Size = new System.Drawing.Size(174, 60);
            this.customButton1.TabIndex = 0;
            this.customButton1.Text = "Sắp xếp";
            this.customButton1.TextColor = System.Drawing.Color.Black;
            this.customButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Type1 ",
            "Type2",
            "Type3"});
            this.comboBox1.Location = new System.Drawing.Point(239, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // customButton2
            // 
            this.customButton2.BorderColor = System.Drawing.Color.Silver;
            this.customButton2.ButtonColor = System.Drawing.Color.White;
            this.customButton2.FlatAppearance.BorderSize = 0;
            this.customButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton2.Location = new System.Drawing.Point(387, 22);
            this.customButton2.Name = "customButton2";
            this.customButton2.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.customButton2.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.customButton2.OnHoverTextColor = System.Drawing.Color.Red;
            this.customButton2.Size = new System.Drawing.Size(60, 60);
            this.customButton2.TabIndex = 2;
            this.customButton2.Text = "Thêm";
            this.customButton2.TextColor = System.Drawing.Color.Black;
            this.customButton2.UseVisualStyleBackColor = true;
            // 
            // customButton3
            // 
            this.customButton3.BorderColor = System.Drawing.Color.Silver;
            this.customButton3.ButtonColor = System.Drawing.Color.White;
            this.customButton3.FlatAppearance.BorderSize = 0;
            this.customButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton3.Location = new System.Drawing.Point(466, 20);
            this.customButton3.Name = "customButton3";
            this.customButton3.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.customButton3.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.customButton3.OnHoverTextColor = System.Drawing.Color.Red;
            this.customButton3.Size = new System.Drawing.Size(60, 60);
            this.customButton3.TabIndex = 3;
            this.customButton3.Text = "Xóa";
            this.customButton3.TextColor = System.Drawing.Color.Black;
            this.customButton3.UseVisualStyleBackColor = true;
            // 
            // customButton4
            // 
            this.customButton4.BorderColor = System.Drawing.Color.Silver;
            this.customButton4.ButtonColor = System.Drawing.Color.White;
            this.customButton4.FlatAppearance.BorderSize = 0;
            this.customButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customButton4.Location = new System.Drawing.Point(539, 20);
            this.customButton4.Name = "customButton4";
            this.customButton4.OnHoverBorderColor = System.Drawing.Color.Gray;
            this.customButton4.OnHoverButtonColor = System.Drawing.Color.Yellow;
            this.customButton4.OnHoverTextColor = System.Drawing.Color.Red;
            this.customButton4.Size = new System.Drawing.Size(60, 60);
            this.customButton4.TabIndex = 4;
            this.customButton4.Text = "Sửa";
            this.customButton4.TextColor = System.Drawing.Color.Black;
            this.customButton4.UseVisualStyleBackColor = true;
            // 
            // CommandBar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.customButton4);
            this.Controls.Add(this.customButton3);
            this.Controls.Add(this.customButton2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.customButton1);
            this.Name = "CommandBar";
            this.Size = new System.Drawing.Size(625, 97);
            this.ResumeLayout(false);

        }

        #endregion

        private CustomButton.CustomButton customButton1;
        private System.Windows.Forms.ComboBox comboBox1;
        private CustomButton.CustomButton customButton2;
        private CustomButton.CustomButton customButton3;
        private CustomButton.CustomButton customButton4;
    }
}
