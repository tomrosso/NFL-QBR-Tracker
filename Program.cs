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

            NFLStats stats = new NFLStats();

            int year = int.Parse(Program.GetYear());

            List<string> teams = stats.GetTeamNames(year);

            Console.Clear();
            Console.WriteLine($"Showing Teams from {year}");

            string team = GetTeam(teams);


            // Console.WriteLine("\nEnter a Team Name: ");
            // string selectedTeam = Console.ReadLine();

            //List<string> allowed = stats.GetOffenseStatNames(year);

            //Console.WriteLine("Offensive Stats: ");
            // foreach (string name in allowed)
            // {
            //     Console.Write($"{name} ");
            // }

            // Console.WriteLine();
            // Console.WriteLine("Select a stat: ");
            // string selectedStat = Console.ReadLine();
            // // string stat = stats.GetStat(year, userChoice validTeams, userChoice validStats);
            // // Console.WriteLine($"In {year} the {userChoice validteams} had {userChoice validStats} in {DisplayStat}!");

            // // return;

            // string value = GetYear();
            // Console.WriteLine($"You entered {value}");
            // List<string> validTeams = new List<string>();

            // validTeams.Add("Cardinals");
            // validTeams.Add("Falcons");
            // validTeams.Add("Panthers");
            // validTeams.Add("Bears");
            // validTeams.Add("Cowboys");
            // validTeams.Add("Lions");
            // validTeams.Add("Packers");
            // validTeams.Add("Rams");
            // validTeams.Add("Vikings");
            // validTeams.Add("Saints");
            // validTeams.Add("Giants");
            // validTeams.Add("Eagles");
            // validTeams.Add("49ers");
            // validTeams.Add("Seahawks");
            // validTeams.Add("Buccaneers");
            // validTeams.Add("Commanders");
            // validTeams.Add("Ravens");
            // validTeams.Add("Bills");
            // validTeams.Add("Bengals");
            // validTeams.Add("Browns");
            // validTeams.Add("Broncos");
            // validTeams.Add("Texans");
            // validTeams.Add("Colts");
            // validTeams.Add("Jaguars");
            // validTeams.Add("Chiefs");
            // validTeams.Add("Raiders");
            // validTeams.Add("Chargers");
            // validTeams.Add("Dolphins");
            // validTeams.Add("Patriots");
            // validTeams.Add("Jets");
            // validTeams.Add("Steelers");
            // validTeams.Add("Titans");
            // string t2 = GetTeam(validTeams);
            // Console.WriteLine($"You selected {team}");

            List<string> validStats = new List<string>();

            validStats.Add("passTdPerc");
            validStats.Add("passSackedPerG");
            validStats.Add("passSacked");
            validStats.Add("passCmpPerG");
            validStats.Add("passFd");
            validStats.Add("passSackedPerc");
            validStats.Add("passRating");
            validStats.Add("passIntPerG");
            validStats.Add("passTdPerG");
            validStats.Add("passNetYdsPerAtt");
            validStats.Add("passFdPerG");
            validStats.Add("passCmpPerc");
            validStats.Add("passSackedYds");
            validStats.Add("passYdsPerG");
            validStats.Add("passCmp");
            validStats.Add("passIntPerc");
            validStats.Add("passInt");
            validStats.Add("passYdsPerCmp");
            validStats.Add("passAtt");
            validStats.Add("passAttPerG");
            validStats.Add("passLong");
            validStats.Add("passYds");
            validStats.Add("passSackedYdsPerG");

            List<string> Stats = GetStat(validStats);
            // foreach loop that does this for each stat in the list
            foreach (string Stat in Stats)
            {
                Console.WriteLine($"You selected {Stat}");
                string theStat = stats.GetOffenseStat(year, team, Stat);
                Console.Write($"You chose the QB stat {Stat} which was {theStat} in {year} for the {team} ");
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
            int userChoice = -1; // TODO(jcollard 2022-02-10): This needs to be an `int` not a `bool`

            do
            {
                Console.Write($"Enter a year between 1980 and 2020: ");
                string input = Console.ReadLine();
                bool isAYear = int.TryParse(input, out userChoice);
                if (isAYear == false)
                {
                    Console.Error.WriteLine("You did not enter a year.");
                }

                else if (userChoice < 1980 || userChoice >= 2022) // TODO(jcollard 2022-02-10): You need to use an or here `else if (userChoice <= 1980 || userChoice >= 2022)`
                {
                    Console.WriteLine($"The input was not between 1980 and 2020");
                }
            }
            while (userChoice < 1980 || userChoice >= 2022); // TODO(jcollard 2022-02-10): You need to use an or here `while (userChoice <= 1980 || userChoice >= 2022)`
            return "" + userChoice;





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

            if (validTeams == null) throw new ArgumentNullException("List of options may not be null.");
            if (validTeams.Count == 0) throw new ArgumentNullException("List of options must contain at least 1 option.");

            int ix = 1;
            foreach (string validTeam in validTeams)
            {
                Console.WriteLine($"{ix}. {validTeam}");
                ix = ix + 1;


            }

            int userChoice;

            do
            {
                Console.Write($"Enter a team between 1 and {validTeams.Count}: ");
                string input = Console.ReadLine();
                bool isAvalidTeam = int.TryParse(input, out userChoice);
                if (isAvalidTeam == false)
                {
                    Console.Error.WriteLine("You did not enter a team.");
                }

                else if (userChoice < 1 || userChoice > validTeams.Count) // TODO(jcollard 2022-02-10): You need to use an or here `else if (userChoice <= 1980 || userChoice >= 2022)`
                {
                    Console.WriteLine($"The input was not a valid team");
                }
            }
            while (userChoice < 1 || userChoice > validTeams.Count); // TODO(jcollard 2022-02-10): You need to use an or here `while (userChoice <= 1980 || userChoice >= 2022)`
            return validTeams[userChoice - 1];
            // Feedback(jcollard 2022-02-08): I've written a similar program
            // that you can uas as an example for how to write this method:
            // https://jcollard.github.io/IntroToCSharpSite/examples/display-options

            ;
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
        public static List<string> GetStat(List<string> validStats)
        //    List<string> GetStat = new List<string>(userChoice);
        {
            // 1. Add While loop
            // Create a list
            // 2. Loop until user enters 0.
            // 3. Add to a list
            // 4. Return the list
            // while (userChoice != 0)

            // 1. Check that validStats has at least 1 option
            // 2. If it does not, throw an exception
            // 3. Display the list of validStats
            // 4. Prompt the user to enter a stat
            // 5. If the entered stat is in the list, return that name
            // 6. Otherwise display "Invalid" and goto step 3.

            if (validStats == null) throw new ArgumentNullException("List of options may not be null.");
            if (validStats.Count == 0) throw new ArgumentNullException("List of options must contain at least 1 option.");
            List<string> selectedStats = new List<string>();
            int ix = 1;
            foreach (string validStat in validStats)
            {
                Console.WriteLine($"{ix}. {validStat} - {GetStatInfo(validStat)}");
                ix = ix + 1;


            }
            int userChoice; // TODO(jcollard 2022-02-10): This needs to be an `int` not a `bool`

            do
            {
                Console.WriteLine($"Enter 0 to stop game");
                Console.Write($"Enter an NFL stat: ");
                string input = Console.ReadLine();
                bool isAStat = int.TryParse(input, out userChoice);
                if (isAStat == false)
                {
                    Console.Error.WriteLine("You did not enter a stat.");
                }

                else if (userChoice < 1 || userChoice > validStats.Count) // TODO(jcollard 2022-02-10): You need to use an or here `else if (userChoice <= 1980 || userChoice >= 2022)`
                {
                    Console.WriteLine($"The input was not a valid stat");
                }
                else
                {
                    selectedStats.Add(validStats[userChoice - 1]);
                }

            }
            while (userChoice != 0); // TODO(jcollard 2022-02-10): You need to use an or here `while (userChoice <= 1980 || userChoice >= 2022)`
            return selectedStats;




        }
        /// <summary>
        ///Once the user enters the the stat they want to be displayed 
        /// the message will display the stat name as well as the stat itself
        /// </summary>
        /// <param name="year">The number between 1980 and 2020 the user chose</param>
        /// <param name="team">The choices to display to the user chose</param>
        /// <param name="stat">The choices to display to the user chose</param>
        /// <param name="Displaystat">Displays the stat name when displaying stat</param>
        public static void DisplayStat(string year, string team, string stat)
        {

        }

        public static string GetStatInfo(string rawStat)
        {
            if (rawStat == "passTdPerc")
            {
                return "This is the percentage passing touchdowns a QB threw";
            }
            if (rawStat == "passSackedPerG")
            {
                return "This is the amount of times a QB got sacked per game";
            }
            if (rawStat == "passSacked")
            {
                return "This is the amount of times a QB got sacked in that year";
            }
            if (rawStat == "passCmpPerG")
            {
                return "This is the amount of completions a QB had per game";
            }
            if (rawStat == "passFd")
            {
                return "This is the amount of passing first downs in that year";
            }
            if (rawStat == "passSackedPerc")
            {
                return "This is the percentage a QB got sacked in that year";
            }
            if (rawStat == "passRating")
            {
                return "Passer rating is calculated using a player's passing attempts, completions, yards, touchdowns, and interceptions and is on a scale from 0 to 158.3. ";
            }
            if (rawStat == "passIntPerG")
            {
                return "This is the passing interception per game";
            }
            if (rawStat == "passTdPerG")
            {
                return "This is the passing touchdowns per game";
            }
            if (rawStat == "passNetYdsPerAtt")
            {
                return "This is a stat incorporated passing yards, sacks, touchdowns and interceptions";
            }
            if (rawStat == "passFdperG")
            {
                return "This is the amount of passing first downs per game";
            }
            if (rawStat == "passCmpPerc")
            {
                return "This is the percentage of completions in that year";
            }
            if (rawStat == "passSackedYds")
            {
                return "This is the amount of yards the QB got sacked in that year";
            }
            if (rawStat == "passYdsPerG")
            {
                return "This is the amount of passing yards per game";
            }
            if (rawStat == "passCmp")
            {
                return "This is the amount of pass completions that year";
            }
            if (rawStat == "passIntPerc")
            {
                return "This is the interception percentage of that year";
            }
            if (rawStat == "passInt")
            {
                return "This is the amount of passing interceptions in that year";
            }
            if (rawStat == "passYdsPerCmp")
            {
                return "This is the amount passing yards per completion in that year";
            }
            if (rawStat == "passAtt")
            {
                return "This is the amount of attempts in that season";
            }
            if (rawStat == "passAttPerG")
            {
                return "This is the amount of pass attempts per game";
            }
            if (rawStat == "passLong")
            {
                return "This is the long completion the QB made in that year";
            }
            if (rawStat == "passYds")
            {
                return "This is the total amount of passing yards in that year";
            }
            if (rawStat == "passSackedYdsPerG")
            {
                return "This is amount of yards a QB got sacked per game";
            }
            if (rawStat == "passFdPerG")
            {
                return "This is the amount of first downs per game";
            }

            return null;
        }

    }
}

