using System;
using System.IO; 


class Program
{
    static void Main(string[] args)
    {
        string _userChoice = "0";
        Console.WriteLine();

        Console.WriteLine("Welcome to the Journal Program!");

        while (_userChoice != "5")
        {
            
            Console.WriteLine();

            Console.WriteLine("Please select one of the following choices: ");

            Console.WriteLine();

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.WriteLine();

            Console.WriteLine("What would you like to do?: ");
            _userChoice = Console.ReadLine();

            if (_userChoice == "1")
            {
                Entry CreateEntry();
            }
            else if (_userChoice == "2")
            {
                Entry DisplayEntry();
            }
            else if (_userChoice == "3")
            {
                Journal LoadFile();
            }
            else if (_userChoice == "4")
            {
                Journal SaveFile();
            }
            else if (_userChoice == "5")
            {
                break;
            }
        }
    }
}

public class Entry
{
    public CreateEntry(string[] args)
    {
        public List<string> JournalList = new List<string>();
        public string _prompt;
        public string _userResponse;
        public DateTime _today;

        PromptGenerator RandomPrompt = Prompt();
        _prompt = Prompt();
        Console.WriteLine(_prompt);
        _userResponse = Console.ReadLine();
        _today = DateTime.Today;
        JournalList.Add($"Date: {_today} - Prompt: {_prompt} - {_userResponse}");
    }

    public  DisplayEntry(string args)
    {
        public string _response;
        
        foreach (_response in JournalList)
        {
            Console.WriteLine(_response);
        }
    }
}


public class Journal
{
    public LoadFile(string[] args)
    {
        public string path;

        path = "myJournal.txt";

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
    
    public SaveFile(string[] args)
    {   
        public string fileName;

        fileName = "myJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(JournalList);
        }
    }
}

public class PromptGenerator
{
    public RandomPrompt(string[] args)
    {
        
        string[] _promptsList = {
            "What was the most interesting thing that happened to me today?",
            "What was my favorite moment today?",
            "What new thing did I learn today?",
            "What blessings did I receive today?",
            "How was my mood today?",
            "How did I have fun today?",
            "What did I do productive today?",
            "What people did I talk to today?",
            "What was my favorite food today?",
            "What things did I do wrong today?"
        };
        
        Random _random = new Random();
        int index = _random.Next(_promptsList.Length);
        string _randomPrompt = _promptsList[index];
        Console.WriteLine($"{_randomPrompt}");

    }

}