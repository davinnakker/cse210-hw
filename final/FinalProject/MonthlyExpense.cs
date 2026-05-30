public class MonthlyExpense : Expense
{
    public override double CalculateMonthlyTotal()
    {
        return _amount;
    }
    public override double CalculateAnnualTotal()
    {
        return _amount * 12;
    }
    public override string GetInfo()
    {
        string info = $"""
        {_name}: {_description}
        ${_amount} a month
        """;
        return info;
    }
}