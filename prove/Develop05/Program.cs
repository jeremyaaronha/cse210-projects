using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalsList = new List<Goal>();
        int _menuChoice = 0;
        int _totalPoints = 0;
        int _userLevel = 1;

        do
        {


            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine();
            Console.WriteLine($"You have {_totalPoints} total points."); 
 
            int _newLevel = _totalPoints / 500 + 1;
            if (_newLevel > _userLevel)
            {
                int _levelsGained = _newLevel - _userLevel;
                _userLevel = _newLevel;
                Console.WriteLine();
                Console.WriteLine($"Congratulations, you have leveled up to level {_userLevel}!");
                Console.WriteLine();                
                if (_levelsGained > 1)
                {
                    Console.WriteLine();
                    Console.WriteLine($"You have gained {_levelsGained} levels!");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"You are level {_userLevel}");  
            Console.WriteLine();   
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. See Goals");
            Console.WriteLine("3. Save Goals to File");
            Console.WriteLine("4. Load Goals from File");
            Console.WriteLine("5. Mark Goal as Completed");
            Console.WriteLine("6. Quit");
            Console.WriteLine();

            Console.Write("Enter option: ");
            int.TryParse(Console.ReadLine(), out _menuChoice);
            Console.Clear();

            switch (_menuChoice)
            {
                case 1:
                    Console.WriteLine("The types of goals are: ");
                    Console.WriteLine(" 1. Simple Goal");
                    Console.WriteLine(" 2. Eternal Goal");
                    Console.WriteLine(" 3. Checklist Goal");
                    Console.WriteLine();
                    Console.Write("Wich type of goal would you like to create?: ");
                    int _goalTypeMenu;
                    if (!int.TryParse(Console.ReadLine(), out _goalTypeMenu))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Invalid option!");
                        break;
                    }
                    switch (_goalTypeMenu)
                    {
                        case 1:
                            Console.Write("Enter goal name: ");
                            string _name = Console.ReadLine();
                            Console.Write("Enter goal description: ");
                            string _description = Console.ReadLine();
                            Console.Write("Enter goal points: ");
                            int _points;
                            if (!int.TryParse(Console.ReadLine(), out _points))
                            {
                                Console.WriteLine("Invalid points value!");
                                break;
                            }
                            SimpleGoal _simpleGoal = new SimpleGoal(_name, _description, _points, false);
                            goalsList.Add(_simpleGoal);
                            Console.WriteLine("Simple Goal created and added to the list.");
                            break;
                        case 2:
                            Console.Write("Enter goal name: ");
                            string _name2 = Console.ReadLine();
                            Console.Write("Enter goal description: ");
                            string _description2 = Console.ReadLine();
                            Console.Write("Enter goal points: ");
                            int _points2;
                            if (!int.TryParse(Console.ReadLine(), out _points2))
                            {
                                Console.WriteLine("Invalid points value!");
                                break;
                            }
                            EternalGoal _eternalGoal = new EternalGoal(_name2, _description2, _points2);
                            goalsList.Add(_eternalGoal);
                            Console.WriteLine("Eternal Goal created and added to the list.");
                            break;
                        case 3:
                            Console.Write("Enter goal name: ");
                            string _name3 = Console.ReadLine();
                            Console.Write("Enter goal description: ");
                            string _description3 = Console.ReadLine();
                            Console.Write("Enter goal points: ");
                            int _points3;
                            if (!int.TryParse(Console.ReadLine(), out _points3))
                            {
                                Console.WriteLine("Invalid points value!");
                                break;
                            }
                            Console.WriteLine("How many times this goal need to be done to be mark as completed?: ");
                            int _timesCompleted = 0;
                            int _timesToComplete;
                            if (!int.TryParse(Console.ReadLine(), out _timesToComplete))
                            {
                                Console.WriteLine("Invalid value!");
                            }
                            bool _completed = false; 
                            Console.WriteLine("How many bonus points for complete the goal that many times?: ");
                            int _bonusPoints;
                            if (!int.TryParse(Console.ReadLine(), out _bonusPoints))
                            {
                                Console.WriteLine("Invalid value!");
                                break;
                            }
                            ChecklistGoal _checklistGoal = new ChecklistGoal(_name3, _description3, _points3, _completed,_timesCompleted, _timesToComplete, _bonusPoints);
                            goalsList.Add(_checklistGoal);
                            Console.WriteLine("Checklist Goal created and added to the list.");
                            
                            break;
                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                    break;
                case 2:
                    Console.WriteLine();
                    Console.WriteLine("Goals List:");
                    Console.WriteLine();

                    foreach (Goal _goal in goalsList)
                    {
                        Console.WriteLine(_goal.ToString());
                    }
                    break;
                case 3:
                    Console.Write("Enter the file name: ");
                    string _filePath = Console.ReadLine();
                    try
                    {
                        using (StreamWriter _sw = new StreamWriter(_filePath))
                        {
                            foreach (Goal _goal in goalsList)
                            {
                                _sw.WriteLine(_goal.ToString());
                            }
                            _sw.WriteLine(_totalPoints);
                            Console.WriteLine("Goals saved to file.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred while saving goals to file: {ex.Message}");
                    }
                    break;
                case 4:
                    List<Goal> _loadedGoals = new List<Goal>();

                    Console.Write("Enter the file name: ");
                    string _filePath2 = Console.ReadLine();
                    try
                    {
                        using (StreamReader sr = new StreamReader(_filePath2))
                        {
                            string _line;
                            while ((_line = sr.ReadLine()) != null)
                            {

                                if (_line.Contains("-"))
                                {
                                    _line = _line.Replace("Completed","true");
                                    _line = _line.Replace("Incomplete","false");   
                                    string[] _parts = _line.Split('-');                                 
                                    string _goalType = _parts[0];
                                    string _name = _parts[1];
                                    string _description = _parts[2];
                                    int _points = int.Parse(_parts[3].Split(": ")[1]);

                                    Goal _goal = null;
                                    switch (_goalType)
                                    {
                                        case "Simple Goal ":
                                            bool _isCompleted = bool.Parse(_parts[4]);
                                            SimpleGoal simpleGoal = new SimpleGoal(_name,_description,_points,_isCompleted);
                                            _loadedGoals.Add(simpleGoal);
                                            break;
                                        case "Eternal Goal ":
                                            EternalGoal eternalGoal = new EternalGoal(_name,_description,_points);
                                            _loadedGoals.Add(eternalGoal);
                                            break;
                                        case "Checklist Goal ":
                                            bool _isCompleted2 = bool.Parse(_parts[4]);

                                            int _timesCompleted = int.Parse(_parts[5].Split("/")[0]);
                                            int _timesToComplete = int.Parse(_parts[5].Split("/")[1]);
                                            int _bonusPoints = int.Parse(_parts[6].Split(": ")[1]);
                                            ChecklistGoal checklistGoal = new ChecklistGoal(_name, _description, _points, _isCompleted2, _timesCompleted, _timesToComplete, _bonusPoints);
                                            _loadedGoals.Add(checklistGoal);
                                            break;
                                    }
                                }
                                else
                                    _totalPoints = int.Parse(_line);

                            }
                        }
                        goalsList = _loadedGoals;

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"An error occurred while loading goals from file: {ex.Message}");
                    }
                    break;
                case 5: 
                    Console.WriteLine();
                    Console.WriteLine("Select a goal to mark as completed:");
                    for (int i = 0; i < goalsList.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {goalsList[i]}");
                    }
                    Console.Write("Enter goal number: ");
                    string goalNumberStr = Console.ReadLine();
                    if (!int.TryParse(goalNumberStr, out int goalNumber) || goalNumber < 1 || goalNumber > goalsList.Count)
                    {
                        Console.WriteLine("Invalid goal number!");
                        break;
                    }

                    Goal selectedGoal = goalsList[goalNumber - 1];
                    _totalPoints += selectedGoal.MarkAsCompleted();
                    break;
                case 6:
                    break;
                default:
                    Console.WriteLine();
                    Console.WriteLine("Please, select a valid option.");
                    break;
            } 
        } while (_menuChoice != 6);
    }
}    
public class Goal
{
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;
    protected string _completedString;

