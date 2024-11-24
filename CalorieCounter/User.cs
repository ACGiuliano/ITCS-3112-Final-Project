using System;
using System.IO;
using System.Text.Json;

namespace CalorieCounter
{
    public class User
    {
        public string userName { get; set; }
        public int userHeight { get; set; }
        public double userWeight { get; set; }
        public double userGoalWeight { get; set; }

        // constructor
        public User(string name, int height, double weight, double goalWeight)
        {
            userName = name;
            userHeight = height;
            userWeight = weight;
            userGoalWeight = goalWeight;
        }

        // default contructor
        public User() { }

        /* Calculates daily calories using a 
         * simplistic formula that gets a rough
         * estimate of what user should be 
         * consuming. */
        public double CalculateCalorieLimit()
        {
            double calorieLimit = userGoalWeight * 12;
            return calorieLimit;
        }

        /*
         * Moving the saving and loading functionality
         * to the ProfileManager class to make it
         * easier to save other data besides
         * basic user data. Also keeps things
         * compartmentalized rather than 
         * overloading the User class with methods.
         */

        // shows user profile information
        public override string ToString()
        {
            return $"Name: {userName}\nHeight: {userHeight}\nWeight: {userWeight}\nGoal Weight: {userGoalWeight}\n";
        }
    }

}
