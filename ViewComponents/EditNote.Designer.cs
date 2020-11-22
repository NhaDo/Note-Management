﻿namespace NoteMakingApp.ViewComponents
{
    partial class EditNote
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
            this.lbMain = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.RichTextBox();
            this.lbContent = new System.Windows.Forms.Label();
            this.lbTittle = new System.Windows.Forms.Label();
            this.txtTittle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMain.Location = new System.Drawing.Point(11, 10);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(230, 40);
            this.lbMain.TabIndex = 19;
            this.lbMain.Text = "Sửa ghi chú";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(154, 294);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 34);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(63, 294);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 34);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(7, 127);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(234, 161);
            this.txtContent.TabIndex = 16;
            this.txtContent.Text = "";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(8, 107);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(67, 17);
            this.lbContent.TabIndex = 15;
            this.lbContent.Text = "Nội Dung";
            // 
            // lbTittle
            // 
            this.lbTittle.AutoSize = true;
            this.lbTittle.Location = new System.Drawing.Point(8, 50);
            this.lbTittle.Name = "lbTittle";
            this.lbTittle.Size = new System.Drawing.Size(56, 17);
            this.lbTittle.TabIndex = 14;
            this.lbTittle.Text = "Tiêu đề";
            // 
            // txtTittle
            // 
            this.txtTittle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTittle.Location = new System.Drawing.Point(8, 70);
            this.txtTittle.Multiline = true;
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(234, 34);
            this.txtTittle.TabIndex = 13;
            this.txtTittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbTittle);
            this.Controls.Add(this.txtTittle);
            this.Name = "EditNote";
            this.Size = new System.Drawing.Size(249, 339);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Label lbTittle;
        private System.Windows.Forms.TextBox txtTittle;
    }
}
