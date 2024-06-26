using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public ReflectingActivity()
    {
         _name = "Reflecting Activity. \n";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
        _prompts = new List<string>
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };

        _questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
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

       
        DisplayPrompt();
        DisplayQuestions();
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];

    }
    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(_questions.Count);
        return _questions[index];
        
    }
    public void DisplayPrompt()
    {
          Console.WriteLine("Consider the following prompt: \n" + GetRandomPrompt());
          Console.WriteLine("\n Press Enter when you have something in mind: ");
          Console.ReadLine();
        
    }
    
    public void DisplayQuestions()
    {
 
         int elapsedSeconds = 0;
        while (elapsedSeconds < _duration)
        {
            string question = GetRandomQuestion();
            Console.WriteLine("\n" + question);
            ShowSpinner(5); // Pause for 5 seconds to reflect on the question
            elapsedSeconds += 5;
        }
    }
}
