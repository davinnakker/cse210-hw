using System.Net;
using System.Runtime.CompilerServices;

public class ExpenseManager
{
    private List<Expense> _expenses;
    private double _monthlyTotal;
    private double _annualTotal;

    public ExpenseManager()
    {
        _expenses = new List<Expense>();
    }
    public void AddExpenses()
    {
        string addExpenseMenu = """
        -----------------------------------------------------------
        Which kind of Expense would you like to add?
        1. Monthly
        2. Annual
        3. MultiMonthly
        -----------------------------------------------------------
        Select an option or press Enter to go back to menu: 
        -----------------------------------------------------------
        """;
        Console.Clear();
        Console.WriteLine(addExpenseMenu);
        string str_response = Console.ReadLine();
        if (str_response != "")
        {
            int response = int.Parse(str_response);
            if (response == 1)
            {
                MonthlyExpense monthly = new MonthlyExpense();
                _expenses.Add(monthly);
            }
            else if (response == 2)
            {
                AnnualExpense annual = new AnnualExpense();
                _expenses.Add(annual);
            }
            else if (response == 3)
            {
                MultiMonthlyExpense multi = new MultiMonthlyExpense();
                _expenses.Add(multi);
            }
        }
    }
    public void ViewExpenses()
    {
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine("Your expense are:");
        Console.WriteLine("-------------------------------------------------------");
        foreach (var(index, expense) in _expenses.Index())
        {
            Console.WriteLine($"{index + 1}.\n{expense.GetInfo()}");
            Console.WriteLine();
        }
        Console.WriteLine("-------------------------------------------------------");
    }
    public double CalculateMonthlyTotal()
    {
        double total = 0;
        foreach (Expense expense in _expenses)
        {
            total = total + expense.CalculateMonthlyTotal();
        }
        _monthlyTotal = total;
        return _monthlyTotal;
    }
    public double CalculateAnnualTotal()
    {
        double total = 0;
        foreach (Expense expense in _expenses)
        {
            total = total + expense.CalculateAnnualTotal();
        }
        _annualTotal = total;
        return _annualTotal;
    }
    public void ViewExpenseReport()
    {
        Console.Clear();
        ViewExpenses();
        CalculateMonthlyTotal();
        Console.WriteLine($"Your Total Monthly Expenses are ${_monthlyTotal}");
        Console.WriteLine("-------------------------------------------------------");
        Console.WriteLine();
        Console.ReadLine();
    }
    public void DeleteExpenses()
    {
        Console.Clear();
        ViewExpenses();
        Console.Write("Which Expense would you like to delete? ");
        Console.WriteLine("-------------------------------------------------------");
        int response = int.Parse(Console.ReadLine());
        response --;
        _expenses.RemoveAt(response);
    }
    public void Menu()
    {
        string response = "0";

        string menu = """
        ----------------------------------------------------------------------
        1. Add Expense
        2. Delete Expense
        3. View Expenses
        ----------------------------------------------------------------------
        Select your option or enter space to go back to the menu
        ----------------------------------------------------------------------
        """;
        while (response != " ")
        {
            Console.Clear();
            Console.WriteLine(menu);
            response = Console.ReadLine();
            if (response == "1")
            {
                AddExpenses();
            }
            else if (response == "2")
            {
                DeleteExpenses();
            }
            else if (response == "3")
            {
                ViewExpenseReport();
            }
        }
    }
}