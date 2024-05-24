using System;
public class Activity{

    protected string _name;
    protected string _description;
    protected int _duration;


    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine($" \n Congrats, you did it!");
        ShowSpinner(5);
        Console.Clear(); 

    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");

        foreach (string a in animation)
        {
            Console.Write(a);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {   
        
        for (int i = seconds; i>=0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
         
    }
    
}

