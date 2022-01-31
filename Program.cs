using System;
using System.Collections.Generic;


namespace NFL_QBR_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test"){
                TestAll();
                return;
            }
        }
        public static void TestAll()
        {
            bool testDisplayStat = TestDisplayStat.RunTest();
            Console.WriteLine($"Test DisplayStat(filename): {testDisplayStat}");

            bool testGetStat = TestGetStat.RunTest();
            Console.WriteLine($"Test GetStat(filename): {testGetStat}");

            bool testGetTeam = TestGetTeam.RunTest();
            Console.WriteLine($"Test GetTeam(filename): {testGetTeam}");

            bool testGetYear = TestGetYear.RunTest();
            Console.WriteLine($"Test GetYear(filename): {testGetYear}");
        }

        /// <summary>
        /// Given a prompt to show the user, displays the prompt then reads
        /// input from keyboard until user types in a year displayed.
        /// If the user does not enter a year displayed the message displays an error
        /// message and prompts the user again.
        /// </summary>
        /// <param name="year">The number between 1980 and 2020 the user chose</param>
        public static string GetYear()
        {
            // The steps might be closer to this:
            // 1. Prompt the user to enter a year between 1980 and 2020
            // 2. If the user enters a valid year, return that year
            // 3. Otherwise, display "Invalid" and go to step 1
            return null;
        }

        /// <summary>
        /// Given a prompt to show the user, displays the prompt then reads
        /// input from keyboard until user types in a team displayed.
        /// If the user does not enter a team displayed the message displays an error
        /// message and prompts the user again.
        /// </summary>
        /// <param name="year">The number between 1980 and 2020 the user chose</param>
        /// <param name="team">The choices to display to the user chose</param>
        public static string GetTeam(List<string> validTeams)
        {
            // The steps might be closer to this:
            // 1. Check that validTeams has at least 1 option
            // 2. If it does not, throw an exception
            // 3. Display the list of validTeams
            // 4. Prompt the user to enter a team name
            // 5. If the entered name is in the list, return that name
            // 6. Otherwise display "Invalid" and goto step 3.
            return null;
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
        public static string GetStat(List<string> validStats)
        {
            // The steps might be closer to this:
            // 1. Check that validStats has at least 1 option
            // 2. If it does not, throw an exception
            // 3. Display the list of validStats
            // 4. Prompt the user to enter a stat
            // 5. If the entered stat is in the list, return that name
            // 6. Otherwise display "Invalid" and goto step 3.
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="team"></param>
        /// <param name="stat"></param>
        public static void DisplayStat(string year, string team, string stat)
        {

        }
        // TODO(jcollard 2022-01-27):
        // This is a great start! I think you should add the following method:
        // public static void DisplayStat(string year, string team, string stat)
        // This method will be called after the user has made each selection. This
        // method will use the year, team, and stat to look up the results and display
        // a message to the user.
    }

}

