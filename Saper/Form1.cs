﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Saper
{
    public partial class Form1 : Form
    {
        PanelGame myGame;
        public Form1()
        {
            InitializeComponent();
            myGame = new PanelGame(8, 8, 10);
            this.Controls.Add(myGame);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
