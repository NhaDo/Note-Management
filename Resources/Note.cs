using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
namespace Note
{
    public class Note : System.Windows.Forms.Button
    {
        public Note()
        {
            this.Size = new System.Drawing.Size(186, 250);
            this.ForeColor = Color.Black;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.BorderColor = Color.Blue;
            Image image = Image.FromFile("C:/Users/Seledy/Documents/GitHub/Note-Management/Resources/Note.png");
            this.Image = image;
            this.ImageAlign = ContentAlignment.MiddleCenter;
            this.Font = new Font("Arial", 12);
            DoubleBuffered = true;
            MouseEnter += (sender, e) =>
            {
                this.FlatAppearance.BorderSize = 3;
                this.ForeColor = Color.Red;
                Invalidate();
            };
            MouseLeave += (sender, e) =>
            {
                this.FlatAppearance.BorderSize = 0;
                this.ForeColor = Color.Black;
                Invalidate();
            };
        }
    }
}
