using System;

class Program
{
    static void Main(string[] args)
    {
       var choice = "";
       do
       {
       Console.WriteLine("Choose a option:");
       Console.WriteLine("1.Breathing Activity");
       Console.WriteLine("2.Reflection Activity");
       Console.WriteLine("3.Listing Activity");
       Console.WriteLine("4. Quit");

       choice = Console.ReadLine();

        if ( choice == "1")
        {
            Console.Clear();
            BreathingActivity breathingActivity = new BreathingActivity();   
            breathingActivity.Run();     
        }
        else if ( choice == "2")
        {
            Console.Clear();
            ReflectingActivity  reflectingActivity = new ReflectingActivity();
            reflectingActivity.Run();
        }
        else if ( choice == "3")
        {   
            Console.Clear();
            ListingActivity listingActivity = new ListingActivity();
            listingActivity.Run();
        }
        else if (choice == "4")
        {
            Console.WriteLine("Goodbye!");
        }

        else 
        {
            Console.WriteLine("Invalid choice, try again");
        }

        }while (choice != "4");
    }
}