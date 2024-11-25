using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace CalorieCounter
{
    public static class ProfileManager
    {
        /*
         * Wanted to try something different with saving using JSON
         * instead of saving to a .txt file, and oh my god this is
         * miserable why didn't I keep this simple?
         */

        private static string filePath = "userProfiles.json"; // this ends up in the bin/debug/net8.0-windows directory

        public static void SaveProfiles(List<User> users)
        {           
            string jsonString = JsonSerializer.Serialize(users, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, jsonString);                        
        }

        // Load profiles from JSON file
        public static List<User> LoadProfiles()
        {
            if (File.Exists(filePath)) 
            {
                string jsonString = File.ReadAllText(filePath);
                var profiles = JsonSerializer.Deserialize<List<User>>(jsonString) ?? new List<User>();
                return profiles;
            }
            else
            {
                return new List<User>();
            }
        }

        // Add a new profile to the list of profiles
        public static void AddProfile(User user)
        {
            // Load existing, adds new user, saves   
            var users = LoadProfiles();
            users.Add(user);
            SaveProfiles(users);
        }

        /*
         * Will eventually add a delete profile option
         * but want to get this functionality down first
         * before I even try to mess with removing stuff.
         */
    }
}
