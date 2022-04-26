# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would run my program to get a learn about QB stats in general and be able to see QB stats from a certain year to inform themselves on the productivity of the quarterback for that team during that year

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates my program displaying information to the user.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard. The user will be asked to enter a year between 1980 and 2020 and the program outputs a list of teams the user can choose from. The user then inputs a number between 1 and the amount of teams that year which will lead the program to display a list of QB stats. The user then finally can input multiple numbers that correlate to the stats they wanted and then the user will input 0 when they want to display the stat numbers. The program will prompt the user to either answer yes to continue running the program or enter no to end the program.
## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
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

```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
  foreach (string validStat in validStats)
            {
                Console.WriteLine($"{ix}. {validStat} - {GetStatInfo(validStat)}");
                ix = ix + 1;


            }

```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

**TODO: Write, The list is stored in "validStats"

### 3b iv.

This list contains the valid stats that can be chosen.

**TODO: Write a sentence describing what is stored in the list**

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

**TODO: Explain why it would be very difficult (or impossible) to write 
the program without using the list.**

My list contains 23 stats. This list could be written with 23 if / else statements. This list manages complexity by allowing the user selected index to select the stat directly. This also allows me to add new stats easily, if 
I didn't have a list I would have to create additional variables.
## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
         public static string GetTeam(List<string> validTeams)
        {
 

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

                else if (userChoice < 1 || userChoice > validTeams.Count)
                {
                    Console.WriteLine($"The input was not a valid team");
                }
            }
            while (userChoice < 1 || userChoice > validTeams.Count);
            return validTeams[userChoice - 1];
           
            ;
        }

```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
  string team = GetTeam(validTeams);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.
        /// <summary>
        /// Given a prompt to show the user, displays the prompt then reads
        /// input from keyboard until user types in a team displayed.
        /// If the user does not enter a team displayed the message displays an error
        /// message and prompts the user again.
        


### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

            // 1. Check that validTeams has at least 1 option
            // 2. If it does not, throw an exception
            // 3. Display the list of validTeams
            // 4. Prompt the user to enter a team name
            // 5. If the entered name is in the list, return that name
            // 6. Otherwise display "Invalid" and goto step 3.

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

GetTeam(null)

Second call:
GetTeam(validTeams)

**TODO: Complete this section**

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
This tests that the method fails when the input is null by throwing an exception

Condition(s) tested by the second call:

This tests that the method runs when the input is not null.

**TODO: Complete this section**

### 3d iii.

Result of the first call:
The result is an exception is thrown.


Result of the second call:

The result is a list of QB stats being generated.
