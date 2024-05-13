using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a Scripture object
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
        Reference reference2 = new Reference("Jeremiah", 1, 4, 5);
        Scripture scripture2 = new Scripture(reference2, "Before I formed thee in the belly … I ordained thee a prophet unto the nations.");
        Reference reference3 = new Reference("Isaiah", 5, 20);
        Scripture scripture3  = new Scripture(reference3, "“Woe unto them that call evil good, and good evil.");

        // Initial display
        Console.WriteLine(scripture.GetDisplayText());

        // Interaction loop
          string input = "";
        while (!scripture.IsCompletelyHidden() && input != "quit")
        {
            input = Console.ReadLine();
            if (input != "quit")
            {
                // Hide a few random words
                scripture.HideRandomWords(4);
                // Clear the console and display the scripture again
                Console.WriteLine(scripture.GetDisplayText());

                // Hide a few random words
                scripture2.HideRandomWords(4);
                // Clear the console and display the scripture again
                Console.WriteLine(scripture2.GetDisplayText());

                 // Hide a few random words
                scripture3.HideRandomWords(4);
                // Clear the console and display the scripture again
                Console.WriteLine(scripture3.GetDisplayText());
                
            }

        
            {
                
            }
        }
    }  
        

}  