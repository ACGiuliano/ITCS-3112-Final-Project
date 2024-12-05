﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    /*
     * This page pretty much acts as a sort of 
     * hub to get to other pages. Once the user
     * loads or creates a profile they come here and
     * can navigate to various other forms to do
     * things such as start a new day, edit days,
     * add food, edit food, look at pre-saved meals, etc.
     */
    public partial class HomeScreen : Form
    {
        private MainForm mainForm;
        public HomeScreen(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void NewDayBtn_Click(object sender, EventArgs e)
        {
            NewDay newDay = new NewDay();
            newDay.Show();
            this.Hide();
        }

        private void ViewDaysBtn_Click(object sender, EventArgs e)
        {

        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {
            this.FormClosing += HomeScreenFormClosing;
        }

        private void HomeScreenFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}