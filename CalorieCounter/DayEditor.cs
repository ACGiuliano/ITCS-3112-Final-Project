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
    public partial class DayEditor : Form
    {
        private MainForm mainForm;
        private Day selectedDay;
        public DayEditor(MainForm mainForm, Day selectedDay)
        {
            InitializeComponent();
            this.mainForm = mainForm;
            this.selectedDay = selectedDay;
        }

        private void DayEditor_Load(object sender, EventArgs e)
        {
            // Make sure we have selections for meal types
            comboBoxMealType.Items.AddRange(new string[] { "Breakfast", "Lunch", "Dinner", "Snack" });

            LabelDayInfo.Text = $"{selectedDay.dayOfWeek}, {selectedDay.date.ToShortDateString()}\nCalorie Limit: {selectedDay.calorieLimit}";

            // populates the listbox with the meals for the selected day so we can edit or add
            foreach (Meal meal in selectedDay.Meals)
            {
                listBoxMeals.Items.Add($"{meal.mealType} - {meal.totalCalories} calories");
            }

            UpdateSummary();

            this.FormClosing += DayEditorFormClosing; // gotta make sure I have this in all my forms
        }
        /*
         * This updates the calorie summary at the top of the label box
         * and if the user is over their calorie limit it will display
         * a large red text at the top of the screen.
         */
        private void UpdateSummary()
        {
            labelCalsConsumed.Text = $"Calories Consumed: {selectedDay.consumedCalories} / {selectedDay.calorieLimit}";
            LabelOverLimit.Visible = selectedDay.overLimit;
        }

        private void DayEditorFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddMealBtn_Click(object sender, EventArgs e)
        {
            string selectedMealType = comboBoxMealType.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedMealType))
            {
                foreach (var item in listBoxMeals.Items)
                {
                    if (item.ToString().Contains(selectedMealType))
                    {
                        MessageBox.Show("Meal already exists for this day.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                // first adds to list, then adds to day object
                listBoxMeals.Items.Add(selectedMealType);

                selectedDay.AddMeal(new Meal(selectedMealType));
            }
            else
            {
                 MessageBox.Show("Select a meal type from the dropdown.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
