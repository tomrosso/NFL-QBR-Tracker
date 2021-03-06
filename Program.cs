using System;
using System.Collections.Generic;


namespace NFL_QBR_Tracker
{

    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0 && args[0] == "test")
            {
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
        /// until returns true.
        /// </summary>
        /// <param name="year">The number between 1980 and 2020 the user chose</param>
        public static string GetYear()
        {
            // The steps might be closer to this:
            // 1. Prompt the user to enter a year between 1980 and 2020
            // 2. If the user enters a valid year, return that year
            // 3. Otherwise, display "Invalid" and go to step 1
            bool userChoice; // TODO(jcollard 2022-02-10): This needs to be an `int` not a `bool`

            do
            {
                Console.Write($"Enter a year between 1980 and 2020");
                string input = Console.ReadLine();
                bool isAYear = int.TryParse(input, out userChoice);
                if (isAYear == false)
                {
                    Console.Error.WriteLine("You did not enter a year");
                }
                
                else if (userChoice <= 1980 >= 2020) // TODO(jcollard 2022-02-10): You need to use an or here `else if (userChoice <= 1980 || userChoice >= 2022)`
                {
                    Console.WriteLine($"The input was not between 1980 and 2020");
                }
            }
            while (userChoice <= 1980 >= 2020); // TODO(jcollard 2022-02-10): You need to use an or here `while (userChoice <= 1980 || userChoice >= 2022)`
            return userChoice;
        
            
        

            // Feedback(jcollard 2022-02-08): Here is a similar program
            // that you can use as an example for how to write this method:
            // https://jcollard.github.io/IntroToCSharpSite/examples/read-input
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

        // Feedback(jcollard 2022-02-08): I've written a similar program
        // that you can uas as an example for how to write this method:
        // https://jcollard.github.io/IntroToCSharpSite/examples/display-options

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

}

