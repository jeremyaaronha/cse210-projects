using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your grade percentage: ");
        string userPercentageString = Console.ReadLine();

        int userPercentageInt = int.Parse(userPercentageString);

        string grade = "";

        if (userPercentageInt >= 90)
        {
            grade = "A";
        }
        else if(userPercentageInt >=80 && userPercentageInt < 90)
        {
            grade = "B";
        }
        else if(userPercentageInt >=70 && userPercentageInt < 80)
        {
            grade = "C";
        }
        else if(userPercentageInt >=60 && userPercentageInt < 70)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (userPercentageInt >= 70)
        {
            Console.WriteLine("You pass!");
        }
        else
        {
            Console.WriteLine("You don't pass, you can do it better next time!");
        }


    }
}