public class EternalGoal : Goal
{
    private int _timesCompleted;
    public EternalGoal() : base()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
        _timesCompleted = 0;
    }

    public override int GetPoints()
    {
        return _timesCompleted * GetPoint();
    }

    public override void Complete()
    {
        _timesCompleted ++;
    }


}