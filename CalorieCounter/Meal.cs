using System;
using System.Collections.Generic;

namespace CalorieCounter
{
    public class Meal
    {
        //properties
        public string mealType {  get; set; }
        public List<Food> foods { get; private set; }

        public int totalCalories
        {
            get
            {
                int total = 0;
                foreach (var food in foods)
                {
                    total += food.calories;
                }
                return total;
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
