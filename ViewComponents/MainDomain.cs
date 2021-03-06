﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteMakingApp.Models;
using NoteMakingApp.ViewComponents.Project;

namespace NoteMakingApp.ViewComponents
{
    public partial class MainDomain : UserControl
    {
        public int _flags = 0;
        public string _way;
        public static MainDomain currentInstance { get; set; }
        public MainDomain()
        {
            InitializeComponent();
            customButton1.setImage(0);
            customButton1.getText("New");
            customButton1.setFunction(1);
            customButton1.CustomBtn.BackColor = Color.Orange;
            customButton2.setImage(2);
            customButton2.getText("Edit");
            customButton2.setFunction(2);
            customButton2.CustomBtn.BackColor = Color.Beige;
            customButton3.setImage(4);
            customButton3.getText("Delete");
            customButton3.setFunction(3);
            customButton3.CustomBtn.BackColor = Color.LightSeaGreen;
            customButton4.setImage(8);
            customButton4.getText("Send");
            customButton4.setFunction(4);
            customButton4.CustomBtn.BackColor = Color.Aqua;
            currentInstance = this;      

            
        }

        public void AddNewNote(int id, string tittle, string content)
        {
            _Note note = new _Note();
            note.setName(id);
            note.setTittle(tittle);
            note.setContent(content);
            note.GotFocus += (s, e) =>
            {
                note.chanceImage();
            };
            note.LostFocus += (s, e) =>
            {
                note.defaultImage();
            };

            this.flPanel.Controls.Add(note);
            

        }
        
        public void AddNewToDoList(string name, string a, List<ItemTDLs> b)
        {
            ToDoList tdl = new ToDoList();
            tdl.setName(a);
            tdl.addItem(b);
            tdl.setId(name);
            this.flPanel.Controls.Add(tdl);
        }

        public void AddReminder(string id,string Tittle,string Content,DateTime Time,int Check)
        {
            Reminder rmd = new Reminder();
            rmd.setValue(id,Tittle, Content, Time,Check);
            this.flPanel.Controls.Add(rmd);
        }

        public void Clear()
        {
            this.flPanel.Controls.Clear();
        }

        public void setFlags(int index)
        {
            _flags = index;
        }

        public int getFlags()
        {
            return _flags;
        }



        private void MainDomain_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.getInstance().ShowListProject();
            this.button1.Enabled = false;

        }

        public void enableButton()
        {
            this.button1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1.getInstance().setWindow("Logout");
            DataHandle.getInstance().nullifyRecentInfo();
            Form1.getInstance().loginPanel1.resetField();
        }

        private void customButton2_Load(object sender, EventArgs e)
        {

        }
    }
}