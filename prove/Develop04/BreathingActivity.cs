using System;
public class BreathingActivity : Activity
{

    public BreathingActivity()
    {
        _name = "Breathing Activity. \n";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        
       
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.Write("\n set the session time you would like in seconds: "); //gets the user time 
        string input = Console.ReadLine(); //gets the user time 
        Console.Clear();
        Console.WriteLine("Get Ready...");
        _duration = int.Parse(input); //convert string to integer

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        
        do
        {
            ShowSpinner(5);
            Console.Write(" \n Breathe in...");
            ShowCountDown (5); 
            Console.Write("\n Now Breathe out...");
            ShowCountDown (5);

         } while(DateTime.Now < endTime);

        DisplayEndingMessage();
    }
}