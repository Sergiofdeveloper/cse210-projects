using System;
using System.Collections.Generic;
using System.IO;
 

public class Program
{
    // list _goals store the goals chosen by user.
    private static List<Goal> _goals = new List<Goal>();
    private static int totalPoints = 0;
    public static void Main()
    {
        // Display current amount of user´s points
        DisplayPoints();
        //  while loop runs until user select quit (variable becomes true)
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create a New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            string choice = Console.ReadLine();

            // different methods are called depending on the choice
            if (choice == "1")
            {
                NewGoal();
            }
            else if (choice == "2")
            {
                ListGoals();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                RecordEvent();
            }
            else if (choice == "6")
            {
                quit = true;
            }
            else
            {
                Console.WriteLine("Wrong Choice. Try again.");
            }

            Console.WriteLine();
        }
    }

    private static void NewGoal()
    {
        // Display the diffent types of goals avaiblable
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type of Goal would you like to create? ");
        //store user´s choice in goalChoice
        string goalChoice = Console.ReadLine();
        Console.Write("What is the name of your Goal? ");
        string name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        //Value variable stores the number of points set for the goal
        int value;

        //if choice is 1 or 2 points are assigned to the value variable as integer.
        if (goalChoice == "1" || goalChoice == "2")
        {
            Console.Write("What is the amount of points associated with this goal? ");
            value = int.Parse(Console.ReadLine());
        }
        
        else if (goalChoice == "3")
        {
            //if choice is 3 points are assigned to the value variable as integer.
            Console.Write("What is the amount of points associated with this goal? ");
            value = int.Parse(Console.ReadLine());
            // Number of repetitions are store as integer in respCount.
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int repsCount = int.Parse(Console.ReadLine());
            // Bonus points are store in bonusValue as integer.
            Console.Write("What is the bonus value for this checklist goal? ");
            int bonusValue = int.Parse(Console.ReadLine());

            // Add ChecklistGoal to list _goals through .Add method.
            Goal goal = new ChecklistGoal(name, description, value, repsCount, bonusValue);
            _goals.Add(goal);
            // exits the method after adding the goal to the list.
            return; 
        }
        else
        {
            Console.WriteLine("Wrong Choice. Try again.");
            return;
        }

        //Depending on user choice object is created
        Goal typeGoal;
        if (goalChoice == "1")
        {
            typeGoal = new SimpleGoal(name, description, value);
        }
        else
        {
            typeGoal = new EternalGoal(name, description, value);
        }
        //Object is added to _goals list
        _goals.Add(typeGoal);
    }

    //Displays list of goals stored in _goals
    private static void ListGoals()
    {
        Console.WriteLine("The goals are:");
           //iterates in every element of _goals list until all goals have been displayed
        for (int i = 0; i < _goals.Count; i++)
        {
            //current goal is get form _goals and stored in variable
            Goal goal = _goals[i];
            //if IsCompleted is true [x], else []
            string status = goal.IsCompleted ? "[X]" : "[ ]";
            //Displays info about the goal
            Console.WriteLine($"{status} {goal.Name} ({goal.Description})");
        }
    }

    private static void SaveGoals()
    {
        Console.Write("What is the name for the goal file? ");
        //name chosen by user stored in variable fileName
        string fileName = Console.ReadLine();
        //StreamWriter create and writes the file
        using (StreamWriter writer = new StreamWriter(fileName))
        {
            //first line in the file, current user´s points by calling on GetTotalPoints
            writer.WriteLine(GetTotalPoints());

            foreach (Goal goal in _goals)
            {
                //Gets the type of the goal and stores it in goalType variable
                string goalType = goal.GetType().Name;
                //stores the info of the goal and stores it in the variable goalDetails
                string goalDetails = $"{goal.Name},{goal.Description},{goal.Value}";

                //if goal is an instance of ChecklistGoal has more properties and adds them to goalDetails
                if (goal is ChecklistGoal checklistGoal)
                {
                    goalDetails += $",{checklistGoal.CompletionCount},{checklistGoal.BonusValue}";
                }
                //writes a line in the file with the details, separated by commas
                writer.WriteLine($"{goalType},{goalDetails}");
            }
        }
    }

    private static void LoadGoals()
    {
        Console.Write("What is the name of the file? ");
        //name chosen by user stored in variable fileName
        string fileName = Console.ReadLine();
        //check if file already exist, else displays message
        if (File.Exists(fileName))
        {
            //StreamReader reads from the file
            using (StreamReader reader = new StreamReader(fileName))
            {
                //reads the first line, with the current user´s points
                string totalPointsLine = reader.ReadLine();
                //store the point in variable totalPoints after turning into integer
                int.TryParse(totalPointsLine, out int totalPoints);
                //variable goalLine is declared with no value yet
                string goalLine;

                //loops read every line until there is no more lines
                while ((goalLine = reader.ReadLine()) != null)
                {
                    //Split into strings separated by commas 
                    string[] parts = goalLine.Split(',');

                    //checks if split parts have 4 elements (type, name, description, points)
                    if (parts.Length >= 4)
                    {
                        string goalType = parts[0];
                        string name = parts[1];
                        string description = parts[2];
                        int value = int.Parse(parts[3]);

                        //depending on the type of goal it creates an object with all the attributes
                        Goal goal;
                        if (goalType == "SimpleGoal")
                        {
                            goal = new SimpleGoal(name, description, value);
                        }
                        else if (goalType == "EternalGoal")
                        {
                            goal = new EternalGoal(name, description, value);
                        }
                        else if (goalType == "ChecklistGoal")
                        {
                            //when is a ChecklistGoal verifies if has 6 elements and extracts properties and create a Checklistgoal object.
                            if (parts.Length >= 6)
                            {
                                int completionCount = int.Parse(parts[4]);
                                int bonusValue = int.Parse(parts[5]);
                                goal = new ChecklistGoal(name, description, value, completionCount, bonusValue);
                            }
                            else
                            {
                                Console.WriteLine($"Invalid goal format: {goalLine}");
                                continue;
                            }
                        }
                        else
                        {
                            
                            continue;
                        }

                        _goals.Add(goal);
                    }
                    
                }
            }
        }
        else
        {
            Console.WriteLine("File not found. Try again.");
        }
    }

    private static int GetTotalPoints()
    {
        //start variable totalPoints with 0 value
        int totalPoints = 0;

        foreach (Goal goal in _goals)
        {
            //if current goal is completed and is not checklistGoal 
            if (goal.IsCompleted && !(goal is ChecklistGoal))
            {
                //adds value to totalpoints variable
                totalPoints += goal.Value;
            }
        }

        return totalPoints;
    }


    private static string GetStringRepresentation(Goal goal)
    {
        //Creates a string representation separated by commas
        string goalType = goal.GetType().Name;
        //all combined form goalDetails string
        string goalDetails = $"{goal.Name},{goal.Description},{goal.Value},{goal.IsCompleted}";
        return $"{goalType}:{goalDetails}";
    }

    private static Goal CreateGoal(string goalString)
    {
        //splits goalString in 2 parts using ":" 
        string[] parts = goalString.Split(':');
        //check if parts has 2 elements
        if (parts.Length == 2)
        {
            string goalType = parts[0];
            string goalDetails = parts[1];

            string[] details = goalDetails.Split(',');

            if (details.Length >= 5)
            {
                string name = details[0];
                string description = details[1];
                int value = int.Parse(details[2]);
                bool isCompleted = bool.Parse(details[3]);
                int repsCount = int.Parse(details[4]);

                if (goalType == "SimpleGoal")
                {
                    return new SimpleGoal(name, description, value);
                }
                else if (goalType == "EternalGoal")
                {
                    return new EternalGoal(name, description, value);
                }
                else if (goalType == "ChecklistGoal")
                {
                    int bonusValue = 0;
                    if (details.Length >= 6)
                    {
                        bonusValue = int.Parse(details[5]);
                    }

                return new ChecklistGoal(name, description, value, repsCount, bonusValue);
            }
        }
    }

    return null;
}

    private static void DisplayPoints()
    {
    int totalPoints = 0;

    foreach (Goal goal in _goals)
    {
        if (goal.IsCompleted)
        {
            totalPoints += goal.Value;
        }
    }

    Console.WriteLine($"You have {totalPoints} points");
}

    private static void RecordEvent()
    {
        Console.WriteLine("Record Event:");
        Console.WriteLine("Select a goal to mark as completed:");

        for (int i = 0; i < _goals.Count; i++)
        {
            Goal goal = _goals[i];
            Console.WriteLine($"{i + 1}. {goal.Name}");
        }

        Console.Write("Enter the number of the goal: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            Goal goal = _goals[goalIndex];

            if (!goal.IsCompleted)
            {
                if (goal is ChecklistGoal checklistGoal)
                {
                    if (!checklistGoal.IsCompleted)
                    {
                        checklistGoal.MarkCompleted(ref totalPoints);
                        int earnedPoints = goal.Value + checklistGoal.BonusValue;
                       // Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
                        Console.WriteLine($"You now have {totalPoints} points.");
                    }
                    else
                    {
                        Console.WriteLine("That Goal is no longer available.");
                    }
                }
                else
                {
                    goal.MarkCompleted(ref totalPoints);
                    int earnedPoints = goal.Value;
                    Console.WriteLine($"Congratulations! You have earned {earnedPoints} points!");
                    Console.WriteLine($"You now have {totalPoints} points.");
                }
            }
            else
            {
                Console.WriteLine("That Goal is no longer available.");
            }
        }
        else
        {
            Console.WriteLine("Wrong choice. Try again.");
        }
    }
}