using System;
using System.Collections.Generic;


namespace NFL_QBR_Tracker
{
    public class TestDisplayStat
    {

        public static bool RunTest()
        {
            //         public static void DisplayStat(string year, string team, string stat)
            Console.WriteLine("Running DisplayStat(string year, string team, string stat). It should produce multiple messages asking you to enter a Year, Team and a QB stat.");
            Console.WriteLine("1992, Rams, and then Total passing yds. It should give you 3218 yds.");
            Program.DisplayStat("1992", "Rams", "Total passing yds");
            Program.DisplayStat("2000", "Saints", "Total rushing yds");
            Console.WriteLine("2000, Saints, and then Total rushing yds. It should give you 349 yds.");
            Program.DisplayStat("1980", "Colts", "QBR");
            Console.WriteLine("1980, Colts, and then QBR. It should give you 73.491%.");

            return false;
        }

    }
}