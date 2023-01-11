using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numbers = new List<int>();

        do 
        {
            Console.Write("Enter a number: ");
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);

            numbers.Add(userNumber);

        } while (userNumber != 0);

        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        countNumbers = Console.WriteLine(numbers.count);
        float average = (sum/countNumbers);
        Console.WriteLine($"Average: {average}");

        int largestNumber = numbers.Max();
        Console.WriteLine($"The largest number is: {largestNumber}");
        
        Console.WriteLine(numbers.Sort());

    }
}