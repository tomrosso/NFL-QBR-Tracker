# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

A person would run my program to get a QB stat from a certain year to inform themselves on the performance of that team during that year

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates my program displaying information to the user.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

My program accepts user input from the keyboard. They enter a year between 1980 and 2020 and outputs a list of teams the user can choose from. The user then inputs a number between 1-32 which will lead the program to display a list of QB stats. The user then finally inputs a number that correlates to the stat they wanted and the program will output that stat.
## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
   List<string> validTeams = new List<string>();

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
            validTeams.Add("Commanders");
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
```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
 foreach (string validTeam in validTeams)
            {
                Console.WriteLine($"{ix}. {validTeam}");
                ix = ix + 1;


            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

**TODO: Write, The list is stored in "validTeams"

### 3b iv.

This list contains the valid teams that can be chosen.

**TODO: Write a sentence describing what is stored in the list**

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

**TODO: Explain why it would be very difficult (or impossible) to write 
the program without using the list.**

My list contains 32 teams. This list could be written with 32 if / else statements. This list manages complexity by allowing the user selected index to select the team directly. This also allows me to add new teams easily, if 
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

                else if (userChoice < 1 || userChoice > validTeams.Count) /
                {
                    Console.WriteLine($"The input was not a valid team");
                }
            }
            while (userChoice < 1 || userChoice > validTeams.Count); // 
            return validTeams[userChoice - 1];
    
            
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