    public Goal(string name, string description, int points, bool completed)
    {
        this._name = name;
        this._description = description;
        this._points = points;
        this._completed = completed;
    }

    public virtual int MarkAsCompleted()
    {
        return 0;
    }

    public override string ToString()
    {
        string _completedStr = _completed ? "true" : "false";
        return $"{_name} | ({_description}) | {_points} | ({_completedStr})";
    }
}

class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool completed)
        : base(name, description, points, completed)
    {
    }

    public override int MarkAsCompleted()
    {
        if (!_completed)
        {
            _completed = true;
            Console.WriteLine();
            Console.WriteLine($"Marked {_name} as completed!");
            Console.WriteLine();
            Console.WriteLine($"You have earned {_points} points!");
            return _points;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"{_name} is already completed!");
            return 0;
        }
    }
    public override string ToString()
    {
        if (_completed)
        {
            _completedString = "Completed";
        }
        else
        {
            _completedString = "Incomplete";
        }
        return $"Simple Goal - {_name} - {_description} - Points: {_points} - {_completedString}";
    }
}

class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points, false)
    {
    }

    public override int MarkAsCompleted()
    {
        Console.WriteLine();
        Console.WriteLine($"Marked {_name} as completed!");
        Console.WriteLine();
        Console.WriteLine($"You have earned {_points} points!");
        return _points;
    }
    public override string ToString()
    {
        if (_completed)
        {
            _completedString = "Completed";
        }
        else
        {
            _completedString = "Incomplete";
        }
        return $"Eternal Goal - {_name} - {_description} - Points: {_points} - {_completedString}";
    }
}

class ChecklistGoal : Goal
{
    private int _timesCompleted;
    private int _timesToComplete;
    private int _bonusPoints;

    public ChecklistGoal(string name, string description, int points, bool completed, int timesCompleted, int timesToComplete, int bonusPoints)
        : base(name, description, points, completed)
    {
        this._timesCompleted = timesCompleted;
        this._timesToComplete = timesToComplete;
        this._bonusPoints = bonusPoints;
        this._completed = completed;

    }

    public override int MarkAsCompleted()
    {
        if (_completed)
        {
            Console.WriteLine();
            Console.WriteLine($"{_name} is already completed!");
            return 0;
        }

        _timesCompleted += 1;
        if (_timesCompleted >= _timesToComplete)
        {
            _completed = true;
            Console.WriteLine();
            Console.WriteLine($"Marked {_name} as completed!");
            Console.WriteLine();
            Console.WriteLine($"You have earned {_points} points!");
            Console.WriteLine($"You have earned {_bonusPoints} bonus points!");
            _points += _bonusPoints;
            return _points;
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine($"Completed {_timesCompleted}/{_timesToComplete} times");
            Console.WriteLine();
            Console.WriteLine($"You have earned {_points} points!");
            return _points;
        }
    }

    public override string ToString()
    {
        if (_completed)
        {
            _completedString = "Completed";
        }
        else
        {
            _completedString = "Incomplete";
        }
        
        return $"Checklist Goal - {_name} - {_description} - Points: {_points} - {_completedString} - {_timesCompleted}/{_timesToComplete} - Bonus Points: {_bonusPoints}";
    }
}
