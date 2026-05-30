public class MultiMonthlyExpense : Expense
{
    protected int _timesPerMonth;
    public MultiMonthlyExpense() : base()
    {
        Console.Write("How many times a month to you pay this? ");
        _timesPerMonth = int.Parse(Console.ReadLine());
    }
    public override double CalculateMonthlyTotal()
    {
        return _amount * _timesPerMonth;
    }
    public override double CalculateAnnualTotal()
    {
        double monthly = CalculateMonthlyTotal();
        return monthly * 12;
    }
    public override string GetInfo()
    {
        string info = $"""
        {_name}: {_description}
        ${CalculateMonthlyTotal()} a month
        """;
        return info;
    }
}