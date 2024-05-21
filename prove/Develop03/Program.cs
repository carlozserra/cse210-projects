using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Press Enter to hide a word or type 'quit' to exit...");  

        Reference reference = new Reference("Moses", 1,39,1);
        Scripture scripture = new Scripture(reference,"This is my work and my glory—to bring to pass the immortality and eternal life of man.");
         
          while (!scripture.IsCompletelyHidden())
        {
            
            string input = Console.ReadLine();
            Console.WriteLine(reference.GetDisplayText());
            Console.WriteLine(scripture.GetDisplayText());
             //Console.Clear(); this line isn't working in my computer!! 
            scripture.HideRandomWords(1);

           
        }   
    }
}