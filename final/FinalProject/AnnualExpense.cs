public class AnnualExpense : Expense
{
    public override double CalculateMonthlyTotal()
    {
        return _amount / 12;
    }
    public override double CalculateAnnualTotal()
    {
        return _amount;
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