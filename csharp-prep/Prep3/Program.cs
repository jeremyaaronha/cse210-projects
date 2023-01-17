using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,101);

        Console.WriteLine("");
        
        do
        {
            Console.Write("What is your guess?: ");
            string guess = Console.ReadLine();
            int userGuess = int.Parse(guess);


            if (userGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (userGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guess it!");
            }
        } while ( userGuess != magicNumber);


    }
}