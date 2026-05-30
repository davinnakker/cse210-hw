using System.Net;

public class App
{
    ExpenseManager _expenseManager;
    IncomeManager _incomeManager;
    BudgetAdvisor _budgetAdvisor;

    public App()
    {
        Console.WriteLine("Welcome to the Budgeting App! Lets get started!");
        _expenseManager = new ExpenseManager();
        _incomeManager = new IncomeManager();
        _budgetAdvisor = new BudgetAdvisor();
    }
    public void GetCashflowReport()
    {
        _incomeManager.ViewIncomeReport();
        _expenseManager.ViewExpenseReport();
        double income = _incomeManager.CalculateMonthlyTotal();
        double expenses = _expenseManager.CalculateMonthlyTotal();
        double totalCashflow = income = expenses;
        Console.WriteLine($"Your total monthly cashflow is: {totalCashflow}");
        Console.ReadLine();
    }
    public void Menu()
    {
        string menu = $"""
        What would you like to do today?

        1. Edit Expenses
        2. Edit Income
        3. View Cashflow Report

        Select an option or type quit to end: 
        """;
        string response = " ";
        while (response != "quit")
        {
            Console.Clear();
            Console.WriteLine(menu);
            response = Console.ReadLine();
            if (response == "1")
            {
                _expenseManager.Menu();
            }
            else if (response == "2")
            {
                _incomeManager.Menu();
            }
            else if (response == "3")
            {
                GetCashflowReport();
            }
        }
    }
}