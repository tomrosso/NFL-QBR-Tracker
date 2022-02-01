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
            List<string> validTeams = new List<string>();
            {
                validTeams.Add("Cardinals");
                validTeams.Add("Falcons");
                validTeams.Add("Panthers");
                validTeams.Add("Bears");
                validTeams.Add("Cowboys");
                validTeams.Add("Lions");
                validTeams.Add("Packers");
                validTeams.Add("Rams");
                validTeams.Add("Vikings");
                validTeams.Add("Saints");
                validTeams.Add("Giants");
                validTeams.Add("Eagles");
                validTeams.Add("49ers");
                validTeams.Add("Seahawks");
                validTeams.Add("Buccaneers");
                validTeams.Add("Team");
                validTeams.Add("Ravens");
                validTeams.Add("Bills");
                validTeams.Add("Bengals");
                validTeams.Add("Browns");
                validTeams.Add("Broncos");
                validTeams.Add("Texans");
                validTeams.Add("Colts");
                validTeams.Add("Jaguars");
                validTeams.Add("Chiefs");
                validTeams.Add("Raiders");
                validTeams.Add("Chargers");
                validTeams.Add("Dolphins");
                validTeams.Add("Patriots");
                validTeams.Add("Jets");
                validTeams.Add("Steelers");
                validTeams.Add("Titans");
                string result = Program.GetTeam(validTeams);

                return true;
            }

        }
    }
}