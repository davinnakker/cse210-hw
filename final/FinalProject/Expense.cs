public abstract class Expense
{
    protected string _name;
    protected string _description;
    protected double _amount;

    public Expense()
    {
        Console.Clear();
        Console.Write("What is the name of the expense? ");
        _name = Console.ReadLine();
        Console.Write("Give a description of the expense: ");
        _description = Console.ReadLine();
        Console.Write("How much is the payment? ");
        _amount = double.Parse(Console.ReadLine());
    }

    public abstract string GetInfo();
    public abstract double CalculateMonthlyTotal();
    public abstract double CalculateAnnualTotal();
}