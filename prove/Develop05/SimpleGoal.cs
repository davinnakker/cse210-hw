public class SimpleGoal : Goal
{
    private bool _completed;

    public SimpleGoal() : base()
    {
        Console.Write("What is the amount of points associated with this goal? ");
        int points = int.Parse(Console.ReadLine());
        SetPoints(points);
        _completed = false;
    }
    public override void Complete()
    {
        _completed = true;
    }

    public override int GetPoints()
    {
        if (_completed == true)
        {
            return GetPoint();
        }
        else
        {
            return 0;
        }
    }
}