using System;
using System.Collections.Generic;


namespace NFL_QBR_Tracker
{
    public class TestGetStat
    {

public static bool RunTest()
{
    Console.WriteLine("Running GetStat(List<string> validStats). It should produce a message asking you to enter a QB stat.");
    Console.WriteLine("Enter Shots Per Game, then tackles, and then QBR. Should say invalid, invalid, valid.");
     // TODO(jcollard 2022-02-01): You should rewrite this as:
    //  List<string> validStats = new List<string>();
    //  validStats.Add("QBR");
    //  validStats.Add("???");
    // Add more stats
    // Then finally call GetTeam with the list
    //  string result = Program.GetTeam(validStats);

    string result = Program.GetTeam(List<string> validStats);
    if (result != "QBR")
    {
        return false;
    }
    
    return true;
}
   
    }
}