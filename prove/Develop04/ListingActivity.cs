using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;

    public ListingActivity()
    {       
        _name = "Listing Activity. \n";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _prompts = new List<string>
         {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    public void Run()
    {

        DisplayStartingMessage();

        Console.Write("\n set the session time you would like in seconds: "); //gets the user time 
        string input = Console.ReadLine(); //gets the user time 
        Console.Clear();
        Console.WriteLine("Get Ready...");
        ShowSpinner(5);
    
    
        
        _duration = int.Parse(input);
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
      
      
        GetRandomPrompt();
        List<string> userItems = GetFromUser(endTime);
        _count = userItems.Count;
        Console.WriteLine($"You listed {_count} items.");
        DisplayEndingMessage();
        
        
    }

    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine($"---{prompt}---");
    }

    public List<string> GetFromUser(DateTime endTime)
    {   
        List<string> userItems = new List<string>();
        while (DateTime.Now < endTime)
        {
                string input = Console.ReadLine();
                userItems.Add(input);
        }
        return userItems;
    }
 }  


