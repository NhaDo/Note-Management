﻿using System;
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
    public partial class ItemTDL : UserControl
    {
        public ItemTDL()
        {
            InitializeComponent();
        }

        public void setValue(string a)
        {
            this.textBox1.Text = a;
        }
    }
}
