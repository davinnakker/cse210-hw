public class HourlyIncome : IncomeSource
{
    protected int _hoursPerWeek;
    public HourlyIncome() : base()
    {
        Console.Write("How hours do you work a week? ");
        _hoursPerWeek = int.Parse(Console.ReadLine());
    }
    public override double CalculateMonthlyTotal()
    {
        return 4.3 * _amount * _hoursPerWeek;
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
        ${CalculateMonthlyTotal} a month
        """;
        return info;
    }
}