using System.Net;
using System.Runtime.CompilerServices;
public class IncomeManager
{
    private List<IncomeSource> _incomeSources;
    private double _monthlyTotal;
    private double _annualTotal;

    public IncomeManager()
    {
        _incomeSources = new List<IncomeSource>();
    }
    public void AddIncomeSource()
    {
        string addIncomeMenu = """
        Which kind of Income Source would you like to add?
        1. Hourly
        2. Salary Bases

        Select an option or press Enter to go back to menu: 
        """;
        Console.Clear();
        Console.Write(addIncomeMenu);
        string str_response = Console.ReadLine();
        if (str_response != "")
        {
            int response = int.Parse(str_response);
            if (response == 1)
            {
                HourlyIncome hourly = new HourlyIncome();
                _incomeSources.Add(hourly);
            }
            else if (response == 2)
            {
                AnnualIncome annual = new AnnualIncome();
                _incomeSources.Add(annual);
            }
        }
    }
    public void ViewIncomeSources()
    {
        Console.WriteLine("Your income sources are:\n");
        foreach (var(index, income) in _incomeSources.Index())
        {
            Console.WriteLine($"{index + 1}.\n{income.GetInfo()}");
            Console.WriteLine();
        }
    }
    public double CalculateMonthlyTotal()
    {
        double total = 0;
        foreach (IncomeSource income in _incomeSources)
        {
            total = total + income.CalculateMonthlyTotal();
        }
        _monthlyTotal = total;
        return _monthlyTotal;
    }
    public double CalculateAnnualTotal()
    {
        double total = 0;
        foreach (IncomeSource income in _incomeSources)
        {
            total = total + income.CalculateAnnualTotal();
        }
        _annualTotal = total;
        return _annualTotal;
    }
    public void ViewIncomeReport()
    {
        Console.Clear();
        ViewIncomeSources();
        CalculateMonthlyTotal();
        Console.WriteLine($"\nYour Total Monthly Income Sources are ${_monthlyTotal}");
        Console.WriteLine();
        Console.ReadLine();
    }
    public void DeleteIncomeSource()
    {
        Console.Clear();
        ViewIncomeSources();
        Console.Write("Which Income Source would you like to delete? ");
        int response = int.Parse(Console.ReadLine());
        response --;
        _incomeSources.RemoveAt(response);
    }
    public void Menu()
    {
        string response = "0";

        string menu = """
        1. Add Income Source
        2. Delete Income Source
        3. View Incomes Sources

        Select your option or enter space to go back to the menu
        """;
        while (response != " ")
        {
            Console.Clear();
            Console.WriteLine(menu);
            response = Console.ReadLine();
            if (response == "1")
            {
                AddIncomeSource();
            }
            else if (response == "2")
            {
                DeleteIncomeSource();
            }
            else if (response == "3")
            {
                ViewIncomeReport();
            }
        }
    }
}
