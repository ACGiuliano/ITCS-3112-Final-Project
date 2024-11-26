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
    public partial class NewProfile : Form
    {

        private MainForm mainForm;
        public NewProfile(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void NewProfile_Load(object sender, EventArgs e)
        {
            this.FormClosing += NewProfileFormClosing;
        }

        // Closes entire application when user clicks X button
        private void NewProfileFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = UsernameBox.Text.Trim();
                int userHeight = int.Parse(HeightBox.Text.Trim());
                double userWeight = double.Parse(CurrWeightBox.Text.Trim());
                double userGoalWeight = double.Parse(GoalWeightBox.Text.Trim());


                // input validation
                if (string.IsNullOrWhiteSpace(userName))
                    throw new Exception("Username cannot be empty.");
                if (userHeight <= 0)
                    throw new Exception("Height must be a positive value.");
                if (userWeight < 0)
                    throw new Exception("Current weight must be a positive value.");
                if (userGoalWeight <= 0)
                    throw new Exception("Goal weight must be a positive value.");

                // create User
                User newUser = new User(userName, userHeight, userWeight, userGoalWeight);

                // Adds user to JSON file
                ProfileManager.AddProfile(newUser);

                MessageBox.Show($"Profile {userName} created.", "Profile Created", MessageBoxButtons.OK, MessageBoxIcon.Information);

                HomeScreen homeScreen = new HomeScreen();
                homeScreen.Show();
                this.Hide();

            }
            // error catching incase input validation doesn't work.
            catch (FormatException)
            {
                MessageBox.Show("Please enter numeric values for height, weight, and goal weight.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
