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
            this.txtTittle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMain
            // 
            this.lbMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbMain.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbMain.Location = new System.Drawing.Point(12, 12);
            this.lbMain.Name = "lbMain";
            this.lbMain.Size = new System.Drawing.Size(259, 50);
            this.lbMain.TabIndex = 19;
            this.lbMain.Text = "Edit note";
            this.lbMain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(173, 368);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(84, 42);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.Location = new System.Drawing.Point(71, 368);
            this.btnOk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(84, 42);
            this.btnOk.TabIndex = 17;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = false;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtContent
            // 
            this.txtContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.txtContent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContent.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtContent.Location = new System.Drawing.Point(7, 134);
            this.txtContent.Margin = new System.Windows.Forms.Padding(0);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(270, 229);
            this.txtContent.TabIndex = 16;
            this.txtContent.Text = "Content";
            // 
            // txtTittle
            // 
            this.txtTittle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(39)))));
            this.txtTittle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTittle.Font = new System.Drawing.Font("Times New Roman", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.txtTittle.Location = new System.Drawing.Point(0, 66);
            this.txtTittle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTittle.Multiline = true;
            this.txtTittle.Name = "txtTittle";
            this.txtTittle.Size = new System.Drawing.Size(279, 64);
            this.txtTittle.TabIndex = 13;
            this.txtTittle.Text = "Name";
            this.txtTittle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EditNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(216)))), ((int)(((byte)(208)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lbMain);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtTittle);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "EditNote";
            this.Size = new System.Drawing.Size(278, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMain;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.RichTextBox txtContent;
        private System.Windows.Forms.TextBox txtTittle;
    }
}
