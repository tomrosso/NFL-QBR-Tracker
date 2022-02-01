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
    string result = Program.GetTeam(List<string> validStats);
    if (result != "QBR")
    {
        return false;
    }
    
    return true;
}
   
    }
}