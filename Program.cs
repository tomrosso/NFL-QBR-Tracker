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

            // TODO(jcollard 2022-01-27): 
            // The steps you have here are not consistent with the summary above
            //
            // I believe that this method should not have any parameters and should return a string
            // I think the method stub should look like this:
            //
            // public static string GetYear()
            //
            // The steps might be closer to this:
            // 1. Prompt the user to enter a year between 1980 and 2020
            // 2. If the user enters a valid year, return that year
            // 3. Otherwise, display "Invalid" and go to step 1
            
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

            // TODO(jcollard 2022-01-27): 
            // The steps you have here are not consistent with the summary above
            //
            // I believe that this method should take one parameter: List<string>. This list should contain
            // the possible valid teams that can be selected. This method should probably return a string
            // which is the team that the player chose.
            //
            // I think the method stub should look like this:
            //
            // public static string GetTeam(List<string> validTeams)
            //
            // The steps might be closer to this:
            // 1. Check that validTeams has at least 1 option
            // 2. If it does not, throw an exception
            // 3. Display the list of validTeams
            // 4. Prompt the user to enter a team name
            // 5. If the entered name is in the list, return that name
            // 6. Otherwise display "Invalid" and goto step 3.
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

            // TODO(jcollard 2022-01-27): 
            // The steps you have here are not consistent with the summary above
            //
            // I believe that this method should take one parameter: List<string>. This list should contain
            // the possible options that the user can make. This method should probalby return a string
            //
            // I think the method stub should look like this:
            //
            // public static string GetStat(List<string> validStats)
            //
            // The steps might be closer to this:
            // 1. Check that validStats has at least 1 option
            // 2. If it does not, throw an exception
            // 3. Display the list of validStats
            // 4. Prompt the user to enter a stat
            // 5. If the entered stat is in the list, return that name
            // 6. Otherwise display "Invalid" and goto step 3.
        }

        // TODO(jcollard 2022-01-27):
        // This is a great start! I think you should add the following method:
        // public static void DisplayStat(string year, string team, string stat)
        // This method will be called after the user has made each selection. This
        // method will use the year, team, and stat to look up the results and display
        // a message to the user.
    }
}

