using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101);

        Console.WriteLine("What is the Guess ?");
        string userGuess = Console.ReadLine();
        int guess = int.Parse(userGuess);

         while (guess != number)

         {
                Console.Write("What is the Guess ?");
                guess = int.Parse(Console.ReadLine());
                
            if (guess == number)
            {
            Console.WriteLine("congrats! you nealed it!");
            }

            else if (guess < number)
            {
            Console.WriteLine("Try higher!");
            }

            else
            {
            Console.WriteLine("Try lower!");
            }

         }
    }
}