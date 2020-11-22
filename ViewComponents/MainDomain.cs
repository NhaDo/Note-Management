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

namespace NoteMakingApp.ViewComponents
{
    public partial class MainDomain : UserControl
    {
        public int _flags = 0;
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
            DataHandle.getInstance().ShowNote();
        }

        public void AddNewNote(int id, string tittle, string content)
        {
            Note note = new Note();
            note.setName(id);
            note.setTittle(tittle);
            note.setContent(content);
            this.flPanel.Controls.Add(note);

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

    }
}
