﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disaster_Recovery_Solution
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new CalcForm().ShowDialog();

        }

        private void exitAppButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
