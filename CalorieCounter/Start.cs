namespace CalorieCounter
{
    public partial class CalorieCounter : Form
    {
        public CalorieCounter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Open the main form and hide the start page
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();

            // Will close CalorieCounter when MainForm is closed
            mainForm.FormClosed += (s, args) => this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Closes application
            Application.Exit();
        }

        private void CalorieCounter_Load(object sender, EventArgs e)
        {

        }
    }
}
