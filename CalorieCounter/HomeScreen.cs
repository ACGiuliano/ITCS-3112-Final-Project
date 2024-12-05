using System;
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
        private User currentUser;
        private MainForm mainForm;
        private DateTime selectedDay;
        public HomeScreen(MainForm mainForm, User currentUser)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.currentUser = currentUser;
        }





        private void HomeScreen_Load(object sender, EventArgs e)
        {
            this.FormClosing += HomeScreenFormClosing;
            selectedDay = dateTimePicker1.Value;
        }

        private void HomeScreenFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            selectedDay = dateTimePicker1.Value;
            MessageBox.Show($"Day Selected: {selectedDay.ToShortDateString()}");

        }

        private void ContinueBtn_Click(object sender, EventArgs e)
        {
            // Takes the selected day and turns it into a day object so we can pass it to the day editor form
            // Uses users calorie limit to determine day's calorie limit
            Day day = new Day(selectedDay.DayOfWeek.ToString(), selectedDay, currentUser.CalculateCalorieLimit());

            DayEditor dayEditor = new DayEditor(mainForm, day);
            dayEditor.Show();
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
    }
}
