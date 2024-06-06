using System;
using System.IO;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    
    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;

        //it needs to call each
        //type of goal.
        //display the second menu
    }
    
    public void Start()
    {
        string choice = "";
        do  
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goal");
            Console.WriteLine("4. Load goal");
            Console.WriteLine("5. Record goal");
            Console.WriteLine("6. Quit");
            Console.WriteLine($"\n You have {_score} points. \n");
            Console.Write("Enter your choice: ");

            
            
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
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

        } while (choice != "6");
        //display main menu and display player info
        //call
        //createGoal, listGoaldetailss, Save and Load Goals
        //record events
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Current Score: {_score}");
    }

    public void ListGoalName()
    {
        for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{_goals[i]}.{_goals[i].GetDetailsString()}");
            }
        //Loop through the list of goals
        // and display the names
    }

    public void ListGoalDetails()
    {
        for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{_goals[i]}.{_goals[i].GetDetailsString()}");
            }
        //Loop through the list of
        //goals and display the full details
    }
    public void CreateGoal()
    {   
        Console.WriteLine("Select from menu: ");
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        string choice = Console.ReadLine();

        //asking the user the same questions for all the three options
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter goal points: ");
        int points = int.Parse(Console.ReadLine());

        if (choice ==  "1")
        {
         _goals.Add(new SimpleGoal(name, description, points));
        }
        if (choice ==  "2")
        {
            _goals.Add(new EternalGoal(name, description, points));
        }
        if (choice ==  "3")
        {
             Console.Write("Enter target amount: ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("Enter bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
        }


   // display sub menu to ask the goal 
      //type and ask for the name and description 
    }   // and points   
            // ask for more if it is a checklist goal 
            //create the object and add to the goal list //IT WAS DONE 

    public void RecordEvent()
    {
        Console.WriteLine("Which Goal did you accomplish?");
        int index = int.Parse(Console.ReadLine());

        if (index >= 0 && index < _goals.Count )
        {
            _score += _goals[index].RecordEvent();
        }

        Console.WriteLine($"Current Score: {_score}");
        //display a list of all of the goal names
    }   //ask user to select a goal
         // call recdord event on the correct goal
        // update the score based on the points
        // display current points //IT WAS DONE 

    public void SaveGoals()
    {
        Console.WriteLine("What is the Filename? ");

        string filename = Console.ReadLine();
        
        using (StreamWriter txt = new StreamWriter(filename))
        {      
            txt.WriteLine(_score);
            foreach (Goal goal in _goals)
            {
                txt.WriteLine(goal.GetStringRepresentation());
            }

        }

        //ask the user for the goal name
        //loop through the goals and convert
        //each goal to a string and save the string
          
    }
    
    public void LoadGoals()

    {
        Console.Write("Enter filename to load goals: ");
        string filename = Console.ReadLine();

        using StreamReader txt = new StreamReader(filename);
        {
            
             string[] lines = File.ReadAllLines(filename);
             _score = int.Parse(lines[0]);

             foreach (string line in lines)
             {
                string[] parts = line.Split(", ");
                string goalType = parts[0].Split(":")[0];
                string name = parts[1];
                string description = parts[2];
                int points = int.Parse(parts[3]);

            }
        }
    }   
}       

            
        //ask the user for the file name
        // read each line of the file and split it up
        // use the parts to re-create the goal object
        //{_shortName}, {_description}, {_points}, {_amountCompleted}/{_target}, Bonus: {_bonus}
    

