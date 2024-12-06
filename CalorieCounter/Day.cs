using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace CalorieCounter
{
    public class Day
    {
        // class properties

        public string dayOfWeek { get; set; }
        public DateTime date { get; set; }
        public double calorieLimit { get; set; }
        public bool overLimit => consumedCalories > calorieLimit;

        [JsonInclude]
        public List<Meal> Meals { get; private set; } = new List<Meal>();

        /*
         * Allows calories to update dynamically rather
         * than only updating when the AddMeal method is called.
         * Makes it easier to update the calorie count on the
         * DayEditor form.
         */
        public int consumedCalories
        {
            get
            {
                return Meals.Sum(m => m.totalCalories);
            }
        }

        public Day(string dayOfWeek,  DateTime date, double calorieLimit)
        {
            this.dayOfWeek = dayOfWeek;
            this.date = date.Date;
            this.calorieLimit = calorieLimit;

        }

        public void AddMeal(Meal meal) 
        {
            Meals.Add(meal);
        }

    }
}
