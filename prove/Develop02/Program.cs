using System;
using System.IO;
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

                Entry _entry = new Entry();
                _entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                _entry._promptText = prompt;
                _entry._entryText = answer;
                
                journal.AddEntry(_entry); 
                
            }

            else if (choice == "2")
            {
                journal.DisplayAll();
            }

            else if (choice == "3") // Load files
            {
                journal.LoadFromFile();
                Console.WriteLine("File loaded sucessfully!");
            }
            else if (choice == "4") //Save files
            {
                 journal.SaveToFile();
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

            Console.WriteLine(); 
        }      
    }
}