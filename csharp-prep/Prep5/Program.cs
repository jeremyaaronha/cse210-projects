using System;

class Program
{
    static void Main(string[] args)
    {

        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber);


    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string userResponse = Console.ReadLine();
        userNumber = int.Parse(userResponse);
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        squareNumber = number ** 2;
        return squareNumber;
    }

    static int DisplayResult(string userName, int squareNumber)
    {
           
        Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
    }


    }
}