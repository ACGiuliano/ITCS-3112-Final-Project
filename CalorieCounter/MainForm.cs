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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // opens new profile form when clicked, hides this form until user goes back
            NewProfile newProfile = new NewProfile();
            newProfile.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
}
