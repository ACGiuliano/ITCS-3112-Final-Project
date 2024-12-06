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
        private User currentUser;
        private HomeScreen homeScreen;
        private Day selectedDay;
        public DayEditor(HomeScreen homeScreen, Day selectedDay, User currentUser)
        {
            InitializeComponent();
            this.homeScreen = homeScreen;
            this.selectedDay = selectedDay;
            this.currentUser = currentUser;
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
            int totalCalories = selectedDay.consumedCalories;
            labelCalsConsumed.Text = $"Calories Consumed: {totalCalories} / {selectedDay.calorieLimit}";
            LabelOverLimit.Visible = selectedDay.overLimit;
        }

        private void DayEditorFormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AddMealBtn_Click(object sender, EventArgs e)
        {
            string selectedMealType = comboBoxMealType.SelectedItem.ToString();

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

        private void listBoxMeals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMeals.SelectedIndex == -1) return;

            string selectedMealType = listBoxMeals.SelectedItem.ToString().Split('-')[0].Trim(); // removes the calorie count from the listbox item

            Meal selectedMeal = selectedDay.Meals.FirstOrDefault(m => m.mealType == selectedMealType);

            listBoxFood.Items.Clear();
            foreach (Food food in selectedMeal.foods)
            {
                listBoxFood.Items.Add($"{food.name} - {food.calories} calories");
            }
        }

        // Makes sure user can only input numeric values for calories
        private void textBoxCalories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void AddFoodBtn_Click(object sender, EventArgs e)
        {
            if (listBoxMeals.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a meal to add food.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // input validation for food name and calories
            string foodName = textBoxFood.Text.Trim();
            if (string.IsNullOrWhiteSpace(foodName))
            {
                MessageBox.Show("Food must have a name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBoxCalories.Text.Trim(), out int foodCalories) || foodCalories <= 0)
            {
                MessageBox.Show("Enter a valid positive number for calories.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMealType = listBoxMeals.SelectedItem.ToString().Split('-')[0].Trim();
            Meal selectedMeal = selectedDay.Meals.FirstOrDefault(m => m.mealType == selectedMealType);

            if (selectedMeal != null)
            {
                Food newFood = new Food(foodName, foodCalories);
                selectedMeal.AddFood(newFood);

                listBoxFood.Items.Add($"{newFood.name} - {newFood.calories} calories");

                UpdateMealsBox(); // need to update calories in the meals listbox
            }

            textBoxFood.Clear();
            textBoxCalories.Clear();
        }

        private void UpdateMealsBox()
        {
            listBoxMeals.Items.Clear();
            foreach (Meal meal in selectedDay.Meals)
            {
                listBoxMeals.Items.Add($"{meal.mealType} - {meal.totalCalories} calories");
            }
            UpdateSummary();
        }

        private void RemoveMealBtn_Click(object sender, EventArgs e)
        {
            if (listBoxMeals.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a meal to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMealType = listBoxMeals.SelectedItem.ToString().Split('-')[0].Trim();
            Meal selectedMeal = selectedDay.Meals.FirstOrDefault(m => m.mealType == selectedMealType);

            if (selectedMeal != null)
            {
                selectedDay.Meals.Remove(selectedMeal);
                listBoxMeals.Items.Remove(listBoxMeals.SelectedItem);
                listBoxFood.Items.Clear();
                UpdateMealsBox();
                UpdateSummary();

                MessageBox.Show("Meal removed.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RemoveFoodBtn_Click(object sender, EventArgs e)
        {
            if (listBoxMeals.SelectedIndex == -1 || listBoxFood.SelectedIndex == -1)
            {
                MessageBox.Show("You must select a meal and food to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedMealType = listBoxMeals.SelectedItem.ToString().Split('-')[0].Trim();
            Meal selectedMeal = selectedDay.Meals.FirstOrDefault(m => m.mealType == selectedMealType);

            if (selectedMeal != null)
            {
                string selectedFood = listBoxFood.SelectedItem.ToString();
                string selectedFoodName = selectedFood.Split('-')[0].Trim();

                Food foodToRemove = selectedMeal.foods.FirstOrDefault(f => f.name == selectedFoodName);
                if (foodToRemove != null)
                {
                    selectedMeal.foods.Remove(foodToRemove);

                    // update listbox to reflect removed food
                    listBoxFood.Items.Remove(listBoxFood.SelectedItem);
                    UpdateMealsBox();
                    UpdateSummary();

                    MessageBox.Show($"{selectedFoodName} removed from {selectedMealType}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            ProfileManager.AddDayToUser(currentUser, selectedDay);

            MessageBox.Show("Day saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            homeScreen.Show();
            this.Hide();
        }
    }
}
