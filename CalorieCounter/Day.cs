using System;
using System.Collections.Generic;

namespace CalorieCounter
{
    public class Day
    {
        // class properties

        public string dayOfWeek { get; set; }
        public DateTime date { get; set; }
        public double calorieLimit { get; set; }
        public int consumedCalories { get; private set; }
        public bool overLimit => consumedCalories > calorieLimit;

        
        public List<Meal> Meals { get; private set; }

        public Day(string dayOfWeek,  DateTime date, double calorieLimit)
        {
            this.dayOfWeek = dayOfWeek;
            this.date = date;
            this.calorieLimit = calorieLimit;
            this.consumedCalories = 0;
            Meals = new List<Meal>();

        }

        public void AddMeal(Meal meal) 
        {
            Meals.Add(meal);
            consumedCalories += meal.totalCalories;
        }

    }
}
