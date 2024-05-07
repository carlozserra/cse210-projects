using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {   
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal ();

        while (true)
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"Prompt: {prompt}");

                Console.Write("Your answer: ");
                string answer = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                entry._promptText = prompt;
                entry._entryText = answer;
                
                journal.AddEntry(entry); 
                
            }

            else if (choice == "2 display")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the file name?");
               string filename = Console.ReadLine();
                journal.LoadFromFile(a);
            }
            else if (choice == "4")
            {
               Console.WriteLine("What is the file name?");
               string filename = Console.ReadLine();
                journal.SaveToFile(filename);
                
            }
            else if (choice == "5")
            {
                Console.WriteLine("Exiting...");
                break; 
            }
            else
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 5.");
            }

            Console.WriteLine(); // Empty line for readability
        }      
    }
}