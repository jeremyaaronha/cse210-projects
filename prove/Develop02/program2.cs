using System;
using System.IO;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        string _userChoice = "0";
        Console.WriteLine();

        Console.WriteLine("Welcome to the Journal Program!");

        List<string> JournalList = new List<string>();

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
                new Entry().CreateEntry(JournalList);
            }
            else if (_userChoice == "2")
            {
                new Entry().DisplayEntry(JournalList);
            }
            else if (_userChoice == "3")
            {
                new Journal().LoadFile(JournalList);
            }
            else if (_userChoice == "4")
            {
                new Journal().SaveFile(JournalList);
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
    public void CreateEntry(List<string> JournalList)
    {

        string _prompt;
        string _userResponse;
        DateTime _today;

        _prompt = new PromptGenerator().Prompt();
        Console.WriteLine(_prompt);
        _userResponse = Console.ReadLine();
        _today = DateTime.Today;
        Console.WriteLine(_prompt);
        JournalList.Add($"Date: {_today} - Prompt: {_prompt} - {_userResponse}");
    }

    public void DisplayEntry(List<string> JournalList)
    {
        string _response;
        
        foreach (string entry in JournalList)
        {
            Console.WriteLine(entry);
        }
    }
}


public class Journal
{
    public void LoadFile(List<string> JournalList)
    {
        string path;

        path = "myJournal.txt";

        if (File.Exists(path))
        {
            string[] lines = File.ReadAllLines(path);
            foreach (string _response in lines)
            {
                Console.WriteLine(_response);
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
    
    public void SaveFile(List<string> JournalList)
    {   
        string fileName;

        fileName = "myJournal.txt";

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach(string entry in JournalList)
            {
                outputFile.WriteLine(entry);
            }
            outputFile.Close();
        }
    }
}

public class PromptGenerator
{
    public string Prompt()
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
        return _randomPrompt;

    }

}