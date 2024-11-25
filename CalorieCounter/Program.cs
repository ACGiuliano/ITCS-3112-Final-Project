namespace CalorieCounter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*
             * Turns out this if statement didn't fix
             * the issue I had but I'm keeping it incase
             * it ends up being a problem for another 
             * user.
             */
            if (!File.Exists("userProfiles.json"))
            {
                ProfileManager.SaveProfiles(new List<User>());
                Console.WriteLine("Created initial empty profiles file.");
            }
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CalorieCounter());
        }
    }
}