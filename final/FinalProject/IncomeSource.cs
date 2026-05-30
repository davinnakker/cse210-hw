public abstract class IncomeSource
{
    protected string _name;
    protected string _description;
    protected double _amount;

    public IncomeSource()
    {
        Console.Clear();
        Console.Write("What is the name of this type of income? ");
        _name = Console.ReadLine();
        Console.Write("Give a description of income source: ");
        _description = Console.ReadLine();
        Console.Write("How much are you payed? ");
        _amount = double.Parse(Console.ReadLine());
    }

    public abstract string GetInfo();
    public abstract double CalculateMonthlyTotal();
    public abstract double CalculateAnnualTotal();
}