using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteMakingApp.ViewComponents
{
    public partial class MainDomain : UserControl
    {
        public static MainDomain currentInstance { get; set; }
      
        public MainDomain()
        {
            InitializeComponent();
            customButton1.setImage(0);
            customButton1.getText("New");
            customButton1.setFunction(1);
            customButton2.setImage(2);
            customButton2.getText("Edit");
            customButton2.setFunction(2);
            customButton3.setImage(4);
            customButton3.getText("Delete");
            customButton3.setFunction(3);
            currentInstance = this;

            
        }

        public void AddNewNote(string tittle,string content)
        {
            Note note = new Note();
            
            note.setTittle(tittle);
            note.setContent(content);
            this.flowLayoutPanel1.Controls.Add(note);
        }

        public void DeleteNote()
        {

        }

        
        public void EditNote()
        {

        }

    }
}
