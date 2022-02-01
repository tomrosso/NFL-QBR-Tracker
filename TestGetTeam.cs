using System;
using System.Collections.Generic;


namespace NFL_QBR_Tracker
{
    public class TestGetTeam
    {

public static bool RunTest()
{
    Console.WriteLine("Running GetTeam(List<string> validTeams). It should produce a message asking you to enter a team.");
    Console.WriteLine("Enter Tigers, then Cubs, and then Patriots. Should say invalid, invalid, valid.");
    string result = Program.GetTeam(List<string> validTeams);
    if (result != "Patriots")
    {
        return false;
    }
    
    return true;
}
   
    }
}