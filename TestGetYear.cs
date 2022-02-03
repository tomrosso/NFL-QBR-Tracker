using System;
using System.Collections.Generic;


namespace NFL_QBR_Tracker
{
    public class TestGetYear
    {

public static bool RunTest()
{
    Console.WriteLine("Running GetYear(). It should produce a message asking you to enter a year.");
    Console.WriteLine("Enter 2, then 2025, and then 2019. Should say invalid, invalid, valid.");
    string result = Program.GetYear();
    if (result != "2019")
    {
        Console.WriteLine($"Invalid input, expected 2019 but received {result}");
        return false;
    }
    
    return true;
}
   
    }
}