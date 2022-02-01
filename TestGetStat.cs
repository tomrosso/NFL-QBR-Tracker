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

  
    List<string> validStats = new List<string>();
    {
    validStats.Add("QBR");
    validStats.Add("Rushing yds per game");
    validStats.Add("Passing yds per game");
    validStats.Add("INTs per game");
    validStats.Add("Completion % per game");
    validStats.Add("Pass attempts per game");
    validStats.Add("Touchdowns per game");
    validStats.Add("Total touchdowns");
    validStats.Add("Total passing yds");
    validStats.Add("Total rushing yds");
    validStats.Add("Total INTs");
    validStats.Add("Total pass attempts");
    string result = Program.GetStat(validStats);
    }
    
    return true;
}
   
    }
}