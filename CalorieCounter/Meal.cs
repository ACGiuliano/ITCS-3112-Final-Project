using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CalorieCounter
{
    public class Meal
    {
        //properties
        public string mealType {  get; set; }

        [JsonInclude]
        public List<Food> foods { get; private set; } = new List<Food>();

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
