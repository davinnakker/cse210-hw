using System.Net;

public class Menu
{
    private int _points;
    private List<Goal> _goals;

    public Menu()
    {
        _goals = new List<Goal>();
        _points = 0;
    }

    private int CalculatePoints()
    {
        _points = 0;
        foreach (Goal goal in _goals)
        {
            _points = _points + goal.GetPoints();
        }
        return _points;
    }

    public void CreateGoal()
    {
        string options = """
        The types of Goals are:
            1. Simple Goal
            2. Eternal Goal
            3. Checklist Goal
        Which type of goal would you like to create? 
        """;
        Console.Write(options);
        string response = Console.ReadLine();
        if (response == "1")
        {
            SimpleGoal simple = new SimpleGoal();
            _goals.Add(simple);
        }
        else if (response == "2")
        {
            EternalGoal eternal = new EternalGoal();
            _goals.Add(eternal);
        }
        else if (response == "3")
        {
            ChecklistGoal checklist = new ChecklistGoal();
            _goals.Add(checklist);
        }
    }

    public void ListGoals()
    {
        foreach (var (index, goal) in _goals.Index())
        {
            Console.Write($"{index + 1}. ");
            goal.Display();
        }
    }

    public void RecordEvent()
    {
        ListGoals();
        Console.Write("Which goal did you accomplish? ");
        int selection = int.Parse(Console.ReadLine());
        selection --;
        _goals[selection].Complete();
        Console.WriteLine($"Congratulations! You have earned {_goals[selection].GetPoint()} points!");
        Console.WriteLine($"You now have {CalculatePoints()} points.\n");
    }

    public void MenuLoop()
    {
        int response = 0;
        while (response != 6)
        {
            Console.WriteLine($"Total Points: {CalculatePoints()}\n");
            string menuPage = """
            
            Menu Options:
                1. Create New Goal
                2. List Goals
                3. Save Goals
                4. Load Goals
                5. Record Event
                6. Quit
            Select a choice from the menu:
            """;
            Console.Write(menuPage + " ");
            response = int.Parse(Console.ReadLine());

            if (response == 1)
            {
                CreateGoal();
            }
            else if (response == 2)
            {
                ListGoals();
            }
            else if (response == 3)
            {
                
            }
            else if (response == 4)
            {
                
            }
            else if (response == 5)
            {
                RecordEvent();
            }
            else if (response == 6)
            {
                break;
            }
        }
    }
}