using System;
using System.IO;

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
         * consuming. Other formulas exist but this 
         * is the easiest way to calculate with
         * information provided by user */
        public double CalculateCalorieLimit()
        {
            double calorieLimit = userGoalWeight * 12;
            return calorieLimit;
        }

        /* Saves profile to a file in a given 
         * filepath. Need to implement saving days 
         * to file as well at future date.
         * Will update this to using JSON file at 
         * some point */
        public void SaveProfile(string filepath)
        {
            using (StreamWriter sw = new StreamWriter(filepath))
            {
                sw.WriteLine(userName);
                sw.WriteLine(userHeight);
                sw.WriteLine(userWeight);
                sw.WriteLine(userGoalWeight);
            }
        }

        /* Same as SaveProfile, need to implement
         * days and calories consumed, etc. for 
         * this to be complete. Just getting basic
         * idea down for now so there's something
         * to work with while I finish it up. */
        public void LoadProfile(string filepath)
        {
            if (File.Exists(filepath)) 
            {
                using (StreamReader sr = new StreamReader(filepath))
                {
                    userName = sr.ReadLine();
                    userHeight = int.Parse(sr.ReadLine());
                    userWeight = double.Parse(sr.ReadLine());
                    userGoalWeight= double.Parse(sr.ReadLine());
                }
            }
            else
            {
                throw new FileNotFoundException("Profile cannot be found.");
            }
        }

        // shows user profile information
        public override string ToString()
        {
            return $"Name: {userName}\nHeight: {userHeight}\nWeight: {userWeight}\nGoal Weight: {userGoalWeight}\n";
        }
    }

}
