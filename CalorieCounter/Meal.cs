using System;
using System.Collections.Generic;

namespace CalorieCounter
{
    public class Meal
    {
        //properties
        public string mealType {  get; set; }
        public List<Food> foods { get; private set; }

        /*
         * Similar to how the consumedCalories property
         * works in the Day class, this allows the total
         * calories from food to dynamically update.
         */
        public int totalCalories
        {
            get
            {
                return foods.Sum(f => f.calories);
            }
        }

        public Meal(string mealType) 
        {
            this.mealType = mealType;
            foods = new List<Food>();
        }

        public void AddFood(Food food) 
        {
            foods.Add(food);
        }

        // display details
        public override string ToString()
        {
            return $"{mealType}: {totalCalories} calories";
        }
    }
}
