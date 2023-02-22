using System;
using System.Threading;
using System.Diagnostics;


class Program
{
    static void Main(string[] args)
    {
        int _menuChoice = 0;
        int _breathingCounter = 0;
        int _reflectionCounter = 0;
        int _listingCounter = 0;

        do
        {
            Console.WriteLine("Select your activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Activities Performed Count");
            Console.WriteLine("5.Quit");

            // Leer la entrada del usuario y convertirla en un número entero
            int.TryParse(Console.ReadLine(), out _menuChoice);
            Console.Clear();
            // Ejecutar la actividad correspondiente al número del menú seleccionado
            switch (_menuChoice)
            {
                case 1:

                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.ShowStartMessage();
                    breathingActivity.DoBreathingActivity();
                    _breathingCounter += 1;
                    breathingActivity.ShowEndMessage();
                    
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.ShowStartMessage();
                    reflectionActivity.DoReflectionActivity();
                    _reflectionCounter += 1;
                    reflectionActivity.ShowEndMessage();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.ShowStartMessage();
                    listingActivity.DoListingActivity();
                    _listingCounter += 1;
                    listingActivity.ShowEndMessage();
                    break;
                case 4:
                    Console.WriteLine($"Times Breathing Activity has been performed: {_breathingCounter}");
                    Console.WriteLine();
                    Console.WriteLine($"Times Reflection Activity has been performed: {_reflectionCounter}");
                    Console.WriteLine();
                    Console.WriteLine($"Times Listing Activity has been performed: {_listingCounter}");
                    Console.WriteLine();
                    break;
                case 5:
                    break;
                default:
                    Console.WriteLine("Please, select a valid option.");
                    break;
            }
            
             

        } while (_menuChoice != 5);
    }
}
// Base class for all activities
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name,string description)
    {
        _name = name;
        _description = description;
    }

    public void ShowStartMessage()
    {
        Console.WriteLine($"Starting {_name}");
        Console.WriteLine($"Description: {_description}");
        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Prepare to begin...");
        ShowAnimation();
    }

    // Common ending message for all activities
    public void ShowEndMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Great job!");
        Console.WriteLine($"You have completed {_name} for {_duration} seconds.");
        ShowAnimation();
        Console.WriteLine();
    }

    public void ShowAnimation()
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        TimeSpan animationDuration = TimeSpan.FromSeconds(3);
        while (stopwatch.Elapsed < animationDuration)
        {
            Console.Write("/");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(500);
            Console.Write("\b \b");
        }
    }
}

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {
    }

    public void DoBreathingActivity()
    {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            TimeSpan duration = TimeSpan.FromSeconds(_duration);

            while(stopwatch.Elapsed < duration)
            {
                Console.WriteLine();
                Console.Write("Breathe in....");
                for (int i = 3; i >= 1; i--)
                {
                    Console.Write("\b \b"); // Move cursor to beginning of line
                    Console.Write($"{i}");
                    Thread.Sleep(1000); // Pause for 1 second
                }
                Console.Write("\b \b"); // Move cursor to beginning of line
                Console.WriteLine();


                Console.WriteLine();
                Console.Write("Breathe out....");
                for (int i = 3; i >= 1; i--)
                {
                    Console.Write("\b \b"); // Move cursor to beginning of line
                    Console.Write($"{i}");
                    Thread.Sleep(1000); // Pause for 1 second
                }
                Console.Write("\b \b"); // Move cursor to beginning of line
                Console.WriteLine();
            }
            stopwatch.Stop();
    }
}


public class ReflectionActivity : Activity
{
    private string _prompt;

    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
        };

    private string[] _questions = {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
        };

    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void DoReflectionActivity()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();

        Random _rand = new Random();
        _prompt = this._prompts[_rand.Next(this._prompts.Length)];
        Console.WriteLine($"--- {_prompt} ---");

        Console.WriteLine();

        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in:  ");
        for (int i = 3; i >= 1; i--)
        {
            Console.Write("\b \b"); // Move cursor to beginning of line
            Console.Write($"{i}");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.Write("\b \b"); // Move cursor to beginning of line
        Console.WriteLine();
        Console.Clear();

        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        
        List<string> shuffledQuestions = this._questions.OrderBy(q => _rand.Next()).ToList();
        int j = 0;
        while (stopwatch2.Elapsed < duration && j < shuffledQuestions.Count)
        {
            Console.Write(shuffledQuestions[j]);
            ShowAnimation();
            ShowAnimation();
            Console.WriteLine();
            j++;
        }
    }

}

public class ListingActivity : Activity
{

    private string[] _listingPrompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }
    
    public void DoListingActivity()
    {
        Console.WriteLine();

        Console.WriteLine("List as many responses you can to the following prompt: ");

        Console.WriteLine();

        Random _listingRand = new Random();
        string _listingPrompt = this._listingPrompts[_listingRand.Next(this._listingPrompts.Length)];
        Console.WriteLine($"--- {_listingPrompt} ---");

        Console.WriteLine();

        Console.Write("You may begin in:  ");
        for (int i = 3; i >= 1; i--)
        {
            Console.Write("\b \b"); // Move cursor to beginning of line
            Console.Write($"{i}");
            Thread.Sleep(1000); // Pause for 1 second
        }
        Console.Write("\b \b"); // Move cursor to beginning of line
        Console.WriteLine();

        Stopwatch stopwatch3 = new Stopwatch();
        stopwatch3.Start();
        TimeSpan duration = TimeSpan.FromSeconds(_duration);
        int _counter = 0;
        while (stopwatch3.Elapsed < duration)
        {
            Console.ReadLine();
            _counter += 1;
        }

        Console.WriteLine();

        Console.WriteLine($"You listed {_counter} items!");
        
    }
}
