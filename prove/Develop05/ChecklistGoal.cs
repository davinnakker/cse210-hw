public class ChecklistGoal : Goal
{
    private int _bonusNumber;
    private int _bonusPoints;
    private int _timesCompleted;
    private bool _bonusComplete;
    public ChecklistGoal()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        _bonusNumber = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus for accomplishing it that many times? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        _timesCompleted = 0;
        _bonusComplete = false;
    }

    public override void Complete()
    {
        _timesCompleted ++;
        if (_timesCompleted == _bonusNumber)
        {
            _bonusComplete = true;
        }
    }

    public override int GetPoints()
    {
        int points = 0;
        if (_bonusComplete == true)
        {
            points = _bonusPoints;
        }
        return points + (_timesCompleted * GetPoint());
    }
}