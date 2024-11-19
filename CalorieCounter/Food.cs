using System;
using System.Collections.Generic;

namespace CalorieCounter
{
    public class Food
    {
        // properties
        public string name {  get; set; }
        public int calories { get; set; }

        public Food(string name, int calories) 
        {
            this.name = name;
            this.calories = calories;
        }

        public override string ToString() 
        {
            return $"{name}: {calories} calories";
        }
    }

}
