using System;

namespace NFL_QBR_Tracker
{
    class Program
    {
        
        /// <summary>
        /// Given a prompt to show the user, displays the prompt then reads
        /// input from keyboard until user types in a year displayed.
        /// If the user does not enter a year displayed the message displays an error
        /// message and prompts the user again.
        /// </summary>
        /// <param name="year">The number between 1980 and 2020 the user chose</param>
        public static void years(string year)
        {
            // 1. Check if filename exists`
            // 2. if false throw exception "choose a year between 1980 and 2020"
            // 3. if true construct a list <int> named years to store the years
            // 4. Load "years.txt" file and store it in a variable: years File.Readlines ("years.txt")
            // 5. Return new: teams()
        }
        
        /// <summary>
        /// Given a prompt to show the user, displays the prompt then reads
        /// input from keyboard until user types in a team displayed.
        /// If the user does not enter a team displayed the message displays an error
        /// message and prompts the user again.
        /// </summary>
        /// <param name="year">The number between 1980 and 2020 the user chose</param>
        /// <param name="team">The choices to display to the user chose</param>
        public static void team(int year, string team)
        {
            // 1. Check if filename exists`
            // 2. if false throw exception "choose a team from the year you have chosen"
            // 3. if true construct a list <int> named teams to store the teams
            // 4. Load "teams.txt" file and store it in a variable: teams File.Readlines ("teams.txt")
            // 5. Return new: stats()
        }

        /// <summary>
        /// Given a prompt to show the user, displays the prompt then reads
        /// input from keyboard until user types in a QB stat displayed.
        /// If the user does not enter a QB stat displayed the message displays an error
        /// message and prompts the user again.
        /// </summary>
        /// <param name="year">The number between 1980 and 2020 the user chose</param>
        /// <param name="team">The choices to display to the user chose</param>
        /// <param name="stat">The choices to display to the user chose</param>
        public static void stats(int year, string team, string stat)
        {
            // 1. Check if filename exists`
            // 2. if false throw exception "Choose a quarterback stat listed"
            // 3. if true construct a list <int> named stats to store the stats
            // 4. Load "stats.txt" file and store it in a variable: stats File.Readlines ("stats.txt")
            // 5. Return: years()
        }
    }
}

