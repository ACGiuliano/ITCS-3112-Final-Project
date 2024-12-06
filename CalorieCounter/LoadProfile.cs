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
    public partial class LoadProfile : Form
    {
        private MainForm mainForm;
        public LoadProfile(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void LoadProfile_Load(object sender, EventArgs e) // this stupid method wasn't attached properly to the form and gave me trouble for hours
        {
            this.FormClosing += LoadProfileFormClosing;

            try
            {
                List<User> profiles = ProfileManager.LoadProfiles();

                if (profiles.Count == 0)
                    MessageBox.Show("No profiles available.", "Load Profiles", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    ProfileDropdown.DataSource = profiles;
                    ProfileDropdown.DisplayMember = "userName";
                    ProfileDropdown.ValueMember = null; // keeps the whole User object, not sure if required but it fixed something
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProfileFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            // shows popup if no profile selected
            if (ProfileDropdown.SelectedItem == null)
            {
                MessageBox.Show("Select a profile from the dropdown.", "No Profile Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User selectedUser = (User)ProfileDropdown.SelectedItem;

            Console.WriteLine($"Selected user: {selectedUser.userName}"); // Show profile details when selected

            // Show profile details when selected
            MessageBox.Show($"Profile selected:\n\n{selectedUser.ToString()}", "Profile Successfully Loaded", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HomeScreen homeScreen = new HomeScreen(mainForm, selectedUser);
            homeScreen.Show();
            this.Hide();
        }
    }
}
