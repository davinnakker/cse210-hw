using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public abstract class Goal
{
    private string _name;
    private string _description;
    private int _points;

    public Goal()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        _name = name;
        Console.Write("What is a short description of it? ");
        string description = Console.ReadLine();
        _description = description;
        _points = 0;
    }
    public void SetPoints(int points)
    {
        _points = points;
    }
    public int GetPoint()
    {
        return _points;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetDescription()
    {
        return _description;
    }
    public abstract int GetPoints();

    public abstract void Complete();

    public virtual void Display()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }
    
}